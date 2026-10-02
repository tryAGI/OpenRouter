#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class CitationsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.CitationsItem>
    {
        /// <inheritdoc />
        public override global::OpenRouter.CitationsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextBlockParamCitationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextBlockParamCitationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicTextBlockParamCitationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.AnthropicCitationCharLocationParam? charLocation = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicTextBlockParamCitationDiscriminatorType.CharLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCitationCharLocationParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCitationCharLocationParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicCitationCharLocationParam)}");
                charLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnthropicCitationPageLocationParam? pageLocation = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicTextBlockParamCitationDiscriminatorType.PageLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCitationPageLocationParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCitationPageLocationParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicCitationPageLocationParam)}");
                pageLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnthropicCitationContentBlockLocationParam? contentBlockLocation = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicTextBlockParamCitationDiscriminatorType.ContentBlockLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCitationContentBlockLocationParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCitationContentBlockLocationParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicCitationContentBlockLocationParam)}");
                contentBlockLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnthropicCitationWebSearchResultLocationParam? webSearchResultLocation = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicTextBlockParamCitationDiscriminatorType.WebSearchResultLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCitationWebSearchResultLocationParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCitationWebSearchResultLocationParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicCitationWebSearchResultLocationParam)}");
                webSearchResultLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnthropicCitationSearchResultLocationParam? searchResultLocation = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicTextBlockParamCitationDiscriminatorType.SearchResultLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCitationSearchResultLocationParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCitationSearchResultLocationParam> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicCitationSearchResultLocationParam)}");
                searchResultLocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.CitationsItem(
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
            global::OpenRouter.CitationsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCharLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCitationCharLocationParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCitationCharLocationParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicCitationCharLocationParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCharLocation(), typeInfo);
            }
            else if (value.IsPageLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCitationPageLocationParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCitationPageLocationParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicCitationPageLocationParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickPageLocation(), typeInfo);
            }
            else if (value.IsContentBlockLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCitationContentBlockLocationParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCitationContentBlockLocationParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicCitationContentBlockLocationParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickContentBlockLocation(), typeInfo);
            }
            else if (value.IsWebSearchResultLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCitationWebSearchResultLocationParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCitationWebSearchResultLocationParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicCitationWebSearchResultLocationParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWebSearchResultLocation(), typeInfo);
            }
            else if (value.IsSearchResultLocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCitationSearchResultLocationParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCitationSearchResultLocationParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicCitationSearchResultLocationParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSearchResultLocation(), typeInfo);
            }
        }
    }
}