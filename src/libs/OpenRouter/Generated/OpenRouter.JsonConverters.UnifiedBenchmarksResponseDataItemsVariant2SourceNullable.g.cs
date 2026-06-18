#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class UnifiedBenchmarksResponseDataItemsVariant2SourceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2Source?>
    {
        /// <inheritdoc />
        public override global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2Source? Read(
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
                        return global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2SourceExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2Source)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2Source?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2Source? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::OpenRouter.UnifiedBenchmarksResponseDataItemsVariant2SourceExtensions.ToValueString(value.Value));
            }
        }
    }
}
