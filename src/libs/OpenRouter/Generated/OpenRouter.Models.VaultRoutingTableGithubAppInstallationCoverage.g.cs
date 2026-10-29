
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// What GitHub says the installation covers; null until read.
    /// </summary>
    public sealed partial class VaultRoutingTableGithubAppInstallationCoverage
    {
        /// <summary>
        /// When GitHub answered, through the installation token the vault holds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checked_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CheckedAt { get; set; }

        /// <summary>
        /// Repositories the installation covers; null when GitHub did not count them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_count")]
        public int? RepositoryCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.VaultRoutingTableGithubAppInstallationCoverageSelectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.VaultRoutingTableGithubAppInstallationCoverageSelection Selection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTableGithubAppInstallationCoverage" /> class.
        /// </summary>
        /// <param name="checkedAt">
        /// When GitHub answered, through the installation token the vault holds.
        /// </param>
        /// <param name="selection"></param>
        /// <param name="repositoryCount">
        /// Repositories the installation covers; null when GitHub did not count them.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultRoutingTableGithubAppInstallationCoverage(
            global::System.DateTime checkedAt,
            global::OpenRouter.VaultRoutingTableGithubAppInstallationCoverageSelection selection,
            int? repositoryCount)
        {
            this.CheckedAt = checkedAt;
            this.RepositoryCount = repositoryCount;
            this.Selection = selection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTableGithubAppInstallationCoverage" /> class.
        /// </summary>
        public VaultRoutingTableGithubAppInstallationCoverage()
        {
        }

    }
}