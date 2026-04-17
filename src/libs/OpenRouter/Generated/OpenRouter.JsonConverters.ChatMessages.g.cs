#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class ChatMessagesJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.ChatMessages>
    {
        /// <inheritdoc />
        public override global::OpenRouter.ChatMessages Read(
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
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("role")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("content")) __score1++;
            if (__jsonProps.Contains("name")) __score1++;
            if (__jsonProps.Contains("role")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("content")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("role")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("audio")) __score3++;
            if (__jsonProps.Contains("audio.data")) __score3++;
            if (__jsonProps.Contains("audio.expires_at")) __score3++;
            if (__jsonProps.Contains("audio.id")) __score3++;
            if (__jsonProps.Contains("audio.transcript")) __score3++;
            if (__jsonProps.Contains("content")) __score3++;
            if (__jsonProps.Contains("images")) __score3++;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("reasoning")) __score3++;
            if (__jsonProps.Contains("reasoning_details")) __score3++;
            if (__jsonProps.Contains("refusal")) __score3++;
            if (__jsonProps.Contains("role")) __score3++;
            if (__jsonProps.Contains("tool_calls")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("content")) __score4++;
            if (__jsonProps.Contains("role")) __score4++;
            if (__jsonProps.Contains("tool_call_id")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::OpenRouter.ChatSystemMessage? chatSystemMessage = default;
            global::OpenRouter.ChatUserMessage? chatUserMessage = default;
            global::OpenRouter.ChatDeveloperMessage? chatDeveloperMessage = default;
            global::OpenRouter.ChatAssistantMessage? chatAssistantMessage = default;
            global::OpenRouter.ChatToolMessage? chatToolMessage = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatSystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatSystemMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatSystemMessage).Name}");
                        chatSystemMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatUserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatUserMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatUserMessage).Name}");
                        chatUserMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatDeveloperMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatDeveloperMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatDeveloperMessage).Name}");
                        chatDeveloperMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatAssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatAssistantMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatAssistantMessage).Name}");
                        chatAssistantMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatToolMessage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatToolMessage).Name}");
                        chatToolMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (chatSystemMessage == null && chatUserMessage == null && chatDeveloperMessage == null && chatAssistantMessage == null && chatToolMessage == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatSystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatSystemMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatSystemMessage).Name}");
                    chatSystemMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatUserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatUserMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatUserMessage).Name}");
                    chatUserMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatDeveloperMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatDeveloperMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatDeveloperMessage).Name}");
                    chatDeveloperMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatAssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatAssistantMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatAssistantMessage).Name}");
                    chatAssistantMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatToolMessage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatToolMessage).Name}");
                    chatToolMessage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::OpenRouter.ChatMessages(
                chatSystemMessage,

                chatUserMessage,

                chatDeveloperMessage,

                chatAssistantMessage,

                chatToolMessage
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.ChatMessages value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsChatSystemMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatSystemMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatSystemMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatSystemMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatSystemMessage!, typeInfo);
            }
            else if (value.IsChatUserMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatUserMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatUserMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatUserMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatUserMessage!, typeInfo);
            }
            else if (value.IsChatDeveloperMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatDeveloperMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatDeveloperMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatDeveloperMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatDeveloperMessage!, typeInfo);
            }
            else if (value.IsChatAssistantMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatAssistantMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatAssistantMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatAssistantMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatAssistantMessage!, typeInfo);
            }
            else if (value.IsChatToolMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatToolMessage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatToolMessage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatToolMessage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatToolMessage!, typeInfo);
            }
        }
    }
}