
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"key":"sk-proj-abc123...","name":"Production OpenAI Key","provider":"openai"}
    /// </summary>
    public sealed partial class CreateBYOKKeyRequest
    {
        /// <summary>
        /// Optional allowlist of OpenRouter API key hashes (`api_keys.hash`) that may use this credential. `null` means no restriction. Must contain at least one hash if provided. Hashes that do not belong to your account return a 400.<br/>
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
        /// Your declaration of whether the upstream provider account behind this credential has zero data retention (ZDR). `null` inherits OpenRouter's data policy for the provider's endpoint; `true` declares the account ZDR so requests that require ZDR may route to this credential even when the shared endpoint retains data; `false` declares it non-ZDR so such requests never route to it. Self-declared and not verified by OpenRouter. Defaults to `null`.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("declared_zdr")]
        public bool? DeclaredZdr { get; set; }

        /// <summary>
        /// Whether this credential should be created in a disabled state.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Whether OpenRouter's shared endpoints on this provider are removed for every model, including models outside `allowed_models` and after all of your keys for the provider fail. The provider is skipped instead of spending OpenRouter credits. Only valid on non-fallback credentials. Defaults to `false`.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_byok_only")]
        public bool? IsByokOnly { get; set; }

        /// <summary>
        /// Whether this credential is treated as a fallback — used only after non-fallback keys for the same provider have been tried. Cannot be combined with `is_byok_only`.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_fallback")]
        public bool? IsFallback { get; set; }

        /// <summary>
        /// Whether OpenRouter's shared endpoints on this provider are removed for the models this credential applies to (its `allowed_models`, or every model when `null`). Requests for those models run only on your keys; models outside the allowlist may still fall back to shared capacity on this provider. Defaults to `false`.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_required")]
        public bool? IsRequired { get; set; }

        /// <summary>
        /// The raw provider API key or credential. This value is encrypted at rest and never returned in API responses.<br/>
        /// Example: sk-proj-abc123...
        /// </summary>
        /// <example>sk-proj-abc123...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

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
        /// Optional workspace ID to scope the credential to. When omitted, the credential is created in the account's default workspace; if that default has been deleted, the request returns a 400 and you must pass `workspace_id` explicitly.<br/>
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
        /// Initializes a new instance of the <see cref="CreateBYOKKeyRequest" /> class.
        /// </summary>
        /// <param name="key">
        /// The raw provider API key or credential. This value is encrypted at rest and never returned in API responses.<br/>
        /// Example: sk-proj-abc123...
        /// </param>
        /// <param name="provider">
        /// The upstream provider this credential authenticates against, as a lowercase slug (e.g. `openai`, `anthropic`, `amazon-bedrock`).<br/>
        /// Example: openai
        /// </param>
        /// <param name="allowedApiKeyHashes">
        /// Optional allowlist of OpenRouter API key hashes (`api_keys.hash`) that may use this credential. `null` means no restriction. Must contain at least one hash if provided. Hashes that do not belong to your account return a 400.<br/>
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
        /// Your declaration of whether the upstream provider account behind this credential has zero data retention (ZDR). `null` inherits OpenRouter's data policy for the provider's endpoint; `true` declares the account ZDR so requests that require ZDR may route to this credential even when the shared endpoint retains data; `false` declares it non-ZDR so such requests never route to it. Self-declared and not verified by OpenRouter. Defaults to `null`.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="disabled">
        /// Whether this credential should be created in a disabled state.<br/>
        /// Example: false
        /// </param>
        /// <param name="isByokOnly">
        /// Whether OpenRouter's shared endpoints on this provider are removed for every model, including models outside `allowed_models` and after all of your keys for the provider fail. The provider is skipped instead of spending OpenRouter credits. Only valid on non-fallback credentials. Defaults to `false`.<br/>
        /// Example: false
        /// </param>
        /// <param name="isFallback">
        /// Whether this credential is treated as a fallback — used only after non-fallback keys for the same provider have been tried. Cannot be combined with `is_byok_only`.<br/>
        /// Example: false
        /// </param>
        /// <param name="isRequired">
        /// Whether OpenRouter's shared endpoints on this provider are removed for the models this credential applies to (its `allowed_models`, or every model when `null`). Requests for those models run only on your keys; models outside the allowlist may still fall back to shared capacity on this provider. Defaults to `false`.<br/>
        /// Example: false
        /// </param>
        /// <param name="name">
        /// Optional human-readable name for the credential.<br/>
        /// Example: Production OpenAI Key
        /// </param>
        /// <param name="workspaceId">
        /// Optional workspace ID to scope the credential to. When omitted, the credential is created in the account's default workspace; if that default has been deleted, the request returns a 400 and you must pass `workspace_id` explicitly.<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBYOKKeyRequest(
            string key,
            global::OpenRouter.BYOKProviderSlug provider,
            global::System.Collections.Generic.IList<string>? allowedApiKeyHashes,
            global::System.Collections.Generic.IList<string>? allowedModels,
            global::System.Collections.Generic.IList<string>? allowedUserIds,
            bool? declaredZdr,
            bool? disabled,
            bool? isByokOnly,
            bool? isFallback,
            bool? isRequired,
            string? name,
            global::System.Guid? workspaceId)
        {
            this.AllowedApiKeyHashes = allowedApiKeyHashes;
            this.AllowedModels = allowedModels;
            this.AllowedUserIds = allowedUserIds;
            this.DeclaredZdr = declaredZdr;
            this.Disabled = disabled;
            this.IsByokOnly = isByokOnly;
            this.IsFallback = isFallback;
            this.IsRequired = isRequired;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Name = name;
            this.Provider = provider;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBYOKKeyRequest" /> class.
        /// </summary>
        public CreateBYOKKeyRequest()
        {
        }

    }
}