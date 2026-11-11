#nullable enable

namespace OpenRouter
{
    public partial interface IGuardrailPoliciesClient
    {
        /// <summary>
        /// Create a model availability policy<br/>
        /// Create a model availability policy in a workspace. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ModelAvailabilityGuardrailPolicyResponse> CreateModelAvailabilityPolicyAsync(

            global::OpenRouter.CreateModelAvailabilityGuardrailPolicyRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a model availability policy<br/>
        /// Create a model availability policy in a workspace. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ModelAvailabilityGuardrailPolicyResponse>> CreateModelAvailabilityPolicyAsResponseAsync(

            global::OpenRouter.CreateModelAvailabilityGuardrailPolicyRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a model availability policy<br/>
        /// Create a model availability policy in a workspace. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="apiKeyHashes">
        /// API key hashes<br/>
        /// Example: [c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]
        /// </param>
        /// <param name="config">
        /// Example: {"allowed_models":["openai/gpt-4o","anthropic/claude-sonnet-4"],"allowed_providers":["openai","anthropic"],"enforce_zdr_anthropic":true,"enforce_zdr_openai":true}
        /// </param>
        /// <param name="isWorkspaceDefault">
        /// Make this the workspace default for its policy type. Defaults to `false`.
        /// </param>
        /// <param name="memberIds">
        /// Organization member user IDs<br/>
        /// Example: [user_2abcDEFghiJKLmnoPQRstu]
        /// </param>
        /// <param name="name">
        /// Policy name<br/>
        /// Example: Engineering monthly budget
        /// </param>
        /// <param name="optedOutApiKeyHashes">
        /// API keys that should not inherit the policy when it is the workspace default<br/>
        /// Example: [c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]
        /// </param>
        /// <param name="optedOutMemberIds">
        /// Members that should not inherit the policy when it is the workspace default<br/>
        /// Example: [user_2abcDEFghiJKLmnoPQRstu]
        /// </param>
        /// <param name="policyType"></param>
        /// <param name="workspaceId">
        /// Workspace the policy belongs to. Required for an organization management key; a workspace-scoped key defaults to its own workspace and gets 403 for any other.<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ModelAvailabilityGuardrailPolicyResponse> CreateModelAvailabilityPolicyAsync(
            global::OpenRouter.GuardrailModelAvailabilityPolicyAuthoringConfig config,
            string name,
            global::System.Collections.Generic.IList<string>? apiKeyHashes = default,
            bool? isWorkspaceDefault = default,
            global::System.Collections.Generic.IList<string>? memberIds = default,
            global::System.Collections.Generic.IList<string>? optedOutApiKeyHashes = default,
            global::System.Collections.Generic.IList<string>? optedOutMemberIds = default,
            global::OpenRouter.CreateModelAvailabilityGuardrailPolicyRequestPolicyType policyType = default,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}