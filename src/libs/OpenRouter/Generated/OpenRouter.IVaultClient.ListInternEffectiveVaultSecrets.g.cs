#nullable enable

namespace OpenRouter
{
    public partial interface IVaultClient
    {
        /// <summary>
        /// List the secrets an intern receives<br/>
        /// Lists, one entry per name, the secret the intern's outbound requests receive: its own secrets, secrets from an attached vault, and workspace secrets, including ones stored before workspace-scoped storage. Where several vaults hold a name, the entry is the one that wins, in the order intern, attached, workspace. The same resolution decides what outbound requests receive, so this list and the intern's requests agree. `scope` says which vault the entry comes from. Responses carry metadata only, never values. Results are ordered by name and paginated with `limit` and `offset`. Returns 404 when the intern's attached vault is no longer available, since the intern then receives no secrets. The scope is selected by the API key: workspace routes act on the key's active workspace and intern routes act on one intern inside that workspace. There is no default workspace and no fallback to another scope. Every vault route, including reads, requires access to the Intern API programme and returns 404 outside it. An intern's own API key is confined to that intern: it can always read the intern's secrets and effective secrets, writes to them follow the rules above, and every other intern and every workspace route answers 404. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
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
        global::System.Threading.Tasks.Task<global::OpenRouter.VaultEffectiveSecretListResponse> ListInternEffectiveVaultSecretsAsync(
            global::System.Guid internId,
            int? limit = default,
            int? offset = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List the secrets an intern receives<br/>
        /// Lists, one entry per name, the secret the intern's outbound requests receive: its own secrets, secrets from an attached vault, and workspace secrets, including ones stored before workspace-scoped storage. Where several vaults hold a name, the entry is the one that wins, in the order intern, attached, workspace. The same resolution decides what outbound requests receive, so this list and the intern's requests agree. `scope` says which vault the entry comes from. Responses carry metadata only, never values. Results are ordered by name and paginated with `limit` and `offset`. Returns 404 when the intern's attached vault is no longer available, since the intern then receives no secrets. The scope is selected by the API key: workspace routes act on the key's active workspace and intern routes act on one intern inside that workspace. There is no default workspace and no fallback to another scope. Every vault route, including reads, requires access to the Intern API programme and returns 404 outside it. An intern's own API key is confined to that intern: it can always read the intern's secrets and effective secrets, writes to them follow the rules above, and every other intern and every workspace route answers 404. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
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
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.VaultEffectiveSecretListResponse>> ListInternEffectiveVaultSecretsAsResponseAsync(
            global::System.Guid internId,
            int? limit = default,
            int? offset = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}