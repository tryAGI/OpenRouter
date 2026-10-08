#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Create a guardrail<br/>
        /// Create a new guardrail for the authenticated user. A newly created guardrail enforces nothing until it is assigned to API keys or organization members; `workspace_id` places the guardrail in a workspace but does not apply it to that workspace's traffic. To restrict all traffic in a workspace, update the workspace's default guardrail instead. Set `allowed_data_regions` to enforce [In-Region Routing](/docs/guides/features/in-region-routing#enforcing-in-region-routing-with-guardrails): governed requests must arrive through one of the listed OpenRouter domains and are rejected with a 403 otherwise. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreateGuardrailResponse> CreateAsync(

            global::OpenRouter.CreateGuardrailRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a guardrail<br/>
        /// Create a new guardrail for the authenticated user. A newly created guardrail enforces nothing until it is assigned to API keys or organization members; `workspace_id` places the guardrail in a workspace but does not apply it to that workspace's traffic. To restrict all traffic in a workspace, update the workspace's default guardrail instead. Set `allowed_data_regions` to enforce [In-Region Routing](/docs/guides/features/in-region-routing#enforcing-in-region-routing-with-guardrails): governed requests must arrive through one of the listed OpenRouter domains and are rejected with a 403 otherwise. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.CreateGuardrailResponse>> CreateAsResponseAsync(

            global::OpenRouter.CreateGuardrailRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a guardrail<br/>
        /// Create a new guardrail for the authenticated user. A newly created guardrail enforces nothing until it is assigned to API keys or organization members; `workspace_id` places the guardrail in a workspace but does not apply it to that workspace's traffic. To restrict all traffic in a workspace, update the workspace's default guardrail instead. Set `allowed_data_regions` to enforce [In-Region Routing](/docs/guides/features/in-region-routing#enforcing-in-region-routing-with-guardrails): governed requests must arrive through one of the listed OpenRouter domains and are rejected with a 403 otherwise. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="allowSafetyRetentionGoogle">
        /// Whether ZDR requests for Google models may use Safety Retention endpoints, which keep only prompts flagged by safety classifiers. `false` requires strict ZDR for Google. `null` inherits the account setting, which is on by default. A guardrail cannot turn this on for an account that turned it off.<br/>
        /// Example: true
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
        /// <param name="name">
        /// Name for the new guardrail<br/>
        /// Example: My New Guardrail
        /// </param>
        /// <param name="resetInterval">
        /// Interval at which the limit resets (daily, weekly, monthly)<br/>
        /// Example: monthly
        /// </param>
        /// <param name="workspaceId">
        /// The workspace to create the guardrail in. When omitted, the guardrail is created in the default workspace; if that default has been deleted, the request returns a 400 and you must pass `workspace_id` explicitly. This only places the guardrail in the workspace; the created guardrail enforces nothing for that workspace's traffic until it is assigned to API keys or members. To restrict all traffic in a workspace, update the workspace's default guardrail instead.<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreateGuardrailResponse> CreateAsync(
            string name,
            bool? allowSafetyRetentionGoogle = default,
            global::System.Collections.Generic.IList<global::OpenRouter.GuardrailDataRegion>? allowedDataRegions = default,
            global::System.Collections.Generic.IList<string>? allowedModels = default,
            global::System.Collections.Generic.IList<string>? allowedProviders = default,
            global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterBuiltinEntryInput>? contentFilterBuiltins = default,
            global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterEntry>? contentFilters = default,
            string? description = default,
            bool? enableFreeModelPublication = default,
            bool? enableFreeModelTraining = default,
            bool? enablePaidModelTraining = default,
            bool? enforceZdrAnthropic = default,
            bool? enforceZdrGoogle = default,
            bool? enforceZdrOpenai = default,
            bool? enforceZdrOther = default,
            bool? enforceZdrXai = default,
            global::System.Collections.Generic.IList<string>? ignoredModels = default,
            global::System.Collections.Generic.IList<string>? ignoredProviders = default,
            bool? includeByokInBudgets = default,
            double? limitUsd = default,
            global::OpenRouter.GuardrailInterval? resetInterval = default,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}