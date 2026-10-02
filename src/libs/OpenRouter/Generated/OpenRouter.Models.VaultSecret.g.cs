
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Metadata for one stored secret. The secret value is never returned. `fingerprint` is an HMAC-SHA-256 of the value keyed with that vault's own data key, so it is comparable only within one vault: equal fingerprints in one vault mean equal values, and rewriting the same value keeps its fingerprint. The same value stored in two vaults (for example a workspace secret and its intern copy) carries different fingerprints, so comparing fingerprints across vaults cannot show that a copy matches or that a rotation propagated. `hosts` and `fingerprint` are `null` only for legacy rows written before host binding was required; storing the secret again assigns hosts.<br/>
    /// Example: {"created_at":"2026-09-15T17:44:00.000Z","fingerprint":"sha256:9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08","hosts":["api.github.com"],"name":"github_token"}
    /// </summary>
    public sealed partial class VaultSecret
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultSecret" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="name"></param>
        /// <param name="fingerprint"></param>
        /// <param name="hosts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultSecret(
            global::System.DateTime createdAt,
            string name,
            string? fingerprint,
            global::System.Collections.Generic.IList<string>? hosts)
        {
            this.CreatedAt = createdAt;
            this.Fingerprint = fingerprint;
            this.Hosts = hosts;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultSecret" /> class.
        /// </summary>
        public VaultSecret()
        {
        }

    }
}