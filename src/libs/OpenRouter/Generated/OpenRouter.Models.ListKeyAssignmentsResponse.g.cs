
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":[{"assigned_by":"user_abc123","created_at":"2025-08-24T10:30:00Z","guardrail_id":"550e8400-e29b-41d4-a716-446655440001","id":"550e8400-e29b-41d4-a716-446655440000","key_hash":"c56454edb818d6b14bc0d61c46025f1450b0f4012d12304ab40aacb519fcbc93","key_label":"prod-key","key_name":"Production Key"}],"total_count":1}
    /// </summary>
    public sealed partial class ListKeyAssignmentsResponse
    {
        /// <summary>
        /// List of key assignments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.KeyAssignment> Data { get; set; }

        /// <summary>
        /// Total number of key assignments for this guardrail<br/>
        /// Example: 25
        /// </summary>
        /// <example>25</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListKeyAssignmentsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of key assignments
        /// </param>
        /// <param name="totalCount">
        /// Total number of key assignments for this guardrail<br/>
        /// Example: 25
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListKeyAssignmentsResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.KeyAssignment> data,
            int totalCount)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListKeyAssignmentsResponse" /> class.
        /// </summary>
        public ListKeyAssignmentsResponse()
        {
        }

    }
}