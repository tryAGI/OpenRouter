#nullable enable

namespace OpenRouter
{
    public partial interface IInternsClient
    {
        /// <summary>
        /// Get an intern's daemon access<br/>
        /// Returns the origin and daemon token that attach `ori tui --host` to one visible, running intern. The token is a credential: the response is sent with `Cache-Control: no-store`, and each reveal is logged by caller and intern. The API key selects the caller, workspace and visible interns. An intern's own API key sees only that intern: the collection and every other intern answer 404 to it. There is no default workspace fallback. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
        /// </summary>
        /// <param name="internId">
        /// ID of an intern visible to the authenticated API key.<br/>
        /// Example: 7c9e6679-7425-40de-944b-e07fc1f90ae7
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.InternDaemonAccess> GetInternDaemonAsync(
            string internId,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an intern's daemon access<br/>
        /// Returns the origin and daemon token that attach `ori tui --host` to one visible, running intern. The token is a credential: the response is sent with `Cache-Control: no-store`, and each reveal is logged by caller and intern. The API key selects the caller, workspace and visible interns. An intern's own API key sees only that intern: the collection and every other intern answer 404 to it. There is no default workspace fallback. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
        /// </summary>
        /// <param name="internId">
        /// ID of an intern visible to the authenticated API key.<br/>
        /// Example: 7c9e6679-7425-40de-944b-e07fc1f90ae7
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.InternDaemonAccess>> GetInternDaemonAsResponseAsync(
            string internId,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}