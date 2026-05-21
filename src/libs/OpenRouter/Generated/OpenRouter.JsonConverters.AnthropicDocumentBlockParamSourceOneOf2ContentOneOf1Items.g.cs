#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items>
    {
        /// <inheritdoc />
        public override global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant1? image = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant1)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant2? text = default;
            if (discriminator?.Type == global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant2)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items(
                discriminator?.Type,
                image,

                text
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image!, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
        }
    }
}