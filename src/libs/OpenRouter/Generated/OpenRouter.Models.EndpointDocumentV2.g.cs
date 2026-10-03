
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A published endpoint in the Models API V2 document format, the same schema providers publish to OpenRouter, with modalities under `inputs`/`outputs` and their constraints under `params`, extended with the provider that serves it and its data policy<br/>
    /// Example: {"created":1687882411,"data_policy":{"retains_prompts":false,"training":false},"id":"gpt-4","inputs":[{"params":{"max_length":{"unit":"token","value":8192}},"pricing":[{"cost_usd":"0.00003","type":"prompt","unit":"token"}],"type":"text"}],"name":"GPT-4","openrouter":{"slug":"openai/gpt-4"},"outputs":[{"max_length":{"unit":"token","value":4096},"params":{"max_tokens":{"type":"unknown"},"temperature":{"type":"unknown"},"tools":{"type":"unknown"}},"pricing":[{"cost_usd":"0.00006","type":"completion","unit":"token"}],"type":"text"}],"provider":{"name":"OpenAI","slug":"openai","tag":"openai"},"schema_version":"2.4"}
    /// </summary>
    public sealed partial class EndpointDocumentV2
    {
        /// <summary>
        /// Entries must be unique by type, unit, and window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capacity")]
        public global::System.Collections.Generic.IList<global::OpenRouter.RequestCapacityEntryV2>? Capacity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public int? Created { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_policy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.EndpointDataPolicyV2 DataPolicy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datacenters")]
        public global::System.Collections.Generic.IList<global::OpenRouter.DatacenterV2>? Datacenters { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_region")]
        public string? DeploymentRegion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecation_date")]
        public global::System.DateTime? DeprecationDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discount_to_user")]
        public double? DiscountToUser { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hugging_face_id")]
        public string? HuggingFaceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Input modalities of the endpoint as full objects (the provider document's `input_modalities`), one entry per modality type with its `params` and pricing; the model-level `inputs` lists the types only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ModelInputV2> Inputs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_free")]
        public bool? IsFree { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_ready")]
        public bool? IsReady { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openrouter")]
        public global::OpenRouter.EndpointOpenrouterV2? Openrouter { get; set; }

        /// <summary>
        /// Output modalities of the endpoint as full objects (the provider document's `output_modalities`), one entry per modality type with its `params` and pricing; the model-level `outputs` lists the types only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ModelOutputV2> Outputs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passthrough_parameters")]
        public global::System.Collections.Generic.Dictionary<string, global::OpenRouter.ParameterDescriptorV2>? PassthroughParameters { get; set; }

        /// <summary>
        /// Entries must be unique by type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        public global::System.Collections.Generic.IList<global::OpenRouter.RequestPricingEntryV2>? Pricing { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.EndpointProviderV2 Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantization")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.EndpointDocumentV2QuantizationJsonConverter))]
        public global::OpenRouter.EndpointDocumentV2Quantization? Quantization { get; set; }

        /// <summary>
        /// V2 document marker. Any "2.x" value is accepted; OpenRouter publishes "2.4".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SchemaVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.EndpointDocumentV2ServiceTierJsonConverter))]
        public global::OpenRouter.EndpointDocumentV2ServiceTier? ServiceTier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenizer")]
        public string? Tokenizer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointDocumentV2" /> class.
        /// </summary>
        /// <param name="dataPolicy"></param>
        /// <param name="id"></param>
        /// <param name="inputs">
        /// Input modalities of the endpoint as full objects (the provider document's `input_modalities`), one entry per modality type with its `params` and pricing; the model-level `inputs` lists the types only
        /// </param>
        /// <param name="name"></param>
        /// <param name="outputs">
        /// Output modalities of the endpoint as full objects (the provider document's `output_modalities`), one entry per modality type with its `params` and pricing; the model-level `outputs` lists the types only
        /// </param>
        /// <param name="provider"></param>
        /// <param name="schemaVersion">
        /// V2 document marker. Any "2.x" value is accepted; OpenRouter publishes "2.4".
        /// </param>
        /// <param name="capacity">
        /// Entries must be unique by type, unit, and window
        /// </param>
        /// <param name="created"></param>
        /// <param name="datacenters"></param>
        /// <param name="deploymentRegion"></param>
        /// <param name="deprecationDate"></param>
        /// <param name="description"></param>
        /// <param name="discountToUser"></param>
        /// <param name="huggingFaceId"></param>
        /// <param name="isFree"></param>
        /// <param name="isReady"></param>
        /// <param name="openrouter"></param>
        /// <param name="passthroughParameters"></param>
        /// <param name="pricing">
        /// Entries must be unique by type
        /// </param>
        /// <param name="quantization"></param>
        /// <param name="serviceTier"></param>
        /// <param name="tokenizer"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndpointDocumentV2(
            global::OpenRouter.EndpointDataPolicyV2 dataPolicy,
            string id,
            global::System.Collections.Generic.IList<global::OpenRouter.ModelInputV2> inputs,
            string name,
            global::System.Collections.Generic.IList<global::OpenRouter.ModelOutputV2> outputs,
            global::OpenRouter.EndpointProviderV2 provider,
            string schemaVersion,
            global::System.Collections.Generic.IList<global::OpenRouter.RequestCapacityEntryV2>? capacity,
            int? created,
            global::System.Collections.Generic.IList<global::OpenRouter.DatacenterV2>? datacenters,
            string? deploymentRegion,
            global::System.DateTime? deprecationDate,
            string? description,
            double? discountToUser,
            string? huggingFaceId,
            bool? isFree,
            bool? isReady,
            global::OpenRouter.EndpointOpenrouterV2? openrouter,
            global::System.Collections.Generic.Dictionary<string, global::OpenRouter.ParameterDescriptorV2>? passthroughParameters,
            global::System.Collections.Generic.IList<global::OpenRouter.RequestPricingEntryV2>? pricing,
            global::OpenRouter.EndpointDocumentV2Quantization? quantization,
            global::OpenRouter.EndpointDocumentV2ServiceTier? serviceTier,
            string? tokenizer)
        {
            this.Capacity = capacity;
            this.Created = created;
            this.DataPolicy = dataPolicy ?? throw new global::System.ArgumentNullException(nameof(dataPolicy));
            this.Datacenters = datacenters;
            this.DeploymentRegion = deploymentRegion;
            this.DeprecationDate = deprecationDate;
            this.Description = description;
            this.DiscountToUser = discountToUser;
            this.HuggingFaceId = huggingFaceId;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.IsFree = isFree;
            this.IsReady = isReady;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Openrouter = openrouter;
            this.Outputs = outputs ?? throw new global::System.ArgumentNullException(nameof(outputs));
            this.PassthroughParameters = passthroughParameters;
            this.Pricing = pricing;
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Quantization = quantization;
            this.SchemaVersion = schemaVersion ?? throw new global::System.ArgumentNullException(nameof(schemaVersion));
            this.ServiceTier = serviceTier;
            this.Tokenizer = tokenizer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointDocumentV2" /> class.
        /// </summary>
        public EndpointDocumentV2()
        {
        }

    }
}