#nullable enable

namespace OpenRouter
{
    public partial interface IEndUsersClient
    {
        /// <summary>
        /// List registered end users<br/>
        /// List registrations belonging to the authenticated organization. Inactive registrations are excluded by default. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="offset">
        /// Number of records to skip for pagination<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="limit">
        /// Maximum number of records to return (max 100)<br/>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </param>
        /// <param name="user">
        /// Immutable case-sensitive tracking string supplied as user on inference requests. URL-encode it in resource paths.<br/>
        /// Example: employee_123
        /// </param>
        /// <param name="includeInactive">
        /// Include deactivated registrations.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ListEndUsersResponse> ListAsync(
            int? offset = default,
            int? limit = default,
            string? user = default,
            bool? includeInactive = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List registered end users<br/>
        /// List registrations belonging to the authenticated organization. Inactive registrations are excluded by default. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="offset">
        /// Number of records to skip for pagination<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="limit">
        /// Maximum number of records to return (max 100)<br/>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </param>
        /// <param name="user">
        /// Immutable case-sensitive tracking string supplied as user on inference requests. URL-encode it in resource paths.<br/>
        /// Example: employee_123
        /// </param>
        /// <param name="includeInactive">
        /// Include deactivated registrations.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ListEndUsersResponse>> ListAsResponseAsync(
            int? offset = default,
            int? limit = default,
            string? user = default,
            bool? includeInactive = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}