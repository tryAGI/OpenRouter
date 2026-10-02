
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"user_ids":["user_abc123","user_def456"]}
    /// </summary>
    public sealed partial class BulkAddWorkspaceMembersRequest
    {
        /// <summary>
        /// List of user IDs to add to the workspace. Members are assigned the same role they hold in the organization.<br/>
        /// Example: [user_abc123, user_def456]
        /// </summary>
        /// <example>[user_abc123, user_def456]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> UserIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkAddWorkspaceMembersRequest" /> class.
        /// </summary>
        /// <param name="userIds">
        /// List of user IDs to add to the workspace. Members are assigned the same role they hold in the organization.<br/>
        /// Example: [user_abc123, user_def456]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkAddWorkspaceMembersRequest(
            global::System.Collections.Generic.IList<string> userIds)
        {
            this.UserIds = userIds ?? throw new global::System.ArgumentNullException(nameof(userIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkAddWorkspaceMembersRequest" /> class.
        /// </summary>
        public BulkAddWorkspaceMembersRequest()
        {
        }

    }
}