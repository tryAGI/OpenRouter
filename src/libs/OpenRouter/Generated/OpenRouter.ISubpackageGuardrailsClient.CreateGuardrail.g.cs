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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreateGuardrailResponse> CreateGuardrailAsync(

            global::OpenRouter.CreateGuardrailRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a guardrail<br/>
        /// Create a new guardrail for the authenticated user. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="name">
        /// Name for the new guardrail
        /// </param>
        /// <param name="description">
        /// Description of the guardrail
        /// </param>
        /// <param name="limitUsd">
        /// Spending limit in USD
        /// </param>
        /// <param name="resetInterval"></param>
        /// <param name="allowedProviders">
        /// List of allowed provider IDs
        /// </param>
        /// <param name="ignoredProviders">
        /// List of provider IDs to exclude from routing
        /// </param>
        /// <param name="allowedModels">
        /// Array of model identifiers (slug or canonical_slug accepted)
        /// </param>
        /// <param name="enforceZdr">
        /// Whether to enforce zero data retention
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreateGuardrailResponse> CreateGuardrailAsync(
            string name,
            string? description = default,
            double? limitUsd = default,
            global::OpenRouter.CreateGuardrailRequestResetInterval? resetInterval = default,
            global::System.Collections.Generic.IList<string>? allowedProviders = default,
            global::System.Collections.Generic.IList<string>? ignoredProviders = default,
            global::System.Collections.Generic.IList<string>? allowedModels = default,
            bool? enforceZdr = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}