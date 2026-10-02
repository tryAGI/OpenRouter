
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Record of an OpenRouter server-tool invocation (e.g. openrouter:fusion), carried in reasoning_details so a prior tool call can be rehydrated into a later turn of the same conversation.<br/>
    /// Example: {"arguments":"{\u0022prompt\u0022:\u0022Compare carbon tax proposals\u0022}","result":"{\u0022status\u0022:\u0022ok\u0022,\u0022models\u0022:[\u0022openai/gpt-4o\u0022]}","tool_call_id":"call_abc123","tool_name":"openrouter:fusion","type":"reasoning.server_tool_call"}
    /// </summary>
    public sealed partial class ReasoningDetailServerToolCall
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arguments { get; set; }

        /// <summary>
        /// Example: unknown
        /// </summary>
        /// <example>unknown</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ReasoningFormatJsonConverter))]
        public global::OpenRouter.ReasoningFormat? Format { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Result { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        public string? ToolCallId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ReasoningDetailServerToolCallTypeJsonConverter))]
        public global::OpenRouter.ReasoningDetailServerToolCallType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningDetailServerToolCall" /> class.
        /// </summary>
        /// <param name="arguments"></param>
        /// <param name="result"></param>
        /// <param name="toolName"></param>
        /// <param name="format">
        /// Example: unknown
        /// </param>
        /// <param name="id"></param>
        /// <param name="index"></param>
        /// <param name="toolCallId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningDetailServerToolCall(
            string arguments,
            string result,
            string toolName,
            global::OpenRouter.ReasoningFormat? format,
            string? id,
            int? index,
            string? toolCallId,
            global::OpenRouter.ReasoningDetailServerToolCallType type)
        {
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Format = format;
            this.Id = id;
            this.Index = index;
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.ToolCallId = toolCallId;
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningDetailServerToolCall" /> class.
        /// </summary>
        public ReasoningDetailServerToolCall()
        {
        }

    }
}