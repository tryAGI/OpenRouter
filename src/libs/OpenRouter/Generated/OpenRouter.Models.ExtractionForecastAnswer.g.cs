
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExtractionForecastAnswer
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
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<double?, string>>? Guess { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mean")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<double?, string>>? Mean { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("median")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<double?, string>>? Median { get; set; }

        /// <summary>
        /// Probability that the state contains nothing for this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p_null")]
        public double? PNull { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p10")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<double?, string>>? P10 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p90")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<double?, string>>? P90 { get; set; }

        /// <summary>
        /// Set to `image` or `document` when the answer was read from an image or a PDF rather than the state text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ExtractionForecastAnswerSourceJsonConverter))]
        public global::OpenRouter.ExtractionForecastAnswerSource? Source { get; set; }

        /// <summary>
        /// Confidence in the spelling of text read from an image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spell_confidence")]
        public double? SpellConfidence { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ExtractionForecastStep>? Steps { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ExtractionForecastAnswerTypeJsonConverter))]
        public global::OpenRouter.ExtractionForecastAnswerType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<double?, string>>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionForecastAnswer" /> class.
        /// </summary>
        /// <param name="confidence"></param>
        /// <param name="guess">
        /// The most likely value even when `value` is null because `p_null` crossed the threshold.
        /// </param>
        /// <param name="mean"></param>
        /// <param name="median"></param>
        /// <param name="pNull">
        /// Probability that the state contains nothing for this field.
        /// </param>
        /// <param name="p10"></param>
        /// <param name="p90"></param>
        /// <param name="source">
        /// Set to `image` or `document` when the answer was read from an image or a PDF rather than the state text.
        /// </param>
        /// <param name="spellConfidence">
        /// Confidence in the spelling of text read from an image.
        /// </param>
        /// <param name="steps"></param>
        /// <param name="type"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractionForecastAnswer(
            double? confidence,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<double?, string>>? guess,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<double?, string>>? mean,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<double?, string>>? median,
            double? pNull,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<double?, string>>? p10,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<double?, string>>? p90,
            global::OpenRouter.ExtractionForecastAnswerSource? source,
            double? spellConfidence,
            global::System.Collections.Generic.IList<global::OpenRouter.ExtractionForecastStep>? steps,
            global::OpenRouter.ExtractionForecastAnswerType type,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<double?, string>>? value)
        {
            this.Confidence = confidence;
            this.Guess = guess;
            this.Mean = mean;
            this.Median = median;
            this.PNull = pNull;
            this.P10 = p10;
            this.P90 = p90;
            this.Source = source;
            this.SpellConfidence = spellConfidence;
            this.Steps = steps;
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionForecastAnswer" /> class.
        /// </summary>
        public ExtractionForecastAnswer()
        {
        }

    }
}