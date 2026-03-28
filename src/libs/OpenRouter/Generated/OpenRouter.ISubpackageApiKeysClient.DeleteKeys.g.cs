#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageApiKeysClient
    {
        /// <summary>
        /// Delete an API key<br/>
        /// Delete an existing API key. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="hash"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ApiKeysDeleteKeysResponse200> DeleteKeysAsync(
            string hash,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}