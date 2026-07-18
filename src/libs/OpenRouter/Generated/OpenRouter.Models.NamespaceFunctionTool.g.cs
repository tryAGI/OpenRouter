
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A function tool grouped inside a namespace tool
    /// </summary>
    public sealed partial class NamespaceFunctionTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_callers")]
        public global::System.Collections.Generic.IList<global::OpenRouter.NamespaceFunctionToolAllowedCallersItems>? AllowedCallers { get; set; }

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
            global::System.Collections.Generic.IList<global::OpenRouter.NamespaceFunctionToolAllowedCallersItems>? allowedCallers,
            bool? deferLoading,
            string? description,
            object? outputSchema,
            object? parameters,
            bool? strict,
            global::OpenRouter.NamespaceFunctionToolType type)
        {
            this.AllowedCallers = allowedCallers;
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