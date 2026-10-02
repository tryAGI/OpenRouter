
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event sent when content is added to a content block<br/>
    /// Example: {"delta":{"text":"Hello","type":"text_delta"},"index":0,"type":"content_block_delta"}
    /// </summary>
    public sealed partial class MessagesContentBlockDeltaEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant1, global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant2, global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant3, global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant4, global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant5, global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant6>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OneOf<global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant1, global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant2, global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant3, global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant4, global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant5, global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant6> Delta { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesContentBlockDeltaEventTypeJsonConverter))]
        public global::OpenRouter.MessagesContentBlockDeltaEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesContentBlockDeltaEvent" /> class.
        /// </summary>
        /// <param name="delta"></param>
        /// <param name="index"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesContentBlockDeltaEvent(
            global::OpenRouter.OneOf<global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant1, global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant2, global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant3, global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant4, global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant5, global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant6> delta,
            int index,
            global::OpenRouter.MessagesContentBlockDeltaEventType type)
        {
            this.Delta = delta;
            this.Index = index;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesContentBlockDeltaEvent" /> class.
        /// </summary>
        public MessagesContentBlockDeltaEvent()
        {
        }

    }
}