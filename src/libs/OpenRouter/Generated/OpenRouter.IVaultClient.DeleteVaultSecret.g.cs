#nullable enable

namespace OpenRouter
{
    public partial interface IVaultClient
    {
        /// <summary>
        /// Delete a workspace secret<br/>
        /// Deletes a secret from the workspace of the authenticated API key. Returns 204 with no body on success and 404 when the secret does not exist in the selected scope. Writes return 503 while vault writes are disabled for the caller. The scope is selected by the API key: workspace routes act on the key's active workspace and intern routes act on one intern inside that workspace. There is no default workspace and no fallback to another scope. Every vault route, including reads, requires access to the Intern API programme and returns 404 outside it. An intern's own API key is confined to that intern: it can always read the intern's secrets and effective secrets, writes to them follow the rules above, and every other intern and every workspace route answers 404. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
        /// </summary>
        /// <param name="name">
        /// Secret name. Lowercase letters, digits and single underscores, starting with a letter and not ending with an underscore, 1 to 255 characters.<br/>
        /// Example: github_token
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteVaultSecretAsync(
            string name,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a workspace secret<br/>
        /// Deletes a secret from the workspace of the authenticated API key. Returns 204 with no body on success and 404 when the secret does not exist in the selected scope. Writes return 503 while vault writes are disabled for the caller. The scope is selected by the API key: workspace routes act on the key's active workspace and intern routes act on one intern inside that workspace. There is no default workspace and no fallback to another scope. Every vault route, including reads, requires access to the Intern API programme and returns 404 outside it. An intern's own API key is confined to that intern: it can always read the intern's secrets and effective secrets, writes to them follow the rules above, and every other intern and every workspace route answers 404. Requests on regional hostnames such as `eu.openrouter.ai` are refused. [API key](/docs/api-reference/authentication) required.
        /// </summary>
        /// <param name="name">
        /// Secret name. Lowercase letters, digits and single underscores, starting with a letter and not ending with an underscore, 1 to 255 characters.<br/>
        /// Example: github_token
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse> DeleteVaultSecretAsResponseAsync(
            string name,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}