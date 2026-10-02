
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: unknown
    /// </summary>
    public readonly partial struct ReasoningFormat : global::System.IEquatable<ReasoningFormat>
    {
        /// <summary>
        ///
        /// </summary>
        public ReasoningFormat(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        ///
        /// </summary>
        public static ReasoningFormat AnthropicClaudeV1 { get; } = new("anthropic-claude-v1");

        /// <summary>
        ///
        /// </summary>
        public static ReasoningFormat AzureOpenaiResponsesV1 { get; } = new("azure-openai-responses-v1");

        /// <summary>
        ///
        /// </summary>
        public static ReasoningFormat BedrockOpenaiResponsesV1 { get; } = new("bedrock-openai-responses-v1");

        /// <summary>
        ///
        /// </summary>
        public static ReasoningFormat BedrockXaiResponsesV1 { get; } = new("bedrock-xai-responses-v1");

        /// <summary>
        ///
        /// </summary>
        public static ReasoningFormat GoogleGeminiV1 { get; } = new("google-gemini-v1");

        /// <summary>
        ///
        /// </summary>
        public static ReasoningFormat MetaResponsesV1 { get; } = new("meta-responses-v1");

        /// <summary>
        ///
        /// </summary>
        public static ReasoningFormat OpenaiResponsesV1 { get; } = new("openai-responses-v1");

        /// <summary>
        ///
        /// </summary>
        public static ReasoningFormat Unknown { get; } = new("unknown");

        /// <summary>
        ///
        /// </summary>
        public static ReasoningFormat XaiResponsesV1 { get; } = new("xai-responses-v1");
        /// <summary>
        ///
        /// </summary>
        public static ReasoningFormat FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "anthropic-claude-v1" => AnthropicClaudeV1,
                "azure-openai-responses-v1" => AzureOpenaiResponsesV1,
                "bedrock-openai-responses-v1" => BedrockOpenaiResponsesV1,
                "bedrock-xai-responses-v1" => BedrockXaiResponsesV1,
                "google-gemini-v1" => GoogleGeminiV1,
                "meta-responses-v1" => MetaResponsesV1,
                "openai-responses-v1" => OpenaiResponsesV1,
                "unknown" => Unknown,
                "xai-responses-v1" => XaiResponsesV1,
                _ => new ReasoningFormat(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "anthropic-claude-v1" => true,
            "azure-openai-responses-v1" => true,
            "bedrock-openai-responses-v1" => true,
            "bedrock-xai-responses-v1" => true,
            "google-gemini-v1" => true,
            "meta-responses-v1" => true,
            "openai-responses-v1" => true,
            "unknown" => true,
            "xai-responses-v1" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ReasoningFormat other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReasoningFormat other && Equals(other);
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            return global::System.StringComparer.Ordinal.GetHashCode(Value ?? string.Empty);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ReasoningFormat left, ReasoningFormat right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ReasoningFormat left, ReasoningFormat right) => !left.Equals(right);
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
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningFormat? ToEnum(string value)
        {
            return ReasoningFormat.FromValue(value);
        }
    }
}