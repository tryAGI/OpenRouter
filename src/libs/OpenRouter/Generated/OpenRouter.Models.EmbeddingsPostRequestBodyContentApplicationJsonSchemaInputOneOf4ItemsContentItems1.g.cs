
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1ImageUrl ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1TypeJsonConverter))]
        public global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1(
            global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1ImageUrl imageUrl,
            global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1Type type)
        {
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1" /> class.
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1()
        {
        }
    }
}