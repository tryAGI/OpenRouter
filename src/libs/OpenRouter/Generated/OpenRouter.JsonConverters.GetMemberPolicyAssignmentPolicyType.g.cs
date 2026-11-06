#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetMemberPolicyAssignmentPolicyTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.GetMemberPolicyAssignmentPolicyType>
    {
        /// <inheritdoc />
        public override global::OpenRouter.GetMemberPolicyAssignmentPolicyType Read(
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
                        return global::OpenRouter.GetMemberPolicyAssignmentPolicyTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.GetMemberPolicyAssignmentPolicyType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.GetMemberPolicyAssignmentPolicyType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::OpenRouter.GetMemberPolicyAssignmentPolicyTypeExtensions.ToValueString(value));
        }
    }
}
