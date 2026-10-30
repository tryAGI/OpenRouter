
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SetFilter
    {
        /// <summary>
        /// Dimension to filter on. Use the /meta endpoint for available dimensions.<br/>
        /// Example: model
        /// </summary>
        /// <example>model</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        /// Include rows where the dimension has no value. Applies only to dimensions that have an unset bucket.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_unset")]
        public bool? IncludeUnset { get; set; }

        /// <summary>
        /// Set-membership operator taking an array filter value.<br/>
        /// Example: in
        /// </summary>
        /// <example>in</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SetFilterOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.SetFilterOperator Operator { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, double?>> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetFilter" /> class.
        /// </summary>
        /// <param name="field">
        /// Dimension to filter on. Use the /meta endpoint for available dimensions.<br/>
        /// Example: model
        /// </param>
        /// <param name="operator">
        /// Set-membership operator taking an array filter value.<br/>
        /// Example: in
        /// </param>
        /// <param name="value"></param>
        /// <param name="includeUnset">
        /// Include rows where the dimension has no value. Applies only to dimensions that have an unset bucket.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetFilter(
            string field,
            global::OpenRouter.SetFilterOperator @operator,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, double?>> value,
            bool? includeUnset)
        {
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
            this.IncludeUnset = includeUnset;
            this.Operator = @operator;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetFilter" /> class.
        /// </summary>
        public SetFilter()
        {
        }

    }
}