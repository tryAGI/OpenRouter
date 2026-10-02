#nullable enable

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateWorkspaceRequestDisabledServerToolNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.UpdateWorkspaceRequestDisabledServerTool?>
    {
        /// <inheritdoc />
        public override global::OpenRouter.UpdateWorkspaceRequestDisabledServerTool? Read(
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
                        return global::OpenRouter.UpdateWorkspaceRequestDisabledServerToolExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::OpenRouter.UpdateWorkspaceRequestDisabledServerTool?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.UpdateWorkspaceRequestDisabledServerTool? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::OpenRouter.UpdateWorkspaceRequestDisabledServerToolExtensions.ToValueString(value.Value));
            }
        }
    }
}
