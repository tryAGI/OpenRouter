
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderSort), TypeInfoPropertyName = "ProviderSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderSortConfigBy), TypeInfoPropertyName = "ProviderSortConfigBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderSortConfigPartition), TypeInfoPropertyName = "ProviderSortConfigPartition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderSortConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BadRequestResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BadRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnauthorizedResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnauthorizedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PaymentRequiredResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PaymentRequiredResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ForbiddenResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ForbiddenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.NotFoundResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.NotFoundResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PayloadTooLargeResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PayloadTooLargeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.TooManyRequestsResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.TooManyRequestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InternalServerResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InternalServerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BadGatewayResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BadGatewayResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationRequestAspectRatio), TypeInfoPropertyName = "ImageGenerationRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationRequestBackground), TypeInfoPropertyName = "ImageGenerationRequestBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputReferenceDiscriminatorMappingImageUrlImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ContentPartImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationRequestOutputFormat), TypeInfoPropertyName = "ImageGenerationRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationProviderPreferencesIgnoreItems), TypeInfoPropertyName = "ImageGenerationProviderPreferencesIgnoreItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationProviderPreferencesOnlyItems), TypeInfoPropertyName = "ImageGenerationProviderPreferencesOnlyItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationProviderPreferencesOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationProviderPreferencesOrderItems), TypeInfoPropertyName = "ImageGenerationProviderPreferencesOrderItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationProviderPreferencesSort), TypeInfoPropertyName = "ImageGenerationProviderPreferencesSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationProviderPreferences))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ImageGenerationProviderPreferencesIgnoreItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ImageGenerationProviderPreferencesOnlyItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ImageGenerationProviderPreferencesOrderItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationRequestQuality), TypeInfoPropertyName = "ImageGenerationRequestQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationRequestResolution), TypeInfoPropertyName = "ImageGenerationRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ContentPartImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationResponseDataItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCacheCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationUsageCompletionTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CostDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicIterationCacheCreation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCompactionUsageIterationType), TypeInfoPropertyName = "AnthropicCompactionUsageIterationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCompactionUsageIteration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicMessageUsageIterationType), TypeInfoPropertyName = "AnthropicMessageUsageIterationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicMessageUsageIteration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicAdvisorMessageUsageIterationType), TypeInfoPropertyName = "AnthropicAdvisorMessageUsageIterationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicAdvisorMessageUsageIteration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicUnknownUsageIteration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicUsageIteration), TypeInfoPropertyName = "AnthropicUsageIteration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationUsagePromptTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationUsageServerToolUse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicSpeed), TypeInfoPropertyName = "AnthropicSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnthropicUsageIteration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ImageGenerationResponseDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageInputModality), TypeInfoPropertyName = "ImageInputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageOutputModality), TypeInfoPropertyName = "ImageOutputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageModelArchitecture))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ImageInputModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ImageOutputModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EnumCapabilityType), TypeInfoPropertyName = "EnumCapabilityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RangeCapabilityType), TypeInfoPropertyName = "RangeCapabilityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CapabilityDescriptor), TypeInfoPropertyName = "CapabilityDescriptor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CapabilityDescriptorVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CapabilityDescriptorVariant1Type), TypeInfoPropertyName = "CapabilityDescriptorVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CapabilityDescriptorVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CapabilityDescriptorVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CapabilityDescriptorDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CapabilityDescriptorDiscriminatorType), TypeInfoPropertyName = "CapabilityDescriptorDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::OpenRouter.CapabilityDescriptor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageModelListItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageModelsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ImageModelListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImagePricingEntryBillable), TypeInfoPropertyName = "ImagePricingEntryBillable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImagePricingEntryUnit), TypeInfoPropertyName = "ImagePricingEntryUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImagePricingEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageEndpoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ImagePricingEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageModelEndpointsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ImageEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderName?), TypeInfoPropertyName = "NullableProviderName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderSort?), TypeInfoPropertyName = "NullableProviderSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderSortConfigBy?), TypeInfoPropertyName = "NullableProviderSortConfigBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderSortConfigPartition?), TypeInfoPropertyName = "NullableProviderSortConfigPartition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationRequestAspectRatio?), TypeInfoPropertyName = "NullableImageGenerationRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationRequestBackground?), TypeInfoPropertyName = "NullableImageGenerationRequestBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationRequestOutputFormat?), TypeInfoPropertyName = "NullableImageGenerationRequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationProviderPreferencesIgnoreItems?), TypeInfoPropertyName = "NullableImageGenerationProviderPreferencesIgnoreItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationProviderPreferencesOnlyItems?), TypeInfoPropertyName = "NullableImageGenerationProviderPreferencesOnlyItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationProviderPreferencesOrderItems?), TypeInfoPropertyName = "NullableImageGenerationProviderPreferencesOrderItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationProviderPreferencesSort?), TypeInfoPropertyName = "NullableImageGenerationProviderPreferencesSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationRequestQuality?), TypeInfoPropertyName = "NullableImageGenerationRequestQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageGenerationRequestResolution?), TypeInfoPropertyName = "NullableImageGenerationRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicCompactionUsageIterationType?), TypeInfoPropertyName = "NullableAnthropicCompactionUsageIterationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicMessageUsageIterationType?), TypeInfoPropertyName = "NullableAnthropicMessageUsageIterationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicAdvisorMessageUsageIterationType?), TypeInfoPropertyName = "NullableAnthropicAdvisorMessageUsageIterationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicUsageIteration?), TypeInfoPropertyName = "NullableAnthropicUsageIteration2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnthropicSpeed?), TypeInfoPropertyName = "NullableAnthropicSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageInputModality?), TypeInfoPropertyName = "NullableImageInputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImageOutputModality?), TypeInfoPropertyName = "NullableImageOutputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.EnumCapabilityType?), TypeInfoPropertyName = "NullableEnumCapabilityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RangeCapabilityType?), TypeInfoPropertyName = "NullableRangeCapabilityType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CapabilityDescriptor?), TypeInfoPropertyName = "NullableCapabilityDescriptor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CapabilityDescriptorVariant1Type?), TypeInfoPropertyName = "NullableCapabilityDescriptorVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CapabilityDescriptorDiscriminatorType?), TypeInfoPropertyName = "NullableCapabilityDescriptorDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImagePricingEntryBillable?), TypeInfoPropertyName = "NullableImagePricingEntryBillable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ImagePricingEntryUnit?), TypeInfoPropertyName = "NullableImagePricingEntryUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ImageGenerationProviderPreferencesIgnoreItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ImageGenerationProviderPreferencesOnlyItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ImageGenerationProviderPreferencesOrderItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ContentPartImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnthropicUsageIteration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ImageGenerationResponseDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ImageInputModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ImageOutputModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ImageModelListItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ImagePricingEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ImageEndpoint>))]
    internal sealed partial class ImagesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImagesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ImagesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ImagesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::OpenRouter.JsonConverters.ImageGenerationProviderPreferencesIgnoreItemsJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.ImageGenerationProviderPreferencesOnlyItemsJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.ImageGenerationProviderPreferencesOrderItemsJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.ImageGenerationProviderPreferencesSortJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.AnthropicUsageIterationJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.CapabilityDescriptorJsonConverter());
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

                    || typeToConvert == typeof(global::OpenRouter.ProviderSort)

                    || typeToConvert == typeof(global::OpenRouter.ProviderSort?)

                    || typeToConvert == typeof(global::OpenRouter.ProviderSortConfigBy)

                    || typeToConvert == typeof(global::OpenRouter.ProviderSortConfigBy?)

                    || typeToConvert == typeof(global::OpenRouter.ProviderSortConfigPartition)

                    || typeToConvert == typeof(global::OpenRouter.ProviderSortConfigPartition?)

                    || typeToConvert == typeof(global::OpenRouter.ImageGenerationRequestAspectRatio)

                    || typeToConvert == typeof(global::OpenRouter.ImageGenerationRequestAspectRatio?)

                    || typeToConvert == typeof(global::OpenRouter.ImageGenerationRequestBackground)

                    || typeToConvert == typeof(global::OpenRouter.ImageGenerationRequestBackground?)

                    || typeToConvert == typeof(global::OpenRouter.ImageGenerationRequestOutputFormat)

                    || typeToConvert == typeof(global::OpenRouter.ImageGenerationRequestOutputFormat?)

                    || typeToConvert == typeof(global::OpenRouter.ImageGenerationRequestQuality)

                    || typeToConvert == typeof(global::OpenRouter.ImageGenerationRequestQuality?)

                    || typeToConvert == typeof(global::OpenRouter.ImageGenerationRequestResolution)

                    || typeToConvert == typeof(global::OpenRouter.ImageGenerationRequestResolution?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicCompactionUsageIterationType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicCompactionUsageIterationType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicMessageUsageIterationType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicMessageUsageIterationType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicAdvisorMessageUsageIterationType)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicAdvisorMessageUsageIterationType?)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicSpeed)

                    || typeToConvert == typeof(global::OpenRouter.AnthropicSpeed?)

                    || typeToConvert == typeof(global::OpenRouter.ImageInputModality)

                    || typeToConvert == typeof(global::OpenRouter.ImageInputModality?)

                    || typeToConvert == typeof(global::OpenRouter.ImageOutputModality)

                    || typeToConvert == typeof(global::OpenRouter.ImageOutputModality?)

                    || typeToConvert == typeof(global::OpenRouter.EnumCapabilityType)

                    || typeToConvert == typeof(global::OpenRouter.EnumCapabilityType?)

                    || typeToConvert == typeof(global::OpenRouter.RangeCapabilityType)

                    || typeToConvert == typeof(global::OpenRouter.RangeCapabilityType?)

                    || typeToConvert == typeof(global::OpenRouter.CapabilityDescriptorVariant1Type)

                    || typeToConvert == typeof(global::OpenRouter.CapabilityDescriptorVariant1Type?)

                    || typeToConvert == typeof(global::OpenRouter.CapabilityDescriptorDiscriminatorType)

                    || typeToConvert == typeof(global::OpenRouter.CapabilityDescriptorDiscriminatorType?)

                    || typeToConvert == typeof(global::OpenRouter.ImagePricingEntryBillable)

                    || typeToConvert == typeof(global::OpenRouter.ImagePricingEntryBillable?)

                    || typeToConvert == typeof(global::OpenRouter.ImagePricingEntryUnit)

                    || typeToConvert == typeof(global::OpenRouter.ImagePricingEntryUnit?);
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

                if (typeToConvert == typeof(global::OpenRouter.ImageGenerationRequestAspectRatio))
                {
                    return new global::OpenRouter.JsonConverters.ImageGenerationRequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ImageGenerationRequestAspectRatio?))
                {
                    return new global::OpenRouter.JsonConverters.ImageGenerationRequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ImageGenerationRequestBackground))
                {
                    return new global::OpenRouter.JsonConverters.ImageGenerationRequestBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ImageGenerationRequestBackground?))
                {
                    return new global::OpenRouter.JsonConverters.ImageGenerationRequestBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ImageGenerationRequestOutputFormat))
                {
                    return new global::OpenRouter.JsonConverters.ImageGenerationRequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ImageGenerationRequestOutputFormat?))
                {
                    return new global::OpenRouter.JsonConverters.ImageGenerationRequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ImageGenerationRequestQuality))
                {
                    return new global::OpenRouter.JsonConverters.ImageGenerationRequestQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ImageGenerationRequestQuality?))
                {
                    return new global::OpenRouter.JsonConverters.ImageGenerationRequestQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ImageGenerationRequestResolution))
                {
                    return new global::OpenRouter.JsonConverters.ImageGenerationRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ImageGenerationRequestResolution?))
                {
                    return new global::OpenRouter.JsonConverters.ImageGenerationRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicCompactionUsageIterationType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicCompactionUsageIterationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicCompactionUsageIterationType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicCompactionUsageIterationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicMessageUsageIterationType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicMessageUsageIterationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicMessageUsageIterationType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicMessageUsageIterationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicAdvisorMessageUsageIterationType))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicAdvisorMessageUsageIterationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicAdvisorMessageUsageIterationType?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicAdvisorMessageUsageIterationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicSpeed))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicSpeedJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnthropicSpeed?))
                {
                    return new global::OpenRouter.JsonConverters.AnthropicSpeedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ImageInputModality))
                {
                    return new global::OpenRouter.JsonConverters.ImageInputModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ImageInputModality?))
                {
                    return new global::OpenRouter.JsonConverters.ImageInputModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ImageOutputModality))
                {
                    return new global::OpenRouter.JsonConverters.ImageOutputModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ImageOutputModality?))
                {
                    return new global::OpenRouter.JsonConverters.ImageOutputModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.EnumCapabilityType))
                {
                    return new global::OpenRouter.JsonConverters.EnumCapabilityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.EnumCapabilityType?))
                {
                    return new global::OpenRouter.JsonConverters.EnumCapabilityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.RangeCapabilityType))
                {
                    return new global::OpenRouter.JsonConverters.RangeCapabilityTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.RangeCapabilityType?))
                {
                    return new global::OpenRouter.JsonConverters.RangeCapabilityTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CapabilityDescriptorVariant1Type))
                {
                    return new global::OpenRouter.JsonConverters.CapabilityDescriptorVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CapabilityDescriptorVariant1Type?))
                {
                    return new global::OpenRouter.JsonConverters.CapabilityDescriptorVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CapabilityDescriptorDiscriminatorType))
                {
                    return new global::OpenRouter.JsonConverters.CapabilityDescriptorDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.CapabilityDescriptorDiscriminatorType?))
                {
                    return new global::OpenRouter.JsonConverters.CapabilityDescriptorDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ImagePricingEntryBillable))
                {
                    return new global::OpenRouter.JsonConverters.ImagePricingEntryBillableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ImagePricingEntryBillable?))
                {
                    return new global::OpenRouter.JsonConverters.ImagePricingEntryBillableNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ImagePricingEntryUnit))
                {
                    return new global::OpenRouter.JsonConverters.ImagePricingEntryUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ImagePricingEntryUnit?))
                {
                    return new global::OpenRouter.JsonConverters.ImagePricingEntryUnitNullableJsonConverter();
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
                    0 => new ImagesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}