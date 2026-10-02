#nullable enable

namespace OpenRouter
{
    public partial interface IVideoGenerationClient
    {
        /// <summary>
        /// Poll video generation status<br/>
        /// Returns job status and content URLs when completed
        /// </summary>
        /// <param name="jobId">
        /// Example: job-abc123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.VideoGenerationResponse> GetGenerationAsync(
            string jobId,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Poll video generation status<br/>
        /// Returns job status and content URLs when completed
        /// </summary>
        /// <param name="jobId">
        /// Example: job-abc123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.VideoGenerationResponse>> GetGenerationAsResponseAsync(
            string jobId,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}