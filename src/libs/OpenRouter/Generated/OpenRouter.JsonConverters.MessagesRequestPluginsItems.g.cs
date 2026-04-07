#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class MessagesRequestPluginsItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.MessagesRequestPluginsItems>
    {
        /// <inheritdoc />
        public override global::OpenRouter.MessagesRequestPluginsItems Read(
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
            if (__jsonProps.Contains("allowed_models")) __score0++;
            if (__jsonProps.Contains("enabled")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("id")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("enabled")) __score2++;
            if (__jsonProps.Contains("engine")) __score2++;
            if (__jsonProps.Contains("exclude_domains")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("include_domains")) __score2++;
            if (__jsonProps.Contains("max_results")) __score2++;
            if (__jsonProps.Contains("search_prompt")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("enabled")) __score3++;
            if (__jsonProps.Contains("id")) __score3++;
            if (__jsonProps.Contains("pdf")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("enabled")) __score4++;
            if (__jsonProps.Contains("id")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("enabled")) __score5++;
            if (__jsonProps.Contains("engine")) __score5++;
            if (__jsonProps.Contains("id")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::OpenRouter.AutoRouterPlugin? autoRouterPlugin = default;
            global::OpenRouter.ModerationPlugin? moderationPlugin = default;
            global::OpenRouter.WebSearchPlugin? webSearchPlugin = default;
            global::OpenRouter.FileParserPlugin? fileParserPlugin = default;
            global::OpenRouter.ResponseHealingPlugin? responseHealingPlugin = default;
            global::OpenRouter.ContextCompressionPlugin? contextCompressionPlugin = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AutoRouterPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AutoRouterPlugin> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AutoRouterPlugin).Name}");
                        autoRouterPlugin = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModerationPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModerationPlugin> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModerationPlugin).Name}");
                        moderationPlugin = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.WebSearchPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.WebSearchPlugin> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.WebSearchPlugin).Name}");
                        webSearchPlugin = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FileParserPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FileParserPlugin> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FileParserPlugin).Name}");
                        fileParserPlugin = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponseHealingPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponseHealingPlugin> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ResponseHealingPlugin).Name}");
                        responseHealingPlugin = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ContextCompressionPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ContextCompressionPlugin> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ContextCompressionPlugin).Name}");
                        contextCompressionPlugin = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (autoRouterPlugin == null && moderationPlugin == null && webSearchPlugin == null && fileParserPlugin == null && responseHealingPlugin == null && contextCompressionPlugin == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AutoRouterPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AutoRouterPlugin> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AutoRouterPlugin).Name}");
                    autoRouterPlugin = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModerationPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModerationPlugin> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModerationPlugin).Name}");
                    moderationPlugin = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.WebSearchPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.WebSearchPlugin> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.WebSearchPlugin).Name}");
                    webSearchPlugin = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FileParserPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FileParserPlugin> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FileParserPlugin).Name}");
                    fileParserPlugin = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponseHealingPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponseHealingPlugin> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ResponseHealingPlugin).Name}");
                    responseHealingPlugin = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ContextCompressionPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ContextCompressionPlugin> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ContextCompressionPlugin).Name}");
                    contextCompressionPlugin = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::OpenRouter.MessagesRequestPluginsItems(
                autoRouterPlugin,

                moderationPlugin,

                webSearchPlugin,

                fileParserPlugin,

                responseHealingPlugin,

                contextCompressionPlugin
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.MessagesRequestPluginsItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAutoRouterPlugin)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AutoRouterPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AutoRouterPlugin?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AutoRouterPlugin).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AutoRouterPlugin!, typeInfo);
            }
            else if (value.IsModerationPlugin)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ModerationPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ModerationPlugin?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ModerationPlugin).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModerationPlugin!, typeInfo);
            }
            else if (value.IsWebSearchPlugin)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.WebSearchPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.WebSearchPlugin?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.WebSearchPlugin).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchPlugin!, typeInfo);
            }
            else if (value.IsFileParserPlugin)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FileParserPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FileParserPlugin?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FileParserPlugin).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileParserPlugin!, typeInfo);
            }
            else if (value.IsResponseHealingPlugin)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ResponseHealingPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ResponseHealingPlugin?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ResponseHealingPlugin).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResponseHealingPlugin!, typeInfo);
            }
            else if (value.IsContextCompressionPlugin)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ContextCompressionPlugin), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ContextCompressionPlugin?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ContextCompressionPlugin).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContextCompressionPlugin!, typeInfo);
            }
        }
    }
}