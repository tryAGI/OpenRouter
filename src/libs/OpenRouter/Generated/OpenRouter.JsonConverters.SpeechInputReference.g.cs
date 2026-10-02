#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class SpeechInputReferenceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.SpeechInputReference>
    {
        /// <inheritdoc />
        public override global::OpenRouter.SpeechInputReference Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.SpeechInputReferenceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.SpeechInputReferenceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.SpeechInputReferenceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.SpeechInputReferenceAudio? inputAudio = default;
            if (discriminator?.Type == global::OpenRouter.SpeechInputReferenceDiscriminatorType.InputAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.SpeechInputReferenceAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.SpeechInputReferenceAudio> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.SpeechInputReferenceAudio)}");
                inputAudio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.SpeechInputReferenceText? text = default;
            if (discriminator?.Type == global::OpenRouter.SpeechInputReferenceDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.SpeechInputReferenceText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.SpeechInputReferenceText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.SpeechInputReferenceText)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.SpeechInputReferenceImage? imageUrl = default;
            if (discriminator?.Type == global::OpenRouter.SpeechInputReferenceDiscriminatorType.ImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.SpeechInputReferenceImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.SpeechInputReferenceImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.SpeechInputReferenceImage)}");
                imageUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.SpeechInputReference(
                discriminator?.Type,
                inputAudio,

                text,

                imageUrl
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.SpeechInputReference value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInputAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.SpeechInputReferenceAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.SpeechInputReferenceAudio?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.SpeechInputReferenceAudio).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickInputAudio(), typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.SpeechInputReferenceText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.SpeechInputReferenceText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.SpeechInputReferenceText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickText(), typeInfo);
            }
            else if (value.IsImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.SpeechInputReferenceImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.SpeechInputReferenceImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.SpeechInputReferenceImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickImageUrl(), typeInfo);
            }
        }
    }
}