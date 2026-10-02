
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Beta. The result of the alignment plugin for this request; the shape may change.<br/>
    /// Example: {"calls":[{"call":1,"outcome":"allowed","rules":[{"broken":false,"probability":0.04}]}]}
    /// </summary>
    public sealed partial class Alignment
    {
        /// <summary>
        /// One record per evaluated assistant message of the request, in the order the messages were produced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.AlignmentCallRecord> Calls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Alignment" /> class.
        /// </summary>
        /// <param name="calls">
        /// One record per evaluated assistant message of the request, in the order the messages were produced.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Alignment(
            global::System.Collections.Generic.IList<global::OpenRouter.AlignmentCallRecord> calls)
        {
            this.Calls = calls ?? throw new global::System.ArgumentNullException(nameof(calls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Alignment" /> class.
        /// </summary>
        public Alignment()
        {
        }

    }
}