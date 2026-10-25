
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClassifierSetFilter
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
        /// Set-membership operator taking an array filter value.<br/>
        /// Example: in
        /// </summary>
        /// <example>in</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ClassifierSetFilterOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ClassifierSetFilterOperator Operator { get; set; }

        /// <summary>
        /// Array of scalar filter values.<br/>
        /// Example: [Engineering, Support]
        /// </summary>
        /// <example>[Engineering, Support]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, double?>> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierSetFilter" /> class.
        /// </summary>
        /// <param name="field">
        /// Classifier dimension name to filter on (snake_case identifier, e.g. "department", "work_type").<br/>
        /// Example: department
        /// </param>
        /// <param name="operator">
        /// Set-membership operator taking an array filter value.<br/>
        /// Example: in
        /// </param>
        /// <param name="value">
        /// Array of scalar filter values.<br/>
        /// Example: [Engineering, Support]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifierSetFilter(
            string field,
            global::OpenRouter.ClassifierSetFilterOperator @operator,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, double?>> value)
        {
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
            this.Operator = @operator;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierSetFilter" /> class.
        /// </summary>
        public ClassifierSetFilter()
        {
        }

    }
}