
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The answer to an `openrouter.provide_input` tool call. `tool_call_id` is the streamed tool call id and `session_id` must name the same session. For a permission, `content` is one of the offered option kinds (`allow_once`, `allow_always`, `reject_once`, `reject_always`) or `cancel`. For a question (elicitation), `content` is a JSON object string with `action` (`accept`, `decline` or `cancel`) and, for `accept`, `content` holding the field values. The answer is delivered to the run that asked. It never starts a new run.<br/>
    /// Example: {"content":"allow_once","role":"tool","tool_call_id":"15e90ad6-5320-4a59-af4f-b371428154fa"}
    /// </summary>
    public sealed partial class InternChatToolMessage
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InternChatToolMessageRoleJsonConverter))]
        public global::OpenRouter.InternChatToolMessageRole Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatToolMessage" /> class.
        /// </summary>
        /// <param name="toolCallId"></param>
        /// <param name="content">
        /// Message text as a string or a list of text parts. Assistant history may carry null. Only the last message is read; earlier messages are accepted so ordinary clients can resend history.<br/>
        /// Example: Summarize the open pull requests.
        /// </param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternChatToolMessage(
            string toolCallId,
            global::OpenRouter.InternChatMessageContent? content,
            global::OpenRouter.InternChatToolMessageRole role)
        {
            this.Content = content;
            this.Role = role;
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatToolMessage" /> class.
        /// </summary>
        public InternChatToolMessage()
        {
        }

    }
}