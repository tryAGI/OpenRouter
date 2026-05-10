
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputAudioInputAudio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputAudioInputAudioFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputAudioInputAudioFormat Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputAudioInputAudio" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="format"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputAudioInputAudio(
            string data,
            global::OpenRouter.OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputAudioInputAudioFormat format)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputAudioInputAudio" /> class.
        /// </summary>
        public OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputAudioInputAudio()
        {
        }

    }
}