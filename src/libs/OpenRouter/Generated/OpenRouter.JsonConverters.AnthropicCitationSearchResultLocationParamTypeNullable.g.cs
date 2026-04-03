#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class AnthropicCitationSearchResultLocationParamTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.AnthropicCitationSearchResultLocationParamType?>
    {
        /// <inheritdoc />
        public override global::OpenRouter.AnthropicCitationSearchResultLocationParamType? Read(
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
                        return global::OpenRouter.AnthropicCitationSearchResultLocationParamTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenRouter.AnthropicCitationSearchResultLocationParamType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.AnthropicCitationSearchResultLocationParamType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.AnthropicCitationSearchResultLocationParamType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::OpenRouter.AnthropicCitationSearchResultLocationParamTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
