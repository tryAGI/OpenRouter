#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class InputReferenceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.InputReference>
    {
        /// <inheritdoc />
        public override global::OpenRouter.InputReference Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InputReferenceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InputReferenceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.InputReferenceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.ContentPartImage? imageUrl = default;
            if (discriminator?.Type == global::OpenRouter.InputReferenceDiscriminatorType.ImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ContentPartImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ContentPartImage> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ContentPartImage)}");
                imageUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ContentPartAudio? audioUrl = default;
            if (discriminator?.Type == global::OpenRouter.InputReferenceDiscriminatorType.AudioUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ContentPartAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ContentPartAudio> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ContentPartAudio)}");
                audioUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ContentPartVideo? videoUrl = default;
            if (discriminator?.Type == global::OpenRouter.InputReferenceDiscriminatorType.VideoUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ContentPartVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ContentPartVideo> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ContentPartVideo)}");
                videoUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.InputReference(
                discriminator?.Type,
                imageUrl,

                audioUrl,

                videoUrl
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.InputReference value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ContentPartImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ContentPartImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ContentPartImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickImageUrl(), typeInfo);
            }
            else if (value.IsAudioUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ContentPartAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ContentPartAudio?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ContentPartAudio).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAudioUrl(), typeInfo);
            }
            else if (value.IsVideoUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ContentPartVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ContentPartVideo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ContentPartVideo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickVideoUrl(), typeInfo);
            }
        }
    }
}