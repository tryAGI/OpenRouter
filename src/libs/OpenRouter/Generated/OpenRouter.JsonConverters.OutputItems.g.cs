#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class OutputItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.OutputItems>
    {
        /// <inheritdoc />
        public override global::OpenRouter.OutputItems Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputItemsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.OutputItemsVariant1? codeInterpreterCall = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.CodeInterpreterCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputItemsVariant1)}");
                codeInterpreterCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputItemsVariant2? computerCall = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.ComputerCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputItemsVariant2)}");
                computerCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputItemsVariant3? customToolCall = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.CustomToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputItemsVariant3)}");
                customToolCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputItemsVariant4? fileSearchCall = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.FileSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputItemsVariant4)}");
                fileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputItemsVariant5? functionCall = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.FunctionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputItemsVariant5)}");
                functionCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputItemsVariant6? imageGenerationCall = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.ImageGenerationCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputItemsVariant6)}");
                imageGenerationCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputItemsVariant7? message = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Message)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputItemsVariant7)}");
                message = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputItemsVariant8? openrouterApplyPatch = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_applyPatch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputItemsVariant8)}");
                openrouterApplyPatch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputItemsVariant9? openrouterBash = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_bash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputItemsVariant9)}");
                openrouterBash = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputItemsVariant10? openrouterBrowserUse = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_browserUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputItemsVariant10)}");
                openrouterBrowserUse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputItemsVariant11? openrouterCodeInterpreter = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_codeInterpreter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant11> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputItemsVariant11)}");
                openrouterCodeInterpreter = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputItemsVariant12? openrouterDatetime = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_datetime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant12> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputItemsVariant12)}");
                openrouterDatetime = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputItemsVariant13? openrouterExperimentalSearchModels = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_experimentalSearchModels)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant13> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputItemsVariant13)}");
                openrouterExperimentalSearchModels = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputItemsVariant14? openrouterFileSearch = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_fileSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant14> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputItemsVariant14)}");
                openrouterFileSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputItemsVariant15? openrouterImageGeneration = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_imageGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant15> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputItemsVariant15)}");
                openrouterImageGeneration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputItemsVariant16? openrouterMcp = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_mcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant16> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputItemsVariant16)}");
                openrouterMcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputItemsVariant17? openrouterMemory = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_memory)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant17> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputItemsVariant17)}");
                openrouterMemory = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputItemsVariant18? openrouterTextEditor = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_textEditor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant18> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputItemsVariant18)}");
                openrouterTextEditor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputItemsVariant19? openrouterToolSearch = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_toolSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant19> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputItemsVariant19)}");
                openrouterToolSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputItemsVariant20? openrouterWebFetch = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_webFetch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant20), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant20> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputItemsVariant20)}");
                openrouterWebFetch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputItemsVariant21? openrouterWebSearch = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_webSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant21), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant21> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputItemsVariant21)}");
                openrouterWebSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputItemsVariant22? reasoning = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Reasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant22), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant22> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputItemsVariant22)}");
                reasoning = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputItemsVariant23? webSearchCall = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.WebSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant23), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant23> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputItemsVariant23)}");
                webSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.OutputItems(
                discriminator?.Type,
                codeInterpreterCall,

                computerCall,

                customToolCall,

                fileSearchCall,

                functionCall,

                imageGenerationCall,

                message,

                openrouterApplyPatch,

                openrouterBash,

                openrouterBrowserUse,

                openrouterCodeInterpreter,

                openrouterDatetime,

                openrouterExperimentalSearchModels,

                openrouterFileSearch,

                openrouterImageGeneration,

                openrouterMcp,

                openrouterMemory,

                openrouterTextEditor,

                openrouterToolSearch,

                openrouterWebFetch,

                openrouterWebSearch,

                reasoning,

                webSearchCall
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.OutputItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCodeInterpreterCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeInterpreterCall!, typeInfo);
            }
            else if (value.IsComputerCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComputerCall!, typeInfo);
            }
            else if (value.IsCustomToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomToolCall!, typeInfo);
            }
            else if (value.IsFileSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchCall!, typeInfo);
            }
            else if (value.IsFunctionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FunctionCall!, typeInfo);
            }
            else if (value.IsImageGenerationCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageGenerationCall!, typeInfo);
            }
            else if (value.IsMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Message!, typeInfo);
            }
            else if (value.IsOpenrouterApplyPatch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenrouterApplyPatch!, typeInfo);
            }
            else if (value.IsOpenrouterBash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant9?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenrouterBash!, typeInfo);
            }
            else if (value.IsOpenrouterBrowserUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant10?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenrouterBrowserUse!, typeInfo);
            }
            else if (value.IsOpenrouterCodeInterpreter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant11?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenrouterCodeInterpreter!, typeInfo);
            }
            else if (value.IsOpenrouterDatetime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant12?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenrouterDatetime!, typeInfo);
            }
            else if (value.IsOpenrouterExperimentalSearchModels)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant13?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant13).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenrouterExperimentalSearchModels!, typeInfo);
            }
            else if (value.IsOpenrouterFileSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant14), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant14?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant14).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenrouterFileSearch!, typeInfo);
            }
            else if (value.IsOpenrouterImageGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant15), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant15?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant15).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenrouterImageGeneration!, typeInfo);
            }
            else if (value.IsOpenrouterMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant16), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant16?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant16).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenrouterMcp!, typeInfo);
            }
            else if (value.IsOpenrouterMemory)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant17), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant17?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant17).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenrouterMemory!, typeInfo);
            }
            else if (value.IsOpenrouterTextEditor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant18), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant18?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant18).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenrouterTextEditor!, typeInfo);
            }
            else if (value.IsOpenrouterToolSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant19), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant19?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant19).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenrouterToolSearch!, typeInfo);
            }
            else if (value.IsOpenrouterWebFetch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant20), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant20?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant20).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenrouterWebFetch!, typeInfo);
            }
            else if (value.IsOpenrouterWebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant21), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant21?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant21).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenrouterWebSearch!, typeInfo);
            }
            else if (value.IsReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant22), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant22?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant22).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Reasoning!, typeInfo);
            }
            else if (value.IsWebSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputItemsVariant23), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputItemsVariant23?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputItemsVariant23).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchCall!, typeInfo);
            }
        }
    }
}