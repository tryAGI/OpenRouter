#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class InternChatMessageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.InternChatMessage>
    {
        /// <inheritdoc />
        public override global::OpenRouter.InternChatMessage Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InternChatMessageDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InternChatMessageDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.InternChatMessageDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.InternChatSystemMessage? system = default;
            if (discriminator?.Role == global::OpenRouter.InternChatMessageDiscriminatorRole.System)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InternChatSystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InternChatSystemMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.InternChatSystemMessage)}");
                system = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.InternChatDeveloperMessage? developer = default;
            if (discriminator?.Role == global::OpenRouter.InternChatMessageDiscriminatorRole.Developer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InternChatDeveloperMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InternChatDeveloperMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.InternChatDeveloperMessage)}");
                developer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.InternChatUserMessage? user = default;
            if (discriminator?.Role == global::OpenRouter.InternChatMessageDiscriminatorRole.User)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InternChatUserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InternChatUserMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.InternChatUserMessage)}");
                user = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.InternChatAssistantMessage? assistant = default;
            if (discriminator?.Role == global::OpenRouter.InternChatMessageDiscriminatorRole.Assistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InternChatAssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InternChatAssistantMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.InternChatAssistantMessage)}");
                assistant = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.InternChatToolMessage? tool = default;
            if (discriminator?.Role == global::OpenRouter.InternChatMessageDiscriminatorRole.Tool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InternChatToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InternChatToolMessage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.InternChatToolMessage)}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.InternChatMessage(
                discriminator?.Role,
                system,

                developer,

                user,

                assistant,

                tool
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.InternChatMessage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSystem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InternChatSystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InternChatSystemMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.InternChatSystemMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSystem(), typeInfo);
            }
            else if (value.IsDeveloper)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InternChatDeveloperMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InternChatDeveloperMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.InternChatDeveloperMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDeveloper(), typeInfo);
            }
            else if (value.IsUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InternChatUserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InternChatUserMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.InternChatUserMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickUser(), typeInfo);
            }
            else if (value.IsAssistant)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InternChatAssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InternChatAssistantMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.InternChatAssistantMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAssistant(), typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InternChatToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InternChatToolMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.InternChatToolMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTool(), typeInfo);
            }
        }
    }
}