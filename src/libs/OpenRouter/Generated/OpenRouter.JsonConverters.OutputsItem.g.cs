#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class OutputsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.OutputsItem>
    {
        /// <inheritdoc />
        public override global::OpenRouter.OutputsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemCodeInterpreterCallOutputDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemCodeInterpreterCallOutputDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputItemCodeInterpreterCallOutputDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.CodeInterpreterLogsOutput? logs = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemCodeInterpreterCallOutputDiscriminatorType.Logs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CodeInterpreterLogsOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CodeInterpreterLogsOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CodeInterpreterLogsOutput)}");
                logs = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.CodeInterpreterImageOutput? image = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemCodeInterpreterCallOutputDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CodeInterpreterImageOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CodeInterpreterImageOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CodeInterpreterImageOutput)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.CodeInterpreterFileOutput? file = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemCodeInterpreterCallOutputDiscriminatorType.File)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CodeInterpreterFileOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CodeInterpreterFileOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CodeInterpreterFileOutput)}");
                file = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.OutputsItem(
                discriminator?.Type,
                logs,

                image,

                file
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.OutputsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLogs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CodeInterpreterLogsOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CodeInterpreterLogsOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CodeInterpreterLogsOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLogs(), typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CodeInterpreterImageOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CodeInterpreterImageOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CodeInterpreterImageOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickImage(), typeInfo);
            }
            else if (value.IsFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CodeInterpreterFileOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CodeInterpreterFileOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CodeInterpreterFileOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFile(), typeInfo);
            }
        }
    }
}