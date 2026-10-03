#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class ModelInputV2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.ModelInputV2>
    {
        /// <inheritdoc />
        public override global::OpenRouter.ModelInputV2 Read(
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
            if (__jsonProps.Contains("capacity")) __score0++;
            if (__jsonProps.Contains("params")) __score0++;
            if (__jsonProps.Contains("params.max_length")) __score0++;
            if (__jsonProps.Contains("params.max_prompt_length")) __score0++;
            if (__jsonProps.Contains("passthrough_parameters")) __score0++;
            if (__jsonProps.Contains("pricing")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("capacity")) __score1++;
            if (__jsonProps.Contains("params")) __score1++;
            if (__jsonProps.Contains("params.detail_levels")) __score1++;
            if (__jsonProps.Contains("params.formats")) __score1++;
            if (__jsonProps.Contains("params.max_content_size_bytes")) __score1++;
            if (__jsonProps.Contains("params.references")) __score1++;
            if (__jsonProps.Contains("params.role")) __score1++;
            if (__jsonProps.Contains("params.sources")) __score1++;
            if (__jsonProps.Contains("passthrough_parameters")) __score1++;
            if (__jsonProps.Contains("pricing")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("capacity")) __score2++;
            if (__jsonProps.Contains("params")) __score2++;
            if (__jsonProps.Contains("params.formats")) __score2++;
            if (__jsonProps.Contains("params.max_content_size_bytes")) __score2++;
            if (__jsonProps.Contains("params.max_duration_seconds")) __score2++;
            if (__jsonProps.Contains("params.sources")) __score2++;
            if (__jsonProps.Contains("passthrough_parameters")) __score2++;
            if (__jsonProps.Contains("pricing")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("capacity")) __score3++;
            if (__jsonProps.Contains("params")) __score3++;
            if (__jsonProps.Contains("params.formats")) __score3++;
            if (__jsonProps.Contains("params.max_content_size_bytes")) __score3++;
            if (__jsonProps.Contains("params.max_duration_seconds")) __score3++;
            if (__jsonProps.Contains("params.sources")) __score3++;
            if (__jsonProps.Contains("passthrough_parameters")) __score3++;
            if (__jsonProps.Contains("pricing")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("capacity")) __score4++;
            if (__jsonProps.Contains("params")) __score4++;
            if (__jsonProps.Contains("params.formats")) __score4++;
            if (__jsonProps.Contains("params.max_content_size_bytes")) __score4++;
            if (__jsonProps.Contains("params.references")) __score4++;
            if (__jsonProps.Contains("params.sources")) __score4++;
            if (__jsonProps.Contains("passthrough_parameters")) __score4++;
            if (__jsonProps.Contains("pricing")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::OpenRouter.ModelInputV2Variant1? modelInputV2Variant1 = default;
            global::OpenRouter.ModelInputV2Variant2? modelInputV2Variant2 = default;
            global::OpenRouter.ModelInputV2Variant3? modelInputV2Variant3 = default;
            global::OpenRouter.ModelInputV2Variant4? modelInputV2Variant4 = default;
            global::OpenRouter.ModelInputV2Variant5? modelInputV2Variant5 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelInputV2Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelInputV2Variant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelInputV2Variant1).Name}");
                        modelInputV2Variant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelInputV2Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelInputV2Variant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelInputV2Variant2).Name}");
                        modelInputV2Variant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelInputV2Variant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelInputV2Variant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelInputV2Variant3).Name}");
                        modelInputV2Variant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelInputV2Variant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelInputV2Variant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelInputV2Variant4).Name}");
                        modelInputV2Variant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelInputV2Variant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelInputV2Variant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelInputV2Variant5).Name}");
                        modelInputV2Variant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (modelInputV2Variant1 == null && modelInputV2Variant2 == null && modelInputV2Variant3 == null && modelInputV2Variant4 == null && modelInputV2Variant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelInputV2Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelInputV2Variant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelInputV2Variant1).Name}");
                    modelInputV2Variant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (modelInputV2Variant1 == null && modelInputV2Variant2 == null && modelInputV2Variant3 == null && modelInputV2Variant4 == null && modelInputV2Variant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelInputV2Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelInputV2Variant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelInputV2Variant2).Name}");
                    modelInputV2Variant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (modelInputV2Variant1 == null && modelInputV2Variant2 == null && modelInputV2Variant3 == null && modelInputV2Variant4 == null && modelInputV2Variant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelInputV2Variant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelInputV2Variant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelInputV2Variant3).Name}");
                    modelInputV2Variant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (modelInputV2Variant1 == null && modelInputV2Variant2 == null && modelInputV2Variant3 == null && modelInputV2Variant4 == null && modelInputV2Variant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelInputV2Variant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelInputV2Variant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelInputV2Variant4).Name}");
                    modelInputV2Variant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (modelInputV2Variant1 == null && modelInputV2Variant2 == null && modelInputV2Variant3 == null && modelInputV2Variant4 == null && modelInputV2Variant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelInputV2Variant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelInputV2Variant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelInputV2Variant5).Name}");
                    modelInputV2Variant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::OpenRouter.ModelInputV2(
                modelInputV2Variant1,

                modelInputV2Variant2,

                modelInputV2Variant3,

                modelInputV2Variant4,

                modelInputV2Variant5
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.ModelInputV2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsModelInputV2Variant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelInputV2Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelInputV2Variant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelInputV2Variant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickModelInputV2Variant1(), typeInfo);
            }
            else if (value.IsModelInputV2Variant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelInputV2Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelInputV2Variant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelInputV2Variant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickModelInputV2Variant2(), typeInfo);
            }
            else if (value.IsModelInputV2Variant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelInputV2Variant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelInputV2Variant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelInputV2Variant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickModelInputV2Variant3(), typeInfo);
            }
            else if (value.IsModelInputV2Variant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelInputV2Variant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelInputV2Variant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelInputV2Variant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickModelInputV2Variant4(), typeInfo);
            }
            else if (value.IsModelInputV2Variant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelInputV2Variant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelInputV2Variant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelInputV2Variant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickModelInputV2Variant5(), typeInfo);
            }
        }
    }
}