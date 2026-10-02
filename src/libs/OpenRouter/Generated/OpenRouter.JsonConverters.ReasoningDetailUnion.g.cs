#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class ReasoningDetailUnionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.ReasoningDetailUnion>
    {
        /// <inheritdoc />
        public override global::OpenRouter.ReasoningDetailUnion Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningDetailUnionDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningDetailUnionDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ReasoningDetailUnionDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.ReasoningDetailSummary? reasoningSummary = default;
            if (discriminator?.Type == global::OpenRouter.ReasoningDetailUnionDiscriminatorType.ReasoningSummary)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningDetailSummary), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningDetailSummary> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ReasoningDetailSummary)}");
                reasoningSummary = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ReasoningDetailEncrypted? reasoningEncrypted = default;
            if (discriminator?.Type == global::OpenRouter.ReasoningDetailUnionDiscriminatorType.ReasoningEncrypted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningDetailEncrypted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningDetailEncrypted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ReasoningDetailEncrypted)}");
                reasoningEncrypted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ReasoningDetailText? reasoningText = default;
            if (discriminator?.Type == global::OpenRouter.ReasoningDetailUnionDiscriminatorType.ReasoningText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningDetailText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningDetailText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ReasoningDetailText)}");
                reasoningText = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ReasoningDetailServerToolCall? reasoningServerToolCall = default;
            if (discriminator?.Type == global::OpenRouter.ReasoningDetailUnionDiscriminatorType.ReasoningServerToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningDetailServerToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningDetailServerToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ReasoningDetailServerToolCall)}");
                reasoningServerToolCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.ReasoningDetailUnion(
                discriminator?.Type,
                reasoningSummary,

                reasoningEncrypted,

                reasoningText,

                reasoningServerToolCall
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.ReasoningDetailUnion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsReasoningSummary)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningDetailSummary), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningDetailSummary?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ReasoningDetailSummary).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickReasoningSummary(), typeInfo);
            }
            else if (value.IsReasoningEncrypted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningDetailEncrypted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningDetailEncrypted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ReasoningDetailEncrypted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickReasoningEncrypted(), typeInfo);
            }
            else if (value.IsReasoningText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningDetailText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningDetailText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ReasoningDetailText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickReasoningText(), typeInfo);
            }
            else if (value.IsReasoningServerToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningDetailServerToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningDetailServerToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ReasoningDetailServerToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickReasoningServerToolCall(), typeInfo);
            }
        }
    }
}