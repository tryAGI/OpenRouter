
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIResponsesToolChoiceVariant5TypeVariant2
    {
        /// <summary>
        ///
        /// </summary>
        WebSearchPreview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIResponsesToolChoiceVariant5TypeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponsesToolChoiceVariant5TypeVariant2 value)
        {
            return value switch
            {
                OpenAIResponsesToolChoiceVariant5TypeVariant2.WebSearchPreview => "web_search_preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponsesToolChoiceVariant5TypeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "web_search_preview" => OpenAIResponsesToolChoiceVariant5TypeVariant2.WebSearchPreview,
                _ => null,
            };
        }
    }
}