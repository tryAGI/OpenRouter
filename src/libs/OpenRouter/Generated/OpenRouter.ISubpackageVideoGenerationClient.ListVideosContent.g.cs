#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageVideoGenerationClient
    {
        /// <summary>
        /// Download generated video content<br/>
        /// Streams the generated video content from the upstream provider
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="index">
        /// Default Value: 0
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ListVideosContentAsync(
            string jobId,
            int? index = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}