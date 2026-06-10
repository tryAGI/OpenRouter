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
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

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
            if (__jsonProps.Contains("namespace")) __score3++;
            if (__jsonProps.Contains("status")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("call_id")) __score4++;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("output")) __score4++;
            if (__jsonProps.Contains("status")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("call_id")) __score5++;
            if (__jsonProps.Contains("id")) __score5++;
            if (__jsonProps.Contains("operation")) __score5++;
            if (__jsonProps.Contains("status")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("call_id")) __score6++;
            if (__jsonProps.Contains("id")) __score6++;
            if (__jsonProps.Contains("output")) __score6++;
            if (__jsonProps.Contains("status")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("content")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("content")) __score8++;
            if (__jsonProps.Contains("format")) __score8++;
            if (__jsonProps.Contains("signature")) __score8++;
            if (__jsonProps.Contains("summary")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("arguments")) __score9++;
            if (__jsonProps.Contains("call_id")) __score9++;
            if (__jsonProps.Contains("id")) __score9++;
            if (__jsonProps.Contains("name")) __score9++;
            if (__jsonProps.Contains("namespace")) __score9++;
            if (__jsonProps.Contains("status")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("call_id")) __score10++;
            if (__jsonProps.Contains("id")) __score10++;
            if (__jsonProps.Contains("input")) __score10++;
            if (__jsonProps.Contains("name")) __score10++;
            if (__jsonProps.Contains("namespace")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("action")) __score11++;
            if (__jsonProps.Contains("id")) __score11++;
            if (__jsonProps.Contains("status")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("id")) __score12++;
            if (__jsonProps.Contains("queries")) __score12++;
            if (__jsonProps.Contains("status")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("id")) __score13++;
            if (__jsonProps.Contains("result")) __score13++;
            if (__jsonProps.Contains("status")) __score13++;
            if (__jsonProps.Contains("type")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("code")) __score14++;
            if (__jsonProps.Contains("container_id")) __score14++;
            if (__jsonProps.Contains("id")) __score14++;
            if (__jsonProps.Contains("outputs")) __score14++;
            if (__jsonProps.Contains("status")) __score14++;
            if (__jsonProps.Contains("type")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("action")) __score15++;
            if (__jsonProps.Contains("call_id")) __score15++;
            if (__jsonProps.Contains("id")) __score15++;
            if (__jsonProps.Contains("pending_safety_checks")) __score15++;
            if (__jsonProps.Contains("status")) __score15++;
            var __score16 = 0;
            if (__jsonProps.Contains("datetime")) __score16++;
            if (__jsonProps.Contains("id")) __score16++;
            if (__jsonProps.Contains("status")) __score16++;
            if (__jsonProps.Contains("timezone")) __score16++;
            var __score17 = 0;
            if (__jsonProps.Contains("action")) __score17++;
            if (__jsonProps.Contains("action.query")) __score17++;
            if (__jsonProps.Contains("action.sources")) __score17++;
            if (__jsonProps.Contains("action.type")) __score17++;
            if (__jsonProps.Contains("id")) __score17++;
            if (__jsonProps.Contains("status")) __score17++;
            if (__jsonProps.Contains("type")) __score17++;
            var __score18 = 0;
            if (__jsonProps.Contains("code")) __score18++;
            if (__jsonProps.Contains("exitCode")) __score18++;
            if (__jsonProps.Contains("id")) __score18++;
            if (__jsonProps.Contains("language")) __score18++;
            if (__jsonProps.Contains("status")) __score18++;
            if (__jsonProps.Contains("stderr")) __score18++;
            if (__jsonProps.Contains("stdout")) __score18++;
            var __score19 = 0;
            if (__jsonProps.Contains("id")) __score19++;
            if (__jsonProps.Contains("queries")) __score19++;
            if (__jsonProps.Contains("status")) __score19++;
            var __score20 = 0;
            if (__jsonProps.Contains("id")) __score20++;
            if (__jsonProps.Contains("imageB64")) __score20++;
            if (__jsonProps.Contains("imageUrl")) __score20++;
            if (__jsonProps.Contains("result")) __score20++;
            if (__jsonProps.Contains("revisedPrompt")) __score20++;
            if (__jsonProps.Contains("status")) __score20++;
            var __score21 = 0;
            if (__jsonProps.Contains("action")) __score21++;
            if (__jsonProps.Contains("id")) __score21++;
            if (__jsonProps.Contains("screenshotB64")) __score21++;
            if (__jsonProps.Contains("status")) __score21++;
            var __score22 = 0;
            if (__jsonProps.Contains("command")) __score22++;
            if (__jsonProps.Contains("exitCode")) __score22++;
            if (__jsonProps.Contains("id")) __score22++;
            if (__jsonProps.Contains("status")) __score22++;
            if (__jsonProps.Contains("stderr")) __score22++;
            if (__jsonProps.Contains("stdout")) __score22++;
            var __score23 = 0;
            if (__jsonProps.Contains("command")) __score23++;
            if (__jsonProps.Contains("filePath")) __score23++;
            if (__jsonProps.Contains("id")) __score23++;
            if (__jsonProps.Contains("status")) __score23++;
            if (__jsonProps.Contains("type")) __score23++;
            var __score24 = 0;
            if (__jsonProps.Contains("call_id")) __score24++;
            if (__jsonProps.Contains("id")) __score24++;
            if (__jsonProps.Contains("operation")) __score24++;
            if (__jsonProps.Contains("status")) __score24++;
            var __score25 = 0;
            if (__jsonProps.Contains("content")) __score25++;
            if (__jsonProps.Contains("error")) __score25++;
            if (__jsonProps.Contains("httpStatus")) __score25++;
            if (__jsonProps.Contains("id")) __score25++;
            if (__jsonProps.Contains("status")) __score25++;
            if (__jsonProps.Contains("title")) __score25++;
            if (__jsonProps.Contains("type")) __score25++;
            if (__jsonProps.Contains("url")) __score25++;
            var __score26 = 0;
            if (__jsonProps.Contains("id")) __score26++;
            if (__jsonProps.Contains("query")) __score26++;
            if (__jsonProps.Contains("status")) __score26++;
            if (__jsonProps.Contains("type")) __score26++;
            var __score27 = 0;
            if (__jsonProps.Contains("action")) __score27++;
            if (__jsonProps.Contains("id")) __score27++;
            if (__jsonProps.Contains("key")) __score27++;
            if (__jsonProps.Contains("status")) __score27++;
            if (__jsonProps.Contains("type")) __score27++;
            if (__jsonProps.Contains("value")) __score27++;
            var __score28 = 0;
            if (__jsonProps.Contains("id")) __score28++;
            if (__jsonProps.Contains("serverLabel")) __score28++;
            if (__jsonProps.Contains("status")) __score28++;
            if (__jsonProps.Contains("toolName")) __score28++;
            if (__jsonProps.Contains("type")) __score28++;
            var __score29 = 0;
            if (__jsonProps.Contains("arguments")) __score29++;
            if (__jsonProps.Contains("id")) __score29++;
            if (__jsonProps.Contains("query")) __score29++;
            if (__jsonProps.Contains("status")) __score29++;
            if (__jsonProps.Contains("type")) __score29++;
            var __score30 = 0;
            if (__jsonProps.Contains("advice")) __score30++;
            if (__jsonProps.Contains("error")) __score30++;
            if (__jsonProps.Contains("id")) __score30++;
            if (__jsonProps.Contains("instance_name")) __score30++;
            if (__jsonProps.Contains("model")) __score30++;
            if (__jsonProps.Contains("prompt")) __score30++;
            if (__jsonProps.Contains("status")) __score30++;
            var __score31 = 0;
            if (__jsonProps.Contains("action")) __score31++;
            if (__jsonProps.Contains("action.command")) __score31++;
            if (__jsonProps.Contains("action.env")) __score31++;
            if (__jsonProps.Contains("action.timeout_ms")) __score31++;
            if (__jsonProps.Contains("action.type")) __score31++;
            if (__jsonProps.Contains("action.user")) __score31++;
            if (__jsonProps.Contains("action.working_directory")) __score31++;
            if (__jsonProps.Contains("call_id")) __score31++;
            if (__jsonProps.Contains("id")) __score31++;
            if (__jsonProps.Contains("status")) __score31++;
            if (__jsonProps.Contains("type")) __score31++;
            var __score32 = 0;
            if (__jsonProps.Contains("id")) __score32++;
            if (__jsonProps.Contains("output")) __score32++;
            if (__jsonProps.Contains("status")) __score32++;
            if (__jsonProps.Contains("type")) __score32++;
            var __score33 = 0;
            if (__jsonProps.Contains("action")) __score33++;
            if (__jsonProps.Contains("action.commands")) __score33++;
            if (__jsonProps.Contains("action.max_output_length")) __score33++;
            if (__jsonProps.Contains("action.timeout_ms")) __score33++;
            if (__jsonProps.Contains("call_id")) __score33++;
            if (__jsonProps.Contains("environment")) __score33++;
            if (__jsonProps.Contains("id")) __score33++;
            if (__jsonProps.Contains("status")) __score33++;
            if (__jsonProps.Contains("type")) __score33++;
            var __score34 = 0;
            if (__jsonProps.Contains("call_id")) __score34++;
            if (__jsonProps.Contains("id")) __score34++;
            if (__jsonProps.Contains("max_output_length")) __score34++;
            if (__jsonProps.Contains("output")) __score34++;
            if (__jsonProps.Contains("status")) __score34++;
            if (__jsonProps.Contains("type")) __score34++;
            var __score35 = 0;
            if (__jsonProps.Contains("error")) __score35++;
            if (__jsonProps.Contains("id")) __score35++;
            if (__jsonProps.Contains("server_label")) __score35++;
            if (__jsonProps.Contains("tools")) __score35++;
            if (__jsonProps.Contains("type")) __score35++;
            var __score36 = 0;
            if (__jsonProps.Contains("arguments")) __score36++;
            if (__jsonProps.Contains("id")) __score36++;
            if (__jsonProps.Contains("name")) __score36++;
            if (__jsonProps.Contains("server_label")) __score36++;
            if (__jsonProps.Contains("type")) __score36++;
            var __score37 = 0;
            if (__jsonProps.Contains("approval_request_id")) __score37++;
            if (__jsonProps.Contains("approve")) __score37++;
            if (__jsonProps.Contains("id")) __score37++;
            if (__jsonProps.Contains("reason")) __score37++;
            if (__jsonProps.Contains("type")) __score37++;
            var __score38 = 0;
            if (__jsonProps.Contains("arguments")) __score38++;
            if (__jsonProps.Contains("error")) __score38++;
            if (__jsonProps.Contains("id")) __score38++;
            if (__jsonProps.Contains("name")) __score38++;
            if (__jsonProps.Contains("output")) __score38++;
            if (__jsonProps.Contains("server_label")) __score38++;
            if (__jsonProps.Contains("type")) __score38++;
            var __score39 = 0;
            if (__jsonProps.Contains("call_id")) __score39++;
            if (__jsonProps.Contains("id")) __score39++;
            if (__jsonProps.Contains("input")) __score39++;
            if (__jsonProps.Contains("name")) __score39++;
            if (__jsonProps.Contains("namespace")) __score39++;
            if (__jsonProps.Contains("type")) __score39++;
            var __score40 = 0;
            if (__jsonProps.Contains("call_id")) __score40++;
            if (__jsonProps.Contains("id")) __score40++;
            if (__jsonProps.Contains("output")) __score40++;
            if (__jsonProps.Contains("type")) __score40++;
            var __score41 = 0;
            if (__jsonProps.Contains("encrypted_content")) __score41++;
            if (__jsonProps.Contains("id")) __score41++;
            if (__jsonProps.Contains("type")) __score41++;
            var __score42 = 0;
            if (__jsonProps.Contains("id")) __score42++;
            if (__jsonProps.Contains("type")) __score42++;
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
            if (__score27 > __bestScore) { __bestScore = __score27; __bestIndex = 27; }
            if (__score28 > __bestScore) { __bestScore = __score28; __bestIndex = 28; }
            if (__score29 > __bestScore) { __bestScore = __score29; __bestIndex = 29; }
            if (__score30 > __bestScore) { __bestScore = __score30; __bestIndex = 30; }
            if (__score31 > __bestScore) { __bestScore = __score31; __bestIndex = 31; }
            if (__score32 > __bestScore) { __bestScore = __score32; __bestIndex = 32; }
            if (__score33 > __bestScore) { __bestScore = __score33; __bestIndex = 33; }
            if (__score34 > __bestScore) { __bestScore = __score34; __bestIndex = 34; }
            if (__score35 > __bestScore) { __bestScore = __score35; __bestIndex = 35; }
            if (__score36 > __bestScore) { __bestScore = __score36; __bestIndex = 36; }
            if (__score37 > __bestScore) { __bestScore = __score37; __bestIndex = 37; }
            if (__score38 > __bestScore) { __bestScore = __score38; __bestIndex = 38; }
            if (__score39 > __bestScore) { __bestScore = __score39; __bestIndex = 39; }
            if (__score40 > __bestScore) { __bestScore = __score40; __bestIndex = 40; }
            if (__score41 > __bestScore) { __bestScore = __score41; __bestIndex = 41; }
            if (__score42 > __bestScore) { __bestScore = __score42; __bestIndex = 42; }

            global::OpenRouter.ReasoningItem? reasoningItem = default;
            global::OpenRouter.EasyInputMessage? easyInputMessage = default;
            global::OpenRouter.InputMessageItem? inputMessageItem = default;
            global::OpenRouter.FunctionCallItem? functionCallItem = default;
            global::OpenRouter.FunctionCallOutputItem? functionCallOutputItem = default;
            global::OpenRouter.ApplyPatchCallItem? applyPatchCallItem = default;
            global::OpenRouter.ApplyPatchCallOutputItem? applyPatchCallOutputItem = default;
            global::OpenRouter.InputsOneOf1Items7? inputsOneOf1Items7 = default;
            global::OpenRouter.InputsOneOf1Items8? inputsOneOf1Items8 = default;
            global::OpenRouter.OutputFunctionCallItem? outputFunctionCallItem = default;
            global::OpenRouter.OutputCustomToolCallItem? outputCustomToolCallItem = default;
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
            global::OpenRouter.OutputAdvisorServerToolItem? outputAdvisorServerToolItem = default;
            global::OpenRouter.LocalShellCallItem? localShellCallItem = default;
            global::OpenRouter.LocalShellCallOutputItem? localShellCallOutputItem = default;
            global::OpenRouter.ShellCallItem? shellCallItem = default;
            global::OpenRouter.ShellCallOutputItem? shellCallOutputItem = default;
            global::OpenRouter.McpListToolsItem? mcpListToolsItem = default;
            global::OpenRouter.McpApprovalRequestItem? mcpApprovalRequestItem = default;
            global::OpenRouter.McpApprovalResponseItem? mcpApprovalResponseItem = default;
            global::OpenRouter.McpCallItem? mcpCallItem = default;
            global::OpenRouter.CustomToolCallItem? customToolCallItem = default;
            global::OpenRouter.CustomToolCallOutputItem? customToolCallOutputItem = default;
            global::OpenRouter.CompactionItem? compactionItem = default;
            global::OpenRouter.ItemReferenceItem? itemReferenceItem = default;
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ApplyPatchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ApplyPatchCallItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ApplyPatchCallItem).Name}");
                        applyPatchCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ApplyPatchCallOutputItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ApplyPatchCallOutputItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ApplyPatchCallOutputItem).Name}");
                        applyPatchCallOutputItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InputsOneOf1Items7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InputsOneOf1Items7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.InputsOneOf1Items7).Name}");
                        inputsOneOf1Items7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InputsOneOf1Items8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InputsOneOf1Items8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.InputsOneOf1Items8).Name}");
                        inputsOneOf1Items8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                else if (__bestIndex == 10)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputCustomToolCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputCustomToolCallItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputCustomToolCallItem).Name}");
                        outputCustomToolCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                else if (__bestIndex == 12)
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
                else if (__bestIndex == 13)
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
                else if (__bestIndex == 14)
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
                else if (__bestIndex == 15)
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
                else if (__bestIndex == 16)
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
                else if (__bestIndex == 17)
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
                else if (__bestIndex == 18)
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
                else if (__bestIndex == 19)
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
                else if (__bestIndex == 20)
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
                else if (__bestIndex == 21)
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
                else if (__bestIndex == 22)
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
                else if (__bestIndex == 23)
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
                else if (__bestIndex == 24)
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
                else if (__bestIndex == 25)
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
                else if (__bestIndex == 26)
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
                else if (__bestIndex == 27)
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
                else if (__bestIndex == 28)
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
                else if (__bestIndex == 29)
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
                else if (__bestIndex == 30)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputAdvisorServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputAdvisorServerToolItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputAdvisorServerToolItem).Name}");
                        outputAdvisorServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 31)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.LocalShellCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.LocalShellCallItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.LocalShellCallItem).Name}");
                        localShellCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 32)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.LocalShellCallOutputItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.LocalShellCallOutputItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.LocalShellCallOutputItem).Name}");
                        localShellCallOutputItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 33)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ShellCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ShellCallItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ShellCallItem).Name}");
                        shellCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 34)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ShellCallOutputItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ShellCallOutputItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ShellCallOutputItem).Name}");
                        shellCallOutputItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 35)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.McpListToolsItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.McpListToolsItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.McpListToolsItem).Name}");
                        mcpListToolsItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 36)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.McpApprovalRequestItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.McpApprovalRequestItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.McpApprovalRequestItem).Name}");
                        mcpApprovalRequestItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 37)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.McpApprovalResponseItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.McpApprovalResponseItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.McpApprovalResponseItem).Name}");
                        mcpApprovalResponseItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 38)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.McpCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.McpCallItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.McpCallItem).Name}");
                        mcpCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 39)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomToolCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomToolCallItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CustomToolCallItem).Name}");
                        customToolCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 40)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomToolCallOutputItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomToolCallOutputItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CustomToolCallOutputItem).Name}");
                        customToolCallOutputItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 41)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CompactionItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CompactionItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CompactionItem).Name}");
                        compactionItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 42)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ItemReferenceItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ItemReferenceItem> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ItemReferenceItem).Name}");
                        itemReferenceItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
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

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
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

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
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

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
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

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
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

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ApplyPatchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ApplyPatchCallItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ApplyPatchCallItem).Name}");
                    applyPatchCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ApplyPatchCallOutputItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ApplyPatchCallOutputItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ApplyPatchCallOutputItem).Name}");
                    applyPatchCallOutputItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InputsOneOf1Items7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InputsOneOf1Items7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.InputsOneOf1Items7).Name}");
                    inputsOneOf1Items7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InputsOneOf1Items8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InputsOneOf1Items8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.InputsOneOf1Items8).Name}");
                    inputsOneOf1Items8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
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

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputCustomToolCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputCustomToolCallItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputCustomToolCallItem).Name}");
                    outputCustomToolCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
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

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
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

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
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

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
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

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
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

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
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

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
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

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
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

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
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

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
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

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
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

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
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

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
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

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
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

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
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

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
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

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
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

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
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

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
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

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputAdvisorServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputAdvisorServerToolItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputAdvisorServerToolItem).Name}");
                    outputAdvisorServerToolItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.LocalShellCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.LocalShellCallItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.LocalShellCallItem).Name}");
                    localShellCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.LocalShellCallOutputItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.LocalShellCallOutputItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.LocalShellCallOutputItem).Name}");
                    localShellCallOutputItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ShellCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ShellCallItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ShellCallItem).Name}");
                    shellCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ShellCallOutputItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ShellCallOutputItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ShellCallOutputItem).Name}");
                    shellCallOutputItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.McpListToolsItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.McpListToolsItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.McpListToolsItem).Name}");
                    mcpListToolsItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.McpApprovalRequestItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.McpApprovalRequestItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.McpApprovalRequestItem).Name}");
                    mcpApprovalRequestItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.McpApprovalResponseItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.McpApprovalResponseItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.McpApprovalResponseItem).Name}");
                    mcpApprovalResponseItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.McpCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.McpCallItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.McpCallItem).Name}");
                    mcpCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomToolCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomToolCallItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CustomToolCallItem).Name}");
                    customToolCallItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomToolCallOutputItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomToolCallOutputItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CustomToolCallOutputItem).Name}");
                    customToolCallOutputItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CompactionItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CompactionItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CompactionItem).Name}");
                    compactionItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (reasoningItem == null && easyInputMessage == null && inputMessageItem == null && functionCallItem == null && functionCallOutputItem == null && applyPatchCallItem == null && applyPatchCallOutputItem == null && inputsOneOf1Items7 == null && inputsOneOf1Items8 == null && outputFunctionCallItem == null && outputCustomToolCallItem == null && outputWebSearchCallItem == null && outputFileSearchCallItem == null && outputImageGenerationCallItem == null && outputCodeInterpreterCallItem == null && outputComputerCallItem == null && outputDatetimeItem == null && outputWebSearchServerToolItem == null && outputCodeInterpreterServerToolItem == null && outputFileSearchServerToolItem == null && outputImageGenerationServerToolItem == null && outputBrowserUseServerToolItem == null && outputBashServerToolItem == null && outputTextEditorServerToolItem == null && outputApplyPatchServerToolItem == null && outputWebFetchServerToolItem == null && outputToolSearchServerToolItem == null && outputMemoryServerToolItem == null && outputMcpServerToolItem == null && outputSearchModelsServerToolItem == null && outputAdvisorServerToolItem == null && localShellCallItem == null && localShellCallOutputItem == null && shellCallItem == null && shellCallOutputItem == null && mcpListToolsItem == null && mcpApprovalRequestItem == null && mcpApprovalResponseItem == null && mcpCallItem == null && customToolCallItem == null && customToolCallOutputItem == null && compactionItem == null && itemReferenceItem == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ItemReferenceItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ItemReferenceItem> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ItemReferenceItem).Name}");
                    itemReferenceItem = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                applyPatchCallItem,

                applyPatchCallOutputItem,

                inputsOneOf1Items7,

                inputsOneOf1Items8,

                outputFunctionCallItem,

                outputCustomToolCallItem,

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

                outputSearchModelsServerToolItem,

                outputAdvisorServerToolItem,

                localShellCallItem,

                localShellCallOutputItem,

                shellCallItem,

                shellCallOutputItem,

                mcpListToolsItem,

                mcpApprovalRequestItem,

                mcpApprovalResponseItem,

                mcpCallItem,

                customToolCallItem,

                customToolCallOutputItem,

                compactionItem,

                itemReferenceItem
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
            else if (value.IsApplyPatchCallItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ApplyPatchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ApplyPatchCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ApplyPatchCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApplyPatchCallItem!, typeInfo);
            }
            else if (value.IsApplyPatchCallOutputItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ApplyPatchCallOutputItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ApplyPatchCallOutputItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ApplyPatchCallOutputItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApplyPatchCallOutputItem!, typeInfo);
            }
            else if (value.IsInputsOneOf1Items7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InputsOneOf1Items7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InputsOneOf1Items7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.InputsOneOf1Items7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputsOneOf1Items7!, typeInfo);
            }
            else if (value.IsInputsOneOf1Items8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.InputsOneOf1Items8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.InputsOneOf1Items8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.InputsOneOf1Items8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputsOneOf1Items8!, typeInfo);
            }
            else if (value.IsOutputFunctionCallItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputFunctionCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputFunctionCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputFunctionCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputFunctionCallItem!, typeInfo);
            }
            else if (value.IsOutputCustomToolCallItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputCustomToolCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputCustomToolCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputCustomToolCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputCustomToolCallItem!, typeInfo);
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
            else if (value.IsOutputAdvisorServerToolItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputAdvisorServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputAdvisorServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputAdvisorServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputAdvisorServerToolItem!, typeInfo);
            }
            else if (value.IsLocalShellCallItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.LocalShellCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.LocalShellCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.LocalShellCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LocalShellCallItem!, typeInfo);
            }
            else if (value.IsLocalShellCallOutputItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.LocalShellCallOutputItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.LocalShellCallOutputItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.LocalShellCallOutputItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LocalShellCallOutputItem!, typeInfo);
            }
            else if (value.IsShellCallItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ShellCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ShellCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ShellCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ShellCallItem!, typeInfo);
            }
            else if (value.IsShellCallOutputItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ShellCallOutputItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ShellCallOutputItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ShellCallOutputItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ShellCallOutputItem!, typeInfo);
            }
            else if (value.IsMcpListToolsItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.McpListToolsItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.McpListToolsItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.McpListToolsItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpListToolsItem!, typeInfo);
            }
            else if (value.IsMcpApprovalRequestItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.McpApprovalRequestItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.McpApprovalRequestItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.McpApprovalRequestItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpApprovalRequestItem!, typeInfo);
            }
            else if (value.IsMcpApprovalResponseItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.McpApprovalResponseItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.McpApprovalResponseItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.McpApprovalResponseItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpApprovalResponseItem!, typeInfo);
            }
            else if (value.IsMcpCallItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.McpCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.McpCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.McpCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpCallItem!, typeInfo);
            }
            else if (value.IsCustomToolCallItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomToolCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomToolCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CustomToolCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomToolCallItem!, typeInfo);
            }
            else if (value.IsCustomToolCallOutputItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomToolCallOutputItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomToolCallOutputItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CustomToolCallOutputItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomToolCallOutputItem!, typeInfo);
            }
            else if (value.IsCompactionItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CompactionItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CompactionItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CompactionItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompactionItem!, typeInfo);
            }
            else if (value.IsItemReferenceItem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ItemReferenceItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ItemReferenceItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ItemReferenceItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ItemReferenceItem!, typeInfo);
            }
        }
    }
}