
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelInputV2Variant2ParamsReferencesType
    {
        /// <summary>
        ///
        /// </summary>
        Integer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelInputV2Variant2ParamsReferencesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelInputV2Variant2ParamsReferencesType value)
        {
            return value switch
            {
                ModelInputV2Variant2ParamsReferencesType.Integer => "integer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelInputV2Variant2ParamsReferencesType? ToEnum(string value)
        {
            return value switch
            {
                "integer" => ModelInputV2Variant2ParamsReferencesType.Integer,
                _ => null,
            };
        }
    }
}