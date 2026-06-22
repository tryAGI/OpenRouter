
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// One billable pricing line for an image provider.
    /// </summary>
    public sealed partial class ImagePricingEntry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billable")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ImagePricingEntryBillableJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ImagePricingEntryBillable Billable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CostUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ImagePricingEntryUnitJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ImagePricingEntryUnit Unit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variant")]
        public string? Variant { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagePricingEntry" /> class.
        /// </summary>
        /// <param name="billable"></param>
        /// <param name="costUsd"></param>
        /// <param name="unit"></param>
        /// <param name="variant"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImagePricingEntry(
            global::OpenRouter.ImagePricingEntryBillable billable,
            double costUsd,
            global::OpenRouter.ImagePricingEntryUnit unit,
            string? variant)
        {
            this.Billable = billable;
            this.CostUsd = costUsd;
            this.Unit = unit;
            this.Variant = variant;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImagePricingEntry" /> class.
        /// </summary>
        public ImagePricingEntry()
        {
        }

    }
}