#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class FileSearchServerToolRankingOptionsRankerNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.FileSearchServerToolRankingOptionsRanker?>
    {
        /// <inheritdoc />
        public override global::OpenRouter.FileSearchServerToolRankingOptionsRanker? Read(
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
                        return global::OpenRouter.FileSearchServerToolRankingOptionsRankerExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenRouter.FileSearchServerToolRankingOptionsRanker)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.FileSearchServerToolRankingOptionsRanker?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.FileSearchServerToolRankingOptionsRanker? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::OpenRouter.FileSearchServerToolRankingOptionsRankerExtensions.ToValueString(value.Value));
            }
        }
    }
}
