#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class MessagesRequestToolsItemsOneOf3CacheControlTtlJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.MessagesRequestToolsItemsOneOf3CacheControlTtl>
    {
        /// <inheritdoc />
        public override global::OpenRouter.MessagesRequestToolsItemsOneOf3CacheControlTtl Read(
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
                        return global::OpenRouter.MessagesRequestToolsItemsOneOf3CacheControlTtlExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenRouter.MessagesRequestToolsItemsOneOf3CacheControlTtl)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.MessagesRequestToolsItemsOneOf3CacheControlTtl);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.MessagesRequestToolsItemsOneOf3CacheControlTtl value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::OpenRouter.MessagesRequestToolsItemsOneOf3CacheControlTtlExtensions.ToValueString(value));
        }
    }
}
