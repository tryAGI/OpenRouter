
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Information about an AI model available on OpenRouter<br/>
    /// Example: {"architecture":{"input_modalities":["text"],"instruct_type":"chatml","modality":"text-\u003Etext","output_modalities":["text"],"tokenizer":"GPT"},"canonical_slug":"openai/gpt-4","context_length":8192,"created":1692901234,"default_parameters":null,"description":"GPT-4 is a large multimodal model that can solve difficult problems with greater accuracy.","expiration_date":null,"id":"openai/gpt-4","knowledge_cutoff":null,"links":{"details":"/api/v1/models/openai/gpt-5.4/endpoints"},"name":"GPT-4","per_request_limits":null,"pricing":{"completion":"0.00006","image":"0","prompt":"0.00003","request":"0"},"reasoning":{"default_effort":"medium","default_enabled":true,"mandatory":false,"supported_efforts":["high","medium","low","minimal"]},"supported_parameters":["temperature","top_p","max_tokens"],"supported_voices":null,"top_provider":{"context_length":8192,"is_moderated":true,"max_completion_tokens":4096}}
    /// </summary>
    public sealed partial class Model
    {
        /// <summary>
        /// Concrete model targeted by this tilde-latest alias, when applicable<br/>
        /// Example: {"name":"Claude Sonnet 4.5","slug":"anthropic/claude-sonnet-4.5"}
        /// </summary>
        /// <example>{"name":"Claude Sonnet 4.5","slug":"anthropic/claude-sonnet-4.5"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias_target")]
        public global::OpenRouter.ModelAliasTarget? AliasTarget { get; set; }

        /// <summary>
        /// Model architecture information<br/>
        /// Example: {"input_modalities":["text"],"instruct_type":"chatml","modality":"text-\u003Etext","output_modalities":["text"],"tokenizer":"GPT"}
        /// </summary>
        /// <example>{"input_modalities":["text"],"instruct_type":"chatml","modality":"text-\u003Etext","output_modalities":["text"],"tokenizer":"GPT"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("architecture")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ModelArchitecture Architecture { get; set; }

        /// <summary>
        /// Third-party benchmark rankings for this model. Omitted when no benchmark data is available.<br/>
        /// Example: {"artificial_analysis":{"agentic_index":55.8,"coding_index":63.2,"intelligence_index":71.4},"design_arena":[{"arena":"models","category":"website","elo":1385.2,"rank":5,"win_rate":62.5}]}
        /// </summary>
        /// <example>{"artificial_analysis":{"agentic_index":55.8,"coding_index":63.2,"intelligence_index":71.4},"design_arena":[{"arena":"models","category":"website","elo":1385.2,"rank":5,"win_rate":62.5}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("benchmarks")]
        public global::OpenRouter.ModelBenchmarks? Benchmarks { get; set; }

        /// <summary>
        /// Canonical slug for the model<br/>
        /// Example: openai/gpt-4
        /// </summary>
        /// <example>openai/gpt-4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("canonical_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CanonicalSlug { get; set; }

        /// <summary>
        /// Maximum context length in tokens<br/>
        /// Example: 8192
        /// </summary>
        /// <example>8192</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_length")]
        public int? ContextLength { get; set; }

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
        /// Default parameters for this model<br/>
        /// Example: {"frequency_penalty":0,"presence_penalty":0,"repetition_penalty":1,"temperature":0.7,"top_k":0,"top_p":0.9}
        /// </summary>
        /// <example>{"frequency_penalty":0,"presence_penalty":0,"repetition_penalty":1,"temperature":0.7,"top_k":0,"top_p":0.9}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_parameters")]
        public global::OpenRouter.DefaultParameters? DefaultParameters { get; set; }

        /// <summary>
        /// Description of the model<br/>
        /// Example: GPT-4 is a large multimodal model that can solve difficult problems with greater accuracy.
        /// </summary>
        /// <example>GPT-4 is a large multimodal model that can solve difficult problems with greater accuracy.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The date after which the model may be removed. ISO 8601 date string (YYYY-MM-DD) or null if no expiration.<br/>
        /// Example: 2025-06-01
        /// </summary>
        /// <example>2025-06-01</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration_date")]
        public string? ExpirationDate { get; set; }

        /// <summary>
        /// Hugging Face model identifier, if applicable<br/>
        /// Example: microsoft/DialoGPT-medium
        /// </summary>
        /// <example>microsoft/DialoGPT-medium</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hugging_face_id")]
        public string? HuggingFaceId { get; set; }

        /// <summary>
        /// Unique identifier for the model<br/>
        /// Example: openai/gpt-4
        /// </summary>
        /// <example>openai/gpt-4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The date up to which the model was trained on data. ISO 8601 date string (YYYY-MM-DD) or null if unknown.<br/>
        /// Example: 2024-10-01
        /// </summary>
        /// <example>2024-10-01</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge_cutoff")]
        public string? KnowledgeCutoff { get; set; }

        /// <summary>
        /// Related API endpoints and resources for this model.<br/>
        /// Example: {"details":"/api/v1/models/openai/gpt-5.4/endpoints"}
        /// </summary>
        /// <example>{"details":"/api/v1/models/openai/gpt-5.4/endpoints"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ModelLinks Links { get; set; }

        /// <summary>
        /// Display name of the model<br/>
        /// Example: GPT-4
        /// </summary>
        /// <example>GPT-4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Per-request token limits<br/>
        /// Example: {"completion_tokens":1000,"prompt_tokens":1000}
        /// </summary>
        /// <example>{"completion_tokens":1000,"prompt_tokens":1000}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_request_limits")]
        public global::OpenRouter.PerRequestLimits? PerRequestLimits { get; set; }

        /// <summary>
        /// Pricing information for the model<br/>
        /// Example: {"completion":"0.00006","image":"0","prompt":"0.00003","request":"0"}
        /// </summary>
        /// <example>{"completion":"0.00006","image":"0","prompt":"0.00003","request":"0"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.PublicPricing Pricing { get; set; }

        /// <summary>
        /// Reasoning effort configuration. Omitted for non-reasoning models and dynamic router models.<br/>
        /// Example: {"default_effort":"medium","default_enabled":true,"mandatory":false,"supported_efforts":["high","medium","low","minimal"]}
        /// </summary>
        /// <example>{"default_effort":"medium","default_enabled":true,"mandatory":false,"supported_efforts":["high","medium","low","minimal"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public global::OpenRouter.ModelReasoning? Reasoning { get; set; }

        /// <summary>
        /// List of supported parameters for this model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.Parameter> SupportedParameters { get; set; }

        /// <summary>
        /// List of supported voice identifiers for TTS models. Null for non-TTS models.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_voices")]
        public global::System.Collections.Generic.IList<string>? SupportedVoices { get; set; }

        /// <summary>
        /// Information about the top provider for this model<br/>
        /// Example: {"context_length":8192,"is_moderated":true,"max_completion_tokens":4096}
        /// </summary>
        /// <example>{"context_length":8192,"is_moderated":true,"max_completion_tokens":4096}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.TopProviderInfo TopProvider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        /// <param name="architecture">
        /// Model architecture information<br/>
        /// Example: {"input_modalities":["text"],"instruct_type":"chatml","modality":"text-\u003Etext","output_modalities":["text"],"tokenizer":"GPT"}
        /// </param>
        /// <param name="canonicalSlug">
        /// Canonical slug for the model<br/>
        /// Example: openai/gpt-4
        /// </param>
        /// <param name="created">
        /// Unix timestamp of when the model was created<br/>
        /// Example: 1692901234
        /// </param>
        /// <param name="id">
        /// Unique identifier for the model<br/>
        /// Example: openai/gpt-4
        /// </param>
        /// <param name="links">
        /// Related API endpoints and resources for this model.<br/>
        /// Example: {"details":"/api/v1/models/openai/gpt-5.4/endpoints"}
        /// </param>
        /// <param name="name">
        /// Display name of the model<br/>
        /// Example: GPT-4
        /// </param>
        /// <param name="pricing">
        /// Pricing information for the model<br/>
        /// Example: {"completion":"0.00006","image":"0","prompt":"0.00003","request":"0"}
        /// </param>
        /// <param name="supportedParameters">
        /// List of supported parameters for this model
        /// </param>
        /// <param name="topProvider">
        /// Information about the top provider for this model<br/>
        /// Example: {"context_length":8192,"is_moderated":true,"max_completion_tokens":4096}
        /// </param>
        /// <param name="aliasTarget">
        /// Concrete model targeted by this tilde-latest alias, when applicable<br/>
        /// Example: {"name":"Claude Sonnet 4.5","slug":"anthropic/claude-sonnet-4.5"}
        /// </param>
        /// <param name="benchmarks">
        /// Third-party benchmark rankings for this model. Omitted when no benchmark data is available.<br/>
        /// Example: {"artificial_analysis":{"agentic_index":55.8,"coding_index":63.2,"intelligence_index":71.4},"design_arena":[{"arena":"models","category":"website","elo":1385.2,"rank":5,"win_rate":62.5}]}
        /// </param>
        /// <param name="contextLength">
        /// Maximum context length in tokens<br/>
        /// Example: 8192
        /// </param>
        /// <param name="defaultParameters">
        /// Default parameters for this model<br/>
        /// Example: {"frequency_penalty":0,"presence_penalty":0,"repetition_penalty":1,"temperature":0.7,"top_k":0,"top_p":0.9}
        /// </param>
        /// <param name="description">
        /// Description of the model<br/>
        /// Example: GPT-4 is a large multimodal model that can solve difficult problems with greater accuracy.
        /// </param>
        /// <param name="expirationDate">
        /// The date after which the model may be removed. ISO 8601 date string (YYYY-MM-DD) or null if no expiration.<br/>
        /// Example: 2025-06-01
        /// </param>
        /// <param name="huggingFaceId">
        /// Hugging Face model identifier, if applicable<br/>
        /// Example: microsoft/DialoGPT-medium
        /// </param>
        /// <param name="knowledgeCutoff">
        /// The date up to which the model was trained on data. ISO 8601 date string (YYYY-MM-DD) or null if unknown.<br/>
        /// Example: 2024-10-01
        /// </param>
        /// <param name="perRequestLimits">
        /// Per-request token limits<br/>
        /// Example: {"completion_tokens":1000,"prompt_tokens":1000}
        /// </param>
        /// <param name="reasoning">
        /// Reasoning effort configuration. Omitted for non-reasoning models and dynamic router models.<br/>
        /// Example: {"default_effort":"medium","default_enabled":true,"mandatory":false,"supported_efforts":["high","medium","low","minimal"]}
        /// </param>
        /// <param name="supportedVoices">
        /// List of supported voice identifiers for TTS models. Null for non-TTS models.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Model(
            global::OpenRouter.ModelArchitecture architecture,
            string canonicalSlug,
            global::System.DateTimeOffset created,
            string id,
            global::OpenRouter.ModelLinks links,
            string name,
            global::OpenRouter.PublicPricing pricing,
            global::System.Collections.Generic.IList<global::OpenRouter.Parameter> supportedParameters,
            global::OpenRouter.TopProviderInfo topProvider,
            global::OpenRouter.ModelAliasTarget? aliasTarget,
            global::OpenRouter.ModelBenchmarks? benchmarks,
            int? contextLength,
            global::OpenRouter.DefaultParameters? defaultParameters,
            string? description,
            string? expirationDate,
            string? huggingFaceId,
            string? knowledgeCutoff,
            global::OpenRouter.PerRequestLimits? perRequestLimits,
            global::OpenRouter.ModelReasoning? reasoning,
            global::System.Collections.Generic.IList<string>? supportedVoices)
        {
            this.AliasTarget = aliasTarget;
            this.Architecture = architecture ?? throw new global::System.ArgumentNullException(nameof(architecture));
            this.Benchmarks = benchmarks;
            this.CanonicalSlug = canonicalSlug ?? throw new global::System.ArgumentNullException(nameof(canonicalSlug));
            this.ContextLength = contextLength;
            this.Created = created;
            this.DefaultParameters = defaultParameters;
            this.Description = description;
            this.ExpirationDate = expirationDate;
            this.HuggingFaceId = huggingFaceId;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.KnowledgeCutoff = knowledgeCutoff;
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PerRequestLimits = perRequestLimits;
            this.Pricing = pricing ?? throw new global::System.ArgumentNullException(nameof(pricing));
            this.Reasoning = reasoning;
            this.SupportedParameters = supportedParameters ?? throw new global::System.ArgumentNullException(nameof(supportedParameters));
            this.SupportedVoices = supportedVoices;
            this.TopProvider = topProvider ?? throw new global::System.ArgumentNullException(nameof(topProvider));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        public Model()
        {
        }

    }
}