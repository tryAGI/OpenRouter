
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderName), TypeInfoPropertyName = "ProviderName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PercentileLatencyCutoffs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PreferredMaxLatency), TypeInfoPropertyName = "PreferredMaxLatency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PercentileThroughputCutoffs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PreferredMinThroughput), TypeInfoPropertyName = "PreferredMinThroughput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Quantization), TypeInfoPropertyName = "Quantization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderSort), TypeInfoPropertyName = "ProviderSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderSortConfigBy), TypeInfoPropertyName = "ProviderSortConfigBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderSortConfigPartition), TypeInfoPropertyName = "ProviderSortConfigPartition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderSortConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.Quantization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningEffort), TypeInfoPropertyName = "ReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BadRequestResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BadRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnauthorizedResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnauthorizedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PaymentRequiredResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PaymentRequiredResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.NotFoundResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.NotFoundResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.TooManyRequestsResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.TooManyRequestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InternalServerResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InternalServerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BadGatewayResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BadGatewayResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ServiceUnavailableResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ServiceUnavailableResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CostDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormat), TypeInfoPropertyName = "EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf0Type), TypeInfoPropertyName = "EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1ImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1Type), TypeInfoPropertyName = "EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MultimodalMedia))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ContentPartInputAudioType), TypeInfoPropertyName = "ContentPartInputAudioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ContentPartInputAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ContentPartInputVideoType), TypeInfoPropertyName = "ContentPartInputVideoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ContentPartInputVideo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ContentPartInputFileType), TypeInfoPropertyName = "ContentPartInputFileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ContentPartInputFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems), TypeInfoPropertyName = "EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput), TypeInfoPropertyName = "EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollection), TypeInfoPropertyName = "EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems), TypeInfoPropertyName = "EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderMaxPrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems), TypeInfoPropertyName = "EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems), TypeInfoPropertyName = "EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderSort), TypeInfoPropertyName = "EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding), TypeInfoPropertyName = "EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObject), TypeInfoPropertyName = "EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaObject), TypeInfoPropertyName = "EmbeddingsPostResponsesContentApplicationJsonSchemaObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaUsagePromptTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsCreateEmbeddingsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputModality), TypeInfoPropertyName = "InputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InstructType), TypeInfoPropertyName = "InstructType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputModality), TypeInfoPropertyName = "OutputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelGroup), TypeInfoPropertyName = "ModelGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelArchitecture))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.InputModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.OutputModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AABenchmarkEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DABenchmarkEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelBenchmarks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.DABenchmarkEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DefaultParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PerRequestLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PricingOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PublicPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.PricingOverride>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ReasoningEffort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Parameter), TypeInfoPropertyName = "Parameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.TopProviderInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.Parameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelsListResponseLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateEmbeddingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderName?), TypeInfoPropertyName = "NullableProviderName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PreferredMaxLatency?), TypeInfoPropertyName = "NullablePreferredMaxLatency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PreferredMinThroughput?), TypeInfoPropertyName = "NullablePreferredMinThroughput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Quantization?), TypeInfoPropertyName = "NullableQuantization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderSort?), TypeInfoPropertyName = "NullableProviderSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderSortConfigBy?), TypeInfoPropertyName = "NullableProviderSortConfigBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderSortConfigPartition?), TypeInfoPropertyName = "NullableProviderSortConfigPartition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningEffort?), TypeInfoPropertyName = "NullableReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormat?), TypeInfoPropertyName = "NullableEmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf0Type?), TypeInfoPropertyName = "NullableEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf0Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1Type?), TypeInfoPropertyName = "NullableEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ContentPartInputAudioType?), TypeInfoPropertyName = "NullableContentPartInputAudioType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ContentPartInputVideoType?), TypeInfoPropertyName = "NullableContentPartInputVideoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ContentPartInputFileType?), TypeInfoPropertyName = "NullableContentPartInputFileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems?), TypeInfoPropertyName = "NullableEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput?), TypeInfoPropertyName = "NullableEmbeddingsPostRequestBodyContentApplicationJsonSchemaInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollection?), TypeInfoPropertyName = "NullableEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems?), TypeInfoPropertyName = "NullableEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems?), TypeInfoPropertyName = "NullableEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems?), TypeInfoPropertyName = "NullableEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderSort?), TypeInfoPropertyName = "NullableEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding?), TypeInfoPropertyName = "NullableEmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbedding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObject?), TypeInfoPropertyName = "NullableEmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaObject?), TypeInfoPropertyName = "NullableEmbeddingsPostResponsesContentApplicationJsonSchemaObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputModality?), TypeInfoPropertyName = "NullableInputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InstructType?), TypeInfoPropertyName = "NullableInstructType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputModality?), TypeInfoPropertyName = "NullableOutputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelGroup?), TypeInfoPropertyName = "NullableModelGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Parameter?), TypeInfoPropertyName = "NullableParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.Quantization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.InputModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.OutputModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.DABenchmarkEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.PricingOverride>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ReasoningEffort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.Parameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.Model>))]
    internal sealed partial class EmbeddingsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EmbeddingsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static EmbeddingsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private EmbeddingsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::OpenRouter.JsonConverters.PreferredMaxLatencyJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.PreferredMinThroughputJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderSortJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsEmbeddingJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::OpenRouter.ProviderName)

                    || typeToConvert == typeof(global::OpenRouter.ProviderName?)

                    || typeToConvert == typeof(global::OpenRouter.Quantization)

                    || typeToConvert == typeof(global::OpenRouter.Quantization?)

                    || typeToConvert == typeof(global::OpenRouter.ProviderSort)

                    || typeToConvert == typeof(global::OpenRouter.ProviderSort?)

                    || typeToConvert == typeof(global::OpenRouter.ProviderSortConfigBy)

                    || typeToConvert == typeof(global::OpenRouter.ProviderSortConfigBy?)

                    || typeToConvert == typeof(global::OpenRouter.ProviderSortConfigPartition)

                    || typeToConvert == typeof(global::OpenRouter.ProviderSortConfigPartition?)

                    || typeToConvert == typeof(global::OpenRouter.ReasoningEffort)

                    || typeToConvert == typeof(global::OpenRouter.ReasoningEffort?)

                    || typeToConvert == typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormat)

                    || typeToConvert == typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormat?)

                    || typeToConvert == typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf0Type)

                    || typeToConvert == typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf0Type?)

                    || typeToConvert == typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1Type)

                    || typeToConvert == typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1Type?)

                    || typeToConvert == typeof(global::OpenRouter.ContentPartInputAudioType)

                    || typeToConvert == typeof(global::OpenRouter.ContentPartInputAudioType?)

                    || typeToConvert == typeof(global::OpenRouter.ContentPartInputVideoType)

                    || typeToConvert == typeof(global::OpenRouter.ContentPartInputVideoType?)

                    || typeToConvert == typeof(global::OpenRouter.ContentPartInputFileType)

                    || typeToConvert == typeof(global::OpenRouter.ContentPartInputFileType?)

                    || typeToConvert == typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollection)

                    || typeToConvert == typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollection?)

                    || typeToConvert == typeof(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObject)

                    || typeToConvert == typeof(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObject?)

                    || typeToConvert == typeof(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaObject)

                    || typeToConvert == typeof(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaObject?)

                    || typeToConvert == typeof(global::OpenRouter.InputModality)

                    || typeToConvert == typeof(global::OpenRouter.InputModality?)

                    || typeToConvert == typeof(global::OpenRouter.InstructType)

                    || typeToConvert == typeof(global::OpenRouter.InstructType?)

                    || typeToConvert == typeof(global::OpenRouter.OutputModality)

                    || typeToConvert == typeof(global::OpenRouter.OutputModality?)

                    || typeToConvert == typeof(global::OpenRouter.ModelGroup)

                    || typeToConvert == typeof(global::OpenRouter.ModelGroup?)

                    || typeToConvert == typeof(global::OpenRouter.Parameter)

                    || typeToConvert == typeof(global::OpenRouter.Parameter?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::OpenRouter.ProviderName))
                {
                    return new global::OpenRouter.JsonConverters.ProviderNameJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ProviderName?))
                {
                    return new global::OpenRouter.JsonConverters.ProviderNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.Quantization))
                {
                    return new global::OpenRouter.JsonConverters.QuantizationJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.Quantization?))
                {
                    return new global::OpenRouter.JsonConverters.QuantizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ProviderSort))
                {
                    return new global::OpenRouter.JsonConverters.ProviderSortJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ProviderSort?))
                {
                    return new global::OpenRouter.JsonConverters.ProviderSortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ProviderSortConfigBy))
                {
                    return new global::OpenRouter.JsonConverters.ProviderSortConfigByJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ProviderSortConfigBy?))
                {
                    return new global::OpenRouter.JsonConverters.ProviderSortConfigByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ProviderSortConfigPartition))
                {
                    return new global::OpenRouter.JsonConverters.ProviderSortConfigPartitionJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ProviderSortConfigPartition?))
                {
                    return new global::OpenRouter.JsonConverters.ProviderSortConfigPartitionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ReasoningEffort))
                {
                    return new global::OpenRouter.JsonConverters.ReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ReasoningEffort?))
                {
                    return new global::OpenRouter.JsonConverters.ReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormat))
                {
                    return new global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormat?))
                {
                    return new global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf0Type))
                {
                    return new global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf0TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf0Type?))
                {
                    return new global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf0TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1Type))
                {
                    return new global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1Type?))
                {
                    return new global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsOneOf1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ContentPartInputAudioType))
                {
                    return new global::OpenRouter.JsonConverters.ContentPartInputAudioTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ContentPartInputAudioType?))
                {
                    return new global::OpenRouter.JsonConverters.ContentPartInputAudioTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ContentPartInputVideoType))
                {
                    return new global::OpenRouter.JsonConverters.ContentPartInputVideoTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ContentPartInputVideoType?))
                {
                    return new global::OpenRouter.JsonConverters.ContentPartInputVideoTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ContentPartInputFileType))
                {
                    return new global::OpenRouter.JsonConverters.ContentPartInputFileTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ContentPartInputFileType?))
                {
                    return new global::OpenRouter.JsonConverters.ContentPartInputFileTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollection))
                {
                    return new global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollectionJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollection?))
                {
                    return new global::OpenRouter.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObject))
                {
                    return new global::OpenRouter.JsonConverters.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObject?))
                {
                    return new global::OpenRouter.JsonConverters.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaObject))
                {
                    return new global::OpenRouter.JsonConverters.EmbeddingsPostResponsesContentApplicationJsonSchemaObjectJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaObject?))
                {
                    return new global::OpenRouter.JsonConverters.EmbeddingsPostResponsesContentApplicationJsonSchemaObjectNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.InputModality))
                {
                    return new global::OpenRouter.JsonConverters.InputModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.InputModality?))
                {
                    return new global::OpenRouter.JsonConverters.InputModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.InstructType))
                {
                    return new global::OpenRouter.JsonConverters.InstructTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.InstructType?))
                {
                    return new global::OpenRouter.JsonConverters.InstructTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.OutputModality))
                {
                    return new global::OpenRouter.JsonConverters.OutputModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.OutputModality?))
                {
                    return new global::OpenRouter.JsonConverters.OutputModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ModelGroup))
                {
                    return new global::OpenRouter.JsonConverters.ModelGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ModelGroup?))
                {
                    return new global::OpenRouter.JsonConverters.ModelGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.Parameter))
                {
                    return new global::OpenRouter.JsonConverters.ParameterJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.Parameter?))
                {
                    return new global::OpenRouter.JsonConverters.ParameterNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new EmbeddingsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}