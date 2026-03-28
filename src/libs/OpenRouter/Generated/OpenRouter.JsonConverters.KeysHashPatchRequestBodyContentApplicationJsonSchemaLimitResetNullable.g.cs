#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitResetNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitReset?>
    {
        /// <inheritdoc />
        public override global::OpenRouter.KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitReset? Read(
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
                        return global::OpenRouter.KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitResetExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenRouter.KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitReset)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitReset?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitReset? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::OpenRouter.KeysHashPatchRequestBodyContentApplicationJsonSchemaLimitResetExtensions.ToValueString(value.Value));
            }
        }
    }
}
