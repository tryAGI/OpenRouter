
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkAssignMembersResponse
    {
        /// <summary>
        /// Number of members successfully assigned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assigned_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AssignedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkAssignMembersResponse" /> class.
        /// </summary>
        /// <param name="assignedCount">
        /// Number of members successfully assigned
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkAssignMembersResponse(
            int assignedCount)
        {
            this.AssignedCount = assignedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkAssignMembersResponse" /> class.
        /// </summary>
        public BulkAssignMembersResponse()
        {
        }
    }
}