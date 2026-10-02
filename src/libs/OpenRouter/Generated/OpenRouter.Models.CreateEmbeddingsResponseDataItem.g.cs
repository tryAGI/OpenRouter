
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A single embedding object<br/>
    /// Example: {"embedding":[0.0023064255,-0.009327292,0.015797347],"index":0,"object":"embedding"}
    /// </summary>
    public sealed partial class CreateEmbeddingsResponseDataItem
    {
        /// <summary>
        /// Embedding vector as an array of floats or a base64 string<br/>
        /// Example: [0.0023064255F, -0.009327292F, 0.015797347F]
        /// </summary>
        /// <example>[0.0023064255F, -0.009327292F, 0.015797347F]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<double>, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<double>, string> Embedding { get; set; }

        /// <summary>
        /// Index of the embedding in the input list<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CreateEmbeddingsResponseDataItemObjectJsonConverter))]
        public global::OpenRouter.CreateEmbeddingsResponseDataItemObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingsResponseDataItem" /> class.
        /// </summary>
        /// <param name="embedding">
        /// Embedding vector as an array of floats or a base64 string<br/>
        /// Example: [0.0023064255F, -0.009327292F, 0.015797347F]
        /// </param>
        /// <param name="index">
        /// Index of the embedding in the input list<br/>
        /// Example: 0
        /// </param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEmbeddingsResponseDataItem(
            global::OpenRouter.AnyOf<global::System.Collections.Generic.IList<double>, string> embedding,
            int? index,
            global::OpenRouter.CreateEmbeddingsResponseDataItemObject @object)
        {
            this.Embedding = embedding;
            this.Index = index;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingsResponseDataItem" /> class.
        /// </summary>
        public CreateEmbeddingsResponseDataItem()
        {
        }

    }
}