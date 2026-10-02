#nullable enable

namespace OpenRouter
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Get a model by its slug<br/>
        /// Returns full details for a single model identified by its author and slug (e.g. openai/gpt-4). Supports variant suffixes (e.g. openai/gpt-4:free) and resolves known slug aliases.
        /// </summary>
        /// <param name="author">
        /// The author/organization of the model<br/>
        /// Example: openai
        /// </param>
        /// <param name="slug">
        /// The model slug, optionally including a variant suffix (e.g. gpt-4 or gpt-4:free)<br/>
        /// Example: gpt-4
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ModelResponse> GetAsync(
            string author,
            string slug,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a model by its slug<br/>
        /// Returns full details for a single model identified by its author and slug (e.g. openai/gpt-4). Supports variant suffixes (e.g. openai/gpt-4:free) and resolves known slug aliases.
        /// </summary>
        /// <param name="author">
        /// The author/organization of the model<br/>
        /// Example: openai
        /// </param>
        /// <param name="slug">
        /// The model slug, optionally including a variant suffix (e.g. gpt-4 or gpt-4:free)<br/>
        /// Example: gpt-4
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ModelResponse>> GetAsResponseAsync(
            string author,
            string slug,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}