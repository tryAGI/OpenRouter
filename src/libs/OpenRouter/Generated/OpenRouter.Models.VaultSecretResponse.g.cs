
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Metadata for the stored secret.<br/>
    /// Example: {"data":{"created_at":"2026-09-15T17:44:00.000Z","fingerprint":"sha256:9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08","hosts":["api.github.com"],"name":"github_token"}}
    /// </summary>
    public sealed partial class VaultSecretResponse
    {
        /// <summary>
        /// Metadata for one stored secret. The secret value is never returned. `fingerprint` is an HMAC-SHA-256 of the value keyed with that vault's own data key, so it is comparable only within one vault: equal fingerprints in one vault mean equal values, and rewriting the same value keeps its fingerprint. The same value stored in two vaults (for example a workspace secret and its intern copy) carries different fingerprints, so comparing fingerprints across vaults cannot show that a copy matches or that a rotation propagated. `hosts` and `fingerprint` are `null` only for legacy rows written before host binding was required; storing the secret again assigns hosts.<br/>
        /// Example: {"created_at":"2026-09-15T17:44:00.000Z","fingerprint":"sha256:9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08","hosts":["api.github.com"],"name":"github_token"}
        /// </summary>
        /// <example>{"created_at":"2026-09-15T17:44:00.000Z","fingerprint":"sha256:9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08","hosts":["api.github.com"],"name":"github_token"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.VaultSecret Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultSecretResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Metadata for one stored secret. The secret value is never returned. `fingerprint` is an HMAC-SHA-256 of the value keyed with that vault's own data key, so it is comparable only within one vault: equal fingerprints in one vault mean equal values, and rewriting the same value keeps its fingerprint. The same value stored in two vaults (for example a workspace secret and its intern copy) carries different fingerprints, so comparing fingerprints across vaults cannot show that a copy matches or that a rotation propagated. `hosts` and `fingerprint` are `null` only for legacy rows written before host binding was required; storing the secret again assigns hosts.<br/>
        /// Example: {"created_at":"2026-09-15T17:44:00.000Z","fingerprint":"sha256:9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08","hosts":["api.github.com"],"name":"github_token"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultSecretResponse(
            global::OpenRouter.VaultSecret data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultSecretResponse" /> class.
        /// </summary>
        public VaultSecretResponse()
        {
        }

    }
}