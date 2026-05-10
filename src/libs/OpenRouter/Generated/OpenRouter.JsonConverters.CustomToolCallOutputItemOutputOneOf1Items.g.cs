#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class CustomToolCallOutputItemOutputOneOf1ItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1Items>
    {
        /// <inheritdoc />
        public override global::OpenRouter.CustomToolCallOutputItemOutputOneOf1Items Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant1? inputFile = default;
            if (discriminator?.Type == global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsDiscriminatorType.InputFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant1)}");
                inputFile = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant2? inputImage = default;
            if (discriminator?.Type == global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsDiscriminatorType.InputImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant2)}");
                inputImage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant3? inputText = default;
            if (discriminator?.Type == global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsDiscriminatorType.InputText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant3)}");
                inputText = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.CustomToolCallOutputItemOutputOneOf1Items(
                discriminator?.Type,
                inputFile,

                inputImage,

                inputText
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.CustomToolCallOutputItemOutputOneOf1Items value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInputFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputFile!, typeInfo);
            }
            else if (value.IsInputImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputImage!, typeInfo);
            }
            else if (value.IsInputText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputText!, typeInfo);
            }
        }
    }
}