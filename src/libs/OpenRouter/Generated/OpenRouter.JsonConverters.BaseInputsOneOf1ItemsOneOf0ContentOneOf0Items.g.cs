#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items>
    {
        /// <inheritdoc />
        public override global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1? inputAudio = default;
            if (discriminator?.Type == global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsDiscriminatorType.InputAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1)}");
                inputAudio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2? inputFile = default;
            if (discriminator?.Type == global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsDiscriminatorType.InputFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2)}");
                inputFile = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3? inputImage = default;
            if (discriminator?.Type == global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsDiscriminatorType.InputImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3)}");
                inputImage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4? inputText = default;
            if (discriminator?.Type == global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsDiscriminatorType.InputText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4)}");
                inputText = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items(
                discriminator?.Type,
                inputAudio,

                inputFile,

                inputImage,

                inputText
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0Items value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInputAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputAudio!, typeInfo);
            }
            else if (value.IsInputFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputFile!, typeInfo);
            }
            else if (value.IsInputImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputImage!, typeInfo);
            }
            else if (value.IsInputText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0ContentOneOf0ItemsVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputText!, typeInfo);
            }
        }
    }
}