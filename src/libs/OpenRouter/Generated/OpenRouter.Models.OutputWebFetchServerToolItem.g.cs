
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:web_fetch server tool output item
    /// </summary>
    public sealed partial class OutputWebFetchServerToolItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ToolCallStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputWebFetchServerToolItemTypeJsonConverter))]
        public global::OpenRouter.OutputWebFetchServerToolItemType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputWebFetchServerToolItem" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="content"></param>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="type"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputWebFetchServerToolItem(
            global::OpenRouter.ToolCallStatus status,
            string? content,
            string? id,
            string? title,
            global::OpenRouter.OutputWebFetchServerToolItemType type,
            string? url)
        {
            this.Content = content;
            this.Id = id;
            this.Status = status;
            this.Title = title;
            this.Type = type;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputWebFetchServerToolItem" /> class.
        /// </summary>
        public OutputWebFetchServerToolItem()
        {
        }
    }
}