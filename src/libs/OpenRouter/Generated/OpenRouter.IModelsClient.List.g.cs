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
        /// Sort the returned models server-side. Prefer this over fetching the full list and sorting client-side. Options: pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), &lt;index&gt;-high-to-low for each Artificial Analysis index (the coding and agentic sorts are deprecated: Artificial Analysis has retired those indexes, so they order by canonical slug and variant alone), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. The decision sort ranks decision models, so pass output_modalities=decisions or all with it. When omitted, the existing default ordering is preserved.<br/>
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
        /// <param name="endpoints">
        /// Filter models by the request API paths they serve, as listed in each model's `endpoints` field. Comma-separated; a model must serve every listed path. Valid values: /api/v1/chat/completions, /api/v1/completions, /api/v1/messages, /api/v1/responses, /api/v1/embeddings, /api/v1/rerank, /api/alpha/decisions, /api/alpha/extractions, /api/v1/videos, /api/v1/audio/speech, /api/v1/audio/transcriptions, /api/v1/images, /api/v1/batches. When set without `output_modalities`, models of every output modality are considered (the companion `/api/alpha/extractions` route is served by text and decisions models alike).<br/>
        /// Example: /api/alpha/extractions
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
        /// Minimum Artificial Analysis Intelligence Index score (0-100); unscored models are excluded.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxIntelligenceIndex">
        /// Maximum Artificial Analysis Intelligence Index score (0-100); unscored models are excluded.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minCodingIndex">
        /// Deprecated: Artificial Analysis has retired its Coding Index; no model has a score, so this matches no model.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxCodingIndex">
        /// Deprecated: Artificial Analysis has retired its Coding Index; no model has a score, so this matches no model.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minAgenticIndex">
        /// Deprecated: Artificial Analysis has retired its Agentic Index; no model has a score, so this matches no model.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxAgenticIndex">
        /// Deprecated: Artificial Analysis has retired its Agentic Index; no model has a score, so this matches no model.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minFinanceAndAccountingIndex">
        /// Minimum Artificial Analysis Finance &amp; Accounting Index score (0-100); unscored models are excluded.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxFinanceAndAccountingIndex">
        /// Maximum Artificial Analysis Finance &amp; Accounting Index score (0-100); unscored models are excluded.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minStrategyAndOpsIndex">
        /// Minimum Artificial Analysis Strategy &amp; Ops Index score (0-100); unscored models are excluded.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxStrategyAndOpsIndex">
        /// Maximum Artificial Analysis Strategy &amp; Ops Index score (0-100); unscored models are excluded.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minLegalIndex">
        /// Minimum Artificial Analysis Legal Index score (0-100); unscored models are excluded.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxLegalIndex">
        /// Maximum Artificial Analysis Legal Index score (0-100); unscored models are excluded.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minHealthcareAndMedicalIndex">
        /// Minimum Artificial Analysis Healthcare &amp; Medical Index score (0-100); unscored models are excluded.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxHealthcareAndMedicalIndex">
        /// Maximum Artificial Analysis Healthcare &amp; Medical Index score (0-100); unscored models are excluded.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minEngineeringIndex">
        /// Minimum Artificial Analysis Engineering Index score (0-100); unscored models are excluded.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxEngineeringIndex">
        /// Maximum Artificial Analysis Engineering Index score (0-100); unscored models are excluded.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minEconomicsIndex">
        /// Minimum Artificial Analysis Economics Index score (0-100); unscored models are excluded.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxEconomicsIndex">
        /// Maximum Artificial Analysis Economics Index score (0-100); unscored models are excluded.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minCyberIndex">
        /// Minimum Artificial Analysis Cyber Index score (0-100); unscored models are excluded.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxCyberIndex">
        /// Maximum Artificial Analysis Cyber Index score (0-100); unscored models are excluded.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minOpennessIndex">
        /// Minimum Artificial Analysis Openness Index score (0-100); unscored models are excluded.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxOpennessIndex">
        /// Maximum Artificial Analysis Openness Index score (0-100); unscored models are excluded.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minMultilingualIndex">
        /// Minimum Artificial Analysis Multilingual Index score (0-1); unscored models are excluded.<br/>
        /// Example: 0.5F
        /// </param>
        /// <param name="maxMultilingualIndex">
        /// Maximum Artificial Analysis Multilingual Index score (0-1); unscored models are excluded.<br/>
        /// Example: 1
        /// </param>
        /// <param name="minDecisionIndex">
        /// Minimum Artificial Analysis Decision Index score (0-100); unscored models are excluded.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxDecisionIndex">
        /// Maximum Artificial Analysis Decision Index score (0-100); unscored models are excluded.<br/>
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
            string? endpoints = default,
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
            double? minFinanceAndAccountingIndex = default,
            double? maxFinanceAndAccountingIndex = default,
            double? minStrategyAndOpsIndex = default,
            double? maxStrategyAndOpsIndex = default,
            double? minLegalIndex = default,
            double? maxLegalIndex = default,
            double? minHealthcareAndMedicalIndex = default,
            double? maxHealthcareAndMedicalIndex = default,
            double? minEngineeringIndex = default,
            double? maxEngineeringIndex = default,
            double? minEconomicsIndex = default,
            double? maxEconomicsIndex = default,
            double? minCyberIndex = default,
            double? maxCyberIndex = default,
            double? minOpennessIndex = default,
            double? maxOpennessIndex = default,
            double? minMultilingualIndex = default,
            double? maxMultilingualIndex = default,
            double? minDecisionIndex = default,
            double? maxDecisionIndex = default,
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
        /// Sort the returned models server-side. Prefer this over fetching the full list and sorting client-side. Options: pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), &lt;index&gt;-high-to-low for each Artificial Analysis index (the coding and agentic sorts are deprecated: Artificial Analysis has retired those indexes, so they order by canonical slug and variant alone), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. The decision sort ranks decision models, so pass output_modalities=decisions or all with it. When omitted, the existing default ordering is preserved.<br/>
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
        /// <param name="endpoints">
        /// Filter models by the request API paths they serve, as listed in each model's `endpoints` field. Comma-separated; a model must serve every listed path. Valid values: /api/v1/chat/completions, /api/v1/completions, /api/v1/messages, /api/v1/responses, /api/v1/embeddings, /api/v1/rerank, /api/alpha/decisions, /api/alpha/extractions, /api/v1/videos, /api/v1/audio/speech, /api/v1/audio/transcriptions, /api/v1/images, /api/v1/batches. When set without `output_modalities`, models of every output modality are considered (the companion `/api/alpha/extractions` route is served by text and decisions models alike).<br/>
        /// Example: /api/alpha/extractions
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
        /// Minimum Artificial Analysis Intelligence Index score (0-100); unscored models are excluded.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxIntelligenceIndex">
        /// Maximum Artificial Analysis Intelligence Index score (0-100); unscored models are excluded.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minCodingIndex">
        /// Deprecated: Artificial Analysis has retired its Coding Index; no model has a score, so this matches no model.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxCodingIndex">
        /// Deprecated: Artificial Analysis has retired its Coding Index; no model has a score, so this matches no model.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minAgenticIndex">
        /// Deprecated: Artificial Analysis has retired its Agentic Index; no model has a score, so this matches no model.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxAgenticIndex">
        /// Deprecated: Artificial Analysis has retired its Agentic Index; no model has a score, so this matches no model.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minFinanceAndAccountingIndex">
        /// Minimum Artificial Analysis Finance &amp; Accounting Index score (0-100); unscored models are excluded.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxFinanceAndAccountingIndex">
        /// Maximum Artificial Analysis Finance &amp; Accounting Index score (0-100); unscored models are excluded.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minStrategyAndOpsIndex">
        /// Minimum Artificial Analysis Strategy &amp; Ops Index score (0-100); unscored models are excluded.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxStrategyAndOpsIndex">
        /// Maximum Artificial Analysis Strategy &amp; Ops Index score (0-100); unscored models are excluded.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minLegalIndex">
        /// Minimum Artificial Analysis Legal Index score (0-100); unscored models are excluded.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxLegalIndex">
        /// Maximum Artificial Analysis Legal Index score (0-100); unscored models are excluded.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minHealthcareAndMedicalIndex">
        /// Minimum Artificial Analysis Healthcare &amp; Medical Index score (0-100); unscored models are excluded.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxHealthcareAndMedicalIndex">
        /// Maximum Artificial Analysis Healthcare &amp; Medical Index score (0-100); unscored models are excluded.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minEngineeringIndex">
        /// Minimum Artificial Analysis Engineering Index score (0-100); unscored models are excluded.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxEngineeringIndex">
        /// Maximum Artificial Analysis Engineering Index score (0-100); unscored models are excluded.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minEconomicsIndex">
        /// Minimum Artificial Analysis Economics Index score (0-100); unscored models are excluded.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxEconomicsIndex">
        /// Maximum Artificial Analysis Economics Index score (0-100); unscored models are excluded.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minCyberIndex">
        /// Minimum Artificial Analysis Cyber Index score (0-100); unscored models are excluded.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxCyberIndex">
        /// Maximum Artificial Analysis Cyber Index score (0-100); unscored models are excluded.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minOpennessIndex">
        /// Minimum Artificial Analysis Openness Index score (0-100); unscored models are excluded.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxOpennessIndex">
        /// Maximum Artificial Analysis Openness Index score (0-100); unscored models are excluded.<br/>
        /// Example: 100
        /// </param>
        /// <param name="minMultilingualIndex">
        /// Minimum Artificial Analysis Multilingual Index score (0-1); unscored models are excluded.<br/>
        /// Example: 0.5F
        /// </param>
        /// <param name="maxMultilingualIndex">
        /// Maximum Artificial Analysis Multilingual Index score (0-1); unscored models are excluded.<br/>
        /// Example: 1
        /// </param>
        /// <param name="minDecisionIndex">
        /// Minimum Artificial Analysis Decision Index score (0-100); unscored models are excluded.<br/>
        /// Example: 50
        /// </param>
        /// <param name="maxDecisionIndex">
        /// Maximum Artificial Analysis Decision Index score (0-100); unscored models are excluded.<br/>
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
            string? endpoints = default,
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
            double? minFinanceAndAccountingIndex = default,
            double? maxFinanceAndAccountingIndex = default,
            double? minStrategyAndOpsIndex = default,
            double? maxStrategyAndOpsIndex = default,
            double? minLegalIndex = default,
            double? maxLegalIndex = default,
            double? minHealthcareAndMedicalIndex = default,
            double? maxHealthcareAndMedicalIndex = default,
            double? minEngineeringIndex = default,
            double? maxEngineeringIndex = default,
            double? minEconomicsIndex = default,
            double? maxEconomicsIndex = default,
            double? minCyberIndex = default,
            double? maxCyberIndex = default,
            double? minOpennessIndex = default,
            double? maxOpennessIndex = default,
            double? minMultilingualIndex = default,
            double? maxMultilingualIndex = default,
            double? minDecisionIndex = default,
            double? maxDecisionIndex = default,
            double? minToolSuccessRate = default,
            double? maxToolSuccessRate = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}