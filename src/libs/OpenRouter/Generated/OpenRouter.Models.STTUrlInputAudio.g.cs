
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Audio input fetched by the provider from a URL<br/>
    /// Example: {"format":"mp3","url":"https://example.com/meeting.mp3"}
    /// </summary>
    public sealed partial class STTUrlInputAudio
    {
        /// <summary>
        /// Audio format of the file at the URL. Defaults to the extension of the URL path; required when the path has no extension.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public string? Format { get; set; }

        /// <summary>
        /// Publicly reachable http(s) URL of the audio file. The provider downloads it directly, so the inline upload size limit does not apply, and the request is billed on the duration the provider reports; your balance must cover the provider's maximum accepted duration at the endpoint rate (returns 402 otherwise). Private-network, loopback, link-local, cloud-metadata, and tunnel hosts are rejected. Only supported by some providers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="STTUrlInputAudio" /> class.
        /// </summary>
        /// <param name="url">
        /// Publicly reachable http(s) URL of the audio file. The provider downloads it directly, so the inline upload size limit does not apply, and the request is billed on the duration the provider reports; your balance must cover the provider's maximum accepted duration at the endpoint rate (returns 402 otherwise). Private-network, loopback, link-local, cloud-metadata, and tunnel hosts are rejected. Only supported by some providers.
        /// </param>
        /// <param name="format">
        /// Audio format of the file at the URL. Defaults to the extension of the URL path; required when the path has no extension.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTUrlInputAudio(
            string url,
            string? format)
        {
            this.Format = format;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTUrlInputAudio" /> class.
        /// </summary>
        public STTUrlInputAudio()
        {
        }

    }
}