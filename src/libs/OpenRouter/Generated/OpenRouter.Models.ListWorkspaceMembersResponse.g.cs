
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
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
        /// Total number of members in the workspace
        /// </summary>
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
        /// Total number of members in the workspace
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