
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GuardrailModerationPolicyConfigContentFilterBuiltin
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.GuardrailModerationPolicyConfigContentFilterBuiltinActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.GuardrailModerationPolicyConfigContentFilterBuiltinAction Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scan_scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.GuardrailModerationPolicyConfigContentFilterBuiltinScanScopeJsonConverter))]
        public global::OpenRouter.GuardrailModerationPolicyConfigContentFilterBuiltinScanScope? ScanScope { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.GuardrailModerationPolicyConfigContentFilterBuiltinSlugJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.GuardrailModerationPolicyConfigContentFilterBuiltinSlug Slug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailModerationPolicyConfigContentFilterBuiltin" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="slug"></param>
        /// <param name="label"></param>
        /// <param name="scanScope"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailModerationPolicyConfigContentFilterBuiltin(
            global::OpenRouter.GuardrailModerationPolicyConfigContentFilterBuiltinAction action,
            global::OpenRouter.GuardrailModerationPolicyConfigContentFilterBuiltinSlug slug,
            string? label,
            global::OpenRouter.GuardrailModerationPolicyConfigContentFilterBuiltinScanScope? scanScope)
        {
            this.Action = action;
            this.Label = label;
            this.ScanScope = scanScope;
            this.Slug = slug;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailModerationPolicyConfigContentFilterBuiltin" /> class.
        /// </summary>
        public GuardrailModerationPolicyConfigContentFilterBuiltin()
        {
        }

    }
}