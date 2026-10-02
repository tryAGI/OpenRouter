#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class OpenAIResponsesToolChoiceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.OpenAIResponsesToolChoice>
    {
        /// <inheritdoc />
        public override global::OpenRouter.OpenAIResponsesToolChoice Read(
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
            var __score1 = 0;
            var __score2 = 0;
            var __score3 = 0;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("mode")) __score5++;
            if (__jsonProps.Contains("tools")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("type")) __score7++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }

            global::OpenRouter.OpenAIResponsesToolChoiceVariant1? openAIResponsesToolChoiceVariant1 = default;
            global::OpenRouter.OpenAIResponsesToolChoiceVariant2? openAIResponsesToolChoiceVariant2 = default;
            global::OpenRouter.OpenAIResponsesToolChoiceVariant3? openAIResponsesToolChoiceVariant3 = default;
            global::OpenRouter.OpenAIResponsesToolChoiceVariant4? openAIResponsesToolChoiceVariant4 = default;
            global::OpenRouter.OpenAIResponsesToolChoiceVariant5? openAIResponsesToolChoiceVariant5 = default;
            global::OpenRouter.ToolChoiceAllowed? allowed = default;
            global::OpenRouter.OpenAIResponsesToolChoiceVariant7? openAIResponsesToolChoiceVariant7 = default;
            global::OpenRouter.OpenAIResponsesToolChoiceVariant8? openAIResponsesToolChoiceVariant8 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenAIResponsesToolChoiceVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant1).Name}");
                        openAIResponsesToolChoiceVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenAIResponsesToolChoiceVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant2).Name}");
                        openAIResponsesToolChoiceVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenAIResponsesToolChoiceVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant3).Name}");
                        openAIResponsesToolChoiceVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenAIResponsesToolChoiceVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant4).Name}");
                        openAIResponsesToolChoiceVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenAIResponsesToolChoiceVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant5).Name}");
                        openAIResponsesToolChoiceVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ToolChoiceAllowed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ToolChoiceAllowed> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ToolChoiceAllowed).Name}");
                        allowed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenAIResponsesToolChoiceVariant7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant7).Name}");
                        openAIResponsesToolChoiceVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenAIResponsesToolChoiceVariant8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant8).Name}");
                        openAIResponsesToolChoiceVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (openAIResponsesToolChoiceVariant1 == null && openAIResponsesToolChoiceVariant2 == null && openAIResponsesToolChoiceVariant3 == null && openAIResponsesToolChoiceVariant4 == null && openAIResponsesToolChoiceVariant5 == null && allowed == null && openAIResponsesToolChoiceVariant7 == null && openAIResponsesToolChoiceVariant8 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenAIResponsesToolChoiceVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant1).Name}");
                    openAIResponsesToolChoiceVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (openAIResponsesToolChoiceVariant1 == null && openAIResponsesToolChoiceVariant2 == null && openAIResponsesToolChoiceVariant3 == null && openAIResponsesToolChoiceVariant4 == null && openAIResponsesToolChoiceVariant5 == null && allowed == null && openAIResponsesToolChoiceVariant7 == null && openAIResponsesToolChoiceVariant8 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenAIResponsesToolChoiceVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant2).Name}");
                    openAIResponsesToolChoiceVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (openAIResponsesToolChoiceVariant1 == null && openAIResponsesToolChoiceVariant2 == null && openAIResponsesToolChoiceVariant3 == null && openAIResponsesToolChoiceVariant4 == null && openAIResponsesToolChoiceVariant5 == null && allowed == null && openAIResponsesToolChoiceVariant7 == null && openAIResponsesToolChoiceVariant8 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenAIResponsesToolChoiceVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant3).Name}");
                    openAIResponsesToolChoiceVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (openAIResponsesToolChoiceVariant1 == null && openAIResponsesToolChoiceVariant2 == null && openAIResponsesToolChoiceVariant3 == null && openAIResponsesToolChoiceVariant4 == null && openAIResponsesToolChoiceVariant5 == null && allowed == null && openAIResponsesToolChoiceVariant7 == null && openAIResponsesToolChoiceVariant8 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenAIResponsesToolChoiceVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant4).Name}");
                    openAIResponsesToolChoiceVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (openAIResponsesToolChoiceVariant1 == null && openAIResponsesToolChoiceVariant2 == null && openAIResponsesToolChoiceVariant3 == null && openAIResponsesToolChoiceVariant4 == null && openAIResponsesToolChoiceVariant5 == null && allowed == null && openAIResponsesToolChoiceVariant7 == null && openAIResponsesToolChoiceVariant8 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenAIResponsesToolChoiceVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant5).Name}");
                    openAIResponsesToolChoiceVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (openAIResponsesToolChoiceVariant1 == null && openAIResponsesToolChoiceVariant2 == null && openAIResponsesToolChoiceVariant3 == null && openAIResponsesToolChoiceVariant4 == null && openAIResponsesToolChoiceVariant5 == null && allowed == null && openAIResponsesToolChoiceVariant7 == null && openAIResponsesToolChoiceVariant8 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ToolChoiceAllowed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ToolChoiceAllowed> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ToolChoiceAllowed).Name}");
                    allowed = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (openAIResponsesToolChoiceVariant1 == null && openAIResponsesToolChoiceVariant2 == null && openAIResponsesToolChoiceVariant3 == null && openAIResponsesToolChoiceVariant4 == null && openAIResponsesToolChoiceVariant5 == null && allowed == null && openAIResponsesToolChoiceVariant7 == null && openAIResponsesToolChoiceVariant8 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenAIResponsesToolChoiceVariant7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant7).Name}");
                    openAIResponsesToolChoiceVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (openAIResponsesToolChoiceVariant1 == null && openAIResponsesToolChoiceVariant2 == null && openAIResponsesToolChoiceVariant3 == null && openAIResponsesToolChoiceVariant4 == null && openAIResponsesToolChoiceVariant5 == null && allowed == null && openAIResponsesToolChoiceVariant7 == null && openAIResponsesToolChoiceVariant8 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenAIResponsesToolChoiceVariant8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant8).Name}");
                    openAIResponsesToolChoiceVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::OpenRouter.OpenAIResponsesToolChoice(
                openAIResponsesToolChoiceVariant1,

                openAIResponsesToolChoiceVariant2,

                openAIResponsesToolChoiceVariant3,

                openAIResponsesToolChoiceVariant4,

                openAIResponsesToolChoiceVariant5,

                allowed,

                openAIResponsesToolChoiceVariant7,

                openAIResponsesToolChoiceVariant8
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.OpenAIResponsesToolChoice value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOpenAIResponsesToolChoiceVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenAIResponsesToolChoiceVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenAIResponsesToolChoiceVariant1(), typeInfo);
            }
            else if (value.IsOpenAIResponsesToolChoiceVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenAIResponsesToolChoiceVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenAIResponsesToolChoiceVariant2(), typeInfo);
            }
            else if (value.IsOpenAIResponsesToolChoiceVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenAIResponsesToolChoiceVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenAIResponsesToolChoiceVariant3(), typeInfo);
            }
            else if (value.IsOpenAIResponsesToolChoiceVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenAIResponsesToolChoiceVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenAIResponsesToolChoiceVariant4(), typeInfo);
            }
            else if (value.IsOpenAIResponsesToolChoiceVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenAIResponsesToolChoiceVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenAIResponsesToolChoiceVariant5(), typeInfo);
            }
            else if (value.IsAllowed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ToolChoiceAllowed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ToolChoiceAllowed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ToolChoiceAllowed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAllowed(), typeInfo);
            }
            else if (value.IsOpenAIResponsesToolChoiceVariant7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenAIResponsesToolChoiceVariant7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenAIResponsesToolChoiceVariant7(), typeInfo);
            }
            else if (value.IsOpenAIResponsesToolChoiceVariant8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OpenAIResponsesToolChoiceVariant8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenAIResponsesToolChoiceVariant8(), typeInfo);
            }
        }
    }
}