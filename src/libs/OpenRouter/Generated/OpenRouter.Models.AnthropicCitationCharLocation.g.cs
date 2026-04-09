
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnthropicCitationCharLocation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cited_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CitedText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DocumentIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_title")]
        public string? DocumentTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_char_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndCharIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_char_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartCharIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicCitationCharLocationTypeJsonConverter))]
        public global::OpenRouter.AnthropicCitationCharLocationType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicCitationCharLocation" /> class.
        /// </summary>
        /// <param name="citedText"></param>
        /// <param name="documentIndex"></param>
        /// <param name="endCharIndex"></param>
        /// <param name="startCharIndex"></param>
        /// <param name="documentTitle"></param>
        /// <param name="fileId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicCitationCharLocation(
            string citedText,
            int documentIndex,
            int endCharIndex,
            int startCharIndex,
            string? documentTitle,
            string? fileId,
            global::OpenRouter.AnthropicCitationCharLocationType type)
        {
            this.CitedText = citedText ?? throw new global::System.ArgumentNullException(nameof(citedText));
            this.DocumentIndex = documentIndex;
            this.DocumentTitle = documentTitle;
            this.EndCharIndex = endCharIndex;
            this.FileId = fileId;
            this.StartCharIndex = startCharIndex;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicCitationCharLocation" /> class.
        /// </summary>
        public AnthropicCitationCharLocation()
        {
        }
    }
}