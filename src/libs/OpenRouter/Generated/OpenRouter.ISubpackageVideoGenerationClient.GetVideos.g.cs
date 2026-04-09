#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageVideoGenerationClient
    {
        /// <summary>
        /// Poll video generation status<br/>
        /// Returns job status and content URLs when completed
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.VideoGenerationResponse> GetVideosAsync(
            string jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}