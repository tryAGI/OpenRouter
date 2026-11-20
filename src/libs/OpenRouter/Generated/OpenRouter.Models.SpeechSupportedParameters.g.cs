
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"instructions":{"type":"unknown"},"response_format":{"type":"enum","values":["mp3","pcm"]},"speed":{"max":4,"min":0.25,"type":"range"},"voice":{"type":"enum","values":["alloy","coral"]}}
    /// </summary>
    public sealed partial class SpeechSupportedParameters
    {
        /// <summary>
        /// Example: {"type":"unknown"}
        /// </summary>
        /// <example>{"type":"unknown"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public global::OpenRouter.SpeechUnknownParameter? Instructions { get; set; }

        /// <summary>
        /// Example: {"type":"enum","values":["alloy","coral"]}
        /// </summary>
        /// <example>{"type":"enum","values":["alloy","coral"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::OpenRouter.SpeechEnumParameter? ResponseFormat { get; set; }

        /// <summary>
        /// The accepted `speed` range. Absent: the provider documents no range; some providers still forward `speed`.<br/>
        /// Example: {"max":4,"min":0.25,"type":"range"}
        /// </summary>
        /// <example>{"max":4,"min":0.25,"type":"range"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public global::OpenRouter.SpeechRangeParameter? Speed { get; set; }

        /// <summary>
        /// `enum` lists the documented voices in `values`; some providers also accept voice IDs not listed there (custom or cloned voices). `unknown` means the field is accepted but no voices are listed.<br/>
        /// Example: {"type":"enum","values":["alloy","coral"]}
        /// </summary>
        /// <example>{"type":"enum","values":["alloy","coral"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public global::OpenRouter.SpeechVoiceParameter? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechSupportedParameters" /> class.
        /// </summary>
        /// <param name="instructions">
        /// Example: {"type":"unknown"}
        /// </param>
        /// <param name="responseFormat">
        /// Example: {"type":"enum","values":["alloy","coral"]}
        /// </param>
        /// <param name="speed">
        /// The accepted `speed` range. Absent: the provider documents no range; some providers still forward `speed`.<br/>
        /// Example: {"max":4,"min":0.25,"type":"range"}
        /// </param>
        /// <param name="voice">
        /// `enum` lists the documented voices in `values`; some providers also accept voice IDs not listed there (custom or cloned voices). `unknown` means the field is accepted but no voices are listed.<br/>
        /// Example: {"type":"enum","values":["alloy","coral"]}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechSupportedParameters(
            global::OpenRouter.SpeechUnknownParameter? instructions,
            global::OpenRouter.SpeechEnumParameter? responseFormat,
            global::OpenRouter.SpeechRangeParameter? speed,
            global::OpenRouter.SpeechVoiceParameter? voice)
        {
            this.Instructions = instructions;
            this.ResponseFormat = responseFormat;
            this.Speed = speed;
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechSupportedParameters" /> class.
        /// </summary>
        public SpeechSupportedParameters()
        {
        }

    }
}