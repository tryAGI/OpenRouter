#nullable enable

namespace OpenRouter
{
    public partial interface IGuardrailPoliciesClient
    {
        /// <summary>
        /// Change an API key policy assignment<br/>
        /// Assign or unassign one policy for an API key. Fails with 409 when `expected_assignment` no longer matches the stored state. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="hash">
        /// API key hash<br/>
        /// Example: c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ChangeGuardrailPolicyAssignmentResponse> ChangeApiKeyPolicyAssignmentAsync(
            string hash,

            global::OpenRouter.ChangeGuardrailPolicyAssignmentRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change an API key policy assignment<br/>
        /// Assign or unassign one policy for an API key. Fails with 409 when `expected_assignment` no longer matches the stored state. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="hash">
        /// API key hash<br/>
        /// Example: c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ChangeGuardrailPolicyAssignmentResponse>> ChangeApiKeyPolicyAssignmentAsResponseAsync(
            string hash,

            global::OpenRouter.ChangeGuardrailPolicyAssignmentRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change an API key policy assignment<br/>
        /// Assign or unassign one policy for an API key. Fails with 409 when `expected_assignment` no longer matches the stored state. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="hash">
        /// API key hash<br/>
        /// Example: c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93
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
        global::System.Threading.Tasks.Task<global::OpenRouter.ChangeGuardrailPolicyAssignmentResponse> ChangeApiKeyPolicyAssignmentAsync(
            string hash,
            bool assigned,
            global::OpenRouter.AllOf<global::OpenRouter.GuardrailPolicyAssignmentState, object> expectedAssignment,
            global::System.Guid policyId,
            global::OpenRouter.ChangeGuardrailPolicyAssignmentRequestPolicyType policyType,
            global::System.Guid workspaceId,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}