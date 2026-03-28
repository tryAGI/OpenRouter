
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Audio input content part. Supported audio formats vary by provider.
    /// </summary>
    public sealed partial class ChatContentAudio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatContentAudioTypeJsonConverter))]
        public global::OpenRouter.ChatContentAudioType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ChatContentAudioInputAudio InputAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentAudio" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="inputAudio"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatContentAudio(
            global::OpenRouter.ChatContentAudioInputAudio inputAudio,
            global::OpenRouter.ChatContentAudioType type)
        {
            this.InputAudio = inputAudio ?? throw new global::System.ArgumentNullException(nameof(inputAudio));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentAudio" /> class.
        /// </summary>
        public ChatContentAudio()
        {
        }
    }
}