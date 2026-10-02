#nullable enable

namespace OpenRouter
{
    public partial interface IVaultClient
    {
        /// <summary>
        /// Copy workspace secrets to an intern<br/>
        /// Copies the named workspace secrets into one intern's scope, replacing any intern secret with the same name. Each copy keeps the source value and host bindings. Every name must exist in the workspace scope or the request fails with 404 and nothing is copied. A workspace secret whose `hosts` is `null` cannot be copied: the request fails with 409 and nothing is copied until that secret is stored again with hosts. The response carries metadata only. Writes return 503 while vault writes are disabled for the caller. The scope is selected by the API key: workspace routes act on the key's active workspace and intern routes act on one intern inside that workspace. There is no default workspace and no fallback to another scope. Every vault route, including reads, requires access to the Intern API programme and returns 404 outside it. An intern's own API key is confined to that intern: it can always read the intern's secrets and effective secrets, writes to them follow the rules above, and every other intern and every workspace route answers 404. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
        /// </summary>
        /// <param name="internId">
        /// UUID of an intern in the workspace selected by the API key.<br/>
        /// Example: 7c9e6679-7425-40de-944b-e07fc1f90ae7
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.VaultSecretCopyResponse> CopyVaultSecretsToInternAsync(
            global::System.Guid internId,

            global::OpenRouter.VaultSecretCopyRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Copy workspace secrets to an intern<br/>
        /// Copies the named workspace secrets into one intern's scope, replacing any intern secret with the same name. Each copy keeps the source value and host bindings. Every name must exist in the workspace scope or the request fails with 404 and nothing is copied. A workspace secret whose `hosts` is `null` cannot be copied: the request fails with 409 and nothing is copied until that secret is stored again with hosts. The response carries metadata only. Writes return 503 while vault writes are disabled for the caller. The scope is selected by the API key: workspace routes act on the key's active workspace and intern routes act on one intern inside that workspace. There is no default workspace and no fallback to another scope. Every vault route, including reads, requires access to the Intern API programme and returns 404 outside it. An intern's own API key is confined to that intern: it can always read the intern's secrets and effective secrets, writes to them follow the rules above, and every other intern and every workspace route answers 404. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
        /// </summary>
        /// <param name="internId">
        /// UUID of an intern in the workspace selected by the API key.<br/>
        /// Example: 7c9e6679-7425-40de-944b-e07fc1f90ae7
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.VaultSecretCopyResponse>> CopyVaultSecretsToInternAsResponseAsync(
            global::System.Guid internId,

            global::OpenRouter.VaultSecretCopyRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Copy workspace secrets to an intern<br/>
        /// Copies the named workspace secrets into one intern's scope, replacing any intern secret with the same name. Each copy keeps the source value and host bindings. Every name must exist in the workspace scope or the request fails with 404 and nothing is copied. A workspace secret whose `hosts` is `null` cannot be copied: the request fails with 409 and nothing is copied until that secret is stored again with hosts. The response carries metadata only. Writes return 503 while vault writes are disabled for the caller. The scope is selected by the API key: workspace routes act on the key's active workspace and intern routes act on one intern inside that workspace. There is no default workspace and no fallback to another scope. Every vault route, including reads, requires access to the Intern API programme and returns 404 outside it. An intern's own API key is confined to that intern: it can always read the intern's secrets and effective secrets, writes to them follow the rules above, and every other intern and every workspace route answers 404. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
        /// </summary>
        /// <param name="internId">
        /// UUID of an intern in the workspace selected by the API key.<br/>
        /// Example: 7c9e6679-7425-40de-944b-e07fc1f90ae7
        /// </param>
        /// <param name="names">
        /// Names of workspace secrets to copy, 1 to 100 unique entries. Every name must exist in the workspace scope.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.VaultSecretCopyResponse> CopyVaultSecretsToInternAsync(
            global::System.Guid internId,
            global::System.Collections.Generic.IList<string> names,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}