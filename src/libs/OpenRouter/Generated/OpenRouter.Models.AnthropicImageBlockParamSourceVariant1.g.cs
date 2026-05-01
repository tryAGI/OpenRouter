
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// base64 variant
    /// </summary>
    public sealed partial class AnthropicImageBlockParamSourceVariant1
    {
        /// <summary>
        /// Discriminator value: base64
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicImageBlockParamSourceVariant1TypeJsonConverter))]
        public global::OpenRouter.AnthropicImageBlockParamSourceVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicImageMimeTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnthropicImageMimeType MediaType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicImageBlockParamSourceVariant1" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="mediaType"></param>
        /// <param name="type">
        /// Discriminator value: base64
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicImageBlockParamSourceVariant1(
            string data,
            global::OpenRouter.AnthropicImageMimeType mediaType,
            global::OpenRouter.AnthropicImageBlockParamSourceVariant1Type type)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.MediaType = mediaType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicImageBlockParamSourceVariant1" /> class.
        /// </summary>
        public AnthropicImageBlockParamSourceVariant1()
        {
        }
    }
}