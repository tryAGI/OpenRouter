
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SuspendInternResponse
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>true</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("suspended")]
        public bool Suspended { get; set; } = true;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SuspendInternResponse" /> class.
        /// </summary>
        /// <param name="suspended"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SuspendInternResponse(
            bool suspended = true)
        {
            this.Suspended = suspended;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuspendInternResponse" /> class.
        /// </summary>
        public SuspendInternResponse()
        {
        }

    }
}