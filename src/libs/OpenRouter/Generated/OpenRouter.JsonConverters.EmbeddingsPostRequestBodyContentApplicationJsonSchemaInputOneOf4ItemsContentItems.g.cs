#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems>
    {
        /// <inheritdoc />
        public override global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems Read(
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
            if (__jsonProps.Contains("text")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("image_url")) __score1++;
            if (__jsonProps.Contains("image_url.url")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("input_audio")) __score2++;
            if (__jsonProps.Contains("input_audio.data")) __score2++;
            if (__jsonProps.Contains("input_audio.format")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("input_video")) __score3++;
            if (__jsonProps.Contains("input_video.data")) __score3++;
            if (__jsonProps.Contains("input_video.format")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("input_file")) __score4++;
            if (__jsonProps.Contains("input_file.data")) __score4++;
            if (__jsonProps.Contains("input_file.format")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 = default;
            global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1? embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 = default;
            global::OpenRouter.ContentPartInputAudio? contentPartInputAudio = default;
            global::OpenRouter.ContentPartInputVideo? contentPartInputVideo = default;
            global::OpenRouter.ContentPartInputFile? contentPartInputFile = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0).Name}");
                        embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1).Name}");
                        embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ContentPartInputAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ContentPartInputAudio> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ContentPartInputAudio).Name}");
                        contentPartInputAudio = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ContentPartInputVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ContentPartInputVideo> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ContentPartInputVideo).Name}");
                        contentPartInputVideo = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ContentPartInputFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ContentPartInputFile> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ContentPartInputFile).Name}");
                        contentPartInputFile = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 == null && embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 == null && contentPartInputAudio == null && contentPartInputVideo == null && contentPartInputFile == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0).Name}");
                    embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 == null && embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 == null && contentPartInputAudio == null && contentPartInputVideo == null && contentPartInputFile == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1).Name}");
                    embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 == null && embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 == null && contentPartInputAudio == null && contentPartInputVideo == null && contentPartInputFile == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ContentPartInputAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ContentPartInputAudio> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ContentPartInputAudio).Name}");
                    contentPartInputAudio = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 == null && embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 == null && contentPartInputAudio == null && contentPartInputVideo == null && contentPartInputFile == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ContentPartInputVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ContentPartInputVideo> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ContentPartInputVideo).Name}");
                    contentPartInputVideo = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0 == null && embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1 == null && contentPartInputAudio == null && contentPartInputVideo == null && contentPartInputFile == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ContentPartInputFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ContentPartInputFile> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ContentPartInputFile).Name}");
                    contentPartInputFile = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems(
                embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0,

                embeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1,

                contentPartInputAudio,

                contentPartInputVideo,

                contentPartInputFile
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems0!, typeInfo);
            }
            else if (value.IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf4ItemsContentItems1!, typeInfo);
            }
            else if (value.IsContentPartInputAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ContentPartInputAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ContentPartInputAudio?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ContentPartInputAudio).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentPartInputAudio!, typeInfo);
            }
            else if (value.IsContentPartInputVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ContentPartInputVideo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ContentPartInputVideo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ContentPartInputVideo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentPartInputVideo!, typeInfo);
            }
            else if (value.IsContentPartInputFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ContentPartInputFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ContentPartInputFile?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ContentPartInputFile).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContentPartInputFile!, typeInfo);
            }
        }
    }
}