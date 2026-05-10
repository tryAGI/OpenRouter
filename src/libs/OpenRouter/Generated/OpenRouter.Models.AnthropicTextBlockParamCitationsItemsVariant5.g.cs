
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// web_search_result_location variant
    /// </summary>
    public sealed partial class AnthropicTextBlockParamCitationsItemsVariant5
    {
        /// <summary>
        /// Discriminator value: web_search_result_location
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicTextBlockParamCitationsItemsVariant5TypeJsonConverter))]
        public global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cited_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CitedText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EncryptedIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="AnthropicTextBlockParamCitationsItemsVariant5" /> class.
        /// </summary>
        /// <param name="citedText"></param>
        /// <param name="encryptedIndex"></param>
        /// <param name="url"></param>
        /// <param name="type">
        /// Discriminator value: web_search_result_location
        /// </param>
        /// <param name="title"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicTextBlockParamCitationsItemsVariant5(
            string citedText,
            string encryptedIndex,
            string url,
            global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5Type type,
            string? title)
        {
            this.Type = type;
            this.CitedText = citedText ?? throw new global::System.ArgumentNullException(nameof(citedText));
            this.EncryptedIndex = encryptedIndex ?? throw new global::System.ArgumentNullException(nameof(encryptedIndex));
            this.Title = title;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicTextBlockParamCitationsItemsVariant5" /> class.
        /// </summary>
        public AnthropicTextBlockParamCitationsItemsVariant5()
        {
        }

    }
}