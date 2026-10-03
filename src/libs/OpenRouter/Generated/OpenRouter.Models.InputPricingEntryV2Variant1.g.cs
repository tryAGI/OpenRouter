
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InputPricingEntryV2Variant1
    {
        /// <summary>
        /// Non-negative decimal number string, e.g. "0.000008"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CostUsd { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        public global::System.Collections.Generic.IList<global::OpenRouter.PricingOverrideV2>? Overrides { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InputPricingEntryV2Variant1TypeJsonConverter))]
        public global::OpenRouter.InputPricingEntryV2Variant1Type Type { get; set; }

        /// <summary>
        /// `megapixel` prices resolution-scaled media: `cost_usd` is the rate per megapixel (1,000,000 pixels) of media area, so cost scales linearly with the pixel dimensions of the input consumed or output generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InputPricingUnitV2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.InputPricingUnitV2 Unit { get; set; }

        /// <summary>
        /// UTC weekdays the entry applies on; absent means every day
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utc_days")]
        public global::System.Collections.Generic.IList<global::OpenRouter.UtcDayV2>? UtcDays { get; set; }

        /// <summary>
        /// HHMM UTC clock time; the minute component must be 00-59
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utc_end")]
        public int? UtcEnd { get; set; }

        /// <summary>
        /// HHMM UTC clock time; the minute component must be 00-59
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("utc_start")]
        public int? UtcStart { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputPricingEntryV2Variant1" /> class.
        /// </summary>
        /// <param name="costUsd">
        /// Non-negative decimal number string, e.g. "0.000008"
        /// </param>
        /// <param name="unit">
        /// `megapixel` prices resolution-scaled media: `cost_usd` is the rate per megapixel (1,000,000 pixels) of media area, so cost scales linearly with the pixel dimensions of the input consumed or output generated.
        /// </param>
        /// <param name="overrides"></param>
        /// <param name="type"></param>
        /// <param name="utcDays">
        /// UTC weekdays the entry applies on; absent means every day
        /// </param>
        /// <param name="utcEnd">
        /// HHMM UTC clock time; the minute component must be 00-59
        /// </param>
        /// <param name="utcStart">
        /// HHMM UTC clock time; the minute component must be 00-59
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputPricingEntryV2Variant1(
            string costUsd,
            global::OpenRouter.InputPricingUnitV2 unit,
            global::System.Collections.Generic.IList<global::OpenRouter.PricingOverrideV2>? overrides,
            global::OpenRouter.InputPricingEntryV2Variant1Type type,
            global::System.Collections.Generic.IList<global::OpenRouter.UtcDayV2>? utcDays,
            int? utcEnd,
            int? utcStart)
        {
            this.CostUsd = costUsd ?? throw new global::System.ArgumentNullException(nameof(costUsd));
            this.Overrides = overrides;
            this.Type = type;
            this.Unit = unit;
            this.UtcDays = utcDays;
            this.UtcEnd = utcEnd;
            this.UtcStart = utcStart;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputPricingEntryV2Variant1" /> class.
        /// </summary>
        public InputPricingEntryV2Variant1()
        {
        }

    }
}