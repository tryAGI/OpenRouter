
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesSearchModelsServerToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_experimentalSearchModels,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesSearchModelsServerToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesSearchModelsServerToolType value)
        {
            return value switch
            {
                MessagesSearchModelsServerToolType.Openrouter_experimentalSearchModels => "openrouter:experimental__search_models",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesSearchModelsServerToolType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:experimental__search_models" => MessagesSearchModelsServerToolType.Openrouter_experimentalSearchModels,
                _ => null,
            };
        }
    }
}