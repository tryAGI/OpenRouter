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
            if (__jsonProps.Contains("cache_control")) __score0++;
            if (__jsonProps.Contains("text")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("image_url")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("input_audio")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            var __score4 = 0;
            if (__jsonProps.Contains("file")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::OpenRouter.ChatContentText? chatContentText = default;
            global::OpenRouter.ChatContentImage? chatContentImage = default;
            global::OpenRouter.ChatContentAudio? chatContentAudio = default;
            global::OpenRouter.ChatContentItems3? chatContentItems3 = default;
            global::OpenRouter.ChatContentFile? chatContentFile = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        chatContentText = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.ChatContentText>(__rawJson, options);
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
                        chatContentImage = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.ChatContentImage>(__rawJson, options);
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
                        chatContentAudio = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.ChatContentAudio>(__rawJson, options);
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
                        chatContentItems3 = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.ChatContentItems3>(__rawJson, options);
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
                        chatContentFile = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.ChatContentFile>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (chatContentText == null && chatContentImage == null && chatContentAudio == null && chatContentItems3 == null && chatContentFile == null)
            {
                try
                {
                    chatContentText = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.ChatContentText>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    chatContentImage = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.ChatContentImage>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    chatContentAudio = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.ChatContentAudio>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    chatContentItems3 = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.ChatContentItems3>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    chatContentFile = global::System.Text.Json.JsonSerializer.Deserialize<global::OpenRouter.ChatContentFile>(__rawJson, options);
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

                chatContentItems3,

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

            if (value.IsChatContentText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatContentText, typeof(global::OpenRouter.ChatContentText), options);
            }
            else if (value.IsChatContentImage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatContentImage, typeof(global::OpenRouter.ChatContentImage), options);
            }
            else if (value.IsChatContentAudio)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatContentAudio, typeof(global::OpenRouter.ChatContentAudio), options);
            }
            else if (value.IsChatContentItems3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatContentItems3, typeof(global::OpenRouter.ChatContentItems3), options);
            }
            else if (value.IsChatContentFile)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatContentFile, typeof(global::OpenRouter.ChatContentFile), options);
            }
        }
    }
}