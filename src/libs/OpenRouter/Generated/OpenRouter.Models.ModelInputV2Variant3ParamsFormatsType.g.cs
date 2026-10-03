
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelInputV2Variant3ParamsFormatsType
    {
        /// <summary>
        ///
        /// </summary>
        Enum,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelInputV2Variant3ParamsFormatsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelInputV2Variant3ParamsFormatsType value)
        {
            return value switch
            {
                ModelInputV2Variant3ParamsFormatsType.Enum => "enum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelInputV2Variant3ParamsFormatsType? ToEnum(string value)
        {
            return value switch
            {
                "enum" => ModelInputV2Variant3ParamsFormatsType.Enum,
                _ => null,
            };
        }
    }
}