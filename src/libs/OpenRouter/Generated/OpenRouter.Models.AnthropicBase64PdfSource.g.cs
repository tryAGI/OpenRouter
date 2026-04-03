
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnthropicBase64PdfSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicBase64PdfSourceTypeJsonConverter))]
        public global::OpenRouter.AnthropicBase64PdfSourceType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicBase64PdfSourceMediaTypeJsonConverter))]
        public global::OpenRouter.AnthropicBase64PdfSourceMediaType MediaType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicBase64PdfSource" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="mediaType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicBase64PdfSource(
            string data,
            global::OpenRouter.AnthropicBase64PdfSourceType type,
            global::OpenRouter.AnthropicBase64PdfSourceMediaType mediaType)
        {
            this.Type = type;
            this.MediaType = mediaType;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicBase64PdfSource" /> class.
        /// </summary>
        public AnthropicBase64PdfSource()
        {
        }
    }
}