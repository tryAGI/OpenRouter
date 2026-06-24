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
        /// Sort the returned models server-side. Prefer this over fetching the full list and sorting client-side. Options: pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low (Artificial Analysis intelligence index), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.
        /// </param>
        /// <param name="useRss"></param>
        /// <param name="useRssChatLinks"></param>
        /// <param name="q"></param>
        /// <param name="inputModalities"></param>
        /// <param name="context"></param>
        /// <param name="minPrice"></param>
        /// <param name="maxPrice"></param>
        /// <param name="arch"></param>
        /// <param name="modelAuthors"></param>
        /// <param name="providers"></param>
        /// <param name="distillable">
        /// Filter by distillation capability. "true" returns only distillable models, "false" excludes them.
        /// </param>
        /// <param name="zdr">
        /// When set to "true", return only models with zero data retention endpoints.
        /// </param>
        /// <param name="region">
        /// Filter to models with endpoints in the given data region. Currently only "eu" is supported.
        /// </param>
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
            string? q = default,
            string? inputModalities = default,
            int? context = default,
            double? minPrice = default,
            double? maxPrice = default,
            string? arch = default,
            string? modelAuthors = default,
            string? providers = default,
            global::OpenRouter.ModelsGetParametersDistillable? distillable = default,
            global::OpenRouter.ModelsGetParametersZdr? zdr = default,
            global::OpenRouter.ModelsGetParametersRegion? region = default,
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
        /// Sort the returned models server-side. Prefer this over fetching the full list and sorting client-side. Options: pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low (Artificial Analysis intelligence index), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.
        /// </param>
        /// <param name="useRss"></param>
        /// <param name="useRssChatLinks"></param>
        /// <param name="q"></param>
        /// <param name="inputModalities"></param>
        /// <param name="context"></param>
        /// <param name="minPrice"></param>
        /// <param name="maxPrice"></param>
        /// <param name="arch"></param>
        /// <param name="modelAuthors"></param>
        /// <param name="providers"></param>
        /// <param name="distillable">
        /// Filter by distillation capability. "true" returns only distillable models, "false" excludes them.
        /// </param>
        /// <param name="zdr">
        /// When set to "true", return only models with zero data retention endpoints.
        /// </param>
        /// <param name="region">
        /// Filter to models with endpoints in the given data region. Currently only "eu" is supported.
        /// </param>
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
            string? q = default,
            string? inputModalities = default,
            int? context = default,
            double? minPrice = default,
            double? maxPrice = default,
            string? arch = default,
            string? modelAuthors = default,
            string? providers = default,
            global::OpenRouter.ModelsGetParametersDistillable? distillable = default,
            global::OpenRouter.ModelsGetParametersZdr? zdr = default,
            global::OpenRouter.ModelsGetParametersRegion? region = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}