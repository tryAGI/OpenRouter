#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class SpeechInputModalityVariant1TurnsNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.SpeechInputModalityVariant1Turns?>
    {
        /// <inheritdoc />
        public override global::OpenRouter.SpeechInputModalityVariant1Turns? Read(
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
                        return global::OpenRouter.SpeechInputModalityVariant1TurnsExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.SpeechInputModalityVariant1Turns?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.SpeechInputModalityVariant1Turns? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::OpenRouter.SpeechInputModalityVariant1TurnsExtensions.ToValueString(value.Value));
            }
        }
    }
}
