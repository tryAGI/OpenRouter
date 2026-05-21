
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Audio input content item
    /// </summary>
    public sealed partial class InputAudio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputAudioInputAudio InputAudio1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudio" /> class.
        /// </summary>
        /// <param name="inputAudio1"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputAudio(
            global::OpenRouter.OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputAudioInputAudio inputAudio1)
        {
            this.InputAudio1 = inputAudio1 ?? throw new global::System.ArgumentNullException(nameof(inputAudio1));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudio" /> class.
        /// </summary>
        public InputAudio()
        {
        }

    }
}