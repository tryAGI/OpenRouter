
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// One page of secret metadata for the selected scope.<br/>
    /// Example: {"data":[{"created_at":"2026-09-15T17:44:00.000Z","fingerprint":"sha256:9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08","hosts":["api.github.com"],"name":"github_token"},{"created_at":"2026-08-01T09:30:00.000Z","fingerprint":null,"hosts":null,"name":"legacy_token"}],"has_more":false}
    /// </summary>
    public sealed partial class VaultSecretListResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.VaultSecret> Data { get; set; }

        /// <summary>
        /// True when more secrets exist beyond this page. Request the next page with `offset` increased by the number of returned entries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultSecretListResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="hasMore">
        /// True when more secrets exist beyond this page. Request the next page with `offset` increased by the number of returned entries.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultSecretListResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.VaultSecret> data,
            bool hasMore)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultSecretListResponse" /> class.
        /// </summary>
        public VaultSecretListResponse()
        {
        }

    }
}