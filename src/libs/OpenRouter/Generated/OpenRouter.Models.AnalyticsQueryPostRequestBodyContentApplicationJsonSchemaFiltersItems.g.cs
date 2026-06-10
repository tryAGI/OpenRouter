
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItems
    {
        /// <summary>
        /// Dimension to filter on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        /// Filter operator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Operator { get; set; }

        /// <summary>
        /// Filter value (scalar or array depending on operator)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItems" /> class.
        /// </summary>
        /// <param name="field">
        /// Dimension to filter on
        /// </param>
        /// <param name="operator">
        /// Filter operator
        /// </param>
        /// <param name="value">
        /// Filter value (scalar or array depending on operator)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItems(
            string field,
            string @operator,
            global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue value)
        {
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
            this.Operator = @operator ?? throw new global::System.ArgumentNullException(nameof(@operator));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItems" /> class.
        /// </summary>
        public AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItems()
        {
        }

    }
}