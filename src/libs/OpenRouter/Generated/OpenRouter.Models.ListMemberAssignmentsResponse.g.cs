
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListMemberAssignmentsResponse
    {
        /// <summary>
        /// List of member assignments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.MemberAssignment> Data { get; set; }

        /// <summary>
        /// Total number of member assignments
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
        /// Initializes a new instance of the <see cref="ListMemberAssignmentsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of member assignments
        /// </param>
        /// <param name="totalCount">
        /// Total number of member assignments
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListMemberAssignmentsResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.MemberAssignment> data,
            int totalCount)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMemberAssignmentsResponse" /> class.
        /// </summary>
        public ListMemberAssignmentsResponse()
        {
        }
    }
}