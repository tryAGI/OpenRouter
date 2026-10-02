
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Tool response message<br/>
    /// Example: {"content":"The weather in San Francisco is 72\u00B0F and sunny.","role":"tool","tool_call_id":"call_abc123"}
    /// </summary>
    public sealed partial class ChatToolMessage
    {
        /// <summary>
        /// Tool response content<br/>
        /// Example: The weather in San Francisco is 72°F and sunny.
        /// </summary>
        /// <example>The weather in San Francisco is 72°F and sunny.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::OpenRouter.ChatContentItems>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.ChatContentItems>> Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatToolMessageRoleJsonConverter))]
        public global::OpenRouter.ChatToolMessageRole Role { get; set; }

        /// <summary>
        /// ID of the assistant message tool call this message responds to<br/>
        /// Example: call_abc123
        /// </summary>
        /// <example>call_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// Tool response content<br/>
        /// Example: The weather in San Francisco is 72°F and sunny.
        /// </param>
        /// <param name="toolCallId">
        /// ID of the assistant message tool call this message responds to<br/>
        /// Example: call_abc123
        /// </param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatToolMessage(
            global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.ChatContentItems>> content,
            string toolCallId,
            global::OpenRouter.ChatToolMessageRole role)
        {
            this.Content = content;
            this.Role = role;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolMessage" /> class.
        /// </summary>
        public ChatToolMessage()
        {
        }

    }
}