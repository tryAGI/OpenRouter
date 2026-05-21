
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateBYOKKeyRequest
    {
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
        /// Whether this credential should be created in a disabled state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Whether this credential is treated as a fallback — used only after non-fallback keys for the same provider have been tried.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_fallback")]
        public bool? IsFallback { get; set; }

        /// <summary>
        /// The raw provider API key or credential. This value is encrypted at rest and never returned in API responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

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
        /// Optional workspace ID. Defaults to the authenticated entity's default workspace.
        /// </summary>
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
        /// The raw provider API key or credential. This value is encrypted at rest and never returned in API responses.
        /// </param>
        /// <param name="provider">
        /// The upstream provider this credential authenticates against, as a lowercase slug (e.g. `openai`, `anthropic`, `amazon-bedrock`).
        /// </param>
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
        /// <param name="name">
        /// Optional human-readable name for the credential.
        /// </param>
        /// <param name="workspaceId">
        /// Optional workspace ID. Defaults to the authenticated entity's default workspace.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBYOKKeyRequest(
            string key,
            global::OpenRouter.BYOKProviderSlug provider,
            global::System.Collections.Generic.IList<string>? allowedModels,
            global::System.Collections.Generic.IList<string>? allowedUserIds,
            bool? disabled,
            bool? isFallback,
            string? name,
            global::System.Guid? workspaceId)
        {
            this.AllowedModels = allowedModels;
            this.AllowedUserIds = allowedUserIds;
            this.Disabled = disabled;
            this.IsFallback = isFallback;
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