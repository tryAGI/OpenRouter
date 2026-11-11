#nullable enable

namespace OpenRouter
{
    public partial interface IGuardrailPoliciesClient
    {
        /// <summary>
        /// Delete a model availability policy<br/>
        /// Delete a model availability policy. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// Policy ID<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="workspaceId">
        /// Workspace the policy belongs to. Required for an organization management key; a workspace-scoped key defaults to its own workspace and gets 403 for any other.<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.DeleteGuardrailPolicyResponse> DeleteModelAvailabilityPolicyAsync(
            global::System.Guid id,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a model availability policy<br/>
        /// Delete a model availability policy. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// Policy ID<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="workspaceId">
        /// Workspace the policy belongs to. Required for an organization management key; a workspace-scoped key defaults to its own workspace and gets 403 for any other.<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.DeleteGuardrailPolicyResponse>> DeleteModelAvailabilityPolicyAsResponseAsync(
            global::System.Guid id,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}