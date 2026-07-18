
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// STT response containing transcribed text and optional usage statistics
    /// </summary>
    public sealed partial class STTResponse
    {
        /// <summary>
        /// Duration of the input audio in seconds, present when response_format is verbose_json
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Detected or forced language, present when response_format is verbose_json
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Timestamped transcript segments, present when response_format is verbose_json
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        public global::System.Collections.Generic.IList<global::OpenRouter.STTSegment>? Segments { get; set; }

        /// <summary>
        /// The task performed, present when response_format is verbose_json
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        public string? Task { get; set; }

        /// <summary>
        /// The transcribed text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Aggregated usage statistics for the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::OpenRouter.STTUsage? Usage { get; set; }

        /// <summary>
        /// Timestamped words, present when the provider returns word-level timestamps
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::OpenRouter.STTWord>? Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="STTResponse" /> class.
        /// </summary>
        /// <param name="text">
        /// The transcribed text
        /// </param>
        /// <param name="duration">
        /// Duration of the input audio in seconds, present when response_format is verbose_json
        /// </param>
        /// <param name="language">
        /// Detected or forced language, present when response_format is verbose_json
        /// </param>
        /// <param name="segments">
        /// Timestamped transcript segments, present when response_format is verbose_json
        /// </param>
        /// <param name="task">
        /// The task performed, present when response_format is verbose_json
        /// </param>
        /// <param name="usage">
        /// Aggregated usage statistics for the request
        /// </param>
        /// <param name="words">
        /// Timestamped words, present when the provider returns word-level timestamps
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTResponse(
            string text,
            double? duration,
            string? language,
            global::System.Collections.Generic.IList<global::OpenRouter.STTSegment>? segments,
            string? task,
            global::OpenRouter.STTUsage? usage,
            global::System.Collections.Generic.IList<global::OpenRouter.STTWord>? words)
        {
            this.Duration = duration;
            this.Language = language;
            this.Segments = segments;
            this.Task = task;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Usage = usage;
            this.Words = words;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTResponse" /> class.
        /// </summary>
        public STTResponse()
        {
        }

    }
}