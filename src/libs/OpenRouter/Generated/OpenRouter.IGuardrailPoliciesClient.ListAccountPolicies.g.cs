#nullable enable

namespace OpenRouter
{
    public partial interface IGuardrailPoliciesClient
    {
        /// <summary>
        /// List workspace-wide policies<br/>
        /// List the workspace-wide policies that apply across workspaces in the account. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="offset">
        /// Number of records to skip for pagination. When both offset and limit are omitted, the full list is returned<br/>
        /// Example: 0
        /// </param>
        /// <param name="limit">
        /// Maximum number of records to return (max 100). When both offset and limit are omitted, the full list is returned<br/>
        /// Example: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ListAccountGuardrailPoliciesResponse> ListAccountPoliciesAsync(
            int? offset = default,
            int? limit = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List workspace-wide policies<br/>
        /// List the workspace-wide policies that apply across workspaces in the account. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="offset">
        /// Number of records to skip for pagination. When both offset and limit are omitted, the full list is returned<br/>
        /// Example: 0
        /// </param>
        /// <param name="limit">
        /// Maximum number of records to return (max 100). When both offset and limit are omitted, the full list is returned<br/>
        /// Example: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ListAccountGuardrailPoliciesResponse>> ListAccountPoliciesAsResponseAsync(
            int? offset = default,
            int? limit = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}