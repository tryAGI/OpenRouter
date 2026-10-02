
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Embeddings response containing embedding vectors<br/>
    /// Example: {"data":[{"embedding":[0.0023064255,-0.009327292,0.015797347],"index":0,"object":"embedding"}],"model":"openai/text-embedding-3-small","object":"list","usage":{"prompt_tokens":8,"total_tokens":8}}
    /// </summary>
    public sealed partial class BatchObjectResultResponseBodyVariant4
    {
        /// <summary>
        /// List of embedding objects<br/>
        /// Example: [{"embedding":[0.0023064255,-0.009327292,0.015797347],"index":0,"object":"embedding"}]
        /// </summary>
        /// <example>[{"embedding":[0.0023064255,-0.009327292,0.015797347],"index":0,"object":"embedding"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant4DataItem> Data { get; set; }

        /// <summary>
        /// Unique identifier for the embeddings response<br/>
        /// Example: embd-1234567890
        /// </summary>
        /// <example>embd-1234567890</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The model used for embeddings<br/>
        /// Example: openai/text-embedding-3-small
        /// </summary>
        /// <example>openai/text-embedding-3-small</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BatchObjectResultResponseBodyVariant4ObjectJsonConverter))]
        public global::OpenRouter.BatchObjectResultResponseBodyVariant4Object Object { get; set; }

        /// <summary>
        /// Token usage statistics<br/>
        /// Example: {"prompt_tokens":8,"total_tokens":8}
        /// </summary>
        /// <example>{"prompt_tokens":8,"total_tokens":8}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::OpenRouter.BatchObjectResultResponseBodyVariant4Usage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant4" /> class.
        /// </summary>
        /// <param name="data">
        /// List of embedding objects<br/>
        /// Example: [{"embedding":[0.0023064255,-0.009327292,0.015797347],"index":0,"object":"embedding"}]
        /// </param>
        /// <param name="model">
        /// The model used for embeddings<br/>
        /// Example: openai/text-embedding-3-small
        /// </param>
        /// <param name="id">
        /// Unique identifier for the embeddings response<br/>
        /// Example: embd-1234567890
        /// </param>
        /// <param name="object"></param>
        /// <param name="usage">
        /// Token usage statistics<br/>
        /// Example: {"prompt_tokens":8,"total_tokens":8}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchObjectResultResponseBodyVariant4(
            global::System.Collections.Generic.IList<global::OpenRouter.BatchObjectResultResponseBodyVariant4DataItem> data,
            string model,
            string? id,
            global::OpenRouter.BatchObjectResultResponseBodyVariant4Object @object,
            global::OpenRouter.BatchObjectResultResponseBodyVariant4Usage? usage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Id = id;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Object = @object;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant4" /> class.
        /// </summary>
        public BatchObjectResultResponseBodyVariant4()
        {
        }

    }
}