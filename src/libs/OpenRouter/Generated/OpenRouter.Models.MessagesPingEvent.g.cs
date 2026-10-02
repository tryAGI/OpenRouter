
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Keep-alive ping event<br/>
    /// Example: {"type":"ping"}
    /// </summary>
    public sealed partial class MessagesPingEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesPingEventTypeJsonConverter))]
        public global::OpenRouter.MessagesPingEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesPingEvent" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesPingEvent(
            global::OpenRouter.MessagesPingEventType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesPingEvent" /> class.
        /// </summary>
        public MessagesPingEvent()
        {
        }

    }
}