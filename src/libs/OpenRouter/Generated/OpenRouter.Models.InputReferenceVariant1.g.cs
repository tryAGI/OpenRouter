
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// audio_url variant
    /// </summary>
    public sealed partial class InputReferenceVariant1
    {
        /// <summary>
        /// Discriminator value: audio_url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InputReferenceVariant1TypeJsonConverter))]
        public global::OpenRouter.InputReferenceVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.InputReferenceDiscriminatorMappingAudioUrlAudioUrl AudioUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputReferenceVariant1" /> class.
        /// </summary>
        /// <param name="audioUrl"></param>
        /// <param name="type">
        /// Discriminator value: audio_url
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputReferenceVariant1(
            global::OpenRouter.InputReferenceDiscriminatorMappingAudioUrlAudioUrl audioUrl,
            global::OpenRouter.InputReferenceVariant1Type type)
        {
            this.Type = type;
            this.AudioUrl = audioUrl ?? throw new global::System.ArgumentNullException(nameof(audioUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputReferenceVariant1" /> class.
        /// </summary>
        public InputReferenceVariant1()
        {
        }

    }
}