#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateCreditPurchaseRequestProtocolNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.CreateCreditPurchaseRequestProtocol?>
    {
        /// <inheritdoc />
        public override global::OpenRouter.CreateCreditPurchaseRequestProtocol? Read(
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
                        return global::OpenRouter.CreateCreditPurchaseRequestProtocolExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.CreateCreditPurchaseRequestProtocol?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.CreateCreditPurchaseRequestProtocol? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::OpenRouter.CreateCreditPurchaseRequestProtocolExtensions.ToValueString(value.Value));
            }
        }
    }
}
