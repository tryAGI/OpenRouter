
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Delta changes in streaming response<br/>
    /// Example: {"content":"Hello","role":"assistant"}
    /// </summary>
    public sealed partial class ChatStreamDelta
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AllOfJsonConverter<global::OpenRouter.ChatAudioOutput, object>))]
        public global::OpenRouter.AllOf<global::OpenRouter.ChatAudioOutput, object>? Audio { get; set; }

        /// <summary>
        /// Message content delta<br/>
        /// Example: Hello
        /// </summary>
        /// <example>Hello</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Reasoning content delta<br/>
        /// Example: I need to
        /// </summary>
        /// <example>I need to</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public string? Reasoning { get; set; }

        /// <summary>
        /// Reasoning details for extended thinking models<br/>
        /// Example: [{"text":"Let me think about this...","type":"reasoning.text"}]
        /// </summary>
        /// <example>[{"text":"Let me think about this...","type":"reasoning.text"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_details")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ReasoningDetailUnion>? ReasoningDetails { get; set; }

        /// <summary>
        /// Refusal message delta<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("refusal")]
        public string? Refusal { get; set; }

        /// <summary>
        /// The role of the message author<br/>
        /// Example: assistant
        /// </summary>
        /// <example>assistant</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatStreamDeltaRoleJsonConverter))]
        public global::OpenRouter.ChatStreamDeltaRole? Role { get; set; }

        /// <summary>
        /// Tool calls delta
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ChatStreamToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamDelta" /> class.
        /// </summary>
        /// <param name="audio"></param>
        /// <param name="content">
        /// Message content delta<br/>
        /// Example: Hello
        /// </param>
        /// <param name="reasoning">
        /// Reasoning content delta<br/>
        /// Example: I need to
        /// </param>
        /// <param name="reasoningDetails">
        /// Reasoning details for extended thinking models<br/>
        /// Example: [{"text":"Let me think about this...","type":"reasoning.text"}]
        /// </param>
        /// <param name="refusal">
        /// Refusal message delta<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="role">
        /// The role of the message author<br/>
        /// Example: assistant
        /// </param>
        /// <param name="toolCalls">
        /// Tool calls delta
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatStreamDelta(
            global::OpenRouter.AllOf<global::OpenRouter.ChatAudioOutput, object>? audio,
            string? content,
            string? reasoning,
            global::System.Collections.Generic.IList<global::OpenRouter.ReasoningDetailUnion>? reasoningDetails,
            string? refusal,
            global::OpenRouter.ChatStreamDeltaRole? role,
            global::System.Collections.Generic.IList<global::OpenRouter.ChatStreamToolCall>? toolCalls)
        {
            this.Audio = audio;
            this.Content = content;
            this.Reasoning = reasoning;
            this.ReasoningDetails = reasoningDetails;
            this.Refusal = refusal;
            this.Role = role;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamDelta" /> class.
        /// </summary>
        public ChatStreamDelta()
        {
        }

    }
}