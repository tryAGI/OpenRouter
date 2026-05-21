#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class AnthropicTextBlockParamCitationsItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.AnthropicTextBlockParamCitationsItems>
    {
        /// <inheritdoc />
        public override global::OpenRouter.AnthropicTextBlockParamCitationsItems Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextBlockParamCitationsItemsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1? charLocation = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicTextBlockParamCitationsItemsDiscriminatorType.CharLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1)}");
                charLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2? contentBlockLocation = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicTextBlockParamCitationsItemsDiscriminatorType.ContentBlockLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2)}");
                contentBlockLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3? pageLocation = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicTextBlockParamCitationsItemsDiscriminatorType.PageLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3)}");
                pageLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4? searchResultLocation = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicTextBlockParamCitationsItemsDiscriminatorType.SearchResultLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4)}");
                searchResultLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5? webSearchResultLocation = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicTextBlockParamCitationsItemsDiscriminatorType.WebSearchResultLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5)}");
                webSearchResultLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.AnthropicTextBlockParamCitationsItems(
                discriminator?.Type,
                charLocation,

                contentBlockLocation,

                pageLocation,

                searchResultLocation,

                webSearchResultLocation
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.AnthropicTextBlockParamCitationsItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCharLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CharLocation!, typeInfo);
            }
            else if (value.IsContentBlockLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentBlockLocation!, typeInfo);
            }
            else if (value.IsPageLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PageLocation!, typeInfo);
            }
            else if (value.IsSearchResultLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SearchResultLocation!, typeInfo);
            }
            else if (value.IsWebSearchResultLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicTextBlockParamCitationsItemsVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchResultLocation!, typeInfo);
            }
        }
    }
}