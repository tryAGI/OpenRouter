
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// reasoning variant
    /// </summary>
    public sealed partial class OutputItemsVariant20
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
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ReasoningTextContent>? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_content")]
        public string? EncryptedContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputItemReasoningStatusJsonConverter))]
        public global::OpenRouter.OutputItemReasoningStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ReasoningSummaryText> Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ReasoningFormatJsonConverter))]
        public global::OpenRouter.ReasoningFormat? Format { get; set; }

        /// <summary>
        /// A signature for the reasoning content, used for verification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant20" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="summary"></param>
        /// <param name="type"></param>
        /// <param name="content"></param>
        /// <param name="encryptedContent"></param>
        /// <param name="status"></param>
        /// <param name="format"></param>
        /// <param name="signature">
        /// A signature for the reasoning content, used for verification
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputItemsVariant20(
            string id,
            global::System.Collections.Generic.IList<global::OpenRouter.ReasoningSummaryText> summary,
            global::OpenRouter.OutputItemReasoningType type,
            global::System.Collections.Generic.IList<global::OpenRouter.ReasoningTextContent>? content,
            string? encryptedContent,
            global::OpenRouter.OutputItemReasoningStatus? status,
            global::OpenRouter.ReasoningFormat? format,
            string? signature)
        {
            this.Type = type;
            this.Content = content;
            this.EncryptedContent = encryptedContent;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Format = format;
            this.Signature = signature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant20" /> class.
        /// </summary>
        public OutputItemsVariant20()
        {
        }
    }
}