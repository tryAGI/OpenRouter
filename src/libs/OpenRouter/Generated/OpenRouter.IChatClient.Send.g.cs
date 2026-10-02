#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Create a chat completion<br/>
        /// Sends a request for a model response for the given chat conversation. Supports both streaming and non-streaming modes.
        /// </summary>
        /// <param name="xOpenRouterMetadata">
        /// Opt-in level for surfacing routing metadata on the response under `openrouter_metadata`.<br/>
        /// Example: enabled
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ChatResult> SendAsync(

            global::OpenRouter.ChatRequest request,
            global::OpenRouter.MetadataLevel? xOpenRouterMetadata = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a chat completion<br/>
        /// Sends a request for a model response for the given chat conversation. Supports both streaming and non-streaming modes.
        /// </summary>
        /// <param name="xOpenRouterMetadata">
        /// Opt-in level for surfacing routing metadata on the response under `openrouter_metadata`.<br/>
        /// Example: enabled
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ChatResult>> SendAsResponseAsync(

            global::OpenRouter.ChatRequest request,
            global::OpenRouter.MetadataLevel? xOpenRouterMetadata = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a chat completion<br/>
        /// Sends a request for a model response for the given chat conversation. Supports both streaming and non-streaming modes.
        /// </summary>
        /// <param name="xOpenRouterMetadata">
        /// Opt-in level for surfacing routing metadata on the response under `openrouter_metadata`.<br/>
        /// Example: enabled
        /// </param>
        /// <param name="cacheControl">
        /// Enable automatic prompt caching. When set at the top level, the system automatically applies cache breakpoints to the last cacheable block in the request. When set on an individual content block, it marks an explicit cache breakpoint; block-level markers also work on OpenAI models that support explicit prompt caching — OpenRouter converts them to the provider's native format.<br/>
        /// Example: {"type":"ephemeral"}
        /// </param>
        /// <param name="debug">
        /// Debug options for inspecting request transformations (streaming only)<br/>
        /// Example: {"echo_upstream_body":true}
        /// </param>
        /// <param name="frequencyPenalty">
        /// Frequency penalty (-2.0 to 2.0)<br/>
        /// Example: 0
        /// </param>
        /// <param name="imageConfig">
        /// Provider-specific image configuration options. Keys and values vary by model/provider. See https://openrouter.ai/docs/guides/overview/multimodal/image-generation for more details.<br/>
        /// Example: {"aspect_ratio":"16:9","quality":"high"}
        /// </param>
        /// <param name="logitBias">
        /// Token logit bias adjustments<br/>
        /// Example: {"50256":-100}
        /// </param>
        /// <param name="logprobs">
        /// Return log probabilities<br/>
        /// Example: false
        /// </param>
        /// <param name="maxCompletionTokens">
        /// Maximum tokens in completion<br/>
        /// Example: 100
        /// </param>
        /// <param name="maxTokens">
        /// Maximum tokens (deprecated, use max_completion_tokens). Note: some providers enforce a minimum of 16.<br/>
        /// Example: 100
        /// </param>
        /// <param name="messages">
        /// List of messages for the conversation<br/>
        /// Example: [{"content":"Hello!","role":"user"}]
        /// </param>
        /// <param name="metadata">
        /// Key-value pairs for additional object information (max 16 pairs, 64 char keys, 512 char values)<br/>
        /// Example: {"session_id":"session-456","user_id":"user-123"}
        /// </param>
        /// <param name="minP">
        /// Minimum probability threshold relative to the most likely token. Tokens with probability below min_p * (probability of top token) are filtered out. Not all providers support this parameter.<br/>
        /// Example: 0.1F
        /// </param>
        /// <param name="modalities">
        /// Output modalities for the response. Supported values are "text", "image", and "audio".<br/>
        /// Example: [text, image]
        /// </param>
        /// <param name="model">
        /// Model to use for completion<br/>
        /// Example: openai/gpt-4
        /// </param>
        /// <param name="models">
        /// Models to use for completion<br/>
        /// Example: [openai/gpt-4, openai/gpt-4o]
        /// </param>
        /// <param name="parallelToolCalls">
        /// Whether to enable parallel function calling during tool use. When true, the model may generate multiple tool calls in a single response.<br/>
        /// Example: true
        /// </param>
        /// <param name="plugins">
        /// Plugins you want to enable for this request, including their settings.
        /// </param>
        /// <param name="prediction">
        /// Static predicted output content. Supported models can use this to reduce latency when much of the response is known in advance.<br/>
        /// Example: {"content":"Expected response","type":"content"}
        /// </param>
        /// <param name="presencePenalty">
        /// Presence penalty (-2.0 to 2.0)<br/>
        /// Example: 0
        /// </param>
        /// <param name="promptCacheKey"></param>
        /// <param name="promptCacheOptions">
        /// Request-level prompt-cache controls. `mode: "explicit"` disables OpenAI-managed breakpoints so only blocks marked with `prompt_cache_breakpoint` are cached. Only supported by OpenAI GPT-5.6 and newer.<br/>
        /// Example: {"mode":"explicit","ttl":"30m"}
        /// </param>
        /// <param name="provider">
        /// When multiple model providers are available, optionally indicate your routing preference.<br/>
        /// Example: {"allow_fallbacks":true}
        /// </param>
        /// <param name="reasoning">
        /// Configuration options for reasoning models<br/>
        /// Example: {"effort":"medium","summary":"concise"}
        /// </param>
        /// <param name="reasoningEffort">
        /// Shorthand for setting reasoning effort. Equivalent to setting reasoning.effort. Cannot be used simultaneously with reasoning.effort if they differ.<br/>
        /// Example: medium
        /// </param>
        /// <param name="repetitionPenalty">
        /// Penalizes tokens based on how much they have already appeared in the text. A value of 1.0 means no penalty. Values above 1.0 penalize repeated tokens more strongly. Not all providers support this parameter.<br/>
        /// Example: 1
        /// </param>
        /// <param name="responseFormat">
        /// Response format configuration<br/>
        /// Example: {"type":"json_object"}
        /// </param>
        /// <param name="seed">
        /// Random seed for deterministic outputs<br/>
        /// Example: 42
        /// </param>
        /// <param name="serviceTier">
        /// The service tier to use for processing this request. `fast` is accepted as an alias for `priority`. `ultrafast` prefers ultrafast endpoints and falls back to `priority`, then default endpoints.<br/>
        /// Example: auto
        /// </param>
        /// <param name="sessionId">
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). When provided, OpenRouter uses it as the sticky routing key, routing all requests in the session to the same provider to maximize prompt cache hits. Also used for observability grouping. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.
        /// </param>
        /// <param name="stop">
        /// Stop sequences (up to 4)<br/>
        /// Example: []
        /// </param>
        /// <param name="stopServerToolsWhen">
        /// Stop conditions for the server-tool agent loop. Any condition firing halts the loop (OR logic). When set, this overrides `max_tool_calls`. When a condition fires while the model is still emitting tool calls, the pending tool calls are executed and one final turn is made with tool calls disabled so the response ends with a natural-language answer instead of an unfinished tool call.<br/>
        /// Example: [{"step_count":5,"type":"step_count_is"}, {"max_cost_in_dollars":0.5,"type":"max_cost"}]
        /// </param>
        /// <param name="streamOptions">
        /// Streaming configuration options<br/>
        /// Example: {"include_usage":true}
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature (0-2)<br/>
        /// Example: 0.7F
        /// </param>
        /// <param name="toolChoice">
        /// Tool choice configuration<br/>
        /// Example: auto
        /// </param>
        /// <param name="tools">
        /// Available tools for function calling<br/>
        /// Example: [{"function":{"description":"Get weather","name":"get_weather"},"type":"function"}]
        /// </param>
        /// <param name="topA">
        /// Consider only tokens with "sufficiently high" probabilities based on the probability of the most likely token. Not all providers support this parameter.<br/>
        /// Example: 0
        /// </param>
        /// <param name="topK">
        /// Limits the model to choose from the top K most likely tokens at each step. A value of 1 means the model will always pick the most likely next token. Not all providers support this parameter.<br/>
        /// Example: 40
        /// </param>
        /// <param name="topLogprobs">
        /// Number of top log probabilities to return (0-20)<br/>
        /// Example: 5
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling parameter (0-1)<br/>
        /// Example: 1
        /// </param>
        /// <param name="trace">
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.<br/>
        /// Example: {"trace_id":"trace-abc123","trace_name":"my-app-trace"}
        /// </param>
        /// <param name="user">
        /// Per-end-user identifier for abuse isolation. Use a stable ID, hash, or pseudonym. When a provider requires a user identity, OpenRouter folds it into the hashed identity sent upstream and never forwards it raw. If omitted, requests use an account-level identity, so provider policy blocks can affect the whole account.<br/>
        /// Example: user-123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ChatResult> SendAsync(
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
            global::System.Collections.Generic.IList<global::OpenRouter.ChatRequestModalitie>? modalities = default,
            string? model = default,
            global::System.Collections.Generic.IList<global::OpenRouter.AllOf<string, object>>? models = default,
            bool? parallelToolCalls = default,
            global::System.Collections.Generic.IList<global::OpenRouter.PluginsItem>? plugins = default,
            global::OpenRouter.Prediction? prediction = default,
            double? presencePenalty = default,
            string? promptCacheKey = default,
            global::OpenRouter.PromptCacheOptions? promptCacheOptions = default,
            global::OpenRouter.ProviderPreferences? provider = default,
            global::OpenRouter.ChatRequestReasoning? reasoning = default,
            global::OpenRouter.ChatRequestReasoningEffort2? reasoningEffort = default,
            double? repetitionPenalty = default,
            global::OpenRouter.ResponseFormat? responseFormat = default,
            int? seed = default,
            global::OpenRouter.ChatRequestServiceTier? serviceTier = default,
            string? sessionId = default,
            global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? stop = default,
            global::System.Collections.Generic.IList<global::OpenRouter.StopServerToolsWhenCondition>? stopServerToolsWhen = default,
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