#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class QueryAnalyticsRequestOrderByDirectionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.QueryAnalyticsRequestOrderByDirection?>
    {
        /// <inheritdoc />
        public override global::OpenRouter.QueryAnalyticsRequestOrderByDirection? Read(
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
                        return global::OpenRouter.QueryAnalyticsRequestOrderByDirectionExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.QueryAnalyticsRequestOrderByDirection?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.QueryAnalyticsRequestOrderByDirection? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::OpenRouter.QueryAnalyticsRequestOrderByDirectionExtensions.ToValueString(value.Value));
            }
        }
    }
}
