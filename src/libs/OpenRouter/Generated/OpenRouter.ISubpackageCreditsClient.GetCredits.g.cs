#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageCreditsClient
    {
        /// <summary>
        /// Get remaining credits<br/>
        /// Get total credits purchased and used for the authenticated user. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreditsGetCreditsResponse200> GetCreditsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}