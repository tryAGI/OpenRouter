
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// STT response containing transcribed text and optional usage statistics
    /// </summary>
    public sealed partial class STTResponse
    {
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
        /// <param name="usage">
        /// Aggregated usage statistics for the request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTResponse(
            string text,
            global::OpenRouter.STTUsage? usage)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTResponse" /> class.
        /// </summary>
        public STTResponse()
        {
        }
    }
}