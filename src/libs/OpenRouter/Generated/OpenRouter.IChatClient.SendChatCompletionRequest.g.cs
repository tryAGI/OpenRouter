#nullable enable

namespace OpenRouter
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Create a chat completion<br/>
        /// Sends a request for a model response for the given chat conversation. Supports both streaming and non-streaming modes.
        /// </summary>
        /// <param name="xOpenRouterMetadata">
        /// Opt-in level for surfacing routing metadata on the response under `openrouter_metadata`.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ChatResult> SendChatCompletionRequestAsync(

            global::OpenRouter.ChatRequest request,
            global::OpenRouter.MetadataLevel? xOpenRouterMetadata = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a chat completion<br/>
        /// Sends a request for a model response for the given chat conversation. Supports both streaming and non-streaming modes.
        /// </summary>
        /// <param name="xOpenRouterMetadata">
        /// Opt-in level for surfacing routing metadata on the response under `openrouter_metadata`.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ChatResult>> SendChatCompletionRequestAsResponseAsync(

            global::OpenRouter.ChatRequest request,
            global::OpenRouter.MetadataLevel? xOpenRouterMetadata = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a chat completion<br/>
        /// Sends a request for a model response for the given chat conversation. Supports both streaming and non-streaming modes.
        /// </summary>
        /// <param name="xOpenRouterMetadata">
        /// Opt-in level for surfacing routing metadata on the response under `openrouter_metadata`.
        /// </param>
        /// <param name="cacheControl">
        /// Enable automatic prompt caching. When set at the top level, the system automatically applies cache breakpoints to the last cacheable block in the request. Currently supported for Anthropic Claude models.
        /// </param>
        /// <param name="debug">
        /// Debug options for inspecting request transformations (streaming only)
        /// </param>
        /// <param name="frequencyPenalty">
        /// Frequency penalty (-2.0 to 2.0)
        /// </param>
        /// <param name="imageConfig"></param>
        /// <param name="logitBias">
        /// Token logit bias adjustments
        /// </param>
        /// <param name="logprobs">
        /// Return log probabilities
        /// </param>
        /// <param name="maxCompletionTokens">
        /// Maximum tokens in completion
        /// </param>
        /// <param name="maxTokens">
        /// Maximum tokens (deprecated, use max_completion_tokens). Note: some providers enforce a minimum of 16.
        /// </param>
        /// <param name="messages">
        /// List of messages for the conversation
        /// </param>
        /// <param name="metadata">
        /// Key-value pairs for additional object information (max 16 pairs, 64 char keys, 512 char values)
        /// </param>
        /// <param name="minP">
        /// Minimum probability threshold relative to the most likely token. Tokens with probability below min_p * (probability of top token) are filtered out. Not all providers support this parameter.
        /// </param>
        /// <param name="modalities">
        /// Output modalities for the response. Supported values are "text", "image", and "audio".
        /// </param>
        /// <param name="model">
        /// Model to use for completion
        /// </param>
        /// <param name="models">
        /// Models to use for completion
        /// </param>
        /// <param name="parallelToolCalls">
        /// Whether to enable parallel function calling during tool use. When true, the model may generate multiple tool calls in a single response.
        /// </param>
        /// <param name="plugins">
        /// Plugins you want to enable for this request, including their settings.
        /// </param>
        /// <param name="presencePenalty">
        /// Presence penalty (-2.0 to 2.0)
        /// </param>
        /// <param name="provider">
        /// When multiple model providers are available, optionally indicate your routing preference.
        /// </param>
        /// <param name="reasoning">
        /// Configuration options for reasoning models
        /// </param>
        /// <param name="reasoningEffort">
        /// Shorthand for setting reasoning effort. Equivalent to setting reasoning.effort. Cannot be used simultaneously with reasoning.effort if they differ.
        /// </param>
        /// <param name="repetitionPenalty">
        /// Penalizes tokens based on how much they have already appeared in the text. A value of 1.0 means no penalty. Values above 1.0 penalize repeated tokens more strongly. Not all providers support this parameter.
        /// </param>
        /// <param name="responseFormat">
        /// Response format configuration
        /// </param>
        /// <param name="route">
        /// Any type
        /// </param>
        /// <param name="seed">
        /// Random seed for deterministic outputs
        /// </param>
        /// <param name="serviceTier">
        /// The service tier to use for processing this request.
        /// </param>
        /// <param name="sessionId">
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). When provided, OpenRouter uses it as the sticky routing key, routing all requests in the session to the same provider to maximize prompt cache hits. Also used for observability grouping. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.
        /// </param>
        /// <param name="stop">
        /// Stop sequences (up to 4)
        /// </param>
        /// <param name="stopServerToolsWhen">
        /// Stop conditions for the server-tool agent loop. Any condition firing halts the loop (OR logic). When set, this overrides `max_tool_calls`.
        /// </param>
        /// <param name="stream">
        /// Enable streaming response<br/>
        /// Default Value: false
        /// </param>
        /// <param name="streamOptions">
        /// Streaming configuration options
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature (0-2)
        /// </param>
        /// <param name="toolChoice">
        /// Tool choice configuration
        /// </param>
        /// <param name="tools">
        /// Available tools for function calling
        /// </param>
        /// <param name="topA">
        /// Consider only tokens with "sufficiently high" probabilities based on the probability of the most likely token. Not all providers support this parameter.
        /// </param>
        /// <param name="topK">
        /// Limits the model to choose from the top K most likely tokens at each step. A value of 1 means the model will always pick the most likely next token. Not all providers support this parameter.
        /// </param>
        /// <param name="topLogprobs">
        /// Number of top log probabilities to return (0-20)
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling parameter (0-1)
        /// </param>
        /// <param name="trace">
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.
        /// </param>
        /// <param name="user">
        /// Unique user identifier
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ChatResult> SendChatCompletionRequestAsync(
            global::System.Collections.Generic.IList<global::OpenRouter.ChatMessages> messages,
            global::OpenRouter.MetadataLevel? xOpenRouterMetadata = default,
            global::OpenRouter.AnthropicCacheControlDirective? cacheControl = default,
            global::OpenRouter.ChatDebugOptions? debug = default,
            double? frequencyPenalty = default,
            global::OpenRouter.ImageConfig? imageConfig = default,
            global::System.Collections.Generic.Dictionary<string, double>? logitBias = default,
            bool? logprobs = default,
            int? maxCompletionTokens = default,
            int? maxTokens = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            double? minP = default,
            global::System.Collections.Generic.IList<global::OpenRouter.ChatRequestModalitiesItems>? modalities = default,
            string? model = default,
            global::System.Collections.Generic.IList<string>? models = default,
            bool? parallelToolCalls = default,
            global::System.Collections.Generic.IList<global::OpenRouter.ChatRequestPluginsItems>? plugins = default,
            double? presencePenalty = default,
            global::OpenRouter.ProviderPreferences? provider = default,
            global::OpenRouter.ChatRequestReasoning? reasoning = default,
            global::OpenRouter.OneOf<global::OpenRouter.ChatRequestReasoningEffort?, object>? reasoningEffort = default,
            double? repetitionPenalty = default,
            global::OpenRouter.ChatRequestResponseFormat? responseFormat = default,
            object? route = default,
            int? seed = default,
            global::OpenRouter.OneOf<global::OpenRouter.ChatRequestServiceTier?, object>? serviceTier = default,
            string? sessionId = default,
            global::OpenRouter.ChatRequestStop? stop = default,
            global::System.Collections.Generic.IList<global::OpenRouter.StopServerToolsWhenCondition>? stopServerToolsWhen = default,
            bool? stream = default,
            global::OpenRouter.ChatStreamOptions? streamOptions = default,
            double? temperature = default,
            global::OpenRouter.ChatToolChoice? toolChoice = default,
            global::System.Collections.Generic.IList<global::OpenRouter.ChatFunctionTool>? tools = default,
            double? topA = default,
            int? topK = default,
            int? topLogprobs = default,
            double? topP = default,
            global::OpenRouter.TraceConfig? trace = default,
            string? user = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}