
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelInputV2Variant2ParamsSourcesType
    {
        /// <summary>
        ///
        /// </summary>
        Enum,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelInputV2Variant2ParamsSourcesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelInputV2Variant2ParamsSourcesType value)
        {
            return value switch
            {
                ModelInputV2Variant2ParamsSourcesType.Enum => "enum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelInputV2Variant2ParamsSourcesType? ToEnum(string value)
        {
            return value switch
            {
                "enum" => ModelInputV2Variant2ParamsSourcesType.Enum,
                _ => null,
            };
        }
    }
}