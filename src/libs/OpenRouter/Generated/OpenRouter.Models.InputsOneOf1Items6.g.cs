
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An output item containing reasoning
    /// </summary>
    public sealed partial class InputsOneOf1Items6
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ReasoningTextContent>? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ReasoningFormatJsonConverter))]
        public global::OpenRouter.ReasoningFormat? Format { get; set; }

        /// <summary>
        /// A signature for the reasoning content, used for verification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string? Signature { get; set; }

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
        /// Initializes a new instance of the <see cref="InputsOneOf1Items6" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="format"></param>
        /// <param name="signature">
        /// A signature for the reasoning content, used for verification
        /// </param>
        /// <param name="summary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputsOneOf1Items6(
            global::System.Collections.Generic.IList<global::OpenRouter.ReasoningTextContent>? content,
            global::OpenRouter.ReasoningFormat? format,
            string? signature,
            global::System.Collections.Generic.IList<global::OpenRouter.ReasoningSummaryText>? summary)
        {
            this.Content = content;
            this.Format = format;
            this.Signature = signature;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputsOneOf1Items6" /> class.
        /// </summary>
        public InputsOneOf1Items6()
        {
        }
    }
}