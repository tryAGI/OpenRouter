
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InputsVariant2ItemVariant92
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ReasoningSummaryText>? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputsVariant2ItemVariant92" /> class.
        /// </summary>
        /// <param name="summary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputsVariant2ItemVariant92(
            global::System.Collections.Generic.IList<global::OpenRouter.ReasoningSummaryText>? summary)
        {
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputsVariant2ItemVariant92" /> class.
        /// </summary>
        public InputsVariant2ItemVariant92()
        {
        }

    }
}