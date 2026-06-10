#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirectionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirection?>
    {
        /// <inheritdoc />
        public override global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirection? Read(
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
                        return global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirectionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirection)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirection?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirection? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderByDirectionExtensions.ToValueString(value.Value));
            }
        }
    }
}
