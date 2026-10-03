
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelInputV2Variant4ParamsFormatsType
    {
        /// <summary>
        ///
        /// </summary>
        Enum,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelInputV2Variant4ParamsFormatsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelInputV2Variant4ParamsFormatsType value)
        {
            return value switch
            {
                ModelInputV2Variant4ParamsFormatsType.Enum => "enum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelInputV2Variant4ParamsFormatsType? ToEnum(string value)
        {
            return value switch
            {
                "enum" => ModelInputV2Variant4ParamsFormatsType.Enum,
                _ => null,
            };
        }
    }
}