#nullable enable

namespace OpenRouter
{
    public partial interface IVaultClient
    {
        /// <summary>
        /// Store an intern secret<br/>
        /// Creates or replaces a secret stored for one intern. The value is encrypted at rest and released only to the exact hostnames in `hosts`. The response carries metadata only. Writes return 503 while vault writes are disabled for the caller. The scope is selected by the API key: workspace routes act on the key's active workspace and intern routes act on one intern inside that workspace. There is no default workspace and no fallback to another scope. Every vault route, including reads, requires access to the Intern API programme and returns 404 outside it. An intern's own API key is confined to that intern: it can always read the intern's secrets and effective secrets, writes to them follow the rules above, and every other intern and every workspace route answers 404. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
        /// </summary>
        /// <param name="internId">
        /// UUID of an intern in the workspace selected by the API key.<br/>
        /// Example: 7c9e6679-7425-40de-944b-e07fc1f90ae7
        /// </param>
        /// <param name="name">
        /// Secret name. Lowercase letters, digits and single underscores, starting with a letter and not ending with an underscore, 1 to 255 characters.<br/>
        /// Example: github_token
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.VaultSecretResponse> StoreInternVaultSecretAsync(
            global::System.Guid internId,
            string name,

            global::OpenRouter.VaultSecretWriteRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Store an intern secret<br/>
        /// Creates or replaces a secret stored for one intern. The value is encrypted at rest and released only to the exact hostnames in `hosts`. The response carries metadata only. Writes return 503 while vault writes are disabled for the caller. The scope is selected by the API key: workspace routes act on the key's active workspace and intern routes act on one intern inside that workspace. There is no default workspace and no fallback to another scope. Every vault route, including reads, requires access to the Intern API programme and returns 404 outside it. An intern's own API key is confined to that intern: it can always read the intern's secrets and effective secrets, writes to them follow the rules above, and every other intern and every workspace route answers 404. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
        /// </summary>
        /// <param name="internId">
        /// UUID of an intern in the workspace selected by the API key.<br/>
        /// Example: 7c9e6679-7425-40de-944b-e07fc1f90ae7
        /// </param>
        /// <param name="name">
        /// Secret name. Lowercase letters, digits and single underscores, starting with a letter and not ending with an underscore, 1 to 255 characters.<br/>
        /// Example: github_token
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.VaultSecretResponse>> StoreInternVaultSecretAsResponseAsync(
            global::System.Guid internId,
            string name,

            global::OpenRouter.VaultSecretWriteRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Store an intern secret<br/>
        /// Creates or replaces a secret stored for one intern. The value is encrypted at rest and released only to the exact hostnames in `hosts`. The response carries metadata only. Writes return 503 while vault writes are disabled for the caller. The scope is selected by the API key: workspace routes act on the key's active workspace and intern routes act on one intern inside that workspace. There is no default workspace and no fallback to another scope. Every vault route, including reads, requires access to the Intern API programme and returns 404 outside it. An intern's own API key is confined to that intern: it can always read the intern's secrets and effective secrets, writes to them follow the rules above, and every other intern and every workspace route answers 404. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
        /// </summary>
        /// <param name="internId">
        /// UUID of an intern in the workspace selected by the API key.<br/>
        /// Example: 7c9e6679-7425-40de-944b-e07fc1f90ae7
        /// </param>
        /// <param name="name">
        /// Secret name. Lowercase letters, digits and single underscores, starting with a letter and not ending with an underscore, 1 to 255 characters.<br/>
        /// Example: github_token
        /// </param>
        /// <param name="hosts">
        /// Exact DNS hostnames the secret may be sent to, 1 to 100 entries. Each entry is lowercased and a trailing dot is removed, so `API.Example.com.` is stored as `api.example.com`. Schemes, ports, paths, wildcards and empty values are rejected. Duplicates after normalization are collapsed. Matching is exact: a secret bound to `api.example.com` is never released to `example.com` or any other hostname.
        /// </param>
        /// <param name="value">
        /// Secret value, 1 to 65536 characters. It is encrypted at rest and never returned.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.VaultSecretResponse> StoreInternVaultSecretAsync(
            global::System.Guid internId,
            string name,
            global::System.Collections.Generic.IList<string> hosts,
            string value,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}