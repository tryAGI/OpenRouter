
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A timestamped transcript segment, returned when response_format is verbose_json
    /// </summary>
    public sealed partial class STTSegment
    {
        /// <summary>
        /// Average log probability of the segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_logprob")]
        public double? AvgLogprob { get; set; }

        /// <summary>
        /// Compression ratio of the segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compression_ratio")]
        public double? CompressionRatio { get; set; }

        /// <summary>
        /// Segment end time in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double End { get; set; }

        /// <summary>
        /// Segment index within the transcript
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Probability the segment contains no speech
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("no_speech_prob")]
        public double? NoSpeechProb { get; set; }

        /// <summary>
        /// Seek offset of the segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seek")]
        public int? Seek { get; set; }

        /// <summary>
        /// Segment start time in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Start { get; set; }

        /// <summary>
        /// Temperature used for the segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Transcribed text of the segment
        /// </summary>
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
        /// Segment end time in seconds
        /// </param>
        /// <param name="id">
        /// Segment index within the transcript
        /// </param>
        /// <param name="start">
        /// Segment start time in seconds
        /// </param>
        /// <param name="text">
        /// Transcribed text of the segment
        /// </param>
        /// <param name="avgLogprob">
        /// Average log probability of the segment
        /// </param>
        /// <param name="compressionRatio">
        /// Compression ratio of the segment
        /// </param>
        /// <param name="noSpeechProb">
        /// Probability the segment contains no speech
        /// </param>
        /// <param name="seek">
        /// Seek offset of the segment
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
            double? compressionRatio,
            double? noSpeechProb,
            int? seek,
            double? temperature,
            global::System.Collections.Generic.IList<int>? tokens)
        {
            this.AvgLogprob = avgLogprob;
            this.CompressionRatio = compressionRatio;
            this.End = end;
            this.Id = id;
            this.NoSpeechProb = noSpeechProb;
            this.Seek = seek;
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