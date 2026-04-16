#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class OutputItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.OutputItems>
    {
        /// <inheritdoc />
        public override global::OpenRouter.OutputItems Read(
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
            if (__jsonProps.Contains("code")) __score0++;
            if (__jsonProps.Contains("container_id")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("outputs")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("action")) __score1++;
            if (__jsonProps.Contains("call_id")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("pending_safety_checks")) __score1++;
            if (__jsonProps.Contains("status")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("queries")) __score2++;
            if (__jsonProps.Contains("status")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("arguments")) __score3++;
            if (__jsonProps.Contains("call_id")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("status")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("id")) __score4++;
            if (__jsonProps.Contains("result")) __score4++;
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
            if (__jsonProps.Contains("filePath")) __score6++;
            if (__jsonProps.Contains("id")) __score6++;
            if (__jsonProps.Contains("patch")) __score6++;
            if (__jsonProps.Contains("status")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("command")) __score7++;
            if (__jsonProps.Contains("exitCode")) __score7++;
            if (__jsonProps.Contains("id")) __score7++;
            if (__jsonProps.Contains("status")) __score7++;
            if (__jsonProps.Contains("stderr")) __score7++;
            if (__jsonProps.Contains("stdout")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("action")) __score8++;
            if (__jsonProps.Contains("id")) __score8++;
            if (__jsonProps.Contains("screenshotB64")) __score8++;
            if (__jsonProps.Contains("status")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("code")) __score9++;
            if (__jsonProps.Contains("exitCode")) __score9++;
            if (__jsonProps.Contains("id")) __score9++;
            if (__jsonProps.Contains("language")) __score9++;
            if (__jsonProps.Contains("status")) __score9++;
            if (__jsonProps.Contains("stderr")) __score9++;
            if (__jsonProps.Contains("stdout")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("datetime")) __score10++;
            if (__jsonProps.Contains("id")) __score10++;
            if (__jsonProps.Contains("status")) __score10++;
            if (__jsonProps.Contains("timezone")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("arguments")) __score11++;
            if (__jsonProps.Contains("id")) __score11++;
            if (__jsonProps.Contains("query")) __score11++;
            if (__jsonProps.Contains("status")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("id")) __score12++;
            if (__jsonProps.Contains("queries")) __score12++;
            if (__jsonProps.Contains("status")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("id")) __score13++;
            if (__jsonProps.Contains("imageB64")) __score13++;
            if (__jsonProps.Contains("imageUrl")) __score13++;
            if (__jsonProps.Contains("result")) __score13++;
            if (__jsonProps.Contains("revisedPrompt")) __score13++;
            if (__jsonProps.Contains("status")) __score13++;
            if (__jsonProps.Contains("type")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("id")) __score14++;
            if (__jsonProps.Contains("serverLabel")) __score14++;
            if (__jsonProps.Contains("status")) __score14++;
            if (__jsonProps.Contains("toolName")) __score14++;
            if (__jsonProps.Contains("type")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("action")) __score15++;
            if (__jsonProps.Contains("id")) __score15++;
            if (__jsonProps.Contains("key")) __score15++;
            if (__jsonProps.Contains("status")) __score15++;
            if (__jsonProps.Contains("type")) __score15++;
            if (__jsonProps.Contains("value")) __score15++;
            var __score16 = 0;
            if (__jsonProps.Contains("command")) __score16++;
            if (__jsonProps.Contains("filePath")) __score16++;
            if (__jsonProps.Contains("id")) __score16++;
            if (__jsonProps.Contains("status")) __score16++;
            if (__jsonProps.Contains("type")) __score16++;
            var __score17 = 0;
            if (__jsonProps.Contains("id")) __score17++;
            if (__jsonProps.Contains("query")) __score17++;
            if (__jsonProps.Contains("status")) __score17++;
            if (__jsonProps.Contains("type")) __score17++;
            var __score18 = 0;
            if (__jsonProps.Contains("content")) __score18++;
            if (__jsonProps.Contains("id")) __score18++;
            if (__jsonProps.Contains("status")) __score18++;
            if (__jsonProps.Contains("title")) __score18++;
            if (__jsonProps.Contains("type")) __score18++;
            if (__jsonProps.Contains("url")) __score18++;
            var __score19 = 0;
            if (__jsonProps.Contains("id")) __score19++;
            if (__jsonProps.Contains("status")) __score19++;
            if (__jsonProps.Contains("type")) __score19++;
            var __score20 = 0;
            if (__jsonProps.Contains("content")) __score20++;
            if (__jsonProps.Contains("encrypted_content")) __score20++;
            if (__jsonProps.Contains("format")) __score20++;
            if (__jsonProps.Contains("id")) __score20++;
            if (__jsonProps.Contains("signature")) __score20++;
            if (__jsonProps.Contains("status")) __score20++;
            if (__jsonProps.Contains("summary")) __score20++;
            if (__jsonProps.Contains("type")) __score20++;
            var __score21 = 0;
            if (__jsonProps.Contains("action")) __score21++;
            if (__jsonProps.Contains("id")) __score21++;
            if (__jsonProps.Contains("status")) __score21++;
            if (__jsonProps.Contains("type")) __score21++;
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

            global::OpenRouter.OutputItemsVariant1? codeInterpreterCall = default;
            global::OpenRouter.OutputItemsVariant2? computerCall = default;
            global::OpenRouter.OutputItemsVariant3? fileSearchCall = default;
            global::OpenRouter.OutputItemsVariant4? functionCall = default;
            global::OpenRouter.OutputItemsVariant5? imageGenerationCall = default;
            global::OpenRouter.OutputItemsVariant6? message = default;
            global::OpenRouter.OutputItemsVariant7? openrouterApplyPatch = default;
            global::OpenRouter.OutputItemsVariant8? openrouterBash = default;
            global::OpenRouter.OutputItemsVariant9? openrouterBrowserUse = default;
            global::OpenRouter.OutputItemsVariant10? openrouterCodeInterpreter = default;
            global::OpenRouter.OutputItemsVariant11? openrouterDatetime = default;
            global::OpenRouter.OutputItemsVariant12? openrouterExperimentalSearchModels = default;
            global::OpenRouter.OutputItemsVariant13? openrouterFileSearch = default;
            global::OpenRouter.OutputItemsVariant14? openrouterImageGeneration = default;
            global::OpenRouter.OutputItemsVariant15? openrouterMcp = default;
            global::OpenRouter.OutputItemsVariant16? openrouterMemory = default;
            global::OpenRouter.OutputItemsVariant17? openrouterTextEditor = default;
            global::OpenRouter.OutputItemsVariant18? openrouterToolSearch = default;
            global::OpenRouter.OutputItemsVariant19? openrouterWebFetch = default;
            global::OpenRouter.OutputItemsVariant20? openrouterWebSearch = default;
            global::OpenRouter.OutputItemsVariant21? reasoning = default;
            global::OpenRouter.OutputItemsVariant22? webSearchCall = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant1).Name}");
                        codeInterpreterCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant2).Name}");
                        computerCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant3).Name}");
                        fileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant4).Name}");
                        functionCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant5).Name}");
                        imageGenerationCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant6).Name}");
                        message = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant7).Name}");
                        openrouterApplyPatch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant8).Name}");
                        openrouterBash = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant9> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant9).Name}");
                        openrouterBrowserUse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant10> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant10).Name}");
                        openrouterCodeInterpreter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant11> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant11).Name}");
                        openrouterDatetime = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant12> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant12).Name}");
                        openrouterExperimentalSearchModels = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant13> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant13).Name}");
                        openrouterFileSearch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant14> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant14).Name}");
                        openrouterImageGeneration = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant15> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant15).Name}");
                        openrouterMcp = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant16> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant16).Name}");
                        openrouterMemory = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant17> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant17).Name}");
                        openrouterTextEditor = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant18> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant18).Name}");
                        openrouterToolSearch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant19> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant19).Name}");
                        openrouterWebFetch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant20), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant20> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant20).Name}");
                        openrouterWebSearch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant21), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant21> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant21).Name}");
                        reasoning = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant22), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant22> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant22).Name}");
                        webSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (codeInterpreterCall == null && computerCall == null && fileSearchCall == null && functionCall == null && imageGenerationCall == null && message == null && openrouterApplyPatch == null && openrouterBash == null && openrouterBrowserUse == null && openrouterCodeInterpreter == null && openrouterDatetime == null && openrouterExperimentalSearchModels == null && openrouterFileSearch == null && openrouterImageGeneration == null && openrouterMcp == null && openrouterMemory == null && openrouterTextEditor == null && openrouterToolSearch == null && openrouterWebFetch == null && openrouterWebSearch == null && reasoning == null && webSearchCall == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant1).Name}");
                    codeInterpreterCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant2).Name}");
                    computerCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant3).Name}");
                    fileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant4).Name}");
                    functionCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant5).Name}");
                    imageGenerationCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant6).Name}");
                    message = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant7).Name}");
                    openrouterApplyPatch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant8).Name}");
                    openrouterBash = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant9> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant9).Name}");
                    openrouterBrowserUse = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant10> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant10).Name}");
                    openrouterCodeInterpreter = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant11> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant11).Name}");
                    openrouterDatetime = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant12> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant12).Name}");
                    openrouterExperimentalSearchModels = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant13> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant13).Name}");
                    openrouterFileSearch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant14> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant14).Name}");
                    openrouterImageGeneration = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant15> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant15).Name}");
                    openrouterMcp = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant16> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant16).Name}");
                    openrouterMemory = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant17> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant17).Name}");
                    openrouterTextEditor = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant18> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant18).Name}");
                    openrouterToolSearch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant19> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant19).Name}");
                    openrouterWebFetch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant20), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant20> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant20).Name}");
                    openrouterWebSearch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant21), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant21> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant21).Name}");
                    reasoning = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant22), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant22> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant22).Name}");
                    webSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::OpenRouter.OutputItems(
                codeInterpreterCall,

                computerCall,

                fileSearchCall,

                functionCall,

                imageGenerationCall,

                message,

                openrouterApplyPatch,

                openrouterBash,

                openrouterBrowserUse,

                openrouterCodeInterpreter,

                openrouterDatetime,

                openrouterExperimentalSearchModels,

                openrouterFileSearch,

                openrouterImageGeneration,

                openrouterMcp,

                openrouterMemory,

                openrouterTextEditor,

                openrouterToolSearch,

                openrouterWebFetch,

                openrouterWebSearch,

                reasoning,

                webSearchCall
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.OutputItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCodeInterpreterCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeInterpreterCall!, typeInfo);
            }
            else if (value.IsComputerCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerCall!, typeInfo);
            }
            else if (value.IsFileSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchCall!, typeInfo);
            }
            else if (value.IsFunctionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCall!, typeInfo);
            }
            else if (value.IsImageGenerationCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageGenerationCall!, typeInfo);
            }
            else if (value.IsMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message!, typeInfo);
            }
            else if (value.IsOpenrouterApplyPatch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenrouterApplyPatch!, typeInfo);
            }
            else if (value.IsOpenrouterBash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenrouterBash!, typeInfo);
            }
            else if (value.IsOpenrouterBrowserUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant9?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenrouterBrowserUse!, typeInfo);
            }
            else if (value.IsOpenrouterCodeInterpreter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant10?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenrouterCodeInterpreter!, typeInfo);
            }
            else if (value.IsOpenrouterDatetime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant11?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenrouterDatetime!, typeInfo);
            }
            else if (value.IsOpenrouterExperimentalSearchModels)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant12?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenrouterExperimentalSearchModels!, typeInfo);
            }
            else if (value.IsOpenrouterFileSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant13?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant13).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenrouterFileSearch!, typeInfo);
            }
            else if (value.IsOpenrouterImageGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant14?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant14).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenrouterImageGeneration!, typeInfo);
            }
            else if (value.IsOpenrouterMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant15?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant15).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenrouterMcp!, typeInfo);
            }
            else if (value.IsOpenrouterMemory)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant16?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant16).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenrouterMemory!, typeInfo);
            }
            else if (value.IsOpenrouterTextEditor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant17?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant17).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenrouterTextEditor!, typeInfo);
            }
            else if (value.IsOpenrouterToolSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant18?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant18).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenrouterToolSearch!, typeInfo);
            }
            else if (value.IsOpenrouterWebFetch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant19?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant19).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenrouterWebFetch!, typeInfo);
            }
            else if (value.IsOpenrouterWebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant20), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant20?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant20).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenrouterWebSearch!, typeInfo);
            }
            else if (value.IsReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant21), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant21?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant21).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Reasoning!, typeInfo);
            }
            else if (value.IsWebSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant22), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant22?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant22).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchCall!, typeInfo);
            }
        }
    }
}