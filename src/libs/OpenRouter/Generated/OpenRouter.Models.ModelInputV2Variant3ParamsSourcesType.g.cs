
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelInputV2Variant3ParamsSourcesType
    {
        /// <summary>
        ///
        /// </summary>
        Enum,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelInputV2Variant3ParamsSourcesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelInputV2Variant3ParamsSourcesType value)
        {
            return value switch
            {
                ModelInputV2Variant3ParamsSourcesType.Enum => "enum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelInputV2Variant3ParamsSourcesType? ToEnum(string value)
        {
            return value switch
            {
                "enum" => ModelInputV2Variant3ParamsSourcesType.Enum,
                _ => null,
            };
        }
    }
}