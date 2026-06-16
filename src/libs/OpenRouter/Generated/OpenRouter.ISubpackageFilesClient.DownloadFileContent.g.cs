#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageFilesClient
    {
        /// <summary>
        /// Download file content<br/>
        /// Downloads the raw bytes of a file. Only files created server-side are downloadable; uploaded files return 400.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> DownloadFileContentAsync(
            string fileId,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download file content<br/>
        /// Downloads the raw bytes of a file. Only files created server-side are downloadable; uploaded files return 400.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> DownloadFileContentAsStreamAsync(
            string fileId,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download file content<br/>
        /// Downloads the raw bytes of a file. Only files created server-side are downloadable; uploaded files return 400.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<byte[]>> DownloadFileContentAsResponseAsync(
            string fileId,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}