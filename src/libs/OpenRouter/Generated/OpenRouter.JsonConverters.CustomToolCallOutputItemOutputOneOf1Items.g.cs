#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class CustomToolCallOutputItemOutputOneOf1ItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1Items>
    {
        /// <inheritdoc />
        public override global::OpenRouter.CustomToolCallOutputItemOutputOneOf1Items Read(
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
            if (__jsonProps.Contains("file_data")) __score0++;
            if (__jsonProps.Contains("file_id")) __score0++;
            if (__jsonProps.Contains("file_url")) __score0++;
            if (__jsonProps.Contains("filename")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("detail")) __score1++;
            if (__jsonProps.Contains("image_url")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("text")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant1? inputFile = default;
            global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant2? inputImage = default;
            global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant3? inputText = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant1).Name}");
                        inputFile = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant2).Name}");
                        inputImage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant3).Name}");
                        inputText = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (inputFile == null && inputImage == null && inputText == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant1).Name}");
                    inputFile = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant2).Name}");
                    inputImage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant3).Name}");
                    inputText = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::OpenRouter.CustomToolCallOutputItemOutputOneOf1Items(
                inputFile,

                inputImage,

                inputText
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.CustomToolCallOutputItemOutputOneOf1Items value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsInputFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputFile!, typeInfo);
            }
            else if (value.IsInputImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputImage!, typeInfo);
            }
            else if (value.IsInputText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.CustomToolCallOutputItemOutputOneOf1ItemsVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputText!, typeInfo);
            }
        }
    }
}