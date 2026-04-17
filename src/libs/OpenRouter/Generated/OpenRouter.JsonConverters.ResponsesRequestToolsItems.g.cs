#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class ResponsesRequestToolsItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.ResponsesRequestToolsItems>
    {
        /// <inheritdoc />
        public override global::OpenRouter.ResponsesRequestToolsItems Read(
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
            if (__jsonProps.Contains("description")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("parameters")) __score0++;
            if (__jsonProps.Contains("strict")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("engine")) __score1++;
            if (__jsonProps.Contains("filters")) __score1++;
            if (__jsonProps.Contains("filters.allowed_domains")) __score1++;
            if (__jsonProps.Contains("filters.excluded_domains")) __score1++;
            if (__jsonProps.Contains("max_results")) __score1++;
            if (__jsonProps.Contains("search_context_size")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("user_location")) __score1++;
            if (__jsonProps.Contains("user_location.city")) __score1++;
            if (__jsonProps.Contains("user_location.country")) __score1++;
            if (__jsonProps.Contains("user_location.region")) __score1++;
            if (__jsonProps.Contains("user_location.timezone")) __score1++;
            if (__jsonProps.Contains("user_location.type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("engine")) __score2++;
            if (__jsonProps.Contains("filters")) __score2++;
            if (__jsonProps.Contains("filters.allowed_domains")) __score2++;
            if (__jsonProps.Contains("filters.excluded_domains")) __score2++;
            if (__jsonProps.Contains("max_results")) __score2++;
            if (__jsonProps.Contains("search_context_size")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("user_location")) __score2++;
            if (__jsonProps.Contains("user_location.city")) __score2++;
            if (__jsonProps.Contains("user_location.country")) __score2++;
            if (__jsonProps.Contains("user_location.region")) __score2++;
            if (__jsonProps.Contains("user_location.timezone")) __score2++;
            if (__jsonProps.Contains("user_location.type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("engine")) __score3++;
            if (__jsonProps.Contains("filters")) __score3++;
            if (__jsonProps.Contains("filters.allowed_domains")) __score3++;
            if (__jsonProps.Contains("filters.excluded_domains")) __score3++;
            if (__jsonProps.Contains("max_results")) __score3++;
            if (__jsonProps.Contains("search_context_size")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("user_location")) __score3++;
            if (__jsonProps.Contains("user_location.city")) __score3++;
            if (__jsonProps.Contains("user_location.country")) __score3++;
            if (__jsonProps.Contains("user_location.region")) __score3++;
            if (__jsonProps.Contains("user_location.timezone")) __score3++;
            if (__jsonProps.Contains("user_location.type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("engine")) __score4++;
            if (__jsonProps.Contains("filters")) __score4++;
            if (__jsonProps.Contains("filters.allowed_domains")) __score4++;
            if (__jsonProps.Contains("filters.excluded_domains")) __score4++;
            if (__jsonProps.Contains("max_results")) __score4++;
            if (__jsonProps.Contains("search_context_size")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("user_location")) __score4++;
            if (__jsonProps.Contains("user_location.city")) __score4++;
            if (__jsonProps.Contains("user_location.country")) __score4++;
            if (__jsonProps.Contains("user_location.region")) __score4++;
            if (__jsonProps.Contains("user_location.timezone")) __score4++;
            if (__jsonProps.Contains("user_location.type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("filters")) __score5++;
            if (__jsonProps.Contains("max_num_results")) __score5++;
            if (__jsonProps.Contains("ranking_options")) __score5++;
            if (__jsonProps.Contains("ranking_options.ranker")) __score5++;
            if (__jsonProps.Contains("ranking_options.score_threshold")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            if (__jsonProps.Contains("vector_store_ids")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("display_height")) __score6++;
            if (__jsonProps.Contains("display_width")) __score6++;
            if (__jsonProps.Contains("environment")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("container")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("allowed_tools")) __score8++;
            if (__jsonProps.Contains("authorization")) __score8++;
            if (__jsonProps.Contains("connector_id")) __score8++;
            if (__jsonProps.Contains("headers")) __score8++;
            if (__jsonProps.Contains("require_approval")) __score8++;
            if (__jsonProps.Contains("server_description")) __score8++;
            if (__jsonProps.Contains("server_label")) __score8++;
            if (__jsonProps.Contains("server_url")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("background")) __score9++;
            if (__jsonProps.Contains("input_fidelity")) __score9++;
            if (__jsonProps.Contains("input_image_mask")) __score9++;
            if (__jsonProps.Contains("input_image_mask.file_id")) __score9++;
            if (__jsonProps.Contains("input_image_mask.image_url")) __score9++;
            if (__jsonProps.Contains("model")) __score9++;
            if (__jsonProps.Contains("moderation")) __score9++;
            if (__jsonProps.Contains("output_compression")) __score9++;
            if (__jsonProps.Contains("output_format")) __score9++;
            if (__jsonProps.Contains("partial_images")) __score9++;
            if (__jsonProps.Contains("quality")) __score9++;
            if (__jsonProps.Contains("size")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("type")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("description")) __score13++;
            if (__jsonProps.Contains("format")) __score13++;
            if (__jsonProps.Contains("name")) __score13++;
            if (__jsonProps.Contains("type")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("parameters")) __score14++;
            if (__jsonProps.Contains("parameters.timezone")) __score14++;
            if (__jsonProps.Contains("type")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("parameters")) __score15++;
            if (__jsonProps.Contains("parameters.model")) __score15++;
            if (__jsonProps.Contains("type")) __score15++;
            var __score16 = 0;
            if (__jsonProps.Contains("parameters")) __score16++;
            if (__jsonProps.Contains("parameters.max_results")) __score16++;
            if (__jsonProps.Contains("type")) __score16++;
            var __score17 = 0;
            if (__jsonProps.Contains("parameters")) __score17++;
            if (__jsonProps.Contains("parameters.max_results")) __score17++;
            if (__jsonProps.Contains("parameters.max_total_results")) __score17++;
            if (__jsonProps.Contains("type")) __score17++;
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

            global::OpenRouter.ResponsesRequestToolsItems0? responsesRequestToolsItems0 = default;
            global::OpenRouter.PreviewWebSearchServerTool? previewWebSearchServerTool = default;
            global::OpenRouter.Preview20250311WebSearchServerTool? preview20250311WebSearchServerTool = default;
            global::OpenRouter.LegacyWebSearchServerTool? legacyWebSearchServerTool = default;
            global::OpenRouter.WebSearchServerTool? webSearchServerTool = default;
            global::OpenRouter.FileSearchServerTool? fileSearchServerTool = default;
            global::OpenRouter.ComputerUseServerTool? computerUseServerTool = default;
            global::OpenRouter.CodeInterpreterServerTool? codeInterpreterServerTool = default;
            global::OpenRouter.McpServerTool? mcpServerTool = default;
            global::OpenRouter.ImageGenerationServerTool? imageGenerationServerTool = default;
            global::OpenRouter.CodexLocalShellTool? codexLocalShellTool = default;
            global::OpenRouter.ShellServerTool? shellServerTool = default;
            global::OpenRouter.ApplyPatchServerTool? applyPatchServerTool = default;
            global::OpenRouter.CustomTool? customTool = default;
            global::OpenRouter.DatetimeServerTool? datetimeServerTool = default;
            global::OpenRouter.ImageGenerationServerToolOpenRouter? imageGenerationServerToolOpenRouter = default;
            global::OpenRouter.ChatSearchModelsServerTool? chatSearchModelsServerTool = default;
            global::OpenRouter.WebSearchServerToolOpenRouter? webSearchServerToolOpenRouter = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponsesRequestToolsItems0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponsesRequestToolsItems0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ResponsesRequestToolsItems0).Name}");
                        responsesRequestToolsItems0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.PreviewWebSearchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.PreviewWebSearchServerTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.PreviewWebSearchServerTool).Name}");
                        previewWebSearchServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.Preview20250311WebSearchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.Preview20250311WebSearchServerTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.Preview20250311WebSearchServerTool).Name}");
                        preview20250311WebSearchServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.LegacyWebSearchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.LegacyWebSearchServerTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.LegacyWebSearchServerTool).Name}");
                        legacyWebSearchServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.WebSearchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.WebSearchServerTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.WebSearchServerTool).Name}");
                        webSearchServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FileSearchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FileSearchServerTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FileSearchServerTool).Name}");
                        fileSearchServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ComputerUseServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ComputerUseServerTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ComputerUseServerTool).Name}");
                        computerUseServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CodeInterpreterServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CodeInterpreterServerTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CodeInterpreterServerTool).Name}");
                        codeInterpreterServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.McpServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.McpServerTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.McpServerTool).Name}");
                        mcpServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ImageGenerationServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ImageGenerationServerTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ImageGenerationServerTool).Name}");
                        imageGenerationServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CodexLocalShellTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CodexLocalShellTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CodexLocalShellTool).Name}");
                        codexLocalShellTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ShellServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ShellServerTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ShellServerTool).Name}");
                        shellServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ApplyPatchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ApplyPatchServerTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ApplyPatchServerTool).Name}");
                        applyPatchServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CustomTool).Name}");
                        customTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DatetimeServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DatetimeServerTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.DatetimeServerTool).Name}");
                        datetimeServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ImageGenerationServerToolOpenRouter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ImageGenerationServerToolOpenRouter> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ImageGenerationServerToolOpenRouter).Name}");
                        imageGenerationServerToolOpenRouter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatSearchModelsServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatSearchModelsServerTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatSearchModelsServerTool).Name}");
                        chatSearchModelsServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.WebSearchServerToolOpenRouter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.WebSearchServerToolOpenRouter> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.WebSearchServerToolOpenRouter).Name}");
                        webSearchServerToolOpenRouter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (responsesRequestToolsItems0 == null && previewWebSearchServerTool == null && preview20250311WebSearchServerTool == null && legacyWebSearchServerTool == null && webSearchServerTool == null && fileSearchServerTool == null && computerUseServerTool == null && codeInterpreterServerTool == null && mcpServerTool == null && imageGenerationServerTool == null && codexLocalShellTool == null && shellServerTool == null && applyPatchServerTool == null && customTool == null && datetimeServerTool == null && imageGenerationServerToolOpenRouter == null && chatSearchModelsServerTool == null && webSearchServerToolOpenRouter == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponsesRequestToolsItems0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponsesRequestToolsItems0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ResponsesRequestToolsItems0).Name}");
                    responsesRequestToolsItems0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.PreviewWebSearchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.PreviewWebSearchServerTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.PreviewWebSearchServerTool).Name}");
                    previewWebSearchServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.Preview20250311WebSearchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.Preview20250311WebSearchServerTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.Preview20250311WebSearchServerTool).Name}");
                    preview20250311WebSearchServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.LegacyWebSearchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.LegacyWebSearchServerTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.LegacyWebSearchServerTool).Name}");
                    legacyWebSearchServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.WebSearchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.WebSearchServerTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.WebSearchServerTool).Name}");
                    webSearchServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FileSearchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FileSearchServerTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FileSearchServerTool).Name}");
                    fileSearchServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ComputerUseServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ComputerUseServerTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ComputerUseServerTool).Name}");
                    computerUseServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CodeInterpreterServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CodeInterpreterServerTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CodeInterpreterServerTool).Name}");
                    codeInterpreterServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.McpServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.McpServerTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.McpServerTool).Name}");
                    mcpServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ImageGenerationServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ImageGenerationServerTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ImageGenerationServerTool).Name}");
                    imageGenerationServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CodexLocalShellTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CodexLocalShellTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CodexLocalShellTool).Name}");
                    codexLocalShellTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ShellServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ShellServerTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ShellServerTool).Name}");
                    shellServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ApplyPatchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ApplyPatchServerTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ApplyPatchServerTool).Name}");
                    applyPatchServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CustomTool).Name}");
                    customTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DatetimeServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DatetimeServerTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.DatetimeServerTool).Name}");
                    datetimeServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ImageGenerationServerToolOpenRouter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ImageGenerationServerToolOpenRouter> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ImageGenerationServerToolOpenRouter).Name}");
                    imageGenerationServerToolOpenRouter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatSearchModelsServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatSearchModelsServerTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatSearchModelsServerTool).Name}");
                    chatSearchModelsServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.WebSearchServerToolOpenRouter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.WebSearchServerToolOpenRouter> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.WebSearchServerToolOpenRouter).Name}");
                    webSearchServerToolOpenRouter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::OpenRouter.ResponsesRequestToolsItems(
                responsesRequestToolsItems0,

                previewWebSearchServerTool,

                preview20250311WebSearchServerTool,

                legacyWebSearchServerTool,

                webSearchServerTool,

                fileSearchServerTool,

                computerUseServerTool,

                codeInterpreterServerTool,

                mcpServerTool,

                imageGenerationServerTool,

                codexLocalShellTool,

                shellServerTool,

                applyPatchServerTool,

                customTool,

                datetimeServerTool,

                imageGenerationServerToolOpenRouter,

                chatSearchModelsServerTool,

                webSearchServerToolOpenRouter
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.ResponsesRequestToolsItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsResponsesRequestToolsItems0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponsesRequestToolsItems0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponsesRequestToolsItems0?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ResponsesRequestToolsItems0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponsesRequestToolsItems0!, typeInfo);
            }
            else if (value.IsPreviewWebSearchServerTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.PreviewWebSearchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.PreviewWebSearchServerTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.PreviewWebSearchServerTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PreviewWebSearchServerTool!, typeInfo);
            }
            else if (value.IsPreview20250311WebSearchServerTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.Preview20250311WebSearchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.Preview20250311WebSearchServerTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.Preview20250311WebSearchServerTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Preview20250311WebSearchServerTool!, typeInfo);
            }
            else if (value.IsLegacyWebSearchServerTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.LegacyWebSearchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.LegacyWebSearchServerTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.LegacyWebSearchServerTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LegacyWebSearchServerTool!, typeInfo);
            }
            else if (value.IsWebSearchServerTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.WebSearchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.WebSearchServerTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.WebSearchServerTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchServerTool!, typeInfo);
            }
            else if (value.IsFileSearchServerTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FileSearchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FileSearchServerTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FileSearchServerTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchServerTool!, typeInfo);
            }
            else if (value.IsComputerUseServerTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ComputerUseServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ComputerUseServerTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ComputerUseServerTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerUseServerTool!, typeInfo);
            }
            else if (value.IsCodeInterpreterServerTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CodeInterpreterServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CodeInterpreterServerTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CodeInterpreterServerTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeInterpreterServerTool!, typeInfo);
            }
            else if (value.IsMcpServerTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.McpServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.McpServerTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.McpServerTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.McpServerTool!, typeInfo);
            }
            else if (value.IsImageGenerationServerTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ImageGenerationServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ImageGenerationServerTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ImageGenerationServerTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageGenerationServerTool!, typeInfo);
            }
            else if (value.IsCodexLocalShellTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CodexLocalShellTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CodexLocalShellTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CodexLocalShellTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodexLocalShellTool!, typeInfo);
            }
            else if (value.IsShellServerTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ShellServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ShellServerTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ShellServerTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ShellServerTool!, typeInfo);
            }
            else if (value.IsApplyPatchServerTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ApplyPatchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ApplyPatchServerTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ApplyPatchServerTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApplyPatchServerTool!, typeInfo);
            }
            else if (value.IsCustomTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CustomTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomTool!, typeInfo);
            }
            else if (value.IsDatetimeServerTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DatetimeServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DatetimeServerTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.DatetimeServerTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DatetimeServerTool!, typeInfo);
            }
            else if (value.IsImageGenerationServerToolOpenRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ImageGenerationServerToolOpenRouter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ImageGenerationServerToolOpenRouter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ImageGenerationServerToolOpenRouter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageGenerationServerToolOpenRouter!, typeInfo);
            }
            else if (value.IsChatSearchModelsServerTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatSearchModelsServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatSearchModelsServerTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatSearchModelsServerTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatSearchModelsServerTool!, typeInfo);
            }
            else if (value.IsWebSearchServerToolOpenRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.WebSearchServerToolOpenRouter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.WebSearchServerToolOpenRouter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.WebSearchServerToolOpenRouter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchServerToolOpenRouter!, typeInfo);
            }
        }
    }
}