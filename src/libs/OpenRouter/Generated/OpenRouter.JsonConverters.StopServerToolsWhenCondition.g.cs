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

            global::OpenRouter.StopServerToolsWhenConditionVariant1? finishReasonIs = default;
            if (discriminator?.Type == global::OpenRouter.StopServerToolsWhenConditionDiscriminatorType.FinishReasonIs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StopServerToolsWhenConditionVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StopServerToolsWhenConditionVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.StopServerToolsWhenConditionVariant1)}");
                finishReasonIs = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.StopServerToolsWhenConditionVariant2? hasToolCall = default;
            if (discriminator?.Type == global::OpenRouter.StopServerToolsWhenConditionDiscriminatorType.HasToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StopServerToolsWhenConditionVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StopServerToolsWhenConditionVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.StopServerToolsWhenConditionVariant2)}");
                hasToolCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.StopServerToolsWhenConditionVariant3? maxCost = default;
            if (discriminator?.Type == global::OpenRouter.StopServerToolsWhenConditionDiscriminatorType.MaxCost)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StopServerToolsWhenConditionVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StopServerToolsWhenConditionVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.StopServerToolsWhenConditionVariant3)}");
                maxCost = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.StopServerToolsWhenConditionVariant4? maxTokensUsed = default;
            if (discriminator?.Type == global::OpenRouter.StopServerToolsWhenConditionDiscriminatorType.MaxTokensUsed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StopServerToolsWhenConditionVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StopServerToolsWhenConditionVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.StopServerToolsWhenConditionVariant4)}");
                maxTokensUsed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.StopServerToolsWhenConditionVariant5? stepCountIs = default;
            if (discriminator?.Type == global::OpenRouter.StopServerToolsWhenConditionDiscriminatorType.StepCountIs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StopServerToolsWhenConditionVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StopServerToolsWhenConditionVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.StopServerToolsWhenConditionVariant5)}");
                stepCountIs = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.StopServerToolsWhenCondition(
                discriminator?.Type,
                finishReasonIs,

                hasToolCall,

                maxCost,

                maxTokensUsed,

                stepCountIs
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

            if (value.IsFinishReasonIs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StopServerToolsWhenConditionVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StopServerToolsWhenConditionVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.StopServerToolsWhenConditionVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FinishReasonIs!, typeInfo);
            }
            else if (value.IsHasToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StopServerToolsWhenConditionVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StopServerToolsWhenConditionVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.StopServerToolsWhenConditionVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.HasToolCall!, typeInfo);
            }
            else if (value.IsMaxCost)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StopServerToolsWhenConditionVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StopServerToolsWhenConditionVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.StopServerToolsWhenConditionVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MaxCost!, typeInfo);
            }
            else if (value.IsMaxTokensUsed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StopServerToolsWhenConditionVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StopServerToolsWhenConditionVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.StopServerToolsWhenConditionVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MaxTokensUsed!, typeInfo);
            }
            else if (value.IsStepCountIs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.StopServerToolsWhenConditionVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.StopServerToolsWhenConditionVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.StopServerToolsWhenConditionVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StepCountIs!, typeInfo);
            }
        }
    }
}