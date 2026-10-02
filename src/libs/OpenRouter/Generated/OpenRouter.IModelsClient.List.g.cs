#nullable enable

namespace OpenRouter
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List all models and their properties
        /// </summary>
        /// <param name="offset">
        /// Number of records to skip for pagination. When both offset and limit are omitted, the full list is returned<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="limit">
        /// Maximum number of records to return (max 1000). When both offset and limit are omitted, the full list is returned<br/>
        /// Default Value: 500<br/>
        /// Example: 500
        /// </param>
        /// <param name="category">
        /// Filter models by use case category<br/>
        /// Example: programming
        /// </param>
        /// <param name="supportedParameters">
        /// Filter models by supported parameter (comma-separated)<br/>
        /// Example: temperature
        /// </param>
        /// <param name="outputModalities">
        /// Filter models by output modality. Accepts a comma-separated list of modalities (text, image, embeddings, audio, video, rerank, decisions, speech, transcription) or "all" to include all models. Defaults to "text".<br/>
        /// Example: text
        /// </param>
        /// <param name="sort">
        /// Sort the returned models server-side. Prefer this over fetching the full list and sorting client-side. Options: pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low, coding-high-to-low, agentic-high-to-low (Artificial Analysis indices), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.<br/>
        /// Example: newest
        /// </param>
        /// <param name="q">
        /// Free-text search by model name or slug.<br/>
        /// Example: gpt-4
        /// </param>
        /// <param name="inputModalities">
        /// Filter models by input modality. Comma-separated list of: text, image, audio, file.<br/>
        /// Example: text,image
        /// </param>
        /// <param name="context">
        /// Minimum context length (tokens). Models with smaller context are excluded.<br/>
        /// Example: 128000
        /// </param>
        /// <param name="minPrice">
        /// Minimum prompt price in $/M tokens.<br/>
        /// Example: 0
        /// </param>
        /// <param name="maxPrice">
        /// Maximum prompt price in $/M tokens.<br/>
        /// Example: 10
        /// </param>
        /// <param name="arch">
        /// Filter models by architecture/model family (e.g. GPT, Claude, Gemini, Llama).<br/>
        /// Example: GPT
        /// </param>
        /// <param name="modelAuthors">
        /// Filter models by the organization that created the model. Comma-separated list of author slugs.<br/>
        /// Example: openai,anthropic
        /// </param>
        /// <param name="providers">
        /// Filter models by hosting provider. Comma-separated list of provider names.<br/>
        /// Example: OpenAI,Anthropic
        /// </param>
        /// <param name="distillable">
        /// Filter by distillation capability. "true" returns only distillable models, "false" excludes them.<br/>
        /// Example: true
        /// </param>
        /// <param name="zdr">
        /// When set to "true", return only models with zero data retention endpoints.<br/>
        /// Example: true
        /// </param>
        /// <param name="region">
        /// Filter to models with endpoints in the given data region ("eu" or "us").<br/>
        /// Example: eu
        /// </param>
        /// <param name="minOutputPrice">
        /// Minimum completion (output) price in $/M tokens.<br/>
        /// Example: 0
        /// </param>
        /// <param name="maxOutputPrice">
        /// Maximum completion (output) price in $/M tokens.<br/>
        /// Example: 10
        /// </param>
        /// <param name="minAgeDays">
        /// Minimum model age in days since its creation date.<br/>
        /// Example: 0
        /// </param>
        /// <param name="maxAgeDays">
        /// Maximum model age in days since its creation date.<br/>
        /// Example: 90
        /// </param>
        /// <param name="minIntelligenceIndex">
        /// Minimum Artificial Analysis intelligence index.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxIntelligenceIndex">
        /// Maximum Artificial Analysis intelligence index.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minCodingIndex">
        /// Minimum Artificial Analysis coding index.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxCodingIndex">
        /// Maximum Artificial Analysis coding index.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minAgenticIndex">
        /// Minimum Artificial Analysis agentic index.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxAgenticIndex">
        /// Maximum Artificial Analysis agentic index.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minToolSuccessRate">
        /// Minimum tool-calling success rate, as a fraction in [0, 1] (e.g. 0.9 = 90% of requests finishing with a tool_calls finish reason).<br/>
        /// Example: 0.9F
        /// </param>
        /// <param name="maxToolSuccessRate">
        /// Maximum tool-calling success rate, as a fraction in [0, 1].<br/>
        /// Example: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ModelsListResponse> ListAsync(
            int? offset = default,
            int? limit = default,
            global::OpenRouter.GetModelsCategory? category = default,
            string? supportedParameters = default,
            string? outputModalities = default,
            global::OpenRouter.GetModelsSort? sort = default,
            string? q = default,
            string? inputModalities = default,
            int? context = default,
            double? minPrice = default,
            double? maxPrice = default,
            string? arch = default,
            string? modelAuthors = default,
            string? providers = default,
            global::OpenRouter.GetModelsDistillable? distillable = default,
            global::OpenRouter.GetModelsZdr? zdr = default,
            global::OpenRouter.GetModelsRegion? region = default,
            double? minOutputPrice = default,
            double? maxOutputPrice = default,
            int? minAgeDays = default,
            int? maxAgeDays = default,
            double? minIntelligenceIndex = default,
            double? maxIntelligenceIndex = default,
            double? minCodingIndex = default,
            double? maxCodingIndex = default,
            double? minAgenticIndex = default,
            double? maxAgenticIndex = default,
            double? minToolSuccessRate = default,
            double? maxToolSuccessRate = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all models and their properties
        /// </summary>
        /// <param name="offset">
        /// Number of records to skip for pagination. When both offset and limit are omitted, the full list is returned<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="limit">
        /// Maximum number of records to return (max 1000). When both offset and limit are omitted, the full list is returned<br/>
        /// Default Value: 500<br/>
        /// Example: 500
        /// </param>
        /// <param name="category">
        /// Filter models by use case category<br/>
        /// Example: programming
        /// </param>
        /// <param name="supportedParameters">
        /// Filter models by supported parameter (comma-separated)<br/>
        /// Example: temperature
        /// </param>
        /// <param name="outputModalities">
        /// Filter models by output modality. Accepts a comma-separated list of modalities (text, image, embeddings, audio, video, rerank, decisions, speech, transcription) or "all" to include all models. Defaults to "text".<br/>
        /// Example: text
        /// </param>
        /// <param name="sort">
        /// Sort the returned models server-side. Prefer this over fetching the full list and sorting client-side. Options: pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low, coding-high-to-low, agentic-high-to-low (Artificial Analysis indices), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.<br/>
        /// Example: newest
        /// </param>
        /// <param name="q">
        /// Free-text search by model name or slug.<br/>
        /// Example: gpt-4
        /// </param>
        /// <param name="inputModalities">
        /// Filter models by input modality. Comma-separated list of: text, image, audio, file.<br/>
        /// Example: text,image
        /// </param>
        /// <param name="context">
        /// Minimum context length (tokens). Models with smaller context are excluded.<br/>
        /// Example: 128000
        /// </param>
        /// <param name="minPrice">
        /// Minimum prompt price in $/M tokens.<br/>
        /// Example: 0
        /// </param>
        /// <param name="maxPrice">
        /// Maximum prompt price in $/M tokens.<br/>
        /// Example: 10
        /// </param>
        /// <param name="arch">
        /// Filter models by architecture/model family (e.g. GPT, Claude, Gemini, Llama).<br/>
        /// Example: GPT
        /// </param>
        /// <param name="modelAuthors">
        /// Filter models by the organization that created the model. Comma-separated list of author slugs.<br/>
        /// Example: openai,anthropic
        /// </param>
        /// <param name="providers">
        /// Filter models by hosting provider. Comma-separated list of provider names.<br/>
        /// Example: OpenAI,Anthropic
        /// </param>
        /// <param name="distillable">
        /// Filter by distillation capability. "true" returns only distillable models, "false" excludes them.<br/>
        /// Example: true
        /// </param>
        /// <param name="zdr">
        /// When set to "true", return only models with zero data retention endpoints.<br/>
        /// Example: true
        /// </param>
        /// <param name="region">
        /// Filter to models with endpoints in the given data region ("eu" or "us").<br/>
        /// Example: eu
        /// </param>
        /// <param name="minOutputPrice">
        /// Minimum completion (output) price in $/M tokens.<br/>
        /// Example: 0
        /// </param>
        /// <param name="maxOutputPrice">
        /// Maximum completion (output) price in $/M tokens.<br/>
        /// Example: 10
        /// </param>
        /// <param name="minAgeDays">
        /// Minimum model age in days since its creation date.<br/>
        /// Example: 0
        /// </param>
        /// <param name="maxAgeDays">
        /// Maximum model age in days since its creation date.<br/>
        /// Example: 90
        /// </param>
        /// <param name="minIntelligenceIndex">
        /// Minimum Artificial Analysis intelligence index.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxIntelligenceIndex">
        /// Maximum Artificial Analysis intelligence index.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minCodingIndex">
        /// Minimum Artificial Analysis coding index.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxCodingIndex">
        /// Maximum Artificial Analysis coding index.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minAgenticIndex">
        /// Minimum Artificial Analysis agentic index.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxAgenticIndex">
        /// Maximum Artificial Analysis agentic index.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minToolSuccessRate">
        /// Minimum tool-calling success rate, as a fraction in [0, 1] (e.g. 0.9 = 90% of requests finishing with a tool_calls finish reason).<br/>
        /// Example: 0.9F
        /// </param>
        /// <param name="maxToolSuccessRate">
        /// Maximum tool-calling success rate, as a fraction in [0, 1].<br/>
        /// Example: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ModelsListResponse>> ListAsResponseAsync(
            int? offset = default,
            int? limit = default,
            global::OpenRouter.GetModelsCategory? category = default,
            string? supportedParameters = default,
            string? outputModalities = default,
            global::OpenRouter.GetModelsSort? sort = default,
            string? q = default,
            string? inputModalities = default,
            int? context = default,
            double? minPrice = default,
            double? maxPrice = default,
            string? arch = default,
            string? modelAuthors = default,
            string? providers = default,
            global::OpenRouter.GetModelsDistillable? distillable = default,
            global::OpenRouter.GetModelsZdr? zdr = default,
            global::OpenRouter.GetModelsRegion? region = default,
            double? minOutputPrice = default,
            double? maxOutputPrice = default,
            int? minAgeDays = default,
            int? maxAgeDays = default,
            double? minIntelligenceIndex = default,
            double? maxIntelligenceIndex = default,
            double? minCodingIndex = default,
            double? maxCodingIndex = default,
            double? minAgenticIndex = default,
            double? maxAgenticIndex = default,
            double? minToolSuccessRate = default,
            double? maxToolSuccessRate = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}