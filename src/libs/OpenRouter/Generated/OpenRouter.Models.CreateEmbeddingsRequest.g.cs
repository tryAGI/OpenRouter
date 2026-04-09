
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEmbeddingsRequest
    {
        /// <summary>
        /// The number of dimensions for the output embeddings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public int? Dimensions { get; set; }

        /// <summary>
        /// The format of the output embeddings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormatJsonConverter))]
        public global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormat? EncodingFormat { get; set; }

        /// <summary>
        /// Text, token, or multimodal input(s) to embed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput Input { get; set; }

        /// <summary>
        /// The type of input (e.g. search_query, search_document)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_type")]
        public string? InputType { get; set; }

        /// <summary>
        /// The model to use for embeddings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProvider? Provider { get; set; }

        /// <summary>
        /// A unique identifier for the end-user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingsRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Text, token, or multimodal input(s) to embed
        /// </param>
        /// <param name="model">
        /// The model to use for embeddings
        /// </param>
        /// <param name="dimensions">
        /// The number of dimensions for the output embeddings
        /// </param>
        /// <param name="encodingFormat">
        /// The format of the output embeddings
        /// </param>
        /// <param name="inputType">
        /// The type of input (e.g. search_query, search_document)
        /// </param>
        /// <param name="provider"></param>
        /// <param name="user">
        /// A unique identifier for the end-user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEmbeddingsRequest(
            global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput input,
            string model,
            int? dimensions,
            global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormat? encodingFormat,
            string? inputType,
            global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProvider? provider,
            string? user)
        {
            this.Dimensions = dimensions;
            this.EncodingFormat = encodingFormat;
            this.Input = input;
            this.InputType = inputType;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Provider = provider;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingsRequest" /> class.
        /// </summary>
        public CreateEmbeddingsRequest()
        {
        }
    }
}