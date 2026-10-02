#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class MessagesStreamEventsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.MessagesStreamEvents>
    {
        /// <inheritdoc />
        public override global::OpenRouter.MessagesStreamEvents Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesStreamEventsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesStreamEventsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.MessagesStreamEventsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.MessagesStartEvent? messageStart = default;
            if (discriminator?.Type == global::OpenRouter.MessagesStreamEventsDiscriminatorType.MessageStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.MessagesStartEvent)}");
                messageStart = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.MessagesDeltaEvent? messageDelta = default;
            if (discriminator?.Type == global::OpenRouter.MessagesStreamEventsDiscriminatorType.MessageDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.MessagesDeltaEvent)}");
                messageDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.MessagesStopEvent? messageStop = default;
            if (discriminator?.Type == global::OpenRouter.MessagesStreamEventsDiscriminatorType.MessageStop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesStopEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesStopEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.MessagesStopEvent)}");
                messageStop = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.MessagesContentBlockStartEvent? contentBlockStart = default;
            if (discriminator?.Type == global::OpenRouter.MessagesStreamEventsDiscriminatorType.ContentBlockStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesContentBlockStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesContentBlockStartEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.MessagesContentBlockStartEvent)}");
                contentBlockStart = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.MessagesContentBlockDeltaEvent? contentBlockDelta = default;
            if (discriminator?.Type == global::OpenRouter.MessagesStreamEventsDiscriminatorType.ContentBlockDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesContentBlockDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesContentBlockDeltaEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.MessagesContentBlockDeltaEvent)}");
                contentBlockDelta = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.MessagesContentBlockStopEvent? contentBlockStop = default;
            if (discriminator?.Type == global::OpenRouter.MessagesStreamEventsDiscriminatorType.ContentBlockStop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesContentBlockStopEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesContentBlockStopEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.MessagesContentBlockStopEvent)}");
                contentBlockStop = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.MessagesPingEvent? ping = default;
            if (discriminator?.Type == global::OpenRouter.MessagesStreamEventsDiscriminatorType.Ping)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesPingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesPingEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.MessagesPingEvent)}");
                ping = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.MessagesErrorEvent? error = default;
            if (discriminator?.Type == global::OpenRouter.MessagesStreamEventsDiscriminatorType.Error)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesErrorEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.MessagesErrorEvent)}");
                error = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.MessagesStreamEvents(
                discriminator?.Type,
                messageStart,

                messageDelta,

                messageStop,

                contentBlockStart,

                contentBlockDelta,

                contentBlockStop,

                ping,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.MessagesStreamEvents value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessageStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesStartEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesStartEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMessageStart(), typeInfo);
            }
            else if (value.IsMessageDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMessageDelta(), typeInfo);
            }
            else if (value.IsMessageStop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesStopEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesStopEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesStopEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMessageStop(), typeInfo);
            }
            else if (value.IsContentBlockStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesContentBlockStartEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesContentBlockStartEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesContentBlockStartEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickContentBlockStart(), typeInfo);
            }
            else if (value.IsContentBlockDelta)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesContentBlockDeltaEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesContentBlockDeltaEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesContentBlockDeltaEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickContentBlockDelta(), typeInfo);
            }
            else if (value.IsContentBlockStop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesContentBlockStopEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesContentBlockStopEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesContentBlockStopEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickContentBlockStop(), typeInfo);
            }
            else if (value.IsPing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesPingEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesPingEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesPingEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickPing(), typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesErrorEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesErrorEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesErrorEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickError(), typeInfo);
            }
        }
    }
}