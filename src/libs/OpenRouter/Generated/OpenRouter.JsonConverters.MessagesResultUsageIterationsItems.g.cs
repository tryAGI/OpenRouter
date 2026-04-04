#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class MessagesResultUsageIterationsItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.MessagesResultUsageIterationsItems>
    {
        /// <inheritdoc />
        public override global::OpenRouter.MessagesResultUsageIterationsItems Read(
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

            global::OpenRouter.MessagesResultUsageIterationsItems0? messagesResultUsageIterationsItems0 = default;
            global::OpenRouter.MessagesResultUsageIterationsItems1? messagesResultUsageIterationsItems1 = default;
            global::OpenRouter.MessagesResultUsageIterationsItems2? messagesResultUsageIterationsItems2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesResultUsageIterationsItems0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesResultUsageIterationsItems0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesResultUsageIterationsItems0).Name}");
                        messagesResultUsageIterationsItems0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesResultUsageIterationsItems1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesResultUsageIterationsItems1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesResultUsageIterationsItems1).Name}");
                        messagesResultUsageIterationsItems1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesResultUsageIterationsItems2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesResultUsageIterationsItems2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesResultUsageIterationsItems2).Name}");
                        messagesResultUsageIterationsItems2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (messagesResultUsageIterationsItems0 == null && messagesResultUsageIterationsItems1 == null && messagesResultUsageIterationsItems2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesResultUsageIterationsItems0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesResultUsageIterationsItems0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesResultUsageIterationsItems0).Name}");
                    messagesResultUsageIterationsItems0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesResultUsageIterationsItems1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesResultUsageIterationsItems1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesResultUsageIterationsItems1).Name}");
                    messagesResultUsageIterationsItems1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesResultUsageIterationsItems2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesResultUsageIterationsItems2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesResultUsageIterationsItems2).Name}");
                    messagesResultUsageIterationsItems2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::OpenRouter.MessagesResultUsageIterationsItems(
                messagesResultUsageIterationsItems0,

                messagesResultUsageIterationsItems1,

                messagesResultUsageIterationsItems2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.MessagesResultUsageIterationsItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessagesResultUsageIterationsItems0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesResultUsageIterationsItems0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesResultUsageIterationsItems0?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesResultUsageIterationsItems0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesResultUsageIterationsItems0!, typeInfo);
            }
            else if (value.IsMessagesResultUsageIterationsItems1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesResultUsageIterationsItems1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesResultUsageIterationsItems1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesResultUsageIterationsItems1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesResultUsageIterationsItems1!, typeInfo);
            }
            else if (value.IsMessagesResultUsageIterationsItems2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.MessagesResultUsageIterationsItems2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.MessagesResultUsageIterationsItems2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.MessagesResultUsageIterationsItems2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessagesResultUsageIterationsItems2!, typeInfo);
            }
        }
    }
}