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

            global::OpenRouter.AnthropicCodeExecutionToolResultError? codeExecutionToolResultError = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicCodeExecutionContentDiscriminatorType.CodeExecutionToolResultError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCodeExecutionToolResultError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCodeExecutionToolResultError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicCodeExecutionToolResultError)}");
                codeExecutionToolResultError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnthropicCodeExecutionResult? codeExecutionResult = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicCodeExecutionContentDiscriminatorType.CodeExecutionResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCodeExecutionResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCodeExecutionResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicCodeExecutionResult)}");
                codeExecutionResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnthropicEncryptedCodeExecutionResult? encryptedCodeExecutionResult = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicCodeExecutionContentDiscriminatorType.EncryptedCodeExecutionResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicEncryptedCodeExecutionResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicEncryptedCodeExecutionResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicEncryptedCodeExecutionResult)}");
                encryptedCodeExecutionResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.AnthropicCodeExecutionContent(
                discriminator?.Type,
                codeExecutionToolResultError,

                codeExecutionResult,

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

            if (value.IsCodeExecutionToolResultError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCodeExecutionToolResultError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCodeExecutionToolResultError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicCodeExecutionToolResultError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCodeExecutionToolResultError(), typeInfo);
            }
            else if (value.IsCodeExecutionResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCodeExecutionResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCodeExecutionResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicCodeExecutionResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCodeExecutionResult(), typeInfo);
            }
            else if (value.IsEncryptedCodeExecutionResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicEncryptedCodeExecutionResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicEncryptedCodeExecutionResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicEncryptedCodeExecutionResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickEncryptedCodeExecutionResult(), typeInfo);
            }
        }
    }
}