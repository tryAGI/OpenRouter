#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class GuardrailsGetResponsesContentApplicationJsonSchemaDataItemsResetIntervalNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.GuardrailsGetResponsesContentApplicationJsonSchemaDataItemsResetInterval?>
    {
        /// <inheritdoc />
        public override global::OpenRouter.GuardrailsGetResponsesContentApplicationJsonSchemaDataItemsResetInterval? Read(
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
                        return global::OpenRouter.GuardrailsGetResponsesContentApplicationJsonSchemaDataItemsResetIntervalExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenRouter.GuardrailsGetResponsesContentApplicationJsonSchemaDataItemsResetInterval)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.GuardrailsGetResponsesContentApplicationJsonSchemaDataItemsResetInterval?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.GuardrailsGetResponsesContentApplicationJsonSchemaDataItemsResetInterval? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::OpenRouter.GuardrailsGetResponsesContentApplicationJsonSchemaDataItemsResetIntervalExtensions.ToValueString(value.Value));
            }
        }
    }
}
