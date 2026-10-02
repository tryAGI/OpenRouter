
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":[{"assigned_by":"user_abc123","created_at":"2025-08-24T10:30:00Z","guardrail_id":"550e8400-e29b-41d4-a716-446655440001","id":"550e8400-e29b-41d4-a716-446655440000","organization_id":"org_xyz789","user_id":"user_abc123"}],"total_count":1}
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
        /// Total number of member assignments<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
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
        /// Total number of member assignments<br/>
        /// Example: 10
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