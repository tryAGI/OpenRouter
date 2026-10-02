#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class PluginsItem3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.PluginsItem3>
    {
        /// <inheritdoc />
        public override global::OpenRouter.PluginsItem3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponsesRequestPluginDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponsesRequestPluginDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ResponsesRequestPluginDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.AutoRouterPlugin? autoRouter = default;
            if (discriminator?.Id == global::OpenRouter.ResponsesRequestPluginDiscriminatorId.AutoRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AutoRouterPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AutoRouterPlugin> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AutoRouterPlugin)}");
                autoRouter = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AutoBetaRouterPlugin? autoBetaRouter = default;
            if (discriminator?.Id == global::OpenRouter.ResponsesRequestPluginDiscriminatorId.AutoBetaRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AutoBetaRouterPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AutoBetaRouterPlugin> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AutoBetaRouterPlugin)}");
                autoBetaRouter = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ModerationPlugin? moderation = default;
            if (discriminator?.Id == global::OpenRouter.ResponsesRequestPluginDiscriminatorId.Moderation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModerationPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModerationPlugin> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ModerationPlugin)}");
                moderation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.WebSearchPlugin? web = default;
            if (discriminator?.Id == global::OpenRouter.ResponsesRequestPluginDiscriminatorId.Web)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.WebSearchPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.WebSearchPlugin> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.WebSearchPlugin)}");
                web = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.WebFetchPlugin? webFetch = default;
            if (discriminator?.Id == global::OpenRouter.ResponsesRequestPluginDiscriminatorId.WebFetch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.WebFetchPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.WebFetchPlugin> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.WebFetchPlugin)}");
                webFetch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.FileParserPlugin? fileParser = default;
            if (discriminator?.Id == global::OpenRouter.ResponsesRequestPluginDiscriminatorId.FileParser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FileParserPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FileParserPlugin> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.FileParserPlugin)}");
                fileParser = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ResponseHealingPlugin? responseHealing = default;
            if (discriminator?.Id == global::OpenRouter.ResponsesRequestPluginDiscriminatorId.ResponseHealing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponseHealingPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponseHealingPlugin> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ResponseHealingPlugin)}");
                responseHealing = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ContextCompressionPlugin? contextCompression = default;
            if (discriminator?.Id == global::OpenRouter.ResponsesRequestPluginDiscriminatorId.ContextCompression)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ContextCompressionPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ContextCompressionPlugin> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ContextCompressionPlugin)}");
                contextCompression = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ParetoRouterPlugin? paretoRouter = default;
            if (discriminator?.Id == global::OpenRouter.ResponsesRequestPluginDiscriminatorId.ParetoRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ParetoRouterPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ParetoRouterPlugin> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ParetoRouterPlugin)}");
                paretoRouter = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.FusionPlugin? fusion = default;
            if (discriminator?.Id == global::OpenRouter.ResponsesRequestPluginDiscriminatorId.Fusion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FusionPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FusionPlugin> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.FusionPlugin)}");
                fusion = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.SwitchyardRouterPlugin? switchyardRouter = default;
            if (discriminator?.Id == global::OpenRouter.ResponsesRequestPluginDiscriminatorId.SwitchyardRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.SwitchyardRouterPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.SwitchyardRouterPlugin> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.SwitchyardRouterPlugin)}");
                switchyardRouter = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.JevRouterPlugin? jevRouter = default;
            if (discriminator?.Id == global::OpenRouter.ResponsesRequestPluginDiscriminatorId.JevRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.JevRouterPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.JevRouterPlugin> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.JevRouterPlugin)}");
                jevRouter = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AlignmentPlugin? alignment = default;
            if (discriminator?.Id == global::OpenRouter.ResponsesRequestPluginDiscriminatorId.Alignment)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AlignmentPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AlignmentPlugin> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AlignmentPlugin)}");
                alignment = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.PluginsItem3(
                discriminator?.Id,
                autoRouter,

                autoBetaRouter,

                moderation,

                web,

                webFetch,

                fileParser,

                responseHealing,

                contextCompression,

                paretoRouter,

                fusion,

                switchyardRouter,

                jevRouter,

                alignment
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.PluginsItem3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAutoRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AutoRouterPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AutoRouterPlugin?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AutoRouterPlugin).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAutoRouter(), typeInfo);
            }
            else if (value.IsAutoBetaRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AutoBetaRouterPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AutoBetaRouterPlugin?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AutoBetaRouterPlugin).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAutoBetaRouter(), typeInfo);
            }
            else if (value.IsModeration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModerationPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModerationPlugin?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModerationPlugin).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickModeration(), typeInfo);
            }
            else if (value.IsWeb)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.WebSearchPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.WebSearchPlugin?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.WebSearchPlugin).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWeb(), typeInfo);
            }
            else if (value.IsWebFetch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.WebFetchPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.WebFetchPlugin?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.WebFetchPlugin).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWebFetch(), typeInfo);
            }
            else if (value.IsFileParser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FileParserPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FileParserPlugin?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FileParserPlugin).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFileParser(), typeInfo);
            }
            else if (value.IsResponseHealing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponseHealingPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponseHealingPlugin?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ResponseHealingPlugin).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickResponseHealing(), typeInfo);
            }
            else if (value.IsContextCompression)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ContextCompressionPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ContextCompressionPlugin?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ContextCompressionPlugin).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickContextCompression(), typeInfo);
            }
            else if (value.IsParetoRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ParetoRouterPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ParetoRouterPlugin?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ParetoRouterPlugin).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickParetoRouter(), typeInfo);
            }
            else if (value.IsFusion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FusionPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FusionPlugin?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FusionPlugin).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFusion(), typeInfo);
            }
            else if (value.IsSwitchyardRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.SwitchyardRouterPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.SwitchyardRouterPlugin?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.SwitchyardRouterPlugin).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSwitchyardRouter(), typeInfo);
            }
            else if (value.IsJevRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.JevRouterPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.JevRouterPlugin?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.JevRouterPlugin).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickJevRouter(), typeInfo);
            }
            else if (value.IsAlignment)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AlignmentPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AlignmentPlugin?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AlignmentPlugin).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAlignment(), typeInfo);
            }
        }
    }
}