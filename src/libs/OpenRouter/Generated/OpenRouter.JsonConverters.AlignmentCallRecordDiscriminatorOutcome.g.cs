#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class AlignmentCallRecordDiscriminatorOutcomeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.AlignmentCallRecordDiscriminatorOutcome>
    {
        /// <inheritdoc />
        public override global::OpenRouter.AlignmentCallRecordDiscriminatorOutcome Read(
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
                        return global::OpenRouter.AlignmentCallRecordDiscriminatorOutcomeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::OpenRouter.AlignmentCallRecordDiscriminatorOutcome)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.AlignmentCallRecordDiscriminatorOutcome);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.AlignmentCallRecordDiscriminatorOutcome value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::OpenRouter.AlignmentCallRecordDiscriminatorOutcomeExtensions.ToValueString(value));
        }
    }
}
