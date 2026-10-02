
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Stop after a tool with this name has been called.<br/>
    /// Example: {"tool_name":"finalize","type":"has_tool_call"}
    /// </summary>
    public sealed partial class StopServerToolsWhenHasToolCall
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.StopServerToolsWhenHasToolCallTypeJsonConverter))]
        public global::OpenRouter.StopServerToolsWhenHasToolCallType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StopServerToolsWhenHasToolCall" /> class.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StopServerToolsWhenHasToolCall(
            string toolName,
            global::OpenRouter.StopServerToolsWhenHasToolCallType type)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StopServerToolsWhenHasToolCall" /> class.
        /// </summary>
        public StopServerToolsWhenHasToolCall()
        {
        }

    }
}