#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class BaseResponsesResultToolVariant1AllowedCallerJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.BaseResponsesResultToolVariant1AllowedCaller>
    {
        /// <inheritdoc />
        public override global::OpenRouter.BaseResponsesResultToolVariant1AllowedCaller Read(
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
                        return global::OpenRouter.BaseResponsesResultToolVariant1AllowedCallerExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.BaseResponsesResultToolVariant1AllowedCaller);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.BaseResponsesResultToolVariant1AllowedCaller value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::OpenRouter.BaseResponsesResultToolVariant1AllowedCallerExtensions.ToValueString(value));
        }
    }
}
