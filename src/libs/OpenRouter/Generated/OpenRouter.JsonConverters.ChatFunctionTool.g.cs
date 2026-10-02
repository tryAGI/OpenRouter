#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class ChatFunctionToolJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.ChatFunctionTool>
    {
        /// <inheritdoc />
        public override global::OpenRouter.ChatFunctionTool Read(
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
            if (__jsonProps.Contains("cache_control")) __score0++;
            if (__jsonProps.Contains("function")) __score0++;
            if (__jsonProps.Contains("function.description")) __score0++;
            if (__jsonProps.Contains("function.name")) __score0++;
            if (__jsonProps.Contains("function.parameters")) __score0++;
            if (__jsonProps.Contains("function.strict")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("parameters")) __score1++;
            if (__jsonProps.Contains("parameters.forward_transcript")) __score1++;
            if (__jsonProps.Contains("parameters.instructions")) __score1++;
            if (__jsonProps.Contains("parameters.max_completion_tokens")) __score1++;
            if (__jsonProps.Contains("parameters.model")) __score1++;
            if (__jsonProps.Contains("parameters.name")) __score1++;
            if (__jsonProps.Contains("parameters.reasoning")) __score1++;
            if (__jsonProps.Contains("parameters.stream")) __score1++;
            if (__jsonProps.Contains("parameters.temperature")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("parameters")) __score2++;
            if (__jsonProps.Contains("parameters.engine")) __score2++;
            if (__jsonProps.Contains("parameters.environment")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("parameters")) __score3++;
            if (__jsonProps.Contains("parameters.timezone")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("parameters")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("parameters")) __score5++;
            if (__jsonProps.Contains("parameters.analysis_models")) __score5++;
            if (__jsonProps.Contains("parameters.cache_control")) __score5++;
            if (__jsonProps.Contains("parameters.max_completion_tokens")) __score5++;
            if (__jsonProps.Contains("parameters.max_tool_calls")) __score5++;
            if (__jsonProps.Contains("parameters.model")) __score5++;
            if (__jsonProps.Contains("parameters.reasoning")) __score5++;
            if (__jsonProps.Contains("parameters.temperature")) __score5++;
            if (__jsonProps.Contains("parameters.tools")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("parameters")) __score6++;
            if (__jsonProps.Contains("parameters.model")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("parameters")) __score7++;
            if (__jsonProps.Contains("parameters.max_results")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("parameters")) __score8++;
            if (__jsonProps.Contains("parameters.inherit_functions")) __score8++;
            if (__jsonProps.Contains("parameters.inherited_function_names")) __score8++;
            if (__jsonProps.Contains("parameters.instructions")) __score8++;
            if (__jsonProps.Contains("parameters.max_completion_tokens")) __score8++;
            if (__jsonProps.Contains("parameters.max_tool_calls")) __score8++;
            if (__jsonProps.Contains("parameters.model")) __score8++;
            if (__jsonProps.Contains("parameters.name")) __score8++;
            if (__jsonProps.Contains("parameters.reasoning")) __score8++;
            if (__jsonProps.Contains("parameters.temperature")) __score8++;
            if (__jsonProps.Contains("parameters.tools")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("parameters")) __score9++;
            if (__jsonProps.Contains("parameters.allowed_domains")) __score9++;
            if (__jsonProps.Contains("parameters.blocked_domains")) __score9++;
            if (__jsonProps.Contains("parameters.engine")) __score9++;
            if (__jsonProps.Contains("parameters.max_content_tokens")) __score9++;
            if (__jsonProps.Contains("parameters.max_uses")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("parameters")) __score10++;
            if (__jsonProps.Contains("parameters.allowed_domains")) __score10++;
            if (__jsonProps.Contains("parameters.engine")) __score10++;
            if (__jsonProps.Contains("parameters.excluded_domains")) __score10++;
            if (__jsonProps.Contains("parameters.max_characters")) __score10++;
            if (__jsonProps.Contains("parameters.max_results")) __score10++;
            if (__jsonProps.Contains("parameters.max_total_results")) __score10++;
            if (__jsonProps.Contains("parameters.max_uses")) __score10++;
            if (__jsonProps.Contains("parameters.mode")) __score10++;
            if (__jsonProps.Contains("parameters.search_context_size")) __score10++;
            if (__jsonProps.Contains("parameters.user_location")) __score10++;
            if (__jsonProps.Contains("parameters.x_search")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("allowed_domains")) __score11++;
            if (__jsonProps.Contains("engine")) __score11++;
            if (__jsonProps.Contains("excluded_domains")) __score11++;
            if (__jsonProps.Contains("max_characters")) __score11++;
            if (__jsonProps.Contains("max_results")) __score11++;
            if (__jsonProps.Contains("max_total_results")) __score11++;
            if (__jsonProps.Contains("max_uses")) __score11++;
            if (__jsonProps.Contains("mode")) __score11++;
            if (__jsonProps.Contains("parameters")) __score11++;
            if (__jsonProps.Contains("parameters.allowed_domains")) __score11++;
            if (__jsonProps.Contains("parameters.engine")) __score11++;
            if (__jsonProps.Contains("parameters.excluded_domains")) __score11++;
            if (__jsonProps.Contains("parameters.max_characters")) __score11++;
            if (__jsonProps.Contains("parameters.max_results")) __score11++;
            if (__jsonProps.Contains("parameters.max_total_results")) __score11++;
            if (__jsonProps.Contains("parameters.max_uses")) __score11++;
            if (__jsonProps.Contains("parameters.mode")) __score11++;
            if (__jsonProps.Contains("parameters.search_context_size")) __score11++;
            if (__jsonProps.Contains("parameters.user_location")) __score11++;
            if (__jsonProps.Contains("parameters.x_search")) __score11++;
            if (__jsonProps.Contains("search_context_size")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            if (__jsonProps.Contains("user_location")) __score11++;
            if (__jsonProps.Contains("user_location.city")) __score11++;
            if (__jsonProps.Contains("user_location.country")) __score11++;
            if (__jsonProps.Contains("user_location.region")) __score11++;
            if (__jsonProps.Contains("user_location.timezone")) __score11++;
            if (__jsonProps.Contains("user_location.type")) __score11++;
            if (__jsonProps.Contains("x_search")) __score11++;
            if (__jsonProps.Contains("x_search.allowed_x_handles")) __score11++;
            if (__jsonProps.Contains("x_search.enable_image_understanding")) __score11++;
            if (__jsonProps.Contains("x_search.enable_video_understanding")) __score11++;
            if (__jsonProps.Contains("x_search.excluded_x_handles")) __score11++;
            if (__jsonProps.Contains("x_search.from_date")) __score11++;
            if (__jsonProps.Contains("x_search.to_date")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("parameters")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
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

            global::OpenRouter.ChatFunctionToolVariant1? chatFunctionToolVariant1 = default;
            global::OpenRouter.AdvisorServerToolOpenRouter? advisorServerOpenRouter = default;
            global::OpenRouter.BashServerTool? bashServer = default;
            global::OpenRouter.DatetimeServerTool? datetimeServer = default;
            global::OpenRouter.FilesServerTool? filesServer = default;
            global::OpenRouter.FusionServerToolOpenRouter? fusionServerOpenRouter = default;
            global::OpenRouter.ImageGenerationServerToolOpenRouter? imageGenerationServerOpenRouter = default;
            global::OpenRouter.ChatSearchModelsServerTool? searchModelsServer = default;
            global::OpenRouter.SubagentServerToolOpenRouter? subagentServerOpenRouter = default;
            global::OpenRouter.WebFetchServerTool? webFetchServer = default;
            global::OpenRouter.OpenRouterWebSearchServerTool? openRouterWebSearchServer = default;
            global::OpenRouter.ChatWebSearchShorthand? webSearchShorthand = default;
            global::OpenRouter.ChatDynamicServerTool? dynamicServer = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatFunctionToolVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatFunctionToolVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatFunctionToolVariant1).Name}");
                        chatFunctionToolVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AdvisorServerToolOpenRouter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AdvisorServerToolOpenRouter> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AdvisorServerToolOpenRouter).Name}");
                        advisorServerOpenRouter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.BashServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.BashServerTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.BashServerTool).Name}");
                        bashServer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DatetimeServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DatetimeServerTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.DatetimeServerTool).Name}");
                        datetimeServer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FilesServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FilesServerTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FilesServerTool).Name}");
                        filesServer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FusionServerToolOpenRouter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FusionServerToolOpenRouter> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FusionServerToolOpenRouter).Name}");
                        fusionServerOpenRouter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ImageGenerationServerToolOpenRouter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ImageGenerationServerToolOpenRouter> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ImageGenerationServerToolOpenRouter).Name}");
                        imageGenerationServerOpenRouter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatSearchModelsServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatSearchModelsServerTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatSearchModelsServerTool).Name}");
                        searchModelsServer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.SubagentServerToolOpenRouter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.SubagentServerToolOpenRouter> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.SubagentServerToolOpenRouter).Name}");
                        subagentServerOpenRouter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.WebFetchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.WebFetchServerTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.WebFetchServerTool).Name}");
                        webFetchServer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenRouterWebSearchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenRouterWebSearchServerTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenRouterWebSearchServerTool).Name}");
                        openRouterWebSearchServer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatWebSearchShorthand), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatWebSearchShorthand> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatWebSearchShorthand).Name}");
                        webSearchShorthand = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatDynamicServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatDynamicServerTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatDynamicServerTool).Name}");
                        dynamicServer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (chatFunctionToolVariant1 == null && advisorServerOpenRouter == null && bashServer == null && datetimeServer == null && filesServer == null && fusionServerOpenRouter == null && imageGenerationServerOpenRouter == null && searchModelsServer == null && subagentServerOpenRouter == null && webFetchServer == null && openRouterWebSearchServer == null && webSearchShorthand == null && dynamicServer == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatFunctionToolVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatFunctionToolVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatFunctionToolVariant1).Name}");
                    chatFunctionToolVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (chatFunctionToolVariant1 == null && advisorServerOpenRouter == null && bashServer == null && datetimeServer == null && filesServer == null && fusionServerOpenRouter == null && imageGenerationServerOpenRouter == null && searchModelsServer == null && subagentServerOpenRouter == null && webFetchServer == null && openRouterWebSearchServer == null && webSearchShorthand == null && dynamicServer == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AdvisorServerToolOpenRouter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AdvisorServerToolOpenRouter> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AdvisorServerToolOpenRouter).Name}");
                    advisorServerOpenRouter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (chatFunctionToolVariant1 == null && advisorServerOpenRouter == null && bashServer == null && datetimeServer == null && filesServer == null && fusionServerOpenRouter == null && imageGenerationServerOpenRouter == null && searchModelsServer == null && subagentServerOpenRouter == null && webFetchServer == null && openRouterWebSearchServer == null && webSearchShorthand == null && dynamicServer == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.BashServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.BashServerTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.BashServerTool).Name}");
                    bashServer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (chatFunctionToolVariant1 == null && advisorServerOpenRouter == null && bashServer == null && datetimeServer == null && filesServer == null && fusionServerOpenRouter == null && imageGenerationServerOpenRouter == null && searchModelsServer == null && subagentServerOpenRouter == null && webFetchServer == null && openRouterWebSearchServer == null && webSearchShorthand == null && dynamicServer == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DatetimeServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DatetimeServerTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.DatetimeServerTool).Name}");
                    datetimeServer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (chatFunctionToolVariant1 == null && advisorServerOpenRouter == null && bashServer == null && datetimeServer == null && filesServer == null && fusionServerOpenRouter == null && imageGenerationServerOpenRouter == null && searchModelsServer == null && subagentServerOpenRouter == null && webFetchServer == null && openRouterWebSearchServer == null && webSearchShorthand == null && dynamicServer == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FilesServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FilesServerTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FilesServerTool).Name}");
                    filesServer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (chatFunctionToolVariant1 == null && advisorServerOpenRouter == null && bashServer == null && datetimeServer == null && filesServer == null && fusionServerOpenRouter == null && imageGenerationServerOpenRouter == null && searchModelsServer == null && subagentServerOpenRouter == null && webFetchServer == null && openRouterWebSearchServer == null && webSearchShorthand == null && dynamicServer == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FusionServerToolOpenRouter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FusionServerToolOpenRouter> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FusionServerToolOpenRouter).Name}");
                    fusionServerOpenRouter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (chatFunctionToolVariant1 == null && advisorServerOpenRouter == null && bashServer == null && datetimeServer == null && filesServer == null && fusionServerOpenRouter == null && imageGenerationServerOpenRouter == null && searchModelsServer == null && subagentServerOpenRouter == null && webFetchServer == null && openRouterWebSearchServer == null && webSearchShorthand == null && dynamicServer == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ImageGenerationServerToolOpenRouter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ImageGenerationServerToolOpenRouter> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ImageGenerationServerToolOpenRouter).Name}");
                    imageGenerationServerOpenRouter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (chatFunctionToolVariant1 == null && advisorServerOpenRouter == null && bashServer == null && datetimeServer == null && filesServer == null && fusionServerOpenRouter == null && imageGenerationServerOpenRouter == null && searchModelsServer == null && subagentServerOpenRouter == null && webFetchServer == null && openRouterWebSearchServer == null && webSearchShorthand == null && dynamicServer == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatSearchModelsServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatSearchModelsServerTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatSearchModelsServerTool).Name}");
                    searchModelsServer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (chatFunctionToolVariant1 == null && advisorServerOpenRouter == null && bashServer == null && datetimeServer == null && filesServer == null && fusionServerOpenRouter == null && imageGenerationServerOpenRouter == null && searchModelsServer == null && subagentServerOpenRouter == null && webFetchServer == null && openRouterWebSearchServer == null && webSearchShorthand == null && dynamicServer == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.SubagentServerToolOpenRouter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.SubagentServerToolOpenRouter> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.SubagentServerToolOpenRouter).Name}");
                    subagentServerOpenRouter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (chatFunctionToolVariant1 == null && advisorServerOpenRouter == null && bashServer == null && datetimeServer == null && filesServer == null && fusionServerOpenRouter == null && imageGenerationServerOpenRouter == null && searchModelsServer == null && subagentServerOpenRouter == null && webFetchServer == null && openRouterWebSearchServer == null && webSearchShorthand == null && dynamicServer == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.WebFetchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.WebFetchServerTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.WebFetchServerTool).Name}");
                    webFetchServer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (chatFunctionToolVariant1 == null && advisorServerOpenRouter == null && bashServer == null && datetimeServer == null && filesServer == null && fusionServerOpenRouter == null && imageGenerationServerOpenRouter == null && searchModelsServer == null && subagentServerOpenRouter == null && webFetchServer == null && openRouterWebSearchServer == null && webSearchShorthand == null && dynamicServer == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenRouterWebSearchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenRouterWebSearchServerTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenRouterWebSearchServerTool).Name}");
                    openRouterWebSearchServer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (chatFunctionToolVariant1 == null && advisorServerOpenRouter == null && bashServer == null && datetimeServer == null && filesServer == null && fusionServerOpenRouter == null && imageGenerationServerOpenRouter == null && searchModelsServer == null && subagentServerOpenRouter == null && webFetchServer == null && openRouterWebSearchServer == null && webSearchShorthand == null && dynamicServer == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatWebSearchShorthand), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatWebSearchShorthand> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatWebSearchShorthand).Name}");
                    webSearchShorthand = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (chatFunctionToolVariant1 == null && advisorServerOpenRouter == null && bashServer == null && datetimeServer == null && filesServer == null && fusionServerOpenRouter == null && imageGenerationServerOpenRouter == null && searchModelsServer == null && subagentServerOpenRouter == null && webFetchServer == null && openRouterWebSearchServer == null && webSearchShorthand == null && dynamicServer == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatDynamicServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatDynamicServerTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatDynamicServerTool).Name}");
                    dynamicServer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::OpenRouter.ChatFunctionTool(
                chatFunctionToolVariant1,

                advisorServerOpenRouter,

                bashServer,

                datetimeServer,

                filesServer,

                fusionServerOpenRouter,

                imageGenerationServerOpenRouter,

                searchModelsServer,

                subagentServerOpenRouter,

                webFetchServer,

                openRouterWebSearchServer,

                webSearchShorthand,

                dynamicServer
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.ChatFunctionTool value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsChatFunctionToolVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatFunctionToolVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatFunctionToolVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatFunctionToolVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickChatFunctionToolVariant1(), typeInfo);
            }
            else if (value.IsAdvisorServerOpenRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AdvisorServerToolOpenRouter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AdvisorServerToolOpenRouter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AdvisorServerToolOpenRouter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAdvisorServerOpenRouter(), typeInfo);
            }
            else if (value.IsBashServer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.BashServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.BashServerTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.BashServerTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBashServer(), typeInfo);
            }
            else if (value.IsDatetimeServer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.DatetimeServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.DatetimeServerTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.DatetimeServerTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDatetimeServer(), typeInfo);
            }
            else if (value.IsFilesServer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FilesServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FilesServerTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FilesServerTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFilesServer(), typeInfo);
            }
            else if (value.IsFusionServerOpenRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FusionServerToolOpenRouter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FusionServerToolOpenRouter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FusionServerToolOpenRouter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFusionServerOpenRouter(), typeInfo);
            }
            else if (value.IsImageGenerationServerOpenRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ImageGenerationServerToolOpenRouter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ImageGenerationServerToolOpenRouter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ImageGenerationServerToolOpenRouter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickImageGenerationServerOpenRouter(), typeInfo);
            }
            else if (value.IsSearchModelsServer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatSearchModelsServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatSearchModelsServerTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatSearchModelsServerTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSearchModelsServer(), typeInfo);
            }
            else if (value.IsSubagentServerOpenRouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.SubagentServerToolOpenRouter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.SubagentServerToolOpenRouter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.SubagentServerToolOpenRouter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSubagentServerOpenRouter(), typeInfo);
            }
            else if (value.IsWebFetchServer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.WebFetchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.WebFetchServerTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.WebFetchServerTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWebFetchServer(), typeInfo);
            }
            else if (value.IsOpenRouterWebSearchServer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenRouterWebSearchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenRouterWebSearchServerTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenRouterWebSearchServerTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenRouterWebSearchServer(), typeInfo);
            }
            else if (value.IsWebSearchShorthand)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatWebSearchShorthand), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatWebSearchShorthand?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatWebSearchShorthand).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWebSearchShorthand(), typeInfo);
            }
            else if (value.IsDynamicServer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatDynamicServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatDynamicServerTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatDynamicServerTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDynamicServer(), typeInfo);
            }
        }
    }
}