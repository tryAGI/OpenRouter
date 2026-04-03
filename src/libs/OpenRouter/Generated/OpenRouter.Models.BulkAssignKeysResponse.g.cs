
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkAssignKeysResponse
    {
        /// <summary>
        /// Number of keys successfully assigned
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
        /// Initializes a new instance of the <see cref="BulkAssignKeysResponse" /> class.
        /// </summary>
        /// <param name="assignedCount">
        /// Number of keys successfully assigned
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkAssignKeysResponse(
            int assignedCount)
        {
            this.AssignedCount = assignedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkAssignKeysResponse" /> class.
        /// </summary>
        public BulkAssignKeysResponse()
        {
        }
    }
}