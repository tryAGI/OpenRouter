
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Audio output data or reference
    /// </summary>
    public sealed partial class ChatAudioOutput
    {
        /// <summary>
        /// Base64 encoded audio data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// Audio expiration timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public int? ExpiresAt { get; set; }

        /// <summary>
        /// Audio output identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Audio transcript
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAudioOutput" /> class.
        /// </summary>
        /// <param name="data">
        /// Base64 encoded audio data
        /// </param>
        /// <param name="expiresAt">
        /// Audio expiration timestamp
        /// </param>
        /// <param name="id">
        /// Audio output identifier
        /// </param>
        /// <param name="transcript">
        /// Audio transcript
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatAudioOutput(
            string? data,
            int? expiresAt,
            string? id,
            string? transcript)
        {
            this.Data = data;
            this.ExpiresAt = expiresAt;
            this.Id = id;
            this.Transcript = transcript;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatAudioOutput" /> class.
        /// </summary>
        public ChatAudioOutput()
        {
        }
    }
}