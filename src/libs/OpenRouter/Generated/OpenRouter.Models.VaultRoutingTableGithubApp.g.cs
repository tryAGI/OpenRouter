
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VaultRoutingTableGithubApp
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_slug")]
        public string? AppSlug { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableGithubAppInstallation> Installations { get; set; }

        /// <summary>
        /// Members whose own account the vault would act as on this App's accounts; GitHub still limits a member's token to what that member can reach.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member_links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableGithubAppMemberLink> MemberLinks { get; set; }

        /// <summary>
        /// `workspace` applies to every intern of the workspace; `intern` to this intern alone.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.VaultRoutingTableGithubAppScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.VaultRoutingTableGithubAppScope Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTableGithubApp" /> class.
        /// </summary>
        /// <param name="installations"></param>
        /// <param name="memberLinks">
        /// Members whose own account the vault would act as on this App's accounts; GitHub still limits a member's token to what that member can reach.
        /// </param>
        /// <param name="scope">
        /// `workspace` applies to every intern of the workspace; `intern` to this intern alone.
        /// </param>
        /// <param name="appId"></param>
        /// <param name="appSlug"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultRoutingTableGithubApp(
            global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableGithubAppInstallation> installations,
            global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableGithubAppMemberLink> memberLinks,
            global::OpenRouter.VaultRoutingTableGithubAppScope scope,
            string? appId,
            string? appSlug)
        {
            this.AppId = appId;
            this.AppSlug = appSlug;
            this.Installations = installations ?? throw new global::System.ArgumentNullException(nameof(installations));
            this.MemberLinks = memberLinks ?? throw new global::System.ArgumentNullException(nameof(memberLinks));
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTableGithubApp" /> class.
        /// </summary>
        public VaultRoutingTableGithubApp()
        {
        }

    }
}