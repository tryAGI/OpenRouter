#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class StopServerToolsWhenConditionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.StopServerToolsWhenCondition>
    {
        /// <inheritdoc />
        public override global::OpenRouter.StopServerToolsWhenCondition Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StopServerToolsWhenConditionDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StopServerToolsWhenConditionDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.StopServerToolsWhenConditionDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.StopServerToolsWhenStepCountIs? stepCountIs = default;
            if (discriminator?.Type == global::OpenRouter.StopServerToolsWhenConditionDiscriminatorType.StepCountIs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StopServerToolsWhenStepCountIs), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StopServerToolsWhenStepCountIs> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.StopServerToolsWhenStepCountIs)}");
                stepCountIs = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.StopServerToolsWhenHasToolCall? hasToolCall = default;
            if (discriminator?.Type == global::OpenRouter.StopServerToolsWhenConditionDiscriminatorType.HasToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StopServerToolsWhenHasToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StopServerToolsWhenHasToolCall> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.StopServerToolsWhenHasToolCall)}");
                hasToolCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.StopServerToolsWhenMaxTokensUsed? maxTokensUsed = default;
            if (discriminator?.Type == global::OpenRouter.StopServerToolsWhenConditionDiscriminatorType.MaxTokensUsed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StopServerToolsWhenMaxTokensUsed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StopServerToolsWhenMaxTokensUsed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.StopServerToolsWhenMaxTokensUsed)}");
                maxTokensUsed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.StopServerToolsWhenMaxCost? maxCost = default;
            if (discriminator?.Type == global::OpenRouter.StopServerToolsWhenConditionDiscriminatorType.MaxCost)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StopServerToolsWhenMaxCost), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StopServerToolsWhenMaxCost> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.StopServerToolsWhenMaxCost)}");
                maxCost = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.StopServerToolsWhenFinishReasonIs? finishReasonIs = default;
            if (discriminator?.Type == global::OpenRouter.StopServerToolsWhenConditionDiscriminatorType.FinishReasonIs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StopServerToolsWhenFinishReasonIs), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StopServerToolsWhenFinishReasonIs> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.StopServerToolsWhenFinishReasonIs)}");
                finishReasonIs = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.StopServerToolsWhenCondition(
                discriminator?.Type,
                stepCountIs,

                hasToolCall,

                maxTokensUsed,

                maxCost,

                finishReasonIs
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.StopServerToolsWhenCondition value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStepCountIs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StopServerToolsWhenStepCountIs), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StopServerToolsWhenStepCountIs?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.StopServerToolsWhenStepCountIs).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickStepCountIs(), typeInfo);
            }
            else if (value.IsHasToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StopServerToolsWhenHasToolCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StopServerToolsWhenHasToolCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.StopServerToolsWhenHasToolCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickHasToolCall(), typeInfo);
            }
            else if (value.IsMaxTokensUsed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StopServerToolsWhenMaxTokensUsed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StopServerToolsWhenMaxTokensUsed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.StopServerToolsWhenMaxTokensUsed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMaxTokensUsed(), typeInfo);
            }
            else if (value.IsMaxCost)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StopServerToolsWhenMaxCost), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StopServerToolsWhenMaxCost?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.StopServerToolsWhenMaxCost).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMaxCost(), typeInfo);
            }
            else if (value.IsFinishReasonIs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StopServerToolsWhenFinishReasonIs), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StopServerToolsWhenFinishReasonIs?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.StopServerToolsWhenFinishReasonIs).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFinishReasonIs(), typeInfo);
            }
        }
    }
}