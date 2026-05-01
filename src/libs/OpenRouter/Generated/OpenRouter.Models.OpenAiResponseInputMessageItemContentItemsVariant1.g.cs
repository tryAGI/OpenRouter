
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Audio input content item
    /// </summary>
    public sealed partial class OpenAiResponseInputMessageItemContentItemsVariant1
    {
        /// <summary>
        /// Discriminator value: input_audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenAiResponseInputMessageItemContentItemsVariant1TypeJsonConverter))]
        public global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputAudioInputAudio InputAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAiResponseInputMessageItemContentItemsVariant1" /> class.
        /// </summary>
        /// <param name="inputAudio"></param>
        /// <param name="type">
        /// Discriminator value: input_audio
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAiResponseInputMessageItemContentItemsVariant1(
            global::OpenRouter.OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputAudioInputAudio inputAudio,
            global::OpenRouter.OpenAiResponseInputMessageItemContentItemsVariant1Type type)
        {
            this.Type = type;
            this.InputAudio = inputAudio ?? throw new global::System.ArgumentNullException(nameof(inputAudio));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAiResponseInputMessageItemContentItemsVariant1" /> class.
        /// </summary>
        public OpenAiResponseInputMessageItemContentItemsVariant1()
        {
        }
    }
}