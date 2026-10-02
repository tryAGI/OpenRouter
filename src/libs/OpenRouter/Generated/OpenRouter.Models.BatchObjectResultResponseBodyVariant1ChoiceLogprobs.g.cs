
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchObjectResultResponseBodyVariant1ChoiceLogprobs
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsContentItem>? Content { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refusal")]
        public global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsRefusalItem>? Refusal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant1ChoiceLogprobs" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="refusal">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchObjectResultResponseBodyVariant1ChoiceLogprobs(
            global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsContentItem>? content,
            global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsRefusalItem>? refusal)
        {
            this.Content = content;
            this.Refusal = refusal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant1ChoiceLogprobs" /> class.
        /// </summary>
        public BatchObjectResultResponseBodyVariant1ChoiceLogprobs()
        {
        }

    }
}