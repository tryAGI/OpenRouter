
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Reasoning effort configuration. Omitted for non-reasoning models and dynamic router models.
    /// </summary>
    public sealed partial class ModelReasoning
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ReasoningEffortJsonConverter))]
        public global::OpenRouter.ReasoningEffort? DefaultEffort { get; set; }

        /// <summary>
        /// Default reasoning enabled state when the client does not set `reasoning.enabled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_enabled")]
        public bool? DefaultEnabled { get; set; }

        /// <summary>
        /// When true, reasoning cannot be disabled and effort "none" is rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mandatory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Mandatory { get; set; }

        /// <summary>
        /// Allowed reasoning effort values for this model, in descending effort order (highest first). Null means no allowlist — all gateway effort values are accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_efforts")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ReasoningEffort>? SupportedEfforts { get; set; }

        /// <summary>
        /// Present and `true` when the model accepts `reasoning.max_tokens` in requests (Anthropic-style) instead of or in addition to `reasoning.effort`. Omitted otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_max_tokens")]
        public bool? SupportsMaxTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelReasoning" /> class.
        /// </summary>
        /// <param name="mandatory">
        /// When true, reasoning cannot be disabled and effort "none" is rejected.
        /// </param>
        /// <param name="defaultEffort"></param>
        /// <param name="defaultEnabled">
        /// Default reasoning enabled state when the client does not set `reasoning.enabled`.
        /// </param>
        /// <param name="supportedEfforts">
        /// Allowed reasoning effort values for this model, in descending effort order (highest first). Null means no allowlist — all gateway effort values are accepted.
        /// </param>
        /// <param name="supportsMaxTokens">
        /// Present and `true` when the model accepts `reasoning.max_tokens` in requests (Anthropic-style) instead of or in addition to `reasoning.effort`. Omitted otherwise.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelReasoning(
            bool mandatory,
            global::OpenRouter.ReasoningEffort? defaultEffort,
            bool? defaultEnabled,
            global::System.Collections.Generic.IList<global::OpenRouter.ReasoningEffort>? supportedEfforts,
            bool? supportsMaxTokens)
        {
            this.DefaultEffort = defaultEffort;
            this.DefaultEnabled = defaultEnabled;
            this.Mandatory = mandatory;
            this.SupportedEfforts = supportedEfforts;
            this.SupportsMaxTokens = supportsMaxTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelReasoning" /> class.
        /// </summary>
        public ModelReasoning()
        {
        }

    }
}