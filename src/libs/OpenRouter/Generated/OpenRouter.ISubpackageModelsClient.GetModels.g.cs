#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageModelsClient
    {
        /// <summary>
        /// List all models and their properties
        /// </summary>
        /// <param name="category">
        /// Filter models by use case category
        /// </param>
        /// <param name="supportedParameters"></param>
        /// <param name="outputModalities"></param>
        /// <param name="sort">
        /// Sort the returned models server-side. Prefer this over fetching the full list and sorting client-side. Options: pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date). When omitted, the existing default ordering is preserved.
        /// </param>
        /// <param name="useRss"></param>
        /// <param name="useRssChatLinks"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ModelsListResponse> GetModelsAsync(
            global::OpenRouter.ModelsGetParametersCategory? category = default,
            string? supportedParameters = default,
            string? outputModalities = default,
            global::OpenRouter.ModelsGetParametersSort? sort = default,
            string? useRss = default,
            string? useRssChatLinks = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all models and their properties
        /// </summary>
        /// <param name="category">
        /// Filter models by use case category
        /// </param>
        /// <param name="supportedParameters"></param>
        /// <param name="outputModalities"></param>
        /// <param name="sort">
        /// Sort the returned models server-side. Prefer this over fetching the full list and sorting client-side. Options: pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date). When omitted, the existing default ordering is preserved.
        /// </param>
        /// <param name="useRss"></param>
        /// <param name="useRssChatLinks"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ModelsListResponse>> GetModelsAsResponseAsync(
            global::OpenRouter.ModelsGetParametersCategory? category = default,
            string? supportedParameters = default,
            string? outputModalities = default,
            global::OpenRouter.ModelsGetParametersSort? sort = default,
            string? useRss = default,
            string? useRssChatLinks = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}