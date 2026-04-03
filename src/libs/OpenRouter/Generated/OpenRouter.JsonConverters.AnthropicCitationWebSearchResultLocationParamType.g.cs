#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class AnthropicCitationWebSearchResultLocationParamTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.AnthropicCitationWebSearchResultLocationParamType>
    {
        /// <inheritdoc />
        public override global::OpenRouter.AnthropicCitationWebSearchResultLocationParamType Read(
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
                        return global::OpenRouter.AnthropicCitationWebSearchResultLocationParamTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenRouter.AnthropicCitationWebSearchResultLocationParamType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.AnthropicCitationWebSearchResultLocationParamType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.AnthropicCitationWebSearchResultLocationParamType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::OpenRouter.AnthropicCitationWebSearchResultLocationParamTypeExtensions.ToValueString(value));
        }
    }
}
