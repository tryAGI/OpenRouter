
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchModelsServerToolOpenRouterType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_experimentalSearchModels,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchModelsServerToolOpenRouterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchModelsServerToolOpenRouterType value)
        {
            return value switch
            {
                SearchModelsServerToolOpenRouterType.Openrouter_experimentalSearchModels => "openrouter:experimental__search_models",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchModelsServerToolOpenRouterType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:experimental__search_models" => SearchModelsServerToolOpenRouterType.Openrouter_experimentalSearchModels,
                _ => null,
            };
        }
    }
}