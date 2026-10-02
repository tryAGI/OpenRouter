
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The MCP tool ran but reported a failure<br/>
    /// Example: {"content":"Connection refused","type":"mcp_tool_execution_error"}
    /// </summary>
    public sealed partial class McpToolExecutionError
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public object? Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.McpToolExecutionErrorTypeJsonConverter))]
        public global::OpenRouter.McpToolExecutionErrorType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpToolExecutionError" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpToolExecutionError(
            object? content,
            global::OpenRouter.McpToolExecutionErrorType type)
        {
            this.Content = content;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpToolExecutionError" /> class.
        /// </summary>
        public McpToolExecutionError()
        {
        }

    }
}