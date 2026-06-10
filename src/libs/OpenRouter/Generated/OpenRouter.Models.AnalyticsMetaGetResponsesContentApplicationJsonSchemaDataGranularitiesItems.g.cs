
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItems
    {
        /// <summary>
        /// Human-readable label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayLabel { get; set; }

        /// <summary>
        /// Granularity identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItemsNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItemsName Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItems" /> class.
        /// </summary>
        /// <param name="displayLabel">
        /// Human-readable label
        /// </param>
        /// <param name="name">
        /// Granularity identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItems(
            string displayLabel,
            global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItemsName name)
        {
            this.DisplayLabel = displayLabel ?? throw new global::System.ArgumentNullException(nameof(displayLabel));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItems" /> class.
        /// </summary>
        public AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItems()
        {
        }

    }
}