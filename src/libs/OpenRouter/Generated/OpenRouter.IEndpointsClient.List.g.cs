#nullable enable

namespace OpenRouter
{
    public partial interface IEndpointsClient
    {
        /// <summary>
        /// List all endpoints for a model
        /// </summary>
        /// <param name="author">
        /// The author/organization of the model<br/>
        /// Example: openai
        /// </param>
        /// <param name="slug">
        /// The model slug<br/>
        /// Example: gpt-4
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ListEndpointsResponse2> ListAsync(
            string author,
            string slug,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all endpoints for a model
        /// </summary>
        /// <param name="author">
        /// The author/organization of the model<br/>
        /// Example: openai
        /// </param>
        /// <param name="slug">
        /// The model slug<br/>
        /// Example: gpt-4
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ListEndpointsResponse2>> ListAsResponseAsync(
            string author,
            string slug,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}