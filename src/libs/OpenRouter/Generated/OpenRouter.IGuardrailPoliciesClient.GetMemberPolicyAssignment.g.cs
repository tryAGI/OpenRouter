#nullable enable

namespace OpenRouter
{
    public partial interface IGuardrailPoliciesClient
    {
        /// <summary>
        /// Get a member policy assignment<br/>
        /// Get the policies of one type that apply to a member in a workspace. Requires a management key with write access. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="memberId">
        /// Organization member user ID<br/>
        /// Example: user_2abcDEFghiJKLmnoPQRstu
        /// </param>
        /// <param name="workspaceId">
        /// Workspace the policy belongs to<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </param>
        /// <param name="policyType">
        /// Policy type the assignment is read or changed for<br/>
        /// Example: budget
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.GuardrailPolicyAssignmentResponse> GetMemberPolicyAssignmentAsync(
            string memberId,
            global::System.Guid workspaceId,
            global::OpenRouter.GetMemberPolicyAssignmentPolicyType policyType,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a member policy assignment<br/>
        /// Get the policies of one type that apply to a member in a workspace. Requires a management key with write access. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="memberId">
        /// Organization member user ID<br/>
        /// Example: user_2abcDEFghiJKLmnoPQRstu
        /// </param>
        /// <param name="workspaceId">
        /// Workspace the policy belongs to<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </param>
        /// <param name="policyType">
        /// Policy type the assignment is read or changed for<br/>
        /// Example: budget
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.GuardrailPolicyAssignmentResponse>> GetMemberPolicyAssignmentAsResponseAsync(
            string memberId,
            global::System.Guid workspaceId,
            global::OpenRouter.GetMemberPolicyAssignmentPolicyType policyType,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}