
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A message routed between agents in a multi-agent session
    /// </summary>
    public sealed partial class AgentMessageItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.AgentMessageItemAgent, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.AgentMessageItemAgent, object>? Agent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.AgentMessageItemContentItems> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipient")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Recipient { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AgentMessageItemTypeJsonConverter))]
        public global::OpenRouter.AgentMessageItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMessageItem" /> class.
        /// </summary>
        /// <param name="author"></param>
        /// <param name="content"></param>
        /// <param name="recipient"></param>
        /// <param name="agent"></param>
        /// <param name="id"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentMessageItem(
            string author,
            global::System.Collections.Generic.IList<global::OpenRouter.AgentMessageItemContentItems> content,
            string recipient,
            global::OpenRouter.OneOf<global::OpenRouter.AgentMessageItemAgent, object>? agent,
            string? id,
            global::OpenRouter.AgentMessageItemType type)
        {
            this.Agent = agent;
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Id = id;
            this.Recipient = recipient ?? throw new global::System.ArgumentNullException(nameof(recipient));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMessageItem" /> class.
        /// </summary>
        public AgentMessageItem()
        {
        }

    }
}