
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VaultRoutingTableGithubAppMemberLink
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("holds_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HoldsToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Login { get; set; }

        /// <summary>
        /// How the vault picks this link for the App, by the same selection egress uses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("via")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.VaultRoutingTableGithubAppMemberLinkViaJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.VaultRoutingTableGithubAppMemberLinkVia Via { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTableGithubAppMemberLink" /> class.
        /// </summary>
        /// <param name="holdsToken"></param>
        /// <param name="login"></param>
        /// <param name="via">
        /// How the vault picks this link for the App, by the same selection egress uses.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultRoutingTableGithubAppMemberLink(
            bool holdsToken,
            string login,
            global::OpenRouter.VaultRoutingTableGithubAppMemberLinkVia via)
        {
            this.HoldsToken = holdsToken;
            this.Login = login ?? throw new global::System.ArgumentNullException(nameof(login));
            this.Via = via;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTableGithubAppMemberLink" /> class.
        /// </summary>
        public VaultRoutingTableGithubAppMemberLink()
        {
        }

    }
}