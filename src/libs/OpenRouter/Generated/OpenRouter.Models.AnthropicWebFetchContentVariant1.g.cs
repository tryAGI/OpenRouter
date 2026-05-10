
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// web_fetch_result variant
    /// </summary>
    public sealed partial class AnthropicWebFetchContentVariant1
    {
        /// <summary>
        /// Discriminator value: web_fetch_result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicWebFetchContentVariant1TypeJsonConverter))]
        public global::OpenRouter.AnthropicWebFetchContentVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnthropicDocumentBlock Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrieved_at")]
        public string? RetrievedAt { get; set; }

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
        /// Initializes a new instance of the <see cref="AnthropicWebFetchContentVariant1" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="url"></param>
        /// <param name="type">
        /// Discriminator value: web_fetch_result
        /// </param>
        /// <param name="retrievedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicWebFetchContentVariant1(
            global::OpenRouter.AnthropicDocumentBlock content,
            string url,
            global::OpenRouter.AnthropicWebFetchContentVariant1Type type,
            string? retrievedAt)
        {
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.RetrievedAt = retrievedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicWebFetchContentVariant1" /> class.
        /// </summary>
        public AnthropicWebFetchContentVariant1()
        {
        }

    }
}