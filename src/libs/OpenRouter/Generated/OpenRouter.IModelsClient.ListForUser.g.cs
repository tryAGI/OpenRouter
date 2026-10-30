#nullable enable

namespace OpenRouter
{
    public partial interface IModelsClient
    {
        /// <summary>
        /// List models filtered by user provider preferences, privacy settings, and guardrails<br/>
        /// List models filtered by user provider preferences, [privacy settings](https://openrouter.ai/docs/guides/privacy/provider-logging), and [guardrails](https://openrouter.ai/docs/guides/features/guardrails). Returns text-output models by default; pass `output_modalities` (a comma-separated list of `text`, `image`, `embeddings`, `audio`, `video`, `rerank`, `speech`, `transcription`, or `all`) to include other modalities. If requesting through a regional hostname, the results will be filtered to models that satisfy in-region routing for that region.
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
        /// <param name="outputModalities">
        /// Filter models by output modality. Accepts a comma-separated list of modalities (text, image, embeddings, audio, video, rerank, decisions, speech, transcription) or "all" to include all models. Defaults to "text".<br/>
        /// Example: text
        /// </param>
        /// <param name="sort">
        /// Sort the returned models server-side. Prefer this over fetching the full list and sorting client-side. Options: pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low, coding-high-to-low, agentic-high-to-low (Artificial Analysis indices), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.<br/>
        /// Example: newest
        /// </param>
        /// <param name="client">
        /// Return only the models and presets the named harness offers: those that support tool calling, and, when one of your guardrails sets `enforce_first_party_harness_models`, only the harness vendor's own models (OpenAI for codex, Anthropic for claude_code and claude_desktop). One of: claude_code, claude_desktop, codex. Omit it to get every model you can use.<br/>
        /// Example: codex
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ModelsListResponse> ListForUserAsync(
            int? offset = default,
            int? limit = default,
            string? outputModalities = default,
            global::OpenRouter.ListModelsUserSort? sort = default,
            global::OpenRouter.ListModelsUserClient? client = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List models filtered by user provider preferences, privacy settings, and guardrails<br/>
        /// List models filtered by user provider preferences, [privacy settings](https://openrouter.ai/docs/guides/privacy/provider-logging), and [guardrails](https://openrouter.ai/docs/guides/features/guardrails). Returns text-output models by default; pass `output_modalities` (a comma-separated list of `text`, `image`, `embeddings`, `audio`, `video`, `rerank`, `speech`, `transcription`, or `all`) to include other modalities. If requesting through a regional hostname, the results will be filtered to models that satisfy in-region routing for that region.
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
        /// <param name="outputModalities">
        /// Filter models by output modality. Accepts a comma-separated list of modalities (text, image, embeddings, audio, video, rerank, decisions, speech, transcription) or "all" to include all models. Defaults to "text".<br/>
        /// Example: text
        /// </param>
        /// <param name="sort">
        /// Sort the returned models server-side. Prefer this over fetching the full list and sorting client-side. Options: pricing-low-to-high, pricing-high-to-low (average prompt/completion price), context-high-to-low (context length), throughput-high-to-low, latency-low-to-high (recent median performance), most-popular, top-weekly (tokens processed in the last week), newest (creation date), intelligence-high-to-low, coding-high-to-low, agentic-high-to-low (Artificial Analysis indices), design-arena-elo-high-to-low (best Design Arena ELO across arenas). Models without a score for the chosen benchmark are placed last. When omitted, the existing default ordering is preserved.<br/>
        /// Example: newest
        /// </param>
        /// <param name="client">
        /// Return only the models and presets the named harness offers: those that support tool calling, and, when one of your guardrails sets `enforce_first_party_harness_models`, only the harness vendor's own models (OpenAI for codex, Anthropic for claude_code and claude_desktop). One of: claude_code, claude_desktop, codex. Omit it to get every model you can use.<br/>
        /// Example: codex
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ModelsListResponse>> ListForUserAsResponseAsync(
            int? offset = default,
            int? limit = default,
            string? outputModalities = default,
            global::OpenRouter.ListModelsUserSort? sort = default,
            global::OpenRouter.ListModelsUserClient? client = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}