#nullable enable

namespace OpenRouter
{
    public partial interface IByokClient
    {
        /// <summary>
        /// Create a BYOK provider credential<br/>
        /// Create a new bring-your-own-key (BYOK) provider credential. The raw key is encrypted at rest and never returned in API responses. Defaults to the authenticated entity's default workspace; use the `workspace_id` body field to scope to a different workspace. Treat the raw key as write-only; it is never returned after creation. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreateBYOKKeyResponse> CreateByokKeyAsync(

            global::OpenRouter.CreateBYOKKeyRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a BYOK provider credential<br/>
        /// Create a new bring-your-own-key (BYOK) provider credential. The raw key is encrypted at rest and never returned in API responses. Defaults to the authenticated entity's default workspace; use the `workspace_id` body field to scope to a different workspace. Treat the raw key as write-only; it is never returned after creation. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.CreateBYOKKeyResponse>> CreateByokKeyAsResponseAsync(

            global::OpenRouter.CreateBYOKKeyRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a BYOK provider credential<br/>
        /// Create a new bring-your-own-key (BYOK) provider credential. The raw key is encrypted at rest and never returned in API responses. Defaults to the authenticated entity's default workspace; use the `workspace_id` body field to scope to a different workspace. Treat the raw key as write-only; it is never returned after creation. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="allowedModels">
        /// Optional allowlist of model slugs this credential may be used for. `null` means no restriction.
        /// </param>
        /// <param name="allowedUserIds">
        /// Optional allowlist of user IDs that may use this credential. `null` means no restriction.
        /// </param>
        /// <param name="disabled">
        /// Whether this credential should be created in a disabled state.
        /// </param>
        /// <param name="isFallback">
        /// Whether this credential is treated as a fallback — used only after non-fallback keys for the same provider have been tried.
        /// </param>
        /// <param name="key">
        /// The raw provider API key or credential. This value is encrypted at rest and never returned in API responses.
        /// </param>
        /// <param name="name">
        /// Optional human-readable name for the credential.
        /// </param>
        /// <param name="provider">
        /// The upstream provider this credential authenticates against, as a lowercase slug (e.g. `openai`, `anthropic`, `amazon-bedrock`).
        /// </param>
        /// <param name="workspaceId">
        /// Optional workspace ID. Defaults to the authenticated entity's default workspace.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreateBYOKKeyResponse> CreateByokKeyAsync(
            string key,
            global::OpenRouter.BYOKProviderSlug provider,
            global::System.Collections.Generic.IList<string>? allowedModels = default,
            global::System.Collections.Generic.IList<string>? allowedUserIds = default,
            bool? disabled = default,
            bool? isFallback = default,
            string? name = default,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}