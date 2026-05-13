#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class ChatRequestPluginsItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.ChatRequestPluginsItems>
    {
        /// <inheritdoc />
        public override global::OpenRouter.ChatRequestPluginsItems Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatRequestPluginsItemsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatRequestPluginsItemsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ChatRequestPluginsItemsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.ChatRequestPluginsItemsVariant1? autoRouter = default;
            if (discriminator?.Id == global::OpenRouter.ChatRequestPluginsItemsDiscriminatorId.AutoRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatRequestPluginsItemsVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ChatRequestPluginsItemsVariant1)}");
                autoRouter = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ChatRequestPluginsItemsVariant2? contextCompression = default;
            if (discriminator?.Id == global::OpenRouter.ChatRequestPluginsItemsDiscriminatorId.ContextCompression)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatRequestPluginsItemsVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ChatRequestPluginsItemsVariant2)}");
                contextCompression = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ChatRequestPluginsItemsVariant3? fileParser = default;
            if (discriminator?.Id == global::OpenRouter.ChatRequestPluginsItemsDiscriminatorId.FileParser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatRequestPluginsItemsVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ChatRequestPluginsItemsVariant3)}");
                fileParser = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ChatRequestPluginsItemsVariant4? fusion = default;
            if (discriminator?.Id == global::OpenRouter.ChatRequestPluginsItemsDiscriminatorId.Fusion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatRequestPluginsItemsVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ChatRequestPluginsItemsVariant4)}");
                fusion = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ChatRequestPluginsItemsVariant5? moderation = default;
            if (discriminator?.Id == global::OpenRouter.ChatRequestPluginsItemsDiscriminatorId.Moderation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatRequestPluginsItemsVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ChatRequestPluginsItemsVariant5)}");
                moderation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ChatRequestPluginsItemsVariant6? paretoRouter = default;
            if (discriminator?.Id == global::OpenRouter.ChatRequestPluginsItemsDiscriminatorId.ParetoRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatRequestPluginsItemsVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ChatRequestPluginsItemsVariant6)}");
                paretoRouter = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ChatRequestPluginsItemsVariant7? responseHealing = default;
            if (discriminator?.Id == global::OpenRouter.ChatRequestPluginsItemsDiscriminatorId.ResponseHealing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatRequestPluginsItemsVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ChatRequestPluginsItemsVariant7)}");
                responseHealing = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ChatRequestPluginsItemsVariant8? web = default;
            if (discriminator?.Id == global::OpenRouter.ChatRequestPluginsItemsDiscriminatorId.Web)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatRequestPluginsItemsVariant8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ChatRequestPluginsItemsVariant8)}");
                web = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.ChatRequestPluginsItems(
                discriminator?.Id,
                autoRouter,

                contextCompression,

                fileParser,

                fusion,

                moderation,

                paretoRouter,

                responseHealing,

                web
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.ChatRequestPluginsItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAutoRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatRequestPluginsItemsVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatRequestPluginsItemsVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoRouter!, typeInfo);
            }
            else if (value.IsContextCompression)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatRequestPluginsItemsVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatRequestPluginsItemsVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContextCompression!, typeInfo);
            }
            else if (value.IsFileParser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatRequestPluginsItemsVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatRequestPluginsItemsVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileParser!, typeInfo);
            }
            else if (value.IsFusion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatRequestPluginsItemsVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatRequestPluginsItemsVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Fusion!, typeInfo);
            }
            else if (value.IsModeration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatRequestPluginsItemsVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatRequestPluginsItemsVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Moderation!, typeInfo);
            }
            else if (value.IsParetoRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatRequestPluginsItemsVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatRequestPluginsItemsVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ParetoRouter!, typeInfo);
            }
            else if (value.IsResponseHealing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatRequestPluginsItemsVariant7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatRequestPluginsItemsVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseHealing!, typeInfo);
            }
            else if (value.IsWeb)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatRequestPluginsItemsVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatRequestPluginsItemsVariant8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatRequestPluginsItemsVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Web!, typeInfo);
            }
        }
    }
}