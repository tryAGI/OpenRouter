
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OutputCapacityEntryV2Variant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputCapacityEntryV2Variant1PerJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OutputCapacityEntryV2Variant1Per Per { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputCapacityEntryV2Variant1TypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OutputCapacityEntryV2Variant1Type Type { get; set; }

        /// <summary>
        /// `megapixel` prices resolution-scaled media: `cost_usd` is the rate per megapixel (1,000,000 pixels) of media area, so cost scales linearly with the pixel dimensions of the input consumed or output generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputPricingUnitV2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OutputPricingUnitV2 Unit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputCapacityEntryV2Variant1" /> class.
        /// </summary>
        /// <param name="per"></param>
        /// <param name="type"></param>
        /// <param name="unit">
        /// `megapixel` prices resolution-scaled media: `cost_usd` is the rate per megapixel (1,000,000 pixels) of media area, so cost scales linearly with the pixel dimensions of the input consumed or output generated.
        /// </param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputCapacityEntryV2Variant1(
            global::OpenRouter.OutputCapacityEntryV2Variant1Per per,
            global::OpenRouter.OutputCapacityEntryV2Variant1Type type,
            global::OpenRouter.OutputPricingUnitV2 unit,
            int value)
        {
            this.Per = per;
            this.Type = type;
            this.Unit = unit;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputCapacityEntryV2Variant1" /> class.
        /// </summary>
        public OutputCapacityEntryV2Variant1()
        {
        }

    }
}