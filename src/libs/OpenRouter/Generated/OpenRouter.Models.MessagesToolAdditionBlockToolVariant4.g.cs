
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesToolAdditionBlockToolVariant4
    {
        /// <summary>
        /// An Anthropic tool definition: a client-defined tool with a JSON Schema `input_schema`, or a server tool (bash, text editor, web search).<br/>
        /// Example: {"description":"Get the current weather for a city.","input_schema":{"properties":{"city":{"type":"string"}},"required":["city"],"type":"object"},"name":"get_weather"}
        /// </summary>
        /// <example>{"description":"Get the current weather for a city.","input_schema":{"properties":{"city":{"type":"string"}},"required":["city"],"type":"object"},"name":"get_weather"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("definition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicToolUnionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnthropicToolUnion Definition { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesToolAdditionBlockToolVariant4TypeJsonConverter))]
        public global::OpenRouter.MessagesToolAdditionBlockToolVariant4Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesToolAdditionBlockToolVariant4" /> class.
        /// </summary>
        /// <param name="definition">
        /// An Anthropic tool definition: a client-defined tool with a JSON Schema `input_schema`, or a server tool (bash, text editor, web search).<br/>
        /// Example: {"description":"Get the current weather for a city.","input_schema":{"properties":{"city":{"type":"string"}},"required":["city"],"type":"object"},"name":"get_weather"}
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesToolAdditionBlockToolVariant4(
            global::OpenRouter.AnthropicToolUnion definition,
            global::OpenRouter.MessagesToolAdditionBlockToolVariant4Type type)
        {
            this.Definition = definition;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesToolAdditionBlockToolVariant4" /> class.
        /// </summary>
        public MessagesToolAdditionBlockToolVariant4()
        {
        }

    }
}