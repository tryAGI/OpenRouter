
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"allowed_api_key_hashes":null,"allowed_models":null,"allowed_user_ids":null,"created_at":"2025-08-24T10:30:00Z","declared_region":null,"declared_zdr":null,"disabled":false,"id":"11111111-2222-3333-4444-555555555555","is_byok_only":false,"is_fallback":false,"is_required":false,"label":"sk-...AbCd","name":"Production OpenAI Key","provider":"openai","sort_order":0,"workspace_id":"550e8400-e29b-41d4-a716-446655440000"}
    /// </summary>
    public sealed partial class BYOKKey
    {
        /// <summary>
        /// Optional allowlist of OpenRouter API key hashes (`api_keys.hash`) that may use this credential. `null` means no restriction.<br/>
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
        /// ISO timestamp of when the credential was created.<br/>
        /// Example: 2025-08-24T10:30:00Z
        /// </summary>
        /// <example>2025-08-24T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Your declaration of the data region in which the upstream provider account behind this credential processes requests, used for routing eligibility on OpenRouter's regional hosts. `null` means undeclared and `global` is behaviorally identical: the credential follows the region OpenRouter records for the endpoint. `europe` or `us` lets requests to `eu.openrouter.ai` or `us.openrouter.ai` use this credential for that provider (private endpoints, endpoints pinned to another cloud region, cross-region inference profiles and video models are excluded). Self-declared and not verified by OpenRouter. For OpenAI and Fireworks the region comes from the key material (a `{"api_key": ..., "region": ...}` key), so the value must match the key's region. Among other providers, only Azure accepts `europe` or `us`.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("declared_region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BYOKKeyDeclaredRegionJsonConverter))]
        public global::OpenRouter.BYOKKeyDeclaredRegion? DeclaredRegion { get; set; }

        /// <summary>
        /// Your declaration of whether the upstream provider account behind this credential has zero data retention (ZDR). `null` inherits OpenRouter's data policy for the provider's endpoint; `true` declares the account ZDR so requests that require ZDR may route to this credential even when the shared endpoint retains data; `false` declares it non-ZDR so such requests never route to it. Self-declared and not verified by OpenRouter.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("declared_zdr")]
        public bool? DeclaredZdr { get; set; }

        /// <summary>
        /// Whether this credential is currently disabled.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Disabled { get; set; }

        /// <summary>
        /// Stable public identifier for this BYOK credential.<br/>
        /// Example: 11111111-2222-3333-4444-555555555555
        /// </summary>
        /// <example>11111111-2222-3333-4444-555555555555</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Whether OpenRouter's shared endpoints on this provider are removed for every model, including models outside `allowed_models` and after all of your keys for the provider fail. The provider is skipped instead of spending OpenRouter credits. Only valid on non-fallback credentials.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_byok_only")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsByokOnly { get; set; }

        /// <summary>
        /// Whether this credential is treated as a fallback — used only after non-fallback keys for the same provider have been tried. Cannot be combined with `is_byok_only`.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_fallback")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFallback { get; set; }

        /// <summary>
        /// Whether OpenRouter's shared endpoints on this provider are removed for the models this credential applies to (its `allowed_models`, or every model when `null`). Requests for those models run only on your keys; models outside the allowlist may still fall back to shared capacity on this provider.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_required")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsRequired { get; set; }

        /// <summary>
        /// Short masked snippet of the key (e.g. the first/last few characters) used to identify it in the UI.<br/>
        /// Example: sk-...AbCd
        /// </summary>
        /// <example>sk-...AbCd</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Optional human-readable name for the credential.<br/>
        /// Example: Production OpenAI Key
        /// </summary>
        /// <example>Production OpenAI Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The upstream provider this credential authenticates against, as a lowercase slug (e.g. `openai`, `anthropic`, `amazon-bedrock`).<br/>
        /// Example: openai
        /// </summary>
        /// <example>openai</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BYOKProviderSlugJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.BYOKProviderSlug Provider { get; set; }

        /// <summary>
        /// Position within the provider — credentials are tried in ascending sort order.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_order")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SortOrder { get; set; }

        /// <summary>
        /// The workspace this credential is scoped to, or `null` when it is global — usable across every workspace in the account. A `null` value does not mean the default workspace.<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BYOKKey" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// ISO timestamp of when the credential was created.<br/>
        /// Example: 2025-08-24T10:30:00Z
        /// </param>
        /// <param name="disabled">
        /// Whether this credential is currently disabled.<br/>
        /// Example: false
        /// </param>
        /// <param name="id">
        /// Stable public identifier for this BYOK credential.<br/>
        /// Example: 11111111-2222-3333-4444-555555555555
        /// </param>
        /// <param name="isByokOnly">
        /// Whether OpenRouter's shared endpoints on this provider are removed for every model, including models outside `allowed_models` and after all of your keys for the provider fail. The provider is skipped instead of spending OpenRouter credits. Only valid on non-fallback credentials.<br/>
        /// Example: false
        /// </param>
        /// <param name="isFallback">
        /// Whether this credential is treated as a fallback — used only after non-fallback keys for the same provider have been tried. Cannot be combined with `is_byok_only`.<br/>
        /// Example: false
        /// </param>
        /// <param name="isRequired">
        /// Whether OpenRouter's shared endpoints on this provider are removed for the models this credential applies to (its `allowed_models`, or every model when `null`). Requests for those models run only on your keys; models outside the allowlist may still fall back to shared capacity on this provider.<br/>
        /// Example: false
        /// </param>
        /// <param name="label">
        /// Short masked snippet of the key (e.g. the first/last few characters) used to identify it in the UI.<br/>
        /// Example: sk-...AbCd
        /// </param>
        /// <param name="provider">
        /// The upstream provider this credential authenticates against, as a lowercase slug (e.g. `openai`, `anthropic`, `amazon-bedrock`).<br/>
        /// Example: openai
        /// </param>
        /// <param name="sortOrder">
        /// Position within the provider — credentials are tried in ascending sort order.<br/>
        /// Example: 0
        /// </param>
        /// <param name="allowedApiKeyHashes">
        /// Optional allowlist of OpenRouter API key hashes (`api_keys.hash`) that may use this credential. `null` means no restriction.<br/>
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
        /// Your declaration of the data region in which the upstream provider account behind this credential processes requests, used for routing eligibility on OpenRouter's regional hosts. `null` means undeclared and `global` is behaviorally identical: the credential follows the region OpenRouter records for the endpoint. `europe` or `us` lets requests to `eu.openrouter.ai` or `us.openrouter.ai` use this credential for that provider (private endpoints, endpoints pinned to another cloud region, cross-region inference profiles and video models are excluded). Self-declared and not verified by OpenRouter. For OpenAI and Fireworks the region comes from the key material (a `{"api_key": ..., "region": ...}` key), so the value must match the key's region. Among other providers, only Azure accepts `europe` or `us`.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="declaredZdr">
        /// Your declaration of whether the upstream provider account behind this credential has zero data retention (ZDR). `null` inherits OpenRouter's data policy for the provider's endpoint; `true` declares the account ZDR so requests that require ZDR may route to this credential even when the shared endpoint retains data; `false` declares it non-ZDR so such requests never route to it. Self-declared and not verified by OpenRouter.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="name">
        /// Optional human-readable name for the credential.<br/>
        /// Example: Production OpenAI Key
        /// </param>
        /// <param name="workspaceId">
        /// The workspace this credential is scoped to, or `null` when it is global — usable across every workspace in the account. A `null` value does not mean the default workspace.<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BYOKKey(
            string createdAt,
            bool disabled,
            global::System.Guid id,
            bool isByokOnly,
            bool isFallback,
            bool isRequired,
            string label,
            global::OpenRouter.BYOKProviderSlug provider,
            int sortOrder,
            global::System.Collections.Generic.IList<string>? allowedApiKeyHashes,
            global::System.Collections.Generic.IList<string>? allowedModels,
            global::System.Collections.Generic.IList<string>? allowedUserIds,
            global::OpenRouter.BYOKKeyDeclaredRegion? declaredRegion,
            bool? declaredZdr,
            string? name,
            global::System.Guid? workspaceId)
        {
            this.AllowedApiKeyHashes = allowedApiKeyHashes;
            this.AllowedModels = allowedModels;
            this.AllowedUserIds = allowedUserIds;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.DeclaredRegion = declaredRegion;
            this.DeclaredZdr = declaredZdr;
            this.Disabled = disabled;
            this.Id = id;
            this.IsByokOnly = isByokOnly;
            this.IsFallback = isFallback;
            this.IsRequired = isRequired;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Name = name;
            this.Provider = provider;
            this.SortOrder = sortOrder;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BYOKKey" /> class.
        /// </summary>
        public BYOKKey()
        {
        }

    }
}