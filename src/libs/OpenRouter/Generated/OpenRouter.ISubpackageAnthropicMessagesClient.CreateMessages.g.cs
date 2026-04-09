#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageAnthropicMessagesClient
    {
        /// <summary>
        /// Create a message<br/>
        /// Creates a message using the Anthropic Messages API format. Supports text, images, PDFs, tools, and extended thinking.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.MessagesResult> CreateMessagesAsync(

            global::OpenRouter.MessagesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a message<br/>
        /// Creates a message using the Anthropic Messages API format. Supports text, images, PDFs, tools, and extended thinking.
        /// </summary>
        /// <param name="cacheControl"></param>
        /// <param name="contextManagement"></param>
        /// <param name="maxTokens"></param>
        /// <param name="messages"></param>
        /// <param name="metadata"></param>
        /// <param name="model"></param>
        /// <param name="models"></param>
        /// <param name="outputConfig">
        /// Configuration for controlling output behavior. Supports the effort parameter and structured output format.
        /// </param>
        /// <param name="plugins">
        /// Plugins you want to enable for this request, including their settings.
        /// </param>
        /// <param name="provider">
        /// When multiple model providers are available, optionally indicate your routing preference.
        /// </param>
        /// <param name="route">
        /// Any type
        /// </param>
        /// <param name="serviceTier"></param>
        /// <param name="sessionId">
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow) for observability. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.
        /// </param>
        /// <param name="speed"></param>
        /// <param name="stopSequences"></param>
        /// <param name="stream"></param>
        /// <param name="system"></param>
        /// <param name="temperature"></param>
        /// <param name="thinking"></param>
        /// <param name="toolChoice"></param>
        /// <param name="tools"></param>
        /// <param name="topK"></param>
        /// <param name="topP"></param>
        /// <param name="trace">
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which helps distinguish between different users of your app. This allows your app to identify specific users in case of abuse reports, preventing your entire app from being affected by the actions of individual users. Maximum of 256 characters.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.MessagesResult> CreateMessagesAsync(
            string model,
            global::OpenRouter.AnthropicCacheControlDirective? cacheControl = default,
            global::OpenRouter.OneOf<global::OpenRouter.MessagesRequestContextManagement, object>? contextManagement = default,
            int? maxTokens = default,
            global::System.Collections.Generic.IList<global::OpenRouter.MessagesMessageParam>? messages = default,
            global::OpenRouter.MessagesRequestMetadata? metadata = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::OpenRouter.MessagesOutputConfig? outputConfig = default,
            global::System.Collections.Generic.IList<global::OpenRouter.MessagesRequestPluginsItems>? plugins = default,
            global::OpenRouter.ProviderPreferences? provider = default,
            object? route = default,
            global::OpenRouter.MessagesRequestServiceTier? serviceTier = default,
            string? sessionId = default,
            global::OpenRouter.MessagesRequestSpeed? speed = default,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            bool? stream = default,
            global::OpenRouter.MessagesRequestSystem? system = default,
            double? temperature = default,
            global::OpenRouter.MessagesRequestThinking? thinking = default,
            global::OpenRouter.MessagesRequestToolChoice? toolChoice = default,
            global::System.Collections.Generic.IList<global::OpenRouter.MessagesRequestToolsItems>? tools = default,
            int? topK = default,
            double? topP = default,
            global::OpenRouter.TraceConfig? trace = default,
            string? user = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}