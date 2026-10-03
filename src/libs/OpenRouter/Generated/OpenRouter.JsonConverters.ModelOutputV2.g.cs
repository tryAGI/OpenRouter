#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class ModelOutputV2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.ModelOutputV2>
    {
        /// <inheritdoc />
        public override global::OpenRouter.ModelOutputV2 Read(
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
            if (__jsonProps.Contains("max_length")) __score0++;
            if (__jsonProps.Contains("max_length.unit")) __score0++;
            if (__jsonProps.Contains("max_length.value")) __score0++;
            if (__jsonProps.Contains("params")) __score0++;
            if (__jsonProps.Contains("passthrough_parameters")) __score0++;
            if (__jsonProps.Contains("pricing")) __score0++;
            if (__jsonProps.Contains("streaming")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("capacity")) __score1++;
            if (__jsonProps.Contains("params")) __score1++;
            if (__jsonProps.Contains("passthrough_parameters")) __score1++;
            if (__jsonProps.Contains("pricing")) __score1++;
            if (__jsonProps.Contains("streaming")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("capacity")) __score2++;
            if (__jsonProps.Contains("params")) __score2++;
            if (__jsonProps.Contains("passthrough_parameters")) __score2++;
            if (__jsonProps.Contains("pricing")) __score2++;
            if (__jsonProps.Contains("streaming")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("capacity")) __score3++;
            if (__jsonProps.Contains("params")) __score3++;
            if (__jsonProps.Contains("passthrough_parameters")) __score3++;
            if (__jsonProps.Contains("pricing")) __score3++;
            if (__jsonProps.Contains("streaming")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("capacity")) __score4++;
            if (__jsonProps.Contains("params")) __score4++;
            if (__jsonProps.Contains("passthrough_parameters")) __score4++;
            if (__jsonProps.Contains("pricing")) __score4++;
            if (__jsonProps.Contains("streaming")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("capacity")) __score5++;
            if (__jsonProps.Contains("params")) __score5++;
            if (__jsonProps.Contains("passthrough_parameters")) __score5++;
            if (__jsonProps.Contains("pricing")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("capacity")) __score6++;
            if (__jsonProps.Contains("params")) __score6++;
            if (__jsonProps.Contains("passthrough_parameters")) __score6++;
            if (__jsonProps.Contains("pricing")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("capacity")) __score7++;
            if (__jsonProps.Contains("params")) __score7++;
            if (__jsonProps.Contains("passthrough_parameters")) __score7++;
            if (__jsonProps.Contains("pricing")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("capacity")) __score8++;
            if (__jsonProps.Contains("params")) __score8++;
            if (__jsonProps.Contains("passthrough_parameters")) __score8++;
            if (__jsonProps.Contains("pricing")) __score8++;
            if (__jsonProps.Contains("streaming")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
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

            global::OpenRouter.ModelOutputV2Variant1? modelOutputV2Variant1 = default;
            global::OpenRouter.ModelOutputV2Variant2? modelOutputV2Variant2 = default;
            global::OpenRouter.ModelOutputV2Variant3? modelOutputV2Variant3 = default;
            global::OpenRouter.ModelOutputV2Variant4? modelOutputV2Variant4 = default;
            global::OpenRouter.ModelOutputV2Variant5? modelOutputV2Variant5 = default;
            global::OpenRouter.ModelOutputV2Variant6? modelOutputV2Variant6 = default;
            global::OpenRouter.ModelOutputV2Variant7? modelOutputV2Variant7 = default;
            global::OpenRouter.ModelOutputV2Variant8? modelOutputV2Variant8 = default;
            global::OpenRouter.ModelOutputV2Variant9? modelOutputV2Variant9 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelOutputV2Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelOutputV2Variant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelOutputV2Variant1).Name}");
                        modelOutputV2Variant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelOutputV2Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelOutputV2Variant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelOutputV2Variant2).Name}");
                        modelOutputV2Variant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelOutputV2Variant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelOutputV2Variant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelOutputV2Variant3).Name}");
                        modelOutputV2Variant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelOutputV2Variant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelOutputV2Variant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelOutputV2Variant4).Name}");
                        modelOutputV2Variant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelOutputV2Variant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelOutputV2Variant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelOutputV2Variant5).Name}");
                        modelOutputV2Variant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelOutputV2Variant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelOutputV2Variant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelOutputV2Variant6).Name}");
                        modelOutputV2Variant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelOutputV2Variant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelOutputV2Variant7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelOutputV2Variant7).Name}");
                        modelOutputV2Variant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelOutputV2Variant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelOutputV2Variant8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelOutputV2Variant8).Name}");
                        modelOutputV2Variant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelOutputV2Variant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelOutputV2Variant9> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelOutputV2Variant9).Name}");
                        modelOutputV2Variant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (modelOutputV2Variant1 == null && modelOutputV2Variant2 == null && modelOutputV2Variant3 == null && modelOutputV2Variant4 == null && modelOutputV2Variant5 == null && modelOutputV2Variant6 == null && modelOutputV2Variant7 == null && modelOutputV2Variant8 == null && modelOutputV2Variant9 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelOutputV2Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelOutputV2Variant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelOutputV2Variant1).Name}");
                    modelOutputV2Variant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (modelOutputV2Variant1 == null && modelOutputV2Variant2 == null && modelOutputV2Variant3 == null && modelOutputV2Variant4 == null && modelOutputV2Variant5 == null && modelOutputV2Variant6 == null && modelOutputV2Variant7 == null && modelOutputV2Variant8 == null && modelOutputV2Variant9 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelOutputV2Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelOutputV2Variant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelOutputV2Variant2).Name}");
                    modelOutputV2Variant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (modelOutputV2Variant1 == null && modelOutputV2Variant2 == null && modelOutputV2Variant3 == null && modelOutputV2Variant4 == null && modelOutputV2Variant5 == null && modelOutputV2Variant6 == null && modelOutputV2Variant7 == null && modelOutputV2Variant8 == null && modelOutputV2Variant9 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelOutputV2Variant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelOutputV2Variant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelOutputV2Variant3).Name}");
                    modelOutputV2Variant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (modelOutputV2Variant1 == null && modelOutputV2Variant2 == null && modelOutputV2Variant3 == null && modelOutputV2Variant4 == null && modelOutputV2Variant5 == null && modelOutputV2Variant6 == null && modelOutputV2Variant7 == null && modelOutputV2Variant8 == null && modelOutputV2Variant9 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelOutputV2Variant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelOutputV2Variant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelOutputV2Variant4).Name}");
                    modelOutputV2Variant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (modelOutputV2Variant1 == null && modelOutputV2Variant2 == null && modelOutputV2Variant3 == null && modelOutputV2Variant4 == null && modelOutputV2Variant5 == null && modelOutputV2Variant6 == null && modelOutputV2Variant7 == null && modelOutputV2Variant8 == null && modelOutputV2Variant9 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelOutputV2Variant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelOutputV2Variant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelOutputV2Variant5).Name}");
                    modelOutputV2Variant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (modelOutputV2Variant1 == null && modelOutputV2Variant2 == null && modelOutputV2Variant3 == null && modelOutputV2Variant4 == null && modelOutputV2Variant5 == null && modelOutputV2Variant6 == null && modelOutputV2Variant7 == null && modelOutputV2Variant8 == null && modelOutputV2Variant9 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelOutputV2Variant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelOutputV2Variant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelOutputV2Variant6).Name}");
                    modelOutputV2Variant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (modelOutputV2Variant1 == null && modelOutputV2Variant2 == null && modelOutputV2Variant3 == null && modelOutputV2Variant4 == null && modelOutputV2Variant5 == null && modelOutputV2Variant6 == null && modelOutputV2Variant7 == null && modelOutputV2Variant8 == null && modelOutputV2Variant9 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelOutputV2Variant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelOutputV2Variant7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelOutputV2Variant7).Name}");
                    modelOutputV2Variant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (modelOutputV2Variant1 == null && modelOutputV2Variant2 == null && modelOutputV2Variant3 == null && modelOutputV2Variant4 == null && modelOutputV2Variant5 == null && modelOutputV2Variant6 == null && modelOutputV2Variant7 == null && modelOutputV2Variant8 == null && modelOutputV2Variant9 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelOutputV2Variant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelOutputV2Variant8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelOutputV2Variant8).Name}");
                    modelOutputV2Variant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (modelOutputV2Variant1 == null && modelOutputV2Variant2 == null && modelOutputV2Variant3 == null && modelOutputV2Variant4 == null && modelOutputV2Variant5 == null && modelOutputV2Variant6 == null && modelOutputV2Variant7 == null && modelOutputV2Variant8 == null && modelOutputV2Variant9 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelOutputV2Variant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelOutputV2Variant9> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelOutputV2Variant9).Name}");
                    modelOutputV2Variant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::OpenRouter.ModelOutputV2(
                modelOutputV2Variant1,

                modelOutputV2Variant2,

                modelOutputV2Variant3,

                modelOutputV2Variant4,

                modelOutputV2Variant5,

                modelOutputV2Variant6,

                modelOutputV2Variant7,

                modelOutputV2Variant8,

                modelOutputV2Variant9
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.ModelOutputV2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsModelOutputV2Variant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelOutputV2Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelOutputV2Variant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelOutputV2Variant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickModelOutputV2Variant1(), typeInfo);
            }
            else if (value.IsModelOutputV2Variant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelOutputV2Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelOutputV2Variant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelOutputV2Variant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickModelOutputV2Variant2(), typeInfo);
            }
            else if (value.IsModelOutputV2Variant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelOutputV2Variant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelOutputV2Variant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelOutputV2Variant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickModelOutputV2Variant3(), typeInfo);
            }
            else if (value.IsModelOutputV2Variant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelOutputV2Variant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelOutputV2Variant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelOutputV2Variant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickModelOutputV2Variant4(), typeInfo);
            }
            else if (value.IsModelOutputV2Variant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelOutputV2Variant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelOutputV2Variant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelOutputV2Variant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickModelOutputV2Variant5(), typeInfo);
            }
            else if (value.IsModelOutputV2Variant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelOutputV2Variant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelOutputV2Variant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelOutputV2Variant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickModelOutputV2Variant6(), typeInfo);
            }
            else if (value.IsModelOutputV2Variant7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelOutputV2Variant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelOutputV2Variant7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelOutputV2Variant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickModelOutputV2Variant7(), typeInfo);
            }
            else if (value.IsModelOutputV2Variant8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelOutputV2Variant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelOutputV2Variant8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelOutputV2Variant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickModelOutputV2Variant8(), typeInfo);
            }
            else if (value.IsModelOutputV2Variant9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModelOutputV2Variant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModelOutputV2Variant9?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModelOutputV2Variant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickModelOutputV2Variant9(), typeInfo);
            }
        }
    }
}