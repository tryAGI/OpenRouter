#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageWorkspacesClient
    {
        /// <summary>
        /// Update a workspace<br/>
        /// Update an existing workspace by ID or slug. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.UpdateWorkspaceResponse> UpdateWorkspaceAsync(
            string id,

            global::OpenRouter.UpdateWorkspaceRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a workspace<br/>
        /// Update an existing workspace by ID or slug. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="defaultImageModel">
        /// Default image model for this workspace
        /// </param>
        /// <param name="defaultProviderSort">
        /// Default provider sort preference (price, throughput, latency, exacto)
        /// </param>
        /// <param name="defaultTextModel">
        /// Default text model for this workspace
        /// </param>
        /// <param name="description">
        /// New description for the workspace
        /// </param>
        /// <param name="ioLoggingApiKeyIds">
        /// Optional array of API key IDs to filter I/O logging
        /// </param>
        /// <param name="ioLoggingSamplingRate">
        /// Sampling rate for I/O logging (0.0001-1)
        /// </param>
        /// <param name="isDataDiscountLoggingEnabled">
        /// Whether data discount logging is enabled
        /// </param>
        /// <param name="isObservabilityBroadcastEnabled">
        /// Whether broadcast is enabled
        /// </param>
        /// <param name="isObservabilityIoLoggingEnabled">
        /// Whether private logging is enabled
        /// </param>
        /// <param name="name">
        /// New name for the workspace
        /// </param>
        /// <param name="slug">
        /// New URL-friendly slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.UpdateWorkspaceResponse> UpdateWorkspaceAsync(
            string id,
            string? defaultImageModel = default,
            string? defaultProviderSort = default,
            string? defaultTextModel = default,
            string? description = default,
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