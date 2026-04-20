#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageWorkspacesClient
    {
        /// <summary>
        /// Create a workspace<br/>
        /// Create a new workspace for the authenticated user. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreateWorkspaceResponse> CreateWorkspaceAsync(

            global::OpenRouter.CreateWorkspaceRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a workspace<br/>
        /// Create a new workspace for the authenticated user. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
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
        /// Description of the workspace
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
        /// Name for the new workspace
        /// </param>
        /// <param name="slug">
        /// URL-friendly slug (lowercase alphanumeric and hyphens only)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreateWorkspaceResponse> CreateWorkspaceAsync(
            string name,
            string slug,
            string? defaultImageModel = default,
            string? defaultProviderSort = default,
            string? defaultTextModel = default,
            string? description = default,
            bool? isDataDiscountLoggingEnabled = default,
            bool? isObservabilityBroadcastEnabled = default,
            bool? isObservabilityIoLoggingEnabled = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}