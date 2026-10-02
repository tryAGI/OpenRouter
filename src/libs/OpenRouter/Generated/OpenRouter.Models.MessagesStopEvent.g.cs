
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event sent when the message is complete<br/>
    /// Example: {"type":"message_stop"}
    /// </summary>
    public sealed partial class MessagesStopEvent
    {
        /// <summary>
        /// Example: {"attempt":1,"endpoints":{"available":[{"model":"openai/gpt-4o","provider":"OpenAI","selected":true}],"total":1},"generation_time":2016,"is_byok":false,"region":"iad","requested":"openai/gpt-4o","strategy":"direct","summary":"available=1, selected=OpenAI"}
        /// </summary>
        /// <example>{"attempt":1,"endpoints":{"available":[{"model":"openai/gpt-4o","provider":"OpenAI","selected":true}],"total":1},"generation_time":2016,"is_byok":false,"region":"iad","requested":"openai/gpt-4o","strategy":"direct","summary":"available=1, selected=OpenAI"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("openrouter_metadata")]
        public global::OpenRouter.OpenRouterMetadata? OpenrouterMetadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesStopEventTypeJsonConverter))]
        public global::OpenRouter.MessagesStopEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesStopEvent" /> class.
        /// </summary>
        /// <param name="openrouterMetadata">
        /// Example: {"attempt":1,"endpoints":{"available":[{"model":"openai/gpt-4o","provider":"OpenAI","selected":true}],"total":1},"generation_time":2016,"is_byok":false,"region":"iad","requested":"openai/gpt-4o","strategy":"direct","summary":"available=1, selected=OpenAI"}
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesStopEvent(
            global::OpenRouter.OpenRouterMetadata? openrouterMetadata,
            global::OpenRouter.MessagesStopEventType type)
        {
            this.OpenrouterMetadata = openrouterMetadata;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesStopEvent" /> class.
        /// </summary>
        public MessagesStopEvent()
        {
        }

    }
}