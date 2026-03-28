#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class MessagesRequestPluginsItemsOneOf3IdJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.MessagesRequestPluginsItemsOneOf3Id>
    {
        /// <inheritdoc />
        public override global::OpenRouter.MessagesRequestPluginsItemsOneOf3Id Read(
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
                        return global::OpenRouter.MessagesRequestPluginsItemsOneOf3IdExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenRouter.MessagesRequestPluginsItemsOneOf3Id)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.MessagesRequestPluginsItemsOneOf3Id);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.MessagesRequestPluginsItemsOneOf3Id value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::OpenRouter.MessagesRequestPluginsItemsOneOf3IdExtensions.ToValueString(value));
        }
    }
}
