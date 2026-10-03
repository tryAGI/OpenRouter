#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class RequestCapacityEntryV2Variant2PerNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.RequestCapacityEntryV2Variant2Per?>
    {
        /// <inheritdoc />
        public override global::OpenRouter.RequestCapacityEntryV2Variant2Per? Read(
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
                        return global::OpenRouter.RequestCapacityEntryV2Variant2PerExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.RequestCapacityEntryV2Variant2Per?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.RequestCapacityEntryV2Variant2Per? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::OpenRouter.RequestCapacityEntryV2Variant2PerExtensions.ToValueString(value.Value));
            }
        }
    }
}
