
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExtractionListAnswer
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// One confidence per item of `value`, in the same order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidences")]
        public global::System.Collections.Generic.IList<double>? Confidences { get; set; }

        /// <summary>
        /// The most likely value even when `value` is null because `p_null` crossed the threshold.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guess")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, double?>>? Guess { get; set; }

        /// <summary>
        /// Probability that the state contains nothing for this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p_null")]
        public double? PNull { get; set; }

        /// <summary>
        /// Set to `image` or `document` when the answer was read from an image or a PDF rather than the state text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ExtractionListAnswerSourceJsonConverter))]
        public global::OpenRouter.ExtractionListAnswerSource? Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spans")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<long>>? Spans { get; set; }

        /// <summary>
        /// Confidence in the spelling of text read from an image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spell_confidence")]
        public double? SpellConfidence { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ExtractionListAnswerTypeJsonConverter))]
        public global::OpenRouter.ExtractionListAnswerType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, double?>>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionListAnswer" /> class.
        /// </summary>
        /// <param name="confidence"></param>
        /// <param name="confidences">
        /// One confidence per item of `value`, in the same order.
        /// </param>
        /// <param name="guess">
        /// The most likely value even when `value` is null because `p_null` crossed the threshold.
        /// </param>
        /// <param name="pNull">
        /// Probability that the state contains nothing for this field.
        /// </param>
        /// <param name="source">
        /// Set to `image` or `document` when the answer was read from an image or a PDF rather than the state text.
        /// </param>
        /// <param name="spans"></param>
        /// <param name="spellConfidence">
        /// Confidence in the spelling of text read from an image.
        /// </param>
        /// <param name="type"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractionListAnswer(
            double? confidence,
            global::System.Collections.Generic.IList<double>? confidences,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, double?>>? guess,
            double? pNull,
            global::OpenRouter.ExtractionListAnswerSource? source,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<long>>? spans,
            double? spellConfidence,
            global::OpenRouter.ExtractionListAnswerType type,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, double?>>? value)
        {
            this.Confidence = confidence;
            this.Confidences = confidences;
            this.Guess = guess;
            this.PNull = pNull;
            this.Source = source;
            this.Spans = spans;
            this.SpellConfidence = spellConfidence;
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionListAnswer" /> class.
        /// </summary>
        public ExtractionListAnswer()
        {
        }

    }
}