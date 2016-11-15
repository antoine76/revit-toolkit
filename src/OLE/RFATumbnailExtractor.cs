﻿using System;
using System.Drawing;
using System.IO;
using CodeCave.CAD.Toolkit;

namespace CodeCave.Revit.Toolkit.OLE
{
    /// <summary>
    /// Utility class for Revit (.rfa, .rvt etc) thumbnail creation
    /// Inspired by Jeremy Tammik's post on The Building Coder website
    /// http://thebuildingcoder.typepad.com/blog/2008/10/rvt-file-version.html
    /// </summary>
    /// <seealso cref="ThumbnailExtractor" />
    public class RFATumbnailExtractor : ThumbnailExtractor
    {
        /// <summary>
        /// Extracts the image.
        /// </summary>
        /// <param name="pathToFile">The path to file.</param>
        /// <returns>
        /// Image object
        /// </returns>
        /// <exception cref="InvalidDataException">Failed to extract the thumbnail of the following Revit file: {pathToFile}</exception>
        public override Image ExtractImage(string pathToFile)
        {
            try
            {
                var thumbnailBytes = OleDataReader.GetRawBytes(pathToFile, RevitFile.OleStorage.IMAGE_STREAM);
                // Validate preview data or go out
                if ((thumbnailBytes == null) || (thumbnailBytes.Length <= 0))
                {
                    return null;
                }

                // read past the Revit metadata to the start of the PNG image
                var startingOffset = GetPngOffset(thumbnailBytes);
                if (startingOffset == 0)
                {
                    return null;
                }

                var previewUpperBound = thumbnailBytes.GetUpperBound(0);
                var pngDataBuffer = new byte[previewUpperBound - startingOffset + 1];

                using (var ms = new MemoryStream(thumbnailBytes))
                {
                    ms.Position = startingOffset;
                    ms.Read(pngDataBuffer, 0, pngDataBuffer.Length);

                    // read the PNG image data into a byte array
                    using (var msi = new MemoryStream(pngDataBuffer))
                    {
                        using (var img = Image.FromStream(msi))
                        {
                            return img.Clone() as Image;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new InvalidDataException($"Failed to extract the thumbnail of the following Revit file \"{pathToFile}\"", ex);
            }
        }

        #region Helpers


        /// <summary>
        /// Gets the PNG data offset in array of bytes.
        /// </summary>
        /// <param name="thumbnailBytes">Thumbnail bytes.</param>
        /// <returns></returns>
        private static int GetPngOffset(byte[] thumbnailBytes)
        {
            var markerFound = false;
            var startingOffset = 0;
            var previousValue = 0;

            using (var memoryStream = new MemoryStream(thumbnailBytes))
            {
                for (var i = 0; i < thumbnailBytes.Length; i++)
                {
                    var pointer = memoryStream.ReadByte();
                    // possible start of PNG file data
                    if (pointer == RevitFile.PngImageMarker.MARKER_137) // 0x89
                    {
                        markerFound = true;
                        startingOffset = i;
                        previousValue = pointer;
                        continue;
                    }

                    switch (pointer)
                    {
                        case RevitFile.PngImageMarker.MARKER_10: // 0x0A
                            if (markerFound && (previousValue == RevitFile.PngImageMarker.MARKER_26))
                            {
                                return startingOffset;
                            }
                            if (markerFound && (previousValue == RevitFile.PngImageMarker.MARKER_13))
                            {
                                previousValue = pointer;
                                continue;
                            }
                            markerFound = false;
                            break;

                        case RevitFile.PngImageMarker.MARKER_13: // 0x0D
                            if (markerFound && (previousValue == RevitFile.PngImageMarker.MARKER_71))
                            {
                                previousValue = pointer;
                                continue;
                            }
                            markerFound = false;
                            break;

                        case RevitFile.PngImageMarker.MARKER_26: // 0x1A
                            if (markerFound && (previousValue == RevitFile.PngImageMarker.MARKER_10))
                            {
                                previousValue = pointer;
                                continue;
                            }
                            markerFound = false;
                            break;

                        case RevitFile.PngImageMarker.MARKER_71: // 0x47
                            if (markerFound && (previousValue == RevitFile.PngImageMarker.MARKER_78))
                            {
                                previousValue = pointer;
                                continue;
                            }
                            markerFound = false;
                            break;

                        case RevitFile.PngImageMarker.MARKER_78: // 0x4E
                            if (markerFound && (previousValue == RevitFile.PngImageMarker.MARKER_80))
                            {
                                previousValue = pointer;
                                continue;
                            }
                            markerFound = false;
                            break;

                        case RevitFile.PngImageMarker.MARKER_80: // 0x50
                            if (markerFound && (previousValue == RevitFile.PngImageMarker.MARKER_137))
                            {
                                previousValue = pointer;
                                continue;
                            }
                            markerFound = false;
                            break;
                    }
                }
            }
            return 0;
        }

        #endregion

        internal struct RevitFile
        {
            internal struct OleStorage
            {
                public const string IMAGE_STREAM = "RevitPreview4.0";
            }

            internal struct PngImageMarker
            {
                public const int MARKER_10 = 10;  // 0x0A
                public const int MARKER_13 = 13;  // 0x0D
                public const int MARKER_26 = 26;  // 0x1A
                public const int MARKER_71 = 71;  // 0x47
                public const int MARKER_78 = 78;  // 0x4E
                public const int MARKER_80 = 80;  // 0x50
                public const int MARKER_137 = 137; // 0x89
            }
        }
    }
}