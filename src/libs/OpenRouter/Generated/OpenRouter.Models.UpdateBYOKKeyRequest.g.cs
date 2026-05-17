
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateBYOKKeyRequest
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
        /// Whether this credential is disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Whether this credential is treated as a fallback — used only after non-fallback keys for the same provider have been tried.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_fallback")]
        public bool? IsFallback { get; set; }

        /// <summary>
        /// A new raw provider API key to rotate the credential in-place. The previous key material is overwritten and the masked label is regenerated. Encrypted at rest and never returned in API responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Optional human-readable name for the credential.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateBYOKKeyRequest(
            global::System.Collections.Generic.IList<string>? allowedModels,
            global::System.Collections.Generic.IList<string>? allowedUserIds,
            bool? disabled,
            bool? isFallback,
            string? key,
            string? name)
        {
            this.AllowedModels = allowedModels;
            this.AllowedUserIds = allowedUserIds;
            this.Disabled = disabled;
            this.IsFallback = isFallback;
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