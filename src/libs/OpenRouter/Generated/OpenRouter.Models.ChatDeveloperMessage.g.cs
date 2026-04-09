
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Developer message
    /// </summary>
    public sealed partial class ChatDeveloperMessage
    {
        /// <summary>
        /// Developer message content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatDeveloperMessageContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ChatDeveloperMessageContent Content { get; set; }

        /// <summary>
        /// Optional name for the developer message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatDeveloperMessageRoleJsonConverter))]
        public global::OpenRouter.ChatDeveloperMessageRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatDeveloperMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// Developer message content
        /// </param>
        /// <param name="name">
        /// Optional name for the developer message
        /// </param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatDeveloperMessage(
            global::OpenRouter.ChatDeveloperMessageContent content,
            string? name,
            global::OpenRouter.ChatDeveloperMessageRole role)
        {
            this.Content = content;
            this.Name = name;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatDeveloperMessage" /> class.
        /// </summary>
        public ChatDeveloperMessage()
        {
        }
    }
}