
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The BYOK credential.
    /// </summary>
    public sealed partial class GetByokKeyResponseData
    {
        /// <summary>
        /// Optional allowlist of OpenRouter API key hashes (`api_keys.hash`) that may use this credential. `null` means no restriction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_api_key_hashes")]
        public global::System.Collections.Generic.IList<string>? AllowedApiKeyHashes { get; set; }

        /// <summary>
        /// Optional allowlist of model slugs this credential may be used for. `null` means no restriction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_models")]
        public global::System.Collections.Generic.IList<string>? AllowedModels { get; set; }

        /// <summary>
        /// Optional allowlist of user IDs that may use this credential. `null` means no restriction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_user_ids")]
        public global::System.Collections.Generic.IList<string>? AllowedUserIds { get; set; }

        /// <summary>
        /// ISO timestamp of when the credential was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Whether this credential is currently disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Disabled { get; set; }

        /// <summary>
        /// Stable public identifier for this BYOK credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Whether this credential is treated as a fallback — used only after non-fallback keys for the same provider have been tried.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_fallback")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFallback { get; set; }

        /// <summary>
        /// Short masked snippet of the key (e.g. the first/last few characters) used to identify it in the UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// Optional human-readable name for the credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The upstream provider this credential authenticates against, as a lowercase slug (e.g. `openai`, `anthropic`, `amazon-bedrock`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BYOKProviderSlugJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.BYOKProviderSlug Provider { get; set; }

        /// <summary>
        /// Position within the provider — credentials are tried in ascending sort order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_order")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SortOrder { get; set; }

        /// <summary>
        /// ID of the workspace this credential belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetByokKeyResponseData" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// ISO timestamp of when the credential was created.
        /// </param>
        /// <param name="disabled">
        /// Whether this credential is currently disabled.
        /// </param>
        /// <param name="id">
        /// Stable public identifier for this BYOK credential.
        /// </param>
        /// <param name="isFallback">
        /// Whether this credential is treated as a fallback — used only after non-fallback keys for the same provider have been tried.
        /// </param>
        /// <param name="label">
        /// Short masked snippet of the key (e.g. the first/last few characters) used to identify it in the UI.
        /// </param>
        /// <param name="provider">
        /// The upstream provider this credential authenticates against, as a lowercase slug (e.g. `openai`, `anthropic`, `amazon-bedrock`).
        /// </param>
        /// <param name="sortOrder">
        /// Position within the provider — credentials are tried in ascending sort order.
        /// </param>
        /// <param name="workspaceId">
        /// ID of the workspace this credential belongs to.
        /// </param>
        /// <param name="allowedApiKeyHashes">
        /// Optional allowlist of OpenRouter API key hashes (`api_keys.hash`) that may use this credential. `null` means no restriction.
        /// </param>
        /// <param name="allowedModels">
        /// Optional allowlist of model slugs this credential may be used for. `null` means no restriction.
        /// </param>
        /// <param name="allowedUserIds">
        /// Optional allowlist of user IDs that may use this credential. `null` means no restriction.
        /// </param>
        /// <param name="name">
        /// Optional human-readable name for the credential.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetByokKeyResponseData(
            string createdAt,
            bool disabled,
            global::System.Guid id,
            bool isFallback,
            string label,
            global::OpenRouter.BYOKProviderSlug provider,
            int sortOrder,
            global::System.Guid workspaceId,
            global::System.Collections.Generic.IList<string>? allowedApiKeyHashes,
            global::System.Collections.Generic.IList<string>? allowedModels,
            global::System.Collections.Generic.IList<string>? allowedUserIds,
            string? name)
        {
            this.AllowedApiKeyHashes = allowedApiKeyHashes;
            this.AllowedModels = allowedModels;
            this.AllowedUserIds = allowedUserIds;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Disabled = disabled;
            this.Id = id;
            this.IsFallback = isFallback;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Name = name;
            this.Provider = provider;
            this.SortOrder = sortOrder;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetByokKeyResponseData" /> class.
        /// </summary>
        public GetByokKeyResponseData()
        {
        }

    }
}