
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObjectJsonConverter))]
        public global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding Embedding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public double? Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="embedding"></param>
        /// <param name="index"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems(
            global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding embedding,
            global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObject @object,
            double? index)
        {
            this.Embedding = embedding;
            this.Object = @object;
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems" /> class.
        /// </summary>
        public EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems()
        {
        }
    }
}