#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class STTInputAudioJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.STTInputAudio>
    {
        /// <inheritdoc />
        public override global::OpenRouter.STTInputAudio Read(
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
            if (__jsonProps.Contains("data")) __score0++;
            if (__jsonProps.Contains("format")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("format")) __score1++;
            if (__jsonProps.Contains("url")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::OpenRouter.STTInlineInputAudio? inline = default;
            global::OpenRouter.STTUrlInputAudio? url = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.STTInlineInputAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.STTInlineInputAudio> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.STTInlineInputAudio).Name}");
                        inline = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.STTUrlInputAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.STTUrlInputAudio> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.STTUrlInputAudio).Name}");
                        url = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (inline == null && url == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.STTInlineInputAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.STTInlineInputAudio> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.STTInlineInputAudio).Name}");
                    inline = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (inline == null && url == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.STTUrlInputAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.STTUrlInputAudio> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.STTUrlInputAudio).Name}");
                    url = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::OpenRouter.STTInputAudio(
                inline,

                url
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.STTInputAudio value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInline)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.STTInlineInputAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.STTInlineInputAudio?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.STTInlineInputAudio).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickInline(), typeInfo);
            }
            else if (value.IsUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.STTUrlInputAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.STTUrlInputAudio?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.STTUrlInputAudio).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickUrl(), typeInfo);
            }
        }
    }
}