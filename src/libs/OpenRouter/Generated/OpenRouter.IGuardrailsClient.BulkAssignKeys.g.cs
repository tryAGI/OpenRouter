#nullable enable

namespace OpenRouter
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Bulk assign keys to a guardrail<br/>
        /// Assign multiple API keys to a specific guardrail. A key may hold at most one guardrail; assigning replaces any existing assignment. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the guardrail<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.BulkAssignKeysResponse> BulkAssignKeysAsync(
            global::System.Guid id,

            global::OpenRouter.BulkAssignKeysRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk assign keys to a guardrail<br/>
        /// Assign multiple API keys to a specific guardrail. A key may hold at most one guardrail; assigning replaces any existing assignment. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the guardrail<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.BulkAssignKeysResponse>> BulkAssignKeysAsResponseAsync(
            global::System.Guid id,

            global::OpenRouter.BulkAssignKeysRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk assign keys to a guardrail<br/>
        /// Assign multiple API keys to a specific guardrail. A key may hold at most one guardrail; assigning replaces any existing assignment. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the guardrail<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="keyHashes">
        /// Array of API key hashes to assign to the guardrail<br/>
        /// Example: [c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.BulkAssignKeysResponse> BulkAssignKeysAsync(
            global::System.Guid id,
            global::System.Collections.Generic.IList<string> keyHashes,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}