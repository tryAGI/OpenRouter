#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageApiKeysClient
    {
        /// <summary>
        /// Get current API key<br/>
        /// Get information on the API key associated with the current authentication session
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ApiKeysGetCurrentKeyResponse200> GetCurrentKeyAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}