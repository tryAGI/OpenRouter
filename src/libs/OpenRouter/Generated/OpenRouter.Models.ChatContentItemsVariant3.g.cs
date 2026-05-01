
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Audio input content part. Supported audio formats vary by provider.
    /// </summary>
    public sealed partial class ChatContentItemsVariant3
    {
        /// <summary>
        /// Discriminator value: input_audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatContentItemsVariant3TypeJsonConverter))]
        public global::OpenRouter.ChatContentItemsVariant3Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ChatContentItemsDiscriminatorMappingInputAudioInputAudio InputAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentItemsVariant3" /> class.
        /// </summary>
        /// <param name="inputAudio"></param>
        /// <param name="type">
        /// Discriminator value: input_audio
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatContentItemsVariant3(
            global::OpenRouter.ChatContentItemsDiscriminatorMappingInputAudioInputAudio inputAudio,
            global::OpenRouter.ChatContentItemsVariant3Type type)
        {
            this.Type = type;
            this.InputAudio = inputAudio ?? throw new global::System.ArgumentNullException(nameof(inputAudio));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentItemsVariant3" /> class.
        /// </summary>
        public ChatContentItemsVariant3()
        {
        }
    }
}