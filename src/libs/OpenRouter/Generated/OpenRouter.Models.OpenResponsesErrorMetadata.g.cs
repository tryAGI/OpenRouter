
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// OpenRouter-specific details of a failed response, such as the alignment object of an alignment error.<br/>
    /// Example: {"alignment":{"calls":[{"call":1,"outcome":"unavailable","reason":"evaluator_error"}]}}
    /// </summary>
    public sealed partial class OpenResponsesErrorMetadata
    {
        /// <summary>
        /// Beta. The result of the alignment plugin for this request; the shape may change.<br/>
        /// Example: {"calls":[{"call":1,"outcome":"allowed","rules":[{"broken":false,"probability":0.04}]}]}
        /// </summary>
        /// <example>{"calls":[{"call":1,"outcome":"allowed","rules":[{"broken":false,"probability":0.04}]}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("alignment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AllOfJsonConverter<global::OpenRouter.Alignment, global::OpenRouter.OpenResponsesErrorMetadataAlignment>))]
        public global::OpenRouter.AllOf<global::OpenRouter.Alignment, global::OpenRouter.OpenResponsesErrorMetadataAlignment>? Alignment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenResponsesErrorMetadata" /> class.
        /// </summary>
        /// <param name="alignment">
        /// Beta. The result of the alignment plugin for this request; the shape may change.<br/>
        /// Example: {"calls":[{"call":1,"outcome":"allowed","rules":[{"broken":false,"probability":0.04}]}]}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenResponsesErrorMetadata(
            global::OpenRouter.AllOf<global::OpenRouter.Alignment, global::OpenRouter.OpenResponsesErrorMetadataAlignment>? alignment)
        {
            this.Alignment = alignment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenResponsesErrorMetadata" /> class.
        /// </summary>
        public OpenResponsesErrorMetadata()
        {
        }

    }
}