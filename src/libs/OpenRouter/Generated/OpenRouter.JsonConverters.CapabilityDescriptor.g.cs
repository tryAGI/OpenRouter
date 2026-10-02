#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class CapabilityDescriptorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.CapabilityDescriptor>
    {
        /// <inheritdoc />
        public override global::OpenRouter.CapabilityDescriptor Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CapabilityDescriptorDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CapabilityDescriptorDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.CapabilityDescriptorDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.EnumCapability? @enum = default;
            if (discriminator?.Type == global::OpenRouter.CapabilityDescriptorDiscriminatorType.Enum)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.EnumCapability), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.EnumCapability> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.EnumCapability)}");
                @enum = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.RangeCapability? range = default;
            if (discriminator?.Type == global::OpenRouter.CapabilityDescriptorDiscriminatorType.Range)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.RangeCapability), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.RangeCapability> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.RangeCapability)}");
                range = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.BooleanCapability? boolean = default;
            if (discriminator?.Type == global::OpenRouter.CapabilityDescriptorDiscriminatorType.Boolean)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.BooleanCapability), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.BooleanCapability> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.BooleanCapability)}");
                boolean = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.CapabilityDescriptor(
                discriminator?.Type,
                @enum,

                range,

                boolean
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.CapabilityDescriptor value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEnum)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.EnumCapability), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.EnumCapability?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.EnumCapability).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickEnum(), typeInfo);
            }
            else if (value.IsRange)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.RangeCapability), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.RangeCapability?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.RangeCapability).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRange(), typeInfo);
            }
            else if (value.IsBoolean)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.BooleanCapability), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.BooleanCapability?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.BooleanCapability).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBoolean(), typeInfo);
            }
        }
    }
}