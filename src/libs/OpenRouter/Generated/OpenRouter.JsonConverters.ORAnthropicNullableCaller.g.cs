#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class ORAnthropicNullableCallerJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.ORAnthropicNullableCaller>
    {
        /// <inheritdoc />
        public override global::OpenRouter.ORAnthropicNullableCaller Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicNullableCallerDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicNullableCallerDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ORAnthropicNullableCallerDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.ORAnthropicNullableCallerVariant1? codeExecution20250825 = default;
            if (discriminator?.Type == global::OpenRouter.ORAnthropicNullableCallerDiscriminatorType.CodeExecution20250825)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicNullableCallerVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicNullableCallerVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ORAnthropicNullableCallerVariant1)}");
                codeExecution20250825 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ORAnthropicNullableCallerVariant2? codeExecution20260120 = default;
            if (discriminator?.Type == global::OpenRouter.ORAnthropicNullableCallerDiscriminatorType.CodeExecution20260120)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicNullableCallerVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicNullableCallerVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ORAnthropicNullableCallerVariant2)}");
                codeExecution20260120 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ORAnthropicNullableCallerVariant3? direct = default;
            if (discriminator?.Type == global::OpenRouter.ORAnthropicNullableCallerDiscriminatorType.Direct)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicNullableCallerVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicNullableCallerVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ORAnthropicNullableCallerVariant3)}");
                direct = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.ORAnthropicNullableCaller(
                discriminator?.Type,
                codeExecution20250825,

                codeExecution20260120,

                direct
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.ORAnthropicNullableCaller value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCodeExecution20250825)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicNullableCallerVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicNullableCallerVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ORAnthropicNullableCallerVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecution20250825!, typeInfo);
            }
            else if (value.IsCodeExecution20260120)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicNullableCallerVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicNullableCallerVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ORAnthropicNullableCallerVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecution20260120!, typeInfo);
            }
            else if (value.IsDirect)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicNullableCallerVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicNullableCallerVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ORAnthropicNullableCallerVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Direct!, typeInfo);
            }
        }
    }
}