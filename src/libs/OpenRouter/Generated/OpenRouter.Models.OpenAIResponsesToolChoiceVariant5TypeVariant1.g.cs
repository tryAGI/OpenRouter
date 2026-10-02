
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIResponsesToolChoiceVariant5TypeVariant1
    {
        /// <summary>
        ///
        /// </summary>
        WebSearchPreview20250311,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIResponsesToolChoiceVariant5TypeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponsesToolChoiceVariant5TypeVariant1 value)
        {
            return value switch
            {
                OpenAIResponsesToolChoiceVariant5TypeVariant1.WebSearchPreview20250311 => "web_search_preview_2025_03_11",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponsesToolChoiceVariant5TypeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "web_search_preview_2025_03_11" => OpenAIResponsesToolChoiceVariant5TypeVariant1.WebSearchPreview20250311,
                _ => null,
            };
        }
    }
}