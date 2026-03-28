#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf0CitationsItemsOneOf0TypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf0CitationsItemsOneOf0Type?>
    {
        /// <inheritdoc />
        public override global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf0CitationsItemsOneOf0Type? Read(
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
                        return global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf0CitationsItemsOneOf0TypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf0CitationsItemsOneOf0Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf0CitationsItemsOneOf0Type?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf0CitationsItemsOneOf0Type? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1ItemsOneOf0CitationsItemsOneOf0TypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
