
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputSearchModelsServerToolItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_experimentalSearchModels,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputSearchModelsServerToolItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputSearchModelsServerToolItemType value)
        {
            return value switch
            {
                OutputSearchModelsServerToolItemType.Openrouter_experimentalSearchModels => "openrouter:experimental__search_models",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputSearchModelsServerToolItemType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:experimental__search_models" => OutputSearchModelsServerToolItemType.Openrouter_experimentalSearchModels,
                _ => null,
            };
        }
    }
}