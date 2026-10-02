
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchObjectResultResponseBodyVariant1ChoiceLogprobsRefusalItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        public global::System.Collections.Generic.IList<long>? Bytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprob")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Logprob { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsRefusalItemTopLogprob> TopLogprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant1ChoiceLogprobsRefusalItem" /> class.
        /// </summary>
        /// <param name="logprob"></param>
        /// <param name="token"></param>
        /// <param name="topLogprobs"></param>
        /// <param name="bytes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchObjectResultResponseBodyVariant1ChoiceLogprobsRefusalItem(
            double logprob,
            string token,
            global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceLogprobsRefusalItemTopLogprob> topLogprobs,
            global::System.Collections.Generic.IList<long>? bytes)
        {
            this.Bytes = bytes;
            this.Logprob = logprob;
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.TopLogprobs = topLogprobs ?? throw new global::System.ArgumentNullException(nameof(topLogprobs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant1ChoiceLogprobsRefusalItem" /> class.
        /// </summary>
        public BatchObjectResultResponseBodyVariant1ChoiceLogprobsRefusalItem()
        {
        }

    }
}