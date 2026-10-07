
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAudioTranscriptionsRequest
    {
        /// <summary>
        /// Label each word with the speaker who said it (words[].speaker, words[].speaker_label). Requires response_format "verbose_json" (400 otherwise); word timestamps are included even when timestamp_granularities[] omits "word". Only supported by some providers; 400 when the selected model cannot diarize.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diarize")]
        public bool? Diarize { get; set; }

        /// <summary>
        /// The audio file to transcribe. The format is derived from the filename extension or the file part content type. Max 25 MB; send larger files as base64 JSON via input_audio, or by URL via source_url. Exactly one of file or source_url is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public byte[]? File { get; set; }

        /// <summary>
        /// The audio file to transcribe. The format is derived from the filename extension or the file part content type. Max 25 MB; send larger files as base64 JSON via input_audio, or by URL via source_url. Exactly one of file or source_url is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Domain terms, names, or phrases to bias recognition toward; repeat the part once per term (keyterms=... is also accepted). Only supported by some providers; 400 when the selected model cannot use keyterms.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyterms[]")]
        public global::System.Collections.Generic.IList<string>? Keyterms { get; set; }

        /// <summary>
        /// The language of the input audio (ISO-639-1).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The model to use for transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// JSON-encoded provider preferences object, the same shape as the JSON body field: { "zdr": true, "data_collection": "deny", "options": { "&lt;provider-slug&gt;": { ... } } }. Only options for the matched provider are forwarded. Must decode to a JSON object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// The response format. "json" (default) returns { text, usage }; "verbose_json" additionally returns task, language, duration, and segment-level timestamps (OpenAI-compatible providers only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CreateAudioTranscriptionsRequestResponseFormatJsonConverter))]
        public global::OpenRouter.CreateAudioTranscriptionsRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). Used for observability grouping in Broadcast and private logging; never sent to the provider. If provided in both the request body and the x-session-id header, the body value takes precedence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Publicly reachable http(s) URL of the audio file, downloaded by the provider directly (no size limit on our side). The format is derived from the URL path extension. Only supported by some providers; exactly one of file or source_url is required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// The sampling temperature.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Timestamp detail levels to include when response_format is "verbose_json". "word" additionally returns word-level timestamps in the words array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_granularities[]")]
        public global::System.Collections.Generic.IList<global::OpenRouter.CreateAudioTranscriptionsRequestTimestampGranularitie>? TimestampGranularities { get; set; }

        /// <summary>
        /// JSON-encoded trace metadata object (trace_id, trace_name, span_name, generation_name, parent_span_id and custom keys) attached to the Broadcast trace. Must decode to a JSON object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace")]
        public string? Trace { get; set; }

        /// <summary>
        /// A unique identifier representing your end-user. Forwarded to Broadcast and private logging as the end-user id; never sent to the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAudioTranscriptionsRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The model to use for transcription.
        /// </param>
        /// <param name="diarize">
        /// Label each word with the speaker who said it (words[].speaker, words[].speaker_label). Requires response_format "verbose_json" (400 otherwise); word timestamps are included even when timestamp_granularities[] omits "word". Only supported by some providers; 400 when the selected model cannot diarize.
        /// </param>
        /// <param name="file">
        /// The audio file to transcribe. The format is derived from the filename extension or the file part content type. Max 25 MB; send larger files as base64 JSON via input_audio, or by URL via source_url. Exactly one of file or source_url is required.
        /// </param>
        /// <param name="filename">
        /// The audio file to transcribe. The format is derived from the filename extension or the file part content type. Max 25 MB; send larger files as base64 JSON via input_audio, or by URL via source_url. Exactly one of file or source_url is required.
        /// </param>
        /// <param name="keyterms">
        /// Domain terms, names, or phrases to bias recognition toward; repeat the part once per term (keyterms=... is also accepted). Only supported by some providers; 400 when the selected model cannot use keyterms.
        /// </param>
        /// <param name="language">
        /// The language of the input audio (ISO-639-1).
        /// </param>
        /// <param name="provider">
        /// JSON-encoded provider preferences object, the same shape as the JSON body field: { "zdr": true, "data_collection": "deny", "options": { "&lt;provider-slug&gt;": { ... } } }. Only options for the matched provider are forwarded. Must decode to a JSON object.
        /// </param>
        /// <param name="responseFormat">
        /// The response format. "json" (default) returns { text, usage }; "verbose_json" additionally returns task, language, duration, and segment-level timestamps (OpenAI-compatible providers only).
        /// </param>
        /// <param name="sessionId">
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). Used for observability grouping in Broadcast and private logging; never sent to the provider. If provided in both the request body and the x-session-id header, the body value takes precedence.
        /// </param>
        /// <param name="sourceUrl">
        /// Publicly reachable http(s) URL of the audio file, downloaded by the provider directly (no size limit on our side). The format is derived from the URL path extension. Only supported by some providers; exactly one of file or source_url is required.
        /// </param>
        /// <param name="temperature">
        /// The sampling temperature.
        /// </param>
        /// <param name="timestampGranularities">
        /// Timestamp detail levels to include when response_format is "verbose_json". "word" additionally returns word-level timestamps in the words array.
        /// </param>
        /// <param name="trace">
        /// JSON-encoded trace metadata object (trace_id, trace_name, span_name, generation_name, parent_span_id and custom keys) attached to the Broadcast trace. Must decode to a JSON object.
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user. Forwarded to Broadcast and private logging as the end-user id; never sent to the provider.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAudioTranscriptionsRequest(
            string model,
            bool? diarize,
            byte[]? file,
            string? filename,
            global::System.Collections.Generic.IList<string>? keyterms,
            string? language,
            string? provider,
            global::OpenRouter.CreateAudioTranscriptionsRequestResponseFormat? responseFormat,
            string? sessionId,
            string? sourceUrl,
            double? temperature,
            global::System.Collections.Generic.IList<global::OpenRouter.CreateAudioTranscriptionsRequestTimestampGranularitie>? timestampGranularities,
            string? trace,
            string? user)
        {
            this.Diarize = diarize;
            this.File = file;
            this.Filename = filename;
            this.Keyterms = keyterms;
            this.Language = language;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Provider = provider;
            this.ResponseFormat = responseFormat;
            this.SessionId = sessionId;
            this.SourceUrl = sourceUrl;
            this.Temperature = temperature;
            this.TimestampGranularities = timestampGranularities;
            this.Trace = trace;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAudioTranscriptionsRequest" /> class.
        /// </summary>
        public CreateAudioTranscriptionsRequest()
        {
        }

    }
}