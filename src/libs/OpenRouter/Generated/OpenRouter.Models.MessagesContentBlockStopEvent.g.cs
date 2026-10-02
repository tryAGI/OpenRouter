
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event sent when a content block is complete<br/>
    /// Example: {"index":0,"type":"content_block_stop"}
    /// </summary>
    public sealed partial class MessagesContentBlockStopEvent
    {
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesContentBlockStopEventTypeJsonConverter))]
        public global::OpenRouter.MessagesContentBlockStopEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesContentBlockStopEvent" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesContentBlockStopEvent(
            int index,
            global::OpenRouter.MessagesContentBlockStopEventType type)
        {
            this.Index = index;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesContentBlockStopEvent" /> class.
        /// </summary>
        public MessagesContentBlockStopEvent()
        {
        }

    }
}