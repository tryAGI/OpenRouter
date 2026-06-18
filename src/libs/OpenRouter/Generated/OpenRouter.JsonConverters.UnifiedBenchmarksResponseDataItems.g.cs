#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class UnifiedBenchmarksResponseDataItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.UnifiedBenchmarksResponseDataItems>
    {
        /// <inheritdoc />
        public override global::OpenRouter.UnifiedBenchmarksResponseDataItems Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UnifiedBenchmarksResponseDataItemsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1? artificialAnalysis = default;
            if (discriminator?.Source == global::OpenRouter.UnifiedBenchmarksResponseDataItemsDiscriminatorSource.ArtificialAnalysis)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1)}");
                artificialAnalysis = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2? designArena = default;
            if (discriminator?.Source == global::OpenRouter.UnifiedBenchmarksResponseDataItemsDiscriminatorSource.DesignArena)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2)}");
                designArena = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.UnifiedBenchmarksResponseDataItems(
                discriminator?.Source,
                artificialAnalysis,

                designArena
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.UnifiedBenchmarksResponseDataItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsArtificialAnalysis)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ArtificialAnalysis!, typeInfo);
            }
            else if (value.IsDesignArena)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DesignArena!, typeInfo);
            }
        }
    }
}