#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageGuardrailsClient
    {
        /// <summary>
        /// List guardrails<br/>
        /// List all guardrails for the authenticated user. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.GuardrailsListGuardrailsResponse200> ListGuardrailsAsync(
            string? offset = default,
            string? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}