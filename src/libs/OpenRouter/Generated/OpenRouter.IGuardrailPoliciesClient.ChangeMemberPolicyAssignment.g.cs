#nullable enable

namespace OpenRouter
{
    public partial interface IGuardrailPoliciesClient
    {
        /// <summary>
        /// Change a member policy assignment<br/>
        /// Assign or unassign one policy for a member. Fails with 409 when `expected_assignment` no longer matches the stored state. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="memberId">
        /// Organization member user ID<br/>
        /// Example: user_2abcDEFghiJKLmnoPQRstu
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ChangeGuardrailPolicyAssignmentResponse> ChangeMemberPolicyAssignmentAsync(
            string memberId,

            global::OpenRouter.ChangeGuardrailPolicyAssignmentRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change a member policy assignment<br/>
        /// Assign or unassign one policy for a member. Fails with 409 when `expected_assignment` no longer matches the stored state. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="memberId">
        /// Organization member user ID<br/>
        /// Example: user_2abcDEFghiJKLmnoPQRstu
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ChangeGuardrailPolicyAssignmentResponse>> ChangeMemberPolicyAssignmentAsResponseAsync(
            string memberId,

            global::OpenRouter.ChangeGuardrailPolicyAssignmentRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change a member policy assignment<br/>
        /// Assign or unassign one policy for a member. Fails with 409 when `expected_assignment` no longer matches the stored state. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="memberId">
        /// Organization member user ID<br/>
        /// Example: user_2abcDEFghiJKLmnoPQRstu
        /// </param>
        /// <param name="assigned">
        /// `true` assigns the policy to the subject, `false` removes it<br/>
        /// Example: true
        /// </param>
        /// <param name="expectedAssignment"></param>
        /// <param name="policyId">
        /// Policy ID<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="policyType">
        /// Policy type the assignment is read or changed for<br/>
        /// Example: budget
        /// </param>
        /// <param name="workspaceId">
        /// Workspace the policy belongs to<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ChangeGuardrailPolicyAssignmentResponse> ChangeMemberPolicyAssignmentAsync(
            string memberId,
            bool assigned,
            global::OpenRouter.AllOf<global::OpenRouter.GuardrailPolicyAssignmentState, object> expectedAssignment,
            global::System.Guid policyId,
            global::OpenRouter.ChangeGuardrailPolicyAssignmentRequestPolicyType policyType,
            global::System.Guid workspaceId,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}