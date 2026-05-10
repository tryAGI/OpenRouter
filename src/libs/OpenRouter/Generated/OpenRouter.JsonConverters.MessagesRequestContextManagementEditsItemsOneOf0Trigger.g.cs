#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class MessagesRequestContextManagementEditsItemsOneOf0TriggerJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0Trigger>
    {
        /// <inheritdoc />
        public override global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0Trigger Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1? inputTokens = default;
            if (discriminator?.Type == global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminatorType.InputTokens)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1)}");
                inputTokens = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2? toolUses = default;
            if (discriminator?.Type == global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerDiscriminatorType.ToolUses)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2)}");
                toolUses = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0Trigger(
                discriminator?.Type,
                inputTokens,

                toolUses
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0Trigger value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInputTokens)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputTokens!, typeInfo);
            }
            else if (value.IsToolUses)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesRequestContextManagementEditsItemsOneOf0TriggerVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolUses!, typeInfo);
            }
        }
    }
}