
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A function tool grouped inside a namespace tool<br/>
    /// Example: {"name":"spawn_agent","type":"function"}
    /// </summary>
    public sealed partial class NamespaceFunctionTool
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_callers")]
        public global::System.Collections.Generic.IList<global::OpenRouter.NamespaceFunctionToolAllowedCaller>? AllowedCallers { get; set; }

        /// <summary>
        /// Lets the model keep working after calling this tool instead of waiting for its output. The tool is still executed by the client; return the result in a later request as a `function_call_output` with the original `call_id`. Only honored by providers whose Responses API supports async tools; ignored elsewhere.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("async")]
        public bool? Async { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defer_loading")]
        public bool? DeferLoading { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_schema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.NamespaceFunctionToolTypeJsonConverter))]
        public global::OpenRouter.NamespaceFunctionToolType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceFunctionTool" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="allowedCallers"></param>
        /// <param name="async">
        /// Lets the model keep working after calling this tool instead of waiting for its output. The tool is still executed by the client; return the result in a later request as a `function_call_output` with the original `call_id`. Only honored by providers whose Responses API supports async tools; ignored elsewhere.<br/>
        /// Example: true
        /// </param>
        /// <param name="deferLoading"></param>
        /// <param name="description"></param>
        /// <param name="outputSchema"></param>
        /// <param name="parameters"></param>
        /// <param name="strict"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NamespaceFunctionTool(
            string name,
            global::System.Collections.Generic.IList<global::OpenRouter.NamespaceFunctionToolAllowedCaller>? allowedCallers,
            bool? async,
            bool? deferLoading,
            string? description,
            object? outputSchema,
            object? parameters,
            bool? strict,
            global::OpenRouter.NamespaceFunctionToolType type)
        {
            this.AllowedCallers = allowedCallers;
            this.Async = async;
            this.DeferLoading = deferLoading;
            this.Description = description;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OutputSchema = outputSchema;
            this.Parameters = parameters;
            this.Strict = strict;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceFunctionTool" /> class.
        /// </summary>
        public NamespaceFunctionTool()
        {
        }

    }
}