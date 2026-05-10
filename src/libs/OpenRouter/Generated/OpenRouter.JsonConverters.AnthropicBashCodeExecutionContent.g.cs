#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class AnthropicBashCodeExecutionContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.AnthropicBashCodeExecutionContent>
    {
        /// <inheritdoc />
        public override global::OpenRouter.AnthropicBashCodeExecutionContent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicBashCodeExecutionContentDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicBashCodeExecutionContentDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicBashCodeExecutionContentDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.AnthropicBashCodeExecutionContentVariant1? bashCodeExecutionResult = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicBashCodeExecutionContentDiscriminatorType.BashCodeExecutionResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicBashCodeExecutionContentVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicBashCodeExecutionContentVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicBashCodeExecutionContentVariant1)}");
                bashCodeExecutionResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnthropicBashCodeExecutionContentVariant2? bashCodeExecutionToolResultError = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicBashCodeExecutionContentDiscriminatorType.BashCodeExecutionToolResultError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicBashCodeExecutionContentVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicBashCodeExecutionContentVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicBashCodeExecutionContentVariant2)}");
                bashCodeExecutionToolResultError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.AnthropicBashCodeExecutionContent(
                discriminator?.Type,
                bashCodeExecutionResult,

                bashCodeExecutionToolResultError
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.AnthropicBashCodeExecutionContent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBashCodeExecutionResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicBashCodeExecutionContentVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicBashCodeExecutionContentVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicBashCodeExecutionContentVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BashCodeExecutionResult!, typeInfo);
            }
            else if (value.IsBashCodeExecutionToolResultError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicBashCodeExecutionContentVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicBashCodeExecutionContentVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicBashCodeExecutionContentVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BashCodeExecutionToolResultError!, typeInfo);
            }
        }
    }
}