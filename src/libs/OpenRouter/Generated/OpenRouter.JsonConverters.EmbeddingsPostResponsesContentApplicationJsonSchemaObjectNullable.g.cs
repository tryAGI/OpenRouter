#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class EmbeddingsPostResponsesContentApplicationJsonSchemaObjectNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaObject?>
    {
        /// <inheritdoc />
        public override global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaObject? Read(
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
                        return global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaObjectExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaObject)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaObject?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaObject? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::OpenRouter.EmbeddingsPostResponsesContentApplicationJsonSchemaObjectExtensions.ToValueString(value.Value));
            }
        }
    }
}
