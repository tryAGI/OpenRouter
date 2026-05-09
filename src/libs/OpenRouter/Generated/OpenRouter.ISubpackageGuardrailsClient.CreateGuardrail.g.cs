#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageGuardrailsClient
    {
        /// <summary>
        /// Create a guardrail<br/>
        /// Create a new guardrail for the authenticated user. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreateGuardrailResponse> CreateGuardrailAsync(

            global::OpenRouter.CreateGuardrailRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a guardrail<br/>
        /// Create a new guardrail for the authenticated user. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.CreateGuardrailResponse>> CreateGuardrailAsResponseAsync(

            global::OpenRouter.CreateGuardrailRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a guardrail<br/>
        /// Create a new guardrail for the authenticated user. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="allowedModels">
        /// Array of model identifiers (slug or canonical_slug accepted)
        /// </param>
        /// <param name="allowedProviders">
        /// List of allowed provider IDs
        /// </param>
        /// <param name="contentFilterBuiltins">
        /// Builtin content filters to apply. The "flag" action is only supported for "regex-prompt-injection"; PII slugs (email, phone, ssn, credit-card, ip-address, person-name, address) accept "block" or "redact" only.
        /// </param>
        /// <param name="contentFilters">
        /// Custom regex content filters to apply to request messages
        /// </param>
        /// <param name="description">
        /// Description of the guardrail
        /// </param>
        /// <param name="enforceZdr">
        /// Deprecated. Use enforce_zdr_anthropic, enforce_zdr_openai, enforce_zdr_google, and enforce_zdr_other instead. When provided, its value is copied into any of those per-provider fields that are not explicitly specified on the request.
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
        /// Whether to enforce zero data retention for models that are not from Anthropic, OpenAI, or Google. Falls back to enforce_zdr when not provided.
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
        /// <param name="name">
        /// Name for the new guardrail
        /// </param>
        /// <param name="resetInterval">
        /// Interval at which the limit resets (daily, weekly, monthly)
        /// </param>
        /// <param name="workspaceId">
        /// The workspace to create the guardrail in. Defaults to the default workspace if not provided.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreateGuardrailResponse> CreateGuardrailAsync(
            string name,
            global::System.Collections.Generic.IList<string>? allowedModels = default,
            global::System.Collections.Generic.IList<string>? allowedProviders = default,
            global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterBuiltinEntry>? contentFilterBuiltins = default,
            global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterEntry>? contentFilters = default,
            string? description = default,
            bool? enforceZdr = default,
            bool? enforceZdrAnthropic = default,
            bool? enforceZdrGoogle = default,
            bool? enforceZdrOpenai = default,
            bool? enforceZdrOther = default,
            global::System.Collections.Generic.IList<string>? ignoredModels = default,
            global::System.Collections.Generic.IList<string>? ignoredProviders = default,
            double? limitUsd = default,
            global::OpenRouter.GuardrailInterval? resetInterval = default,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}