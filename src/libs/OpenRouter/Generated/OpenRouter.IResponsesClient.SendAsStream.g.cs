#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Create a response<br/>
        /// Creates a streaming or non-streaming response using OpenResponses API format
        /// </summary>
        /// <param name="xOpenRouterMetadata">
        /// Opt-in level for surfacing routing metadata on the response under `openrouter_metadata`.<br/>
        /// Example: enabled
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::OpenRouter.ResponsesStreamingResponse> SendAsStreamAsync(

            global::OpenRouter.ResponsesRequest request,
            global::OpenRouter.MetadataLevel? xOpenRouterMetadata = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a response<br/>
        /// Creates a streaming or non-streaming response using OpenResponses API format
        /// </summary>
        /// <param name="xOpenRouterMetadata">
        /// Opt-in level for surfacing routing metadata on the response under `openrouter_metadata`.<br/>
        /// Example: enabled
        /// </param>
        /// <param name="background"></param>
        /// <param name="cacheControl">
        /// Enable automatic prompt caching. When set at the top level, the system automatically applies cache breakpoints to the last cacheable block in the request. When set on an individual content block, it marks an explicit cache breakpoint; block-level markers also work on OpenAI models that support explicit prompt caching — OpenRouter converts them to the provider's native format.<br/>
        /// Example: {"type":"ephemeral"}
        /// </param>
        /// <param name="debug">
        /// Debug options for inspecting request transformations (streaming only)<br/>
        /// Example: {"echo_upstream_body":true}
        /// </param>
        /// <param name="deferredTools">
        /// Opt-in versioned router-level deferred-tool protocol. Replay assistant reasoning unchanged on continuation; keep the catalog unchanged.<br/>
        /// Example: {"profile":"portable","protocol":"v1","search":{"max_results":5,"type":"bm25"},"validation":"runtime"}
        /// </param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="imageConfig">
        /// Provider-specific image configuration options. Keys and values vary by model/provider. See https://openrouter.ai/docs/guides/overview/multimodal/image-generation for more details.<br/>
        /// Example: {"aspect_ratio":"16:9","quality":"high"}
        /// </param>
        /// <param name="include"></param>
        /// <param name="input">
        /// Input for a response request - can be a string or array of items<br/>
        /// Example: [{"content":"What is the weather today?","role":"user"}]
        /// </param>
        /// <param name="instructions"></param>
        /// <param name="maxOutputTokens"></param>
        /// <param name="maxToolCalls">
        /// Maximum number of server-tool (e.g. `openrouter:web_search`) agent steps the model may take during a request. Defaults to 30, which is also the maximum. Ignored when `stop_server_tools_when` is set.<br/>
        /// Example: 30
        /// </param>
        /// <param name="metadata">
        /// Metadata key-value pairs for the request. Keys must be ≤64 characters and cannot contain brackets. Values must be ≤512 characters. Maximum 16 pairs allowed.<br/>
        /// Example: {"session_id":"abc-def-ghi","user_id":"123"}
        /// </param>
        /// <param name="modalities">
        /// Output modalities for the response. Supported values are "text" and "image".<br/>
        /// Example: [text, image]
        /// </param>
        /// <param name="model"></param>
        /// <param name="models"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="plugins">
        /// Plugins you want to enable for this request, including their settings.
        /// </param>
        /// <param name="presencePenalty"></param>
        /// <param name="previousResponseId">
        /// Not supported on this proxy. Each response request is independent: no responses are stored, so a previous response cannot be referenced. Requests with a non-null value are rejected with a 400 error. Send the full conversation history in `input` instead.
        /// </param>
        /// <param name="prompt">
        /// Example: {"id":"prompt-abc123","variables":{"name":"John"}}
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
        /// Configuration for reasoning mode in the response<br/>
        /// Example: {"enabled":true,"summary":"auto"}
        /// </param>
        /// <param name="safetyIdentifier">
        /// Recommended per-end-user identifier for abuse isolation. Use a stable ID, hash, or pseudonym. When a provider requires a user identity, OpenRouter folds it into the hashed identity sent upstream and never forwards it raw. If omitted, requests use an account-level identity, so provider policy blocks can affect the whole account.<br/>
        /// Example: user-123
        /// </param>
        /// <param name="serviceTier">
        /// The service tier to use for processing this request. `fast` is accepted as an alias for `priority`. `ultrafast` prefers ultrafast endpoints and falls back to `priority`, then default endpoints.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="sessionId">
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). When provided, OpenRouter uses it as the sticky routing key, routing all requests in the session to the same provider to maximize prompt cache hits. Also used for observability grouping. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.
        /// </param>
        /// <param name="stopServerToolsWhen">
        /// Stop conditions for the server-tool agent loop. Any condition firing halts the loop (OR logic). When set, this overrides `max_tool_calls`. When a condition fires while the model is still emitting tool calls, the pending tool calls are executed and one final turn is made with tool calls disabled so the response ends with a natural-language answer instead of an unfinished tool call.<br/>
        /// Example: [{"step_count":5,"type":"step_count_is"}, {"max_cost_in_dollars":0.5,"type":"max_cost"}]
        /// </param>
        /// <param name="store">
        /// Default Value: false
        /// </param>
        /// <param name="temperature"></param>
        /// <param name="text">
        /// Text output configuration including format and verbosity<br/>
        /// Example: {"format":{"type":"text"}}
        /// </param>
        /// <param name="toolChoice">
        /// Example: auto
        /// </param>
        /// <param name="tools"></param>
        /// <param name="topK"></param>
        /// <param name="topLogprobs"></param>
        /// <param name="topP"></param>
        /// <param name="trace">
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.<br/>
        /// Example: {"trace_id":"trace-abc123","trace_name":"my-app-trace"}
        /// </param>
        /// <param name="truncation">
        /// Example: auto
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which helps distinguish between different users of your app. This allows your app to identify specific users in case of abuse reports, preventing your entire app from being affected by the actions of individual users. Maximum of 256 characters.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::OpenRouter.ResponsesStreamingResponse> SendAsStreamAsync(
            global::OpenRouter.MetadataLevel? xOpenRouterMetadata = default,
            bool? background = default,
            global::OpenRouter.AnthropicCacheControlDirective? cacheControl = default,
            global::OpenRouter.ChatDebugOptions? debug = default,
            global::OpenRouter.DeferredToolsControl? deferredTools = default,
            double? frequencyPenalty = default,
            global::OpenRouter.ImageConfig? imageConfig = default,
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
            global::System.Collections.Generic.IList<global::OpenRouter.PluginsItem3>? plugins = default,
            double? presencePenalty = default,
            object? previousResponseId = default,
            global::OpenRouter.StoredPromptTemplate? prompt = default,
            string? promptCacheKey = default,
            global::OpenRouter.PromptCacheOptions? promptCacheOptions = default,
            global::OpenRouter.ProviderPreferences? provider = default,
            global::OpenRouter.AllOf<global::OpenRouter.BaseReasoningConfig, global::OpenRouter.ReasoningConfigVariant12>? reasoning = default,
            string? safetyIdentifier = default,
            global::OpenRouter.ResponsesRequestServiceTier? serviceTier = default,
            string? sessionId = default,
            global::System.Collections.Generic.IList<global::OpenRouter.StopServerToolsWhenCondition>? stopServerToolsWhen = default,
            bool? store = default,
            double? temperature = default,
            global::OpenRouter.TextExtendedConfig? text = default,
            global::OpenRouter.OpenAIResponsesToolChoice? toolChoice = default,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.AllOf<global::OpenRouter.FunctionTool, global::OpenRouter.ResponsesRequestToolVariant1>?, global::OpenRouter.PreviewWebSearchServerTool, global::OpenRouter.Preview20250311WebSearchServerTool, global::OpenRouter.LegacyWebSearchServerTool, global::OpenRouter.WebSearchServerTool, global::OpenRouter.FileSearchServerTool, global::OpenRouter.ComputerUseServerTool, global::OpenRouter.CodeInterpreterServerTool, global::OpenRouter.McpServerTool, global::OpenRouter.ImageGenerationServerTool, global::OpenRouter.CodexLocalShellTool, global::OpenRouter.ShellServerTool, global::OpenRouter.ApplyPatchServerTool, global::OpenRouter.CustomTool, global::OpenRouter.NamespaceTool, global::OpenRouter.AdvisorServerToolOpenRouter, global::OpenRouter.SubagentServerToolOpenRouter, global::OpenRouter.DatetimeServerTool, global::OpenRouter.FilesServerTool, global::OpenRouter.FusionServerToolOpenRouter, global::OpenRouter.ImageGenerationServerToolOpenRouter, global::OpenRouter.SearchModelsServerToolOpenRouter, global::OpenRouter.WebFetchServerTool, global::OpenRouter.WebSearchServerToolOpenRouter, global::OpenRouter.ApplyPatchServerToolOpenRouter, global::OpenRouter.BashServerTool, global::OpenRouter.ShellServerToolOpenRouter, global::OpenRouter.ToolSearchServerTool>>? tools = default,
            int? topK = default,
            int? topLogprobs = default,
            double? topP = default,
            global::OpenRouter.TraceConfig? trace = default,
            global::OpenRouter.OpenAIResponsesTruncation? truncation = default,
            string? user = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}