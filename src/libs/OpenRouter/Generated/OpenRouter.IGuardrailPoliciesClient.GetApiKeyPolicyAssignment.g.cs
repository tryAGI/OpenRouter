#nullable enable

namespace OpenRouter
{
    public partial interface IGuardrailPoliciesClient
    {
        /// <summary>
        /// Get an API key policy assignment<br/>
        /// Get the policies of one type that apply to an API key in a workspace. Requires a management key with write access. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="hash">
        /// API key hash<br/>
        /// Example: c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93
        /// </param>
        /// <param name="workspaceId">
        /// Workspace the policy belongs to. Required for an organization management key; a workspace-scoped key defaults to its own workspace and gets 403 for any other.<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </param>
        /// <param name="policyType">
        /// Policy type the assignment is read or changed for<br/>
        /// Example: budget
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.GuardrailPolicyAssignmentResponse> GetApiKeyPolicyAssignmentAsync(
            string hash,
            global::OpenRouter.GetApiKeyPolicyAssignmentPolicyType policyType,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get an API key policy assignment<br/>
        /// Get the policies of one type that apply to an API key in a workspace. Requires a management key with write access. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="hash">
        /// API key hash<br/>
        /// Example: c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93
        /// </param>
        /// <param name="workspaceId">
        /// Workspace the policy belongs to. Required for an organization management key; a workspace-scoped key defaults to its own workspace and gets 403 for any other.<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </param>
        /// <param name="policyType">
        /// Policy type the assignment is read or changed for<br/>
        /// Example: budget
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.GuardrailPolicyAssignmentResponse>> GetApiKeyPolicyAssignmentAsResponseAsync(
            string hash,
            global::OpenRouter.GetApiKeyPolicyAssignmentPolicyType policyType,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}