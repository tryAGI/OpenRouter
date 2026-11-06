
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// OpenRouter built-in server tool: connects the model to a remote MCP server and runs its tools during the response<br/>
    /// Example: {"parameters":{"server_label":"huggingface","server_url":"https://huggingface.co/mcp"},"type":"openrouter:mcp"}
    /// </summary>
    public sealed partial class McpServerToolOpenRouter
    {
        /// <summary>
        /// Configuration for a remote MCP server tool.<br/>
        /// Example: {"server_label":"huggingface","server_url":"https://huggingface.co/mcp"}
        /// </summary>
        /// <example>{"server_label":"huggingface","server_url":"https://huggingface.co/mcp"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.McpServerToolParameters Parameters { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.McpServerToolOpenRouterTypeJsonConverter))]
        public global::OpenRouter.McpServerToolOpenRouterType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerToolOpenRouter" /> class.
        /// </summary>
        /// <param name="parameters">
        /// Configuration for a remote MCP server tool.<br/>
        /// Example: {"server_label":"huggingface","server_url":"https://huggingface.co/mcp"}
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpServerToolOpenRouter(
            global::OpenRouter.McpServerToolParameters parameters,
            global::OpenRouter.McpServerToolOpenRouterType type)
        {
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerToolOpenRouter" /> class.
        /// </summary>
        public McpServerToolOpenRouter()
        {
        }

    }
}