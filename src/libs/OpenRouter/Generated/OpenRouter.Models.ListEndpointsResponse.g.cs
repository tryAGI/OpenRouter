
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// List of available endpoints for a model<br/>
    /// Example: {"architecture":{"input_modalities":["text"],"instruct_type":"chatml","modality":"text-\u003Etext","output_modalities":["text"],"tokenizer":"GPT"},"created":1692901234,"description":"GPT-4 is a large multimodal model that can solve difficult problems with greater accuracy.","endpoints":[{"context_length":8192,"latency_last_30m":{"p50":0.25,"p75":0.35,"p90":0.48,"p99":0.85},"max_completion_tokens":4096,"max_prompt_tokens":8192,"model_id":"openai/gpt-4","model_name":"GPT-4","name":"OpenAI: GPT-4","pricing":{"completion":"0.00006","image":"0","prompt":"0.00003","request":"0"},"provider_name":"OpenAI","quantization":"fp16","status":0,"supported_parameters":["temperature","top_p","max_tokens","frequency_penalty","presence_penalty"],"supports_implicit_caching":true,"tag":"openai","throughput_last_30m":{"p50":45.2,"p75":38.5,"p90":28.3,"p99":15.1},"uptime_last_1d":99.8,"uptime_last_30m":99.5,"uptime_last_5m":100}],"id":"openai/gpt-4","name":"GPT-4"}
    /// </summary>
    public sealed partial class ListEndpointsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("architecture")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AllOfJsonConverter<global::OpenRouter.ModelArchitecture, global::OpenRouter.ListEndpointsResponseArchitecture>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AllOf<global::OpenRouter.ModelArchitecture, global::OpenRouter.ListEndpointsResponseArchitecture> Architecture { get; set; }

        /// <summary>
        /// Unix timestamp of when the model was created<br/>
        /// Example: 1692901234
        /// </summary>
        /// <example>1692901234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset Created { get; set; }

        /// <summary>
        /// Description of the model<br/>
        /// Example: GPT-4 is a large multimodal model that can solve difficult problems with greater accuracy.
        /// </summary>
        /// <example>GPT-4 is a large multimodal model that can solve difficult problems with greater accuracy.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// List of available endpoints for this model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.PublicEndpoint> Endpoints { get; set; }

        /// <summary>
        /// Unique identifier for the model<br/>
        /// Example: openai/gpt-4
        /// </summary>
        /// <example>openai/gpt-4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Display name of the model<br/>
        /// Example: GPT-4
        /// </summary>
        /// <example>GPT-4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEndpointsResponse" /> class.
        /// </summary>
        /// <param name="architecture"></param>
        /// <param name="created">
        /// Unix timestamp of when the model was created<br/>
        /// Example: 1692901234
        /// </param>
        /// <param name="description">
        /// Description of the model<br/>
        /// Example: GPT-4 is a large multimodal model that can solve difficult problems with greater accuracy.
        /// </param>
        /// <param name="endpoints">
        /// List of available endpoints for this model
        /// </param>
        /// <param name="id">
        /// Unique identifier for the model<br/>
        /// Example: openai/gpt-4
        /// </param>
        /// <param name="name">
        /// Display name of the model<br/>
        /// Example: GPT-4
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListEndpointsResponse(
            global::OpenRouter.AllOf<global::OpenRouter.ModelArchitecture, global::OpenRouter.ListEndpointsResponseArchitecture> architecture,
            global::System.DateTimeOffset created,
            string description,
            global::System.Collections.Generic.IList<global::OpenRouter.PublicEndpoint> endpoints,
            string id,
            string name)
        {
            this.Architecture = architecture;
            this.Created = created;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Endpoints = endpoints ?? throw new global::System.ArgumentNullException(nameof(endpoints));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEndpointsResponse" /> class.
        /// </summary>
        public ListEndpointsResponse()
        {
        }

    }
}