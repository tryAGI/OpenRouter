
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Transcript of an `input_audio` part<br/>
    /// Example: {"text":"I used to rule the world.","type":"text"}
    /// </summary>
    public sealed partial class SpeechInputReferenceText
    {
        /// <summary>
        /// Transcript of an `input_audio` part. With a single clip it may appear before or after the clip; with multiple clips it must immediately follow the clip it transcribes.<br/>
        /// Example: I used to rule the world.
        /// </summary>
        /// <example>I used to rule the world.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SpeechInputReferenceTextTypeJsonConverter))]
        public global::OpenRouter.SpeechInputReferenceTextType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechInputReferenceText" /> class.
        /// </summary>
        /// <param name="text">
        /// Transcript of an `input_audio` part. With a single clip it may appear before or after the clip; with multiple clips it must immediately follow the clip it transcribes.<br/>
        /// Example: I used to rule the world.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechInputReferenceText(
            string text,
            global::OpenRouter.SpeechInputReferenceTextType type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechInputReferenceText" /> class.
        /// </summary>
        public SpeechInputReferenceText()
        {
        }

    }
}