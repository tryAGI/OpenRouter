
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetAnalyticsMetaResponseData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.GetAnalyticsMetaResponseDataDimension> Dimensions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granularities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.GetAnalyticsMetaResponseDataGranularitie> Granularities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.GetAnalyticsMetaResponseDataMetric> Metrics { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operators")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.GetAnalyticsMetaResponseDataOperator> Operators { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsMetaResponseData" /> class.
        /// </summary>
        /// <param name="dimensions"></param>
        /// <param name="granularities"></param>
        /// <param name="metrics"></param>
        /// <param name="operators"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsMetaResponseData(
            global::System.Collections.Generic.IList<global::OpenRouter.GetAnalyticsMetaResponseDataDimension> dimensions,
            global::System.Collections.Generic.IList<global::OpenRouter.GetAnalyticsMetaResponseDataGranularitie> granularities,
            global::System.Collections.Generic.IList<global::OpenRouter.GetAnalyticsMetaResponseDataMetric> metrics,
            global::System.Collections.Generic.IList<global::OpenRouter.GetAnalyticsMetaResponseDataOperator> operators)
        {
            this.Dimensions = dimensions ?? throw new global::System.ArgumentNullException(nameof(dimensions));
            this.Granularities = granularities ?? throw new global::System.ArgumentNullException(nameof(granularities));
            this.Metrics = metrics ?? throw new global::System.ArgumentNullException(nameof(metrics));
            this.Operators = operators ?? throw new global::System.ArgumentNullException(nameof(operators));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsMetaResponseData" /> class.
        /// </summary>
        public GetAnalyticsMetaResponseData()
        {
        }

    }
}