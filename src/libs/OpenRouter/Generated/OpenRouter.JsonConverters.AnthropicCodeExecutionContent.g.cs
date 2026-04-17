#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class AnthropicCodeExecutionContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.AnthropicCodeExecutionContent>
    {
        /// <inheritdoc />
        public override global::OpenRouter.AnthropicCodeExecutionContent Read(
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
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("return_code")) __score1++;
            if (__jsonProps.Contains("stderr")) __score1++;
            if (__jsonProps.Contains("stdout")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("content")) __score2++;
            if (__jsonProps.Contains("encrypted_stdout")) __score2++;
            if (__jsonProps.Contains("return_code")) __score2++;
            if (__jsonProps.Contains("stderr")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::OpenRouter.AnthropicCodeExecutionToolResultError? anthropicCodeExecutionToolResultError = default;
            global::OpenRouter.AnthropicCodeExecutionResult? anthropicCodeExecutionResult = default;
            global::OpenRouter.AnthropicEncryptedCodeExecutionResult? anthropicEncryptedCodeExecutionResult = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCodeExecutionToolResultError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCodeExecutionToolResultError> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicCodeExecutionToolResultError).Name}");
                        anthropicCodeExecutionToolResultError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCodeExecutionResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCodeExecutionResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicCodeExecutionResult).Name}");
                        anthropicCodeExecutionResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicEncryptedCodeExecutionResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicEncryptedCodeExecutionResult> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicEncryptedCodeExecutionResult).Name}");
                        anthropicEncryptedCodeExecutionResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (anthropicCodeExecutionToolResultError == null && anthropicCodeExecutionResult == null && anthropicEncryptedCodeExecutionResult == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCodeExecutionToolResultError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCodeExecutionToolResultError> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicCodeExecutionToolResultError).Name}");
                    anthropicCodeExecutionToolResultError = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCodeExecutionResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCodeExecutionResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicCodeExecutionResult).Name}");
                    anthropicCodeExecutionResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicEncryptedCodeExecutionResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicEncryptedCodeExecutionResult> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicEncryptedCodeExecutionResult).Name}");
                    anthropicEncryptedCodeExecutionResult = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::OpenRouter.AnthropicCodeExecutionContent(
                anthropicCodeExecutionToolResultError,

                anthropicCodeExecutionResult,

                anthropicEncryptedCodeExecutionResult
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.AnthropicCodeExecutionContent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAnthropicCodeExecutionToolResultError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCodeExecutionToolResultError), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCodeExecutionToolResultError?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicCodeExecutionToolResultError).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnthropicCodeExecutionToolResultError!, typeInfo);
            }
            else if (value.IsAnthropicCodeExecutionResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCodeExecutionResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCodeExecutionResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicCodeExecutionResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnthropicCodeExecutionResult!, typeInfo);
            }
            else if (value.IsAnthropicEncryptedCodeExecutionResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicEncryptedCodeExecutionResult), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicEncryptedCodeExecutionResult?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicEncryptedCodeExecutionResult).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnthropicEncryptedCodeExecutionResult!, typeInfo);
            }
        }
    }
}