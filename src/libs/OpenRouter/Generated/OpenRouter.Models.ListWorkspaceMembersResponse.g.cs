
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":[{"created_at":"2025-08-24T10:30:00Z","id":"660e8400-e29b-41d4-a716-446655440000","role":"member","user_id":"user_abc123","workspace_id":"550e8400-e29b-41d4-a716-446655440000"}],"total_count":1}
    /// </summary>
    public sealed partial class ListWorkspaceMembersResponse
    {
        /// <summary>
        /// List of workspace members
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.WorkspaceMember> Data { get; set; }

        /// <summary>
        /// Total number of members in the workspace<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWorkspaceMembersResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of workspace members
        /// </param>
        /// <param name="totalCount">
        /// Total number of members in the workspace<br/>
        /// Example: 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListWorkspaceMembersResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.WorkspaceMember> data,
            int totalCount)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWorkspaceMembersResponse" /> class.
        /// </summary>
        public ListWorkspaceMembersResponse()
        {
        }

    }
}