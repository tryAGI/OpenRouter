
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReasoningFormat
    {
        /// <summary>
        /// 
        /// </summary>
        AnthropicClaudeV1,
        /// <summary>
        /// 
        /// </summary>
        AzureOpenaiResponsesV1,
        /// <summary>
        /// 
        /// </summary>
        GoogleGeminiV1,
        /// <summary>
        /// 
        /// </summary>
        OpenaiResponsesV1,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        XaiResponsesV1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningFormat value)
        {
            return value switch
            {
                ReasoningFormat.AnthropicClaudeV1 => "anthropic-claude-v1",
                ReasoningFormat.AzureOpenaiResponsesV1 => "azure-openai-responses-v1",
                ReasoningFormat.GoogleGeminiV1 => "google-gemini-v1",
                ReasoningFormat.OpenaiResponsesV1 => "openai-responses-v1",
                ReasoningFormat.Unknown => "unknown",
                ReasoningFormat.XaiResponsesV1 => "xai-responses-v1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningFormat? ToEnum(string value)
        {
            return value switch
            {
                "anthropic-claude-v1" => ReasoningFormat.AnthropicClaudeV1,
                "azure-openai-responses-v1" => ReasoningFormat.AzureOpenaiResponsesV1,
                "google-gemini-v1" => ReasoningFormat.GoogleGeminiV1,
                "openai-responses-v1" => ReasoningFormat.OpenaiResponsesV1,
                "unknown" => ReasoningFormat.Unknown,
                "xai-responses-v1" => ReasoningFormat.XaiResponsesV1,
                _ => null,
            };
        }
    }
}