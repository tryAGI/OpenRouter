#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class BatchObjectResultResponseBodyVariant1ChoiceMessageImageTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageImageType?>
    {
        /// <inheritdoc />
        public override global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageImageType? Read(
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
                        return global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageImageTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageImageType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageImageType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageImageType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageImageTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
