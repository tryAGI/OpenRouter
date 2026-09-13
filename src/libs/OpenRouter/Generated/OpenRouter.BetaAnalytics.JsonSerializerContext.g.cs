
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ForbiddenResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ForbiddenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RequestTimeoutResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RequestTimeoutResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InternalServerResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InternalServerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataDimensionsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItemsName), TypeInfoPropertyName = "AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItemsName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItemsDisplayFormat), TypeInfoPropertyName = "AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItemsDisplayFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName), TypeInfoPropertyName = "AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsValueType), TypeInfoPropertyName = "AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsValueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataDimensionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BetaAnalyticsGetAnalyticsMetaResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierDimensions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items), TypeInfoPropertyName = "AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue), TypeInfoPropertyName = "AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFilters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items), TypeInfoPropertyName = "AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue), TypeInfoPropertyName = "AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirection), TypeInfoPropertyName = "AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaTimeRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsQueryPostResponsesContentApplicationJsonSchemaDataDataItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsQueryPostResponsesContentApplicationJsonSchemaDataMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsQueryPostResponsesContentApplicationJsonSchemaData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostResponsesContentApplicationJsonSchemaDataDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BetaAnalyticsQueryAnalyticsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.QueryAnalyticsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItemsName?), TypeInfoPropertyName = "NullableAnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItemsName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItemsDisplayFormat?), TypeInfoPropertyName = "NullableAnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItemsDisplayFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName?), TypeInfoPropertyName = "NullableAnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsValueType?), TypeInfoPropertyName = "NullableAnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsValueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items?), TypeInfoPropertyName = "NullableAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue?), TypeInfoPropertyName = "NullableAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items?), TypeInfoPropertyName = "NullableAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue?), TypeInfoPropertyName = "NullableAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirection?), TypeInfoPropertyName = "NullableAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataDimensionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnalyticsQueryPostResponsesContentApplicationJsonSchemaDataDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItems>))]
    internal sealed partial class BetaAnalyticsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaAnalyticsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BetaAnalyticsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BetaAnalyticsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::OpenRouter.JsonConverters.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsJsonConverter());
            options.Converters.Add(new global::OpenRouter.JsonConverters.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueJsonConverter());
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
                    typeToConvert == typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItemsName)

                    || typeToConvert == typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItemsName?)

                    || typeToConvert == typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItemsDisplayFormat)

                    || typeToConvert == typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItemsDisplayFormat?)

                    || typeToConvert == typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName)

                    || typeToConvert == typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName?)

                    || typeToConvert == typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsValueType)

                    || typeToConvert == typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsValueType?)

                    || typeToConvert == typeof(global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirection)

                    || typeToConvert == typeof(global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirection?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItemsName))
                {
                    return new global::OpenRouter.JsonConverters.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItemsNameJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItemsName?))
                {
                    return new global::OpenRouter.JsonConverters.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataGranularitiesItemsNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItemsDisplayFormat))
                {
                    return new global::OpenRouter.JsonConverters.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItemsDisplayFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItemsDisplayFormat?))
                {
                    return new global::OpenRouter.JsonConverters.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItemsDisplayFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName))
                {
                    return new global::OpenRouter.JsonConverters.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsNameJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsName?))
                {
                    return new global::OpenRouter.JsonConverters.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsValueType))
                {
                    return new global::OpenRouter.JsonConverters.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsValueTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsValueType?))
                {
                    return new global::OpenRouter.JsonConverters.AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataOperatorsItemsValueTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirection))
                {
                    return new global::OpenRouter.JsonConverters.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirection?))
                {
                    return new global::OpenRouter.JsonConverters.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirectionNullableJsonConverter();
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
                    0 => new BetaAnalyticsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}