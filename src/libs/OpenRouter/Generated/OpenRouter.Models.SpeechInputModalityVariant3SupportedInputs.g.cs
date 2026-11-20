
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpeechInputModalityVariant3SupportedInputs
    {
        /// <summary>
        /// `required`: an image reference is accepted only together with an audio reference. `excluded`: only without one. Absent: either.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SpeechInputModalityVariant3SupportedInputsAudioJsonConverter))]
        public global::OpenRouter.SpeechInputModalityVariant3SupportedInputsAudio? Audio { get; set; }

        /// <summary>
        /// Example: {"max":1,"min":1,"type":"integer"}
        /// </summary>
        /// <example>{"max":1,"min":1,"type":"integer"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.SpeechReferenceCount References { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechInputModalityVariant3SupportedInputs" /> class.
        /// </summary>
        /// <param name="references">
        /// Example: {"max":1,"min":1,"type":"integer"}
        /// </param>
        /// <param name="audio">
        /// `required`: an image reference is accepted only together with an audio reference. `excluded`: only without one. Absent: either.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechInputModalityVariant3SupportedInputs(
            global::OpenRouter.SpeechReferenceCount references,
            global::OpenRouter.SpeechInputModalityVariant3SupportedInputsAudio? audio)
        {
            this.Audio = audio;
            this.References = references ?? throw new global::System.ArgumentNullException(nameof(references));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechInputModalityVariant3SupportedInputs" /> class.
        /// </summary>
        public SpeechInputModalityVariant3SupportedInputs()
        {
        }

    }
}