
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExtractionDurationAnswer
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// The most likely value even when `value` is null because `p_null` crossed the threshold.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guess")]
        public double? Guess { get; set; }

        /// <summary>
        /// Probability that the state contains nothing for this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p_null")]
        public double? PNull { get; set; }

        /// <summary>
        /// Set to `image` or `document` when the answer was read from an image or a PDF rather than the state text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ExtractionDurationAnswerSourceJsonConverter))]
        public global::OpenRouter.ExtractionDurationAnswerSource? Source { get; set; }

        /// <summary>
        /// Unicode code point offsets [start, end) into the state text: index code points (not UTF-16 code units or UTF-8 bytes), so an emoji or accented letter counts once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span")]
        public global::System.Collections.Generic.IList<long>? Span { get; set; }

        /// <summary>
        /// Confidence in the spelling of text read from an image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spell_confidence")]
        public double? SpellConfidence { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ExtractionDurationAnswerTypeJsonConverter))]
        public global::OpenRouter.ExtractionDurationAnswerType Type { get; set; }

        /// <summary>
        /// The unit `value` is expressed in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        public string? Unit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionDurationAnswer" /> class.
        /// </summary>
        /// <param name="confidence"></param>
        /// <param name="guess">
        /// The most likely value even when `value` is null because `p_null` crossed the threshold.
        /// </param>
        /// <param name="pNull">
        /// Probability that the state contains nothing for this field.
        /// </param>
        /// <param name="source">
        /// Set to `image` or `document` when the answer was read from an image or a PDF rather than the state text.
        /// </param>
        /// <param name="span">
        /// Unicode code point offsets [start, end) into the state text: index code points (not UTF-16 code units or UTF-8 bytes), so an emoji or accented letter counts once.
        /// </param>
        /// <param name="spellConfidence">
        /// Confidence in the spelling of text read from an image.
        /// </param>
        /// <param name="type"></param>
        /// <param name="unit">
        /// The unit `value` is expressed in.
        /// </param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractionDurationAnswer(
            double? confidence,
            double? guess,
            double? pNull,
            global::OpenRouter.ExtractionDurationAnswerSource? source,
            global::System.Collections.Generic.IList<long>? span,
            double? spellConfidence,
            global::OpenRouter.ExtractionDurationAnswerType type,
            string? unit,
            double? value)
        {
            this.Confidence = confidence;
            this.Guess = guess;
            this.PNull = pNull;
            this.Source = source;
            this.Span = span;
            this.SpellConfidence = spellConfidence;
            this.Type = type;
            this.Unit = unit;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionDurationAnswer" /> class.
        /// </summary>
        public ExtractionDurationAnswer()
        {
        }

    }
}