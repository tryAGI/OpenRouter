#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class FormatsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.Formats>
    {
        /// <inheritdoc />
        public override global::OpenRouter.Formats Read(
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
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("description")) __score2++;
            if (__jsonProps.Contains("name")) __score2++;
            if (__jsonProps.Contains("schema")) __score2++;
            if (__jsonProps.Contains("strict")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::OpenRouter.FormatTextConfig? formatTextConfig = default;
            global::OpenRouter.FormatJsonObjectConfig? formatJsonObjectConfig = default;
            global::OpenRouter.FormatJsonSchemaConfig? formatJsonSchemaConfig = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FormatTextConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FormatTextConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FormatTextConfig).Name}");
                        formatTextConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FormatJsonObjectConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FormatJsonObjectConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FormatJsonObjectConfig).Name}");
                        formatJsonObjectConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FormatJsonSchemaConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FormatJsonSchemaConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FormatJsonSchemaConfig).Name}");
                        formatJsonSchemaConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (formatTextConfig == null && formatJsonObjectConfig == null && formatJsonSchemaConfig == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FormatTextConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FormatTextConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FormatTextConfig).Name}");
                    formatTextConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FormatJsonObjectConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FormatJsonObjectConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FormatJsonObjectConfig).Name}");
                    formatJsonObjectConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FormatJsonSchemaConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FormatJsonSchemaConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FormatJsonSchemaConfig).Name}");
                    formatJsonSchemaConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::OpenRouter.Formats(
                formatTextConfig,

                formatJsonObjectConfig,

                formatJsonSchemaConfig
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.Formats value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFormatTextConfig)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FormatTextConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FormatTextConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FormatTextConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FormatTextConfig!, typeInfo);
            }
            else if (value.IsFormatJsonObjectConfig)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FormatJsonObjectConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FormatJsonObjectConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FormatJsonObjectConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FormatJsonObjectConfig!, typeInfo);
            }
            else if (value.IsFormatJsonSchemaConfig)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.FormatJsonSchemaConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.FormatJsonSchemaConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.FormatJsonSchemaConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FormatJsonSchemaConfig!, typeInfo);
            }
        }
    }
}