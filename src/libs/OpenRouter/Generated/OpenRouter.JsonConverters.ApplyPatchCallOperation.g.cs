#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class ApplyPatchCallOperationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.ApplyPatchCallOperation>
    {
        /// <inheritdoc />
        public override global::OpenRouter.ApplyPatchCallOperation Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ApplyPatchCallOperationDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ApplyPatchCallOperationDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ApplyPatchCallOperationDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.ApplyPatchCallOperationVariant1? createFile = default;
            if (discriminator?.Type == global::OpenRouter.ApplyPatchCallOperationDiscriminatorType.CreateFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ApplyPatchCallOperationVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ApplyPatchCallOperationVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ApplyPatchCallOperationVariant1)}");
                createFile = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ApplyPatchCallOperationVariant2? deleteFile = default;
            if (discriminator?.Type == global::OpenRouter.ApplyPatchCallOperationDiscriminatorType.DeleteFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ApplyPatchCallOperationVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ApplyPatchCallOperationVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ApplyPatchCallOperationVariant2)}");
                deleteFile = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ApplyPatchCallOperationVariant3? updateFile = default;
            if (discriminator?.Type == global::OpenRouter.ApplyPatchCallOperationDiscriminatorType.UpdateFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ApplyPatchCallOperationVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ApplyPatchCallOperationVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ApplyPatchCallOperationVariant3)}");
                updateFile = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.ApplyPatchCallOperation(
                discriminator?.Type,
                createFile,

                deleteFile,

                updateFile
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.ApplyPatchCallOperation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCreateFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ApplyPatchCallOperationVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ApplyPatchCallOperationVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ApplyPatchCallOperationVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateFile!, typeInfo);
            }
            else if (value.IsDeleteFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ApplyPatchCallOperationVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ApplyPatchCallOperationVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ApplyPatchCallOperationVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeleteFile!, typeInfo);
            }
            else if (value.IsUpdateFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ApplyPatchCallOperationVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ApplyPatchCallOperationVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ApplyPatchCallOperationVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UpdateFile!, typeInfo);
            }
        }
    }
}