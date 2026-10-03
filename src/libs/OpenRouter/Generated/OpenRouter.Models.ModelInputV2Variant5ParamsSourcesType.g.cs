
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelInputV2Variant5ParamsSourcesType
    {
        /// <summary>
        ///
        /// </summary>
        Enum,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelInputV2Variant5ParamsSourcesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelInputV2Variant5ParamsSourcesType value)
        {
            return value switch
            {
                ModelInputV2Variant5ParamsSourcesType.Enum => "enum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelInputV2Variant5ParamsSourcesType? ToEnum(string value)
        {
            return value switch
            {
                "enum" => ModelInputV2Variant5ParamsSourcesType.Enum,
                _ => null,
            };
        }
    }
}