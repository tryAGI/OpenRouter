#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class FileDeleteResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.FileDeleteResponse>
    {
        /// <inheritdoc />
        public override global::OpenRouter.FileDeleteResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FileDeleteResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FileDeleteResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.FileDeleteResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.OpenRouterFileDeleted? openrouter = default;
            if (discriminator?.Shape == global::OpenRouter.FileDeleteResponseDiscriminatorShape.Openrouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenRouterFileDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenRouterFileDeleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OpenRouterFileDeleted)}");
                openrouter = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OpenAIFileDeleted? openai = default;
            if (discriminator?.Shape == global::OpenRouter.FileDeleteResponseDiscriminatorShape.Openai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenAIFileDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenAIFileDeleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OpenAIFileDeleted)}");
                openai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnthropicFileDeleted? anthropic = default;
            if (discriminator?.Shape == global::OpenRouter.FileDeleteResponseDiscriminatorShape.Anthropic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicFileDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicFileDeleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicFileDeleted)}");
                anthropic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.FileDeleteResponse(
                discriminator?.Shape,
                openrouter,

                openai,

                anthropic
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.FileDeleteResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOpenrouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenRouterFileDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenRouterFileDeleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenRouterFileDeleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenrouter(), typeInfo);
            }
            else if (value.IsOpenai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenAIFileDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenAIFileDeleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenAIFileDeleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenai(), typeInfo);
            }
            else if (value.IsAnthropic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicFileDeleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicFileDeleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicFileDeleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAnthropic(), typeInfo);
            }
        }
    }
}