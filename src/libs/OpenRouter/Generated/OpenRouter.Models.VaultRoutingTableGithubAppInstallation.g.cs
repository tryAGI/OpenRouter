
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VaultRoutingTableGithubAppInstallation
    {
        /// <summary>
        /// The account the App is installed on, as GitHub spells it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Account { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.VaultRoutingTableGithubAppInstallationAccountTypeJsonConverter))]
        public global::OpenRouter.VaultRoutingTableGithubAppInstallationAccountType? AccountType { get; set; }

        /// <summary>
        /// What GitHub says the installation covers; null until read.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coverage")]
        public global::OpenRouter.VaultRoutingTableGithubAppInstallationCoverage? Coverage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CredentialId { get; set; }

        /// <summary>
        /// Whether the vault holds a current installation token to inject.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("holds_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HoldsToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsEnabled { get; set; }

        /// <summary>
        /// The workspace turned this shared installation off or hid it for this intern.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_off_for_intern")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsOffForIntern { get; set; }

        /// <summary>
        /// What egress uses instead of this installation for a request to its account: an earlier installation on the same account, or a token pinned to the account. Null when this installation answers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shadowed_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.VaultRoutingTableGithubAppInstallationShadowedByJsonConverter))]
        public global::OpenRouter.VaultRoutingTableGithubAppInstallationShadowedBy? ShadowedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTableGithubAppInstallation" /> class.
        /// </summary>
        /// <param name="account">
        /// The account the App is installed on, as GitHub spells it.
        /// </param>
        /// <param name="credentialId"></param>
        /// <param name="holdsToken">
        /// Whether the vault holds a current installation token to inject.
        /// </param>
        /// <param name="isEnabled"></param>
        /// <param name="isOffForIntern">
        /// The workspace turned this shared installation off or hid it for this intern.
        /// </param>
        /// <param name="accountType"></param>
        /// <param name="coverage">
        /// What GitHub says the installation covers; null until read.
        /// </param>
        /// <param name="shadowedBy">
        /// What egress uses instead of this installation for a request to its account: an earlier installation on the same account, or a token pinned to the account. Null when this installation answers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultRoutingTableGithubAppInstallation(
            string account,
            string credentialId,
            bool holdsToken,
            bool isEnabled,
            bool isOffForIntern,
            global::OpenRouter.VaultRoutingTableGithubAppInstallationAccountType? accountType,
            global::OpenRouter.VaultRoutingTableGithubAppInstallationCoverage? coverage,
            global::OpenRouter.VaultRoutingTableGithubAppInstallationShadowedBy? shadowedBy)
        {
            this.Account = account ?? throw new global::System.ArgumentNullException(nameof(account));
            this.AccountType = accountType;
            this.Coverage = coverage;
            this.CredentialId = credentialId ?? throw new global::System.ArgumentNullException(nameof(credentialId));
            this.HoldsToken = holdsToken;
            this.IsEnabled = isEnabled;
            this.IsOffForIntern = isOffForIntern;
            this.ShadowedBy = shadowedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTableGithubAppInstallation" /> class.
        /// </summary>
        public VaultRoutingTableGithubAppInstallation()
        {
        }

    }
}