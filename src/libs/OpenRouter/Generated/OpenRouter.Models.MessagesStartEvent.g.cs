
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event sent at the start of a streaming message<br/>
    /// Example: {"message":{"container":null,"content":[],"id":"msg_01XFDUDYJgAACzvnptvVoYEL","model":"claude-sonnet-4-5-20250929","role":"assistant","stop_details":null,"stop_reason":null,"stop_sequence":null,"type":"message","usage":{"cache_creation":null,"cache_creation_input_tokens":null,"cache_read_input_tokens":null,"inference_geo":null,"input_tokens":12,"output_tokens":0,"output_tokens_details":null,"server_tool_use":null,"service_tier":"standard"}},"type":"message_start"}
    /// </summary>
    public sealed partial class MessagesStartEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.MessagesStartEventMessage Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesStartEventTypeJsonConverter))]
        public global::OpenRouter.MessagesStartEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesStartEvent" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesStartEvent(
            global::OpenRouter.MessagesStartEventMessage message,
            global::OpenRouter.MessagesStartEventType type)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesStartEvent" /> class.
        /// </summary>
        public MessagesStartEvent()
        {
        }

    }
}