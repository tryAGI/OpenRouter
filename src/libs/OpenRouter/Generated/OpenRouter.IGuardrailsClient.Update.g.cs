#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Update a guardrail<br/>
        /// Update an existing guardrail, or materialize an unconfigured workspace default guardrail. Collection fields use replace semantics: send the full desired set on every update. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the guardrail to update<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.UpdateGuardrailResponse> UpdateAsync(
            global::System.Guid id,

            global::OpenRouter.UpdateGuardrailRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a guardrail<br/>
        /// Update an existing guardrail, or materialize an unconfigured workspace default guardrail. Collection fields use replace semantics: send the full desired set on every update. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the guardrail to update<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.UpdateGuardrailResponse>> UpdateAsResponseAsync(
            global::System.Guid id,

            global::OpenRouter.UpdateGuardrailRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a guardrail<br/>
        /// Update an existing guardrail, or materialize an unconfigured workspace default guardrail. Collection fields use replace semantics: send the full desired set on every update. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the guardrail to update<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="allowedDataRegions">
        /// Data regions through which requests governed by this guardrail must arrive. `global` is https://openrouter.ai, `europe` is https://eu.openrouter.ai, and `us` is https://us.openrouter.ai. Requests arriving through any other region are rejected. `null` leaves the ingress region unrestricted. When several guardrails apply (workspace default, member, API key), the effective regions are the intersection of every non-null value. An empty array is rejected.<br/>
        /// Example: [europe]
        /// </param>
        /// <param name="allowedModels">
        /// Array of model identifiers (slug or canonical_slug accepted)<br/>
        /// Example: [openai/gpt-5.2]
        /// </param>
        /// <param name="allowedProviders">
        /// New list of allowed provider IDs<br/>
        /// Example: [openai, anthropic, deepseek]
        /// </param>
        /// <param name="contentFilterBuiltins">
        /// Builtin content filters to apply. Set to null to remove. Every builtin slug supports "block", "redact", and the detect-only "flag" action.<br/>
        /// Example: [{"action":"block","slug":"regex-prompt-injection"}]
        /// </param>
        /// <param name="contentFilters">
        /// Custom regex content filters to apply. Set to null to remove.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description">
        /// New description for the guardrail<br/>
        /// Example: Updated description
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
        /// Example: true
        /// </param>
        /// <param name="enforceZdrGoogle">
        /// Whether to enforce zero data retention for Google models. Falls back to enforce_zdr when not provided.<br/>
        /// Example: true
        /// </param>
        /// <param name="enforceZdrOpenai">
        /// Whether to enforce zero data retention for OpenAI models. Falls back to enforce_zdr when not provided.<br/>
        /// Example: true
        /// </param>
        /// <param name="enforceZdrOther">
        /// Whether to enforce zero data retention for models that are not from Anthropic, OpenAI, Google, or xAI. Falls back to enforce_zdr when not provided.<br/>
        /// Example: true
        /// </param>
        /// <param name="enforceZdrXai">
        /// Whether to enforce zero data retention for xAI models. Falls back to enforce_zdr when not provided.<br/>
        /// Example: true
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
        /// Whether BYOK (bring-your-own-key) inference spend counts toward this guardrail's limit_usd, in addition to OpenRouter credit spend. Omit to leave unchanged.<br/>
        /// Example: true
        /// </param>
        /// <param name="limitUsd">
        /// New spending limit in USD<br/>
        /// Example: 75
        /// </param>
        /// <param name="name">
        /// New name for the guardrail<br/>
        /// Example: Updated Guardrail Name
        /// </param>
        /// <param name="resetInterval">
        /// Interval at which the limit resets (daily, weekly, monthly)<br/>
        /// Example: monthly
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.UpdateGuardrailResponse> UpdateAsync(
            global::System.Guid id,
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
            string? name = default,
            global::OpenRouter.GuardrailInterval? resetInterval = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}