#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class ChatContentItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.ChatContentItems>
    {
        /// <inheritdoc />
        public override global::OpenRouter.ChatContentItems Read(
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
            if (__jsonProps.Contains("text")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("image_url")) __score1++;
            if (__jsonProps.Contains("image_url.detail")) __score1++;
            if (__jsonProps.Contains("image_url.url")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("input_audio")) __score2++;
            if (__jsonProps.Contains("input_audio.data")) __score2++;
            if (__jsonProps.Contains("input_audio.format")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("type")) __score3++;
            if (__jsonProps.Contains("video_url")) __score3++;
            if (__jsonProps.Contains("video_url.url")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("video_url")) __score4++;
            if (__jsonProps.Contains("video_url.url")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("file")) __score5++;
            if (__jsonProps.Contains("file.file_data")) __score5++;
            if (__jsonProps.Contains("file.file_id")) __score5++;
            if (__jsonProps.Contains("file.filename")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::OpenRouter.ChatContentText? chatContentText = default;
            global::OpenRouter.ChatContentImage? chatContentImage = default;
            global::OpenRouter.ChatContentAudio? chatContentAudio = default;
            global::OpenRouter.LegacyChatContentVideo? legacyChatContentVideo = default;
            global::OpenRouter.ChatContentVideo? chatContentVideo = default;
            global::OpenRouter.ChatContentFile? chatContentFile = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatContentText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatContentText> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatContentText).Name}");
                        chatContentText = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatContentImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatContentImage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatContentImage).Name}");
                        chatContentImage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatContentAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatContentAudio> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatContentAudio).Name}");
                        chatContentAudio = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.LegacyChatContentVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.LegacyChatContentVideo> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.LegacyChatContentVideo).Name}");
                        legacyChatContentVideo = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatContentVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatContentVideo> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatContentVideo).Name}");
                        chatContentVideo = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatContentFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatContentFile> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatContentFile).Name}");
                        chatContentFile = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (chatContentText == null && chatContentImage == null && chatContentAudio == null && legacyChatContentVideo == null && chatContentVideo == null && chatContentFile == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatContentText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatContentText> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatContentText).Name}");
                    chatContentText = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatContentImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatContentImage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatContentImage).Name}");
                    chatContentImage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatContentAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatContentAudio> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatContentAudio).Name}");
                    chatContentAudio = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.LegacyChatContentVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.LegacyChatContentVideo> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.LegacyChatContentVideo).Name}");
                    legacyChatContentVideo = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatContentVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatContentVideo> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatContentVideo).Name}");
                    chatContentVideo = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatContentFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatContentFile> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatContentFile).Name}");
                    chatContentFile = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::OpenRouter.ChatContentItems(
                chatContentText,

                chatContentImage,

                chatContentAudio,

                legacyChatContentVideo,

                chatContentVideo,

                chatContentFile
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.ChatContentItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsChatContentText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatContentText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatContentText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatContentText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatContentText!, typeInfo);
            }
            else if (value.IsChatContentImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatContentImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatContentImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatContentImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatContentImage!, typeInfo);
            }
            else if (value.IsChatContentAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatContentAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatContentAudio?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatContentAudio).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatContentAudio!, typeInfo);
            }
            else if (value.IsLegacyChatContentVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.LegacyChatContentVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.LegacyChatContentVideo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.LegacyChatContentVideo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LegacyChatContentVideo!, typeInfo);
            }
            else if (value.IsChatContentVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatContentVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatContentVideo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatContentVideo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatContentVideo!, typeInfo);
            }
            else if (value.IsChatContentFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ChatContentFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ChatContentFile?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ChatContentFile).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatContentFile!, typeInfo);
            }
        }
    }
}