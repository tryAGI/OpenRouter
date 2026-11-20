
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpeechInputModalityVariant2
    {
        /// <summary>
        /// `references` is how many audio clips a request may send. With more than one, some providers require the text to address every clip with an `@AudioN` placeholder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.SpeechInputModalityVariant2SupportedInputs SupportedInputs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SpeechInputModalityVariant2TypeJsonConverter))]
        public global::OpenRouter.SpeechInputModalityVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechInputModalityVariant2" /> class.
        /// </summary>
        /// <param name="supportedInputs">
        /// `references` is how many audio clips a request may send. With more than one, some providers require the text to address every clip with an `@AudioN` placeholder.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechInputModalityVariant2(
            global::OpenRouter.SpeechInputModalityVariant2SupportedInputs supportedInputs,
            global::OpenRouter.SpeechInputModalityVariant2Type type)
        {
            this.SupportedInputs = supportedInputs ?? throw new global::System.ArgumentNullException(nameof(supportedInputs));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechInputModalityVariant2" /> class.
        /// </summary>
        public SpeechInputModalityVariant2()
        {
        }

    }
}