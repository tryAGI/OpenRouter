#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class ObservabilityFilterRulesConfigGroupsItemsLogicNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.ObservabilityFilterRulesConfigGroupsItemsLogic?>
    {
        /// <inheritdoc />
        public override global::OpenRouter.ObservabilityFilterRulesConfigGroupsItemsLogic? Read(
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
                        return global::OpenRouter.ObservabilityFilterRulesConfigGroupsItemsLogicExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenRouter.ObservabilityFilterRulesConfigGroupsItemsLogic)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.ObservabilityFilterRulesConfigGroupsItemsLogic?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.ObservabilityFilterRulesConfigGroupsItemsLogic? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::OpenRouter.ObservabilityFilterRulesConfigGroupsItemsLogicExtensions.ToValueString(value.Value));
            }
        }
    }
}
