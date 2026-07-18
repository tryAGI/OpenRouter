
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItems
    {
        /// <summary>
        /// Classifier dimension name to filter on (snake_case identifier, e.g. "department", "work_type").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        /// Filter operator. Only equality/set operators are supported (eq, neq, in, not_in) — ordered comparisons are not available because classification values are strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Operator { get; set; }

        /// <summary>
        /// Filter value. Use a scalar (string or number) for eq/neq, or an array for in/not_in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItems" /> class.
        /// </summary>
        /// <param name="field">
        /// Classifier dimension name to filter on (snake_case identifier, e.g. "department", "work_type").
        /// </param>
        /// <param name="operator">
        /// Filter operator. Only equality/set operators are supported (eq, neq, in, not_in) — ordered comparisons are not available because classification values are strings.
        /// </param>
        /// <param name="value">
        /// Filter value. Use a scalar (string or number) for eq/neq, or an array for in/not_in.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItems(
            string field,
            string @operator,
            global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue value)
        {
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
            this.Operator = @operator ?? throw new global::System.ArgumentNullException(nameof(@operator));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItems" /> class.
        /// </summary>
        public AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItems()
        {
        }

    }
}