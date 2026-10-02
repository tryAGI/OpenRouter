
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event sent when the message metadata changes (e.g., stop_reason)<br/>
    /// Example: {"delta":{"container":null,"stop_details":null,"stop_reason":"end_turn","stop_sequence":null},"type":"message_delta","usage":{"cache_creation_input_tokens":null,"cache_read_input_tokens":null,"input_tokens":null,"output_tokens":15,"output_tokens_details":null,"server_tool_use":null}}
    /// </summary>
    public sealed partial class MessagesDeltaEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.MessagesDeltaEventDelta Delta { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesDeltaEventTypeJsonConverter))]
        public global::OpenRouter.MessagesDeltaEventType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.MessagesDeltaEventUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesDeltaEvent" /> class.
        /// </summary>
        /// <param name="delta"></param>
        /// <param name="usage"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesDeltaEvent(
            global::OpenRouter.MessagesDeltaEventDelta delta,
            global::OpenRouter.MessagesDeltaEventUsage usage,
            global::OpenRouter.MessagesDeltaEventType type)
        {
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.Type = type;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesDeltaEvent" /> class.
        /// </summary>
        public MessagesDeltaEvent()
        {
        }

    }
}