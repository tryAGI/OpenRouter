
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VaultRoutingTableHostRule
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("holds_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HoldsSecret { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Host { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTableHostRule" /> class.
        /// </summary>
        /// <param name="holdsSecret"></param>
        /// <param name="host"></param>
        /// <param name="secretName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultRoutingTableHostRule(
            bool holdsSecret,
            string host,
            string secretName)
        {
            this.HoldsSecret = holdsSecret;
            this.Host = host ?? throw new global::System.ArgumentNullException(nameof(host));
            this.SecretName = secretName ?? throw new global::System.ArgumentNullException(nameof(secretName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTableHostRule" /> class.
        /// </summary>
        public VaultRoutingTableHostRule()
        {
        }

    }
}