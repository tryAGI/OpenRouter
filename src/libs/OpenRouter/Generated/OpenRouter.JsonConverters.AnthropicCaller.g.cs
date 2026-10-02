#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class AnthropicCallerJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.AnthropicCaller>
    {
        /// <inheritdoc />
        public override global::OpenRouter.AnthropicCaller Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCallerDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCallerDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicCallerDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.AnthropicDirectCaller? direct = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicCallerDiscriminatorType.Direct)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicDirectCaller), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicDirectCaller> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicDirectCaller)}");
                direct = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnthropicCodeExecution20250825Caller? codeExecution20250825 = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicCallerDiscriminatorType.CodeExecution20250825)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCodeExecution20250825Caller), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCodeExecution20250825Caller> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicCodeExecution20250825Caller)}");
                codeExecution20250825 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnthropicCodeExecution20260120Caller? codeExecution20260120 = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicCallerDiscriminatorType.CodeExecution20260120)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCodeExecution20260120Caller), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCodeExecution20260120Caller> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicCodeExecution20260120Caller)}");
                codeExecution20260120 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.AnthropicCaller(
                discriminator?.Type,
                direct,

                codeExecution20250825,

                codeExecution20260120
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.AnthropicCaller value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDirect)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicDirectCaller), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicDirectCaller?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicDirectCaller).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDirect(), typeInfo);
            }
            else if (value.IsCodeExecution20250825)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCodeExecution20250825Caller), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCodeExecution20250825Caller?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicCodeExecution20250825Caller).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCodeExecution20250825(), typeInfo);
            }
            else if (value.IsCodeExecution20260120)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCodeExecution20260120Caller), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCodeExecution20260120Caller?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicCodeExecution20260120Caller).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCodeExecution20260120(), typeInfo);
            }
        }
    }
}