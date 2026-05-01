#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class EasyInputMessageContentOneOf0ItemsOneOf1DetailJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.EasyInputMessageContentOneOf0ItemsOneOf1Detail>
    {
        /// <inheritdoc />
        public override global::OpenRouter.EasyInputMessageContentOneOf0ItemsOneOf1Detail Read(
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
                        return global::OpenRouter.EasyInputMessageContentOneOf0ItemsOneOf1DetailExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenRouter.EasyInputMessageContentOneOf0ItemsOneOf1Detail)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.EasyInputMessageContentOneOf0ItemsOneOf1Detail);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.EasyInputMessageContentOneOf0ItemsOneOf1Detail value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::OpenRouter.EasyInputMessageContentOneOf0ItemsOneOf1DetailExtensions.ToValueString(value));
        }
    }
}
