
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"disabled":false,"name":"Updated OpenAI Key"}
    /// </summary>
    public sealed partial class UpdateBYOKKeyRequest
    {
        /// <summary>
        /// Optional allowlist of OpenRouter API key hashes (`api_keys.hash`) that may use this credential. `null` clears the restriction. Must contain at least one hash if provided. Hashes that do not belong to your account return a 400.<br/>
        /// Example: [f01d52606dc8f0a8303a7b5cc3fa07109c2e346cec7c0a16b40de462992ce943]
        /// </summary>
        /// <example>[f01d52606dc8f0a8303a7b5cc3fa07109c2e346cec7c0a16b40de462992ce943]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_api_key_hashes")]
        public global::System.Collections.Generic.IList<string>? AllowedApiKeyHashes { get; set; }

        /// <summary>
        /// Optional allowlist of model slugs this credential may be used for. `null` means no restriction.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_models")]
        public global::System.Collections.Generic.IList<string>? AllowedModels { get; set; }

        /// <summary>
        /// Optional allowlist of user IDs that may use this credential. `null` means no restriction.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_user_ids")]
        public global::System.Collections.Generic.IList<string>? AllowedUserIds { get; set; }

        /// <summary>
        /// Your declaration of the data region in which the upstream provider account behind this credential processes requests, used for routing eligibility on OpenRouter's regional hosts. `null` means undeclared and `global` is behaviorally identical: the credential follows the region OpenRouter records for the endpoint. `europe` or `us` lets requests to `eu.openrouter.ai` or `us.openrouter.ai` use this credential for that provider (private endpoints, endpoints pinned to another cloud region, cross-region inference profiles and video models are excluded). Self-declared and not verified by OpenRouter. For OpenAI and Fireworks the region comes from the key material (a `{"api_key": ..., "region": ...}` key), so the value must match the key's region. Among other providers, only Azure accepts `europe` or `us`. Omit to leave the stored value unchanged (rotating an OpenAI or Fireworks `key` re-derives it from the new key); `null` clears the declaration.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("declared_region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UpdateBYOKKeyRequestDeclaredRegionJsonConverter))]
        public global::OpenRouter.UpdateBYOKKeyRequestDeclaredRegion? DeclaredRegion { get; set; }

        /// <summary>
        /// Your declaration of whether the upstream provider account behind this credential has zero data retention (ZDR). `null` inherits OpenRouter's data policy for the provider's endpoint; `true` declares the account ZDR so requests that require ZDR may route to this credential even when the shared endpoint retains data; `false` declares it non-ZDR so such requests never route to it. Self-declared and not verified by OpenRouter. Omit to leave the stored value unchanged; `null` clears the declaration.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("declared_zdr")]
        public bool? DeclaredZdr { get; set; }

        /// <summary>
        /// Whether this credential is disabled.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Whether OpenRouter's shared endpoints on this provider are removed for every model, including models outside `allowed_models` and after all of your keys for the provider fail. The provider is skipped instead of spending OpenRouter credits. Only valid on non-fallback credentials. Omit to leave the stored value unchanged.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_byok_only")]
        public bool? IsByokOnly { get; set; }

        /// <summary>
        /// Whether this credential is treated as a fallback — used only after non-fallback keys for the same provider have been tried. Cannot be combined with `is_byok_only`. Omit to leave the stored value unchanged.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_fallback")]
        public bool? IsFallback { get; set; }

        /// <summary>
        /// Whether OpenRouter's shared endpoints on this provider are removed for the models this credential applies to (its `allowed_models`, or every model when `null`). Requests for those models run only on your keys; models outside the allowlist may still fall back to shared capacity on this provider. Omit to leave the stored value unchanged.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_required")]
        public bool? IsRequired { get; set; }

        /// <summary>
        /// A new raw provider API key to rotate the credential in-place. The previous key material is overwritten and the masked label is regenerated. Encrypted at rest and never returned in API responses.<br/>
        /// Example: sk-proj-newkey456...
        /// </summary>
        /// <example>sk-proj-newkey456...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Optional human-readable name for the credential.<br/>
        /// Example: Updated OpenAI Key
        /// </summary>
        /// <example>Updated OpenAI Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBYOKKeyRequest" /> class.
        /// </summary>
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
        /// <param name="declaredRegion">
        /// Your declaration of the data region in which the upstream provider account behind this credential processes requests, used for routing eligibility on OpenRouter's regional hosts. `null` means undeclared and `global` is behaviorally identical: the credential follows the region OpenRouter records for the endpoint. `europe` or `us` lets requests to `eu.openrouter.ai` or `us.openrouter.ai` use this credential for that provider (private endpoints, endpoints pinned to another cloud region, cross-region inference profiles and video models are excluded). Self-declared and not verified by OpenRouter. For OpenAI and Fireworks the region comes from the key material (a `{"api_key": ..., "region": ...}` key), so the value must match the key's region. Among other providers, only Azure accepts `europe` or `us`. Omit to leave the stored value unchanged (rotating an OpenAI or Fireworks `key` re-derives it from the new key); `null` clears the declaration.<br/>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateBYOKKeyRequest(
            global::System.Collections.Generic.IList<string>? allowedApiKeyHashes,
            global::System.Collections.Generic.IList<string>? allowedModels,
            global::System.Collections.Generic.IList<string>? allowedUserIds,
            global::OpenRouter.UpdateBYOKKeyRequestDeclaredRegion? declaredRegion,
            bool? declaredZdr,
            bool? disabled,
            bool? isByokOnly,
            bool? isFallback,
            bool? isRequired,
            string? key,
            string? name)
        {
            this.AllowedApiKeyHashes = allowedApiKeyHashes;
            this.AllowedModels = allowedModels;
            this.AllowedUserIds = allowedUserIds;
            this.DeclaredRegion = declaredRegion;
            this.DeclaredZdr = declaredZdr;
            this.Disabled = disabled;
            this.IsByokOnly = isByokOnly;
            this.IsFallback = isFallback;
            this.IsRequired = isRequired;
            this.Key = key;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBYOKKeyRequest" /> class.
        /// </summary>
        public UpdateBYOKKeyRequest()
        {
        }

    }
}