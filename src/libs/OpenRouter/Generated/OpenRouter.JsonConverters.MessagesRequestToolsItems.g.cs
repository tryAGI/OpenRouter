#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class MessagesRequestToolsItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.MessagesRequestToolsItems>
    {
        /// <inheritdoc />
        public override global::OpenRouter.MessagesRequestToolsItems Read(
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
            if (__jsonProps.Contains("description")) __score0++;
            if (__jsonProps.Contains("input_schema")) __score0++;
            if (__jsonProps.Contains("input_schema.properties")) __score0++;
            if (__jsonProps.Contains("input_schema.required")) __score0++;
            if (__jsonProps.Contains("input_schema.type")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
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
            var __score5 = 0;
            if (__jsonProps.Contains("parameters")) __score5++;
            if (__jsonProps.Contains("parameters.timezone")) __score5++;
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
            if (__jsonProps.Contains("parameters.allowed_domains")) __score8++;
            if (__jsonProps.Contains("parameters.engine")) __score8++;
            if (__jsonProps.Contains("parameters.excluded_domains")) __score8++;
            if (__jsonProps.Contains("parameters.max_results")) __score8++;
            if (__jsonProps.Contains("parameters.max_total_results")) __score8++;
            if (__jsonProps.Contains("parameters.search_context_size")) __score8++;
            if (__jsonProps.Contains("parameters.user_location")) __score8++;
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

            global::OpenRouter.MessagesRequestToolsItems0? messagesRequestToolsItems0 = default;
            global::OpenRouter.MessagesRequestToolsItems1? messagesRequestToolsItems1 = default;
            global::OpenRouter.MessagesRequestToolsItems2? messagesRequestToolsItems2 = default;
            global::OpenRouter.MessagesRequestToolsItems3? messagesRequestToolsItems3 = default;
            global::OpenRouter.MessagesRequestToolsItems4? messagesRequestToolsItems4 = default;
            global::OpenRouter.DatetimeServerTool? datetimeServerTool = default;
            global::OpenRouter.ImageGenerationServerToolOpenRouter? imageGenerationServerToolOpenRouter = default;
            global::OpenRouter.ChatSearchModelsServerTool? chatSearchModelsServerTool = default;
            global::OpenRouter.OpenRouterWebSearchServerTool? openRouterWebSearchServerTool = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestToolsItems0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestToolsItems0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesRequestToolsItems0).Name}");
                        messagesRequestToolsItems0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestToolsItems1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestToolsItems1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesRequestToolsItems1).Name}");
                        messagesRequestToolsItems1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestToolsItems2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestToolsItems2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesRequestToolsItems2).Name}");
                        messagesRequestToolsItems2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestToolsItems3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestToolsItems3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesRequestToolsItems3).Name}");
                        messagesRequestToolsItems3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestToolsItems4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestToolsItems4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesRequestToolsItems4).Name}");
                        messagesRequestToolsItems4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                else if (__bestIndex == 6)
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
                else if (__bestIndex == 7)
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
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenRouterWebSearchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenRouterWebSearchServerTool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenRouterWebSearchServerTool).Name}");
                        openRouterWebSearchServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (messagesRequestToolsItems0 == null && messagesRequestToolsItems1 == null && messagesRequestToolsItems2 == null && messagesRequestToolsItems3 == null && messagesRequestToolsItems4 == null && datetimeServerTool == null && imageGenerationServerToolOpenRouter == null && chatSearchModelsServerTool == null && openRouterWebSearchServerTool == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestToolsItems0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestToolsItems0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesRequestToolsItems0).Name}");
                    messagesRequestToolsItems0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestToolsItems1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestToolsItems1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesRequestToolsItems1).Name}");
                    messagesRequestToolsItems1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestToolsItems2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestToolsItems2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesRequestToolsItems2).Name}");
                    messagesRequestToolsItems2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestToolsItems3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestToolsItems3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesRequestToolsItems3).Name}");
                    messagesRequestToolsItems3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestToolsItems4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestToolsItems4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesRequestToolsItems4).Name}");
                    messagesRequestToolsItems4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenRouterWebSearchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenRouterWebSearchServerTool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenRouterWebSearchServerTool).Name}");
                    openRouterWebSearchServerTool = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::OpenRouter.MessagesRequestToolsItems(
                messagesRequestToolsItems0,

                messagesRequestToolsItems1,

                messagesRequestToolsItems2,

                messagesRequestToolsItems3,

                messagesRequestToolsItems4,

                datetimeServerTool,

                imageGenerationServerToolOpenRouter,

                chatSearchModelsServerTool,

                openRouterWebSearchServerTool
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.MessagesRequestToolsItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessagesRequestToolsItems0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestToolsItems0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestToolsItems0?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesRequestToolsItems0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestToolsItems0!, typeInfo);
            }
            else if (value.IsMessagesRequestToolsItems1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestToolsItems1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestToolsItems1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesRequestToolsItems1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestToolsItems1!, typeInfo);
            }
            else if (value.IsMessagesRequestToolsItems2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestToolsItems2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestToolsItems2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesRequestToolsItems2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestToolsItems2!, typeInfo);
            }
            else if (value.IsMessagesRequestToolsItems3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestToolsItems3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestToolsItems3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesRequestToolsItems3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestToolsItems3!, typeInfo);
            }
            else if (value.IsMessagesRequestToolsItems4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesRequestToolsItems4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesRequestToolsItems4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesRequestToolsItems4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesRequestToolsItems4!, typeInfo);
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
            else if (value.IsOpenRouterWebSearchServerTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenRouterWebSearchServerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenRouterWebSearchServerTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenRouterWebSearchServerTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenRouterWebSearchServerTool!, typeInfo);
            }
        }
    }
}