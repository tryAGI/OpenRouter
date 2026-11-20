#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class SpeechInputModalityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.SpeechInputModality>
    {
        /// <inheritdoc />
        public override global::OpenRouter.SpeechInputModality Read(
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
            if (__jsonProps.Contains("turns")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("supported_inputs")) __score1++;
            if (__jsonProps.Contains("supported_inputs.references")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("supported_inputs")) __score2++;
            if (__jsonProps.Contains("supported_inputs.audio")) __score2++;
            if (__jsonProps.Contains("supported_inputs.references")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::OpenRouter.SpeechInputModalityVariant1? speechInputModalityVariant1 = default;
            global::OpenRouter.SpeechInputModalityVariant2? speechInputModalityVariant2 = default;
            global::OpenRouter.SpeechInputModalityVariant3? speechInputModalityVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.SpeechInputModalityVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.SpeechInputModalityVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.SpeechInputModalityVariant1).Name}");
                        speechInputModalityVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.SpeechInputModalityVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.SpeechInputModalityVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.SpeechInputModalityVariant2).Name}");
                        speechInputModalityVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.SpeechInputModalityVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.SpeechInputModalityVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.SpeechInputModalityVariant3).Name}");
                        speechInputModalityVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                    catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                    {
                        // Legacy enum converters signal an incompatible JSON token with this exception.
                    }
                }
            }

            if (speechInputModalityVariant1 == null && speechInputModalityVariant2 == null && speechInputModalityVariant3 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.SpeechInputModalityVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.SpeechInputModalityVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.SpeechInputModalityVariant1).Name}");
                    speechInputModalityVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (speechInputModalityVariant1 == null && speechInputModalityVariant2 == null && speechInputModalityVariant3 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.SpeechInputModalityVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.SpeechInputModalityVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.SpeechInputModalityVariant2).Name}");
                    speechInputModalityVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            if (speechInputModalityVariant1 == null && speechInputModalityVariant2 == null && speechInputModalityVariant3 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.SpeechInputModalityVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.SpeechInputModalityVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.SpeechInputModalityVariant3).Name}");
                    speechInputModalityVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
                catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
                {
                    // Legacy enum converters signal an incompatible JSON token with this exception.
                }
            }

            var __value = new global::OpenRouter.SpeechInputModality(
                speechInputModalityVariant1,

                speechInputModalityVariant2,

                speechInputModalityVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.SpeechInputModality value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSpeechInputModalityVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.SpeechInputModalityVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.SpeechInputModalityVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.SpeechInputModalityVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSpeechInputModalityVariant1(), typeInfo);
            }
            else if (value.IsSpeechInputModalityVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.SpeechInputModalityVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.SpeechInputModalityVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.SpeechInputModalityVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSpeechInputModalityVariant2(), typeInfo);
            }
            else if (value.IsSpeechInputModalityVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.SpeechInputModalityVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.SpeechInputModalityVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.SpeechInputModalityVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSpeechInputModalityVariant3(), typeInfo);
            }
        }
    }
}