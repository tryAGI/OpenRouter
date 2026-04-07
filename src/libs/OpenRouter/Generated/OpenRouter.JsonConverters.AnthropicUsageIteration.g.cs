#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class AnthropicUsageIterationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.AnthropicUsageIteration>
    {
        /// <inheritdoc />
        public override global::OpenRouter.AnthropicUsageIteration Read(
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
            if (__jsonProps.Contains("cache_creation")) __score0++;
            if (__jsonProps.Contains("cache_creation_input_tokens")) __score0++;
            if (__jsonProps.Contains("cache_read_input_tokens")) __score0++;
            if (__jsonProps.Contains("input_tokens")) __score0++;
            if (__jsonProps.Contains("output_tokens")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("cache_creation")) __score1++;
            if (__jsonProps.Contains("cache_creation_input_tokens")) __score1++;
            if (__jsonProps.Contains("cache_read_input_tokens")) __score1++;
            if (__jsonProps.Contains("input_tokens")) __score1++;
            if (__jsonProps.Contains("output_tokens")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("cache_creation")) __score2++;
            if (__jsonProps.Contains("cache_creation_input_tokens")) __score2++;
            if (__jsonProps.Contains("cache_read_input_tokens")) __score2++;
            if (__jsonProps.Contains("input_tokens")) __score2++;
            if (__jsonProps.Contains("output_tokens")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::OpenRouter.AnthropicCompactionUsageIteration? anthropicCompactionUsageIteration = default;
            global::OpenRouter.AnthropicMessageUsageIteration? anthropicMessageUsageIteration = default;
            global::OpenRouter.AnthropicUnknownUsageIteration? anthropicUnknownUsageIteration = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCompactionUsageIteration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCompactionUsageIteration> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicCompactionUsageIteration).Name}");
                        anthropicCompactionUsageIteration = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicMessageUsageIteration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicMessageUsageIteration> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicMessageUsageIteration).Name}");
                        anthropicMessageUsageIteration = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicUnknownUsageIteration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicUnknownUsageIteration> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicUnknownUsageIteration).Name}");
                        anthropicUnknownUsageIteration = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (anthropicCompactionUsageIteration == null && anthropicMessageUsageIteration == null && anthropicUnknownUsageIteration == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCompactionUsageIteration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCompactionUsageIteration> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicCompactionUsageIteration).Name}");
                    anthropicCompactionUsageIteration = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicMessageUsageIteration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicMessageUsageIteration> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicMessageUsageIteration).Name}");
                    anthropicMessageUsageIteration = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicUnknownUsageIteration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicUnknownUsageIteration> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicUnknownUsageIteration).Name}");
                    anthropicUnknownUsageIteration = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::OpenRouter.AnthropicUsageIteration(
                anthropicCompactionUsageIteration,

                anthropicMessageUsageIteration,

                anthropicUnknownUsageIteration
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.AnthropicUsageIteration value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAnthropicCompactionUsageIteration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicCompactionUsageIteration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicCompactionUsageIteration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicCompactionUsageIteration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnthropicCompactionUsageIteration!, typeInfo);
            }
            else if (value.IsAnthropicMessageUsageIteration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicMessageUsageIteration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicMessageUsageIteration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicMessageUsageIteration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnthropicMessageUsageIteration!, typeInfo);
            }
            else if (value.IsAnthropicUnknownUsageIteration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.AnthropicUnknownUsageIteration), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.AnthropicUnknownUsageIteration?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.AnthropicUnknownUsageIteration).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnthropicUnknownUsageIteration!, typeInfo);
            }
        }
    }
}