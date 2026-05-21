
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteObservabilityDestinationResponse
    {
        /// <summary>
        /// Always `true` on success.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteObservabilityDestinationResponse" /> class.
        /// </summary>
        /// <param name="deleted">
        /// Always `true` on success.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteObservabilityDestinationResponse(
            bool deleted)
        {
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteObservabilityDestinationResponse" /> class.
        /// </summary>
        public DeleteObservabilityDestinationResponse()
        {
        }

    }
}