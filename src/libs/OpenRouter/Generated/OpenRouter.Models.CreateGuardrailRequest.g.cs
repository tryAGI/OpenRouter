
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGuardrailRequest
    {
        /// <summary>
        /// Array of model identifiers (slug or canonical_slug accepted)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_models")]
        public global::System.Collections.Generic.IList<string>? AllowedModels { get; set; }

        /// <summary>
        /// List of allowed provider IDs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_providers")]
        public global::System.Collections.Generic.IList<string>? AllowedProviders { get; set; }

        /// <summary>
        /// Builtin content filters to apply. Every builtin slug supports "block", "redact", and the detect-only "flag" action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_filter_builtins")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterBuiltinEntryInput>? ContentFilterBuiltins { get; set; }

        /// <summary>
        /// Custom regex content filters to apply to request messages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_filters")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterEntry>? ContentFilters { get; set; }

        /// <summary>
        /// Description of the guardrail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Deprecated. Use enforce_zdr_anthropic, enforce_zdr_openai, enforce_zdr_google, enforce_zdr_xai, and enforce_zdr_other instead. When provided, its value is copied into any of those per-provider fields that are not explicitly specified on the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_zdr")]
        public bool? EnforceZdr { get; set; }

        /// <summary>
        /// Whether to enforce zero data retention for Anthropic models. Falls back to enforce_zdr when not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_zdr_anthropic")]
        public bool? EnforceZdrAnthropic { get; set; }

        /// <summary>
        /// Whether to enforce zero data retention for Google models. Falls back to enforce_zdr when not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_zdr_google")]
        public bool? EnforceZdrGoogle { get; set; }

        /// <summary>
        /// Whether to enforce zero data retention for OpenAI models. Falls back to enforce_zdr when not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_zdr_openai")]
        public bool? EnforceZdrOpenai { get; set; }

        /// <summary>
        /// Whether to enforce zero data retention for models that are not from Anthropic, OpenAI, Google, or xAI. Falls back to enforce_zdr when not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_zdr_other")]
        public bool? EnforceZdrOther { get; set; }

        /// <summary>
        /// Whether to enforce zero data retention for xAI models. Falls back to enforce_zdr when not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_zdr_xai")]
        public bool? EnforceZdrXai { get; set; }

        /// <summary>
        /// Array of model identifiers to exclude from routing (slug or canonical_slug accepted)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignored_models")]
        public global::System.Collections.Generic.IList<string>? IgnoredModels { get; set; }

        /// <summary>
        /// List of provider IDs to exclude from routing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignored_providers")]
        public global::System.Collections.Generic.IList<string>? IgnoredProviders { get; set; }

        /// <summary>
        /// Spending limit in USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_usd")]
        public double? LimitUsd { get; set; }

        /// <summary>
        /// Name for the new guardrail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Interval at which the limit resets (daily, weekly, monthly)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reset_interval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.GuardrailIntervalJsonConverter))]
        public global::OpenRouter.GuardrailInterval? ResetInterval { get; set; }

        /// <summary>
        /// The workspace to create the guardrail in. Defaults to the default workspace if not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGuardrailRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name for the new guardrail
        /// </param>
        /// <param name="allowedModels">
        /// Array of model identifiers (slug or canonical_slug accepted)
        /// </param>
        /// <param name="allowedProviders">
        /// List of allowed provider IDs
        /// </param>
        /// <param name="contentFilterBuiltins">
        /// Builtin content filters to apply. Every builtin slug supports "block", "redact", and the detect-only "flag" action.
        /// </param>
        /// <param name="contentFilters">
        /// Custom regex content filters to apply to request messages
        /// </param>
        /// <param name="description">
        /// Description of the guardrail
        /// </param>
        /// <param name="enforceZdr">
        /// Deprecated. Use enforce_zdr_anthropic, enforce_zdr_openai, enforce_zdr_google, enforce_zdr_xai, and enforce_zdr_other instead. When provided, its value is copied into any of those per-provider fields that are not explicitly specified on the request.
        /// </param>
        /// <param name="enforceZdrAnthropic">
        /// Whether to enforce zero data retention for Anthropic models. Falls back to enforce_zdr when not provided.
        /// </param>
        /// <param name="enforceZdrGoogle">
        /// Whether to enforce zero data retention for Google models. Falls back to enforce_zdr when not provided.
        /// </param>
        /// <param name="enforceZdrOpenai">
        /// Whether to enforce zero data retention for OpenAI models. Falls back to enforce_zdr when not provided.
        /// </param>
        /// <param name="enforceZdrOther">
        /// Whether to enforce zero data retention for models that are not from Anthropic, OpenAI, Google, or xAI. Falls back to enforce_zdr when not provided.
        /// </param>
        /// <param name="enforceZdrXai">
        /// Whether to enforce zero data retention for xAI models. Falls back to enforce_zdr when not provided.
        /// </param>
        /// <param name="ignoredModels">
        /// Array of model identifiers to exclude from routing (slug or canonical_slug accepted)
        /// </param>
        /// <param name="ignoredProviders">
        /// List of provider IDs to exclude from routing
        /// </param>
        /// <param name="limitUsd">
        /// Spending limit in USD
        /// </param>
        /// <param name="resetInterval">
        /// Interval at which the limit resets (daily, weekly, monthly)
        /// </param>
        /// <param name="workspaceId">
        /// The workspace to create the guardrail in. Defaults to the default workspace if not provided.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGuardrailRequest(
            string name,
            global::System.Collections.Generic.IList<string>? allowedModels,
            global::System.Collections.Generic.IList<string>? allowedProviders,
            global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterBuiltinEntryInput>? contentFilterBuiltins,
            global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterEntry>? contentFilters,
            string? description,
            bool? enforceZdr,
            bool? enforceZdrAnthropic,
            bool? enforceZdrGoogle,
            bool? enforceZdrOpenai,
            bool? enforceZdrOther,
            bool? enforceZdrXai,
            global::System.Collections.Generic.IList<string>? ignoredModels,
            global::System.Collections.Generic.IList<string>? ignoredProviders,
            double? limitUsd,
            global::OpenRouter.GuardrailInterval? resetInterval,
            global::System.Guid? workspaceId)
        {
            this.AllowedModels = allowedModels;
            this.AllowedProviders = allowedProviders;
            this.ContentFilterBuiltins = contentFilterBuiltins;
            this.ContentFilters = contentFilters;
            this.Description = description;
            this.EnforceZdr = enforceZdr;
            this.EnforceZdrAnthropic = enforceZdrAnthropic;
            this.EnforceZdrGoogle = enforceZdrGoogle;
            this.EnforceZdrOpenai = enforceZdrOpenai;
            this.EnforceZdrOther = enforceZdrOther;
            this.EnforceZdrXai = enforceZdrXai;
            this.IgnoredModels = ignoredModels;
            this.IgnoredProviders = ignoredProviders;
            this.LimitUsd = limitUsd;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ResetInterval = resetInterval;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGuardrailRequest" /> class.
        /// </summary>
        public CreateGuardrailRequest()
        {
        }

    }
}