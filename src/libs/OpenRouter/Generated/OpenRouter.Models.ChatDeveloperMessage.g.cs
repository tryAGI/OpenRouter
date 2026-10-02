
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Developer message<br/>
    /// Example: {"content":"This is a message from the developer.","role":"developer"}
    /// </summary>
    public sealed partial class ChatDeveloperMessage
    {
        /// <summary>
        /// OpenRouter extension. Same as the system message `configuration_update`: changes reasoning effort from this point in the conversation onward without invalidating the prompt cache for the preceding turns.<br/>
        /// Example: {"reasoning":{"effort":"low"}}
        /// </summary>
        /// <example>{"reasoning":{"effort":"low"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration_update")]
        public global::OpenRouter.ChatDeveloperMessageConfigurationUpdate? ConfigurationUpdate { get; set; }

        /// <summary>
        /// Developer message content<br/>
        /// Example: This is a message from the developer.
        /// </summary>
        /// <example>This is a message from the developer.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::OpenRouter.ChatContentText>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.ChatContentText>> Content { get; set; }

        /// <summary>
        /// Optional name for the developer message<br/>
        /// Example: Developer
        /// </summary>
        /// <example>Developer</example>
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
        /// Developer message content<br/>
        /// Example: This is a message from the developer.
        /// </param>
        /// <param name="configurationUpdate">
        /// OpenRouter extension. Same as the system message `configuration_update`: changes reasoning effort from this point in the conversation onward without invalidating the prompt cache for the preceding turns.<br/>
        /// Example: {"reasoning":{"effort":"low"}}
        /// </param>
        /// <param name="name">
        /// Optional name for the developer message<br/>
        /// Example: Developer
        /// </param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatDeveloperMessage(
            global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.ChatContentText>> content,
            global::OpenRouter.ChatDeveloperMessageConfigurationUpdate? configurationUpdate,
            string? name,
            global::OpenRouter.ChatDeveloperMessageRole role)
        {
            this.ConfigurationUpdate = configurationUpdate;
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