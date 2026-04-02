#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class ChatRequestResponseFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.ChatRequestResponseFormat>
    {
        /// <inheritdoc />
        public override global::OpenRouter.ChatRequestResponseFormat Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("json_schema")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("grammar")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("type")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::OpenRouter.ChatFormatTextConfig? chatFormatTextConfig = default;
            global::OpenRouter.FormatJsonObjectConfig? formatJsonObjectConfig = default;
            global::OpenRouter.ChatFormatJsonSchemaConfig? chatFormatJsonSchemaConfig = default;
            global::OpenRouter.ChatFormatGrammarConfig? chatFormatGrammarConfig = default;
            global::OpenRouter.ChatFormatPythonConfig? chatFormatPythonConfig = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        chatFormatTextConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.ChatFormatTextConfig>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        formatJsonObjectConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.FormatJsonObjectConfig>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        chatFormatJsonSchemaConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.ChatFormatJsonSchemaConfig>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        chatFormatGrammarConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.ChatFormatGrammarConfig>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        chatFormatPythonConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.ChatFormatPythonConfig>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (chatFormatTextConfig == null && formatJsonObjectConfig == null && chatFormatJsonSchemaConfig == null && chatFormatGrammarConfig == null && chatFormatPythonConfig == null)
            {
                try
                {
                    chatFormatTextConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.ChatFormatTextConfig>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    formatJsonObjectConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.FormatJsonObjectConfig>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    chatFormatJsonSchemaConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.ChatFormatJsonSchemaConfig>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    chatFormatGrammarConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.ChatFormatGrammarConfig>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    chatFormatPythonConfig = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.ChatFormatPythonConfig>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::OpenRouter.ChatRequestResponseFormat(
                chatFormatTextConfig,

                formatJsonObjectConfig,

                chatFormatJsonSchemaConfig,

                chatFormatGrammarConfig,

                chatFormatPythonConfig
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.ChatRequestResponseFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsChatFormatTextConfig)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatFormatTextConfig, typeof(global::OpenRouter.ChatFormatTextConfig), options);
            }
            else if (value.IsFormatJsonObjectConfig)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FormatJsonObjectConfig, typeof(global::OpenRouter.FormatJsonObjectConfig), options);
            }
            else if (value.IsChatFormatJsonSchemaConfig)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatFormatJsonSchemaConfig, typeof(global::OpenRouter.ChatFormatJsonSchemaConfig), options);
            }
            else if (value.IsChatFormatGrammarConfig)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatFormatGrammarConfig, typeof(global::OpenRouter.ChatFormatGrammarConfig), options);
            }
            else if (value.IsChatFormatPythonConfig)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatFormatPythonConfig, typeof(global::OpenRouter.ChatFormatPythonConfig), options);
            }
        }
    }
}