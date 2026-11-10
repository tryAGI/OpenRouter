#nullable enable

namespace OpenRouter
{
    public partial interface IPresetsClient
    {
        /// <summary>
        /// Restore a preset<br/>
        /// Re-activates an archived preset so it resolves for inference again. No version is created and the designated version is unchanged. Restoring an active preset returns it unchanged. A disabled preset returns 409. Requires a read-write [management key](/docs/guides/overview/auth/management-api-keys); inference API keys are rejected. `workspace_id` may be sent as a query parameter or a JSON body field.
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
        global::System.Threading.Tasks.Task<global::OpenRouter.GetPresetResponse> RestoreAsync(
            string slug,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Restore a preset<br/>
        /// Re-activates an archived preset so it resolves for inference again. No version is created and the designated version is unchanged. Restoring an active preset returns it unchanged. A disabled preset returns 409. Requires a read-write [management key](/docs/guides/overview/auth/management-api-keys); inference API keys are rejected. `workspace_id` may be sent as a query parameter or a JSON body field.
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
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.GetPresetResponse>> RestoreAsResponseAsync(
            string slug,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}