
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Secret value and the exact hostnames it may be released to.<br/>
    /// Example: {"hosts":["api.github.com"],"value":"ghp_exampleTokenValue"}
    /// </summary>
    public sealed partial class VaultSecretWriteRequest
    {
        /// <summary>
        /// Exact DNS hostnames the secret may be sent to, 1 to 100 entries. Each entry is lowercased and a trailing dot is removed, so `API.Example.com.` is stored as `api.example.com`. Schemes, ports, paths, wildcards and empty values are rejected. Duplicates after normalization are collapsed. Matching is exact: a secret bound to `api.example.com` is never released to `example.com` or any other hostname.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hosts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Hosts { get; set; }

        /// <summary>
        /// Secret value, 1 to 65536 characters. It is encrypted at rest and never returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultSecretWriteRequest" /> class.
        /// </summary>
        /// <param name="hosts">
        /// Exact DNS hostnames the secret may be sent to, 1 to 100 entries. Each entry is lowercased and a trailing dot is removed, so `API.Example.com.` is stored as `api.example.com`. Schemes, ports, paths, wildcards and empty values are rejected. Duplicates after normalization are collapsed. Matching is exact: a secret bound to `api.example.com` is never released to `example.com` or any other hostname.
        /// </param>
        /// <param name="value">
        /// Secret value, 1 to 65536 characters. It is encrypted at rest and never returned.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultSecretWriteRequest(
            global::System.Collections.Generic.IList<string> hosts,
            string value)
        {
            this.Hosts = hosts ?? throw new global::System.ArgumentNullException(nameof(hosts));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultSecretWriteRequest" /> class.
        /// </summary>
        public VaultSecretWriteRequest()
        {
        }

    }
}