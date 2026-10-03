
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"author":"openai","canonical_slug":"openai/gpt-4","context_length":8192,"created":1687882411,"description":"OpenAI flagship model.","endpoints":[{"created":1687882411,"data_policy":{"retains_prompts":false,"training":false},"id":"gpt-4","inputs":[{"params":{"max_length":{"unit":"token","value":8192}},"pricing":[{"cost_usd":"0.00003","type":"prompt","unit":"token"}],"type":"text"}],"name":"GPT-4","openrouter":{"slug":"openai/gpt-4"},"outputs":[{"max_length":{"unit":"token","value":4096},"params":{"max_tokens":{"type":"unknown"},"temperature":{"type":"unknown"},"tools":{"type":"unknown"}},"pricing":[{"cost_usd":"0.00006","type":"completion","unit":"token"}],"type":"text"}],"provider":{"name":"OpenAI","slug":"openai","tag":"openai"},"schema_version":"2.4"}],"id":"openai/gpt-4","inputs":["text"],"kind":"model","name":"GPT-4","outputs":["text"],"variant":"standard"}
    /// </summary>
    public sealed partial class ModelV2
    {
        /// <summary>
        /// For an `alias` record, the model it currently resolves to; absent while the alias has no live target
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias_target")]
        public global::OpenRouter.AliasTargetV2? AliasTarget { get; set; }

        /// <summary>
        /// Author slug, the first segment of the model slug<br/>
        /// Example: openai
        /// </summary>
        /// <example>openai</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Author { get; set; }

        /// <summary>
        /// Permanent slug that identifies this model version<br/>
        /// Example: openai/gpt-4
        /// </summary>
        /// <example>openai/gpt-4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("canonical_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CanonicalSlug { get; set; }

        /// <summary>
        /// Context window of the model in tokens, as listed by `GET /api/v1/models`<br/>
        /// Example: 8192
        /// </summary>
        /// <example>8192</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContextLength { get; set; }

        /// <summary>
        /// Unix timestamp (seconds) when the model was added to OpenRouter<br/>
        /// Example: 1687882411
        /// </summary>
        /// <example>1687882411</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset Created { get; set; }

        /// <summary>
        /// Model description<br/>
        /// Example: OpenAI flagship model.
        /// </summary>
        /// <example>OpenAI flagship model.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Published endpoints serving this model, one V2 document each. An `alias` carries the endpoints of its target; a `router` has none, it routes to other models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.EndpointDocumentV2> Endpoints { get; set; }

        /// <summary>
        /// Hugging Face model identifier, when the weights are published there<br/>
        /// Example: meta-llama/Llama-3.1-8B-Instruct
        /// </summary>
        /// <example>meta-llama/Llama-3.1-8B-Instruct</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hugging_face_id")]
        public string? HuggingFaceId { get; set; }

        /// <summary>
        /// Model slug used in API requests<br/>
        /// Example: openai/gpt-4
        /// </summary>
        /// <example>openai/gpt-4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Input modality types registered on the model, independent of which endpoints the request returns; each entry of `endpoints[].inputs` carries the full modality object of that endpoint<br/>
        /// Example: [text, image]
        /// </summary>
        /// <example>[text, image]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ModelV2Input> Inputs { get; set; }

        /// <summary>
        /// What the record is: `model` for a served model variant, `router` for an OpenRouter router (`openrouter/auto`), `alias` for a `~author/family-latest` pointer. `kind.not=router` lists catalog models only<br/>
        /// Example: model
        /// </summary>
        /// <example>model</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ModelV2KindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ModelV2Kind Kind { get; set; }

        /// <summary>
        /// Human-readable model name<br/>
        /// Example: GPT-4
        /// </summary>
        /// <example>GPT-4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Output modality types registered on the model, independent of which endpoints the request returns; each entry of `endpoints[].outputs` carries the full modality object of that endpoint<br/>
        /// Example: [text]
        /// </summary>
        /// <example>[text]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ModelV2Output> Outputs { get; set; }

        /// <summary>
        /// Variant of the model this record serves, the suffix of `id` (`openai/gpt-4:free` is `free`). Every record other than `free` is paid, so `variant.not=free` lists paid models and `variant=batch` the batch variants<br/>
        /// Example: standard
        /// </summary>
        /// <example>standard</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("variant")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ModelV2VariantJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ModelV2Variant Variant { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelV2" /> class.
        /// </summary>
        /// <param name="author">
        /// Author slug, the first segment of the model slug<br/>
        /// Example: openai
        /// </param>
        /// <param name="canonicalSlug">
        /// Permanent slug that identifies this model version<br/>
        /// Example: openai/gpt-4
        /// </param>
        /// <param name="contextLength">
        /// Context window of the model in tokens, as listed by `GET /api/v1/models`<br/>
        /// Example: 8192
        /// </param>
        /// <param name="created">
        /// Unix timestamp (seconds) when the model was added to OpenRouter<br/>
        /// Example: 1687882411
        /// </param>
        /// <param name="endpoints">
        /// Published endpoints serving this model, one V2 document each. An `alias` carries the endpoints of its target; a `router` has none, it routes to other models
        /// </param>
        /// <param name="id">
        /// Model slug used in API requests<br/>
        /// Example: openai/gpt-4
        /// </param>
        /// <param name="inputs">
        /// Input modality types registered on the model, independent of which endpoints the request returns; each entry of `endpoints[].inputs` carries the full modality object of that endpoint<br/>
        /// Example: [text, image]
        /// </param>
        /// <param name="kind">
        /// What the record is: `model` for a served model variant, `router` for an OpenRouter router (`openrouter/auto`), `alias` for a `~author/family-latest` pointer. `kind.not=router` lists catalog models only<br/>
        /// Example: model
        /// </param>
        /// <param name="name">
        /// Human-readable model name<br/>
        /// Example: GPT-4
        /// </param>
        /// <param name="outputs">
        /// Output modality types registered on the model, independent of which endpoints the request returns; each entry of `endpoints[].outputs` carries the full modality object of that endpoint<br/>
        /// Example: [text]
        /// </param>
        /// <param name="variant">
        /// Variant of the model this record serves, the suffix of `id` (`openai/gpt-4:free` is `free`). Every record other than `free` is paid, so `variant.not=free` lists paid models and `variant=batch` the batch variants<br/>
        /// Example: standard
        /// </param>
        /// <param name="aliasTarget">
        /// For an `alias` record, the model it currently resolves to; absent while the alias has no live target
        /// </param>
        /// <param name="description">
        /// Model description<br/>
        /// Example: OpenAI flagship model.
        /// </param>
        /// <param name="huggingFaceId">
        /// Hugging Face model identifier, when the weights are published there<br/>
        /// Example: meta-llama/Llama-3.1-8B-Instruct
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelV2(
            string author,
            string canonicalSlug,
            int contextLength,
            global::System.DateTimeOffset created,
            global::System.Collections.Generic.IList<global::OpenRouter.EndpointDocumentV2> endpoints,
            string id,
            global::System.Collections.Generic.IList<global::OpenRouter.ModelV2Input> inputs,
            global::OpenRouter.ModelV2Kind kind,
            string name,
            global::System.Collections.Generic.IList<global::OpenRouter.ModelV2Output> outputs,
            global::OpenRouter.ModelV2Variant variant,
            global::OpenRouter.AliasTargetV2? aliasTarget,
            string? description,
            string? huggingFaceId)
        {
            this.AliasTarget = aliasTarget;
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.CanonicalSlug = canonicalSlug ?? throw new global::System.ArgumentNullException(nameof(canonicalSlug));
            this.ContextLength = contextLength;
            this.Created = created;
            this.Description = description;
            this.Endpoints = endpoints ?? throw new global::System.ArgumentNullException(nameof(endpoints));
            this.HuggingFaceId = huggingFaceId;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.Kind = kind;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Outputs = outputs ?? throw new global::System.ArgumentNullException(nameof(outputs));
            this.Variant = variant;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelV2" /> class.
        /// </summary>
        public ModelV2()
        {
        }

    }
}