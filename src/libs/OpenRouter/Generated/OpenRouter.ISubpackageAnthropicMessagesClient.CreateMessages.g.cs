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
        /// <param name="model"></param>
        /// <param name="maxTokens"></param>
        /// <param name="messages"></param>
        /// <param name="system"></param>
        /// <param name="metadata"></param>
        /// <param name="stopSequences"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="topK"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="thinking"></param>
        /// <param name="serviceTier"></param>
        /// <param name="outputConfig">
        /// Configuration for controlling output behavior. Supports the effort parameter and structured output format.
        /// </param>
        /// <param name="cacheControl"></param>
        /// <param name="stream"></param>
        /// <param name="contextManagement"></param>
        /// <param name="provider">
        /// When multiple model providers are available, optionally indicate your routing preference.
        /// </param>
        /// <param name="plugins">
        /// Plugins you want to enable for this request, including their settings.
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which helps distinguish between different users of your app. This allows your app to identify specific users in case of abuse reports, preventing your entire app from being affected by the actions of individual users. Maximum of 256 characters.
        /// </param>
        /// <param name="sessionId">
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow) for observability. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.
        /// </param>
        /// <param name="trace">
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.
        /// </param>
        /// <param name="models"></param>
        /// <param name="speed">
        /// Controls output generation speed. When set to `fast`, uses a higher-speed inference configuration at premium pricing. Defaults to `standard` when omitted.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.MessagesResult> CreateMessagesAsync(
            string model,
            double? maxTokens = default,
            global::System.Collections.Generic.IList<global::OpenRouter.MessagesMessageParam>? messages = default,
            global::OpenRouter.MessagesRequestSystem? system = default,
            global::OpenRouter.MessagesRequestMetadata? metadata = default,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            double? temperature = default,
            double? topP = default,
            double? topK = default,
            global::System.Collections.Generic.IList<global::OpenRouter.MessagesRequestToolsItems>? tools = default,
            global::OpenRouter.MessagesRequestToolChoice? toolChoice = default,
            global::OpenRouter.MessagesRequestThinking? thinking = default,
            global::OpenRouter.MessagesRequestServiceTier? serviceTier = default,
            global::OpenRouter.MessagesOutputConfig? outputConfig = default,
            global::OpenRouter.MessagesRequestCacheControl? cacheControl = default,
            bool? stream = default,
            global::OpenRouter.OneOf<global::OpenRouter.MessagesRequestContextManagement, object>? contextManagement = default,
            global::OpenRouter.OneOf<global::OpenRouter.MessagesRequestProvider, object>? provider = default,
            global::System.Collections.Generic.IList<global::OpenRouter.MessagesRequestPluginsItems>? plugins = default,
            string? user = default,
            string? sessionId = default,
            global::OpenRouter.MessagesRequestTrace? trace = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::OpenRouter.MessagesRequestSpeed? speed = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}