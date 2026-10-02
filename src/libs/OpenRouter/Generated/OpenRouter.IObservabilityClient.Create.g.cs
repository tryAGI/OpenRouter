#nullable enable

namespace OpenRouter
{
    public partial interface IObservabilityClient
    {
        /// <summary>
        /// Create an observability destination<br/>
        /// Create a new observability destination. A maximum of 5 destinations per type is allowed. Defaults to the authenticated entity's default workspace; use the `workspace_id` body field to scope to a different workspace. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreateObservabilityDestinationResponse> CreateAsync(

            global::OpenRouter.CreateObservabilityDestinationRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an observability destination<br/>
        /// Create a new observability destination. A maximum of 5 destinations per type is allowed. Defaults to the authenticated entity's default workspace; use the `workspace_id` body field to scope to a different workspace. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.CreateObservabilityDestinationResponse>> CreateAsResponseAsync(

            global::OpenRouter.CreateObservabilityDestinationRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an observability destination<br/>
        /// Create a new observability destination. A maximum of 5 destinations per type is allowed. Defaults to the authenticated entity's default workspace; use the `workspace_id` body field to scope to a different workspace. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="apiKeyHashes">
        /// Optional allowlist of OpenRouter API key hashes whose traffic is forwarded. `null` or omitted means all keys. Must contain at least one hash if provided.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="broadcastGenerationCost">
        /// When true, include cost and billing generation metadata.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="broadcastGenerationIdentity">
        /// When true, include identity generation metadata.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="broadcastGenerationRequestContext">
        /// When true, include request-context generation metadata.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="config">
        /// Provider-specific configuration. The shape depends on `type` and is validated server-side.<br/>
        /// Example: {"baseUrl":"https://us.cloud.langfuse.com","publicKey":"pk-l...EfGh","secretKey":"sk-l...AbCd"}
        /// </param>
        /// <param name="enabled">
        /// Whether this destination should be enabled immediately.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="filterRules">
        /// Optional structured filter rules controlling which events are forwarded.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="name">
        /// Human-readable name for the destination.<br/>
        /// Example: Production Langfuse
        /// </param>
        /// <param name="privacyMode">
        /// When true, request/response bodies are not forwarded — only metadata.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="regions">
        /// Data regions this destination applies to. `eu` is accepted as an alias for `europe` and normalizes to `europe`. Omitting this field defaults to ['global']; the array must be non-empty.<br/>
        /// Default Value: [global]<br/>
        /// Example: [global]
        /// </param>
        /// <param name="samplingRate">
        /// Sampling rate between 0.0001 and 1 (1 = 100%).<br/>
        /// Example: 1
        /// </param>
        /// <param name="type">
        /// The destination type. Only stable destination types are accepted.<br/>
        /// Example: langfuse
        /// </param>
        /// <param name="workspaceId">
        /// Optional workspace ID. Defaults to the authenticated entity's default workspace.<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreateObservabilityDestinationResponse> CreateAsync(
            object config,
            string name,
            global::OpenRouter.CreateObservabilityDestinationRequestType type,
            global::System.Collections.Generic.IList<string>? apiKeyHashes = default,
            bool? broadcastGenerationCost = default,
            bool? broadcastGenerationIdentity = default,
            bool? broadcastGenerationRequestContext = default,
            bool? enabled = default,
            global::OpenRouter.ObservabilityFilterRulesConfigNullable? filterRules = default,
            bool? privacyMode = default,
            global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityDataRegionInput>? regions = default,
            double? samplingRate = default,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}