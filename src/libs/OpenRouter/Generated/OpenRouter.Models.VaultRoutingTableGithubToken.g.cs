
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VaultRoutingTableGithubToken
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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public string? Owner { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_count")]
        public int? RepositoryCount { get; set; }

        /// <summary>
        /// `workspace` applies to every intern of the workspace; `intern` to this intern alone.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.VaultRoutingTableGithubTokenScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.VaultRoutingTableGithubTokenScope Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTableGithubToken" /> class.
        /// </summary>
        /// <param name="holdsToken"></param>
        /// <param name="login"></param>
        /// <param name="scope">
        /// `workspace` applies to every intern of the workspace; `intern` to this intern alone.
        /// </param>
        /// <param name="owner"></param>
        /// <param name="repositoryCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultRoutingTableGithubToken(
            bool holdsToken,
            string login,
            global::OpenRouter.VaultRoutingTableGithubTokenScope scope,
            string? owner,
            int? repositoryCount)
        {
            this.HoldsToken = holdsToken;
            this.Login = login ?? throw new global::System.ArgumentNullException(nameof(login));
            this.Owner = owner;
            this.RepositoryCount = repositoryCount;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTableGithubToken" /> class.
        /// </summary>
        public VaultRoutingTableGithubToken()
        {
        }

    }
}