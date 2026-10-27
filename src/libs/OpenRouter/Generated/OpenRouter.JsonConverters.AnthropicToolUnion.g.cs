#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class AnthropicToolUnionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.AnthropicToolUnion>
    {
        /// <inheritdoc />
        public override global::OpenRouter.AnthropicToolUnion Read(
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
            if (__jsonProps.Contains("cache_control.ttl")) __score0++;
            if (__jsonProps.Contains("cache_control.type")) __score0++;
            if (__jsonProps.Contains("defer_loading")) __score0++;
            if (__jsonProps.Contains("description")) __score0++;
            if (__jsonProps.Contains("input_schema")) __score0++;
            if (__jsonProps.Contains("input_schema.properties")) __score0++;
            if (__jsonProps.Contains("input_schema.required")) __score0++;
            if (__jsonProps.Contains("input_schema.type")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("strict")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("cache_control")) __score1++;
            if (__jsonProps.Contains("cache_control.ttl")) __score1++;
            if (__jsonProps.Contains("cache_control.type")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("cache_control")) __score2++;
            if (__jsonProps.Contains("cache_control.ttl")) __score2++;
            if (__jsonProps.Contains("cache_control.type")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("allowed_domains")) __score3++;
            if (__jsonProps.Contains("blocked_domains")) __score3++;
            if (__jsonProps.Contains("cache_control")) __score3++;
            if (__jsonProps.Contains("cache_control.ttl")) __score3++;
            if (__jsonProps.Contains("cache_control.type")) __score3++;
            if (__jsonProps.Contains("max_uses")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("user_location")) __score3++;
            if (__jsonProps.Contains("user_location.city")) __score3++;
            if (__jsonProps.Contains("user_location.country")) __score3++;
            if (__jsonProps.Contains("user_location.region")) __score3++;
            if (__jsonProps.Contains("user_location.timezone")) __score3++;
            if (__jsonProps.Contains("user_location.type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("allowed_callers")) __score4++;
            if (__jsonProps.Contains("allowed_domains")) __score4++;
            if (__jsonProps.Contains("blocked_domains")) __score4++;
            if (__jsonProps.Contains("cache_control")) __score4++;
            if (__jsonProps.Contains("cache_control.ttl")) __score4++;
            if (__jsonProps.Contains("cache_control.type")) __score4++;
            if (__jsonProps.Contains("max_uses")) __score4++;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("user_location")) __score4++;
            if (__jsonProps.Contains("user_location.city")) __score4++;
            if (__jsonProps.Contains("user_location.country")) __score4++;
            if (__jsonProps.Contains("user_location.region")) __score4++;
            if (__jsonProps.Contains("user_location.timezone")) __score4++;
            if (__jsonProps.Contains("user_location.type")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::OpenRouter.AnthropicToolUnionVariant1? anthropicToolUnionVariant1 = default;
            global::OpenRouter.AnthropicToolUnionVariant2? anthropicToolUnionVariant2 = default;
            global::OpenRouter.AnthropicToolUnionVariant3? anthropicToolUnionVariant3 = default;
            global::OpenRouter.AnthropicToolUnionVariant4? anthropicToolUnionVariant4 = default;
            global::OpenRouter.AnthropicToolUnionVariant5? anthropicToolUnionVariant5 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicToolUnionVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicToolUnionVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicToolUnionVariant1).Name}");
                        anthropicToolUnionVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicToolUnionVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicToolUnionVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicToolUnionVariant2).Name}");
                        anthropicToolUnionVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicToolUnionVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicToolUnionVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicToolUnionVariant3).Name}");
                        anthropicToolUnionVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicToolUnionVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicToolUnionVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicToolUnionVariant4).Name}");
                        anthropicToolUnionVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicToolUnionVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicToolUnionVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicToolUnionVariant5).Name}");
                        anthropicToolUnionVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
            }

            if (anthropicToolUnionVariant1 == null && anthropicToolUnionVariant2 == null && anthropicToolUnionVariant3 == null && anthropicToolUnionVariant4 == null && anthropicToolUnionVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicToolUnionVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicToolUnionVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicToolUnionVariant1).Name}");
                    anthropicToolUnionVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (anthropicToolUnionVariant1 == null && anthropicToolUnionVariant2 == null && anthropicToolUnionVariant3 == null && anthropicToolUnionVariant4 == null && anthropicToolUnionVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicToolUnionVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicToolUnionVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicToolUnionVariant2).Name}");
                    anthropicToolUnionVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (anthropicToolUnionVariant1 == null && anthropicToolUnionVariant2 == null && anthropicToolUnionVariant3 == null && anthropicToolUnionVariant4 == null && anthropicToolUnionVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicToolUnionVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicToolUnionVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicToolUnionVariant3).Name}");
                    anthropicToolUnionVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (anthropicToolUnionVariant1 == null && anthropicToolUnionVariant2 == null && anthropicToolUnionVariant3 == null && anthropicToolUnionVariant4 == null && anthropicToolUnionVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicToolUnionVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicToolUnionVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicToolUnionVariant4).Name}");
                    anthropicToolUnionVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (anthropicToolUnionVariant1 == null && anthropicToolUnionVariant2 == null && anthropicToolUnionVariant3 == null && anthropicToolUnionVariant4 == null && anthropicToolUnionVariant5 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicToolUnionVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicToolUnionVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicToolUnionVariant5).Name}");
                    anthropicToolUnionVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            var __value = new global::OpenRouter.AnthropicToolUnion(
                anthropicToolUnionVariant1,

                anthropicToolUnionVariant2,

                anthropicToolUnionVariant3,

                anthropicToolUnionVariant4,

                anthropicToolUnionVariant5
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.AnthropicToolUnion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAnthropicToolUnionVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicToolUnionVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicToolUnionVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicToolUnionVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAnthropicToolUnionVariant1(), typeInfo);
            }
            else if (value.IsAnthropicToolUnionVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicToolUnionVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicToolUnionVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicToolUnionVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAnthropicToolUnionVariant2(), typeInfo);
            }
            else if (value.IsAnthropicToolUnionVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicToolUnionVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicToolUnionVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicToolUnionVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAnthropicToolUnionVariant3(), typeInfo);
            }
            else if (value.IsAnthropicToolUnionVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicToolUnionVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicToolUnionVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicToolUnionVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAnthropicToolUnionVariant4(), typeInfo);
            }
            else if (value.IsAnthropicToolUnionVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicToolUnionVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicToolUnionVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicToolUnionVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAnthropicToolUnionVariant5(), typeInfo);
            }
        }
    }
}