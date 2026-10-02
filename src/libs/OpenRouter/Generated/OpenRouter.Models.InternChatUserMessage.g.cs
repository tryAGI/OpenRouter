
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A user message. When it is the last message its text is the prompt for a new run, at most 32000 characters.<br/>
    /// Example: {"content":"Summarize the open pull requests.","role":"user"}
    /// </summary>
    public sealed partial class InternChatUserMessage
    {
        /// <summary>
        /// Message text as a string or a list of text parts. Assistant history may carry null. Only the last message is read; earlier messages are accepted so ordinary clients can resend history.<br/>
        /// Example: Summarize the open pull requests.
        /// </summary>
        /// <example>Summarize the open pull requests.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InternChatMessageContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.InternChatMessageContent Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InternChatUserMessageRoleJsonConverter))]
        public global::OpenRouter.InternChatUserMessageRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatUserMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// Message text as a string or a list of text parts. Assistant history may carry null. Only the last message is read; earlier messages are accepted so ordinary clients can resend history.<br/>
        /// Example: Summarize the open pull requests.
        /// </param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternChatUserMessage(
            global::OpenRouter.InternChatMessageContent content,
            global::OpenRouter.InternChatUserMessageRole role)
        {
            this.Content = content;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatUserMessage" /> class.
        /// </summary>
        public InternChatUserMessage()
        {
        }

    }
}