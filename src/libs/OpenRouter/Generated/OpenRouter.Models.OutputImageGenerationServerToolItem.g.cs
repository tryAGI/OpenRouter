
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:image_generation server tool output item<br/>
    /// Example: {"id":"ig_tmp_abc123","imageUrl":"https://example.com/image.png","result":"https://example.com/image.png","status":"completed","type":"openrouter:image_generation"}
    /// </summary>
    public sealed partial class OutputImageGenerationServerToolItem
    {
        /// <summary>
        /// The error message when the tool call failed before producing a result. Set together with `status: 'failed'`; absent on a successful call.<br/>
        /// Example: Tool execution failed
        /// </summary>
        /// <example>Tool execution failed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

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
        /// The prompt (possibly rewritten) that the image was generated from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

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
        /// Example: completed
        /// </summary>
        /// <example>completed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.FailableToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.FailableToolCallStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputImageGenerationServerToolItemTypeJsonConverter))]
        public global::OpenRouter.OutputImageGenerationServerToolItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputImageGenerationServerToolItem" /> class.
        /// </summary>
        /// <param name="status">
        /// Example: completed
        /// </param>
        /// <param name="error">
        /// The error message when the tool call failed before producing a result. Set together with `status: 'failed'`; absent on a successful call.<br/>
        /// Example: Tool execution failed
        /// </param>
        /// <param name="id"></param>
        /// <param name="imageB64"></param>
        /// <param name="imageUrl"></param>
        /// <param name="prompt">
        /// The prompt (possibly rewritten) that the image was generated from.
        /// </param>
        /// <param name="result">
        /// The generated image as a base64-encoded string or URL, matching OpenAI image_generation_call format
        /// </param>
        /// <param name="revisedPrompt"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputImageGenerationServerToolItem(
            global::OpenRouter.FailableToolCallStatus status,
            string? error,
            string? id,
            string? imageB64,
            string? imageUrl,
            string? prompt,
            string? result,
            string? revisedPrompt,
            global::OpenRouter.OutputImageGenerationServerToolItemType type)
        {
            this.Error = error;
            this.Id = id;
            this.ImageB64 = imageB64;
            this.ImageUrl = imageUrl;
            this.Prompt = prompt;
            this.Result = result;
            this.RevisedPrompt = revisedPrompt;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputImageGenerationServerToolItem" /> class.
        /// </summary>
        public OutputImageGenerationServerToolItem()
        {
        }

    }
}