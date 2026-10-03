#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class ModelInputV2Variant5ParamsFormatsValueNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.ModelInputV2Variant5ParamsFormatsValue?>
    {
        /// <inheritdoc />
        public override global::OpenRouter.ModelInputV2Variant5ParamsFormatsValue? Read(
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
                        return global::OpenRouter.ModelInputV2Variant5ParamsFormatsValueExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.ModelInputV2Variant5ParamsFormatsValue?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.ModelInputV2Variant5ParamsFormatsValue? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::OpenRouter.ModelInputV2Variant5ParamsFormatsValueExtensions.ToValueString(value.Value));
            }
        }
    }
}
