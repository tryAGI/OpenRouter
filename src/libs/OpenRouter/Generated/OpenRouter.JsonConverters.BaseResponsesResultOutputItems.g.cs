#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class BaseResponsesResultOutputItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.BaseResponsesResultOutputItems>
    {
        /// <inheritdoc />
        public override global::OpenRouter.BaseResponsesResultOutputItems Read(
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
            if (__jsonProps.Contains("content")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("phase")) __score0++;
            if (__jsonProps.Contains("role")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("encrypted_content")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            if (__jsonProps.Contains("summary")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("arguments")) __score2++;
            if (__jsonProps.Contains("call_id")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("status")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("action")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("status")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("queries")) __score4++;
            if (__jsonProps.Contains("status")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("result")) __score5++;
            if (__jsonProps.Contains("status")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::OpenRouter.OutputMessage? outputMessage = default;
            global::OpenRouter.OutputItemReasoning? outputItemReasoning = default;
            global::OpenRouter.OutputItemFunctionCall? outputItemFunctionCall = default;
            global::OpenRouter.OutputItemWebSearchCall? outputItemWebSearchCall = default;
            global::OpenRouter.OutputItemFileSearchCall? outputItemFileSearchCall = default;
            global::OpenRouter.OutputItemImageGenerationCall? outputItemImageGenerationCall = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputMessage).Name}");
                        outputMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemReasoning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemReasoning> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemReasoning).Name}");
                        outputItemReasoning = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemFunctionCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemFunctionCall> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemFunctionCall).Name}");
                        outputItemFunctionCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemWebSearchCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemWebSearchCall> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemWebSearchCall).Name}");
                        outputItemWebSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemFileSearchCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemFileSearchCall> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemFileSearchCall).Name}");
                        outputItemFileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemImageGenerationCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemImageGenerationCall> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemImageGenerationCall).Name}");
                        outputItemImageGenerationCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (outputMessage == null && outputItemReasoning == null && outputItemFunctionCall == null && outputItemWebSearchCall == null && outputItemFileSearchCall == null && outputItemImageGenerationCall == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputMessage).Name}");
                    outputMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemReasoning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemReasoning> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemReasoning).Name}");
                    outputItemReasoning = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemFunctionCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemFunctionCall> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemFunctionCall).Name}");
                    outputItemFunctionCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemWebSearchCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemWebSearchCall> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemWebSearchCall).Name}");
                    outputItemWebSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemFileSearchCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemFileSearchCall> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemFileSearchCall).Name}");
                    outputItemFileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemImageGenerationCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemImageGenerationCall> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemImageGenerationCall).Name}");
                    outputItemImageGenerationCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::OpenRouter.BaseResponsesResultOutputItems(
                outputMessage,

                outputItemReasoning,

                outputItemFunctionCall,

                outputItemWebSearchCall,

                outputItemFileSearchCall,

                outputItemImageGenerationCall
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.BaseResponsesResultOutputItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOutputMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputMessage, typeInfo);
            }
            else if (value.IsOutputItemReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemReasoning), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemReasoning?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemReasoning).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemReasoning, typeInfo);
            }
            else if (value.IsOutputItemFunctionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemFunctionCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemFunctionCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemFunctionCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemFunctionCall, typeInfo);
            }
            else if (value.IsOutputItemWebSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemWebSearchCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemWebSearchCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemWebSearchCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemWebSearchCall, typeInfo);
            }
            else if (value.IsOutputItemFileSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemFileSearchCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemFileSearchCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemFileSearchCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemFileSearchCall, typeInfo);
            }
            else if (value.IsOutputItemImageGenerationCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemImageGenerationCall), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemImageGenerationCall?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemImageGenerationCall).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemImageGenerationCall, typeInfo);
            }
        }
    }
}