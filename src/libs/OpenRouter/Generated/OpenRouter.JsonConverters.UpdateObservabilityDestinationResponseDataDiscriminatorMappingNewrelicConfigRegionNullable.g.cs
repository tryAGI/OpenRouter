#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfigRegionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfigRegion?>
    {
        /// <inheritdoc />
        public override global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfigRegion? Read(
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
                        return global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfigRegionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfigRegion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfigRegion?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfigRegion? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingNewrelicConfigRegionExtensions.ToValueString(value.Value));
            }
        }
    }
}
