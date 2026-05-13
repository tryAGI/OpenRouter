#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApplyPatchCallItemOperationOneOf2TypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.ApplyPatchCallItemOperationOneOf2Type?>
    {
        /// <inheritdoc />
        public override global::OpenRouter.ApplyPatchCallItemOperationOneOf2Type? Read(
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
                        return global::OpenRouter.ApplyPatchCallItemOperationOneOf2TypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenRouter.ApplyPatchCallItemOperationOneOf2Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.ApplyPatchCallItemOperationOneOf2Type?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.ApplyPatchCallItemOperationOneOf2Type? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::OpenRouter.ApplyPatchCallItemOperationOneOf2TypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
