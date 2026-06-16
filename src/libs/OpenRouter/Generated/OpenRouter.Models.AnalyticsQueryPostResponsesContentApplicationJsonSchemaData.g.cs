
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyticsQueryPostResponsesContentApplicationJsonSchemaData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cachedAt")]
        public double? CachedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostResponsesContentApplicationJsonSchemaDataDataItems> Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnalyticsQueryPostResponsesContentApplicationJsonSchemaDataMetadata Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryPostResponsesContentApplicationJsonSchemaData" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="metadata"></param>
        /// <param name="cachedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsQueryPostResponsesContentApplicationJsonSchemaData(
            global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostResponsesContentApplicationJsonSchemaDataDataItems> data,
            global::OpenRouter.AnalyticsQueryPostResponsesContentApplicationJsonSchemaDataMetadata metadata,
            double? cachedAt)
        {
            this.CachedAt = cachedAt;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryPostResponsesContentApplicationJsonSchemaData" /> class.
        /// </summary>
        public AnalyticsQueryPostResponsesContentApplicationJsonSchemaData()
        {
        }

    }
}