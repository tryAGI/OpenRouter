#nullable enable

namespace OpenRouter
{
    public partial interface IPresetsClient
    {
        /// <summary>
        /// Delete a preset<br/>
        /// Archives a preset: it no longer resolves for inference and is hidden from get and list. The preset and its versions are kept, so the slug stays taken; restore it with `POST /presets/{slug}/restore`. Deleting an already-archived preset succeeds again. A disabled preset returns 409. Requires a read-write [management key](/docs/guides/overview/auth/management-api-keys); inference API keys are rejected. `workspace_id` may be sent as a query parameter or a JSON body field.
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
        global::System.Threading.Tasks.Task<global::OpenRouter.GetPresetResponse> DeleteAsync(
            string slug,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a preset<br/>
        /// Archives a preset: it no longer resolves for inference and is hidden from get and list. The preset and its versions are kept, so the slug stays taken; restore it with `POST /presets/{slug}/restore`. Deleting an already-archived preset succeeds again. A disabled preset returns 409. Requires a read-write [management key](/docs/guides/overview/auth/management-api-keys); inference API keys are rejected. `workspace_id` may be sent as a query parameter or a JSON body field.
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
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.GetPresetResponse>> DeleteAsResponseAsync(
            string slug,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}