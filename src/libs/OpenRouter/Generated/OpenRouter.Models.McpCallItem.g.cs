
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An MCP tool call with its output or error<br/>
    /// Example: {"arguments":"{\u0022query\u0022:\u0022SELECT * FROM users\u0022}","id":"mcp-call-abc123","name":"query_database","output":"[{\u0022id\u0022:1,\u0022name\u0022:\u0022Alice\u0022}]","server_label":"database-server","type":"mcp_call"}
    /// </summary>
    public sealed partial class McpCallItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arguments { get; set; }

        /// <summary>
        /// Error from an MCP tool call, either a plain message or a structured error<br/>
        /// Example: {"code":503,"message":"Service Unavailable","type":"http_error"}
        /// </summary>
        /// <example>{"code":503,"message":"Service Unavailable","type":"http_error"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.McpToolCallErrorJsonConverter))]
        public global::OpenRouter.McpToolCallError? Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public string? Output { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerLabel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.McpCallItemTypeJsonConverter))]
        public global::OpenRouter.McpCallItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpCallItem" /> class.
        /// </summary>
        /// <param name="arguments"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="serverLabel"></param>
        /// <param name="error">
        /// Error from an MCP tool call, either a plain message or a structured error<br/>
        /// Example: {"code":503,"message":"Service Unavailable","type":"http_error"}
        /// </param>
        /// <param name="output"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpCallItem(
            string arguments,
            string id,
            string name,
            string serverLabel,
            global::OpenRouter.McpToolCallError? error,
            string? output,
            global::OpenRouter.McpCallItemType type)
        {
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Error = error;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Output = output;
            this.ServerLabel = serverLabel ?? throw new global::System.ArgumentNullException(nameof(serverLabel));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpCallItem" /> class.
        /// </summary>
        public McpCallItem()
        {
        }

    }
}