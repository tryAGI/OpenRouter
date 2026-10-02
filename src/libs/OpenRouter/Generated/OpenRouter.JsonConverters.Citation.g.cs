#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class CitationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.Citation>
    {
        /// <inheritdoc />
        public override global::OpenRouter.Citation Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.AnthropicCitationCharLocation? charLocation = default;
            if (discriminator?.Type == global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminatorType.CharLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCitationCharLocation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCitationCharLocation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicCitationCharLocation)}");
                charLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnthropicCitationPageLocation? pageLocation = default;
            if (discriminator?.Type == global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminatorType.PageLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCitationPageLocation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCitationPageLocation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicCitationPageLocation)}");
                pageLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnthropicCitationContentBlockLocation? contentBlockLocation = default;
            if (discriminator?.Type == global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminatorType.ContentBlockLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCitationContentBlockLocation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCitationContentBlockLocation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicCitationContentBlockLocation)}");
                contentBlockLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnthropicCitationWebSearchResultLocation? webSearchResultLocation = default;
            if (discriminator?.Type == global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminatorType.WebSearchResultLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCitationWebSearchResultLocation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCitationWebSearchResultLocation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicCitationWebSearchResultLocation)}");
                webSearchResultLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnthropicCitationSearchResultLocation? searchResultLocation = default;
            if (discriminator?.Type == global::OpenRouter.MessagesContentBlockDeltaEventDeltaVariant5CitationDiscriminatorType.SearchResultLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCitationSearchResultLocation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCitationSearchResultLocation> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicCitationSearchResultLocation)}");
                searchResultLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.Citation(
                discriminator?.Type,
                charLocation,

                pageLocation,

                contentBlockLocation,

                webSearchResultLocation,

                searchResultLocation
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.Citation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCharLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCitationCharLocation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCitationCharLocation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicCitationCharLocation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCharLocation(), typeInfo);
            }
            else if (value.IsPageLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCitationPageLocation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCitationPageLocation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicCitationPageLocation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickPageLocation(), typeInfo);
            }
            else if (value.IsContentBlockLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCitationContentBlockLocation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCitationContentBlockLocation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicCitationContentBlockLocation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickContentBlockLocation(), typeInfo);
            }
            else if (value.IsWebSearchResultLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCitationWebSearchResultLocation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCitationWebSearchResultLocation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicCitationWebSearchResultLocation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWebSearchResultLocation(), typeInfo);
            }
            else if (value.IsSearchResultLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCitationSearchResultLocation), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCitationSearchResultLocation?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicCitationSearchResultLocation).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSearchResultLocation(), typeInfo);
            }
        }
    }
}