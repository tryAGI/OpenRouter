#nullable enable

namespace OpenRouter
{
    public partial interface IContainersClient
    {
        /// <summary>
        /// Retrieve a container file<br/>
        /// Returns the metadata of a single file in a container.
        /// </summary>
        /// <param name="containerId">
        /// The canonical container id, exactly as returned in a bash/shell tool result — a restarted session has its own `-r&lt;nonce&gt;`-suffixed id. A session-derived id is always `sess_` + the sanitized session key, which is not necessarily the raw session id that was sent.<br/>
        /// Example: sess_abc123
        /// </param>
        /// <param name="fileId">
        /// Container file id (`cfile_` + base64url of the file path).<br/>
        /// Example: cfile_b3V0L3JlcG9ydC5jc3Y
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ContainerFile> GetContainerFileAsync(
            string containerId,
            string fileId,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a container file<br/>
        /// Returns the metadata of a single file in a container.
        /// </summary>
        /// <param name="containerId">
        /// The canonical container id, exactly as returned in a bash/shell tool result — a restarted session has its own `-r&lt;nonce&gt;`-suffixed id. A session-derived id is always `sess_` + the sanitized session key, which is not necessarily the raw session id that was sent.<br/>
        /// Example: sess_abc123
        /// </param>
        /// <param name="fileId">
        /// Container file id (`cfile_` + base64url of the file path).<br/>
        /// Example: cfile_b3V0L3JlcG9ydC5jc3Y
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ContainerFile>> GetContainerFileAsResponseAsync(
            string containerId,
            string fileId,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}