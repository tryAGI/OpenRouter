#nullable enable

namespace OpenRouter
{
    public partial interface IByokClient
    {
        /// <summary>
        /// List BYOK provider credentials<br/>
        /// List the bring-your-own-key (BYOK) provider credentials for the authenticated entity's default workspace. Use the `workspace_id` query parameter to scope the result to a different workspace, or the `provider` query parameter to filter by upstream provider. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="workspaceId"></param>
        /// <param name="provider">
        /// Optional provider slug to filter by (e.g. `openai`, `anthropic`, `amazon-bedrock`).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ListBYOKKeysResponse> ListByokKeysAsync(
            int? offset = default,
            int? limit = default,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.ByokGetParametersProvider? provider = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List BYOK provider credentials<br/>
        /// List the bring-your-own-key (BYOK) provider credentials for the authenticated entity's default workspace. Use the `workspace_id` query parameter to scope the result to a different workspace, or the `provider` query parameter to filter by upstream provider. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="limit"></param>
        /// <param name="workspaceId"></param>
        /// <param name="provider">
        /// Optional provider slug to filter by (e.g. `openai`, `anthropic`, `amazon-bedrock`).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ListBYOKKeysResponse>> ListByokKeysAsResponseAsync(
            int? offset = default,
            int? limit = default,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.ByokGetParametersProvider? provider = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}