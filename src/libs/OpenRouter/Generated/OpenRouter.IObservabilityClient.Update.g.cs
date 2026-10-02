#nullable enable

namespace OpenRouter
{
    public partial interface IObservabilityClient
    {
        /// <summary>
        /// Update an observability destination<br/>
        /// Update an existing observability destination. Only the fields provided in the request body are updated. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// The destination ID (UUID).<br/>
        /// Example: 99999999-aaaa-bbbb-cccc-dddddddddddd
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.UpdateObservabilityDestinationResponse> UpdateAsync(
            global::System.Guid id,

            global::OpenRouter.UpdateObservabilityDestinationRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an observability destination<br/>
        /// Update an existing observability destination. Only the fields provided in the request body are updated. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// The destination ID (UUID).<br/>
        /// Example: 99999999-aaaa-bbbb-cccc-dddddddddddd
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.UpdateObservabilityDestinationResponse>> UpdateAsResponseAsync(
            global::System.Guid id,

            global::OpenRouter.UpdateObservabilityDestinationRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an observability destination<br/>
        /// Update an existing observability destination. Only the fields provided in the request body are updated. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// The destination ID (UUID).<br/>
        /// Example: 99999999-aaaa-bbbb-cccc-dddddddddddd
        /// </param>
        /// <param name="apiKeyHashes">
        /// Optional allowlist of OpenRouter API key hashes. `null` clears the filter (all keys). Omitting leaves the current value. Must contain at least one hash if provided.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="broadcastGenerationCost">
        /// Whether to include cost and billing generation metadata.<br/>
        /// Example: false
        /// </param>
        /// <param name="broadcastGenerationIdentity">
        /// Whether to include identity generation metadata.<br/>
        /// Example: false
        /// </param>
        /// <param name="broadcastGenerationRequestContext">
        /// Whether to include request-context generation metadata.<br/>
        /// Example: false
        /// </param>
        /// <param name="config">
        /// Provider-specific configuration fields to update. Masked values are ignored; unset fields keep their current value.<br/>
        /// Example: {"baseUrl":"https://us.cloud.langfuse.com","publicKey":"pk-l...EfGh","secretKey":"sk-l...AbCd"}
        /// </param>
        /// <param name="enabled">
        /// Whether the destination is enabled.<br/>
        /// Example: true
        /// </param>
        /// <param name="filterRules"></param>
        /// <param name="name">
        /// Human-readable name for the destination.<br/>
        /// Example: Production Langfuse
        /// </param>
        /// <param name="privacyMode">
        /// When true, request/response bodies are not forwarded — only metadata.<br/>
        /// Example: false
        /// </param>
        /// <param name="regions">
        /// Data regions this destination applies to. `eu` is accepted as an alias for `europe` and normalizes to `europe`. Omitting this field keeps the current value; it cannot be cleared.<br/>
        /// Example: [global]
        /// </param>
        /// <param name="samplingRate">
        /// Sampling rate between 0.0001 and 1 (1 = 100%).<br/>
        /// Example: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.UpdateObservabilityDestinationResponse> UpdateAsync(
            global::System.Guid id,
            global::System.Collections.Generic.IList<string>? apiKeyHashes = default,
            bool? broadcastGenerationCost = default,
            bool? broadcastGenerationIdentity = default,
            bool? broadcastGenerationRequestContext = default,
            object? config = default,
            bool? enabled = default,
            global::OpenRouter.AllOf<global::OpenRouter.ObservabilityFilterRulesConfigNullable, object>? filterRules = default,
            string? name = default,
            bool? privacyMode = default,
            global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityDataRegionInput>? regions = default,
            double? samplingRate = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}