
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QueryAnalyticsRequestClassifierFiltersFilter
    {
        /// <summary>
        /// Classifier dimension name to filter on (snake_case identifier, e.g. "department", "work_type").<br/>
        /// Example: department
        /// </summary>
        /// <example>department</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        /// Filter operator. Only equality/set operators are supported (eq, neq, in, not_in) — ordered comparisons are not available because classification values are strings.<br/>
        /// Example: eq
        /// </summary>
        /// <example>eq</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Operator { get; set; }

        /// <summary>
        /// Filter value. Use a scalar (string or number) for eq/neq, or an array for in/not_in.<br/>
        /// Example: Engineering
        /// </summary>
        /// <example>Engineering</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<string, double?, global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, double?>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnyOf<string, double?, global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, double?>>> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAnalyticsRequestClassifierFiltersFilter" /> class.
        /// </summary>
        /// <param name="field">
        /// Classifier dimension name to filter on (snake_case identifier, e.g. "department", "work_type").<br/>
        /// Example: department
        /// </param>
        /// <param name="operator">
        /// Filter operator. Only equality/set operators are supported (eq, neq, in, not_in) — ordered comparisons are not available because classification values are strings.<br/>
        /// Example: eq
        /// </param>
        /// <param name="value">
        /// Filter value. Use a scalar (string or number) for eq/neq, or an array for in/not_in.<br/>
        /// Example: Engineering
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryAnalyticsRequestClassifierFiltersFilter(
            string field,
            string @operator,
            global::OpenRouter.AnyOf<string, double?, global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, double?>>> value)
        {
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
            this.Operator = @operator ?? throw new global::System.ArgumentNullException(nameof(@operator));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAnalyticsRequestClassifierFiltersFilter" /> class.
        /// </summary>
        public QueryAnalyticsRequestClassifierFiltersFilter()
        {
        }

    }
}