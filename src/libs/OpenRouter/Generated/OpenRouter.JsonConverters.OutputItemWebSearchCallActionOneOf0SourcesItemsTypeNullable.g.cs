#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class OutputItemWebSearchCallActionOneOf0SourcesItemsTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.OutputItemWebSearchCallActionOneOf0SourcesItemsType?>
    {
        /// <inheritdoc />
        public override global::OpenRouter.OutputItemWebSearchCallActionOneOf0SourcesItemsType? Read(
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
                        return global::OpenRouter.OutputItemWebSearchCallActionOneOf0SourcesItemsTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenRouter.OutputItemWebSearchCallActionOneOf0SourcesItemsType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.OutputItemWebSearchCallActionOneOf0SourcesItemsType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.OutputItemWebSearchCallActionOneOf0SourcesItemsType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::OpenRouter.OutputItemWebSearchCallActionOneOf0SourcesItemsTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
