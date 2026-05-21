#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class AnthropicCodeExecutionContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.AnthropicCodeExecutionContent>
    {
        /// <inheritdoc />
        public override global::OpenRouter.AnthropicCodeExecutionContent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCodeExecutionContentDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCodeExecutionContentDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicCodeExecutionContentDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.AnthropicCodeExecutionContentVariant1? codeExecutionResult = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicCodeExecutionContentDiscriminatorType.CodeExecutionResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCodeExecutionContentVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCodeExecutionContentVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicCodeExecutionContentVariant1)}");
                codeExecutionResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnthropicCodeExecutionContentVariant2? codeExecutionToolResultError = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicCodeExecutionContentDiscriminatorType.CodeExecutionToolResultError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCodeExecutionContentVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCodeExecutionContentVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicCodeExecutionContentVariant2)}");
                codeExecutionToolResultError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnthropicCodeExecutionContentVariant3? encryptedCodeExecutionResult = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicCodeExecutionContentDiscriminatorType.EncryptedCodeExecutionResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCodeExecutionContentVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCodeExecutionContentVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicCodeExecutionContentVariant3)}");
                encryptedCodeExecutionResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.AnthropicCodeExecutionContent(
                discriminator?.Type,
                codeExecutionResult,

                codeExecutionToolResultError,

                encryptedCodeExecutionResult
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.AnthropicCodeExecutionContent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCodeExecutionResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCodeExecutionContentVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCodeExecutionContentVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicCodeExecutionContentVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecutionResult!, typeInfo);
            }
            else if (value.IsCodeExecutionToolResultError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCodeExecutionContentVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCodeExecutionContentVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicCodeExecutionContentVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecutionToolResultError!, typeInfo);
            }
            else if (value.IsEncryptedCodeExecutionResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCodeExecutionContentVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCodeExecutionContentVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicCodeExecutionContentVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EncryptedCodeExecutionResult!, typeInfo);
            }
        }
    }
}