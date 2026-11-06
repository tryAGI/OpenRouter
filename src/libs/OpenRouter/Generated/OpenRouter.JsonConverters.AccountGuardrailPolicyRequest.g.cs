#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class AccountGuardrailPolicyRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.AccountGuardrailPolicyRequest>
    {
        /// <inheritdoc />
        public override global::OpenRouter.AccountGuardrailPolicyRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AccountGuardrailPolicyRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AccountGuardrailPolicyRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AccountGuardrailPolicyRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.BudgetAccountGuardrailPolicyRequest? budget = default;
            if (discriminator?.PolicyType == global::OpenRouter.AccountGuardrailPolicyRequestDiscriminatorPolicyType.Budget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.BudgetAccountGuardrailPolicyRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.BudgetAccountGuardrailPolicyRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.BudgetAccountGuardrailPolicyRequest)}");
                budget = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ModerationAccountGuardrailPolicyRequest? moderation = default;
            if (discriminator?.PolicyType == global::OpenRouter.AccountGuardrailPolicyRequestDiscriminatorPolicyType.Moderation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModerationAccountGuardrailPolicyRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModerationAccountGuardrailPolicyRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ModerationAccountGuardrailPolicyRequest)}");
                moderation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ModelAvailabilityAccountGuardrailPolicyRequest? modelAvailability = default;
            if (discriminator?.PolicyType == global::OpenRouter.AccountGuardrailPolicyRequestDiscriminatorPolicyType.ModelAvailability)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelAvailabilityAccountGuardrailPolicyRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelAvailabilityAccountGuardrailPolicyRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ModelAvailabilityAccountGuardrailPolicyRequest)}");
                modelAvailability = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.AccountGuardrailPolicyRequest(
                discriminator?.PolicyType,
                budget,

                moderation,

                modelAvailability
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.AccountGuardrailPolicyRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBudget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.BudgetAccountGuardrailPolicyRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.BudgetAccountGuardrailPolicyRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.BudgetAccountGuardrailPolicyRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBudget(), typeInfo);
            }
            else if (value.IsModeration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModerationAccountGuardrailPolicyRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModerationAccountGuardrailPolicyRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModerationAccountGuardrailPolicyRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickModeration(), typeInfo);
            }
            else if (value.IsModelAvailability)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelAvailabilityAccountGuardrailPolicyRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelAvailabilityAccountGuardrailPolicyRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelAvailabilityAccountGuardrailPolicyRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickModelAvailability(), typeInfo);
            }
        }
    }
}