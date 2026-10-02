#nullable enable

namespace OpenRouter
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Create a SCIM group mapping<br/>
        /// Create a SCIM group-to-workspace role mapping. Creating a mapping that already exists with the same role succeeds and re-applies the mapping to the group members. Requesting a different role for an existing mapping returns 409. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreateScimGroupMappingResponse> CreateAsync(

            global::OpenRouter.CreateScimGroupMappingRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a SCIM group mapping<br/>
        /// Create a SCIM group-to-workspace role mapping. Creating a mapping that already exists with the same role succeeds and re-applies the mapping to the group members. Requesting a different role for an existing mapping returns 409. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.CreateScimGroupMappingResponse>> CreateAsResponseAsync(

            global::OpenRouter.CreateScimGroupMappingRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a SCIM group mapping<br/>
        /// Create a SCIM group-to-workspace role mapping. Creating a mapping that already exists with the same role succeeds and re-applies the mapping to the group members. Requesting a different role for an existing mapping returns 409. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="scimGroupId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreateScimGroupMappingResponse> CreateAsync(
            global::OpenRouter.CreateScimGroupMappingRequestRole role,
            global::System.Guid scimGroupId,
            global::System.Guid workspaceId,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}