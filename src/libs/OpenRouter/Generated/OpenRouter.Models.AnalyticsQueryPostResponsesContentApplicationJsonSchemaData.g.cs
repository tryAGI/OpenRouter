
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
        /// Warnings about filter resolution issues (e.g. unresolvable api_key_id hashes). The query still runs normally; these inform the caller that some filter values could not be resolved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public global::System.Collections.Generic.IList<string>? Warnings { get; set; }

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
        /// <param name="warnings">
        /// Warnings about filter resolution issues (e.g. unresolvable api_key_id hashes). The query still runs normally; these inform the caller that some filter values could not be resolved.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsQueryPostResponsesContentApplicationJsonSchemaData(
            global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostResponsesContentApplicationJsonSchemaDataDataItems> data,
            global::OpenRouter.AnalyticsQueryPostResponsesContentApplicationJsonSchemaDataMetadata metadata,
            double? cachedAt,
            global::System.Collections.Generic.IList<string>? warnings)
        {
            this.CachedAt = cachedAt;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Warnings = warnings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryPostResponsesContentApplicationJsonSchemaData" /> class.
        /// </summary>
        public AnalyticsQueryPostResponsesContentApplicationJsonSchemaData()
        {
        }

    }
}