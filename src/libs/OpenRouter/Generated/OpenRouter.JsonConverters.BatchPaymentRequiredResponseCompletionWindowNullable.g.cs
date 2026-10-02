#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class BatchPaymentRequiredResponseCompletionWindowNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.BatchPaymentRequiredResponseCompletionWindow?>
    {
        /// <inheritdoc />
        public override global::OpenRouter.BatchPaymentRequiredResponseCompletionWindow? Read(
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
                        return global::OpenRouter.BatchPaymentRequiredResponseCompletionWindowExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenRouter.BatchPaymentRequiredResponseCompletionWindow)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.BatchPaymentRequiredResponseCompletionWindow?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.BatchPaymentRequiredResponseCompletionWindow? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::OpenRouter.BatchPaymentRequiredResponseCompletionWindowExtensions.ToValueString(value.Value));
            }
        }
    }
}
