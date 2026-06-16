
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyticsMetaGetResponsesContentApplicationJsonSchemaData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataDimensionsItems> Dimensions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granularities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItems> Granularities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItems> Metrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operators")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItems> Operators { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsMetaGetResponsesContentApplicationJsonSchemaData" /> class.
        /// </summary>
        /// <param name="dimensions"></param>
        /// <param name="granularities"></param>
        /// <param name="metrics"></param>
        /// <param name="operators"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsMetaGetResponsesContentApplicationJsonSchemaData(
            global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataDimensionsItems> dimensions,
            global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItems> granularities,
            global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItems> metrics,
            global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItems> operators)
        {
            this.Dimensions = dimensions ?? throw new global::System.ArgumentNullException(nameof(dimensions));
            this.Granularities = granularities ?? throw new global::System.ArgumentNullException(nameof(granularities));
            this.Metrics = metrics ?? throw new global::System.ArgumentNullException(nameof(metrics));
            this.Operators = operators ?? throw new global::System.ArgumentNullException(nameof(operators));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsMetaGetResponsesContentApplicationJsonSchemaData" /> class.
        /// </summary>
        public AnalyticsMetaGetResponsesContentApplicationJsonSchemaData()
        {
        }

    }
}