
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VaultRoutingTableSlackMemberLink
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
        [global::System.Text.Json.Serialization.JsonPropertyName("slack_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SlackUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTableSlackMemberLink" /> class.
        /// </summary>
        /// <param name="holdsToken"></param>
        /// <param name="slackUserId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VaultRoutingTableSlackMemberLink(
            bool holdsToken,
            string slackUserId)
        {
            this.HoldsToken = holdsToken;
            this.SlackUserId = slackUserId ?? throw new global::System.ArgumentNullException(nameof(slackUserId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultRoutingTableSlackMemberLink" /> class.
        /// </summary>
        public VaultRoutingTableSlackMemberLink()
        {
        }

    }
}