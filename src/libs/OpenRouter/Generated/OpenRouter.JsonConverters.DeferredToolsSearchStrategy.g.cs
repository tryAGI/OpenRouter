#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class DeferredToolsSearchStrategyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.DeferredToolsSearchStrategy>
    {
        /// <inheritdoc />
        public override global::OpenRouter.DeferredToolsSearchStrategy Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DeferredToolsSearchStrategyDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DeferredToolsSearchStrategyDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.DeferredToolsSearchStrategyDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.DeferredRegexSearch? regex = default;
            if (discriminator?.Type == global::OpenRouter.DeferredToolsSearchStrategyDiscriminatorType.Regex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DeferredRegexSearch), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DeferredRegexSearch> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.DeferredRegexSearch)}");
                regex = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.DeferredBm25Search? bm25 = default;
            if (discriminator?.Type == global::OpenRouter.DeferredToolsSearchStrategyDiscriminatorType.Bm25)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DeferredBm25Search), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DeferredBm25Search> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.DeferredBm25Search)}");
                bm25 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.DeferredCustomSearch? custom = default;
            if (discriminator?.Type == global::OpenRouter.DeferredToolsSearchStrategyDiscriminatorType.Custom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DeferredCustomSearch), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DeferredCustomSearch> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.DeferredCustomSearch)}");
                custom = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.DeferredToolsSearchStrategy(
                discriminator?.Type,
                regex,

                bm25,

                custom
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.DeferredToolsSearchStrategy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRegex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DeferredRegexSearch), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DeferredRegexSearch?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.DeferredRegexSearch).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRegex(), typeInfo);
            }
            else if (value.IsBm25)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DeferredBm25Search), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DeferredBm25Search?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.DeferredBm25Search).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBm25(), typeInfo);
            }
            else if (value.IsCustom)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DeferredCustomSearch), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DeferredCustomSearch?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.DeferredCustomSearch).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCustom(), typeInfo);
            }
        }
    }
}