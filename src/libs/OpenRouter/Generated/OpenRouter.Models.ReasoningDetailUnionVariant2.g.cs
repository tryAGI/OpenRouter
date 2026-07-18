
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Record of an OpenRouter server-tool invocation (e.g. openrouter:fusion), carried in reasoning_details so a prior tool call can be rehydrated into a later turn of the same conversation.
    /// </summary>
    public sealed partial class ReasoningDetailUnionVariant2
    {
        /// <summary>
        /// Discriminator value: reasoning.server_tool_call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ReasoningDetailUnionVariant2TypeJsonConverter))]
        public global::OpenRouter.ReasoningDetailUnionVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arguments { get; set; }

        /// <summary>
        /// 
        /// </summary>
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningDetailUnionVariant2" /> class.
        /// </summary>
        /// <param name="arguments"></param>
        /// <param name="result"></param>
        /// <param name="toolName"></param>
        /// <param name="type">
        /// Discriminator value: reasoning.server_tool_call
        /// </param>
        /// <param name="format"></param>
        /// <param name="id"></param>
        /// <param name="index"></param>
        /// <param name="toolCallId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningDetailUnionVariant2(
            string arguments,
            string result,
            string toolName,
            global::OpenRouter.ReasoningDetailUnionVariant2Type type,
            global::OpenRouter.ReasoningFormat? format,
            string? id,
            int? index,
            string? toolCallId)
        {
            this.Type = type;
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Format = format;
            this.Id = id;
            this.Index = index;
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.ToolCallId = toolCallId;
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningDetailUnionVariant2" /> class.
        /// </summary>
        public ReasoningDetailUnionVariant2()
        {
        }

    }
}