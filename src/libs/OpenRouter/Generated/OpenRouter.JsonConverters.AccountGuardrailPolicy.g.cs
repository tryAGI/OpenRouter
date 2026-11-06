#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class AccountGuardrailPolicyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.AccountGuardrailPolicy>
    {
        /// <inheritdoc />
        public override global::OpenRouter.AccountGuardrailPolicy Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AccountGuardrailPolicyDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AccountGuardrailPolicyDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.AccountGuardrailPolicyDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.BudgetAccountGuardrailPolicy? budget = default;
            if (discriminator?.PolicyType == global::OpenRouter.AccountGuardrailPolicyDiscriminatorPolicyType.Budget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.BudgetAccountGuardrailPolicy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.BudgetAccountGuardrailPolicy> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.BudgetAccountGuardrailPolicy)}");
                budget = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ModerationAccountGuardrailPolicy? moderation = default;
            if (discriminator?.PolicyType == global::OpenRouter.AccountGuardrailPolicyDiscriminatorPolicyType.Moderation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModerationAccountGuardrailPolicy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModerationAccountGuardrailPolicy> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ModerationAccountGuardrailPolicy)}");
                moderation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ModelAvailabilityAccountGuardrailPolicy? modelAvailability = default;
            if (discriminator?.PolicyType == global::OpenRouter.AccountGuardrailPolicyDiscriminatorPolicyType.ModelAvailability)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelAvailabilityAccountGuardrailPolicy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelAvailabilityAccountGuardrailPolicy> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ModelAvailabilityAccountGuardrailPolicy)}");
                modelAvailability = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.AccountGuardrailPolicy(
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
            global::OpenRouter.AccountGuardrailPolicy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBudget)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.BudgetAccountGuardrailPolicy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.BudgetAccountGuardrailPolicy?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.BudgetAccountGuardrailPolicy).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBudget(), typeInfo);
            }
            else if (value.IsModeration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModerationAccountGuardrailPolicy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModerationAccountGuardrailPolicy?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModerationAccountGuardrailPolicy).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickModeration(), typeInfo);
            }
            else if (value.IsModelAvailability)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelAvailabilityAccountGuardrailPolicy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelAvailabilityAccountGuardrailPolicy?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelAvailabilityAccountGuardrailPolicy).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickModelAvailability(), typeInfo);
            }
        }
    }
}