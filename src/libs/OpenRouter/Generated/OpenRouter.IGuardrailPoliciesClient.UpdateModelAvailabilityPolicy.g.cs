#nullable enable

namespace OpenRouter
{
    public partial interface IGuardrailPoliciesClient
    {
        /// <summary>
        /// Update a model availability policy<br/>
        /// Replace a model availability policy's name and config, and optionally its assignments. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// Policy ID<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ModelAvailabilityGuardrailPolicyResponse> UpdateModelAvailabilityPolicyAsync(
            global::System.Guid id,

            global::OpenRouter.UpdateModelAvailabilityGuardrailPolicyRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a model availability policy<br/>
        /// Replace a model availability policy's name and config, and optionally its assignments. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// Policy ID<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ModelAvailabilityGuardrailPolicyResponse>> UpdateModelAvailabilityPolicyAsResponseAsync(
            global::System.Guid id,

            global::OpenRouter.UpdateModelAvailabilityGuardrailPolicyRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a model availability policy<br/>
        /// Replace a model availability policy's name and config, and optionally its assignments. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// Policy ID<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="apiKeyHashes">
        /// Complete new list of assigned API keys. Send together with `member_ids`, or omit both to keep the stored assignments.<br/>
        /// Example: [c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]
        /// </param>
        /// <param name="config">
        /// Example: {"allowed_models":["openai/gpt-4o","anthropic/claude-sonnet-4"],"allowed_providers":["openai","anthropic"],"enforce_zdr_anthropic":true,"enforce_zdr_openai":true}
        /// </param>
        /// <param name="isWorkspaceDefault">
        /// Omit to keep the stored default status; `false` unsets the policy as the workspace default.
        /// </param>
        /// <param name="memberIds">
        /// Complete new list of assigned members. Send together with `api_key_hashes`, or omit both to keep the stored assignments.<br/>
        /// Example: [user_2abcDEFghiJKLmnoPQRstu]
        /// </param>
        /// <param name="name">
        /// Policy name<br/>
        /// Example: Engineering monthly budget
        /// </param>
        /// <param name="optedOutApiKeyHashes">
        /// API key hashes<br/>
        /// Example: [c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]
        /// </param>
        /// <param name="optedOutMemberIds">
        /// Organization member user IDs<br/>
        /// Example: [user_2abcDEFghiJKLmnoPQRstu]
        /// </param>
        /// <param name="workspaceId">
        /// Workspace the policy belongs to<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ModelAvailabilityGuardrailPolicyResponse> UpdateModelAvailabilityPolicyAsync(
            global::System.Guid id,
            global::OpenRouter.GuardrailModelAvailabilityPolicyAuthoringConfig config,
            string name,
            global::System.Guid workspaceId,
            global::System.Collections.Generic.IList<string>? apiKeyHashes = default,
            bool? isWorkspaceDefault = default,
            global::System.Collections.Generic.IList<string>? memberIds = default,
            global::System.Collections.Generic.IList<string>? optedOutApiKeyHashes = default,
            global::System.Collections.Generic.IList<string>? optedOutMemberIds = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}