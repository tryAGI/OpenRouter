
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExtractionEstimateField
    {
        /// <summary>
        /// What the field should contain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<double?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnyOf<double?, string> Max { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<double?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnyOf<double?, string> Min { get; set; }

        /// <summary>
        /// Probability of null above which `value` is null. Default 0.5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("null_threshold")]
        public double? NullThreshold { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ExtractionEstimateFieldScaleJsonConverter))]
        public global::OpenRouter.ExtractionEstimateFieldScale? Scale { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<double?, global::OpenRouter.ExtractionEstimateFieldStepVariant2?, global::OpenRouter.ExtractionEstimateFieldStepVariant3?>))]
        public global::OpenRouter.AnyOf<double?, global::OpenRouter.ExtractionEstimateFieldStepVariant2?, global::OpenRouter.ExtractionEstimateFieldStepVariant3?>? Step { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ExtractionEstimateFieldTypeJsonConverter))]
        public global::OpenRouter.ExtractionEstimateFieldType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        public string? Unit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionEstimateField" /> class.
        /// </summary>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <param name="instructions">
        /// What the field should contain.
        /// </param>
        /// <param name="nullThreshold">
        /// Probability of null above which `value` is null. Default 0.5.
        /// </param>
        /// <param name="scale"></param>
        /// <param name="step"></param>
        /// <param name="type"></param>
        /// <param name="unit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractionEstimateField(
            global::OpenRouter.AnyOf<double?, string> max,
            global::OpenRouter.AnyOf<double?, string> min,
            string? instructions,
            double? nullThreshold,
            global::OpenRouter.ExtractionEstimateFieldScale? scale,
            global::OpenRouter.AnyOf<double?, global::OpenRouter.ExtractionEstimateFieldStepVariant2?, global::OpenRouter.ExtractionEstimateFieldStepVariant3?>? step,
            global::OpenRouter.ExtractionEstimateFieldType type,
            string? unit)
        {
            this.Instructions = instructions;
            this.Max = max;
            this.Min = min;
            this.NullThreshold = nullThreshold;
            this.Scale = scale;
            this.Step = step;
            this.Type = type;
            this.Unit = unit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractionEstimateField" /> class.
        /// </summary>
        public ExtractionEstimateField()
        {
        }

    }
}