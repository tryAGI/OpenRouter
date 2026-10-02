#nullable enable

namespace OpenRouter
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// List endpoints for an image model<br/>
        /// Returns the full per-endpoint records for an image model: each endpoint's definitive supported parameters, pricing, and passthrough allowlist.
        /// </summary>
        /// <param name="author">
        /// Model author/organization<br/>
        /// Example: bytedance-seed
        /// </param>
        /// <param name="slug">
        /// Model slug<br/>
        /// Example: seedream-4.5
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ImageModelEndpointsResponse> ListModelEndpointsAsync(
            string author,
            string slug,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List endpoints for an image model<br/>
        /// Returns the full per-endpoint records for an image model: each endpoint's definitive supported parameters, pricing, and passthrough allowlist.
        /// </summary>
        /// <param name="author">
        /// Model author/organization<br/>
        /// Example: bytedance-seed
        /// </param>
        /// <param name="slug">
        /// Model slug<br/>
        /// Example: seedream-4.5
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ImageModelEndpointsResponse>> ListModelEndpointsAsResponseAsync(
            string author,
            string slug,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}