
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkUnassignKeysResponse
    {
        /// <summary>
        /// Number of keys successfully unassigned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unassigned_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UnassignedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUnassignKeysResponse" /> class.
        /// </summary>
        /// <param name="unassignedCount">
        /// Number of keys successfully unassigned
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkUnassignKeysResponse(
            int unassignedCount)
        {
            this.UnassignedCount = unassignedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUnassignKeysResponse" /> class.
        /// </summary>
        public BulkUnassignKeysResponse()
        {
        }
    }
}