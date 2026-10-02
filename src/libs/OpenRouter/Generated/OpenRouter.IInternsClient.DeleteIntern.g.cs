#nullable enable

namespace OpenRouter
{
    public partial interface IInternsClient
    {
        /// <summary>
        /// Delete an intern<br/>
        /// Starts safe teardown of the intern, its runtime and its private vault. The body is optional. Send `{"acknowledge_workspace_loss": true}` to delete a `destroy_failed` intern whose `last_failure_message` names `workspace_archive_failed`, accepting that its workspace is not backed up. The request body is capped at 1048576 bytes and a larger body is refused with 413. A non-empty body must declare `Content-Type: application/json` or it is refused with 415. The API key selects the caller, workspace and visible interns. An intern's own API key sees only that intern: the collection and every other intern answer 404 to it. There is no default workspace fallback. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
        /// </summary>
        /// <param name="internId">
        /// ID of an intern visible to the authenticated API key.<br/>
        /// Example: 7c9e6679-7425-40de-944b-e07fc1f90ae7
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.DeleteInternResponse> DeleteInternAsync(
            string internId,

            global::OpenRouter.DeleteInternRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an intern<br/>
        /// Starts safe teardown of the intern, its runtime and its private vault. The body is optional. Send `{"acknowledge_workspace_loss": true}` to delete a `destroy_failed` intern whose `last_failure_message` names `workspace_archive_failed`, accepting that its workspace is not backed up. The request body is capped at 1048576 bytes and a larger body is refused with 413. A non-empty body must declare `Content-Type: application/json` or it is refused with 415. The API key selects the caller, workspace and visible interns. An intern's own API key sees only that intern: the collection and every other intern answer 404 to it. There is no default workspace fallback. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
        /// </summary>
        /// <param name="internId">
        /// ID of an intern visible to the authenticated API key.<br/>
        /// Example: 7c9e6679-7425-40de-944b-e07fc1f90ae7
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.DeleteInternResponse>> DeleteInternAsResponseAsync(
            string internId,

            global::OpenRouter.DeleteInternRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an intern<br/>
        /// Starts safe teardown of the intern, its runtime and its private vault. The body is optional. Send `{"acknowledge_workspace_loss": true}` to delete a `destroy_failed` intern whose `last_failure_message` names `workspace_archive_failed`, accepting that its workspace is not backed up. The request body is capped at 1048576 bytes and a larger body is refused with 413. A non-empty body must declare `Content-Type: application/json` or it is refused with 415. The API key selects the caller, workspace and visible interns. An intern's own API key sees only that intern: the collection and every other intern answer 404 to it. There is no default workspace fallback. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
        /// </summary>
        /// <param name="internId">
        /// ID of an intern visible to the authenticated API key.<br/>
        /// Example: 7c9e6679-7425-40de-944b-e07fc1f90ae7
        /// </param>
        /// <param name="acknowledgeWorkspaceLoss">
        /// Delete even though the workspace backup was not confirmed. Defaults to false, which refuses the teardown when a workspace archive is missing.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.DeleteInternResponse> DeleteInternAsync(
            string internId,
            bool? acknowledgeWorkspaceLoss = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}