
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A builtin content filter entry. Builtin filters include PII detectors and the regex-based prompt injection detector.
    /// </summary>
    public sealed partial class ContentFilterBuiltinEntry
    {
        /// <summary>
        /// Action taken when the builtin filter triggers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ContentFilterBuiltinActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ContentFilterBuiltinAction Action { get; set; }

        /// <summary>
        /// Optional label used in redaction placeholders (e.g. "[PROMPT_INJECTION]")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// The builtin filter identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ContentFilterBuiltinSlugJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ContentFilterBuiltinSlug Slug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFilterBuiltinEntry" /> class.
        /// </summary>
        /// <param name="action">
        /// Action taken when the builtin filter triggers
        /// </param>
        /// <param name="slug">
        /// The builtin filter identifier
        /// </param>
        /// <param name="label">
        /// Optional label used in redaction placeholders (e.g. "[PROMPT_INJECTION]")
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentFilterBuiltinEntry(
            global::OpenRouter.ContentFilterBuiltinAction action,
            global::OpenRouter.ContentFilterBuiltinSlug slug,
            string? label)
        {
            this.Action = action;
            this.Label = label;
            this.Slug = slug;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFilterBuiltinEntry" /> class.
        /// </summary>
        public ContentFilterBuiltinEntry()
        {
        }
    }
}