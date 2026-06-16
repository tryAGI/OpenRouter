
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItems
    {
        /// <summary>
        /// How this metric value should be formatted for display (e.g. percent → multiply by 100 and append %, currency → prefix with $)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItemsDisplayFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItemsDisplayFormat DisplayFormat { get; set; }

        /// <summary>
        /// Human-readable label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayLabel { get; set; }

        /// <summary>
        /// Whether this metric is a rate/ratio (averaged, not summed)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsRate { get; set; }

        /// <summary>
        /// Metric identifier used in query requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItems" /> class.
        /// </summary>
        /// <param name="displayFormat">
        /// How this metric value should be formatted for display (e.g. percent → multiply by 100 and append %, currency → prefix with $)
        /// </param>
        /// <param name="displayLabel">
        /// Human-readable label
        /// </param>
        /// <param name="isRate">
        /// Whether this metric is a rate/ratio (averaged, not summed)
        /// </param>
        /// <param name="name">
        /// Metric identifier used in query requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItems(
            global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItemsDisplayFormat displayFormat,
            string displayLabel,
            bool isRate,
            string name)
        {
            this.DisplayFormat = displayFormat;
            this.DisplayLabel = displayLabel ?? throw new global::System.ArgumentNullException(nameof(displayLabel));
            this.IsRate = isRate;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItems" /> class.
        /// </summary>
        public AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItems()
        {
        }

    }
}