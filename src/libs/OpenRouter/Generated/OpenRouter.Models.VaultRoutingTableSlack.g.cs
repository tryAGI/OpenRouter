
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VaultRoutingTableSlack
    {
        /// <summary>
        /// Members whose own Slack account the vault can act as; whether the intern's own Slack app runs is a runtime fact the `connections` tool reports.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member_links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableSlackMemberLink> MemberLinks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTableSlack" /> class.
        /// </summary>
        /// <param name="memberLinks">
        /// Members whose own Slack account the vault can act as; whether the intern's own Slack app runs is a runtime fact the `connections` tool reports.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultRoutingTableSlack(
            global::System.Collections.Generic.IList<global::OpenRouter.VaultRoutingTableSlackMemberLink> memberLinks)
        {
            this.MemberLinks = memberLinks ?? throw new global::System.ArgumentNullException(nameof(memberLinks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTableSlack" /> class.
        /// </summary>
        public VaultRoutingTableSlack()
        {
        }

    }
}