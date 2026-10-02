
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// STT response containing transcribed text and optional usage statistics<br/>
    /// Example: {"text":"Hello, this is a test of OpenAI speech-to-text transcription.","usage":{"cost":0.000508,"input_tokens":83,"output_tokens":30,"seconds":9.2,"total_tokens":113}}
    /// </summary>
    public sealed partial class STTResponse
    {
        /// <summary>
        /// Provider confidence for the whole transcript from 0 to 1, present when response_format is verbose_json and the provider scores the full transcript<br/>
        /// Example: 0.94F
        /// </summary>
        /// <example>0.94F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Duration of the input audio in seconds, present when response_format is verbose_json<br/>
        /// Example: 9.2F
        /// </summary>
        /// <example>9.2F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Detected entities with character offsets into text, present when the provider runs entity detection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        public global::System.Collections.Generic.IList<global::OpenRouter.STTEntity>? Entities { get; set; }

        /// <summary>
        /// Detected or forced language, present when response_format is verbose_json<br/>
        /// Example: english
        /// </summary>
        /// <example>english</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Provider confidence in the detected language from 0 to 1, present when response_format is verbose_json and the provider scores language detection<br/>
        /// Example: 0.98F
        /// </summary>
        /// <example>0.98F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_confidence")]
        public double? LanguageConfidence { get; set; }

        /// <summary>
        /// Timestamped transcript segments, present when response_format is verbose_json
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        public global::System.Collections.Generic.IList<global::OpenRouter.STTSegment>? Segments { get; set; }

        /// <summary>
        /// The task performed, present when response_format is verbose_json<br/>
        /// Example: transcribe
        /// </summary>
        /// <example>transcribe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        public string? Task { get; set; }

        /// <summary>
        /// The transcribed text<br/>
        /// Example: Hello, this is a test of OpenAI speech-to-text transcription. The weather is sunny today and the temperature is around 72 degrees.
        /// </summary>
        /// <example>Hello, this is a test of OpenAI speech-to-text transcription. The weather is sunny today and the temperature is around 72 degrees.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Aggregated usage statistics for the request<br/>
        /// Example: {"cost":0.000508,"input_tokens":83,"output_tokens":30,"seconds":9.2,"total_tokens":113}
        /// </summary>
        /// <example>{"cost":0.000508,"input_tokens":83,"output_tokens":30,"seconds":9.2,"total_tokens":113}</example>
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
        /// The transcribed text<br/>
        /// Example: Hello, this is a test of OpenAI speech-to-text transcription. The weather is sunny today and the temperature is around 72 degrees.
        /// </param>
        /// <param name="confidence">
        /// Provider confidence for the whole transcript from 0 to 1, present when response_format is verbose_json and the provider scores the full transcript<br/>
        /// Example: 0.94F
        /// </param>
        /// <param name="duration">
        /// Duration of the input audio in seconds, present when response_format is verbose_json<br/>
        /// Example: 9.2F
        /// </param>
        /// <param name="entities">
        /// Detected entities with character offsets into text, present when the provider runs entity detection
        /// </param>
        /// <param name="language">
        /// Detected or forced language, present when response_format is verbose_json<br/>
        /// Example: english
        /// </param>
        /// <param name="languageConfidence">
        /// Provider confidence in the detected language from 0 to 1, present when response_format is verbose_json and the provider scores language detection<br/>
        /// Example: 0.98F
        /// </param>
        /// <param name="segments">
        /// Timestamped transcript segments, present when response_format is verbose_json
        /// </param>
        /// <param name="task">
        /// The task performed, present when response_format is verbose_json<br/>
        /// Example: transcribe
        /// </param>
        /// <param name="usage">
        /// Aggregated usage statistics for the request<br/>
        /// Example: {"cost":0.000508,"input_tokens":83,"output_tokens":30,"seconds":9.2,"total_tokens":113}
        /// </param>
        /// <param name="words">
        /// Timestamped words, present when the provider returns word-level timestamps
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTResponse(
            string text,
            double? confidence,
            double? duration,
            global::System.Collections.Generic.IList<global::OpenRouter.STTEntity>? entities,
            string? language,
            double? languageConfidence,
            global::System.Collections.Generic.IList<global::OpenRouter.STTSegment>? segments,
            string? task,
            global::OpenRouter.STTUsage? usage,
            global::System.Collections.Generic.IList<global::OpenRouter.STTWord>? words)
        {
            this.Confidence = confidence;
            this.Duration = duration;
            this.Entities = entities;
            this.Language = language;
            this.LanguageConfidence = languageConfidence;
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