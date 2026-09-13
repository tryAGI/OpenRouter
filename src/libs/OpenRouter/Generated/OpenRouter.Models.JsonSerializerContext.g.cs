
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningEffort), TypeInfoPropertyName = "ReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BadRequestResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BadRequestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnauthorizedResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UnauthorizedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.NotFoundResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.NotFoundResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InternalServerResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InternalServerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelsGetParametersCategory), TypeInfoPropertyName = "ModelsGetParametersCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelsGetParametersSort), TypeInfoPropertyName = "ModelsGetParametersSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelsGetParametersDistillable), TypeInfoPropertyName = "ModelsGetParametersDistillable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelsGetParametersZdr), TypeInfoPropertyName = "ModelsGetParametersZdr2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelsGetParametersRegion), TypeInfoPropertyName = "ModelsGetParametersRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelsCountResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelsCountResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ReasoningEffort?), TypeInfoPropertyName = "NullableReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InputModality?), TypeInfoPropertyName = "NullableInputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InstructType?), TypeInfoPropertyName = "NullableInstructType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.OutputModality?), TypeInfoPropertyName = "NullableOutputModality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelGroup?), TypeInfoPropertyName = "NullableModelGroup2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Parameter?), TypeInfoPropertyName = "NullableParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelsGetParametersCategory?), TypeInfoPropertyName = "NullableModelsGetParametersCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelsGetParametersSort?), TypeInfoPropertyName = "NullableModelsGetParametersSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelsGetParametersDistillable?), TypeInfoPropertyName = "NullableModelsGetParametersDistillable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelsGetParametersZdr?), TypeInfoPropertyName = "NullableModelsGetParametersZdr2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ModelsGetParametersRegion?), TypeInfoPropertyName = "NullableModelsGetParametersRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.InputModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.OutputModality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.DABenchmarkEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.PricingOverride>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ReasoningEffort>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.Parameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.Model>))]
    internal sealed partial class ModelsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ModelsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ModelsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::OpenRouter.ReasoningEffort)

                    || typeToConvert == typeof(global::OpenRouter.ReasoningEffort?)

                    || typeToConvert == typeof(global::OpenRouter.InputModality)

                    || typeToConvert == typeof(global::OpenRouter.InputModality?)

                    || typeToConvert == typeof(global::OpenRouter.InstructType)

                    || typeToConvert == typeof(global::OpenRouter.InstructType?)

                    || typeToConvert == typeof(global::OpenRouter.OutputModality)

                    || typeToConvert == typeof(global::OpenRouter.OutputModality?)

                    || typeToConvert == typeof(global::OpenRouter.ModelGroup)

                    || typeToConvert == typeof(global::OpenRouter.ModelGroup?)

                    || typeToConvert == typeof(global::OpenRouter.Parameter)

                    || typeToConvert == typeof(global::OpenRouter.Parameter?)

                    || typeToConvert == typeof(global::OpenRouter.ModelsGetParametersCategory)

                    || typeToConvert == typeof(global::OpenRouter.ModelsGetParametersCategory?)

                    || typeToConvert == typeof(global::OpenRouter.ModelsGetParametersSort)

                    || typeToConvert == typeof(global::OpenRouter.ModelsGetParametersSort?)

                    || typeToConvert == typeof(global::OpenRouter.ModelsGetParametersDistillable)

                    || typeToConvert == typeof(global::OpenRouter.ModelsGetParametersDistillable?)

                    || typeToConvert == typeof(global::OpenRouter.ModelsGetParametersZdr)

                    || typeToConvert == typeof(global::OpenRouter.ModelsGetParametersZdr?)

                    || typeToConvert == typeof(global::OpenRouter.ModelsGetParametersRegion)

                    || typeToConvert == typeof(global::OpenRouter.ModelsGetParametersRegion?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::OpenRouter.ReasoningEffort))
                {
                    return new global::OpenRouter.JsonConverters.ReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ReasoningEffort?))
                {
                    return new global::OpenRouter.JsonConverters.ReasoningEffortNullableJsonConverter();
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

                if (typeToConvert == typeof(global::OpenRouter.ModelsGetParametersCategory))
                {
                    return new global::OpenRouter.JsonConverters.ModelsGetParametersCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ModelsGetParametersCategory?))
                {
                    return new global::OpenRouter.JsonConverters.ModelsGetParametersCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ModelsGetParametersSort))
                {
                    return new global::OpenRouter.JsonConverters.ModelsGetParametersSortJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ModelsGetParametersSort?))
                {
                    return new global::OpenRouter.JsonConverters.ModelsGetParametersSortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ModelsGetParametersDistillable))
                {
                    return new global::OpenRouter.JsonConverters.ModelsGetParametersDistillableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ModelsGetParametersDistillable?))
                {
                    return new global::OpenRouter.JsonConverters.ModelsGetParametersDistillableNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ModelsGetParametersZdr))
                {
                    return new global::OpenRouter.JsonConverters.ModelsGetParametersZdrJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ModelsGetParametersZdr?))
                {
                    return new global::OpenRouter.JsonConverters.ModelsGetParametersZdrNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ModelsGetParametersRegion))
                {
                    return new global::OpenRouter.JsonConverters.ModelsGetParametersRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ModelsGetParametersRegion?))
                {
                    return new global::OpenRouter.JsonConverters.ModelsGetParametersRegionNullableJsonConverter();
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
                    0 => new ModelsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}