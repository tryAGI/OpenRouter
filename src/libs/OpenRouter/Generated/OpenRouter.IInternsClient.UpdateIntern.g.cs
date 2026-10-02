#nullable enable

namespace OpenRouter
{
    public partial interface IInternsClient
    {
        /// <summary>
        /// Update an intern<br/>
        /// Changes the intern name, description, instructions or model. Omitted fields stay unchanged. The request body is capped at 1048576 bytes and a larger body is refused with 413. A non-empty body must declare `Content-Type: application/json` or it is refused with 415. The API key selects the caller, workspace and visible interns. An intern's own API key sees only that intern: the collection and every other intern answer 404 to it. There is no default workspace fallback. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
        /// </summary>
        /// <param name="internId">
        /// ID of an intern visible to the authenticated API key.<br/>
        /// Example: 7c9e6679-7425-40de-944b-e07fc1f90ae7
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.Intern> UpdateInternAsync(
            string internId,

            global::OpenRouter.UpdateInternRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an intern<br/>
        /// Changes the intern name, description, instructions or model. Omitted fields stay unchanged. The request body is capped at 1048576 bytes and a larger body is refused with 413. A non-empty body must declare `Content-Type: application/json` or it is refused with 415. The API key selects the caller, workspace and visible interns. An intern's own API key sees only that intern: the collection and every other intern answer 404 to it. There is no default workspace fallback. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
        /// </summary>
        /// <param name="internId">
        /// ID of an intern visible to the authenticated API key.<br/>
        /// Example: 7c9e6679-7425-40de-944b-e07fc1f90ae7
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.Intern>> UpdateInternAsResponseAsync(
            string internId,

            global::OpenRouter.UpdateInternRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an intern<br/>
        /// Changes the intern name, description, instructions or model. Omitted fields stay unchanged. The request body is capped at 1048576 bytes and a larger body is refused with 413. A non-empty body must declare `Content-Type: application/json` or it is refused with 415. The API key selects the caller, workspace and visible interns. An intern's own API key sees only that intern: the collection and every other intern answer 404 to it. There is no default workspace fallback. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
        /// </summary>
        /// <param name="internId">
        /// ID of an intern visible to the authenticated API key.<br/>
        /// Example: 7c9e6679-7425-40de-944b-e07fc1f90ae7
        /// </param>
        /// <param name="description">
        /// New free-form description. Null clears it.
        /// </param>
        /// <param name="instructions">
        /// New standing instructions. Null clears them.
        /// </param>
        /// <param name="model">
        /// New OpenRouter model slug in `author/slug` form (an optional `:variant` suffix is accepted). Other shapes are refused with 400. Null restores the workspace default. Takes effect on the next provision: until then `GET` shows this configured model while chat chunks show the model the running intern reports.
        /// </param>
        /// <param name="name">
        /// New intern name, unique per creator within the workspace.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.Intern> UpdateInternAsync(
            string internId,
            string? description = default,
            string? instructions = default,
            string? model = default,
            string? name = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}