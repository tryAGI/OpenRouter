#nullable enable

namespace OpenRouter
{
    public partial interface IInternsClient
    {
        /// <summary>
        /// Sign a daemon request with the caller's identity<br/>
        /// Signs the SHA-256 digest of one request the CLI is about to send to the intern daemon, binding it to the intern and to the signed-in member so personal connections resolve. Only an OAuth session from `ori login --oidc` whose grant carries `vault:read` can sign: an API key is refused with 403 because it names no person, and an `interns`-only grant is refused with 403 because a proof releases that user's personal connections. The route is behind the same gate as chat and counts against the chat turn limiter. The response is sent with `Cache-Control: no-store`. The API key selects the caller, workspace and visible interns. An intern's own API key sees only that intern: the collection and every other intern answer 404 to it. There is no default workspace fallback. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
        /// </summary>
        /// <param name="internId">
        /// ID of an intern visible to the authenticated API key.<br/>
        /// Example: 7c9e6679-7425-40de-944b-e07fc1f90ae7
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.SignInternDaemonResponse> SignInternDaemonRequestAsync(
            string internId,

            global::OpenRouter.SignInternDaemonRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sign a daemon request with the caller's identity<br/>
        /// Signs the SHA-256 digest of one request the CLI is about to send to the intern daemon, binding it to the intern and to the signed-in member so personal connections resolve. Only an OAuth session from `ori login --oidc` whose grant carries `vault:read` can sign: an API key is refused with 403 because it names no person, and an `interns`-only grant is refused with 403 because a proof releases that user's personal connections. The route is behind the same gate as chat and counts against the chat turn limiter. The response is sent with `Cache-Control: no-store`. The API key selects the caller, workspace and visible interns. An intern's own API key sees only that intern: the collection and every other intern answer 404 to it. There is no default workspace fallback. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
        /// </summary>
        /// <param name="internId">
        /// ID of an intern visible to the authenticated API key.<br/>
        /// Example: 7c9e6679-7425-40de-944b-e07fc1f90ae7
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.SignInternDaemonResponse>> SignInternDaemonRequestAsResponseAsync(
            string internId,

            global::OpenRouter.SignInternDaemonRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sign a daemon request with the caller's identity<br/>
        /// Signs the SHA-256 digest of one request the CLI is about to send to the intern daemon, binding it to the intern and to the signed-in member so personal connections resolve. Only an OAuth session from `ori login --oidc` whose grant carries `vault:read` can sign: an API key is refused with 403 because it names no person, and an `interns`-only grant is refused with 403 because a proof releases that user's personal connections. The route is behind the same gate as chat and counts against the chat turn limiter. The response is sent with `Cache-Control: no-store`. The API key selects the caller, workspace and visible interns. An intern's own API key sees only that intern: the collection and every other intern answer 404 to it. There is no default workspace fallback. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
        /// </summary>
        /// <param name="internId">
        /// ID of an intern visible to the authenticated API key.<br/>
        /// Example: 7c9e6679-7425-40de-944b-e07fc1f90ae7
        /// </param>
        /// <param name="bodySha256">
        /// Lower-case hex SHA-256 of the exact bytes the CLI will send as the daemon request body.<br/>
        /// Example: e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.SignInternDaemonResponse> SignInternDaemonRequestAsync(
            string internId,
            string bodySha256,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}