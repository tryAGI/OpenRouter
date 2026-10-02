
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Streaming chat completion chunk<br/>
    /// Example: {"choices":[{"delta":{"content":"Hello","role":"assistant"},"finish_reason":null,"index":0}],"created":1677652288,"id":"chatcmpl-123","model":"openai/gpt-4","object":"chat.completion.chunk"}
    /// </summary>
    public sealed partial class ChatStreamChunk
    {
        /// <summary>
        /// List of streaming chunk choices
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ChatStreamChoice> Choices { get; set; }

        /// <summary>
        /// Unix timestamp of creation<br/>
        /// Example: 1677652288
        /// </summary>
        /// <example>1677652288</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset Created { get; set; }

        /// <summary>
        /// Error information<br/>
        /// Example: {"code":429,"message":"Rate limit exceeded","metadata":{"error_type":"rate_limit_exceeded"}}
        /// </summary>
        /// <example>{"code":429,"message":"Rate limit exceeded","metadata":{"error_type":"rate_limit_exceeded"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::OpenRouter.ChatStreamChunkError? Error { get; set; }

        /// <summary>
        /// Unique chunk identifier<br/>
        /// Example: chatcmpl-123
        /// </summary>
        /// <example>chatcmpl-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Model used for completion<br/>
        /// Example: openai/gpt-4
        /// </summary>
        /// <example>openai/gpt-4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatStreamChunkObjectJsonConverter))]
        public global::OpenRouter.ChatStreamChunkObject Object { get; set; }

        /// <summary>
        /// Example: {"attempt":1,"endpoints":{"available":[{"model":"openai/gpt-4o","provider":"OpenAI","selected":true}],"total":1},"generation_time":2016,"is_byok":false,"region":"iad","requested":"openai/gpt-4o","strategy":"direct","summary":"available=1, selected=OpenAI"}
        /// </summary>
        /// <example>{"attempt":1,"endpoints":{"available":[{"model":"openai/gpt-4o","provider":"OpenAI","selected":true}],"total":1},"generation_time":2016,"is_byok":false,"region":"iad","requested":"openai/gpt-4o","strategy":"direct","summary":"available=1, selected=OpenAI"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("openrouter_metadata")]
        public global::OpenRouter.OpenRouterMetadata? OpenrouterMetadata { get; set; }

        /// <summary>
        /// The service tier used by the upstream provider for this request<br/>
        /// Example: default
        /// </summary>
        /// <example>default</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        public string? ServiceTier { get; set; }

        /// <summary>
        /// System fingerprint<br/>
        /// Example: fp_44709d6fcb
        /// </summary>
        /// <example>fp_44709d6fcb</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_fingerprint")]
        public string? SystemFingerprint { get; set; }

        /// <summary>
        /// Token usage statistics<br/>
        /// Example: {"completion_tokens":15,"completion_tokens_details":{"reasoning_tokens":5},"cost":0.0012,"cost_details":{"upstream_inference_completions_cost":0.0004,"upstream_inference_cost":null,"upstream_inference_prompt_cost":0.0008},"is_byok":false,"prompt_tokens":10,"prompt_tokens_details":{"cached_tokens":2},"server_tool_use_details":{"tool_calls_executed":2,"tool_calls_requested":2},"total_tokens":25}
        /// </summary>
        /// <example>{"completion_tokens":15,"completion_tokens_details":{"reasoning_tokens":5},"cost":0.0012,"cost_details":{"upstream_inference_completions_cost":0.0004,"upstream_inference_cost":null,"upstream_inference_prompt_cost":0.0008},"is_byok":false,"prompt_tokens":10,"prompt_tokens_details":{"cached_tokens":2},"server_tool_use_details":{"tool_calls_executed":2,"tool_calls_requested":2},"total_tokens":25}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::OpenRouter.ChatUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamChunk" /> class.
        /// </summary>
        /// <param name="choices">
        /// List of streaming chunk choices
        /// </param>
        /// <param name="created">
        /// Unix timestamp of creation<br/>
        /// Example: 1677652288
        /// </param>
        /// <param name="id">
        /// Unique chunk identifier<br/>
        /// Example: chatcmpl-123
        /// </param>
        /// <param name="model">
        /// Model used for completion<br/>
        /// Example: openai/gpt-4
        /// </param>
        /// <param name="error">
        /// Error information<br/>
        /// Example: {"code":429,"message":"Rate limit exceeded","metadata":{"error_type":"rate_limit_exceeded"}}
        /// </param>
        /// <param name="object"></param>
        /// <param name="openrouterMetadata">
        /// Example: {"attempt":1,"endpoints":{"available":[{"model":"openai/gpt-4o","provider":"OpenAI","selected":true}],"total":1},"generation_time":2016,"is_byok":false,"region":"iad","requested":"openai/gpt-4o","strategy":"direct","summary":"available=1, selected=OpenAI"}
        /// </param>
        /// <param name="serviceTier">
        /// The service tier used by the upstream provider for this request<br/>
        /// Example: default
        /// </param>
        /// <param name="systemFingerprint">
        /// System fingerprint<br/>
        /// Example: fp_44709d6fcb
        /// </param>
        /// <param name="usage">
        /// Token usage statistics<br/>
        /// Example: {"completion_tokens":15,"completion_tokens_details":{"reasoning_tokens":5},"cost":0.0012,"cost_details":{"upstream_inference_completions_cost":0.0004,"upstream_inference_cost":null,"upstream_inference_prompt_cost":0.0008},"is_byok":false,"prompt_tokens":10,"prompt_tokens_details":{"cached_tokens":2},"server_tool_use_details":{"tool_calls_executed":2,"tool_calls_requested":2},"total_tokens":25}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatStreamChunk(
            global::System.Collections.Generic.IList<global::OpenRouter.ChatStreamChoice> choices,
            global::System.DateTimeOffset created,
            string id,
            string model,
            global::OpenRouter.ChatStreamChunkError? error,
            global::OpenRouter.ChatStreamChunkObject @object,
            global::OpenRouter.OpenRouterMetadata? openrouterMetadata,
            string? serviceTier,
            string? systemFingerprint,
            global::OpenRouter.ChatUsage? usage)
        {
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.Created = created;
            this.Error = error;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Object = @object;
            this.OpenrouterMetadata = openrouterMetadata;
            this.ServiceTier = serviceTier;
            this.SystemFingerprint = systemFingerprint;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamChunk" /> class.
        /// </summary>
        public ChatStreamChunk()
        {
        }

    }
}