#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class AdditionalToolsItemToolAllowedCallerJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.AdditionalToolsItemToolAllowedCaller>
    {
        /// <inheritdoc />
        public override global::OpenRouter.AdditionalToolsItemToolAllowedCaller Read(
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
                        return global::OpenRouter.AdditionalToolsItemToolAllowedCallerExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.AdditionalToolsItemToolAllowedCaller);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.AdditionalToolsItemToolAllowedCaller value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::OpenRouter.AdditionalToolsItemToolAllowedCallerExtensions.ToValueString(value));
        }
    }
}
