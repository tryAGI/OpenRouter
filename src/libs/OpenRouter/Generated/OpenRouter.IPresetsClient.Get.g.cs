#nullable enable

namespace OpenRouter
{
    public partial interface IPresetsClient
    {
        /// <summary>
        /// Get a preset<br/>
        /// Retrieves a preset by its slug with its currently designated version inline.
        /// </summary>
        /// <param name="slug">
        /// URL-safe slug identifying the preset.<br/>
        /// Example: my-preset
        /// </param>
        /// <param name="workspaceId">
        /// Workspace to act in. Also accepted as a `workspace_id` field in a JSON request body. Defaults to the key's workspace for a key limited to one workspace, otherwise to the account's default workspace.<br/>
        /// Example: 750e8400-e29b-41d4-a716-446655440002
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.GetPresetResponse> GetAsync(
            string slug,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a preset<br/>
        /// Retrieves a preset by its slug with its currently designated version inline.
        /// </summary>
        /// <param name="slug">
        /// URL-safe slug identifying the preset.<br/>
        /// Example: my-preset
        /// </param>
        /// <param name="workspaceId">
        /// Workspace to act in. Also accepted as a `workspace_id` field in a JSON request body. Defaults to the key's workspace for a key limited to one workspace, otherwise to the account's default workspace.<br/>
        /// Example: 750e8400-e29b-41d4-a716-446655440002
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.GetPresetResponse>> GetAsResponseAsync(
            string slug,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}