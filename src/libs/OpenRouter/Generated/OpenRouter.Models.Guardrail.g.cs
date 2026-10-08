
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"allow_safety_retention_google":null,"allowed_data_regions":null,"allowed_models":null,"allowed_providers":["openai","anthropic","google"],"content_filter_builtins":[{"action":"redact","label":"[EMAIL]","slug":"email"}],"content_filters":null,"created_at":"2025-08-24T10:30:00Z","description":"Guardrail for production environment","enable_free_model_publication":false,"enable_free_model_training":true,"enable_paid_model_training":true,"enforce_zdr":null,"enforce_zdr_anthropic":true,"enforce_zdr_google":false,"enforce_zdr_openai":true,"enforce_zdr_other":false,"enforce_zdr_xai":false,"id":"550e8400-e29b-41d4-a716-446655440000","ignored_models":null,"ignored_providers":null,"include_byok_in_budgets":false,"limit_usd":100,"name":"Production Guardrail","reset_interval":"monthly","updated_at":"2025-08-24T15:45:00Z","workspace_id":"0df9e665-d932-5740-b2c7-b52af166bc11"}
    /// </summary>
    public sealed partial class Guardrail
    {
        /// <summary>
        /// Whether ZDR requests for Google models may use Safety Retention endpoints, which keep only prompts flagged by safety classifiers. `false` requires strict ZDR for Google. `null` inherits the account setting, which is on by default. A guardrail cannot turn this on for an account that turned it off.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_safety_retention_google")]
        public bool? AllowSafetyRetentionGoogle { get; set; }

        /// <summary>
        /// Data regions through which requests governed by this guardrail must arrive. `global` is https://openrouter.ai, `europe` is https://eu.openrouter.ai, and `us` is https://us.openrouter.ai. Requests arriving through any other region are rejected. `null` leaves the ingress region unrestricted. When several guardrails apply (workspace default, member, API key), the effective regions are the intersection of every non-null value.<br/>
        /// Example: [europe]
        /// </summary>
        /// <example>[europe]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_data_regions")]
        public global::System.Collections.Generic.IList<global::OpenRouter.GuardrailDataRegion>? AllowedDataRegions { get; set; }

        /// <summary>
        /// Array of model canonical_slugs (immutable identifiers)<br/>
        /// Example: [openai/gpt-5.2-20251211, anthropic/claude-4.5-opus-20251124, deepseek/deepseek-r1-0528:free]
        /// </summary>
        /// <example>[openai/gpt-5.2-20251211, anthropic/claude-4.5-opus-20251124, deepseek/deepseek-r1-0528:free]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_models")]
        public global::System.Collections.Generic.IList<string>? AllowedModels { get; set; }

        /// <summary>
        /// List of allowed provider IDs<br/>
        /// Example: [openai, anthropic, google]
        /// </summary>
        /// <example>[openai, anthropic, google]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_providers")]
        public global::System.Collections.Generic.IList<string>? AllowedProviders { get; set; }

        /// <summary>
        /// Builtin content filters applied to requests. Includes PII detectors and the regex-based prompt injection detector.<br/>
        /// Example: [{"action":"redact","label":"[EMAIL]","slug":"email"}]
        /// </summary>
        /// <example>[{"action":"redact","label":"[EMAIL]","slug":"email"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_filter_builtins")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterBuiltinEntry>? ContentFilterBuiltins { get; set; }

        /// <summary>
        /// Custom regex content filters applied to request messages<br/>
        /// Example: [{"action":"redact","label":"[API_KEY]","pattern":"\\b(sk-[a-zA-Z0-9]{48})\\b"}]
        /// </summary>
        /// <example>[{"action":"redact","label":"[API_KEY]","pattern":"\\b(sk-[a-zA-Z0-9]{48})\\b"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_filters")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterEntry>? ContentFilters { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the guardrail was created<br/>
        /// Example: 2025-08-24T10:30:00Z
        /// </summary>
        /// <example>2025-08-24T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Description of the guardrail<br/>
        /// Example: Guardrail for production environment
        /// </summary>
        /// <example>Guardrail for production environment</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether this guardrail allows free endpoints that publish prompts.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_free_model_publication")]
        public bool? EnableFreeModelPublication { get; set; }

        /// <summary>
        /// Whether this guardrail allows free endpoints that train on request data.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_free_model_training")]
        public bool? EnableFreeModelTraining { get; set; }

        /// <summary>
        /// Whether this guardrail allows paid endpoints that train on request data.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_paid_model_training")]
        public bool? EnablePaidModelTraining { get; set; }

        /// <summary>
        /// Deprecated. Use enforce_zdr_anthropic, enforce_zdr_openai, enforce_zdr_google, enforce_zdr_xai, and enforce_zdr_other instead. When provided, its value is copied into any of those per-provider fields that are not explicitly specified on the request.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_zdr")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? EnforceZdr { get; set; }

        /// <summary>
        /// Whether to enforce zero data retention for Anthropic models. Falls back to enforce_zdr when not provided.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_zdr_anthropic")]
        public bool? EnforceZdrAnthropic { get; set; }

        /// <summary>
        /// Whether to enforce zero data retention for Google models. Falls back to enforce_zdr when not provided.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_zdr_google")]
        public bool? EnforceZdrGoogle { get; set; }

        /// <summary>
        /// Whether to enforce zero data retention for OpenAI models. Falls back to enforce_zdr when not provided.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_zdr_openai")]
        public bool? EnforceZdrOpenai { get; set; }

        /// <summary>
        /// Whether to enforce zero data retention for models that are not from Anthropic, OpenAI, Google, or xAI. Falls back to enforce_zdr when not provided.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_zdr_other")]
        public bool? EnforceZdrOther { get; set; }

        /// <summary>
        /// Whether to enforce zero data retention for xAI models. Falls back to enforce_zdr when not provided.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_zdr_xai")]
        public bool? EnforceZdrXai { get; set; }

        /// <summary>
        /// Unique identifier for the guardrail<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Array of model canonical_slugs to exclude from routing<br/>
        /// Example: [openai/gpt-4o-mini-2024-07-18]
        /// </summary>
        /// <example>[openai/gpt-4o-mini-2024-07-18]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignored_models")]
        public global::System.Collections.Generic.IList<string>? IgnoredModels { get; set; }

        /// <summary>
        /// List of provider IDs to exclude from routing<br/>
        /// Example: [azure]
        /// </summary>
        /// <example>[azure]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignored_providers")]
        public global::System.Collections.Generic.IList<string>? IgnoredProviders { get; set; }

        /// <summary>
        /// Whether BYOK (bring-your-own-key) inference spend counts toward this guardrail's limit_usd, in addition to OpenRouter credit spend.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_byok_in_budgets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IncludeByokInBudgets { get; set; }

        /// <summary>
        /// Spending limit in USD<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_usd")]
        public double? LimitUsd { get; set; }

        /// <summary>
        /// Name of the guardrail<br/>
        /// Example: Production Guardrail
        /// </summary>
        /// <example>Production Guardrail</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Interval at which the limit resets (daily, weekly, monthly)<br/>
        /// Example: monthly
        /// </summary>
        /// <example>monthly</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reset_interval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.GuardrailIntervalJsonConverter))]
        public global::OpenRouter.GuardrailInterval? ResetInterval { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the guardrail was last updated<br/>
        /// Example: 2025-08-24T15:45:00Z
        /// </summary>
        /// <example>2025-08-24T15:45:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// The workspace this guardrail belongs to, or `null` for an unscoped legacy guardrail predating workspaces. Workspace membership organizes the guardrail; it does not apply the guardrail to the workspace's traffic. A `null` value does not mean the default workspace, and does not apply the guardrail across every workspace.<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </summary>
        /// <example>0df9e665-d932-5740-b2c7-b52af166bc11</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Guardrail" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the guardrail was created<br/>
        /// Example: 2025-08-24T10:30:00Z
        /// </param>
        /// <param name="id">
        /// Unique identifier for the guardrail<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="includeByokInBudgets">
        /// Whether BYOK (bring-your-own-key) inference spend counts toward this guardrail's limit_usd, in addition to OpenRouter credit spend.<br/>
        /// Example: false
        /// </param>
        /// <param name="name">
        /// Name of the guardrail<br/>
        /// Example: Production Guardrail
        /// </param>
        /// <param name="allowSafetyRetentionGoogle">
        /// Whether ZDR requests for Google models may use Safety Retention endpoints, which keep only prompts flagged by safety classifiers. `false` requires strict ZDR for Google. `null` inherits the account setting, which is on by default. A guardrail cannot turn this on for an account that turned it off.<br/>
        /// Example: true
        /// </param>
        /// <param name="allowedDataRegions">
        /// Data regions through which requests governed by this guardrail must arrive. `global` is https://openrouter.ai, `europe` is https://eu.openrouter.ai, and `us` is https://us.openrouter.ai. Requests arriving through any other region are rejected. `null` leaves the ingress region unrestricted. When several guardrails apply (workspace default, member, API key), the effective regions are the intersection of every non-null value.<br/>
        /// Example: [europe]
        /// </param>
        /// <param name="allowedModels">
        /// Array of model canonical_slugs (immutable identifiers)<br/>
        /// Example: [openai/gpt-5.2-20251211, anthropic/claude-4.5-opus-20251124, deepseek/deepseek-r1-0528:free]
        /// </param>
        /// <param name="allowedProviders">
        /// List of allowed provider IDs<br/>
        /// Example: [openai, anthropic, google]
        /// </param>
        /// <param name="contentFilterBuiltins">
        /// Builtin content filters applied to requests. Includes PII detectors and the regex-based prompt injection detector.<br/>
        /// Example: [{"action":"redact","label":"[EMAIL]","slug":"email"}]
        /// </param>
        /// <param name="contentFilters">
        /// Custom regex content filters applied to request messages<br/>
        /// Example: [{"action":"redact","label":"[API_KEY]","pattern":"\\b(sk-[a-zA-Z0-9]{48})\\b"}]
        /// </param>
        /// <param name="description">
        /// Description of the guardrail<br/>
        /// Example: Guardrail for production environment
        /// </param>
        /// <param name="enableFreeModelPublication">
        /// Whether this guardrail allows free endpoints that publish prompts.<br/>
        /// Example: false
        /// </param>
        /// <param name="enableFreeModelTraining">
        /// Whether this guardrail allows free endpoints that train on request data.<br/>
        /// Example: true
        /// </param>
        /// <param name="enablePaidModelTraining">
        /// Whether this guardrail allows paid endpoints that train on request data.<br/>
        /// Example: true
        /// </param>
        /// <param name="enforceZdrAnthropic">
        /// Whether to enforce zero data retention for Anthropic models. Falls back to enforce_zdr when not provided.<br/>
        /// Example: false
        /// </param>
        /// <param name="enforceZdrGoogle">
        /// Whether to enforce zero data retention for Google models. Falls back to enforce_zdr when not provided.<br/>
        /// Example: false
        /// </param>
        /// <param name="enforceZdrOpenai">
        /// Whether to enforce zero data retention for OpenAI models. Falls back to enforce_zdr when not provided.<br/>
        /// Example: false
        /// </param>
        /// <param name="enforceZdrOther">
        /// Whether to enforce zero data retention for models that are not from Anthropic, OpenAI, Google, or xAI. Falls back to enforce_zdr when not provided.<br/>
        /// Example: false
        /// </param>
        /// <param name="enforceZdrXai">
        /// Whether to enforce zero data retention for xAI models. Falls back to enforce_zdr when not provided.<br/>
        /// Example: false
        /// </param>
        /// <param name="ignoredModels">
        /// Array of model canonical_slugs to exclude from routing<br/>
        /// Example: [openai/gpt-4o-mini-2024-07-18]
        /// </param>
        /// <param name="ignoredProviders">
        /// List of provider IDs to exclude from routing<br/>
        /// Example: [azure]
        /// </param>
        /// <param name="limitUsd">
        /// Spending limit in USD<br/>
        /// Example: 100
        /// </param>
        /// <param name="resetInterval">
        /// Interval at which the limit resets (daily, weekly, monthly)<br/>
        /// Example: monthly
        /// </param>
        /// <param name="updatedAt">
        /// ISO 8601 timestamp of when the guardrail was last updated<br/>
        /// Example: 2025-08-24T15:45:00Z
        /// </param>
        /// <param name="workspaceId">
        /// The workspace this guardrail belongs to, or `null` for an unscoped legacy guardrail predating workspaces. Workspace membership organizes the guardrail; it does not apply the guardrail to the workspace's traffic. A `null` value does not mean the default workspace, and does not apply the guardrail across every workspace.<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Guardrail(
            string createdAt,
            global::System.Guid id,
            bool includeByokInBudgets,
            string name,
            bool? allowSafetyRetentionGoogle,
            global::System.Collections.Generic.IList<global::OpenRouter.GuardrailDataRegion>? allowedDataRegions,
            global::System.Collections.Generic.IList<string>? allowedModels,
            global::System.Collections.Generic.IList<string>? allowedProviders,
            global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterBuiltinEntry>? contentFilterBuiltins,
            global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterEntry>? contentFilters,
            string? description,
            bool? enableFreeModelPublication,
            bool? enableFreeModelTraining,
            bool? enablePaidModelTraining,
            bool? enforceZdrAnthropic,
            bool? enforceZdrGoogle,
            bool? enforceZdrOpenai,
            bool? enforceZdrOther,
            bool? enforceZdrXai,
            global::System.Collections.Generic.IList<string>? ignoredModels,
            global::System.Collections.Generic.IList<string>? ignoredProviders,
            double? limitUsd,
            global::OpenRouter.GuardrailInterval? resetInterval,
            string? updatedAt,
            string? workspaceId)
        {
            this.AllowSafetyRetentionGoogle = allowSafetyRetentionGoogle;
            this.AllowedDataRegions = allowedDataRegions;
            this.AllowedModels = allowedModels;
            this.AllowedProviders = allowedProviders;
            this.ContentFilterBuiltins = contentFilterBuiltins;
            this.ContentFilters = contentFilters;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Description = description;
            this.EnableFreeModelPublication = enableFreeModelPublication;
            this.EnableFreeModelTraining = enableFreeModelTraining;
            this.EnablePaidModelTraining = enablePaidModelTraining;
            this.EnforceZdrAnthropic = enforceZdrAnthropic;
            this.EnforceZdrGoogle = enforceZdrGoogle;
            this.EnforceZdrOpenai = enforceZdrOpenai;
            this.EnforceZdrOther = enforceZdrOther;
            this.EnforceZdrXai = enforceZdrXai;
            this.Id = id;
            this.IgnoredModels = ignoredModels;
            this.IgnoredProviders = ignoredProviders;
            this.IncludeByokInBudgets = includeByokInBudgets;
            this.LimitUsd = limitUsd;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ResetInterval = resetInterval;
            this.UpdatedAt = updatedAt;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Guardrail" /> class.
        /// </summary>
        public Guardrail()
        {
        }

    }
}