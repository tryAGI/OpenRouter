#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateObservabilityDestinationResponseDataVariant17TypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17Type?>
    {
        /// <inheritdoc />
        public override global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17Type? Read(
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
                        return global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17TypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17Type?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17Type? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::OpenRouter.CreateObservabilityDestinationResponseDataVariant17TypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
