
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExtractionForecastStep
    {
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
        /// Initializes a new instance of the <see cref="ExtractionForecastStep" /> class.
        /// </summary>
        /// <param name="mean"></param>
        /// <param name="median"></param>
        /// <param name="pAbove">
        /// Probability mass above `max`.
        /// </param>
        /// <param name="pBelow">
        /// Probability mass below `min`.
        /// </param>
        /// <param name="p10"></param>
        /// <param name="p90"></param>
        /// <param name="quantiles">
        /// 99 percentiles, present when the provider is asked for quantiles.
        /// </param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractionForecastStep(
            global::OpenRouter.AnyOf<double?, string>? mean,
            global::OpenRouter.AnyOf<double?, string>? median,
            double? pAbove,
            double? pBelow,
            global::OpenRouter.AnyOf<double?, string>? p10,
            global::OpenRouter.AnyOf<double?, string>? p90,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<double?, string>>? quantiles,
            global::OpenRouter.AnyOf<double?, string>? value)
        {
            this.Mean = mean;
            this.Median = median;
            this.PAbove = pAbove;
            this.PBelow = pBelow;
            this.P10 = p10;
            this.P90 = p90;
            this.Quantiles = quantiles;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionForecastStep" /> class.
        /// </summary>
        public ExtractionForecastStep()
        {
        }

    }
}