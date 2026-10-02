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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ModelsListResponse> ListForUserAsync(
            int? offset = default,
            int? limit = default,
            string? outputModalities = default,
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ModelsListResponse>> ListForUserAsResponseAsync(
            int? offset = default,
            int? limit = default,
            string? outputModalities = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}