
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A builtin content filter entry for create/update requests. Labels are system-assigned and cannot be set by the caller.<br/>
    /// Example: {"action":"redact","slug":"email"}
    /// </summary>
    public sealed partial class ContentFilterBuiltinEntryInput
    {
        /// <summary>
        /// Action taken when the builtin filter triggers<br/>
        /// Example: block
        /// </summary>
        /// <example>block</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ContentFilterBuiltinActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ContentFilterBuiltinAction Action { get; set; }

        /// <summary>
        /// Deprecated: labels are system-assigned and cannot be set by the caller. Accepted for backward compatibility but silently ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Label { get; set; }

        /// <summary>
        /// Which message roles to scan for prompt injection. Only applies to the regex-prompt-injection builtin. Defaults to all_messages.<br/>
        /// Example: user_only
        /// </summary>
        /// <example>user_only</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scan_scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.PromptInjectionScanScopeJsonConverter))]
        public global::OpenRouter.PromptInjectionScanScope? ScanScope { get; set; }

        /// <summary>
        /// The builtin filter identifier<br/>
        /// Example: regex-prompt-injection
        /// </summary>
        /// <example>regex-prompt-injection</example>
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
        /// Action taken when the builtin filter triggers<br/>
        /// Example: block
        /// </param>
        /// <param name="slug">
        /// The builtin filter identifier<br/>
        /// Example: regex-prompt-injection
        /// </param>
        /// <param name="scanScope">
        /// Which message roles to scan for prompt injection. Only applies to the regex-prompt-injection builtin. Defaults to all_messages.<br/>
        /// Example: user_only
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentFilterBuiltinEntryInput(
            global::OpenRouter.ContentFilterBuiltinAction action,
            global::OpenRouter.ContentFilterBuiltinSlug slug,
            global::OpenRouter.PromptInjectionScanScope? scanScope)
        {
            this.Action = action;
            this.ScanScope = scanScope;
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