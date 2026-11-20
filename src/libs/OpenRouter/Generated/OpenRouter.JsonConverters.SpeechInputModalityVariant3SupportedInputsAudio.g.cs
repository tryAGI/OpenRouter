#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class SpeechInputModalityVariant3SupportedInputsAudioJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.SpeechInputModalityVariant3SupportedInputsAudio>
    {
        /// <inheritdoc />
        public override global::OpenRouter.SpeechInputModalityVariant3SupportedInputsAudio Read(
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
                        return global::OpenRouter.SpeechInputModalityVariant3SupportedInputsAudioExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.SpeechInputModalityVariant3SupportedInputsAudio);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.SpeechInputModalityVariant3SupportedInputsAudio value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::OpenRouter.SpeechInputModalityVariant3SupportedInputsAudioExtensions.ToValueString(value));
        }
    }
}
