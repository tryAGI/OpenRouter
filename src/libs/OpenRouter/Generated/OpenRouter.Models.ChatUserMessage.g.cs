
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// User message<br/>
    /// Example: {"content":"What is the capital of France?","role":"user"}
    /// </summary>
    public sealed partial class ChatUserMessage
    {
        /// <summary>
        /// User message content<br/>
        /// Example: What is the capital of France?
        /// </summary>
        /// <example>What is the capital of France?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::OpenRouter.ChatContentItems>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.ChatContentItems>> Content { get; set; }

        /// <summary>
        /// Optional name for the user<br/>
        /// Example: User
        /// </summary>
        /// <example>User</example>
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
        /// User message content<br/>
        /// Example: What is the capital of France?
        /// </param>
        /// <param name="name">
        /// Optional name for the user<br/>
        /// Example: User
        /// </param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatUserMessage(
            global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.ChatContentItems>> content,
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