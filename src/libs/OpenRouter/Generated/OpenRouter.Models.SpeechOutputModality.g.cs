
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"supported_parameters":{"voice":{"type":"enum","values":["alloy","coral"]}},"type":"speech"}
    /// </summary>
    public sealed partial class SpeechOutputModality
    {
        /// <summary>
        /// Example: {"instructions":{"type":"unknown"},"response_format":{"type":"enum","values":["mp3","pcm"]},"speed":{"max":4,"min":0.25,"type":"range"},"voice":{"type":"enum","values":["alloy","coral"]}}
        /// </summary>
        /// <example>{"instructions":{"type":"unknown"},"response_format":{"type":"enum","values":["mp3","pcm"]},"speed":{"max":4,"min":0.25,"type":"range"},"voice":{"type":"enum","values":["alloy","coral"]}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.SpeechSupportedParameters SupportedParameters { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SpeechOutputModalityTypeJsonConverter))]
        public global::OpenRouter.SpeechOutputModalityType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechOutputModality" /> class.
        /// </summary>
        /// <param name="supportedParameters">
        /// Example: {"instructions":{"type":"unknown"},"response_format":{"type":"enum","values":["mp3","pcm"]},"speed":{"max":4,"min":0.25,"type":"range"},"voice":{"type":"enum","values":["alloy","coral"]}}
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechOutputModality(
            global::OpenRouter.SpeechSupportedParameters supportedParameters,
            global::OpenRouter.SpeechOutputModalityType type)
        {
            this.SupportedParameters = supportedParameters ?? throw new global::System.ArgumentNullException(nameof(supportedParameters));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechOutputModality" /> class.
        /// </summary>
        public SpeechOutputModality()
        {
        }

    }
}