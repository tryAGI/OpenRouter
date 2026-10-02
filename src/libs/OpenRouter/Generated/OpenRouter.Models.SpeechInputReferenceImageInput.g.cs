
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Reference image input object
    /// </summary>
    public sealed partial class SpeechInputReferenceImageInput
    {
        /// <summary>
        /// JPEG, PNG, or WebP reference image as a base64 data URI or a public http(s) URL. Remote images are downloaded (15 MiB max) and forwarded as bytes, never as the URL.<br/>
        /// Example: data:image/png;base64,iVBORw0KGgo...
        /// </summary>
        /// <example>data:image/png;base64,iVBORw0KGgo...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechInputReferenceImageInput" /> class.
        /// </summary>
        /// <param name="url">
        /// JPEG, PNG, or WebP reference image as a base64 data URI or a public http(s) URL. Remote images are downloaded (15 MiB max) and forwarded as bytes, never as the URL.<br/>
        /// Example: data:image/png;base64,iVBORw0KGgo...
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechInputReferenceImageInput(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechInputReferenceImageInput" /> class.
        /// </summary>
        public SpeechInputReferenceImageInput()
        {
        }

    }
}