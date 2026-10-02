
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Metadata for the one secret the intern's outbound requests receive under this name. The secret value is never returned. The intern receives it only on requests to a hostname in `hosts`, or on any request when `hosts` is `null`; a request to any other hostname receives no secret under this name, even when another vault holds one. `fingerprint` is comparable only within one vault.<br/>
    /// Example: {"created_at":"2026-09-15T17:44:00.000Z","fingerprint":"sha256:9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08","hosts":["api.github.com"],"name":"github_token","scope":"intern"}
    /// </summary>
    public sealed partial class VaultEffectiveSecret
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fingerprint")]
        public string? Fingerprint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hosts")]
        public global::System.Collections.Generic.IList<string>? Hosts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Where the delivered secret is stored: `intern` for the intern's own vault, `attached` for a vault attached to the intern, `workspace` for the workspace vault.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.VaultEffectiveSecretScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.VaultEffectiveSecretScope Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultEffectiveSecret" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="name"></param>
        /// <param name="scope">
        /// Where the delivered secret is stored: `intern` for the intern's own vault, `attached` for a vault attached to the intern, `workspace` for the workspace vault.
        /// </param>
        /// <param name="fingerprint"></param>
        /// <param name="hosts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultEffectiveSecret(
            global::System.DateTime createdAt,
            string name,
            global::OpenRouter.VaultEffectiveSecretScope scope,
            string? fingerprint,
            global::System.Collections.Generic.IList<string>? hosts)
        {
            this.CreatedAt = createdAt;
            this.Fingerprint = fingerprint;
            this.Hosts = hosts;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultEffectiveSecret" /> class.
        /// </summary>
        public VaultEffectiveSecret()
        {
        }

    }
}