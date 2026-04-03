#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1ItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items>
    {
        /// <inheritdoc />
        public override global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items Read(
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
            if (__jsonProps.Contains("cache_control")) __score0++;
            if (__jsonProps.Contains("citations")) __score0++;
            if (__jsonProps.Contains("text")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("cache_control")) __score1++;
            if (__jsonProps.Contains("source")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::OpenRouter.AnthropicTextBlockParam? anthropicTextBlockParam = default;
            global::OpenRouter.AnthropicImageBlockParam? anthropicImageBlockParam = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextBlockParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextBlockParam> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicTextBlockParam).Name}");
                        anthropicTextBlockParam = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicImageBlockParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicImageBlockParam> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicImageBlockParam).Name}");
                        anthropicImageBlockParam = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (anthropicTextBlockParam == null && anthropicImageBlockParam == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextBlockParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextBlockParam> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicTextBlockParam).Name}");
                    anthropicTextBlockParam = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicImageBlockParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicImageBlockParam> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicImageBlockParam).Name}");
                    anthropicImageBlockParam = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items(
                anthropicTextBlockParam,

                anthropicImageBlockParam
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.AnthropicDocumentBlockParamSourceOneOf2ContentOneOf1Items value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAnthropicTextBlockParam)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicTextBlockParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicTextBlockParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicTextBlockParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnthropicTextBlockParam!, typeInfo);
            }
            else if (value.IsAnthropicImageBlockParam)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicImageBlockParam), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicImageBlockParam?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicImageBlockParam).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnthropicImageBlockParam!, typeInfo);
            }
        }
    }
}