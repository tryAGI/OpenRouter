
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExtractionEstimateAnswer
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<double?, string>))]
        public global::OpenRouter.AnyOf<double?, string>? Guess { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mean")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<double?, string>))]
        public global::OpenRouter.AnyOf<double?, string>? Mean { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("median")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<double?, string>))]
        public global::OpenRouter.AnyOf<double?, string>? Median { get; set; }

        /// <summary>
        /// Probability mass above `max`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p_above")]
        public double? PAbove { get; set; }

        /// <summary>
        /// Probability mass below `min`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p_below")]
        public double? PBelow { get; set; }

        /// <summary>
        /// Probability that the state contains nothing for this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p_null")]
        public double? PNull { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p10")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<double?, string>))]
        public global::OpenRouter.AnyOf<double?, string>? P10 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p90")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<double?, string>))]
        public global::OpenRouter.AnyOf<double?, string>? P90 { get; set; }

        /// <summary>
        /// 99 percentiles, present when the provider is asked for quantiles.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantiles")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<double?, string>>? Quantiles { get; set; }

        /// <summary>
        /// Set to `image` or `document` when the answer was read from an image or a PDF rather than the state text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ExtractionEstimateAnswerSourceJsonConverter))]
        public global::OpenRouter.ExtractionEstimateAnswerSource? Source { get; set; }

        /// <summary>
        /// Confidence in the spelling of text read from an image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spell_confidence")]
        public double? SpellConfidence { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ExtractionEstimateAnswerTypeJsonConverter))]
        public global::OpenRouter.ExtractionEstimateAnswerType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<double?, string>))]
        public global::OpenRouter.AnyOf<double?, string>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionEstimateAnswer" /> class.
        /// </summary>
        /// <param name="confidence"></param>
        /// <param name="guess">
        /// The most likely value even when `value` is null because `p_null` crossed the threshold.
        /// </param>
        /// <param name="mean"></param>
        /// <param name="median"></param>
        /// <param name="pAbove">
        /// Probability mass above `max`.
        /// </param>
        /// <param name="pBelow">
        /// Probability mass below `min`.
        /// </param>
        /// <param name="pNull">
        /// Probability that the state contains nothing for this field.
        /// </param>
        /// <param name="p10"></param>
        /// <param name="p90"></param>
        /// <param name="quantiles">
        /// 99 percentiles, present when the provider is asked for quantiles.
        /// </param>
        /// <param name="source">
        /// Set to `image` or `document` when the answer was read from an image or a PDF rather than the state text.
        /// </param>
        /// <param name="spellConfidence">
        /// Confidence in the spelling of text read from an image.
        /// </param>
        /// <param name="type"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractionEstimateAnswer(
            double? confidence,
            global::OpenRouter.AnyOf<double?, string>? guess,
            global::OpenRouter.AnyOf<double?, string>? mean,
            global::OpenRouter.AnyOf<double?, string>? median,
            double? pAbove,
            double? pBelow,
            double? pNull,
            global::OpenRouter.AnyOf<double?, string>? p10,
            global::OpenRouter.AnyOf<double?, string>? p90,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<double?, string>>? quantiles,
            global::OpenRouter.ExtractionEstimateAnswerSource? source,
            double? spellConfidence,
            global::OpenRouter.ExtractionEstimateAnswerType type,
            global::OpenRouter.AnyOf<double?, string>? value)
        {
            this.Confidence = confidence;
            this.Guess = guess;
            this.Mean = mean;
            this.Median = median;
            this.PAbove = pAbove;
            this.PBelow = pBelow;
            this.PNull = pNull;
            this.P10 = p10;
            this.P90 = p90;
            this.Quantiles = quantiles;
            this.Source = source;
            this.SpellConfidence = spellConfidence;
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionEstimateAnswer" /> class.
        /// </summary>
        public ExtractionEstimateAnswer()
        {
        }

    }
}