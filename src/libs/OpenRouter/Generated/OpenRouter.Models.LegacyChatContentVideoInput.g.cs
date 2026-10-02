
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Video input object<br/>
    /// Example: {"url":"https://example.com/video.mp4"}
    /// </summary>
    public sealed partial class LegacyChatContentVideoInput
    {
        /// <summary>
        /// Video processing mode. `agentic` enables agentic video processing and `static` forces fixed-rate frame sampling on providers that support it (currently Google Gemini).<br/>
        /// Example: agentic
        /// </summary>
        /// <example>agentic</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.LegacyChatContentVideoInputProcessingJsonConverter))]
        public global::OpenRouter.LegacyChatContentVideoInputProcessing? Processing { get; set; }

        /// <summary>
        /// URL of the video (data: URLs supported)
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
        /// Initializes a new instance of the <see cref="LegacyChatContentVideoInput" /> class.
        /// </summary>
        /// <param name="url">
        /// URL of the video (data: URLs supported)
        /// </param>
        /// <param name="processing">
        /// Video processing mode. `agentic` enables agentic video processing and `static` forces fixed-rate frame sampling on providers that support it (currently Google Gemini).<br/>
        /// Example: agentic
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LegacyChatContentVideoInput(
            string url,
            global::OpenRouter.LegacyChatContentVideoInputProcessing? processing)
        {
            this.Processing = processing;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LegacyChatContentVideoInput" /> class.
        /// </summary>
        public LegacyChatContentVideoInput()
        {
        }

    }
}