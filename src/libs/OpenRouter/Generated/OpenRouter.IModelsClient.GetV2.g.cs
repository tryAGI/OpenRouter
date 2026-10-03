#nullable enable

namespace OpenRouter
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// Get a model with its V2 endpoint documents<br/>
        /// Returns a single model identified by its author and slug (e.g. openai/gpt-4) together with each of its published endpoints in the Models API V2 document format. Known slug aliases are resolved. A variant suffix (e.g. openai/gpt-4:free) selects the record of that variant; a variant no endpoint serves is reported as not found. Routers (openrouter/auto) and `~author/family-latest` aliases are records too. `region` narrows the endpoints the same way it does on the list route; a model left without an endpoint is reported as not found. With an API key the record comes from that key's catalog, as on the list route, so a model the key cannot route to is not found.
        /// </summary>
        /// <param name="author">
        /// The author/organization of the model<br/>
        /// Example: openai
        /// </param>
        /// <param name="slug">
        /// The model slug, optionally including a variant suffix (e.g. gpt-4 or gpt-4:free)<br/>
        /// Example: gpt-4
        /// </param>
        /// <param name="region">
        /// Only return endpoints in the given data region ("eu" or "us"); a model left without an endpoint is reported as not found. With an API key the record comes from that key's catalog, as on the list route, so a model the key cannot route to is not found.<br/>
        /// Example: eu
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ModelV2Response> GetV2Async(
            string author,
            string slug,
            global::OpenRouter.GetModelV2Region? region = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a model with its V2 endpoint documents<br/>
        /// Returns a single model identified by its author and slug (e.g. openai/gpt-4) together with each of its published endpoints in the Models API V2 document format. Known slug aliases are resolved. A variant suffix (e.g. openai/gpt-4:free) selects the record of that variant; a variant no endpoint serves is reported as not found. Routers (openrouter/auto) and `~author/family-latest` aliases are records too. `region` narrows the endpoints the same way it does on the list route; a model left without an endpoint is reported as not found. With an API key the record comes from that key's catalog, as on the list route, so a model the key cannot route to is not found.
        /// </summary>
        /// <param name="author">
        /// The author/organization of the model<br/>
        /// Example: openai
        /// </param>
        /// <param name="slug">
        /// The model slug, optionally including a variant suffix (e.g. gpt-4 or gpt-4:free)<br/>
        /// Example: gpt-4
        /// </param>
        /// <param name="region">
        /// Only return endpoints in the given data region ("eu" or "us"); a model left without an endpoint is reported as not found. With an API key the record comes from that key's catalog, as on the list route, so a model the key cannot route to is not found.<br/>
        /// Example: eu
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ModelV2Response>> GetV2AsResponseAsync(
            string author,
            string slug,
            global::OpenRouter.GetModelV2Region? region = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}