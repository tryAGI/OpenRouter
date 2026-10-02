
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":{"delta":{"text":"Hello","type":"text_delta"},"index":0,"type":"content_block_delta"},"event":"content_block_delta"}
    /// </summary>
    public sealed partial class MessagesStreamingResponse
    {
        /// <summary>
        /// Union of all possible streaming events<br/>
        /// Example: {"delta":{"text":"Hello","type":"text_delta"},"index":0,"type":"content_block_delta"}
        /// </summary>
        /// <example>{"delta":{"text":"Hello","type":"text_delta"},"index":0,"type":"content_block_delta"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesStreamEventsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.MessagesStreamEvents Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesStreamingResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Union of all possible streaming events<br/>
        /// Example: {"delta":{"text":"Hello","type":"text_delta"},"index":0,"type":"content_block_delta"}
        /// </param>
        /// <param name="event"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesStreamingResponse(
            global::OpenRouter.MessagesStreamEvents data,
            string @event)
        {
            this.Data = data;
            this.Event = @event ?? throw new global::System.ArgumentNullException(nameof(@event));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesStreamingResponse" /> class.
        /// </summary>
        public MessagesStreamingResponse()
        {
        }

    }
}