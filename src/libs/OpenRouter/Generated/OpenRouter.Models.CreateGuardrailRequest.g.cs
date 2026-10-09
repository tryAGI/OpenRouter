
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"allowed_models":null,"allowed_providers":["openai","anthropic","deepseek"],"content_filter_builtins":[{"action":"block","slug":"regex-prompt-injection"}],"content_filters":null,"description":"A guardrail for limiting API usage","enforce_zdr_anthropic":true,"enforce_zdr_google":false,"enforce_zdr_openai":true,"enforce_zdr_other":false,"enforce_zdr_xai":false,"ignored_models":null,"ignored_providers":null,"limit_usd":50,"name":"My New Guardrail","reset_interval":"monthly"}
    /// </summary>
    public sealed partial class CreateGuardrailRequest
    {
        /// <summary>
        /// Data regions through which requests governed by this guardrail must arrive. `global` is https://openrouter.ai, `europe` is https://eu.openrouter.ai, and `us` is https://us.openrouter.ai. Requests arriving through any other region are rejected. `null` leaves the ingress region unrestricted. When several guardrails apply (workspace default, member, API key), the effective regions are the intersection of every non-null value. An empty array is rejected.<br/>
        /// Example: [europe]
        /// </summary>
        /// <example>[europe]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_data_regions")]
        public global::System.Collections.Generic.IList<global::OpenRouter.GuardrailDataRegion>? AllowedDataRegions { get; set; }

        /// <summary>
        /// Array of model identifiers (slug or canonical_slug accepted)<br/>
        /// Example: [openai/gpt-5.2, anthropic/claude-4.5-opus-20251124, deepseek/deepseek-r1-0528:free]
        /// </summary>
        /// <example>[openai/gpt-5.2, anthropic/claude-4.5-opus-20251124, deepseek/deepseek-r1-0528:free]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_models")]
        public global::System.Collections.Generic.IList<string>? AllowedModels { get; set; }

        /// <summary>
        /// List of allowed provider IDs<br/>
        /// Example: [openai, anthropic, deepseek]
        /// </summary>
        /// <example>[openai, anthropic, deepseek]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_providers")]
        public global::System.Collections.Generic.IList<string>? AllowedProviders { get; set; }

        /// <summary>
        /// Builtin content filters to apply. Every builtin slug supports "block", "redact", and the detect-only "flag" action.<br/>
        /// Example: [{"action":"block","slug":"regex-prompt-injection"}]
        /// </summary>
        /// <example>[{"action":"block","slug":"regex-prompt-injection"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_filter_builtins")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterBuiltinEntryInput>? ContentFilterBuiltins { get; set; }

        /// <summary>
        /// Custom regex content filters to apply to request messages<br/>
        /// Example: [{"action":"redact","label":"[API_KEY]","pattern":"\\b(sk-[a-zA-Z0-9]{48})\\b"}]
        /// </summary>
        /// <example>[{"action":"redact","label":"[API_KEY]","pattern":"\\b(sk-[a-zA-Z0-9]{48})\\b"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_filters")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterEntry>? ContentFilters { get; set; }

        /// <summary>
        /// Description of the guardrail<br/>
        /// Example: A guardrail for limiting API usage
        /// </summary>
        /// <example>A guardrail for limiting API usage</example>
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
        /// Array of model identifiers to exclude from routing (slug or canonical_slug accepted)<br/>
        /// Example: [openai/gpt-4o-mini]
        /// </summary>
        /// <example>[openai/gpt-4o-mini]</example>
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
        /// Whether BYOK (bring-your-own-key) inference spend counts toward this guardrail's limit_usd, in addition to OpenRouter credit spend. Defaults to false.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_byok_in_budgets")]
        public bool? IncludeByokInBudgets { get; set; }

        /// <summary>
        /// Spending limit in USD. Must be provided together with `reset_interval`: a request that sets only one of the two is rejected with a 400.<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_usd")]
        public double? LimitUsd { get; set; }

        /// <summary>
        /// Name for the new guardrail<br/>
        /// Example: My New Guardrail
        /// </summary>
        /// <example>My New Guardrail</example>
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
        /// The workspace to create the guardrail in. When omitted, the guardrail is created in the default workspace; if that default has been deleted, the request returns a 400 and you must pass `workspace_id` explicitly. This only places the guardrail in the workspace; the created guardrail enforces nothing for that workspace's traffic until it is assigned to API keys or members. To restrict all traffic in a workspace, update the workspace's default guardrail instead.<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </summary>
        /// <example>0df9e665-d932-5740-b2c7-b52af166bc11</example>
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
        /// Name for the new guardrail<br/>
        /// Example: My New Guardrail
        /// </param>
        /// <param name="allowedDataRegions">
        /// Data regions through which requests governed by this guardrail must arrive. `global` is https://openrouter.ai, `europe` is https://eu.openrouter.ai, and `us` is https://us.openrouter.ai. Requests arriving through any other region are rejected. `null` leaves the ingress region unrestricted. When several guardrails apply (workspace default, member, API key), the effective regions are the intersection of every non-null value. An empty array is rejected.<br/>
        /// Example: [europe]
        /// </param>
        /// <param name="allowedModels">
        /// Array of model identifiers (slug or canonical_slug accepted)<br/>
        /// Example: [openai/gpt-5.2, anthropic/claude-4.5-opus-20251124, deepseek/deepseek-r1-0528:free]
        /// </param>
        /// <param name="allowedProviders">
        /// List of allowed provider IDs<br/>
        /// Example: [openai, anthropic, deepseek]
        /// </param>
        /// <param name="contentFilterBuiltins">
        /// Builtin content filters to apply. Every builtin slug supports "block", "redact", and the detect-only "flag" action.<br/>
        /// Example: [{"action":"block","slug":"regex-prompt-injection"}]
        /// </param>
        /// <param name="contentFilters">
        /// Custom regex content filters to apply to request messages<br/>
        /// Example: [{"action":"redact","label":"[API_KEY]","pattern":"\\b(sk-[a-zA-Z0-9]{48})\\b"}]
        /// </param>
        /// <param name="description">
        /// Description of the guardrail<br/>
        /// Example: A guardrail for limiting API usage
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
        /// Array of model identifiers to exclude from routing (slug or canonical_slug accepted)<br/>
        /// Example: [openai/gpt-4o-mini]
        /// </param>
        /// <param name="ignoredProviders">
        /// List of provider IDs to exclude from routing<br/>
        /// Example: [azure]
        /// </param>
        /// <param name="includeByokInBudgets">
        /// Whether BYOK (bring-your-own-key) inference spend counts toward this guardrail's limit_usd, in addition to OpenRouter credit spend. Defaults to false.<br/>
        /// Example: false
        /// </param>
        /// <param name="limitUsd">
        /// Spending limit in USD. Must be provided together with `reset_interval`: a request that sets only one of the two is rejected with a 400.<br/>
        /// Example: 50
        /// </param>
        /// <param name="resetInterval">
        /// Interval at which the limit resets (daily, weekly, monthly)<br/>
        /// Example: monthly
        /// </param>
        /// <param name="workspaceId">
        /// The workspace to create the guardrail in. When omitted, the guardrail is created in the default workspace; if that default has been deleted, the request returns a 400 and you must pass `workspace_id` explicitly. This only places the guardrail in the workspace; the created guardrail enforces nothing for that workspace's traffic until it is assigned to API keys or members. To restrict all traffic in a workspace, update the workspace's default guardrail instead.<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGuardrailRequest(
            string name,
            global::System.Collections.Generic.IList<global::OpenRouter.GuardrailDataRegion>? allowedDataRegions,
            global::System.Collections.Generic.IList<string>? allowedModels,
            global::System.Collections.Generic.IList<string>? allowedProviders,
            global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterBuiltinEntryInput>? contentFilterBuiltins,
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
            bool? includeByokInBudgets,
            double? limitUsd,
            global::OpenRouter.GuardrailInterval? resetInterval,
            global::System.Guid? workspaceId)
        {
            this.AllowedDataRegions = allowedDataRegions;
            this.AllowedModels = allowedModels;
            this.AllowedProviders = allowedProviders;
            this.ContentFilterBuiltins = contentFilterBuiltins;
            this.ContentFilters = contentFilters;
            this.Description = description;
            this.EnableFreeModelPublication = enableFreeModelPublication;
            this.EnableFreeModelTraining = enableFreeModelTraining;
            this.EnablePaidModelTraining = enablePaidModelTraining;
            this.EnforceZdrAnthropic = enforceZdrAnthropic;
            this.EnforceZdrGoogle = enforceZdrGoogle;
            this.EnforceZdrOpenai = enforceZdrOpenai;
            this.EnforceZdrOther = enforceZdrOther;
            this.EnforceZdrXai = enforceZdrXai;
            this.IgnoredModels = ignoredModels;
            this.IgnoredProviders = ignoredProviders;
            this.IncludeByokInBudgets = includeByokInBudgets;
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