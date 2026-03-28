
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class URLCitation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UrlCitationTypeJsonConverter))]
        public global::OpenRouter.UrlCitationType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="URLCitation" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="url"></param>
        /// <param name="title"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public URLCitation(
            string url,
            string title,
            double startIndex,
            double endIndex,
            global::OpenRouter.UrlCitationType type)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="URLCitation" /> class.
        /// </summary>
        public URLCitation()
        {
        }
    }
}