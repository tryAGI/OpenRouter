#nullable enable

namespace OpenRouter
{
    public partial interface IVaultClient
    {
        /// <summary>
        /// List intern secrets<br/>
        /// Lists secret metadata stored for one intern. The list includes secrets stored from the dashboard or at provisioning before workspace-scoped storage; where both exist under one name, the one stored through this API is listed. Those older secrets cannot be deleted or copied through this API, and storing the same name through this API replaces them. Responses contain names, bound hosts, fingerprints and creation times, never secret values. Results are ordered by name and paginated with `limit` and `offset`. The scope is selected by the API key: workspace routes act on the key's active workspace and intern routes act on one intern inside that workspace. There is no default workspace and no fallback to another scope. Every vault route, including reads, requires access to the Intern API programme and returns 404 outside it. An intern's own API key is confined to that intern: it can always read the intern's secrets and effective secrets, writes to them follow the rules above, and every other intern and every workspace route answers 404. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
        /// </summary>
        /// <param name="internId">
        /// UUID of an intern in the workspace selected by the API key.<br/>
        /// Example: 7c9e6679-7425-40de-944b-e07fc1f90ae7
        /// </param>
        /// <param name="limit">
        /// Page size, 1 to 100. Defaults to 100.<br/>
        /// Default Value: 100<br/>
        /// Example: 50
        /// </param>
        /// <param name="offset">
        /// Number of secrets to skip, 0 to 10000. Defaults to 0.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.VaultSecretListResponse> ListInternVaultSecretsAsync(
            global::System.Guid internId,
            int? limit = default,
            int? offset = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List intern secrets<br/>
        /// Lists secret metadata stored for one intern. The list includes secrets stored from the dashboard or at provisioning before workspace-scoped storage; where both exist under one name, the one stored through this API is listed. Those older secrets cannot be deleted or copied through this API, and storing the same name through this API replaces them. Responses contain names, bound hosts, fingerprints and creation times, never secret values. Results are ordered by name and paginated with `limit` and `offset`. The scope is selected by the API key: workspace routes act on the key's active workspace and intern routes act on one intern inside that workspace. There is no default workspace and no fallback to another scope. Every vault route, including reads, requires access to the Intern API programme and returns 404 outside it. An intern's own API key is confined to that intern: it can always read the intern's secrets and effective secrets, writes to them follow the rules above, and every other intern and every workspace route answers 404. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
        /// </summary>
        /// <param name="internId">
        /// UUID of an intern in the workspace selected by the API key.<br/>
        /// Example: 7c9e6679-7425-40de-944b-e07fc1f90ae7
        /// </param>
        /// <param name="limit">
        /// Page size, 1 to 100. Defaults to 100.<br/>
        /// Default Value: 100<br/>
        /// Example: 50
        /// </param>
        /// <param name="offset">
        /// Number of secrets to skip, 0 to 10000. Defaults to 0.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.VaultSecretListResponse>> ListInternVaultSecretsAsResponseAsync(
            global::System.Guid internId,
            int? limit = default,
            int? offset = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}