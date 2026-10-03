
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RequestPricingEntryV2Variant2
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.RequestPricingEntryV2Variant2TypeJsonConverter))]
        public global::OpenRouter.RequestPricingEntryV2Variant2Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SearchUnitV2JsonConverter))]
        public global::OpenRouter.SearchUnitV2 Unit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestPricingEntryV2Variant2" /> class.
        /// </summary>
        /// <param name="costUsd">
        /// Non-negative decimal number string, e.g. "0.000008"
        /// </param>
        /// <param name="overrides"></param>
        /// <param name="type"></param>
        /// <param name="unit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestPricingEntryV2Variant2(
            string costUsd,
            global::System.Collections.Generic.IList<global::OpenRouter.PricingOverrideV2>? overrides,
            global::OpenRouter.RequestPricingEntryV2Variant2Type type,
            global::OpenRouter.SearchUnitV2 unit)
        {
            this.CostUsd = costUsd ?? throw new global::System.ArgumentNullException(nameof(costUsd));
            this.Overrides = overrides;
            this.Type = type;
            this.Unit = unit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestPricingEntryV2Variant2" /> class.
        /// </summary>
        public RequestPricingEntryV2Variant2()
        {
        }

    }
}