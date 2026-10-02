#nullable enable

namespace OpenRouter
{
    public partial interface IVideoGenerationClient
    {
        /// <summary>
        /// Download generated video content<br/>
        /// Streams the generated video content from the upstream provider
        /// </summary>
        /// <param name="jobId">
        /// Example: job-abc123
        /// </param>
        /// <param name="index">
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetVideoContentAsync(
            string jobId,
            int? index = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download generated video content<br/>
        /// Streams the generated video content from the upstream provider
        /// </summary>
        /// <param name="jobId">
        /// Example: job-abc123
        /// </param>
        /// <param name="index">
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> GetVideoContentAsStreamAsync(
            string jobId,
            int? index = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download generated video content<br/>
        /// Streams the generated video content from the upstream provider
        /// </summary>
        /// <param name="jobId">
        /// Example: job-abc123
        /// </param>
        /// <param name="index">
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<byte[]>> GetVideoContentAsResponseAsync(
            string jobId,
            int? index = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}