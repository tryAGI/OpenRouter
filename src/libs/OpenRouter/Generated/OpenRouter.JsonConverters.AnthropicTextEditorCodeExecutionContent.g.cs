#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class AnthropicTextEditorCodeExecutionContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.AnthropicTextEditorCodeExecutionContent>
    {
        /// <inheritdoc />
        public override global::OpenRouter.AnthropicTextEditorCodeExecutionContent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

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
            if (__jsonProps.Contains("error_code")) __score0++;
            if (__jsonProps.Contains("error_message")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("file_type")) __score1++;
            if (__jsonProps.Contains("num_lines")) __score1++;
            if (__jsonProps.Contains("start_line")) __score1++;
            if (__jsonProps.Contains("total_lines")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("is_file_update")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("lines")) __score3++;
            if (__jsonProps.Contains("new_lines")) __score3++;
            if (__jsonProps.Contains("new_start")) __score3++;
            if (__jsonProps.Contains("old_lines")) __score3++;
            if (__jsonProps.Contains("old_start")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError? anthropicTextEditorCodeExecutionToolResultError = default;
            global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult? anthropicTextEditorCodeExecutionViewResult = default;
            global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult? anthropicTextEditorCodeExecutionCreateResult = default;
            global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult? anthropicTextEditorCodeExecutionStrReplaceResult = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError).Name}");
                        anthropicTextEditorCodeExecutionToolResultError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult).Name}");
                        anthropicTextEditorCodeExecutionViewResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult).Name}");
                        anthropicTextEditorCodeExecutionCreateResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult).Name}");
                        anthropicTextEditorCodeExecutionStrReplaceResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (anthropicTextEditorCodeExecutionToolResultError == null && anthropicTextEditorCodeExecutionViewResult == null && anthropicTextEditorCodeExecutionCreateResult == null && anthropicTextEditorCodeExecutionStrReplaceResult == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError).Name}");
                    anthropicTextEditorCodeExecutionToolResultError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult).Name}");
                    anthropicTextEditorCodeExecutionViewResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult).Name}");
                    anthropicTextEditorCodeExecutionCreateResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult).Name}");
                    anthropicTextEditorCodeExecutionStrReplaceResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::OpenRouter.AnthropicTextEditorCodeExecutionContent(
                anthropicTextEditorCodeExecutionToolResultError,

                anthropicTextEditorCodeExecutionViewResult,

                anthropicTextEditorCodeExecutionCreateResult,

                anthropicTextEditorCodeExecutionStrReplaceResult
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.AnthropicTextEditorCodeExecutionContent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAnthropicTextEditorCodeExecutionToolResultError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnthropicTextEditorCodeExecutionToolResultError!, typeInfo);
            }
            else if (value.IsAnthropicTextEditorCodeExecutionViewResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnthropicTextEditorCodeExecutionViewResult!, typeInfo);
            }
            else if (value.IsAnthropicTextEditorCodeExecutionCreateResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnthropicTextEditorCodeExecutionCreateResult!, typeInfo);
            }
            else if (value.IsAnthropicTextEditorCodeExecutionStrReplaceResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnthropicTextEditorCodeExecutionStrReplaceResult!, typeInfo);
            }
        }
    }
}