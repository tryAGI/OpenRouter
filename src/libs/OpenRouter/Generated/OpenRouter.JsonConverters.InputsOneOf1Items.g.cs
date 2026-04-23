#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class InputsOneOf1ItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.InputsOneOf1Items>
    {
        /// <inheritdoc />
        public override global::OpenRouter.InputsOneOf1Items Read(
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
            if (__jsonProps.Contains("encrypted_content")) __score0++;
            if (__jsonProps.Contains("format")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("signature")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("summary")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("phase")) __score1++;
            if (__jsonProps.Contains("role")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("content")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("role")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("arguments")) __score3++;
            if (__jsonProps.Contains("call_id")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("status")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("call_id")) __score4++;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("output")) __score4++;
            if (__jsonProps.Contains("status")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("content")) __score5++;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("phase")) __score5++;
            if (__jsonProps.Contains("role")) __score5++;
            if (__jsonProps.Contains("status")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("content")) __score6++;
            if (__jsonProps.Contains("encrypted_content")) __score6++;
            if (__jsonProps.Contains("format")) __score6++;
            if (__jsonProps.Contains("id")) __score6++;
            if (__jsonProps.Contains("signature")) __score6++;
            if (__jsonProps.Contains("status")) __score6++;
            if (__jsonProps.Contains("summary")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("arguments")) __score7++;
            if (__jsonProps.Contains("call_id")) __score7++;
            if (__jsonProps.Contains("id")) __score7++;
            if (__jsonProps.Contains("name")) __score7++;
            if (__jsonProps.Contains("status")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("action")) __score8++;
            if (__jsonProps.Contains("id")) __score8++;
            if (__jsonProps.Contains("status")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("id")) __score9++;
            if (__jsonProps.Contains("queries")) __score9++;
            if (__jsonProps.Contains("status")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("id")) __score10++;
            if (__jsonProps.Contains("result")) __score10++;
            if (__jsonProps.Contains("status")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("code")) __score11++;
            if (__jsonProps.Contains("container_id")) __score11++;
            if (__jsonProps.Contains("id")) __score11++;
            if (__jsonProps.Contains("outputs")) __score11++;
            if (__jsonProps.Contains("status")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("action")) __score12++;
            if (__jsonProps.Contains("call_id")) __score12++;
            if (__jsonProps.Contains("id")) __score12++;
            if (__jsonProps.Contains("pending_safety_checks")) __score12++;
            if (__jsonProps.Contains("status")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("datetime")) __score13++;
            if (__jsonProps.Contains("id")) __score13++;
            if (__jsonProps.Contains("status")) __score13++;
            if (__jsonProps.Contains("timezone")) __score13++;
            if (__jsonProps.Contains("type")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("id")) __score14++;
            if (__jsonProps.Contains("status")) __score14++;
            if (__jsonProps.Contains("type")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("code")) __score15++;
            if (__jsonProps.Contains("exitCode")) __score15++;
            if (__jsonProps.Contains("id")) __score15++;
            if (__jsonProps.Contains("language")) __score15++;
            if (__jsonProps.Contains("status")) __score15++;
            if (__jsonProps.Contains("stderr")) __score15++;
            if (__jsonProps.Contains("stdout")) __score15++;
            if (__jsonProps.Contains("type")) __score15++;
            var __score16 = 0;
            if (__jsonProps.Contains("id")) __score16++;
            if (__jsonProps.Contains("queries")) __score16++;
            if (__jsonProps.Contains("status")) __score16++;
            if (__jsonProps.Contains("type")) __score16++;
            var __score17 = 0;
            if (__jsonProps.Contains("id")) __score17++;
            if (__jsonProps.Contains("imageB64")) __score17++;
            if (__jsonProps.Contains("imageUrl")) __score17++;
            if (__jsonProps.Contains("result")) __score17++;
            if (__jsonProps.Contains("revisedPrompt")) __score17++;
            if (__jsonProps.Contains("status")) __score17++;
            if (__jsonProps.Contains("type")) __score17++;
            var __score18 = 0;
            if (__jsonProps.Contains("action")) __score18++;
            if (__jsonProps.Contains("id")) __score18++;
            if (__jsonProps.Contains("screenshotB64")) __score18++;
            if (__jsonProps.Contains("status")) __score18++;
            if (__jsonProps.Contains("type")) __score18++;
            var __score19 = 0;
            if (__jsonProps.Contains("command")) __score19++;
            if (__jsonProps.Contains("exitCode")) __score19++;
            if (__jsonProps.Contains("id")) __score19++;
            if (__jsonProps.Contains("status")) __score19++;
            if (__jsonProps.Contains("stderr")) __score19++;
            if (__jsonProps.Contains("stdout")) __score19++;
            if (__jsonProps.Contains("type")) __score19++;
            var __score20 = 0;
            if (__jsonProps.Contains("command")) __score20++;
            if (__jsonProps.Contains("filePath")) __score20++;
            if (__jsonProps.Contains("id")) __score20++;
            if (__jsonProps.Contains("status")) __score20++;
            if (__jsonProps.Contains("type")) __score20++;
            var __score21 = 0;
            if (__jsonProps.Contains("filePath")) __score21++;
            if (__jsonProps.Contains("id")) __score21++;
            if (__jsonProps.Contains("patch")) __score21++;
            if (__jsonProps.Contains("status")) __score21++;
            if (__jsonProps.Contains("type")) __score21++;
            var __score22 = 0;
            if (__jsonProps.Contains("content")) __score22++;
            if (__jsonProps.Contains("id")) __score22++;
            if (__jsonProps.Contains("status")) __score22++;
            if (__jsonProps.Contains("title")) __score22++;
            if (__jsonProps.Contains("type")) __score22++;
            if (__jsonProps.Contains("url")) __score22++;
            var __score23 = 0;
            if (__jsonProps.Contains("id")) __score23++;
            if (__jsonProps.Contains("query")) __score23++;
            if (__jsonProps.Contains("status")) __score23++;
            if (__jsonProps.Contains("type")) __score23++;
            var __score24 = 0;
            if (__jsonProps.Contains("action")) __score24++;
            if (__jsonProps.Contains("id")) __score24++;
            if (__jsonProps.Contains("key")) __score24++;
            if (__jsonProps.Contains("status")) __score24++;
            if (__jsonProps.Contains("type")) __score24++;
            if (__jsonProps.Contains("value")) __score24++;
            var __score25 = 0;
            if (__jsonProps.Contains("id")) __score25++;
            if (__jsonProps.Contains("serverLabel")) __score25++;
            if (__jsonProps.Contains("status")) __score25++;
            if (__jsonProps.Contains("toolName")) __score25++;
            if (__jsonProps.Contains("type")) __score25++;
            var __score26 = 0;
            if (__jsonProps.Contains("arguments")) __score26++;
            if (__jsonProps.Contains("id")) __score26++;
            if (__jsonProps.Contains("query")) __score26++;
            if (__jsonProps.Contains("status")) __score26++;
            if (__jsonProps.Contains("type")) __score26++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }
            if (__score13 > __bestScore) { __bestScore = __score13; __bestIndex = 13; }
            if (__score14 > __bestScore) { __bestScore = __score14; __bestIndex = 14; }
            if (__score15 > __bestScore) { __bestScore = __score15; __bestIndex = 15; }
            if (__score16 > __bestScore) { __bestScore = __score16; __bestIndex = 16; }
            if (__score17 > __bestScore) { __bestScore = __score17; __bestIndex = 17; }
            if (__score18 > __bestScore) { __bestScore = __score18; __bestIndex = 18; }
            if (__score19 > __bestScore) { __bestScore = __score19; __bestIndex = 19; }
            if (__score20 > __bestScore) { __bestScore = __score20; __bestIndex = 20; }
            if (__score21 > __bestScore) { __bestScore = __score21; __bestIndex = 21; }
            if (__score22 > __bestScore) { __bestScore = __score22; __bestIndex = 22; }
            if (__score23 > __bestScore) { __bestScore = __score23; __bestIndex = 23; }
            if (__score24 > __bestScore) { __bestScore = __score24; __bestIndex = 24; }
            if (__score25 > __bestScore) { __bestScore = __score25; __bestIndex = 25; }
            if (__score26 > __bestScore) { __bestScore = __score26; __bestIndex = 26; }

            global::OpenRouter.ReasoningItem? reasoningItem = default;
            global::OpenRouter.EasyInputMessage? easyInputMessage = default;
            global::OpenRouter.InputMessageItem? inputMessageItem = default;
            global::OpenRouter.FunctionCallItem? functionCallItem = default;
            global::OpenRouter.FunctionCallOutputItem? functionCallOutputItem = default;
            global::OpenRouter.InputsOneOf1Items5? inputsOneOf1Items5 = default;
            global::OpenRouter.InputsOneOf1Items6? inputsOneOf1Items6 = default;
            global::OpenRouter.OutputFunctionCallItem? outputFunctionCallItem = default;
            global::OpenRouter.OutputWebSearchCallItem? outputWebSearchCallItem = default;
            global::OpenRouter.OutputFileSearchCallItem? outputFileSearchCallItem = default;
            global::OpenRouter.OutputImageGenerationCallItem? outputImageGenerationCallItem = default;
            global::OpenRouter.OutputCodeInterpreterCallItem? outputCodeInterpreterCallItem = default;
            global::OpenRouter.OutputComputerCallItem? outputComputerCallItem = default;
            global::OpenRouter.OutputDatetimeItem? outputDatetimeItem = default;
            global::OpenRouter.OutputWebSearchServerToolItem? outputWebSearchServerToolItem = default;
            global::OpenRouter.OutputCodeInterpreterServerToolItem? outputCodeInterpreterServerToolItem = default;
            global::OpenRouter.OutputFileSearchServerToolItem? outputFileSearchServerToolItem = default;
            global::OpenRouter.OutputImageGenerationServerToolItem? outputImageGenerationServerToolItem = default;
            global::OpenRouter.OutputBrowserUseServerToolItem? outputBrowserUseServerToolItem = default;
            global::OpenRouter.OutputBashServerToolItem? outputBashServerToolItem = default;
            global::OpenRouter.OutputTextEditorServerToolItem? outputTextEditorServerToolItem = default;
            global::OpenRouter.OutputApplyPatchServerToolItem? outputApplyPatchServerToolItem = default;
            global::OpenRouter.OutputWebFetchServerToolItem? outputWebFetchServerToolItem = default;
            global::OpenRouter.OutputToolSearchServerToolItem? outputToolSearchServerToolItem = default;
            global::OpenRouter.OutputMemoryServerToolItem? outputMemoryServerToolItem = default;
            global::OpenRouter.OutputMcpServerToolItem? outputMcpServerToolItem = default;
            global::OpenRouter.OutputSearchModelsServerToolItem? outputSearchModelsServerToolItem = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ReasoningItem).Name}");
                        reasoningItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.EasyInputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.EasyInputMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.EasyInputMessage).Name}");
                        easyInputMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InputMessageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InputMessageItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.InputMessageItem).Name}");
                        inputMessageItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FunctionCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FunctionCallItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FunctionCallItem).Name}");
                        functionCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FunctionCallOutputItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FunctionCallOutputItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FunctionCallOutputItem).Name}");
                        functionCallOutputItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InputsOneOf1Items5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InputsOneOf1Items5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.InputsOneOf1Items5).Name}");
                        inputsOneOf1Items5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InputsOneOf1Items6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InputsOneOf1Items6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.InputsOneOf1Items6).Name}");
                        inputsOneOf1Items6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputFunctionCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputFunctionCallItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputFunctionCallItem).Name}");
                        outputFunctionCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputWebSearchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputWebSearchCallItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputWebSearchCallItem).Name}");
                        outputWebSearchCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputFileSearchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputFileSearchCallItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputFileSearchCallItem).Name}");
                        outputFileSearchCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputImageGenerationCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputImageGenerationCallItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputImageGenerationCallItem).Name}");
                        outputImageGenerationCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 11)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputCodeInterpreterCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputCodeInterpreterCallItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputCodeInterpreterCallItem).Name}");
                        outputCodeInterpreterCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 12)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputComputerCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputComputerCallItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputComputerCallItem).Name}");
                        outputComputerCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 13)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputDatetimeItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputDatetimeItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputDatetimeItem).Name}");
                        outputDatetimeItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 14)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputWebSearchServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputWebSearchServerToolItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputWebSearchServerToolItem).Name}");
                        outputWebSearchServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 15)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputCodeInterpreterServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputCodeInterpreterServerToolItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputCodeInterpreterServerToolItem).Name}");
                        outputCodeInterpreterServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 16)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputFileSearchServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputFileSearchServerToolItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputFileSearchServerToolItem).Name}");
                        outputFileSearchServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 17)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputImageGenerationServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputImageGenerationServerToolItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputImageGenerationServerToolItem).Name}");
                        outputImageGenerationServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 18)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputBrowserUseServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputBrowserUseServerToolItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputBrowserUseServerToolItem).Name}");
                        outputBrowserUseServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 19)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputBashServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputBashServerToolItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputBashServerToolItem).Name}");
                        outputBashServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 20)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputTextEditorServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputTextEditorServerToolItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputTextEditorServerToolItem).Name}");
                        outputTextEditorServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 21)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputApplyPatchServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputApplyPatchServerToolItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputApplyPatchServerToolItem).Name}");
                        outputApplyPatchServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 22)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputWebFetchServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputWebFetchServerToolItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputWebFetchServerToolItem).Name}");
                        outputWebFetchServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 23)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputToolSearchServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputToolSearchServerToolItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputToolSearchServerToolItem).Name}");
                        outputToolSearchServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 24)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputMemoryServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputMemoryServerToolItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputMemoryServerToolItem).Name}");
                        outputMemoryServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 25)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputMcpServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputMcpServerToolItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputMcpServerToolItem).Name}");
                        outputMcpServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 26)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputSearchModelsServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputSearchModelsServerToolItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputSearchModelsServerToolItem).Name}");
                        outputSearchModelsServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && inputsOneOf1Items5 == null && inputsOneOf1Items6 == null && outputFunctionCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ReasoningItem).Name}");
                    reasoningItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.EasyInputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.EasyInputMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.EasyInputMessage).Name}");
                    easyInputMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InputMessageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InputMessageItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.InputMessageItem).Name}");
                    inputMessageItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FunctionCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FunctionCallItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FunctionCallItem).Name}");
                    functionCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FunctionCallOutputItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FunctionCallOutputItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FunctionCallOutputItem).Name}");
                    functionCallOutputItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InputsOneOf1Items5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InputsOneOf1Items5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.InputsOneOf1Items5).Name}");
                    inputsOneOf1Items5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InputsOneOf1Items6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InputsOneOf1Items6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.InputsOneOf1Items6).Name}");
                    inputsOneOf1Items6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputFunctionCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputFunctionCallItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputFunctionCallItem).Name}");
                    outputFunctionCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputWebSearchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputWebSearchCallItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputWebSearchCallItem).Name}");
                    outputWebSearchCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputFileSearchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputFileSearchCallItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputFileSearchCallItem).Name}");
                    outputFileSearchCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputImageGenerationCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputImageGenerationCallItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputImageGenerationCallItem).Name}");
                    outputImageGenerationCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputCodeInterpreterCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputCodeInterpreterCallItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputCodeInterpreterCallItem).Name}");
                    outputCodeInterpreterCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputComputerCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputComputerCallItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputComputerCallItem).Name}");
                    outputComputerCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputDatetimeItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputDatetimeItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputDatetimeItem).Name}");
                    outputDatetimeItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputWebSearchServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputWebSearchServerToolItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputWebSearchServerToolItem).Name}");
                    outputWebSearchServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputCodeInterpreterServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputCodeInterpreterServerToolItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputCodeInterpreterServerToolItem).Name}");
                    outputCodeInterpreterServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputFileSearchServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputFileSearchServerToolItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputFileSearchServerToolItem).Name}");
                    outputFileSearchServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputImageGenerationServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputImageGenerationServerToolItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputImageGenerationServerToolItem).Name}");
                    outputImageGenerationServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputBrowserUseServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputBrowserUseServerToolItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputBrowserUseServerToolItem).Name}");
                    outputBrowserUseServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputBashServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputBashServerToolItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputBashServerToolItem).Name}");
                    outputBashServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputTextEditorServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputTextEditorServerToolItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputTextEditorServerToolItem).Name}");
                    outputTextEditorServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputApplyPatchServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputApplyPatchServerToolItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputApplyPatchServerToolItem).Name}");
                    outputApplyPatchServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputWebFetchServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputWebFetchServerToolItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputWebFetchServerToolItem).Name}");
                    outputWebFetchServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputToolSearchServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputToolSearchServerToolItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputToolSearchServerToolItem).Name}");
                    outputToolSearchServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputMemoryServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputMemoryServerToolItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputMemoryServerToolItem).Name}");
                    outputMemoryServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputMcpServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputMcpServerToolItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputMcpServerToolItem).Name}");
                    outputMcpServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputSearchModelsServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputSearchModelsServerToolItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputSearchModelsServerToolItem).Name}");
                    outputSearchModelsServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::OpenRouter.InputsOneOf1Items(
                reasoningItem,

                easyInputMessage,

                inputMessageItem,

                functionCallItem,

                functionCallOutputItem,

                inputsOneOf1Items5,

                inputsOneOf1Items6,

                outputFunctionCallItem,

                outputWebSearchCallItem,

                outputFileSearchCallItem,

                outputImageGenerationCallItem,

                outputCodeInterpreterCallItem,

                outputComputerCallItem,

                outputDatetimeItem,

                outputWebSearchServerToolItem,

                outputCodeInterpreterServerToolItem,

                outputFileSearchServerToolItem,

                outputImageGenerationServerToolItem,

                outputBrowserUseServerToolItem,

                outputBashServerToolItem,

                outputTextEditorServerToolItem,

                outputApplyPatchServerToolItem,

                outputWebFetchServerToolItem,

                outputToolSearchServerToolItem,

                outputMemoryServerToolItem,

                outputMcpServerToolItem,

                outputSearchModelsServerToolItem
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.InputsOneOf1Items value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsReasoningItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ReasoningItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ReasoningItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningItem!, typeInfo);
            }
            else if (value.IsEasyInputMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.EasyInputMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.EasyInputMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.EasyInputMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EasyInputMessage!, typeInfo);
            }
            else if (value.IsInputMessageItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InputMessageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InputMessageItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.InputMessageItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputMessageItem!, typeInfo);
            }
            else if (value.IsFunctionCallItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FunctionCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FunctionCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FunctionCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallItem!, typeInfo);
            }
            else if (value.IsFunctionCallOutputItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FunctionCallOutputItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FunctionCallOutputItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FunctionCallOutputItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCallOutputItem!, typeInfo);
            }
            else if (value.IsInputsOneOf1Items5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InputsOneOf1Items5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InputsOneOf1Items5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.InputsOneOf1Items5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputsOneOf1Items5!, typeInfo);
            }
            else if (value.IsInputsOneOf1Items6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InputsOneOf1Items6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InputsOneOf1Items6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.InputsOneOf1Items6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputsOneOf1Items6!, typeInfo);
            }
            else if (value.IsOutputFunctionCallItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputFunctionCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputFunctionCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputFunctionCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputFunctionCallItem!, typeInfo);
            }
            else if (value.IsOutputWebSearchCallItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputWebSearchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputWebSearchCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputWebSearchCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputWebSearchCallItem!, typeInfo);
            }
            else if (value.IsOutputFileSearchCallItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputFileSearchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputFileSearchCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputFileSearchCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputFileSearchCallItem!, typeInfo);
            }
            else if (value.IsOutputImageGenerationCallItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputImageGenerationCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputImageGenerationCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputImageGenerationCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputImageGenerationCallItem!, typeInfo);
            }
            else if (value.IsOutputCodeInterpreterCallItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputCodeInterpreterCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputCodeInterpreterCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputCodeInterpreterCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputCodeInterpreterCallItem!, typeInfo);
            }
            else if (value.IsOutputComputerCallItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputComputerCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputComputerCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputComputerCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputComputerCallItem!, typeInfo);
            }
            else if (value.IsOutputDatetimeItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputDatetimeItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputDatetimeItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputDatetimeItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputDatetimeItem!, typeInfo);
            }
            else if (value.IsOutputWebSearchServerToolItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputWebSearchServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputWebSearchServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputWebSearchServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputWebSearchServerToolItem!, typeInfo);
            }
            else if (value.IsOutputCodeInterpreterServerToolItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputCodeInterpreterServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputCodeInterpreterServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputCodeInterpreterServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputCodeInterpreterServerToolItem!, typeInfo);
            }
            else if (value.IsOutputFileSearchServerToolItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputFileSearchServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputFileSearchServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputFileSearchServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputFileSearchServerToolItem!, typeInfo);
            }
            else if (value.IsOutputImageGenerationServerToolItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputImageGenerationServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputImageGenerationServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputImageGenerationServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputImageGenerationServerToolItem!, typeInfo);
            }
            else if (value.IsOutputBrowserUseServerToolItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputBrowserUseServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputBrowserUseServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputBrowserUseServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputBrowserUseServerToolItem!, typeInfo);
            }
            else if (value.IsOutputBashServerToolItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputBashServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputBashServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputBashServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputBashServerToolItem!, typeInfo);
            }
            else if (value.IsOutputTextEditorServerToolItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputTextEditorServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputTextEditorServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputTextEditorServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputTextEditorServerToolItem!, typeInfo);
            }
            else if (value.IsOutputApplyPatchServerToolItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputApplyPatchServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputApplyPatchServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputApplyPatchServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputApplyPatchServerToolItem!, typeInfo);
            }
            else if (value.IsOutputWebFetchServerToolItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputWebFetchServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputWebFetchServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputWebFetchServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputWebFetchServerToolItem!, typeInfo);
            }
            else if (value.IsOutputToolSearchServerToolItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputToolSearchServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputToolSearchServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputToolSearchServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputToolSearchServerToolItem!, typeInfo);
            }
            else if (value.IsOutputMemoryServerToolItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputMemoryServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputMemoryServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputMemoryServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputMemoryServerToolItem!, typeInfo);
            }
            else if (value.IsOutputMcpServerToolItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputMcpServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputMcpServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputMcpServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputMcpServerToolItem!, typeInfo);
            }
            else if (value.IsOutputSearchModelsServerToolItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputSearchModelsServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputSearchModelsServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputSearchModelsServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputSearchModelsServerToolItem!, typeInfo);
            }
        }
    }
}