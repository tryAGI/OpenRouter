
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Filter results to generations with specific classifier tag values. Can be combined with classifier_dimensions (must use the same classifier_id) or used independently with standard dimensions.
    /// </summary>
    public sealed partial class QueryAnalyticsRequestClassifierFilters
    {
        /// <summary>
        /// UUID of the classifier whose tags to filter by. Must match classifier_dimensions.classifier_id when both are specified.<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ClassifierId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.QueryAnalyticsRequestClassifierFiltersFilter> Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAnalyticsRequestClassifierFilters" /> class.
        /// </summary>
        /// <param name="classifierId">
        /// UUID of the classifier whose tags to filter by. Must match classifier_dimensions.classifier_id when both are specified.<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="filters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryAnalyticsRequestClassifierFilters(
            global::System.Guid classifierId,
            global::System.Collections.Generic.IList<global::OpenRouter.QueryAnalyticsRequestClassifierFiltersFilter> filters)
        {
            this.ClassifierId = classifierId;
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAnalyticsRequestClassifierFilters" /> class.
        /// </summary>
        public QueryAnalyticsRequestClassifierFilters()
        {
        }

    }
}