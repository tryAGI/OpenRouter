#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class MessagesToolSearchToolResultContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.MessagesToolSearchToolResultContent>
    {
        /// <inheritdoc />
        public override global::OpenRouter.MessagesToolSearchToolResultContent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesToolSearchToolResultContentDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesToolSearchToolResultContentDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.MessagesToolSearchToolResultContentDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.MessagesToolSearchToolResultError? toolSearchToolResultError = default;
            if (discriminator?.Type == global::OpenRouter.MessagesToolSearchToolResultContentDiscriminatorType.ToolSearchToolResultError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesToolSearchToolResultError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesToolSearchToolResultError> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.MessagesToolSearchToolResultError)}");
                toolSearchToolResultError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.MessagesToolSearchToolSearchResult? toolSearchToolSearchResult = default;
            if (discriminator?.Type == global::OpenRouter.MessagesToolSearchToolResultContentDiscriminatorType.ToolSearchToolSearchResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesToolSearchToolSearchResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesToolSearchToolSearchResult> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.MessagesToolSearchToolSearchResult)}");
                toolSearchToolSearchResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.MessagesToolSearchToolResultContent(
                discriminator?.Type,
                toolSearchToolResultError,

                toolSearchToolSearchResult
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.MessagesToolSearchToolResultContent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsToolSearchToolResultError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesToolSearchToolResultError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesToolSearchToolResultError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesToolSearchToolResultError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickToolSearchToolResultError(), typeInfo);
            }
            else if (value.IsToolSearchToolSearchResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesToolSearchToolSearchResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesToolSearchToolSearchResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesToolSearchToolSearchResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickToolSearchToolSearchResult(), typeInfo);
            }
        }
    }
}