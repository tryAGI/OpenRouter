
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Operator
    {
        /// <summary>
        /// Operator identifier used in filter definitions<br/>
        /// Example: eq
        /// </summary>
        /// <example>eq</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OperatorNameJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OperatorName Name { get; set; }

        /// <summary>
        /// Whether the operator expects a single value or an array
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OperatorValueTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OperatorValueType ValueType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Operator" /> class.
        /// </summary>
        /// <param name="name">
        /// Operator identifier used in filter definitions<br/>
        /// Example: eq
        /// </param>
        /// <param name="valueType">
        /// Whether the operator expects a single value or an array
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Operator(
            global::OpenRouter.OperatorName name,
            global::OpenRouter.OperatorValueType valueType)
        {
            this.Name = name;
            this.ValueType = valueType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Operator" /> class.
        /// </summary>
        public Operator()
        {
        }

    }
}