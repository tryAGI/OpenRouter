
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEmbeddingsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormatJsonConverter))]
        public global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormat? EncodingFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public int? Dimensions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Provider routing preferences for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public global::OpenRouter.ProviderPreferences? Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_type")]
        public string? InputType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingsRequest" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="model"></param>
        /// <param name="encodingFormat"></param>
        /// <param name="dimensions"></param>
        /// <param name="user"></param>
        /// <param name="provider">
        /// Provider routing preferences for the request.
        /// </param>
        /// <param name="inputType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEmbeddingsRequest(
            global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput input,
            string model,
            global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormat? encodingFormat,
            int? dimensions,
            string? user,
            global::OpenRouter.ProviderPreferences? provider,
            string? inputType)
        {
            this.Input = input;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.EncodingFormat = encodingFormat;
            this.Dimensions = dimensions;
            this.User = user;
            this.Provider = provider;
            this.InputType = inputType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingsRequest" /> class.
        /// </summary>
        public CreateEmbeddingsRequest()
        {
        }
    }
}