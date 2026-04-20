
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkAddWorkspaceMembersResponse
    {
        /// <summary>
        /// Number of workspace memberships created or updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AddedCount { get; set; }

        /// <summary>
        /// List of added workspace memberships
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.WorkspaceMember> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkAddWorkspaceMembersResponse" /> class.
        /// </summary>
        /// <param name="addedCount">
        /// Number of workspace memberships created or updated
        /// </param>
        /// <param name="data">
        /// List of added workspace memberships
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkAddWorkspaceMembersResponse(
            int addedCount,
            global::System.Collections.Generic.IList<global::OpenRouter.WorkspaceMember> data)
        {
            this.AddedCount = addedCount;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkAddWorkspaceMembersResponse" /> class.
        /// </summary>
        public BulkAddWorkspaceMembersResponse()
        {
        }
    }
}