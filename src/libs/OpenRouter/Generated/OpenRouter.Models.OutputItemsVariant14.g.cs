
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// openrouter:image_generation variant
    /// </summary>
    public sealed partial class OutputItemsVariant14
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputImageGenerationServerToolItemTypeJsonConverter))]
        public global::OpenRouter.OutputImageGenerationServerToolItemType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageB64")]
        public string? ImageB64 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// The generated image as a base64-encoded string or URL, matching OpenAI image_generation_call format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public string? Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revisedPrompt")]
        public string? RevisedPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ToolCallStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant14" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="imageB64"></param>
        /// <param name="imageUrl"></param>
        /// <param name="result">
        /// The generated image as a base64-encoded string or URL, matching OpenAI image_generation_call format
        /// </param>
        /// <param name="revisedPrompt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputItemsVariant14(
            global::OpenRouter.ToolCallStatus status,
            global::OpenRouter.OutputImageGenerationServerToolItemType type,
            string? id,
            string? imageB64,
            string? imageUrl,
            string? result,
            string? revisedPrompt)
        {
            this.Type = type;
            this.Id = id;
            this.ImageB64 = imageB64;
            this.ImageUrl = imageUrl;
            this.Result = result;
            this.RevisedPrompt = revisedPrompt;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemsVariant14" /> class.
        /// </summary>
        public OutputItemsVariant14()
        {
        }
    }
}