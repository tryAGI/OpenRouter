
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// User message
    /// </summary>
    public sealed partial class ChatUserMessage
    {
        /// <summary>
        /// User message content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatUserMessageContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ChatUserMessageContent Content { get; set; }

        /// <summary>
        /// Optional name for the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatUserMessageRoleJsonConverter))]
        public global::OpenRouter.ChatUserMessageRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatUserMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// User message content
        /// </param>
        /// <param name="name">
        /// Optional name for the user
        /// </param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatUserMessage(
            global::OpenRouter.ChatUserMessageContent content,
            string? name,
            global::OpenRouter.ChatUserMessageRole role)
        {
            this.Content = content;
            this.Name = name;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatUserMessage" /> class.
        /// </summary>
        public ChatUserMessage()
        {
        }
    }
}