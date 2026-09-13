
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.NotFoundResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.NotFoundResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InternalServerResponseErrorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.InternalServerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ContentFilterBuiltinAction), TypeInfoPropertyName = "ContentFilterBuiltinAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PromptInjectionScanScope), TypeInfoPropertyName = "PromptInjectionScanScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ContentFilterBuiltinSlug), TypeInfoPropertyName = "ContentFilterBuiltinSlug2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ContentFilterBuiltinEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ContentFilterAction), TypeInfoPropertyName = "ContentFilterAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ContentFilterEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GuardrailInterval), TypeInfoPropertyName = "GuardrailInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.Guardrail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterBuiltinEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ListGuardrailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.Guardrail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ContentFilterBuiltinEntryInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateGuardrailRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.ContentFilterBuiltinEntryInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateGuardrailResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.CreateGuardrailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetGuardrailResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GetGuardrailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.DeleteGuardrailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateGuardrailRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateGuardrailResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.UpdateGuardrailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.KeyAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ListKeyAssignmentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.KeyAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BulkAssignKeysRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BulkAssignKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BulkUnassignKeysRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BulkUnassignKeysResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.MemberAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ListMemberAssignmentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::OpenRouter.MemberAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BulkAssignMembersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BulkAssignMembersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BulkUnassignMembersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.BulkUnassignMembersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ContentFilterBuiltinAction?), TypeInfoPropertyName = "NullableContentFilterBuiltinAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.PromptInjectionScanScope?), TypeInfoPropertyName = "NullablePromptInjectionScanScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ContentFilterBuiltinSlug?), TypeInfoPropertyName = "NullableContentFilterBuiltinSlug2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.ContentFilterAction?), TypeInfoPropertyName = "NullableContentFilterAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::OpenRouter.GuardrailInterval?), TypeInfoPropertyName = "NullableGuardrailInterval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ContentFilterBuiltinEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ContentFilterEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.Guardrail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.ContentFilterBuiltinEntryInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.KeyAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::OpenRouter.MemberAssignment>))]
    internal sealed partial class GuardrailsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GuardrailsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GuardrailsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GuardrailsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::OpenRouter.ContentFilterBuiltinAction)

                    || typeToConvert == typeof(global::OpenRouter.ContentFilterBuiltinAction?)

                    || typeToConvert == typeof(global::OpenRouter.PromptInjectionScanScope)

                    || typeToConvert == typeof(global::OpenRouter.PromptInjectionScanScope?)

                    || typeToConvert == typeof(global::OpenRouter.ContentFilterBuiltinSlug)

                    || typeToConvert == typeof(global::OpenRouter.ContentFilterBuiltinSlug?)

                    || typeToConvert == typeof(global::OpenRouter.ContentFilterAction)

                    || typeToConvert == typeof(global::OpenRouter.ContentFilterAction?)

                    || typeToConvert == typeof(global::OpenRouter.GuardrailInterval)

                    || typeToConvert == typeof(global::OpenRouter.GuardrailInterval?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::OpenRouter.ContentFilterBuiltinAction))
                {
                    return new global::OpenRouter.JsonConverters.ContentFilterBuiltinActionJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ContentFilterBuiltinAction?))
                {
                    return new global::OpenRouter.JsonConverters.ContentFilterBuiltinActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.PromptInjectionScanScope))
                {
                    return new global::OpenRouter.JsonConverters.PromptInjectionScanScopeJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.PromptInjectionScanScope?))
                {
                    return new global::OpenRouter.JsonConverters.PromptInjectionScanScopeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ContentFilterBuiltinSlug))
                {
                    return new global::OpenRouter.JsonConverters.ContentFilterBuiltinSlugJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ContentFilterBuiltinSlug?))
                {
                    return new global::OpenRouter.JsonConverters.ContentFilterBuiltinSlugNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ContentFilterAction))
                {
                    return new global::OpenRouter.JsonConverters.ContentFilterActionJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.ContentFilterAction?))
                {
                    return new global::OpenRouter.JsonConverters.ContentFilterActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GuardrailInterval))
                {
                    return new global::OpenRouter.JsonConverters.GuardrailIntervalJsonConverter();
                }

                if (typeToConvert == typeof(global::OpenRouter.GuardrailInterval?))
                {
                    return new global::OpenRouter.JsonConverters.GuardrailIntervalNullableJsonConverter();
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
                    0 => new GuardrailsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}