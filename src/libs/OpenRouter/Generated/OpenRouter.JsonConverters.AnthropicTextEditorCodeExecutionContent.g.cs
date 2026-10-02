#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class AnthropicTextEditorCodeExecutionContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.AnthropicTextEditorCodeExecutionContent>
    {
        /// <inheritdoc />
        public override global::OpenRouter.AnthropicTextEditorCodeExecutionContent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError? textEditorCodeExecutionToolResultError = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminatorType.TextEditorCodeExecutionToolResultError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError)}");
                textEditorCodeExecutionToolResultError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult? textEditorCodeExecutionViewResult = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminatorType.TextEditorCodeExecutionViewResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult)}");
                textEditorCodeExecutionViewResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult? textEditorCodeExecutionCreateResult = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminatorType.TextEditorCodeExecutionCreateResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult)}");
                textEditorCodeExecutionCreateResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult? textEditorCodeExecutionStrReplaceResult = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminatorType.TextEditorCodeExecutionStrReplaceResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult)}");
                textEditorCodeExecutionStrReplaceResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.AnthropicTextEditorCodeExecutionContent(
                discriminator?.Type,
                textEditorCodeExecutionToolResultError,

                textEditorCodeExecutionViewResult,

                textEditorCodeExecutionCreateResult,

                textEditorCodeExecutionStrReplaceResult
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.AnthropicTextEditorCodeExecutionContent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTextEditorCodeExecutionToolResultError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTextEditorCodeExecutionToolResultError(), typeInfo);
            }
            else if (value.IsTextEditorCodeExecutionViewResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTextEditorCodeExecutionViewResult(), typeInfo);
            }
            else if (value.IsTextEditorCodeExecutionCreateResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTextEditorCodeExecutionCreateResult(), typeInfo);
            }
            else if (value.IsTextEditorCodeExecutionStrReplaceResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTextEditorCodeExecutionStrReplaceResult(), typeInfo);
            }
        }
    }
}