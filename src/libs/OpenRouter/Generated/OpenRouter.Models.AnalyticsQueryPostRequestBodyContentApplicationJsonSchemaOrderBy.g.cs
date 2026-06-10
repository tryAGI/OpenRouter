
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderBy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirection Direction { get; set; }

        /// <summary>
        /// Field to order by
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderBy" /> class.
        /// </summary>
        /// <param name="direction"></param>
        /// <param name="field">
        /// Field to order by
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderBy(
            global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirection direction,
            string field)
        {
            this.Direction = direction;
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderBy" /> class.
        /// </summary>
        public AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderBy()
        {
        }

    }
}