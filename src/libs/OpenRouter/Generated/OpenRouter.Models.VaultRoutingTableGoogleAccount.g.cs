
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VaultRoutingTableGoogleAccount
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delegated_capabilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DelegatedCapabilities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("holds_grant")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HoldsGrant { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_delegated_to_intern")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDelegatedToIntern { get; set; }

        /// <summary>
        /// `workspace` applies to every intern of the workspace; `intern` to this intern alone.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.VaultRoutingTableGoogleAccountScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.VaultRoutingTableGoogleAccountScope Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTableGoogleAccount" /> class.
        /// </summary>
        /// <param name="delegatedCapabilities"></param>
        /// <param name="email"></param>
        /// <param name="holdsGrant"></param>
        /// <param name="isDelegatedToIntern"></param>
        /// <param name="scope">
        /// `workspace` applies to every intern of the workspace; `intern` to this intern alone.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultRoutingTableGoogleAccount(
            global::System.Collections.Generic.IList<string> delegatedCapabilities,
            string email,
            bool holdsGrant,
            bool isDelegatedToIntern,
            global::OpenRouter.VaultRoutingTableGoogleAccountScope scope)
        {
            this.DelegatedCapabilities = delegatedCapabilities ?? throw new global::System.ArgumentNullException(nameof(delegatedCapabilities));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.HoldsGrant = holdsGrant;
            this.IsDelegatedToIntern = isDelegatedToIntern;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTableGoogleAccount" /> class.
        /// </summary>
        public VaultRoutingTableGoogleAccount()
        {
        }

    }
}