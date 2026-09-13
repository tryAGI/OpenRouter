
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BenchmarksGetParametersSource), TypeInfoPropertyName = "BenchmarksGetParametersSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BenchmarksGetParametersTaskType), TypeInfoPropertyName = "BenchmarksGetParametersTaskType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BenchmarksGetParametersArena), TypeInfoPropertyName = "BenchmarksGetParametersArena2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnifiedBenchmarkPricing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsDiscriminatorMappingDesignArenaTournamentStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItems), TypeInfoPropertyName = "UnifiedBenchmarksResponseDataItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1Source), TypeInfoPropertyName = "UnifiedBenchmarksResponseDataItemsVariant1Source2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2Source), TypeInfoPropertyName = "UnifiedBenchmarksResponseDataItemsVariant2Source2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsDiscriminatorSource), TypeInfoPropertyName = "UnifiedBenchmarksResponseDataItemsDiscriminatorSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnifiedBenchmarksMetaSource), TypeInfoPropertyName = "UnifiedBenchmarksMetaSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnifiedBenchmarksMetaVersion), TypeInfoPropertyName = "UnifiedBenchmarksMetaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnifiedBenchmarksMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnifiedBenchmarksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.UnifiedBenchmarksResponseDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BenchmarksGetParametersSource?), TypeInfoPropertyName = "NullableBenchmarksGetParametersSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BenchmarksGetParametersTaskType?), TypeInfoPropertyName = "NullableBenchmarksGetParametersTaskType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BenchmarksGetParametersArena?), TypeInfoPropertyName = "NullableBenchmarksGetParametersArena2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItems?), TypeInfoPropertyName = "NullableUnifiedBenchmarksResponseDataItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1Source?), TypeInfoPropertyName = "NullableUnifiedBenchmarksResponseDataItemsVariant1Source2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2Source?), TypeInfoPropertyName = "NullableUnifiedBenchmarksResponseDataItemsVariant2Source2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsDiscriminatorSource?), TypeInfoPropertyName = "NullableUnifiedBenchmarksResponseDataItemsDiscriminatorSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnifiedBenchmarksMetaSource?), TypeInfoPropertyName = "NullableUnifiedBenchmarksMetaSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnifiedBenchmarksMetaVersion?), TypeInfoPropertyName = "NullableUnifiedBenchmarksMetaVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.UnifiedBenchmarksResponseDataItems>))]
    internal sealed partial class BenchmarksSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BenchmarksSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BenchmarksSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BenchmarksSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::OpenRouter.JsonConverters.UnifiedBenchmarksResponseDataItemsJsonConverter());
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
                    typeToConvert == typeof(global::OpenRouter.BenchmarksGetParametersSource)

                    || typeToConvert == typeof(global::OpenRouter.BenchmarksGetParametersSource?)

                    || typeToConvert == typeof(global::OpenRouter.BenchmarksGetParametersTaskType)

                    || typeToConvert == typeof(global::OpenRouter.BenchmarksGetParametersTaskType?)

                    || typeToConvert == typeof(global::OpenRouter.BenchmarksGetParametersArena)

                    || typeToConvert == typeof(global::OpenRouter.BenchmarksGetParametersArena?)

                    || typeToConvert == typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1Source)

                    || typeToConvert == typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1Source?)

                    || typeToConvert == typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2Source)

                    || typeToConvert == typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2Source?)

                    || typeToConvert == typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsDiscriminatorSource)

                    || typeToConvert == typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsDiscriminatorSource?)

                    || typeToConvert == typeof(global::OpenRouter.UnifiedBenchmarksMetaSource)

                    || typeToConvert == typeof(global::OpenRouter.UnifiedBenchmarksMetaSource?)

                    || typeToConvert == typeof(global::OpenRouter.UnifiedBenchmarksMetaVersion)

                    || typeToConvert == typeof(global::OpenRouter.UnifiedBenchmarksMetaVersion?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::OpenRouter.BenchmarksGetParametersSource))
                {
                    return new global::OpenRouter.JsonConverters.BenchmarksGetParametersSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.BenchmarksGetParametersSource?))
                {
                    return new global::OpenRouter.JsonConverters.BenchmarksGetParametersSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.BenchmarksGetParametersTaskType))
                {
                    return new global::OpenRouter.JsonConverters.BenchmarksGetParametersTaskTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.BenchmarksGetParametersTaskType?))
                {
                    return new global::OpenRouter.JsonConverters.BenchmarksGetParametersTaskTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.BenchmarksGetParametersArena))
                {
                    return new global::OpenRouter.JsonConverters.BenchmarksGetParametersArenaJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.BenchmarksGetParametersArena?))
                {
                    return new global::OpenRouter.JsonConverters.BenchmarksGetParametersArenaNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1Source))
                {
                    return new global::OpenRouter.JsonConverters.UnifiedBenchmarksResponseDataItemsVariant1SourceJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1Source?))
                {
                    return new global::OpenRouter.JsonConverters.UnifiedBenchmarksResponseDataItemsVariant1SourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2Source))
                {
                    return new global::OpenRouter.JsonConverters.UnifiedBenchmarksResponseDataItemsVariant2SourceJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2Source?))
                {
                    return new global::OpenRouter.JsonConverters.UnifiedBenchmarksResponseDataItemsVariant2SourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsDiscriminatorSource))
                {
                    return new global::OpenRouter.JsonConverters.UnifiedBenchmarksResponseDataItemsDiscriminatorSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsDiscriminatorSource?))
                {
                    return new global::OpenRouter.JsonConverters.UnifiedBenchmarksResponseDataItemsDiscriminatorSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UnifiedBenchmarksMetaSource))
                {
                    return new global::OpenRouter.JsonConverters.UnifiedBenchmarksMetaSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UnifiedBenchmarksMetaSource?))
                {
                    return new global::OpenRouter.JsonConverters.UnifiedBenchmarksMetaSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UnifiedBenchmarksMetaVersion))
                {
                    return new global::OpenRouter.JsonConverters.UnifiedBenchmarksMetaVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.UnifiedBenchmarksMetaVersion?))
                {
                    return new global::OpenRouter.JsonConverters.UnifiedBenchmarksMetaVersionNullableJsonConverter();
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
                    0 => new BenchmarksSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}