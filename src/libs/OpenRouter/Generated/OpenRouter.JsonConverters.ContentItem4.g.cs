#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class ContentItem4JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.ContentItem4>
    {
        /// <inheritdoc />
        public override global::OpenRouter.ContentItem4 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenAIResponseInputMessageItemContentItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenAIResponseInputMessageItemContentItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OpenAIResponseInputMessageItemContentItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.InputText? inputText = default;
            if (discriminator?.Type == global::OpenRouter.OpenAIResponseInputMessageItemContentItemDiscriminatorType.InputText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InputText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InputText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.InputText)}");
                inputText = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.InputImage? inputImage = default;
            if (discriminator?.Type == global::OpenRouter.OpenAIResponseInputMessageItemContentItemDiscriminatorType.InputImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InputImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InputImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.InputImage)}");
                inputImage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.InputFile? inputFile = default;
            if (discriminator?.Type == global::OpenRouter.OpenAIResponseInputMessageItemContentItemDiscriminatorType.InputFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InputFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InputFile> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.InputFile)}");
                inputFile = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.InputAudio? inputAudio = default;
            if (discriminator?.Type == global::OpenRouter.OpenAIResponseInputMessageItemContentItemDiscriminatorType.InputAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InputAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InputAudio> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.InputAudio)}");
                inputAudio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.ContentItem4(
                discriminator?.Type,
                inputText,

                inputImage,

                inputFile,

                inputAudio
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.ContentItem4 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInputText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InputText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InputText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.InputText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickInputText(), typeInfo);
            }
            else if (value.IsInputImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InputImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InputImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.InputImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickInputImage(), typeInfo);
            }
            else if (value.IsInputFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InputFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InputFile?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.InputFile).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickInputFile(), typeInfo);
            }
            else if (value.IsInputAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InputAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InputAudio?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.InputAudio).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickInputAudio(), typeInfo);
            }
        }
    }
}