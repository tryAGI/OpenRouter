
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A custom regex content filter that scans request messages for matching patterns.
    /// </summary>
    public sealed partial class ContentFilterEntry
    {
        /// <summary>
        /// Action taken when the pattern matches
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ContentFilterActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ContentFilterAction Action { get; set; }

        /// <summary>
        /// Optional label used in redaction placeholders or error messages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// A regex pattern to match against request content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pattern { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFilterEntry" /> class.
        /// </summary>
        /// <param name="action">
        /// Action taken when the pattern matches
        /// </param>
        /// <param name="pattern">
        /// A regex pattern to match against request content
        /// </param>
        /// <param name="label">
        /// Optional label used in redaction placeholders or error messages
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentFilterEntry(
            global::OpenRouter.ContentFilterAction action,
            string pattern,
            string? label)
        {
            this.Action = action;
            this.Label = label;
            this.Pattern = pattern ?? throw new global::System.ArgumentNullException(nameof(pattern));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFilterEntry" /> class.
        /// </summary>
        public ContentFilterEntry()
        {
        }

    }
}