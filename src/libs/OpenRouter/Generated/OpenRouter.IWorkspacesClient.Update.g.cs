#nullable enable

namespace OpenRouter
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Update a workspace<br/>
        /// Update an existing workspace by ID or slug. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// The workspace ID (UUID) or slug<br/>
        /// Example: production
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.UpdateWorkspaceResponse> UpdateAsync(
            string id,

            global::OpenRouter.UpdateWorkspaceRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a workspace<br/>
        /// Update an existing workspace by ID or slug. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// The workspace ID (UUID) or slug<br/>
        /// Example: production
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.UpdateWorkspaceResponse>> UpdateAsResponseAsync(
            string id,

            global::OpenRouter.UpdateWorkspaceRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a workspace<br/>
        /// Update an existing workspace by ID or slug. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// The workspace ID (UUID) or slug<br/>
        /// Example: production
        /// </param>
        /// <param name="defaultImageModel">
        /// Default image model for this workspace<br/>
        /// Example: openai/dall-e-3
        /// </param>
        /// <param name="defaultProviderSort">
        /// Default provider sort preference (price, throughput, latency, exacto)<br/>
        /// Example: price
        /// </param>
        /// <param name="defaultTextModel">
        /// Default text model for this workspace<br/>
        /// Example: openai/gpt-4o
        /// </param>
        /// <param name="description">
        /// New description for the workspace<br/>
        /// Example: Updated description
        /// </param>
        /// <param name="disabledServerTools">
        /// OpenRouter server tools that requests in this workspace may not invoke. Requests naming a disabled tool are rejected with 403. An empty array or null clears the list.<br/>
        /// Example: [openrouter:web_search, openrouter:bash]
        /// </param>
        /// <param name="ioLoggingApiKeyIds">
        /// Optional array of API key IDs to filter I/O logging<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="ioLoggingSamplingRate">
        /// Sampling rate for I/O logging (0.0001-1)<br/>
        /// Example: 1
        /// </param>
        /// <param name="isDataDiscountLoggingEnabled">
        /// Whether data discount logging is enabled<br/>
        /// Example: true
        /// </param>
        /// <param name="isObservabilityBroadcastEnabled">
        /// Whether broadcast is enabled<br/>
        /// Example: false
        /// </param>
        /// <param name="isObservabilityIoLoggingEnabled">
        /// Whether private logging is enabled<br/>
        /// Example: false
        /// </param>
        /// <param name="name">
        /// New name for the workspace<br/>
        /// Example: Updated Workspace
        /// </param>
        /// <param name="slug">
        /// New URL-friendly slug (lowercase alphanumeric segments separated by single hyphens, no leading/trailing hyphens)<br/>
        /// Example: updated-workspace
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.UpdateWorkspaceResponse> UpdateAsync(
            string id,
            string? defaultImageModel = default,
            string? defaultProviderSort = default,
            string? defaultTextModel = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::OpenRouter.UpdateWorkspaceRequestDisabledServerTool>? disabledServerTools = default,
            global::System.Collections.Generic.IList<int>? ioLoggingApiKeyIds = default,
            double? ioLoggingSamplingRate = default,
            bool? isDataDiscountLoggingEnabled = default,
            bool? isObservabilityBroadcastEnabled = default,
            bool? isObservabilityIoLoggingEnabled = default,
            string? name = default,
            string? slug = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}