#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class AnthropicWebFetchContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.AnthropicWebFetchContent>
    {
        /// <inheritdoc />
        public override global::OpenRouter.AnthropicWebFetchContent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicWebFetchContentDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicWebFetchContentDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicWebFetchContentDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.AnthropicWebFetchContentVariant1? webFetchResult = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicWebFetchContentDiscriminatorType.WebFetchResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicWebFetchContentVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicWebFetchContentVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicWebFetchContentVariant1)}");
                webFetchResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnthropicWebFetchContentVariant2? webFetchToolResultError = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicWebFetchContentDiscriminatorType.WebFetchToolResultError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicWebFetchContentVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicWebFetchContentVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicWebFetchContentVariant2)}");
                webFetchToolResultError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.AnthropicWebFetchContent(
                discriminator?.Type,
                webFetchResult,

                webFetchToolResultError
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.AnthropicWebFetchContent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWebFetchResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicWebFetchContentVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicWebFetchContentVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicWebFetchContentVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebFetchResult!, typeInfo);
            }
            else if (value.IsWebFetchToolResultError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicWebFetchContentVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicWebFetchContentVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicWebFetchContentVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebFetchToolResultError!, typeInfo);
            }
        }
    }
}