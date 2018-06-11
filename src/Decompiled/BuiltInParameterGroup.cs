using System.Collections.Generic;
using System.Linq;

#pragma warning disable 1591

namespace CodeCave.Revit.Toolkit
{
    /// <summary>An enumerated type listing all of the built-in parameter groups supported by Autodesk Revit.</summary>
    /// <remarks>Parameter groups are used to sort parameters within the Element Properties dialog.</remarks>
    // Decompiled with JetBrains decompiler
    // Type: Autodesk.Revit.DB.BuiltInParameterGroup
    // Assembly: RevitAPI, Version=17.0.0.0, Culture=neutral, PublicKeyToken=null
    // ReSharper disable InconsistentNaming
    public enum BuiltInParameterGroup
    {
        PG_ENERGY_ANALYSIS_BLDG_CONS_MTL_THERMAL_PROPS = -5000221,
        PG_ENERGY_ANALYSIS_ROOM_SPACE_DATA = -5000220,
        PG_ENERGY_ANALYSIS_BUILDING_DATA = -5000219,
        PG_COUPLER_ARRAY = -5000218,
        PG_ENERGY_ANALYSIS_ADVANCED = -5000217,
        PG_RELEASES_MEMBER_FORCES = -5000216,
        PG_SECONDARY_END = -5000214,
        PG_PRIMARY_END = -5000213,
        PG_MOMENTS = -5000212,
        PG_FORCES = -5000211,
        PG_FABRICATION_PRODUCT_DATA = -5000210,
        PG_REFERENCE = -5000208,
        PG_GEOMETRY_POSITIONING = -5000207,
        PG_DIVISION_GEOMETRY = -5000206,
        PG_SEGMENTS_FITTINGS = -5000205,
        PG_CONTINUOUSRAIL_END_TOP_EXTENSION = -5000204,
        PG_CONTINUOUSRAIL_BEGIN_BOTTOM_EXTENSION = -5000203,
        PG_STAIRS_WINDERS = -5000202,
        PG_STAIRS_SUPPORTS = -5000201,
        PG_STAIRS_OPEN_END_CONNECTION = -5000200,
        PG_RAILING_SYSTEM_SECONDARY_FAMILY_HANDRAILS = -5000199,
        PG_TERMINTATION = -5000198,
        PG_STAIRS_TREADS_RISERS = -5000197,
        PG_STAIRS_CALCULATOR_RULES = -5000196,
        PG_SPLIT_PROFILE_DIMENSIONS = -5000195,
        PG_LENGTH = -5000194,
        PG_NODES = -5000193,
        PG_ANALYTICAL_PROPERTIES = -5000192,
        PG_ANALYTICAL_ALIGNMENT = -5000191,
        PG_SYSTEMTYPE_RISEDROP = -5000190,
        PG_LINING = -5000189,
        PG_INSULATION = -5000188,
        PG_OVERALL_LEGEND = -5000187,
        PG_VISIBILITY = -5000186,
        PG_SUPPORT = -5000185,
        PG_RAILING_SYSTEM_SEGMENT_V_GRID = -5000184,
        PG_RAILING_SYSTEM_SEGMENT_U_GRID = -5000183,
        PG_RAILING_SYSTEM_SEGMENT_POSTS = -5000182,
        PG_RAILING_SYSTEM_SEGMENT_PATTERN_REMAINDER = -5000181,
        PG_RAILING_SYSTEM_SEGMENT_PATTERN_REPEAT = -5000180,
        PG_RAILING_SYSTEM_FAMILY_SEGMENT_PATTERN = -5000179,
        PG_RAILING_SYSTEM_FAMILY_HANDRAILS = -5000178,
        PG_RAILING_SYSTEM_FAMILY_TOP_RAIL = -5000177,
        PG_CONCEPTUAL_ENERGY_DATA_BUILDING_SERVICES = -5000176,
        PG_DATA = -5000175,
        PG_ELECTRICAL_CIRCUITING = -5000174,
        PG_GENERAL = -5000173,
        PG_FLEXIBLE = -5000172,
        PG_ENERGY_ANALYSIS_CONCEPTUAL_MODEL = -5000171,
        PG_ENERGY_ANALYSIS_DETAILED_MODEL = -5000170,
        PG_ENERGY_ANALYSIS_DETAILED_AND_CONCEPTUAL_MODELS = -5000169,
        PG_FITTING = -5000168,
        PG_CONCEPTUAL_ENERGY_DATA = -5000167,
        PG_AREA = -5000166,
        PG_ADSK_MODEL_PROPERTIES = -5000165,
        PG_CURTAIN_GRID_V = -5000164,
        PG_CURTAIN_GRID_U = -5000163,
        PG_DISPLAY = -5000162,
        PG_ANALYSIS_RESULTS = -5000161,
        PG_SLAB_SHAPE_EDIT = -5000160,
        PG_LIGHT_PHOTOMETRICS = -5000159,
        PG_PATTERN_APPLICATION = -5000158,
        PG_GREEN_BUILDING = -5000157,
        PG_PROFILE_2 = -5000156,
        PG_PROFILE_1 = -5000155,
        PG_PROFILE = -5000154,
        PG_TRUSS_FAMILY_BOTTOM_CHORD = -5000153,
        PG_TRUSS_FAMILY_TOP_CHORD = -5000152,
        PG_TRUSS_FAMILY_DIAG_WEB = -5000151,
        PG_TRUSS_FAMILY_VERT_WEB = -5000150,
        PG_TITLE = -5000149,
        PG_FIRE_PROTECTION = -5000148,
        PG_ROTATION_ABOUT = -5000147,
        PG_TRANSLATION_IN = -5000146,
        PG_ANALYTICAL_MODEL = -5000145,
        PG_REBAR_ARRAY = -5000144,
        PG_REBAR_SYSTEM_LAYERS = -5000143,
        PG_CURTAIN_GRID = -5000141,
        PG_CURTAIN_MULLION_2 = -5000140,
        PG_CURTAIN_MULLION_HORIZ = -5000139,
        PG_CURTAIN_MULLION_1 = -5000138,
        PG_CURTAIN_MULLION_VERT = -5000137,
        PG_CURTAIN_GRID_2 = -5000136,
        PG_CURTAIN_GRID_HORIZ = -5000135,
        PG_CURTAIN_GRID_1 = -5000134,
        PG_CURTAIN_GRID_VERT = -5000133,
        PG_IFC = -5000131,
        PG_AELECTRICAL = -5000130,
        PG_ENERGY_ANALYSIS = -5000129,
        PG_STRUCTURAL_ANALYSIS = -5000128,
        PG_MECHANICAL_AIRFLOW = -5000127,
        PG_MECHANICAL_LOADS = -5000126,
        PG_ELECTRICAL_LOADS = -5000125,
        PG_ELECTRICAL_LIGHTING = -5000124,
        PG_TEXT = -5000123,
        PG_VIEW_CAMERA = -5000122,
        PG_VIEW_EXTENTS = -5000121,
        PG_PATTERN = -5000120,
        PG_CONSTRAINTS = -5000119,
        PG_PHASING = -5000114,
        PG_MECHANICAL = -5000113,
        PG_STRUCTURAL = -5000112,
        PG_PLUMBING = -5000111,
        PG_ELECTRICAL = -5000110,
        PG_STAIR_STRINGERS = -5000109,
        PG_STAIR_RISERS = -5000108,
        PG_STAIR_TREADS = -5000107,
        PG_UNDERLAY = -5000106,
        PG_MATERIALS = -5000105,
        PG_GRAPHICS = -5000104,
        PG_CONSTRUCTION = -5000103,
        PG_GEOMETRY = -5000101,
        PG_IDENTITY_DATA = -5000100,
        INVALID = -1,
    }

    /// <summary>
    /// Contains extension methods for <see cref="BuiltInParameterGroup"/>
    /// </summary>
    public static class BuiltInParameterGroupExtensions
    {
        private static readonly Dictionary<BuiltInParameterGroup, string> _builtInParameterGroup;

        /// <summary>
        /// Initializes the <see cref="BuiltInParameterGroupExtensions"/> class.
        /// </summary>
        static BuiltInParameterGroupExtensions()
        {
            _builtInParameterGroup = new Dictionary<BuiltInParameterGroup, string>
            {
                {BuiltInParameterGroup.PG_ENERGY_ANALYSIS_BLDG_CONS_MTL_THERMAL_PROPS, "Material Thermal Properties"},
                {BuiltInParameterGroup.PG_ENERGY_ANALYSIS_ROOM_SPACE_DATA, "Room/Space Data"},
                {BuiltInParameterGroup.PG_ENERGY_ANALYSIS_BUILDING_DATA, "Building Data"},
                {BuiltInParameterGroup.PG_COUPLER_ARRAY, "Set"},
                {BuiltInParameterGroup.PG_ENERGY_ANALYSIS_ADVANCED, "Advanced"},
                {BuiltInParameterGroup.PG_RELEASES_MEMBER_FORCES, "Releases / Member Forces"},
                {BuiltInParameterGroup.PG_SECONDARY_END, "Secondary End"},
                {BuiltInParameterGroup.PG_PRIMARY_END, "Primary End"},
                {BuiltInParameterGroup.PG_MOMENTS, "Moments"},
                {BuiltInParameterGroup.PG_FORCES, "Forces"},
                {BuiltInParameterGroup.PG_FABRICATION_PRODUCT_DATA, "Fabrication Product Data"},
                {BuiltInParameterGroup.PG_REFERENCE, "Reference"},
                {BuiltInParameterGroup.PG_GEOMETRY_POSITIONING, "Geometric Position"},
                {BuiltInParameterGroup.PG_DIVISION_GEOMETRY, "Division Geometry"},
                {BuiltInParameterGroup.PG_SEGMENTS_FITTINGS, "Segments and Fittings"},
                {BuiltInParameterGroup.PG_CONTINUOUSRAIL_END_TOP_EXTENSION, "Extension (End/Top)"},
                {BuiltInParameterGroup.PG_CONTINUOUSRAIL_BEGIN_BOTTOM_EXTENSION, "Extension (Beginning/Bottom)"},
                {BuiltInParameterGroup.PG_STAIRS_WINDERS, "Winders"},
                {BuiltInParameterGroup.PG_STAIRS_SUPPORTS, "Supports"},
                {BuiltInParameterGroup.PG_STAIRS_OPEN_END_CONNECTION, "End Connection"},
                {BuiltInParameterGroup.PG_RAILING_SYSTEM_SECONDARY_FAMILY_HANDRAILS, "Handrail 2"},
                {BuiltInParameterGroup.PG_TERMINTATION, "Terminations"},
                {BuiltInParameterGroup.PG_STAIRS_TREADS_RISERS, "Threads/Risers"},
                {BuiltInParameterGroup.PG_STAIRS_CALCULATOR_RULES, "Calculation Rules"},
                {BuiltInParameterGroup.PG_SPLIT_PROFILE_DIMENSIONS, "Dimensions     (linear units or % of thickness)"},
                {BuiltInParameterGroup.PG_LENGTH, "Length"},
                {BuiltInParameterGroup.PG_NODES, "Nodes"},
                {BuiltInParameterGroup.PG_ANALYTICAL_PROPERTIES, "Analytical Properties"},
                {BuiltInParameterGroup.PG_ANALYTICAL_ALIGNMENT, "Analytical Alignment"},
                {BuiltInParameterGroup.PG_SYSTEMTYPE_RISEDROP, "Rise / Drop"},
                {BuiltInParameterGroup.PG_LINING, "Lining"},
                {BuiltInParameterGroup.PG_INSULATION, "Insulation"},
                {BuiltInParameterGroup.PG_OVERALL_LEGEND, "Overall Legend"},
                {BuiltInParameterGroup.PG_VISIBILITY, "Visibility"},
                {BuiltInParameterGroup.PG_SUPPORT, "Supports"},
                {BuiltInParameterGroup.PG_RAILING_SYSTEM_SEGMENT_V_GRID, "V Grid"},
                {BuiltInParameterGroup.PG_RAILING_SYSTEM_SEGMENT_U_GRID, "U Grid"},
                {BuiltInParameterGroup.PG_RAILING_SYSTEM_SEGMENT_POSTS, "Posts"},
                {BuiltInParameterGroup.PG_RAILING_SYSTEM_SEGMENT_PATTERN_REMAINDER, "Pattern Remainder"},
                {BuiltInParameterGroup.PG_RAILING_SYSTEM_SEGMENT_PATTERN_REPEAT, "Pattern Repeat"},
                {BuiltInParameterGroup.PG_RAILING_SYSTEM_FAMILY_SEGMENT_PATTERN, "Segment Pattern (default)"},
                {BuiltInParameterGroup.PG_RAILING_SYSTEM_FAMILY_HANDRAILS, "Handrail 1"},
                {BuiltInParameterGroup.PG_RAILING_SYSTEM_FAMILY_TOP_RAIL, "Top Rail"},
                {BuiltInParameterGroup.PG_CONCEPTUAL_ENERGY_DATA_BUILDING_SERVICES, "Energy Model - Building Services"},
                {BuiltInParameterGroup.PG_DATA, "Data"},
                {BuiltInParameterGroup.PG_ELECTRICAL_CIRCUITING, "Electrical - Circuiting"},
                {BuiltInParameterGroup.PG_GENERAL, "General"},
                {BuiltInParameterGroup.PG_FLEXIBLE, "Adaptive Component"},
                {BuiltInParameterGroup.PG_ENERGY_ANALYSIS_CONCEPTUAL_MODEL, "Energy Analytical Model"},
                {BuiltInParameterGroup.PG_ENERGY_ANALYSIS_DETAILED_MODEL, "Detailed Model"},
                {BuiltInParameterGroup.PG_ENERGY_ANALYSIS_DETAILED_AND_CONCEPTUAL_MODELS, "Essential"},
                {BuiltInParameterGroup.PG_FITTING, "Fittings"},
                {BuiltInParameterGroup.PG_CONCEPTUAL_ENERGY_DATA, "Conceptual Energy Data"},
                {BuiltInParameterGroup.PG_AREA, "Area"},
                {BuiltInParameterGroup.PG_ADSK_MODEL_PROPERTIES, "Model Properties"},
                {BuiltInParameterGroup.PG_CURTAIN_GRID_V, "V Grid"},
                {BuiltInParameterGroup.PG_CURTAIN_GRID_U, "U Grid"},
                {BuiltInParameterGroup.PG_DISPLAY, "Display"},
                {BuiltInParameterGroup.PG_ANALYSIS_RESULTS, "Analysis Results"},
                {BuiltInParameterGroup.PG_SLAB_SHAPE_EDIT, "Slab Shape Edit"},
                {BuiltInParameterGroup.PG_LIGHT_PHOTOMETRICS, "Photometrics"},
                {BuiltInParameterGroup.PG_PATTERN_APPLICATION, "Pattern Application"},
                {BuiltInParameterGroup.PG_GREEN_BUILDING, "Green Building Properties"},
                {BuiltInParameterGroup.PG_PROFILE_2, "Profile 2"},
                {BuiltInParameterGroup.PG_PROFILE_1, "Profile 1"},
                {BuiltInParameterGroup.PG_PROFILE, "Profile"},
                {BuiltInParameterGroup.PG_TRUSS_FAMILY_BOTTOM_CHORD, "Bottom Chords"},
                {BuiltInParameterGroup.PG_TRUSS_FAMILY_TOP_CHORD, "Top Chords"},
                {BuiltInParameterGroup.PG_TRUSS_FAMILY_DIAG_WEB, "Diagonal Webs"},
                {BuiltInParameterGroup.PG_TRUSS_FAMILY_VERT_WEB, "Vertical Webs"},
                {BuiltInParameterGroup.PG_TITLE, "Title Text"},
                {BuiltInParameterGroup.PG_FIRE_PROTECTION, "Fire Protection"},
                {BuiltInParameterGroup.PG_ROTATION_ABOUT, "Rotation about"},
                {BuiltInParameterGroup.PG_TRANSLATION_IN, "Translation in"},
                {BuiltInParameterGroup.PG_ANALYTICAL_MODEL, "Analytical Model"},
                {BuiltInParameterGroup.PG_REBAR_ARRAY, "Rebar Set"},
                {BuiltInParameterGroup.PG_REBAR_SYSTEM_LAYERS, "Layers"},
                {BuiltInParameterGroup.PG_CURTAIN_GRID, "Grid"},
                {BuiltInParameterGroup.PG_CURTAIN_MULLION_2, "Grid 2 Mullions"},
                {BuiltInParameterGroup.PG_CURTAIN_MULLION_HORIZ, "Horizontal Mullions"},
                {BuiltInParameterGroup.PG_CURTAIN_MULLION_1, "Grid 1 Mullions"},
                {BuiltInParameterGroup.PG_CURTAIN_MULLION_VERT, "Vertical Mullions"},
                {BuiltInParameterGroup.PG_CURTAIN_GRID_2, "Grid 2"},
                {BuiltInParameterGroup.PG_CURTAIN_GRID_HORIZ, "Horizontal Grid"},
                {BuiltInParameterGroup.PG_CURTAIN_GRID_1, "Grid 1"},
                {BuiltInParameterGroup.PG_CURTAIN_GRID_VERT, "Vertical Grid"},
                {BuiltInParameterGroup.PG_IFC, "IFC Parameters"},
                {BuiltInParameterGroup.PG_AELECTRICAL, "Electrical"},
                {BuiltInParameterGroup.PG_ENERGY_ANALYSIS, "Energy Analysis"},
                {BuiltInParameterGroup.PG_STRUCTURAL_ANALYSIS, "Structural Analysis"},
                {BuiltInParameterGroup.PG_MECHANICAL_AIRFLOW, "Mechanical - Flow"},
                {BuiltInParameterGroup.PG_MECHANICAL_LOADS, "Mechanical - Loads"},
                {BuiltInParameterGroup.PG_ELECTRICAL_LOADS, "Electrical - Loads"},
                {BuiltInParameterGroup.PG_ELECTRICAL_LIGHTING, "Electrical - Lighting"},
                {BuiltInParameterGroup.PG_TEXT, "Text"},
                {BuiltInParameterGroup.PG_VIEW_CAMERA, "Camera"},
                {BuiltInParameterGroup.PG_VIEW_EXTENTS, "Extents"},
                {BuiltInParameterGroup.PG_PATTERN, "Pattern"},
                {BuiltInParameterGroup.PG_CONSTRAINTS, "Constraints"},
                {BuiltInParameterGroup.PG_PHASING, "Phasing"},
                {BuiltInParameterGroup.PG_MECHANICAL, "Mechanical"},
                {BuiltInParameterGroup.PG_STRUCTURAL, "Structural"},
                {BuiltInParameterGroup.PG_PLUMBING, "Plumbing"},
                {BuiltInParameterGroup.PG_ELECTRICAL, "Electrical Engineering"},
                {BuiltInParameterGroup.PG_STAIR_STRINGERS, "Stringers"},
                {BuiltInParameterGroup.PG_STAIR_RISERS, "Risers"},
                {BuiltInParameterGroup.PG_STAIR_TREADS, "Treads"},
                {BuiltInParameterGroup.PG_UNDERLAY, "Underlay"},
                {BuiltInParameterGroup.PG_MATERIALS, "Materials and Finishes"},
                {BuiltInParameterGroup.PG_GRAPHICS, "Graphics"},
                {BuiltInParameterGroup.PG_CONSTRUCTION, "Construction"},
                {BuiltInParameterGroup.PG_GEOMETRY, "Dimensions"},
                {BuiltInParameterGroup.PG_IDENTITY_DATA, "Identity Data"},
                {BuiltInParameterGroup.INVALID, "Other"},
            };
        }

        /// <summary>
        /// Tries to convert <see cref="BuiltInParameterGroup"/> value to a human-readable English label.
        /// </summary>
        /// <param name="builtInParameterGroup">Built in parameter group value.</param>
        /// <param name="builtInParameterGroupString">Human-readable English label for the given <see cref="BuiltInParameterGroup"/> value.</param>
        /// <returns></returns>
        public static bool ToEnglishLabel(this BuiltInParameterGroup builtInParameterGroup,
            out string builtInParameterGroupString)
        {
            return _builtInParameterGroup.TryGetValue(builtInParameterGroup, out builtInParameterGroupString);
        }

        /// <summary>
        /// Tries to convert <see cref="string"/> label to <see cref="BuiltInParameterGroup"/> enum value.
        /// </summary>
        /// <param name="builtInParameterGroupString">The built in parameter group string.</param>
        /// <param name="builtInParameterGroup">The built in parameter group.</param>
        /// <returns></returns>
        public static bool FromEnglishLabel(this string builtInParameterGroupString, 
            out BuiltInParameterGroup builtInParameterGroup)
        {
            builtInParameterGroup = BuiltInParameterGroup.INVALID;
            if (!_builtInParameterGroup.ContainsValue(builtInParameterGroupString))
                return false;

            builtInParameterGroup = _builtInParameterGroup.FirstOrDefault(kp =>Equals(kp.Value, builtInParameterGroupString)).Key;
            return true;
        }
    }
}
