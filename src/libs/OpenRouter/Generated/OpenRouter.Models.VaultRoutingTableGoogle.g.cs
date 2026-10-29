
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VaultRoutingTableGoogle
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accounts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableGoogleAccount> Accounts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTableGoogle" /> class.
        /// </summary>
        /// <param name="accounts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultRoutingTableGoogle(
            global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableGoogleAccount> accounts)
        {
            this.Accounts = accounts ?? throw new global::System.ArgumentNullException(nameof(accounts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTableGoogle" /> class.
        /// </summary>
        public VaultRoutingTableGoogle()
        {
        }

    }
}