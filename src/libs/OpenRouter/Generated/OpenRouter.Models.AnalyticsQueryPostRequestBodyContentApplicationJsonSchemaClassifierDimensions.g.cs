
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Group results by custom classifier tags, breaking down metrics by the specified dimension values. Requires an active classifier on the workspace.
    /// </summary>
    public sealed partial class AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierDimensions
    {
        /// <summary>
        /// UUID of the classifier whose tags to group by.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ClassifierId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimension_names")]
        public global::System.Collections.Generic.IList<string>? DimensionNames { get; set; }

        /// <summary>
        /// When true, also include generations that have no tag from this classifier. Defaults to false, which returns only classified generations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_nulls")]
        public bool? IncludeNulls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierDimensions" /> class.
        /// </summary>
        /// <param name="classifierId">
        /// UUID of the classifier whose tags to group by.
        /// </param>
        /// <param name="dimensionNames"></param>
        /// <param name="includeNulls">
        /// When true, also include generations that have no tag from this classifier. Defaults to false, which returns only classified generations.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierDimensions(
            global::System.Guid classifierId,
            global::System.Collections.Generic.IList<string>? dimensionNames,
            bool? includeNulls)
        {
            this.ClassifierId = classifierId;
            this.DimensionNames = dimensionNames;
            this.IncludeNulls = includeNulls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierDimensions" /> class.
        /// </summary>
        public AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierDimensions()
        {
        }

    }
}