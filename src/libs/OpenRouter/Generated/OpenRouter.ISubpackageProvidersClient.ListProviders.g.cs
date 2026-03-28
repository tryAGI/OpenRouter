#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageProvidersClient
    {
        /// <summary>
        /// List all providers
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ProvidersListProvidersResponse200> ListProvidersAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}