#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2TypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2Type>
    {
        /// <inheritdoc />
        public override global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2Type Read(
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
                        return global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2TypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2Type);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2Type value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2TypeExtensions.ToValueString(value));
        }
    }
}
