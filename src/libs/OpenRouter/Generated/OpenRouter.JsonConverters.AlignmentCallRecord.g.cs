#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class AlignmentCallRecordJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.AlignmentCallRecord>
    {
        /// <inheritdoc />
        public override global::OpenRouter.AlignmentCallRecord Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AlignmentCallRecordDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AlignmentCallRecordDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AlignmentCallRecordDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.AlignmentAllowedCallRecord? allowed = default;
            if (discriminator?.Outcome == global::OpenRouter.AlignmentCallRecordDiscriminatorOutcome.Allowed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AlignmentAllowedCallRecord), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AlignmentAllowedCallRecord> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AlignmentAllowedCallRecord)}");
                allowed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AlignmentBlockedCallRecord? blocked = default;
            if (discriminator?.Outcome == global::OpenRouter.AlignmentCallRecordDiscriminatorOutcome.Blocked)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AlignmentBlockedCallRecord), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AlignmentBlockedCallRecord> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AlignmentBlockedCallRecord)}");
                blocked = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.AlignmentUnavailableCallRecord? unavailable = default;
            if (discriminator?.Outcome == global::OpenRouter.AlignmentCallRecordDiscriminatorOutcome.Unavailable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AlignmentUnavailableCallRecord), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AlignmentUnavailableCallRecord> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AlignmentUnavailableCallRecord)}");
                unavailable = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.AlignmentCallRecord(
                discriminator?.Outcome,
                allowed,

                blocked,

                unavailable
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.AlignmentCallRecord value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAllowed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AlignmentAllowedCallRecord), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AlignmentAllowedCallRecord?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AlignmentAllowedCallRecord).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAllowed(), typeInfo);
            }
            else if (value.IsBlocked)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AlignmentBlockedCallRecord), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AlignmentBlockedCallRecord?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AlignmentBlockedCallRecord).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBlocked(), typeInfo);
            }
            else if (value.IsUnavailable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AlignmentUnavailableCallRecord), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AlignmentUnavailableCallRecord?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AlignmentUnavailableCallRecord).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickUnavailable(), typeInfo);
            }
        }
    }
}