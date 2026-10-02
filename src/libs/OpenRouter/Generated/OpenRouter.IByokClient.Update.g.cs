#nullable enable

namespace OpenRouter
{
    public partial interface IByokClient
    {
        /// <summary>
        /// Update a BYOK provider credential<br/>
        /// Update an existing bring-your-own-key (BYOK) provider credential by its `id`. Include the `key` field to rotate the raw provider API key in-place (the previous key material is overwritten). Use `allowed_api_key_hashes` to restrict the credential to specific OpenRouter API keys (`null` clears the restriction). [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// The BYOK credential ID (UUID).<br/>
        /// Example: 11111111-2222-3333-4444-555555555555
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.UpdateBYOKKeyResponse> UpdateAsync(
            global::System.Guid id,

            global::OpenRouter.UpdateBYOKKeyRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a BYOK provider credential<br/>
        /// Update an existing bring-your-own-key (BYOK) provider credential by its `id`. Include the `key` field to rotate the raw provider API key in-place (the previous key material is overwritten). Use `allowed_api_key_hashes` to restrict the credential to specific OpenRouter API keys (`null` clears the restriction). [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// The BYOK credential ID (UUID).<br/>
        /// Example: 11111111-2222-3333-4444-555555555555
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.UpdateBYOKKeyResponse>> UpdateAsResponseAsync(
            global::System.Guid id,

            global::OpenRouter.UpdateBYOKKeyRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a BYOK provider credential<br/>
        /// Update an existing bring-your-own-key (BYOK) provider credential by its `id`. Include the `key` field to rotate the raw provider API key in-place (the previous key material is overwritten). Use `allowed_api_key_hashes` to restrict the credential to specific OpenRouter API keys (`null` clears the restriction). [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// The BYOK credential ID (UUID).<br/>
        /// Example: 11111111-2222-3333-4444-555555555555
        /// </param>
        /// <param name="allowedApiKeyHashes">
        /// Optional allowlist of OpenRouter API key hashes (`api_keys.hash`) that may use this credential. `null` clears the restriction. Must contain at least one hash if provided. Hashes that do not belong to your account return a 400.<br/>
        /// Example: [f01d52606dc8f0a8303a7b5cc3fa07109c2e346cec7c0a16b40de462992ce943]
        /// </param>
        /// <param name="allowedModels">
        /// Optional allowlist of model slugs this credential may be used for. `null` means no restriction.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="allowedUserIds">
        /// Optional allowlist of user IDs that may use this credential. `null` means no restriction.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="declaredZdr">
        /// Your declaration of whether the upstream provider account behind this credential has zero data retention (ZDR). `null` inherits OpenRouter's data policy for the provider's endpoint; `true` declares the account ZDR so requests that require ZDR may route to this credential even when the shared endpoint retains data; `false` declares it non-ZDR so such requests never route to it. Self-declared and not verified by OpenRouter. Omit to leave the stored value unchanged; `null` clears the declaration.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="disabled">
        /// Whether this credential is disabled.<br/>
        /// Example: false
        /// </param>
        /// <param name="isByokOnly">
        /// Whether OpenRouter's shared endpoints on this provider are removed for every model, including models outside `allowed_models` and after all of your keys for the provider fail. The provider is skipped instead of spending OpenRouter credits. Only valid on non-fallback credentials. Omit to leave the stored value unchanged.<br/>
        /// Example: false
        /// </param>
        /// <param name="isFallback">
        /// Whether this credential is treated as a fallback — used only after non-fallback keys for the same provider have been tried. Cannot be combined with `is_byok_only`. Omit to leave the stored value unchanged.<br/>
        /// Example: false
        /// </param>
        /// <param name="isRequired">
        /// Whether OpenRouter's shared endpoints on this provider are removed for the models this credential applies to (its `allowed_models`, or every model when `null`). Requests for those models run only on your keys; models outside the allowlist may still fall back to shared capacity on this provider. Omit to leave the stored value unchanged.<br/>
        /// Example: false
        /// </param>
        /// <param name="key">
        /// A new raw provider API key to rotate the credential in-place. The previous key material is overwritten and the masked label is regenerated. Encrypted at rest and never returned in API responses.<br/>
        /// Example: sk-proj-newkey456...
        /// </param>
        /// <param name="name">
        /// Optional human-readable name for the credential.<br/>
        /// Example: Updated OpenAI Key
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.UpdateBYOKKeyResponse> UpdateAsync(
            global::System.Guid id,
            global::System.Collections.Generic.IList<string>? allowedApiKeyHashes = default,
            global::System.Collections.Generic.IList<string>? allowedModels = default,
            global::System.Collections.Generic.IList<string>? allowedUserIds = default,
            bool? declaredZdr = default,
            bool? disabled = default,
            bool? isByokOnly = default,
            bool? isFallback = default,
            bool? isRequired = default,
            string? key = default,
            string? name = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}