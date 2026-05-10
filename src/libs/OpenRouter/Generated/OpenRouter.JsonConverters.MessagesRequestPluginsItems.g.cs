#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class MessagesRequestPluginsItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.MessagesRequestPluginsItems>
    {
        /// <inheritdoc />
        public override global::OpenRouter.MessagesRequestPluginsItems Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestPluginsItemsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestPluginsItemsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.MessagesRequestPluginsItemsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.MessagesRequestPluginsItemsVariant1? autoRouter = default;
            if (discriminator?.Id == global::OpenRouter.MessagesRequestPluginsItemsDiscriminatorId.AutoRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestPluginsItemsVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.MessagesRequestPluginsItemsVariant1)}");
                autoRouter = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.MessagesRequestPluginsItemsVariant2? contextCompression = default;
            if (discriminator?.Id == global::OpenRouter.MessagesRequestPluginsItemsDiscriminatorId.ContextCompression)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestPluginsItemsVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.MessagesRequestPluginsItemsVariant2)}");
                contextCompression = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.MessagesRequestPluginsItemsVariant3? fileParser = default;
            if (discriminator?.Id == global::OpenRouter.MessagesRequestPluginsItemsDiscriminatorId.FileParser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestPluginsItemsVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.MessagesRequestPluginsItemsVariant3)}");
                fileParser = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.MessagesRequestPluginsItemsVariant4? moderation = default;
            if (discriminator?.Id == global::OpenRouter.MessagesRequestPluginsItemsDiscriminatorId.Moderation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestPluginsItemsVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.MessagesRequestPluginsItemsVariant4)}");
                moderation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.MessagesRequestPluginsItemsVariant5? paretoRouter = default;
            if (discriminator?.Id == global::OpenRouter.MessagesRequestPluginsItemsDiscriminatorId.ParetoRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestPluginsItemsVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.MessagesRequestPluginsItemsVariant5)}");
                paretoRouter = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.MessagesRequestPluginsItemsVariant6? responseHealing = default;
            if (discriminator?.Id == global::OpenRouter.MessagesRequestPluginsItemsDiscriminatorId.ResponseHealing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestPluginsItemsVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.MessagesRequestPluginsItemsVariant6)}");
                responseHealing = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.MessagesRequestPluginsItemsVariant7? web = default;
            if (discriminator?.Id == global::OpenRouter.MessagesRequestPluginsItemsDiscriminatorId.Web)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestPluginsItemsVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.MessagesRequestPluginsItemsVariant7)}");
                web = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.MessagesRequestPluginsItems(
                discriminator?.Id,
                autoRouter,

                contextCompression,

                fileParser,

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
            global::OpenRouter.MessagesRequestPluginsItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAutoRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestPluginsItemsVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoRouter!, typeInfo);
            }
            else if (value.IsContextCompression)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestPluginsItemsVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContextCompression!, typeInfo);
            }
            else if (value.IsFileParser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestPluginsItemsVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileParser!, typeInfo);
            }
            else if (value.IsModeration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestPluginsItemsVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Moderation!, typeInfo);
            }
            else if (value.IsParetoRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestPluginsItemsVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ParetoRouter!, typeInfo);
            }
            else if (value.IsResponseHealing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestPluginsItemsVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseHealing!, typeInfo);
            }
            else if (value.IsWeb)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestPluginsItemsVariant7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesRequestPluginsItemsVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Web!, typeInfo);
            }
        }
    }
}