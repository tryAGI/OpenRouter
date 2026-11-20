
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The `input` text.
    /// </summary>
    public sealed partial class SpeechInputModalityVariant1
    {
        /// <summary>
        /// `optional`: `input` may also be a multi-speaker turn array, which cannot be combined with `input_references`. `required`: `input` must be a turn array with at least two distinct voices. Absent: `input` is a string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turns")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SpeechInputModalityVariant1TurnsJsonConverter))]
        public global::OpenRouter.SpeechInputModalityVariant1Turns? Turns { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SpeechInputModalityVariant1TypeJsonConverter))]
        public global::OpenRouter.SpeechInputModalityVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechInputModalityVariant1" /> class.
        /// </summary>
        /// <param name="turns">
        /// `optional`: `input` may also be a multi-speaker turn array, which cannot be combined with `input_references`. `required`: `input` must be a turn array with at least two distinct voices. Absent: `input` is a string.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechInputModalityVariant1(
            global::OpenRouter.SpeechInputModalityVariant1Turns? turns,
            global::OpenRouter.SpeechInputModalityVariant1Type type)
        {
            this.Turns = turns;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechInputModalityVariant1" /> class.
        /// </summary>
        public SpeechInputModalityVariant1()
        {
        }

    }
}