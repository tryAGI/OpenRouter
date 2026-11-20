
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpeechInputModalityVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.SpeechInputModalityVariant3SupportedInputs SupportedInputs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SpeechInputModalityVariant3TypeJsonConverter))]
        public global::OpenRouter.SpeechInputModalityVariant3Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechInputModalityVariant3" /> class.
        /// </summary>
        /// <param name="supportedInputs"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechInputModalityVariant3(
            global::OpenRouter.SpeechInputModalityVariant3SupportedInputs supportedInputs,
            global::OpenRouter.SpeechInputModalityVariant3Type type)
        {
            this.SupportedInputs = supportedInputs ?? throw new global::System.ArgumentNullException(nameof(supportedInputs));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechInputModalityVariant3" /> class.
        /// </summary>
        public SpeechInputModalityVariant3()
        {
        }

    }
}