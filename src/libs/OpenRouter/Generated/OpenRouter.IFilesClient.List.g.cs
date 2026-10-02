#nullable enable

namespace OpenRouter
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// List files<br/>
        /// Lists files belonging to the workspace of the authenticating API key.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of files to return (1–1000).<br/>
        /// Example: 100
        /// </param>
        /// <param name="cursor">
        /// Opaque pagination cursor from a previous response.<br/>
        /// Example: eyJjdXJzb3IiOiJvcl9maWxlXzAxMUNOaGE4aUNKY1Uxd1hOUjZxNFY4dyJ9
        /// </param>
        /// <param name="workspaceId">
        /// Workspace to scope the request to. Defaults to the caller’s default workspace.<br/>
        /// Example: a103d8b6-42f0-4e50-9a3c-bf41e2c3c1a7
        /// </param>
        /// <param name="provider">
        /// Store or read this file on the named provider using your own API key for it. Omit to use OpenRouter storage.<br/>
        /// Example: openai
        /// </param>
        /// <param name="after">
        /// OpenAI-style forward cursor: the id to list after.<br/>
        /// Example: or_file_011CNha8iCJcU1wXNR6q4V8w
        /// </param>
        /// <param name="afterId">
        /// Anthropic-style forward cursor: the id to list after.<br/>
        /// Example: or_file_011CNha8iCJcU1wXNR6q4V8w
        /// </param>
        /// <param name="beforeId">
        /// Anthropic-style reverse cursor. Not supported by OpenRouter storage.<br/>
        /// Example: or_file_011CNha8iCJcU1wXNR6q4V8w
        /// </param>
        /// <param name="order">
        /// Sort direction. Only `asc` is supported by OpenRouter storage.<br/>
        /// Example: asc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.FileListResponse> ListAsync(
            int? limit = default,
            string? cursor = default,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.FileProvider? provider = default,
            string? after = default,
            string? afterId = default,
            string? beforeId = default,
            global::OpenRouter.ListFilesOrder? order = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List files<br/>
        /// Lists files belonging to the workspace of the authenticating API key.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of files to return (1–1000).<br/>
        /// Example: 100
        /// </param>
        /// <param name="cursor">
        /// Opaque pagination cursor from a previous response.<br/>
        /// Example: eyJjdXJzb3IiOiJvcl9maWxlXzAxMUNOaGE4aUNKY1Uxd1hOUjZxNFY4dyJ9
        /// </param>
        /// <param name="workspaceId">
        /// Workspace to scope the request to. Defaults to the caller’s default workspace.<br/>
        /// Example: a103d8b6-42f0-4e50-9a3c-bf41e2c3c1a7
        /// </param>
        /// <param name="provider">
        /// Store or read this file on the named provider using your own API key for it. Omit to use OpenRouter storage.<br/>
        /// Example: openai
        /// </param>
        /// <param name="after">
        /// OpenAI-style forward cursor: the id to list after.<br/>
        /// Example: or_file_011CNha8iCJcU1wXNR6q4V8w
        /// </param>
        /// <param name="afterId">
        /// Anthropic-style forward cursor: the id to list after.<br/>
        /// Example: or_file_011CNha8iCJcU1wXNR6q4V8w
        /// </param>
        /// <param name="beforeId">
        /// Anthropic-style reverse cursor. Not supported by OpenRouter storage.<br/>
        /// Example: or_file_011CNha8iCJcU1wXNR6q4V8w
        /// </param>
        /// <param name="order">
        /// Sort direction. Only `asc` is supported by OpenRouter storage.<br/>
        /// Example: asc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.FileListResponse>> ListAsResponseAsync(
            int? limit = default,
            string? cursor = default,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.FileProvider? provider = default,
            string? after = default,
            string? afterId = default,
            string? beforeId = default,
            global::OpenRouter.ListFilesOrder? order = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}