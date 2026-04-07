#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageEmbeddingsClient
    {
        /// <summary>
        /// Submit an embedding request<br/>
        /// Submits an embedding request to the embeddings router
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.EmbeddingsCreateEmbeddingsResponse200> CreateEmbeddingsAsync(

            global::OpenRouter.CreateEmbeddingsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit an embedding request<br/>
        /// Submits an embedding request to the embeddings router
        /// </summary>
        /// <param name="input">
        /// Text, token, or multimodal input(s) to embed
        /// </param>
        /// <param name="model">
        /// The model to use for embeddings
        /// </param>
        /// <param name="encodingFormat">
        /// The format of the output embeddings
        /// </param>
        /// <param name="dimensions">
        /// The number of dimensions for the output embeddings
        /// </param>
        /// <param name="user">
        /// A unique identifier for the end-user
        /// </param>
        /// <param name="provider"></param>
        /// <param name="inputType">
        /// The type of input (e.g. search_query, search_document)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.EmbeddingsCreateEmbeddingsResponse200> CreateEmbeddingsAsync(
            global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput input,
            string model,
            global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormat? encodingFormat = default,
            int? dimensions = default,
            string? user = default,
            global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProvider? provider = default,
            string? inputType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}