
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Developer message
    /// </summary>
    public sealed partial class ChatMessagesVariant2
    {
        /// <summary>
        /// Discriminator value: developer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatMessagesVariant2RoleJsonConverter))]
        public global::OpenRouter.ChatMessagesVariant2Role Role { get; set; }

        /// <summary>
        /// Developer message content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatMessagesDiscriminatorMappingDeveloperContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ChatMessagesDiscriminatorMappingDeveloperContent Content { get; set; }

        /// <summary>
        /// Optional name for the developer message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessagesVariant2" /> class.
        /// </summary>
        /// <param name="content">
        /// Developer message content
        /// </param>
        /// <param name="role">
        /// Discriminator value: developer
        /// </param>
        /// <param name="name">
        /// Optional name for the developer message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatMessagesVariant2(
            global::OpenRouter.ChatMessagesDiscriminatorMappingDeveloperContent content,
            global::OpenRouter.ChatMessagesVariant2Role role,
            string? name)
        {
            this.Role = role;
            this.Content = content;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessagesVariant2" /> class.
        /// </summary>
        public ChatMessagesVariant2()
        {
        }

    }
}