
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A builtin content filter entry for create/update requests. Labels are system-assigned and cannot be set by the caller.
    /// </summary>
    public sealed partial class ContentFilterBuiltinEntryInput
    {
        /// <summary>
        /// Action taken when the builtin filter triggers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ContentFilterBuiltinActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ContentFilterBuiltinAction Action { get; set; }

        /// <summary>
        /// Deprecated: labels are system-assigned and cannot be set by the caller. Accepted for backward compatibility but silently ignored.
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
        /// Initializes a new instance of the <see cref="ContentFilterBuiltinEntryInput" /> class.
        /// </summary>
        /// <param name="action">
        /// Action taken when the builtin filter triggers
        /// </param>
        /// <param name="slug">
        /// The builtin filter identifier
        /// </param>
        /// <param name="label">
        /// Deprecated: labels are system-assigned and cannot be set by the caller. Accepted for backward compatibility but silently ignored.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentFilterBuiltinEntryInput(
            global::OpenRouter.ContentFilterBuiltinAction action,
            global::OpenRouter.ContentFilterBuiltinSlug slug,
            string? label)
        {
            this.Action = action;
            this.Label = label;
            this.Slug = slug;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFilterBuiltinEntryInput" /> class.
        /// </summary>
        public ContentFilterBuiltinEntryInput()
        {
        }

    }
}