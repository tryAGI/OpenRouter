#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class ShellServerToolEnvironmentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.ShellServerToolEnvironment>
    {
        /// <inheritdoc />
        public override global::OpenRouter.ShellServerToolEnvironment Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ShellServerToolEnvironmentDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ShellServerToolEnvironmentDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ShellServerToolEnvironmentDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.ContainerAutoEnvironment? containerAuto = default;
            if (discriminator?.Type == global::OpenRouter.ShellServerToolEnvironmentDiscriminatorType.ContainerAuto)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ContainerAutoEnvironment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ContainerAutoEnvironment> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ContainerAutoEnvironment)}");
                containerAuto = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ContainerReferenceEnvironment? containerReference = default;
            if (discriminator?.Type == global::OpenRouter.ShellServerToolEnvironmentDiscriminatorType.ContainerReference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ContainerReferenceEnvironment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ContainerReferenceEnvironment> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ContainerReferenceEnvironment)}");
                containerReference = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.ShellServerToolEnvironment(
                discriminator?.Type,
                containerAuto,

                containerReference
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.ShellServerToolEnvironment value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsContainerAuto)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ContainerAutoEnvironment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ContainerAutoEnvironment?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ContainerAutoEnvironment).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickContainerAuto(), typeInfo);
            }
            else if (value.IsContainerReference)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ContainerReferenceEnvironment), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ContainerReferenceEnvironment?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ContainerReferenceEnvironment).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickContainerReference(), typeInfo);
            }
        }
    }
}