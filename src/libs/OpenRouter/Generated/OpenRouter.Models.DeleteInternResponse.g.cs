
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeleteInternResponse
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>true</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleting")]
        public bool Deleting { get; set; } = true;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteInternResponse" /> class.
        /// </summary>
        /// <param name="deleting"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteInternResponse(
            bool deleting = true)
        {
            this.Deleting = deleting;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteInternResponse" /> class.
        /// </summary>
        public DeleteInternResponse()
        {
        }

    }
}