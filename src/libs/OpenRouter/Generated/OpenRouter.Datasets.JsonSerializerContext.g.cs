
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BadRequestResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BadRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnauthorizedResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnauthorizedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.TooManyRequestsResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.TooManyRequestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InternalServerResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InternalServerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatasetsAppRankingsGetParametersCategory), TypeInfoPropertyName = "DatasetsAppRankingsGetParametersCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatasetsAppRankingsGetParametersSubcategory), TypeInfoPropertyName = "DatasetsAppRankingsGetParametersSubcategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatasetsAppRankingsGetParametersSort), TypeInfoPropertyName = "DatasetsAppRankingsGetParametersSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AppRankingsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RankingsDailyMetaVersion), TypeInfoPropertyName = "RankingsDailyMetaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RankingsDailyMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.AppRankingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.AppRankingsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersPeriod), TypeInfoPropertyName = "DatasetsRankingsDailyGetParametersPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersModality), TypeInfoPropertyName = "DatasetsRankingsDailyGetParametersModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersContextBucket), TypeInfoPropertyName = "DatasetsRankingsDailyGetParametersContextBucket2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersCategory), TypeInfoPropertyName = "DatasetsRankingsDailyGetParametersCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersLanguageType), TypeInfoPropertyName = "DatasetsRankingsDailyGetParametersLanguageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RankingsDailyItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RankingsDailyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.RankingsDailyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatasetsAppRankingsGetParametersCategory?), TypeInfoPropertyName = "NullableDatasetsAppRankingsGetParametersCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatasetsAppRankingsGetParametersSubcategory?), TypeInfoPropertyName = "NullableDatasetsAppRankingsGetParametersSubcategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatasetsAppRankingsGetParametersSort?), TypeInfoPropertyName = "NullableDatasetsAppRankingsGetParametersSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.RankingsDailyMetaVersion?), TypeInfoPropertyName = "NullableRankingsDailyMetaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersPeriod?), TypeInfoPropertyName = "NullableDatasetsRankingsDailyGetParametersPeriod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersModality?), TypeInfoPropertyName = "NullableDatasetsRankingsDailyGetParametersModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersContextBucket?), TypeInfoPropertyName = "NullableDatasetsRankingsDailyGetParametersContextBucket2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersCategory?), TypeInfoPropertyName = "NullableDatasetsRankingsDailyGetParametersCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersLanguageType?), TypeInfoPropertyName = "NullableDatasetsRankingsDailyGetParametersLanguageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.AppRankingsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.RankingsDailyItem>))]
    internal sealed partial class DatasetsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DatasetsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DatasetsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DatasetsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::OpenRouter.DatasetsAppRankingsGetParametersCategory)

                    || typeToConvert == typeof(global::OpenRouter.DatasetsAppRankingsGetParametersCategory?)

                    || typeToConvert == typeof(global::OpenRouter.DatasetsAppRankingsGetParametersSubcategory)

                    || typeToConvert == typeof(global::OpenRouter.DatasetsAppRankingsGetParametersSubcategory?)

                    || typeToConvert == typeof(global::OpenRouter.DatasetsAppRankingsGetParametersSort)

                    || typeToConvert == typeof(global::OpenRouter.DatasetsAppRankingsGetParametersSort?)

                    || typeToConvert == typeof(global::OpenRouter.RankingsDailyMetaVersion)

                    || typeToConvert == typeof(global::OpenRouter.RankingsDailyMetaVersion?)

                    || typeToConvert == typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersPeriod)

                    || typeToConvert == typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersPeriod?)

                    || typeToConvert == typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersModality)

                    || typeToConvert == typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersModality?)

                    || typeToConvert == typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersContextBucket)

                    || typeToConvert == typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersContextBucket?)

                    || typeToConvert == typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersCategory)

                    || typeToConvert == typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersCategory?)

                    || typeToConvert == typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersLanguageType)

                    || typeToConvert == typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersLanguageType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::OpenRouter.DatasetsAppRankingsGetParametersCategory))
                {
                    return new global::OpenRouter.JsonConverters.DatasetsAppRankingsGetParametersCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.DatasetsAppRankingsGetParametersCategory?))
                {
                    return new global::OpenRouter.JsonConverters.DatasetsAppRankingsGetParametersCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.DatasetsAppRankingsGetParametersSubcategory))
                {
                    return new global::OpenRouter.JsonConverters.DatasetsAppRankingsGetParametersSubcategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.DatasetsAppRankingsGetParametersSubcategory?))
                {
                    return new global::OpenRouter.JsonConverters.DatasetsAppRankingsGetParametersSubcategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.DatasetsAppRankingsGetParametersSort))
                {
                    return new global::OpenRouter.JsonConverters.DatasetsAppRankingsGetParametersSortJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.DatasetsAppRankingsGetParametersSort?))
                {
                    return new global::OpenRouter.JsonConverters.DatasetsAppRankingsGetParametersSortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.RankingsDailyMetaVersion))
                {
                    return new global::OpenRouter.JsonConverters.RankingsDailyMetaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.RankingsDailyMetaVersion?))
                {
                    return new global::OpenRouter.JsonConverters.RankingsDailyMetaVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersPeriod))
                {
                    return new global::OpenRouter.JsonConverters.DatasetsRankingsDailyGetParametersPeriodJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersPeriod?))
                {
                    return new global::OpenRouter.JsonConverters.DatasetsRankingsDailyGetParametersPeriodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersModality))
                {
                    return new global::OpenRouter.JsonConverters.DatasetsRankingsDailyGetParametersModalityJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersModality?))
                {
                    return new global::OpenRouter.JsonConverters.DatasetsRankingsDailyGetParametersModalityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersContextBucket))
                {
                    return new global::OpenRouter.JsonConverters.DatasetsRankingsDailyGetParametersContextBucketJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersContextBucket?))
                {
                    return new global::OpenRouter.JsonConverters.DatasetsRankingsDailyGetParametersContextBucketNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersCategory))
                {
                    return new global::OpenRouter.JsonConverters.DatasetsRankingsDailyGetParametersCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersCategory?))
                {
                    return new global::OpenRouter.JsonConverters.DatasetsRankingsDailyGetParametersCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersLanguageType))
                {
                    return new global::OpenRouter.JsonConverters.DatasetsRankingsDailyGetParametersLanguageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.DatasetsRankingsDailyGetParametersLanguageType?))
                {
                    return new global::OpenRouter.JsonConverters.DatasetsRankingsDailyGetParametersLanguageTypeNullableJsonConverter();
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
                    0 => new DatasetsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}