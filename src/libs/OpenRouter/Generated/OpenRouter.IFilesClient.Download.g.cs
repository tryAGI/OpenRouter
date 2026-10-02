#nullable enable

namespace OpenRouter
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Download file content<br/>
        /// Downloads the raw bytes of a file. Only files created server-side are downloadable; uploaded files return 400.
        /// </summary>
        /// <param name="fileId">
        /// Example: or_file_011CNha8iCJcU1wXNR6q4V8w
        /// </param>
        /// <param name="workspaceId">
        /// Workspace to scope the request to. Defaults to the caller’s default workspace.<br/>
        /// Example: a103d8b6-42f0-4e50-9a3c-bf41e2c3c1a7
        /// </param>
        /// <param name="provider">
        /// Store or read this file on the named provider using your own API key for it. Omit to use OpenRouter storage.<br/>
        /// Example: openai
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> DownloadAsync(
            string fileId,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.FileProvider? provider = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download file content<br/>
        /// Downloads the raw bytes of a file. Only files created server-side are downloadable; uploaded files return 400.
        /// </summary>
        /// <param name="fileId">
        /// Example: or_file_011CNha8iCJcU1wXNR6q4V8w
        /// </param>
        /// <param name="workspaceId">
        /// Workspace to scope the request to. Defaults to the caller’s default workspace.<br/>
        /// Example: a103d8b6-42f0-4e50-9a3c-bf41e2c3c1a7
        /// </param>
        /// <param name="provider">
        /// Store or read this file on the named provider using your own API key for it. Omit to use OpenRouter storage.<br/>
        /// Example: openai
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> DownloadAsStreamAsync(
            string fileId,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.FileProvider? provider = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download file content<br/>
        /// Downloads the raw bytes of a file. Only files created server-side are downloadable; uploaded files return 400.
        /// </summary>
        /// <param name="fileId">
        /// Example: or_file_011CNha8iCJcU1wXNR6q4V8w
        /// </param>
        /// <param name="workspaceId">
        /// Workspace to scope the request to. Defaults to the caller’s default workspace.<br/>
        /// Example: a103d8b6-42f0-4e50-9a3c-bf41e2c3c1a7
        /// </param>
        /// <param name="provider">
        /// Store or read this file on the named provider using your own API key for it. Omit to use OpenRouter storage.<br/>
        /// Example: openai
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<byte[]>> DownloadAsResponseAsync(
            string fileId,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.FileProvider? provider = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}