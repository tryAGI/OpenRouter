#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter
{
    public partial interface IPresetsClient
    {
        /// <summary>
        /// Create a preset from a messages request body<br/>
        /// Creates a preset (or a new version of an existing one) from an inference request body. Only fields that overlap with the preset config are persisted; other fields (e.g. `messages`, `stream`, `prompt`) are silently ignored.
        /// </summary>
        /// <param name="slug">
        /// URL-safe slug identifying the preset. Created if it does not exist.<br/>
        /// Example: my-preset
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreatePresetFromInferenceResponse> CreatePresetsMessagesAsync(
            string slug,

            global::OpenRouter.MessagesRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a preset from a messages request body<br/>
        /// Creates a preset (or a new version of an existing one) from an inference request body. Only fields that overlap with the preset config are persisted; other fields (e.g. `messages`, `stream`, `prompt`) are silently ignored.
        /// </summary>
        /// <param name="slug">
        /// URL-safe slug identifying the preset. Created if it does not exist.<br/>
        /// Example: my-preset
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.CreatePresetFromInferenceResponse>> CreatePresetsMessagesAsResponseAsync(
            string slug,

            global::OpenRouter.MessagesRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a preset from a messages request body<br/>
        /// Creates a preset (or a new version of an existing one) from an inference request body. Only fields that overlap with the preset config are persisted; other fields (e.g. `messages`, `stream`, `prompt`) are silently ignored.
        /// </summary>
        /// <param name="slug">
        /// URL-safe slug identifying the preset. Created if it does not exist.<br/>
        /// Example: my-preset
        /// </param>
        /// <param name="cacheControl">
        /// Enable automatic prompt caching. When set at the top level, the system automatically applies cache breakpoints to the last cacheable block in the request. When set on an individual content block, it marks an explicit cache breakpoint; block-level markers also work on OpenAI models that support explicit prompt caching — OpenRouter converts them to the provider's native format.<br/>
        /// Example: {"type":"ephemeral"}
        /// </param>
        /// <param name="contextManagement"></param>
        /// <param name="deferredTools">
        /// Opt-in versioned router-level deferred-tool protocol. Replay assistant reasoning unchanged on continuation; keep the catalog unchanged.<br/>
        /// Example: {"profile":"portable","protocol":"v1","search":{"max_results":5,"type":"bm25"},"validation":"runtime"}
        /// </param>
        /// <param name="fallbacks">
        /// Fallback models to try if the primary model fails or refuses, in order. Handled by OpenRouter multi-model routing rather than Anthropic server-side fallbacks; cannot be combined with `models`. Each entry accepts only `model`. Maximum of 3 entries.<br/>
        /// Example: [{"model":"claude-opus-4-8"}]
        /// </param>
        /// <param name="maxTokens"></param>
        /// <param name="messages"></param>
        /// <param name="metadata"></param>
        /// <param name="model"></param>
        /// <param name="models"></param>
        /// <param name="outputConfig">
        /// Configuration for controlling output behavior. Supports the effort parameter and structured output format.<br/>
        /// Example: {"effort":"medium"}
        /// </param>
        /// <param name="plugins">
        /// Plugins you want to enable for this request, including their settings.
        /// </param>
        /// <param name="provider">
        /// When multiple model providers are available, optionally indicate your routing preference.<br/>
        /// Example: {"allow_fallbacks":true}
        /// </param>
        /// <param name="safeguards"></param>
        /// <param name="serviceTier"></param>
        /// <param name="sessionId">
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). When provided, OpenRouter uses it as the sticky routing key, routing all requests in the session to the same provider to maximize prompt cache hits. Also used for observability grouping. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.
        /// </param>
        /// <param name="speed"></param>
        /// <param name="stopSequences"></param>
        /// <param name="stopServerToolsWhen">
        /// Stop conditions for the server-tool agent loop. Any condition firing halts the loop (OR logic). When set, this overrides `max_tool_calls`. When a condition fires while the model is still emitting tool calls, the pending tool calls are executed and one final turn is made with tool calls disabled so the response ends with a natural-language answer instead of an unfinished tool call.<br/>
        /// Example: [{"step_count":5,"type":"step_count_is"}, {"max_cost_in_dollars":0.5,"type":"max_cost"}]
        /// </param>
        /// <param name="stream"></param>
        /// <param name="system"></param>
        /// <param name="temperature"></param>
        /// <param name="thinking"></param>
        /// <param name="toolChoice"></param>
        /// <param name="tools"></param>
        /// <param name="topK"></param>
        /// <param name="topP"></param>
        /// <param name="trace">
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.<br/>
        /// Example: {"trace_id":"trace-abc123","trace_name":"my-app-trace"}
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which helps distinguish between different users of your app. This allows your app to identify specific users in case of abuse reports, preventing your entire app from being affected by the actions of individual users. Maximum of 256 characters.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreatePresetFromInferenceResponse> CreatePresetsMessagesAsync(
            string slug,
            string model,
            global::OpenRouter.AnthropicCacheControlDirective? cacheControl = default,
            global::OpenRouter.MessagesRequestContextManagement? contextManagement = default,
            global::OpenRouter.DeferredToolsControl? deferredTools = default,
            global::System.Collections.Generic.IList<global::OpenRouter.MessagesFallbackParam>? fallbacks = default,
            int? maxTokens = default,
            global::System.Collections.Generic.IList<global::OpenRouter.MessagesMessageParam>? messages = default,
            global::OpenRouter.MessagesRequestMetadata? metadata = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::OpenRouter.MessagesOutputConfig? outputConfig = default,
            global::System.Collections.Generic.IList<global::OpenRouter.PluginsItem2>? plugins = default,
            global::OpenRouter.ProviderPreferences? provider = default,
            global::System.Collections.Generic.IList<global::OpenRouter.AnthropicSafeguard>? safeguards = default,
            string? serviceTier = default,
            string? sessionId = default,
            global::OpenRouter.AllOf<global::OpenRouter.AnthropicSpeed?, object>? speed = default,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            global::System.Collections.Generic.IList<global::OpenRouter.StopServerToolsWhenCondition>? stopServerToolsWhen = default,
            bool? stream = default,
            global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<global::OpenRouter.AnthropicTextBlockParam>>? system = default,
            double? temperature = default,
            global::OpenRouter.OneOf<global::OpenRouter.MessagesRequestThinkingVariant1, global::OpenRouter.MessagesRequestThinkingVariant2, global::OpenRouter.MessagesRequestThinkingVariant3, global::OpenRouter.MessagesRequestThinkingVariant4>? thinking = default,
            global::OpenRouter.OneOf<global::OpenRouter.MessagesRequestToolChoiceVariant1, global::OpenRouter.MessagesRequestToolChoiceVariant2, global::OpenRouter.MessagesRequestToolChoiceVariant3, global::OpenRouter.MessagesRequestToolChoiceVariant4>? toolChoice = default,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.MessagesRequestToolVariant1, global::OpenRouter.MessagesRequestToolVariant2, global::OpenRouter.MessagesRequestToolVariant3, global::OpenRouter.MessagesRequestToolVariant4, global::OpenRouter.MessagesRequestToolVariant5, global::OpenRouter.MessagesRequestToolVariant6, global::OpenRouter.BashServerTool, global::OpenRouter.DatetimeServerTool, global::OpenRouter.ImageGenerationServerToolOpenRouter, global::OpenRouter.MessagesSearchModelsServerTool, global::OpenRouter.WebFetchServerTool, global::OpenRouter.OpenRouterWebSearchServerTool, global::OpenRouter.MessagesRequestToolVariant13, global::OpenRouter.AnthropicToolSearchToolBm25, global::OpenRouter.AnthropicToolSearchToolRegex, global::OpenRouter.ShellServerToolOpenRouter, global::OpenRouter.ToolSearchServerTool>>? tools = default,
            int? topK = default,
            double? topP = default,
            global::OpenRouter.TraceConfig? trace = default,
            string? user = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}