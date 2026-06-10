
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaTimeRange
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime End { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Start { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaTimeRange" /> class.
        /// </summary>
        /// <param name="end"></param>
        /// <param name="start"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaTimeRange(
            global::System.DateTime end,
            global::System.DateTime start)
        {
            this.End = end;
            this.Start = start;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaTimeRange" /> class.
        /// </summary>
        public AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaTimeRange()
        {
        }

    }
}