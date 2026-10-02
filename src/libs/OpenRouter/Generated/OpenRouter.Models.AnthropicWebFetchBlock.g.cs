
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"content":{"citations":null,"source":{"data":"","media_type":"text/plain","type":"text"},"title":null,"type":"document"},"retrieved_at":null,"type":"web_fetch_result","url":"https://example.com"}
    /// </summary>
    public sealed partial class AnthropicWebFetchBlock
    {
        /// <summary>
        /// Example: {"citations":null,"source":{"data":"Hello, world!","media_type":"text/plain","type":"text"},"title":null,"type":"document"}
        /// </summary>
        /// <example>{"citations":null,"source":{"data":"Hello, world!","media_type":"text/plain","type":"text"},"title":null,"type":"document"}</example>
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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicWebFetchBlockTypeJsonConverter))]
        public global::OpenRouter.AnthropicWebFetchBlockType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="AnthropicWebFetchBlock" /> class.
        /// </summary>
        /// <param name="content">
        /// Example: {"citations":null,"source":{"data":"Hello, world!","media_type":"text/plain","type":"text"},"title":null,"type":"document"}
        /// </param>
        /// <param name="url"></param>
        /// <param name="retrievedAt"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicWebFetchBlock(
            global::OpenRouter.AnthropicDocumentBlock content,
            string url,
            string? retrievedAt,
            global::OpenRouter.AnthropicWebFetchBlockType type)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.RetrievedAt = retrievedAt;
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicWebFetchBlock" /> class.
        /// </summary>
        public AnthropicWebFetchBlock()
        {
        }

    }
}