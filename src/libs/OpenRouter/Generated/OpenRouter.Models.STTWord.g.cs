
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A timestamped word, returned when the provider includes word-level timestamps<br/>
    /// Example: {"confidence":0.98,"end":0.4,"speaker":0,"start":0,"word":"Hello"}
    /// </summary>
    public sealed partial class STTWord
    {
        /// <summary>
        /// Zero-based audio channel index for the word, present when the provider transcribes channels separately<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        public int? Channel { get; set; }

        /// <summary>
        /// Provider confidence for the word from 0 to 1, present when the provider returns per-word confidence<br/>
        /// Example: 0.98F
        /// </summary>
        /// <example>0.98F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Word end time in seconds<br/>
        /// Example: 0.4F
        /// </summary>
        /// <example>0.4F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double End { get; set; }

        /// <summary>
        /// Speaker index for the word, present when the provider returns diarization data<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public int? Speaker { get; set; }

        /// <summary>
        /// Provider speaker label for the word, present when the provider labels speakers with a string<br/>
        /// Example: speaker_0
        /// </summary>
        /// <example>speaker_0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_label")]
        public string? SpeakerLabel { get; set; }

        /// <summary>
        /// Word start time in seconds<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Start { get; set; }

        /// <summary>
        /// Kind of entry; omitted or "word" for spoken words, "audio_event" for non-speech sounds the provider tags with timestamps<br/>
        /// Example: word
        /// </summary>
        /// <example>word</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.STTWordTypeJsonConverter))]
        public global::OpenRouter.STTWordType? Type { get; set; }

        /// <summary>
        /// The transcribed word, or the event tag such as "(laughter)" when type is audio_event<br/>
        /// Example: Hello
        /// </summary>
        /// <example>Hello</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Word { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="STTWord" /> class.
        /// </summary>
        /// <param name="end">
        /// Word end time in seconds<br/>
        /// Example: 0.4F
        /// </param>
        /// <param name="start">
        /// Word start time in seconds<br/>
        /// Example: 0
        /// </param>
        /// <param name="word">
        /// The transcribed word, or the event tag such as "(laughter)" when type is audio_event<br/>
        /// Example: Hello
        /// </param>
        /// <param name="channel">
        /// Zero-based audio channel index for the word, present when the provider transcribes channels separately<br/>
        /// Example: 0
        /// </param>
        /// <param name="confidence">
        /// Provider confidence for the word from 0 to 1, present when the provider returns per-word confidence<br/>
        /// Example: 0.98F
        /// </param>
        /// <param name="speaker">
        /// Speaker index for the word, present when the provider returns diarization data<br/>
        /// Example: 0
        /// </param>
        /// <param name="speakerLabel">
        /// Provider speaker label for the word, present when the provider labels speakers with a string<br/>
        /// Example: speaker_0
        /// </param>
        /// <param name="type">
        /// Kind of entry; omitted or "word" for spoken words, "audio_event" for non-speech sounds the provider tags with timestamps<br/>
        /// Example: word
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTWord(
            double end,
            double start,
            string word,
            int? channel,
            double? confidence,
            int? speaker,
            string? speakerLabel,
            global::OpenRouter.STTWordType? type)
        {
            this.Channel = channel;
            this.Confidence = confidence;
            this.End = end;
            this.Speaker = speaker;
            this.SpeakerLabel = speakerLabel;
            this.Start = start;
            this.Type = type;
            this.Word = word ?? throw new global::System.ArgumentNullException(nameof(word));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTWord" /> class.
        /// </summary>
        public STTWord()
        {
        }

    }
}