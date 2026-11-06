#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetApiKeyPolicyAssignmentPolicyTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.GetApiKeyPolicyAssignmentPolicyType>
    {
        /// <inheritdoc />
        public override global::OpenRouter.GetApiKeyPolicyAssignmentPolicyType Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::OpenRouter.GetApiKeyPolicyAssignmentPolicyTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.GetApiKeyPolicyAssignmentPolicyType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.GetApiKeyPolicyAssignmentPolicyType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::OpenRouter.GetApiKeyPolicyAssignmentPolicyTypeExtensions.ToValueString(value));
        }
    }
}
