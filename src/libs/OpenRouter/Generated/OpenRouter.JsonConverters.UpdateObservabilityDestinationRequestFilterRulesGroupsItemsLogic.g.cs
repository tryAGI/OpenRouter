#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateObservabilityDestinationRequestFilterRulesGroupsItemsLogicJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.UpdateObservabilityDestinationRequestFilterRulesGroupsItemsLogic>
    {
        /// <inheritdoc />
        public override global::OpenRouter.UpdateObservabilityDestinationRequestFilterRulesGroupsItemsLogic Read(
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
                        return global::OpenRouter.UpdateObservabilityDestinationRequestFilterRulesGroupsItemsLogicExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenRouter.UpdateObservabilityDestinationRequestFilterRulesGroupsItemsLogic)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.UpdateObservabilityDestinationRequestFilterRulesGroupsItemsLogic);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.UpdateObservabilityDestinationRequestFilterRulesGroupsItemsLogic value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::OpenRouter.UpdateObservabilityDestinationRequestFilterRulesGroupsItemsLogicExtensions.ToValueString(value));
        }
    }
}
