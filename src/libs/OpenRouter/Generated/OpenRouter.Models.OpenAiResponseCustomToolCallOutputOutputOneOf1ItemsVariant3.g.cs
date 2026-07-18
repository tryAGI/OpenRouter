
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Text input content item
    /// </summary>
    public sealed partial class OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsVariant3
    {
        /// <summary>
        /// Discriminator value: input_text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsVariant3TypeJsonConverter))]
        public global::OpenRouter.OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsVariant3Type Type { get; set; }

        /// <summary>
        /// Marks an explicit prompt-cache boundary on this content block (OpenAI-style). Everything through the block carrying this marker is part of the candidate cached prefix. Supported natively by OpenAI GPT-5.6 and newer; on providers that use Anthropic-style `cache_control`, OpenRouter converts the marker to that format automatically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_breakpoint")]
        public global::OpenRouter.PromptCacheBreakpoint? PromptCacheBreakpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsVariant3" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type">
        /// Discriminator value: input_text
        /// </param>
        /// <param name="promptCacheBreakpoint">
        /// Marks an explicit prompt-cache boundary on this content block (OpenAI-style). Everything through the block carrying this marker is part of the candidate cached prefix. Supported natively by OpenAI GPT-5.6 and newer; on providers that use Anthropic-style `cache_control`, OpenRouter converts the marker to that format automatically.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsVariant3(
            string text,
            global::OpenRouter.OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsVariant3Type type,
            global::OpenRouter.PromptCacheBreakpoint? promptCacheBreakpoint)
        {
            this.Type = type;
            this.PromptCacheBreakpoint = promptCacheBreakpoint;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsVariant3" /> class.
        /// </summary>
        public OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsVariant3()
        {
        }

    }
}