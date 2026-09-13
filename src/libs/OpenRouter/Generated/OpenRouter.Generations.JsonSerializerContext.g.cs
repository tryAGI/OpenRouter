
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.TooManyRequestsResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.TooManyRequestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InternalServerResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InternalServerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BadGatewayResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BadGatewayResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GenerationResponseDataApiType), TypeInfoPropertyName = "GenerationResponseDataApiType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GenerationResponseDataDataRegion), TypeInfoPropertyName = "GenerationResponseDataDataRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderResponseProviderName), TypeInfoPropertyName = "ProviderResponseProviderName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderResponseRoutedServiceTier), TypeInfoPropertyName = "ProviderResponseRoutedServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GenerationResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ProviderResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GenerationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GenerationContentDataInput0))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GenerationContentDataInput1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GenerationContentDataInput), TypeInfoPropertyName = "GenerationContentDataInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GenerationContentDataOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GenerationContentData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GenerationContentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.SubmitGenerationFeedbackRequestCategory), TypeInfoPropertyName = "SubmitGenerationFeedbackRequestCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.SubmitGenerationFeedbackRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.SubmitGenerationFeedbackResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.SubmitGenerationFeedbackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GenerationResponseDataApiType?), TypeInfoPropertyName = "NullableGenerationResponseDataApiType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GenerationResponseDataDataRegion?), TypeInfoPropertyName = "NullableGenerationResponseDataDataRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderResponseProviderName?), TypeInfoPropertyName = "NullableProviderResponseProviderName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ProviderResponseRoutedServiceTier?), TypeInfoPropertyName = "NullableProviderResponseRoutedServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GenerationContentDataInput?), TypeInfoPropertyName = "NullableGenerationContentDataInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.SubmitGenerationFeedbackRequestCategory?), TypeInfoPropertyName = "NullableSubmitGenerationFeedbackRequestCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ProviderResponse>))]
    internal sealed partial class GenerationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GenerationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GenerationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GenerationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::OpenRouter.JsonConverters.GenerationContentDataInputJsonConverter());
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
                    typeToConvert == typeof(global::OpenRouter.GenerationResponseDataApiType)

                    || typeToConvert == typeof(global::OpenRouter.GenerationResponseDataApiType?)

                    || typeToConvert == typeof(global::OpenRouter.GenerationResponseDataDataRegion)

                    || typeToConvert == typeof(global::OpenRouter.GenerationResponseDataDataRegion?)

                    || typeToConvert == typeof(global::OpenRouter.ProviderResponseProviderName)

                    || typeToConvert == typeof(global::OpenRouter.ProviderResponseProviderName?)

                    || typeToConvert == typeof(global::OpenRouter.ProviderResponseRoutedServiceTier)

                    || typeToConvert == typeof(global::OpenRouter.ProviderResponseRoutedServiceTier?)

                    || typeToConvert == typeof(global::OpenRouter.SubmitGenerationFeedbackRequestCategory)

                    || typeToConvert == typeof(global::OpenRouter.SubmitGenerationFeedbackRequestCategory?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::OpenRouter.GenerationResponseDataApiType))
                {
                    return new global::OpenRouter.JsonConverters.GenerationResponseDataApiTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GenerationResponseDataApiType?))
                {
                    return new global::OpenRouter.JsonConverters.GenerationResponseDataApiTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GenerationResponseDataDataRegion))
                {
                    return new global::OpenRouter.JsonConverters.GenerationResponseDataDataRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GenerationResponseDataDataRegion?))
                {
                    return new global::OpenRouter.JsonConverters.GenerationResponseDataDataRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ProviderResponseProviderName))
                {
                    return new global::OpenRouter.JsonConverters.ProviderResponseProviderNameJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ProviderResponseProviderName?))
                {
                    return new global::OpenRouter.JsonConverters.ProviderResponseProviderNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ProviderResponseRoutedServiceTier))
                {
                    return new global::OpenRouter.JsonConverters.ProviderResponseRoutedServiceTierJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ProviderResponseRoutedServiceTier?))
                {
                    return new global::OpenRouter.JsonConverters.ProviderResponseRoutedServiceTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.SubmitGenerationFeedbackRequestCategory))
                {
                    return new global::OpenRouter.JsonConverters.SubmitGenerationFeedbackRequestCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.SubmitGenerationFeedbackRequestCategory?))
                {
                    return new global::OpenRouter.JsonConverters.SubmitGenerationFeedbackRequestCategoryNullableJsonConverter();
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
                    0 => new GenerationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}