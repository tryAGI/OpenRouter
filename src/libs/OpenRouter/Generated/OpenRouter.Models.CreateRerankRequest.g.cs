
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Rerank request input<br/>
    /// Example: {"documents":["Paris is the capital of France.","Berlin is the capital of Germany."],"model":"cohere/rerank-v3.5","query":"What is the capital of France?","top_n":3}
    /// </summary>
    public sealed partial class CreateRerankRequest
    {
        /// <summary>
        /// The list of documents to rerank. Documents may be plain strings, or structured objects with `text` and/or `image` for multimodal models.<br/>
        /// Example: [Paris is the capital of France., Berlin is the capital of Germany.]
        /// </summary>
        /// <example>[Paris is the capital of France., Berlin is the capital of Germany.]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, global::OpenRouter.CreateRerankRequestDocument>> Documents { get; set; }

        /// <summary>
        /// The rerank model to use<br/>
        /// Example: cohere/rerank-v3.5
        /// </summary>
        /// <example>cohere/rerank-v3.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AllOfJsonConverter<global::OpenRouter.ProviderPreferences, object>))]
        public global::OpenRouter.AllOf<global::OpenRouter.ProviderPreferences, object>? Provider { get; set; }

        /// <summary>
        /// The search query to rerank documents against<br/>
        /// Example: What is the capital of France?
        /// </summary>
        /// <example>What is the capital of France?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). Used for observability grouping in Broadcast and private logging; never sent to the provider. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.<br/>
        /// Example: session-1234
        /// </summary>
        /// <example>session-1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Number of most relevant documents to return<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_n")]
        public int? TopN { get; set; }

        /// <summary>
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.<br/>
        /// Example: {"trace_id":"trace-abc123","trace_name":"my-app-trace"}
        /// </summary>
        /// <example>{"trace_id":"trace-abc123","trace_name":"my-app-trace"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace")]
        public global::OpenRouter.TraceConfig? Trace { get; set; }

        /// <summary>
        /// A unique identifier representing your end-user. Forwarded to Broadcast and private logging as the end-user id; never sent to the provider.<br/>
        /// Example: user-1234
        /// </summary>
        /// <example>user-1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRerankRequest" /> class.
        /// </summary>
        /// <param name="documents">
        /// The list of documents to rerank. Documents may be plain strings, or structured objects with `text` and/or `image` for multimodal models.<br/>
        /// Example: [Paris is the capital of France., Berlin is the capital of Germany.]
        /// </param>
        /// <param name="model">
        /// The rerank model to use<br/>
        /// Example: cohere/rerank-v3.5
        /// </param>
        /// <param name="query">
        /// The search query to rerank documents against<br/>
        /// Example: What is the capital of France?
        /// </param>
        /// <param name="provider"></param>
        /// <param name="sessionId">
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). Used for observability grouping in Broadcast and private logging; never sent to the provider. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.<br/>
        /// Example: session-1234
        /// </param>
        /// <param name="topN">
        /// Number of most relevant documents to return<br/>
        /// Example: 3
        /// </param>
        /// <param name="trace">
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.<br/>
        /// Example: {"trace_id":"trace-abc123","trace_name":"my-app-trace"}
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user. Forwarded to Broadcast and private logging as the end-user id; never sent to the provider.<br/>
        /// Example: user-1234
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRerankRequest(
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, global::OpenRouter.CreateRerankRequestDocument>> documents,
            string model,
            string query,
            global::OpenRouter.AllOf<global::OpenRouter.ProviderPreferences, object>? provider,
            string? sessionId,
            int? topN,
            global::OpenRouter.TraceConfig? trace,
            string? user)
        {
            this.Documents = documents ?? throw new global::System.ArgumentNullException(nameof(documents));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Provider = provider;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.SessionId = sessionId;
            this.TopN = topN;
            this.Trace = trace;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRerankRequest" /> class.
        /// </summary>
        public CreateRerankRequest()
        {
        }

    }
}