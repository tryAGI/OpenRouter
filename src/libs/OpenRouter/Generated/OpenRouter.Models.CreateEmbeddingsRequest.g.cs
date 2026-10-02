
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Embeddings request input<br/>
    /// Example: {"dimensions":1536,"input":"The quick brown fox jumps over the lazy dog","model":"openai/text-embedding-3-small"}
    /// </summary>
    public sealed partial class CreateEmbeddingsRequest
    {
        /// <summary>
        /// The number of dimensions for the output embeddings<br/>
        /// Example: 1536
        /// </summary>
        /// <example>1536</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public int? Dimensions { get; set; }

        /// <summary>
        /// The format of the output embeddings<br/>
        /// Example: float
        /// </summary>
        /// <example>float</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CreateEmbeddingsRequestEncodingFormatJsonConverter))]
        public global::OpenRouter.CreateEmbeddingsRequestEncodingFormat? EncodingFormat { get; set; }

        /// <summary>
        /// Text, token, or multimodal input(s) to embed<br/>
        /// Example: The quick brown fox jumps over the lazy dog
        /// </summary>
        /// <example>The quick brown fox jumps over the lazy dog</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.IList<global::OpenRouter.CreateEmbeddingsRequestInputVariant5Item>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.IList<global::OpenRouter.CreateEmbeddingsRequestInputVariant5Item>> Input { get; set; }

        /// <summary>
        /// The type of input (e.g. search_query, search_document)<br/>
        /// Example: search_query
        /// </summary>
        /// <example>search_query</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_type")]
        public string? InputType { get; set; }

        /// <summary>
        /// The model to use for embeddings<br/>
        /// Example: openai/text-embedding-3-small
        /// </summary>
        /// <example>openai/text-embedding-3-small</example>
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
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). Used for observability grouping in Broadcast and private logging; never sent to the provider. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.<br/>
        /// Example: session-1234
        /// </summary>
        /// <example>session-1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.<br/>
        /// Example: {"trace_id":"trace-abc123","trace_name":"my-app-trace"}
        /// </summary>
        /// <example>{"trace_id":"trace-abc123","trace_name":"my-app-trace"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace")]
        public global::OpenRouter.TraceConfig? Trace { get; set; }

        /// <summary>
        /// A unique identifier for the end-user<br/>
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
        /// Initializes a new instance of the <see cref="CreateEmbeddingsRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Text, token, or multimodal input(s) to embed<br/>
        /// Example: The quick brown fox jumps over the lazy dog
        /// </param>
        /// <param name="model">
        /// The model to use for embeddings<br/>
        /// Example: openai/text-embedding-3-small
        /// </param>
        /// <param name="dimensions">
        /// The number of dimensions for the output embeddings<br/>
        /// Example: 1536
        /// </param>
        /// <param name="encodingFormat">
        /// The format of the output embeddings<br/>
        /// Example: float
        /// </param>
        /// <param name="inputType">
        /// The type of input (e.g. search_query, search_document)<br/>
        /// Example: search_query
        /// </param>
        /// <param name="provider"></param>
        /// <param name="sessionId">
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). Used for observability grouping in Broadcast and private logging; never sent to the provider. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.<br/>
        /// Example: session-1234
        /// </param>
        /// <param name="trace">
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.<br/>
        /// Example: {"trace_id":"trace-abc123","trace_name":"my-app-trace"}
        /// </param>
        /// <param name="user">
        /// A unique identifier for the end-user<br/>
        /// Example: user-1234
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEmbeddingsRequest(
            global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.IList<global::OpenRouter.CreateEmbeddingsRequestInputVariant5Item>> input,
            string model,
            int? dimensions,
            global::OpenRouter.CreateEmbeddingsRequestEncodingFormat? encodingFormat,
            string? inputType,
            global::OpenRouter.AllOf<global::OpenRouter.ProviderPreferences, object>? provider,
            string? sessionId,
            global::OpenRouter.TraceConfig? trace,
            string? user)
        {
            this.Dimensions = dimensions;
            this.EncodingFormat = encodingFormat;
            this.Input = input;
            this.InputType = inputType;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Provider = provider;
            this.SessionId = sessionId;
            this.Trace = trace;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingsRequest" /> class.
        /// </summary>
        public CreateEmbeddingsRequest()
        {
        }

    }
}