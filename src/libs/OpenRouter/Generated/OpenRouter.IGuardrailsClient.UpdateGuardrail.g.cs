#nullable enable

namespace OpenRouter
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Update a guardrail<br/>
        /// Update an existing guardrail. Collection fields use replace semantics: send the full desired set on every update. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.UpdateGuardrailResponse> UpdateGuardrailAsync(
            global::System.Guid id,

            global::OpenRouter.UpdateGuardrailRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a guardrail<br/>
        /// Update an existing guardrail. Collection fields use replace semantics: send the full desired set on every update. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.UpdateGuardrailResponse>> UpdateGuardrailAsResponseAsync(
            global::System.Guid id,

            global::OpenRouter.UpdateGuardrailRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a guardrail<br/>
        /// Update an existing guardrail. Collection fields use replace semantics: send the full desired set on every update. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="allowedModels">
        /// Array of model identifiers (slug or canonical_slug accepted)
        /// </param>
        /// <param name="allowedProviders">
        /// New list of allowed provider IDs
        /// </param>
        /// <param name="contentFilterBuiltins">
        /// Builtin content filters to apply. Set to null to remove. The "flag" action is only supported for "regex-prompt-injection"; PII slugs (email, phone, ssn, credit-card, ip-address, person-name, address) accept "block" or "redact" only.
        /// </param>
        /// <param name="contentFilters">
        /// Custom regex content filters to apply. Set to null to remove.
        /// </param>
        /// <param name="description">
        /// New description for the guardrail
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
        /// New spending limit in USD
        /// </param>
        /// <param name="name">
        /// New name for the guardrail
        /// </param>
        /// <param name="resetInterval">
        /// Interval at which the limit resets (daily, weekly, monthly)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.UpdateGuardrailResponse> UpdateGuardrailAsync(
            global::System.Guid id,
            global::System.Collections.Generic.IList<string>? allowedModels = default,
            global::System.Collections.Generic.IList<string>? allowedProviders = default,
            global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterBuiltinEntryInput>? contentFilterBuiltins = default,
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
            string? name = default,
            global::OpenRouter.GuardrailInterval? resetInterval = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}