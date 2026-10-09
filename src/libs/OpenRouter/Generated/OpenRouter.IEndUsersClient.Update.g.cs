#nullable enable

namespace OpenRouter
{
    public partial interface IEndUsersClient
    {
        /// <summary>
        /// Update a registered end user<br/>
        /// Update registration state without changing identity. State changes do not enforce inference access. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="user">
        /// Immutable case-sensitive tracking string supplied as user on inference requests or as external.user on API keys: 1 to 512 characters, well-formed Unicode, no NUL, no surrounding whitespace. URL-encode it in resource paths; an ID of `.` or `..` cannot be addressed by path, so look it up with the list filter.<br/>
        /// Example: employee_123
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.EndUserResponse> UpdateAsync(
            string user,

            global::OpenRouter.UpdateEndUserRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a registered end user<br/>
        /// Update registration state without changing identity. State changes do not enforce inference access. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="user">
        /// Immutable case-sensitive tracking string supplied as user on inference requests or as external.user on API keys: 1 to 512 characters, well-formed Unicode, no NUL, no surrounding whitespace. URL-encode it in resource paths; an ID of `.` or `..` cannot be addressed by path, so look it up with the list filter.<br/>
        /// Example: employee_123
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.EndUserResponse>> UpdateAsResponseAsync(
            string user,

            global::OpenRouter.UpdateEndUserRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a registered end user<br/>
        /// Update registration state without changing identity. State changes do not enforce inference access. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="user">
        /// Immutable case-sensitive tracking string supplied as user on inference requests or as external.user on API keys: 1 to 512 characters, well-formed Unicode, no NUL, no surrounding whitespace. URL-encode it in resource paths; an ID of `.` or `..` cannot be addressed by path, so look it up with the list filter.<br/>
        /// Example: employee_123
        /// </param>
        /// <param name="isActive">
        /// Registration state only; does not enforce inference access.<br/>
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.EndUserResponse> UpdateAsync(
            string user,
            bool isActive,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}