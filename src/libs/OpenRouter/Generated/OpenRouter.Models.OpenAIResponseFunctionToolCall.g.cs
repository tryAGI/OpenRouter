
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIResponseFunctionToolCall
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arguments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ToolCallStatusJsonConverter))]
        public global::OpenRouter.ToolCallStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenAiResponseFunctionToolCallTypeJsonConverter))]
        public global::OpenRouter.OpenAiResponseFunctionToolCallType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIResponseFunctionToolCall" /> class.
        /// </summary>
        /// <param name="arguments"></param>
        /// <param name="callId"></param>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIResponseFunctionToolCall(
            string arguments,
            string callId,
            string name,
            string? id,
            global::OpenRouter.ToolCallStatus? status,
            global::OpenRouter.OpenAiResponseFunctionToolCallType type)
        {
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIResponseFunctionToolCall" /> class.
        /// </summary>
        public OpenAIResponseFunctionToolCall()
        {
        }
    }
}