
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Text input content item<br/>
    /// Example: {"text":"Hello, how can I help you?","type":"input_text"}
    /// </summary>
    public sealed partial class InputText
    {
        /// <summary>
        /// Marks an explicit prompt-cache boundary on this content block (OpenAI-style). Everything through the block carrying this marker is part of the candidate cached prefix. Supported natively by OpenAI GPT-5.6 and newer; on providers that use Anthropic-style `cache_control`, OpenRouter converts the marker to that format automatically.<br/>
        /// Example: {"mode":"explicit"}
        /// </summary>
        /// <example>{"mode":"explicit"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_breakpoint")]
        public global::OpenRouter.PromptCacheBreakpoint? PromptCacheBreakpoint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InputTextTypeJsonConverter))]
        public global::OpenRouter.InputTextType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputText" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="promptCacheBreakpoint">
        /// Marks an explicit prompt-cache boundary on this content block (OpenAI-style). Everything through the block carrying this marker is part of the candidate cached prefix. Supported natively by OpenAI GPT-5.6 and newer; on providers that use Anthropic-style `cache_control`, OpenRouter converts the marker to that format automatically.<br/>
        /// Example: {"mode":"explicit"}
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputText(
            string text,
            global::OpenRouter.PromptCacheBreakpoint? promptCacheBreakpoint,
            global::OpenRouter.InputTextType type)
        {
            this.PromptCacheBreakpoint = promptCacheBreakpoint;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputText" /> class.
        /// </summary>
        public InputText()
        {
        }

    }
}