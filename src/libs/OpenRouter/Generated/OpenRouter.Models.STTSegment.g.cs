
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A timestamped transcript segment, returned when response_format is verbose_json<br/>
    /// Example: {"avg_logprob":-0.28,"compression_ratio":1.13,"end":3.2,"id":0,"no_speech_prob":0.01,"seek":0,"speaker":0,"start":0,"temperature":0,"text":"Hello there.","tokens":[50364,2425,456]}
    /// </summary>
    public sealed partial class STTSegment
    {
        /// <summary>
        /// Average log probability of the segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_logprob")]
        public double? AvgLogprob { get; set; }

        /// <summary>
        /// Zero-based audio channel index for the segment, present when the provider transcribes channels separately<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        public int? Channel { get; set; }

        /// <summary>
        /// Compression ratio of the segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compression_ratio")]
        public double? CompressionRatio { get; set; }

        /// <summary>
        /// Segment end time in seconds<br/>
        /// Example: 3.2F
        /// </summary>
        /// <example>3.2F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double End { get; set; }

        /// <summary>
        /// Segment index within the transcript<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Probability the segment contains no speech
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("no_speech_prob")]
        public double? NoSpeechProb { get; set; }

        /// <summary>
        /// Seek offset of the segment<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("seek")]
        public int? Seek { get; set; }

        /// <summary>
        /// Speaker index for the segment, present when the provider returns diarization data<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public int? Speaker { get; set; }

        /// <summary>
        /// Provider speaker label for the segment, present when the provider labels speakers with a string<br/>
        /// Example: speaker_0
        /// </summary>
        /// <example>speaker_0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_label")]
        public string? SpeakerLabel { get; set; }

        /// <summary>
        /// Segment start time in seconds<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Start { get; set; }

        /// <summary>
        /// Temperature used for the segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Transcribed text of the segment<br/>
        /// Example: Hello there.
        /// </summary>
        /// <example>Hello there.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Token IDs of the segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        public global::System.Collections.Generic.IList<int>? Tokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="STTSegment" /> class.
        /// </summary>
        /// <param name="end">
        /// Segment end time in seconds<br/>
        /// Example: 3.2F
        /// </param>
        /// <param name="id">
        /// Segment index within the transcript<br/>
        /// Example: 0
        /// </param>
        /// <param name="start">
        /// Segment start time in seconds<br/>
        /// Example: 0
        /// </param>
        /// <param name="text">
        /// Transcribed text of the segment<br/>
        /// Example: Hello there.
        /// </param>
        /// <param name="avgLogprob">
        /// Average log probability of the segment
        /// </param>
        /// <param name="channel">
        /// Zero-based audio channel index for the segment, present when the provider transcribes channels separately<br/>
        /// Example: 0
        /// </param>
        /// <param name="compressionRatio">
        /// Compression ratio of the segment
        /// </param>
        /// <param name="noSpeechProb">
        /// Probability the segment contains no speech
        /// </param>
        /// <param name="seek">
        /// Seek offset of the segment<br/>
        /// Example: 0
        /// </param>
        /// <param name="speaker">
        /// Speaker index for the segment, present when the provider returns diarization data<br/>
        /// Example: 0
        /// </param>
        /// <param name="speakerLabel">
        /// Provider speaker label for the segment, present when the provider labels speakers with a string<br/>
        /// Example: speaker_0
        /// </param>
        /// <param name="temperature">
        /// Temperature used for the segment
        /// </param>
        /// <param name="tokens">
        /// Token IDs of the segment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTSegment(
            double end,
            int id,
            double start,
            string text,
            double? avgLogprob,
            int? channel,
            double? compressionRatio,
            double? noSpeechProb,
            int? seek,
            int? speaker,
            string? speakerLabel,
            double? temperature,
            global::System.Collections.Generic.IList<int>? tokens)
        {
            this.AvgLogprob = avgLogprob;
            this.Channel = channel;
            this.CompressionRatio = compressionRatio;
            this.End = end;
            this.Id = id;
            this.NoSpeechProb = noSpeechProb;
            this.Seek = seek;
            this.Speaker = speaker;
            this.SpeakerLabel = speakerLabel;
            this.Start = start;
            this.Temperature = temperature;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Tokens = tokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTSegment" /> class.
        /// </summary>
        public STTSegment()
        {
        }

    }
}