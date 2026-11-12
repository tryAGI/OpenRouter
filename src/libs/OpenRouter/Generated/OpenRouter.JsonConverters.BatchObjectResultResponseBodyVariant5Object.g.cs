#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class BatchObjectResultResponseBodyVariant5ObjectJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.BatchObjectResultResponseBodyVariant5Object>
    {
        /// <inheritdoc />
        public override global::OpenRouter.BatchObjectResultResponseBodyVariant5Object Read(
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
                        return global::OpenRouter.BatchObjectResultResponseBodyVariant5ObjectExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenRouter.BatchObjectResultResponseBodyVariant5Object)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.BatchObjectResultResponseBodyVariant5Object);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.BatchObjectResultResponseBodyVariant5Object value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::OpenRouter.BatchObjectResultResponseBodyVariant5ObjectExtensions.ToValueString(value));
        }
    }
}
