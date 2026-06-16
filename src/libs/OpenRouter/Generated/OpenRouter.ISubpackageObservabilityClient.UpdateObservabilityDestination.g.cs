#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageObservabilityClient
    {
        /// <summary>
        /// Update an observability destination<br/>
        /// Update an existing observability destination. Only the fields provided in the request body are updated. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.UpdateObservabilityDestinationResponse> UpdateObservabilityDestinationAsync(
            global::System.Guid id,

            global::OpenRouter.UpdateObservabilityDestinationRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an observability destination<br/>
        /// Update an existing observability destination. Only the fields provided in the request body are updated. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.UpdateObservabilityDestinationResponse>> UpdateObservabilityDestinationAsResponseAsync(
            global::System.Guid id,

            global::OpenRouter.UpdateObservabilityDestinationRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an observability destination<br/>
        /// Update an existing observability destination. Only the fields provided in the request body are updated. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="apiKeyHashes">
        /// Optional allowlist of OpenRouter API key hashes. `null` clears the filter (all keys). Omitting leaves the current value. Must contain at least one hash if provided.
        /// </param>
        /// <param name="config">
        /// Provider-specific configuration fields to update. Masked values are ignored; unset fields keep their current value.
        /// </param>
        /// <param name="enabled">
        /// Whether the destination is enabled.
        /// </param>
        /// <param name="filterRules">
        /// Optional structured filter rules. `null` clears the rules. Omitting keeps the current value.
        /// </param>
        /// <param name="name">
        /// Human-readable name for the destination.
        /// </param>
        /// <param name="privacyMode">
        /// When true, request/response bodies are not forwarded — only metadata.
        /// </param>
        /// <param name="samplingRate">
        /// Sampling rate between 0.0001 and 1 (1 = 100%).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.UpdateObservabilityDestinationResponse> UpdateObservabilityDestinationAsync(
            global::System.Guid id,
            global::System.Collections.Generic.IList<string>? apiKeyHashes = default,
            object? config = default,
            bool? enabled = default,
            global::OpenRouter.UpdateObservabilityDestinationRequestFilterRules? filterRules = default,
            string? name = default,
            bool? privacyMode = default,
            double? samplingRate = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}