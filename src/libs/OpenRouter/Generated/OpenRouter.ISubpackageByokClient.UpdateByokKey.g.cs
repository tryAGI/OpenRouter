#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageByokClient
    {
        /// <summary>
        /// Update a BYOK provider credential<br/>
        /// Update an existing bring-your-own-key (BYOK) provider credential by its `id`. Include the `key` field to rotate the raw provider API key in-place (the previous key material is overwritten). [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.UpdateBYOKKeyResponse> UpdateByokKeyAsync(
            global::System.Guid id,

            global::OpenRouter.UpdateBYOKKeyRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a BYOK provider credential<br/>
        /// Update an existing bring-your-own-key (BYOK) provider credential by its `id`. Include the `key` field to rotate the raw provider API key in-place (the previous key material is overwritten). [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.UpdateBYOKKeyResponse>> UpdateByokKeyAsResponseAsync(
            global::System.Guid id,

            global::OpenRouter.UpdateBYOKKeyRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a BYOK provider credential<br/>
        /// Update an existing bring-your-own-key (BYOK) provider credential by its `id`. Include the `key` field to rotate the raw provider API key in-place (the previous key material is overwritten). [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="allowedModels">
        /// Optional allowlist of model slugs this credential may be used for. `null` means no restriction.
        /// </param>
        /// <param name="allowedUserIds">
        /// Optional allowlist of user IDs that may use this credential. `null` means no restriction.
        /// </param>
        /// <param name="disabled">
        /// Whether this credential is disabled.
        /// </param>
        /// <param name="isFallback">
        /// Whether this credential is treated as a fallback — used only after non-fallback keys for the same provider have been tried.
        /// </param>
        /// <param name="key">
        /// A new raw provider API key to rotate the credential in-place. The previous key material is overwritten and the masked label is regenerated. Encrypted at rest and never returned in API responses.
        /// </param>
        /// <param name="name">
        /// Optional human-readable name for the credential.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.UpdateBYOKKeyResponse> UpdateByokKeyAsync(
            global::System.Guid id,
            global::System.Collections.Generic.IList<string>? allowedModels = default,
            global::System.Collections.Generic.IList<string>? allowedUserIds = default,
            bool? disabled = default,
            bool? isFallback = default,
            string? key = default,
            string? name = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}