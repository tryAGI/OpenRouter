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
        /// <param name="input"></param>
        /// <param name="model"></param>
        /// <param name="encodingFormat"></param>
        /// <param name="dimensions"></param>
        /// <param name="user"></param>
        /// <param name="provider">
        /// Provider routing preferences for the request.
        /// </param>
        /// <param name="inputType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.EmbeddingsCreateEmbeddingsResponse200> CreateEmbeddingsAsync(
            global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput input,
            string model,
            global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormat? encodingFormat = default,
            int? dimensions = default,
            string? user = default,
            global::OpenRouter.ProviderPreferences? provider = default,
            string? inputType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}