#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollectionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollection>
    {
        /// <inheritdoc />
        public override global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollection Read(
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
                        return global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollectionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollection)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollection);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollection value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderDataCollectionExtensions.ToValueString(value));
        }
    }
}
