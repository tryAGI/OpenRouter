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

            global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant1? textEditorCodeExecutionCreateResult = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminatorType.TextEditorCodeExecutionCreateResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant1)}");
                textEditorCodeExecutionCreateResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant2? textEditorCodeExecutionStrReplaceResult = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminatorType.TextEditorCodeExecutionStrReplaceResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant2)}");
                textEditorCodeExecutionStrReplaceResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant3? textEditorCodeExecutionToolResultError = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminatorType.TextEditorCodeExecutionToolResultError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant3)}");
                textEditorCodeExecutionToolResultError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant4? textEditorCodeExecutionViewResult = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminatorType.TextEditorCodeExecutionViewResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant4)}");
                textEditorCodeExecutionViewResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.AnthropicTextEditorCodeExecutionContent(
                discriminator?.Type,
                textEditorCodeExecutionCreateResult,

                textEditorCodeExecutionStrReplaceResult,

                textEditorCodeExecutionToolResultError,

                textEditorCodeExecutionViewResult
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

            if (value.IsTextEditorCodeExecutionCreateResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditorCodeExecutionCreateResult!, typeInfo);
            }
            else if (value.IsTextEditorCodeExecutionStrReplaceResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditorCodeExecutionStrReplaceResult!, typeInfo);
            }
            else if (value.IsTextEditorCodeExecutionToolResultError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditorCodeExecutionToolResultError!, typeInfo);
            }
            else if (value.IsTextEditorCodeExecutionViewResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditorCodeExecutionViewResult!, typeInfo);
            }
        }
    }
}