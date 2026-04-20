
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkRemoveWorkspaceMembersResponse
    {
        /// <summary>
        /// Number of members removed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removed_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RemovedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkRemoveWorkspaceMembersResponse" /> class.
        /// </summary>
        /// <param name="removedCount">
        /// Number of members removed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkRemoveWorkspaceMembersResponse(
            int removedCount)
        {
            this.RemovedCount = removedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkRemoveWorkspaceMembersResponse" /> class.
        /// </summary>
        public BulkRemoveWorkspaceMembersResponse()
        {
        }
    }
}