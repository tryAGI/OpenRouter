
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A single embedding object
    /// </summary>
    public sealed partial class EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems
    {
        /// <summary>
        /// Embedding vector as an array of floats or a base64 string
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding Embedding { get; set; }

        /// <summary>
        /// Index of the embedding in the input list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObjectJsonConverter))]
        public global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems" /> class.
        /// </summary>
        /// <param name="embedding">
        /// Embedding vector as an array of floats or a base64 string
        /// </param>
        /// <param name="index">
        /// Index of the embedding in the input list
        /// </param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems(
            global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding embedding,
            int? index,
            global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObject @object)
        {
            this.Embedding = embedding;
            this.Index = index;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems" /> class.
        /// </summary>
        public EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems()
        {
        }
    }
}