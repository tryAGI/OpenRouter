
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Custom tool configuration<br/>
    /// Example: {"name":"my_tool","type":"custom"}
    /// </summary>
    public sealed partial class CustomTool
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<global::OpenRouter.CustomToolFormatVariant1, global::OpenRouter.CustomToolFormatVariant2>))]
        public global::OpenRouter.AnyOf<global::OpenRouter.CustomToolFormatVariant1, global::OpenRouter.CustomToolFormatVariant2>? Format { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CustomToolTypeJsonConverter))]
        public global::OpenRouter.CustomToolType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTool" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="async">
        /// Lets the model keep working after calling this tool instead of waiting for its output. The tool is still executed by the client; return the result in a later request as a `function_call_output` with the original `call_id`. Only honored by providers whose Responses API supports async tools; ignored elsewhere.<br/>
        /// Example: true
        /// </param>
        /// <param name="description"></param>
        /// <param name="format"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomTool(
            string name,
            bool? async,
            string? description,
            global::OpenRouter.AnyOf<global::OpenRouter.CustomToolFormatVariant1, global::OpenRouter.CustomToolFormatVariant2>? format,
            global::OpenRouter.CustomToolType type)
        {
            this.Async = async;
            this.Description = description;
            this.Format = format;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomTool" /> class.
        /// </summary>
        public CustomTool()
        {
        }

    }
}