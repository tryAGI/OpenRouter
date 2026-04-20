
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkRemoveWorkspaceMembersRequest
    {
        /// <summary>
        /// List of user IDs to remove from the workspace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> UserIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkRemoveWorkspaceMembersRequest" /> class.
        /// </summary>
        /// <param name="userIds">
        /// List of user IDs to remove from the workspace
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkRemoveWorkspaceMembersRequest(
            global::System.Collections.Generic.IList<string> userIds)
        {
            this.UserIds = userIds ?? throw new global::System.ArgumentNullException(nameof(userIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkRemoveWorkspaceMembersRequest" /> class.
        /// </summary>
        public BulkRemoveWorkspaceMembersRequest()
        {
        }
    }
}