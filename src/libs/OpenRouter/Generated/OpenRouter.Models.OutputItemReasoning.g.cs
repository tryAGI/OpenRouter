
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutputItemReasoning
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputItemReasoningTypeJsonConverter))]
        public global::OpenRouter.OutputItemReasoningType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ReasoningTextContent>? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ReasoningSummaryText> Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_content")]
        public string? EncryptedContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputItemReasoningStatusJsonConverter))]
        public global::OpenRouter.OutputItemReasoningStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemReasoning" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="content"></param>
        /// <param name="summary"></param>
        /// <param name="encryptedContent"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputItemReasoning(
            string id,
            global::System.Collections.Generic.IList<global::OpenRouter.ReasoningSummaryText> summary,
            global::OpenRouter.OutputItemReasoningType type,
            global::System.Collections.Generic.IList<global::OpenRouter.ReasoningTextContent>? content,
            string? encryptedContent,
            global::OpenRouter.OutputItemReasoningStatus? status)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Type = type;
            this.Content = content;
            this.EncryptedContent = encryptedContent;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemReasoning" /> class.
        /// </summary>
        public OutputItemReasoning()
        {
        }
    }
}