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
        global::System.Threading.Tasks.Task<global::OpenRouter.CreateObservabilityDestinationResponse> CreateObservabilityDestinationAsync(

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
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.CreateObservabilityDestinationResponse>> CreateObservabilityDestinationAsResponseAsync(

            global::OpenRouter.CreateObservabilityDestinationRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an observability destination<br/>
        /// Create a new observability destination. A maximum of 5 destinations per type is allowed. Defaults to the authenticated entity's default workspace; use the `workspace_id` body field to scope to a different workspace. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="apiKeyHashes">
        /// Optional allowlist of OpenRouter API key hashes whose traffic is forwarded. `null` or omitted means all keys. Must contain at least one hash if provided.
        /// </param>
        /// <param name="config">
        /// Provider-specific configuration. The shape depends on `type` and is validated server-side.
        /// </param>
        /// <param name="enabled">
        /// Whether this destination should be enabled immediately.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="filterRules">
        /// Optional structured filter rules controlling which events are forwarded.
        /// </param>
        /// <param name="name">
        /// Human-readable name for the destination.
        /// </param>
        /// <param name="privacyMode">
        /// When true, request/response bodies are not forwarded — only metadata.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="samplingRate">
        /// Sampling rate between 0.0001 and 1 (1 = 100%).
        /// </param>
        /// <param name="type">
        /// The destination type. Only stable destination types are accepted.
        /// </param>
        /// <param name="workspaceId">
        /// Optional workspace ID. Defaults to the authenticated entity's default workspace.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreateObservabilityDestinationResponse> CreateObservabilityDestinationAsync(
            object config,
            string name,
            global::OpenRouter.CreateObservabilityDestinationRequestType type,
            global::System.Collections.Generic.IList<string>? apiKeyHashes = default,
            bool? enabled = default,
            global::OpenRouter.ObservabilityFilterRulesConfig? filterRules = default,
            bool? privacyMode = default,
            double? samplingRate = default,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}