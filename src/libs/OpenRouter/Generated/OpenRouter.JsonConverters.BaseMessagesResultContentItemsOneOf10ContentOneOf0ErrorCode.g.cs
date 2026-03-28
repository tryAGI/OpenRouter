#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCodeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCode>
    {
        /// <inheritdoc />
        public override global::OpenRouter.BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCode Read(
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
                        return global::OpenRouter.BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCodeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenRouter.BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::OpenRouter.BaseMessagesResultContentItemsOneOf10ContentOneOf0ErrorCodeExtensions.ToValueString(value));
        }
    }
}
