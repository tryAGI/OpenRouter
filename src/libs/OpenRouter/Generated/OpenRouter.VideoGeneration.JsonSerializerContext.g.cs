
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputReferenceDiscriminatorMappingImageUrlImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoGenerationRequestAspectRatio), TypeInfoPropertyName = "VideoGenerationRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FrameImageImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FrameImageType), TypeInfoPropertyName = "FrameImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FrameImageFrameType), TypeInfoPropertyName = "FrameImageFrameType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FrameImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputReferenceDiscriminatorMappingAudioUrlAudioUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputReferenceDiscriminatorMappingVideoUrlVideoUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputReference), TypeInfoPropertyName = "InputReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputReferenceVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputReferenceVariant1Type), TypeInfoPropertyName = "InputReferenceVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputReferenceVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputReferenceVariant2Type), TypeInfoPropertyName = "InputReferenceVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputReferenceVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputReferenceVariant3Type), TypeInfoPropertyName = "InputReferenceVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputReferenceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputReferenceDiscriminatorType), TypeInfoPropertyName = "InputReferenceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoGenerationRequestProviderOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoGenerationRequestProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoGenerationRequestResolution), TypeInfoPropertyName = "VideoGenerationRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.FrameImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.InputReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoGenerationResponseStatus), TypeInfoPropertyName = "VideoGenerationResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoGenerationUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoGenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoModelSupportedAspectRatiosItems), TypeInfoPropertyName = "VideoModelSupportedAspectRatiosItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoModelSupportedFrameImagesItems), TypeInfoPropertyName = "VideoModelSupportedFrameImagesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoModelSupportedResolutionsItems), TypeInfoPropertyName = "VideoModelSupportedResolutionsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoModelSupportedSizesItems), TypeInfoPropertyName = "VideoModelSupportedSizesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedAspectRatiosItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedFrameImagesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedResolutionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedSizesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoModelsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.VideoModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoGenerationRequestAspectRatio?), TypeInfoPropertyName = "NullableVideoGenerationRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FrameImageType?), TypeInfoPropertyName = "NullableFrameImageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.FrameImageFrameType?), TypeInfoPropertyName = "NullableFrameImageFrameType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputReference?), TypeInfoPropertyName = "NullableInputReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputReferenceVariant1Type?), TypeInfoPropertyName = "NullableInputReferenceVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputReferenceVariant2Type?), TypeInfoPropertyName = "NullableInputReferenceVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputReferenceVariant3Type?), TypeInfoPropertyName = "NullableInputReferenceVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputReferenceDiscriminatorType?), TypeInfoPropertyName = "NullableInputReferenceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoGenerationRequestResolution?), TypeInfoPropertyName = "NullableVideoGenerationRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoGenerationResponseStatus?), TypeInfoPropertyName = "NullableVideoGenerationResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoModelSupportedAspectRatiosItems?), TypeInfoPropertyName = "NullableVideoModelSupportedAspectRatiosItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoModelSupportedFrameImagesItems?), TypeInfoPropertyName = "NullableVideoModelSupportedFrameImagesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoModelSupportedResolutionsItems?), TypeInfoPropertyName = "NullableVideoModelSupportedResolutionsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.VideoModelSupportedSizesItems?), TypeInfoPropertyName = "NullableVideoModelSupportedSizesItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.FrameImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.InputReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.VideoModelSupportedAspectRatiosItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.VideoModelSupportedFrameImagesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.VideoModelSupportedResolutionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.VideoModelSupportedSizesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.VideoModel>))]
    internal sealed partial class VideoGenerationSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VideoGenerationSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VideoGenerationSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VideoGenerationSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::OpenRouter.JsonConverters.InputReferenceJsonConverter());
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
                    typeToConvert == typeof(global::OpenRouter.VideoGenerationRequestAspectRatio)

                    || typeToConvert == typeof(global::OpenRouter.VideoGenerationRequestAspectRatio?)

                    || typeToConvert == typeof(global::OpenRouter.FrameImageType)

                    || typeToConvert == typeof(global::OpenRouter.FrameImageType?)

                    || typeToConvert == typeof(global::OpenRouter.FrameImageFrameType)

                    || typeToConvert == typeof(global::OpenRouter.FrameImageFrameType?)

                    || typeToConvert == typeof(global::OpenRouter.InputReferenceVariant1Type)

                    || typeToConvert == typeof(global::OpenRouter.InputReferenceVariant1Type?)

                    || typeToConvert == typeof(global::OpenRouter.InputReferenceVariant2Type)

                    || typeToConvert == typeof(global::OpenRouter.InputReferenceVariant2Type?)

                    || typeToConvert == typeof(global::OpenRouter.InputReferenceVariant3Type)

                    || typeToConvert == typeof(global::OpenRouter.InputReferenceVariant3Type?)

                    || typeToConvert == typeof(global::OpenRouter.InputReferenceDiscriminatorType)

                    || typeToConvert == typeof(global::OpenRouter.InputReferenceDiscriminatorType?)

                    || typeToConvert == typeof(global::OpenRouter.VideoGenerationRequestResolution)

                    || typeToConvert == typeof(global::OpenRouter.VideoGenerationRequestResolution?)

                    || typeToConvert == typeof(global::OpenRouter.VideoGenerationResponseStatus)

                    || typeToConvert == typeof(global::OpenRouter.VideoGenerationResponseStatus?)

                    || typeToConvert == typeof(global::OpenRouter.VideoModelSupportedAspectRatiosItems)

                    || typeToConvert == typeof(global::OpenRouter.VideoModelSupportedAspectRatiosItems?)

                    || typeToConvert == typeof(global::OpenRouter.VideoModelSupportedFrameImagesItems)

                    || typeToConvert == typeof(global::OpenRouter.VideoModelSupportedFrameImagesItems?)

                    || typeToConvert == typeof(global::OpenRouter.VideoModelSupportedResolutionsItems)

                    || typeToConvert == typeof(global::OpenRouter.VideoModelSupportedResolutionsItems?)

                    || typeToConvert == typeof(global::OpenRouter.VideoModelSupportedSizesItems)

                    || typeToConvert == typeof(global::OpenRouter.VideoModelSupportedSizesItems?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::OpenRouter.VideoGenerationRequestAspectRatio))
                {
                    return new global::OpenRouter.JsonConverters.VideoGenerationRequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.VideoGenerationRequestAspectRatio?))
                {
                    return new global::OpenRouter.JsonConverters.VideoGenerationRequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.FrameImageType))
                {
                    return new global::OpenRouter.JsonConverters.FrameImageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.FrameImageType?))
                {
                    return new global::OpenRouter.JsonConverters.FrameImageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.FrameImageFrameType))
                {
                    return new global::OpenRouter.JsonConverters.FrameImageFrameTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.FrameImageFrameType?))
                {
                    return new global::OpenRouter.JsonConverters.FrameImageFrameTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.InputReferenceVariant1Type))
                {
                    return new global::OpenRouter.JsonConverters.InputReferenceVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.InputReferenceVariant1Type?))
                {
                    return new global::OpenRouter.JsonConverters.InputReferenceVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.InputReferenceVariant2Type))
                {
                    return new global::OpenRouter.JsonConverters.InputReferenceVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.InputReferenceVariant2Type?))
                {
                    return new global::OpenRouter.JsonConverters.InputReferenceVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.InputReferenceVariant3Type))
                {
                    return new global::OpenRouter.JsonConverters.InputReferenceVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.InputReferenceVariant3Type?))
                {
                    return new global::OpenRouter.JsonConverters.InputReferenceVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.InputReferenceDiscriminatorType))
                {
                    return new global::OpenRouter.JsonConverters.InputReferenceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.InputReferenceDiscriminatorType?))
                {
                    return new global::OpenRouter.JsonConverters.InputReferenceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.VideoGenerationRequestResolution))
                {
                    return new global::OpenRouter.JsonConverters.VideoGenerationRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.VideoGenerationRequestResolution?))
                {
                    return new global::OpenRouter.JsonConverters.VideoGenerationRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.VideoGenerationResponseStatus))
                {
                    return new global::OpenRouter.JsonConverters.VideoGenerationResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.VideoGenerationResponseStatus?))
                {
                    return new global::OpenRouter.JsonConverters.VideoGenerationResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.VideoModelSupportedAspectRatiosItems))
                {
                    return new global::OpenRouter.JsonConverters.VideoModelSupportedAspectRatiosItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.VideoModelSupportedAspectRatiosItems?))
                {
                    return new global::OpenRouter.JsonConverters.VideoModelSupportedAspectRatiosItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.VideoModelSupportedFrameImagesItems))
                {
                    return new global::OpenRouter.JsonConverters.VideoModelSupportedFrameImagesItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.VideoModelSupportedFrameImagesItems?))
                {
                    return new global::OpenRouter.JsonConverters.VideoModelSupportedFrameImagesItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.VideoModelSupportedResolutionsItems))
                {
                    return new global::OpenRouter.JsonConverters.VideoModelSupportedResolutionsItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.VideoModelSupportedResolutionsItems?))
                {
                    return new global::OpenRouter.JsonConverters.VideoModelSupportedResolutionsItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.VideoModelSupportedSizesItems))
                {
                    return new global::OpenRouter.JsonConverters.VideoModelSupportedSizesItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.VideoModelSupportedSizesItems?))
                {
                    return new global::OpenRouter.JsonConverters.VideoModelSupportedSizesItemsNullableJsonConverter();
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
                    0 => new VideoGenerationSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}