
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An assistant message from an earlier response. When answering an interaction, echo the streamed `tool_calls` here before the `tool` message.<br/>
    /// Example: {"content":null,"role":"assistant","tool_calls":[{"function":{"arguments":"{\u0022kind\u0022:\u0022permission\u0022,\u0022operation\u0022:\u0022shell\u0022,\u0022options\u0022:[\u0022allow_once\u0022,\u0022reject_once\u0022]}","name":"openrouter.provide_input"},"id":"15e90ad6-5320-4a59-af4f-b371428154fa"}]}
    /// </summary>
    public sealed partial class InternChatAssistantMessage
    {
        /// <summary>
        /// Message text as a string or a list of text parts. Assistant history may carry null. Only the last message is read; earlier messages are accepted so ordinary clients can resend history.<br/>
        /// Example: Summarize the open pull requests.
        /// </summary>
        /// <example>Summarize the open pull requests.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InternChatMessageContentJsonConverter))]
        public global::OpenRouter.InternChatMessageContent? Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InternChatAssistantMessageRoleJsonConverter))]
        public global::OpenRouter.InternChatAssistantMessageRole Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::OpenRouter.InternChatEchoedToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatAssistantMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// Message text as a string or a list of text parts. Assistant history may carry null. Only the last message is read; earlier messages are accepted so ordinary clients can resend history.<br/>
        /// Example: Summarize the open pull requests.
        /// </param>
        /// <param name="role"></param>
        /// <param name="toolCalls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternChatAssistantMessage(
            global::OpenRouter.InternChatMessageContent? content,
            global::OpenRouter.InternChatAssistantMessageRole role,
            global::System.Collections.Generic.IList<global::OpenRouter.InternChatEchoedToolCall>? toolCalls)
        {
            this.Content = content;
            this.Role = role;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatAssistantMessage" /> class.
        /// </summary>
        public InternChatAssistantMessage()
        {
        }

    }
}