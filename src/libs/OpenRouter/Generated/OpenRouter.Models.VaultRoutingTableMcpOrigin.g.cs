
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VaultRoutingTableMcpOrigin
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_key")]
        public string? AccountKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Host { get; set; }

        /// <summary>
        /// Members' own accounts, matched to the acting member per turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_personal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPersonal { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableMcpOriginRoute> Routes { get; set; }

        /// <summary>
        /// The vault's decision for a request to this server; null for members' own accounts, decided per acting member.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::OpenRouter.VaultRoutingTableMcpOriginStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTableMcpOrigin" /> class.
        /// </summary>
        /// <param name="host"></param>
        /// <param name="isPersonal">
        /// Members' own accounts, matched to the acting member per turn.
        /// </param>
        /// <param name="routes"></param>
        /// <param name="accountKey"></param>
        /// <param name="status">
        /// The vault's decision for a request to this server; null for members' own accounts, decided per acting member.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultRoutingTableMcpOrigin(
            string host,
            bool isPersonal,
            global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableMcpOriginRoute> routes,
            string? accountKey,
            global::OpenRouter.VaultRoutingTableMcpOriginStatus? status)
        {
            this.AccountKey = accountKey;
            this.Host = host ?? throw new global::System.ArgumentNullException(nameof(host));
            this.IsPersonal = isPersonal;
            this.Routes = routes ?? throw new global::System.ArgumentNullException(nameof(routes));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTableMcpOrigin" /> class.
        /// </summary>
        public VaultRoutingTableMcpOrigin()
        {
        }

    }
}