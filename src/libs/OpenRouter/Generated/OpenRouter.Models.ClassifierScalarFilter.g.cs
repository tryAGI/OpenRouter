
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClassifierScalarFilter
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
        /// Equality operator taking a scalar filter value. Ordered comparisons are not available because classification values are strings.<br/>
        /// Example: eq
        /// </summary>
        /// <example>eq</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ClassifierScalarFilterOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ClassifierScalarFilterOperator Operator { get; set; }

        /// <summary>
        /// Scalar (string or number) filter value.<br/>
        /// Example: Engineering
        /// </summary>
        /// <example>Engineering</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<string, double?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnyOf<string, double?> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierScalarFilter" /> class.
        /// </summary>
        /// <param name="field">
        /// Classifier dimension name to filter on (snake_case identifier, e.g. "department", "work_type").<br/>
        /// Example: department
        /// </param>
        /// <param name="operator">
        /// Equality operator taking a scalar filter value. Ordered comparisons are not available because classification values are strings.<br/>
        /// Example: eq
        /// </param>
        /// <param name="value">
        /// Scalar (string or number) filter value.<br/>
        /// Example: Engineering
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifierScalarFilter(
            string field,
            global::OpenRouter.ClassifierScalarFilterOperator @operator,
            global::OpenRouter.AnyOf<string, double?> value)
        {
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
            this.Operator = @operator;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierScalarFilter" /> class.
        /// </summary>
        public ClassifierScalarFilter()
        {
        }

    }
}