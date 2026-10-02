
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StreamEventsResponseOutputItemAddedVariant2
    {
        /// <summary>
        /// An output item from the response<br/>
        /// Example: {"content":[{"text":"Hello! How can I help you today?","type":"output_text"}],"id":"msg-abc123","role":"assistant","status":"completed","type":"message"}
        /// </summary>
        /// <example>{"content":[{"text":"Hello! How can I help you today?","type":"output_text"}],"id":"msg-abc123","role":"assistant","status":"completed","type":"message"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputItemsJsonConverter))]
        public global::OpenRouter.OutputItems? Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamEventsResponseOutputItemAddedVariant2" /> class.
        /// </summary>
        /// <param name="item">
        /// An output item from the response<br/>
        /// Example: {"content":[{"text":"Hello! How can I help you today?","type":"output_text"}],"id":"msg-abc123","role":"assistant","status":"completed","type":"message"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StreamEventsResponseOutputItemAddedVariant2(
            global::OpenRouter.OutputItems? item)
        {
            this.Item = item;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamEventsResponseOutputItemAddedVariant2" /> class.
        /// </summary>
        public StreamEventsResponseOutputItemAddedVariant2()
        {
        }

    }
}