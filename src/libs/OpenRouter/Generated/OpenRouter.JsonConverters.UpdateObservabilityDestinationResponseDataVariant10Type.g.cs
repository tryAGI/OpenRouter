#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateObservabilityDestinationResponseDataVariant10TypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant10Type>
    {
        /// <inheritdoc />
        public override global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant10Type Read(
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
                        return global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant10TypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant10Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant10Type);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant10Type value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::OpenRouter.UpdateObservabilityDestinationResponseDataVariant10TypeExtensions.ToValueString(value));
        }
    }
}
