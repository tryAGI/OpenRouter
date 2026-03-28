#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class BaseInputsOneOf1ItemsOneOf0Phase1NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Phase1?>
    {
        /// <inheritdoc />
        public override global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Phase1? Read(
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
                        return global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Phase1Extensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Phase1)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Phase1?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Phase1? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::OpenRouter.BaseInputsOneOf1ItemsOneOf0Phase1Extensions.ToValueString(value.Value));
            }
        }
    }
}
