#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class ResponsesRequestPluginsItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.ResponsesRequestPluginsItems>
    {
        /// <inheritdoc />
        public override global::OpenRouter.ResponsesRequestPluginsItems Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.ResponsesRequestPluginsItemsVariant1? autoBetaRouter = default;
            if (discriminator?.Id == global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorId.AutoBetaRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponsesRequestPluginsItemsVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ResponsesRequestPluginsItemsVariant1)}");
                autoBetaRouter = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ResponsesRequestPluginsItemsVariant2? autoRouter = default;
            if (discriminator?.Id == global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorId.AutoRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponsesRequestPluginsItemsVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ResponsesRequestPluginsItemsVariant2)}");
                autoRouter = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ResponsesRequestPluginsItemsVariant3? contextCompression = default;
            if (discriminator?.Id == global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorId.ContextCompression)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponsesRequestPluginsItemsVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ResponsesRequestPluginsItemsVariant3)}");
                contextCompression = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ResponsesRequestPluginsItemsVariant4? fileParser = default;
            if (discriminator?.Id == global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorId.FileParser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponsesRequestPluginsItemsVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ResponsesRequestPluginsItemsVariant4)}");
                fileParser = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ResponsesRequestPluginsItemsVariant5? fusion = default;
            if (discriminator?.Id == global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorId.Fusion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponsesRequestPluginsItemsVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ResponsesRequestPluginsItemsVariant5)}");
                fusion = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ResponsesRequestPluginsItemsVariant6? moderation = default;
            if (discriminator?.Id == global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorId.Moderation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponsesRequestPluginsItemsVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ResponsesRequestPluginsItemsVariant6)}");
                moderation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ResponsesRequestPluginsItemsVariant7? paretoRouter = default;
            if (discriminator?.Id == global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorId.ParetoRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponsesRequestPluginsItemsVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ResponsesRequestPluginsItemsVariant7)}");
                paretoRouter = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ResponsesRequestPluginsItemsVariant8? responseHealing = default;
            if (discriminator?.Id == global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorId.ResponseHealing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponsesRequestPluginsItemsVariant8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ResponsesRequestPluginsItemsVariant8)}");
                responseHealing = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ResponsesRequestPluginsItemsVariant9? web = default;
            if (discriminator?.Id == global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorId.Web)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponsesRequestPluginsItemsVariant9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ResponsesRequestPluginsItemsVariant9)}");
                web = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ResponsesRequestPluginsItemsVariant10? webFetch = default;
            if (discriminator?.Id == global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorId.WebFetch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponsesRequestPluginsItemsVariant10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ResponsesRequestPluginsItemsVariant10)}");
                webFetch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.ResponsesRequestPluginsItems(
                discriminator?.Id,
                autoBetaRouter,

                autoRouter,

                contextCompression,

                fileParser,

                fusion,

                moderation,

                paretoRouter,

                responseHealing,

                web,

                webFetch
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.ResponsesRequestPluginsItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAutoBetaRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponsesRequestPluginsItemsVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoBetaRouter!, typeInfo);
            }
            else if (value.IsAutoRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponsesRequestPluginsItemsVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoRouter!, typeInfo);
            }
            else if (value.IsContextCompression)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponsesRequestPluginsItemsVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContextCompression!, typeInfo);
            }
            else if (value.IsFileParser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponsesRequestPluginsItemsVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileParser!, typeInfo);
            }
            else if (value.IsFusion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponsesRequestPluginsItemsVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Fusion!, typeInfo);
            }
            else if (value.IsModeration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponsesRequestPluginsItemsVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Moderation!, typeInfo);
            }
            else if (value.IsParetoRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponsesRequestPluginsItemsVariant7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ParetoRouter!, typeInfo);
            }
            else if (value.IsResponseHealing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponsesRequestPluginsItemsVariant8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseHealing!, typeInfo);
            }
            else if (value.IsWeb)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponsesRequestPluginsItemsVariant9?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Web!, typeInfo);
            }
            else if (value.IsWebFetch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponsesRequestPluginsItemsVariant10?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ResponsesRequestPluginsItemsVariant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebFetch!, typeInfo);
            }
        }
    }
}