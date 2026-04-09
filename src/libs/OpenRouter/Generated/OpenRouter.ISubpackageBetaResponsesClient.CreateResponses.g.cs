#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageBetaResponsesClient
    {
        /// <summary>
        /// Create a response<br/>
        /// Creates a streaming or non-streaming response using OpenResponses API format
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.OpenResponsesResult> CreateResponsesAsync(

            global::OpenRouter.ResponsesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a response<br/>
        /// Creates a streaming or non-streaming response using OpenResponses API format
        /// </summary>
        /// <param name="background"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="imageConfig">
        /// Provider-specific image configuration options. Keys and values vary by model/provider. See https://openrouter.ai/docs/features/multimodal/image-generation for more details.
        /// </param>
        /// <param name="include"></param>
        /// <param name="input">
        /// Input for a response request - can be a string or array of items
        /// </param>
        /// <param name="instructions"></param>
        /// <param name="maxOutputTokens"></param>
        /// <param name="maxToolCalls"></param>
        /// <param name="metadata">
        /// Metadata key-value pairs for the request. Keys must be ≤64 characters and cannot contain brackets. Values must be ≤512 characters. Maximum 16 pairs allowed.
        /// </param>
        /// <param name="modalities">
        /// Output modalities for the response. Supported values are "text" and "image".
        /// </param>
        /// <param name="model"></param>
        /// <param name="models"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="plugins">
        /// Plugins you want to enable for this request, including their settings.
        /// </param>
        /// <param name="presencePenalty"></param>
        /// <param name="previousResponseId"></param>
        /// <param name="prompt"></param>
        /// <param name="promptCacheKey"></param>
        /// <param name="provider">
        /// When multiple model providers are available, optionally indicate your routing preference.
        /// </param>
        /// <param name="reasoning">
        /// Configuration for reasoning mode in the response
        /// </param>
        /// <param name="route">
        /// Any type
        /// </param>
        /// <param name="safetyIdentifier"></param>
        /// <param name="serviceTier"></param>
        /// <param name="sessionId">
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow) for observability. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.
        /// </param>
        /// <param name="store"></param>
        /// <param name="stream">
        /// Default Value: false
        /// </param>
        /// <param name="temperature"></param>
        /// <param name="text">
        /// Text output configuration including format and verbosity
        /// </param>
        /// <param name="toolChoice"></param>
        /// <param name="tools"></param>
        /// <param name="topK"></param>
        /// <param name="topLogprobs"></param>
        /// <param name="topP"></param>
        /// <param name="trace">
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.
        /// </param>
        /// <param name="truncation"></param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which helps distinguish between different users of your app. This allows your app to identify specific users in case of abuse reports, preventing your entire app from being affected by the actions of individual users. Maximum of 256 characters.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.OpenResponsesResult> CreateResponsesAsync(
            bool? background = default,
            double? frequencyPenalty = default,
            object? imageConfig = default,
            global::System.Collections.Generic.IList<global::OpenRouter.ResponseIncludesEnum>? include = default,
            global::OpenRouter.Inputs? input = default,
            string? instructions = default,
            int? maxOutputTokens = default,
            int? maxToolCalls = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::System.Collections.Generic.IList<global::OpenRouter.OutputModalityEnum>? modalities = default,
            string? model = default,
            global::System.Collections.Generic.IList<string>? models = default,
            bool? parallelToolCalls = default,
            global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestPluginsItems>? plugins = default,
            double? presencePenalty = default,
            string? previousResponseId = default,
            global::OpenRouter.StoredPromptTemplate? prompt = default,
            string? promptCacheKey = default,
            global::OpenRouter.ProviderPreferences? provider = default,
            global::OpenRouter.ReasoningConfig? reasoning = default,
            object? route = default,
            string? safetyIdentifier = default,
            global::OpenRouter.OneOf<global::OpenRouter.ResponsesRequestServiceTier?, object>? serviceTier = default,
            string? sessionId = default,
            bool? store = default,
            bool? stream = default,
            double? temperature = default,
            global::OpenRouter.TextExtendedConfig? text = default,
            global::OpenRouter.OpenAIResponsesToolChoice? toolChoice = default,
            global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestToolsItems>? tools = default,
            int? topK = default,
            int? topLogprobs = default,
            double? topP = default,
            global::OpenRouter.TraceConfig? trace = default,
            global::OpenRouter.OpenAIResponsesTruncation? truncation = default,
            string? user = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}