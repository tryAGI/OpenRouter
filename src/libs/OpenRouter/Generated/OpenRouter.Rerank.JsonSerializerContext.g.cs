
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems), TypeInfoPropertyName = "RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderDataCollection), TypeInfoPropertyName = "RerankPostRequestBodyContentApplicationJsonSchemaProviderDataCollection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems), TypeInfoPropertyName = "RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderMaxPrice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems), TypeInfoPropertyName = "RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems), TypeInfoPropertyName = "RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderSort), TypeInfoPropertyName = "RerankPostRequestBodyContentApplicationJsonSchemaProviderSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostResponsesContentApplicationJsonSchemaResultsItemsDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostResponsesContentApplicationJsonSchemaResultsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostResponsesContentApplicationJsonSchemaUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankCreateRerankResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.RerankPostResponsesContentApplicationJsonSchemaResultsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateRerankRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems?), TypeInfoPropertyName = "NullableRerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderDataCollection?), TypeInfoPropertyName = "NullableRerankPostRequestBodyContentApplicationJsonSchemaProviderDataCollection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems?), TypeInfoPropertyName = "NullableRerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems?), TypeInfoPropertyName = "NullableRerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems?), TypeInfoPropertyName = "NullableRerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderSort?), TypeInfoPropertyName = "NullableRerankPostRequestBodyContentApplicationJsonSchemaProviderSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.Quantization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.RerankPostResponsesContentApplicationJsonSchemaResultsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems>))]
    internal sealed partial class RerankSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RerankSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static RerankSourceGenerationContext Default { get; } = new(DefaultOptions);

        private RerankSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::OpenRouter.JsonConverters.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.RerankPostRequestBodyContentApplicationJsonSchemaProviderSortJsonConverter());
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

                    || typeToConvert == typeof(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderDataCollection)

                    || typeToConvert == typeof(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderDataCollection?);
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

                if (typeToConvert == typeof(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderDataCollection))
                {
                    return new global::OpenRouter.JsonConverters.RerankPostRequestBodyContentApplicationJsonSchemaProviderDataCollectionJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProviderDataCollection?))
                {
                    return new global::OpenRouter.JsonConverters.RerankPostRequestBodyContentApplicationJsonSchemaProviderDataCollectionNullableJsonConverter();
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
                    0 => new RerankSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}