#nullable enable

namespace OpenRouter
{
    public partial interface IEndUsersClient
    {
        /// <summary>
        /// Deactivate a registered end user<br/>
        /// Soft-deactivate a registration while retaining its tracking ID. Repeat deactivation succeeds. This does not block inference; reactivate through PATCH. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="user">
        /// Immutable case-sensitive tracking string supplied as user on inference requests. URL-encode it in resource paths.<br/>
        /// Example: employee_123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            string user,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deactivate a registered end user<br/>
        /// Soft-deactivate a registration while retaining its tracking ID. Repeat deactivation succeeds. This does not block inference; reactivate through PATCH. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="user">
        /// Immutable case-sensitive tracking string supplied as user on inference requests. URL-encode it in resource paths.<br/>
        /// Example: employee_123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse> DeleteAsResponseAsync(
            string user,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}