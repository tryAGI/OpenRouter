
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"download_url":"https://example.com/download/file_abc123","filename":"summary.txt","id":"file_abc123","type":"file"}
    /// </summary>
    public sealed partial class CodeInterpreterFileOutput
    {
        /// <summary>
        /// Provider-issued download URL for the generated file. Typically signed and time-limited (see `expires_at`); fetch promptly rather than persisting the URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// Provider error code when generating or persisting the file failed; null or absent on success.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string? ErrorCode { get; set; }

        /// <summary>
        /// When the `download_url` stops working, as an ISO 8601 timestamp. After this time the file must be regenerated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public string? ExpiresAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        public string? MediaType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha256")]
        public string? Sha256 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        public long? SizeBytes { get; set; }

        /// <summary>
        /// Provider-reported readiness of the generated file (e.g. `ready`). Values other than `ready` indicate the artifact may not be downloadable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CodeInterpreterFileOutputTypeJsonConverter))]
        public global::OpenRouter.CodeInterpreterFileOutputType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterFileOutput" /> class.
        /// </summary>
        /// <param name="downloadUrl">
        /// Provider-issued download URL for the generated file. Typically signed and time-limited (see `expires_at`); fetch promptly rather than persisting the URL.
        /// </param>
        /// <param name="errorCode">
        /// Provider error code when generating or persisting the file failed; null or absent on success.
        /// </param>
        /// <param name="expiresAt">
        /// When the `download_url` stops working, as an ISO 8601 timestamp. After this time the file must be regenerated.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="id"></param>
        /// <param name="mediaType"></param>
        /// <param name="sha256"></param>
        /// <param name="sizeBytes"></param>
        /// <param name="status">
        /// Provider-reported readiness of the generated file (e.g. `ready`). Values other than `ready` indicate the artifact may not be downloadable.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeInterpreterFileOutput(
            string? downloadUrl,
            string? errorCode,
            string? expiresAt,
            string? filename,
            string? id,
            string? mediaType,
            string? sha256,
            long? sizeBytes,
            string? status,
            global::OpenRouter.CodeInterpreterFileOutputType type)
        {
            this.DownloadUrl = downloadUrl;
            this.ErrorCode = errorCode;
            this.ExpiresAt = expiresAt;
            this.Filename = filename;
            this.Id = id;
            this.MediaType = mediaType;
            this.Sha256 = sha256;
            this.SizeBytes = sizeBytes;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeInterpreterFileOutput" /> class.
        /// </summary>
        public CodeInterpreterFileOutput()
        {
        }

    }
}