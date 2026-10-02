#nullable enable

namespace OpenRouter
{
    public partial interface IContainersClient
    {
        /// <summary>
        /// List container files<br/>
        /// Lists the files in a container, in lexicographic path order. The container id is the canonical id returned in bash/shell tool results; a restarted session is a separate container with its own id. Paginate with `limit` and `after` (pass the previous page’s `last_id`); `has_more: true` always means the next page is fetchable that way. `last_id` is the resume cursor: it is the last listed file’s id, except when a page ends at the per-request scan bound on hidden bookkeeping objects, where it names the scan position instead and may not appear in `data` (which can then be empty).
        /// </summary>
        /// <param name="containerId">
        /// The canonical container id, exactly as returned in a bash/shell tool result — a restarted session has its own `-r&lt;nonce&gt;`-suffixed id. A session-derived id is always `sess_` + the sanitized session key, which is not necessarily the raw session id that was sent.<br/>
        /// Example: sess_abc123
        /// </param>
        /// <param name="limit">
        /// Maximum number of files to return (1-1000). Defaults to 100 when absent.<br/>
        /// Default Value: 100<br/>
        /// Example: 100
        /// </param>
        /// <param name="after">
        /// Forward cursor: the previous page’s `last_id` (or any container file id); listing resumes strictly after that path. A `last_id` from a page that stopped at the scan bound may name a directory-marker path (trailing `/`) that was never listed as a file; such cursors are accepted.<br/>
        /// Example: cfile_b3V0L3JlcG9ydC5jc3Y
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ContainerFileListResponse> ListContainerFilesAsync(
            string containerId,
            int? limit = default,
            string? after = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List container files<br/>
        /// Lists the files in a container, in lexicographic path order. The container id is the canonical id returned in bash/shell tool results; a restarted session is a separate container with its own id. Paginate with `limit` and `after` (pass the previous page’s `last_id`); `has_more: true` always means the next page is fetchable that way. `last_id` is the resume cursor: it is the last listed file’s id, except when a page ends at the per-request scan bound on hidden bookkeeping objects, where it names the scan position instead and may not appear in `data` (which can then be empty).
        /// </summary>
        /// <param name="containerId">
        /// The canonical container id, exactly as returned in a bash/shell tool result — a restarted session has its own `-r&lt;nonce&gt;`-suffixed id. A session-derived id is always `sess_` + the sanitized session key, which is not necessarily the raw session id that was sent.<br/>
        /// Example: sess_abc123
        /// </param>
        /// <param name="limit">
        /// Maximum number of files to return (1-1000). Defaults to 100 when absent.<br/>
        /// Default Value: 100<br/>
        /// Example: 100
        /// </param>
        /// <param name="after">
        /// Forward cursor: the previous page’s `last_id` (or any container file id); listing resumes strictly after that path. A `last_id` from a page that stopped at the scan bound may name a directory-marker path (trailing `/`) that was never listed as a file; such cursors are accepted.<br/>
        /// Example: cfile_b3V0L3JlcG9ydC5jc3Y
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ContainerFileListResponse>> ListContainerFilesAsResponseAsync(
            string containerId,
            int? limit = default,
            string? after = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}