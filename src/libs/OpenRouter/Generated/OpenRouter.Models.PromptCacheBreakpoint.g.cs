
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Marks an explicit prompt-cache boundary on this content block (OpenAI-style). Everything through the block carrying this marker is part of the candidate cached prefix. Supported natively by OpenAI GPT-5.6 and newer; on providers that use Anthropic-style `cache_control`, OpenRouter converts the marker to that format automatically. `ttl` ("30m" or "12h") overrides the request-level `prompt_cache_options.ttl` for this boundary; 12h writes bill at the higher cache-write rate.<br/>
    /// Example: {"mode":"explicit","ttl":"30m"}
    /// </summary>
    public sealed partial class PromptCacheBreakpoint
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.PromptCacheBreakpointModeJsonConverter))]
        public global::OpenRouter.PromptCacheBreakpointMode Mode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        public string? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCacheBreakpoint" /> class.
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="ttl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptCacheBreakpoint(
            global::OpenRouter.PromptCacheBreakpointMode mode,
            string? ttl)
        {
            this.Mode = mode;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCacheBreakpoint" /> class.
        /// </summary>
        public PromptCacheBreakpoint()
        {
        }

    }
}