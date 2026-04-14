
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatSearchModelsServerToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_experimentalSearchModels,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatSearchModelsServerToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatSearchModelsServerToolType value)
        {
            return value switch
            {
                ChatSearchModelsServerToolType.Openrouter_experimentalSearchModels => "openrouter:experimental__search_models",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatSearchModelsServerToolType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:experimental__search_models" => ChatSearchModelsServerToolType.Openrouter_experimentalSearchModels,
                _ => null,
            };
        }
    }
}