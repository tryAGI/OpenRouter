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
        /// <param name="allowedModels">
        /// Array of model identifiers (slug or canonical_slug accepted)
        /// </param>
        /// <param name="allowedProviders">
        /// List of allowed provider IDs
        /// </param>
        /// <param name="description">
        /// Description of the guardrail
        /// </param>
        /// <param name="enforceZdr">
        /// Whether to enforce zero data retention
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreateGuardrailResponse> CreateGuardrailAsync(
            string name,
            global::System.Collections.Generic.IList<string>? allowedModels = default,
            global::System.Collections.Generic.IList<string>? allowedProviders = default,
            string? description = default,
            bool? enforceZdr = default,
            global::System.Collections.Generic.IList<string>? ignoredModels = default,
            global::System.Collections.Generic.IList<string>? ignoredProviders = default,
            double? limitUsd = default,
            global::OpenRouter.GuardrailInterval? resetInterval = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}