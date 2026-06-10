
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItems
    {
        /// <summary>
        /// Operator identifier used in filter definitions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName Name { get; set; }

        /// <summary>
        /// Whether the operator expects a single value or an array
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsValueTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsValueType ValueType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItems" /> class.
        /// </summary>
        /// <param name="name">
        /// Operator identifier used in filter definitions
        /// </param>
        /// <param name="valueType">
        /// Whether the operator expects a single value or an array
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItems(
            global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName name,
            global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsValueType valueType)
        {
            this.Name = name;
            this.ValueType = valueType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItems" /> class.
        /// </summary>
        public AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItems()
        {
        }

    }
}