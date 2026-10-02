
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// System message for setting behavior<br/>
    /// Example: {"content":"You are a helpful assistant.","name":"Assistant Config","role":"system"}
    /// </summary>
    public sealed partial class ChatSystemMessage
    {
        /// <summary>
        /// OpenRouter extension. Changes reasoning effort from this point in the conversation onward without invalidating the prompt cache for the preceding turns. Place it on a content-less system message (`content: ""`) directly before the user message it should apply to, and keep it at that position in later requests. Equivalent to the OpenAI Responses `configuration_update` input item and the Anthropic Messages per-message `output_config.effort`.<br/>
        /// Example: {"reasoning":{"effort":"low"}}
        /// </summary>
        /// <example>{"reasoning":{"effort":"low"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration_update")]
        public global::OpenRouter.ChatSystemMessageConfigurationUpdate? ConfigurationUpdate { get; set; }

        /// <summary>
        /// System message content<br/>
        /// Example: You are a helpful assistant.
        /// </summary>
        /// <example>You are a helpful assistant.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::OpenRouter.ChatContentText>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.ChatContentText>> Content { get; set; }

        /// <summary>
        /// Optional name for the system message<br/>
        /// Example: Assistant Config
        /// </summary>
        /// <example>Assistant Config</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatSystemMessageRoleJsonConverter))]
        public global::OpenRouter.ChatSystemMessageRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSystemMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// System message content<br/>
        /// Example: You are a helpful assistant.
        /// </param>
        /// <param name="configurationUpdate">
        /// OpenRouter extension. Changes reasoning effort from this point in the conversation onward without invalidating the prompt cache for the preceding turns. Place it on a content-less system message (`content: ""`) directly before the user message it should apply to, and keep it at that position in later requests. Equivalent to the OpenAI Responses `configuration_update` input item and the Anthropic Messages per-message `output_config.effort`.<br/>
        /// Example: {"reasoning":{"effort":"low"}}
        /// </param>
        /// <param name="name">
        /// Optional name for the system message<br/>
        /// Example: Assistant Config
        /// </param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatSystemMessage(
            global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.ChatContentText>> content,
            global::OpenRouter.ChatSystemMessageConfigurationUpdate? configurationUpdate,
            string? name,
            global::OpenRouter.ChatSystemMessageRole role)
        {
            this.ConfigurationUpdate = configurationUpdate;
            this.Content = content;
            this.Name = name;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSystemMessage" /> class.
        /// </summary>
        public ChatSystemMessage()
        {
        }

    }
}