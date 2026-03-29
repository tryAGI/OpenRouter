
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingsCreateEmbeddingsResponse200
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.EmbeddingsPostResponsesContentApplicationJsonSchemaObjectJsonConverter))]
        public global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems> Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsCreateEmbeddingsResponse200" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="model"></param>
        /// <param name="id"></param>
        /// <param name="object"></param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingsCreateEmbeddingsResponse200(
            global::System.Collections.Generic.IList<global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems> data,
            string model,
            string? id,
            global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaObject @object,
            global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaUsage? usage)
        {
            this.Id = id;
            this.Object = @object;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsCreateEmbeddingsResponse200" /> class.
        /// </summary>
        public EmbeddingsCreateEmbeddingsResponse200()
        {
        }
    }
}