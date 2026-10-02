
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Error event in the stream<br/>
    /// Example: {"error":{"error_type":"provider_overloaded","message":"Overloaded","type":"overloaded_error"},"type":"error"}
    /// </summary>
    public sealed partial class MessagesErrorEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.MessagesErrorEventError Error { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.MessagesErrorEventTypeJsonConverter))]
        public global::OpenRouter.MessagesErrorEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesErrorEvent" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="openrouterMetadata">
        /// Example: {"attempt":1,"endpoints":{"available":[{"model":"openai/gpt-4o","provider":"OpenAI","selected":true}],"total":1},"generation_time":2016,"is_byok":false,"region":"iad","requested":"openai/gpt-4o","strategy":"direct","summary":"available=1, selected=OpenAI"}
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesErrorEvent(
            global::OpenRouter.MessagesErrorEventError error,
            global::OpenRouter.OpenRouterMetadata? openrouterMetadata,
            global::OpenRouter.MessagesErrorEventType type)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.OpenrouterMetadata = openrouterMetadata;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesErrorEvent" /> class.
        /// </summary>
        public MessagesErrorEvent()
        {
        }

    }
}