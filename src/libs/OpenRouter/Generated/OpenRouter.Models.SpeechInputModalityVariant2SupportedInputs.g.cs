
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// `references` is how many audio clips a request may send. With more than one, some providers require the text to address every clip with an `@AudioN` placeholder.
    /// </summary>
    public sealed partial class SpeechInputModalityVariant2SupportedInputs
    {
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
        /// Initializes a new instance of the <see cref="SpeechInputModalityVariant2SupportedInputs" /> class.
        /// </summary>
        /// <param name="references">
        /// Example: {"max":1,"min":1,"type":"integer"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechInputModalityVariant2SupportedInputs(
            global::OpenRouter.SpeechReferenceCount references)
        {
            this.References = references ?? throw new global::System.ArgumentNullException(nameof(references));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechInputModalityVariant2SupportedInputs" /> class.
        /// </summary>
        public SpeechInputModalityVariant2SupportedInputs()
        {
        }

    }
}