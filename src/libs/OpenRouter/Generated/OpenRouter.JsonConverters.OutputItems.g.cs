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

            global::OpenRouter.OutputMessageItem? message = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Message)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputMessageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputMessageItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputMessageItem)}");
                message = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputReasoningItem? reasoning = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Reasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputReasoningItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputReasoningItem)}");
                reasoning = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputFunctionCallItem? functionCall = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.FunctionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputFunctionCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputFunctionCallItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputFunctionCallItem)}");
                functionCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputWebSearchCallItem? webSearchCall = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.WebSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputWebSearchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputWebSearchCallItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputWebSearchCallItem)}");
                webSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputFileSearchCallItem? fileSearchCall = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.FileSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputFileSearchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputFileSearchCallItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputFileSearchCallItem)}");
                fileSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputImageGenerationCallItem? imageGenerationCall = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.ImageGenerationCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputImageGenerationCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputImageGenerationCallItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputImageGenerationCallItem)}");
                imageGenerationCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputCodeInterpreterCallItem? codeInterpreterCall = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.CodeInterpreterCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputCodeInterpreterCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputCodeInterpreterCallItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputCodeInterpreterCallItem)}");
                codeInterpreterCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputComputerCallItem? computerCall = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.ComputerCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputComputerCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputComputerCallItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputComputerCallItem)}");
                computerCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputDatetimeItem? openrouterDatetime = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_datetime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputDatetimeItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputDatetimeItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputDatetimeItem)}");
                openrouterDatetime = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputWebSearchServerToolItem? openrouterWebSearch = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_webSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputWebSearchServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputWebSearchServerToolItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputWebSearchServerToolItem)}");
                openrouterWebSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputCodeInterpreterServerToolItem? openrouterCodeInterpreter = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_codeInterpreter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputCodeInterpreterServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputCodeInterpreterServerToolItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputCodeInterpreterServerToolItem)}");
                openrouterCodeInterpreter = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputFileSearchServerToolItem? openrouterFileSearch = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_fileSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputFileSearchServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputFileSearchServerToolItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputFileSearchServerToolItem)}");
                openrouterFileSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputImageGenerationServerToolItem? openrouterImageGeneration = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_imageGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputImageGenerationServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputImageGenerationServerToolItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputImageGenerationServerToolItem)}");
                openrouterImageGeneration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputBrowserUseServerToolItem? openrouterBrowserUse = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_browserUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputBrowserUseServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputBrowserUseServerToolItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputBrowserUseServerToolItem)}");
                openrouterBrowserUse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputBashServerToolItem? openrouterBash = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_bash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputBashServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputBashServerToolItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputBashServerToolItem)}");
                openrouterBash = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputTextEditorServerToolItem? openrouterTextEditor = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_textEditor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputTextEditorServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputTextEditorServerToolItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputTextEditorServerToolItem)}");
                openrouterTextEditor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputApplyPatchServerToolItem? openrouterApplyPatch = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_applyPatch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputApplyPatchServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputApplyPatchServerToolItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputApplyPatchServerToolItem)}");
                openrouterApplyPatch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputApplyPatchCallItem? applyPatchCall = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.ApplyPatchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputApplyPatchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputApplyPatchCallItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputApplyPatchCallItem)}");
                applyPatchCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputShellCallItem? shellCall = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.ShellCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputShellCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputShellCallItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputShellCallItem)}");
                shellCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputShellCallOutputItem? shellCallOutput = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.ShellCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputShellCallOutputItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputShellCallOutputItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputShellCallOutputItem)}");
                shellCallOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputShellServerToolItem? openrouterShell = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_shell)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputShellServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputShellServerToolItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputShellServerToolItem)}");
                openrouterShell = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputWebFetchServerToolItem? openrouterWebFetch = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_webFetch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputWebFetchServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputWebFetchServerToolItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputWebFetchServerToolItem)}");
                openrouterWebFetch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputToolSearchServerToolItem? openrouterToolSearch = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_toolSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputToolSearchServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputToolSearchServerToolItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputToolSearchServerToolItem)}");
                openrouterToolSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputMemoryServerToolItem? openrouterMemory = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_memory)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputMemoryServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputMemoryServerToolItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputMemoryServerToolItem)}");
                openrouterMemory = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputMcpServerToolItem? openrouterMcp = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_mcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputMcpServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputMcpServerToolItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputMcpServerToolItem)}");
                openrouterMcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputSearchModelsServerToolItem? openrouterExperimentalSearchModels = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_experimentalSearchModels)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputSearchModelsServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputSearchModelsServerToolItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputSearchModelsServerToolItem)}");
                openrouterExperimentalSearchModels = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputFusionServerToolItem? openrouterFusion = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_fusion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputFusionServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputFusionServerToolItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputFusionServerToolItem)}");
                openrouterFusion = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputAdvisorServerToolItem? openrouterAdvisor = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_advisor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputAdvisorServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputAdvisorServerToolItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputAdvisorServerToolItem)}");
                openrouterAdvisor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputSubagentServerToolItem? openrouterSubagent = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_subagent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputSubagentServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputSubagentServerToolItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputSubagentServerToolItem)}");
                openrouterSubagent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputFilesServerToolItem? openrouterFiles = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.Openrouter_files)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputFilesServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputFilesServerToolItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputFilesServerToolItem)}");
                openrouterFiles = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputCustomToolCallItem? customToolCall = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.CustomToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputCustomToolCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputCustomToolCallItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputCustomToolCallItem)}");
                customToolCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.OutputToolSearchCallItem? toolSearchCall = default;
            if (discriminator?.Type == global::OpenRouter.OutputItemsDiscriminatorType.ToolSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputToolSearchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputToolSearchCallItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.OutputToolSearchCallItem)}");
                toolSearchCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.OutputItems(
                discriminator?.Type,
                message,

                reasoning,

                functionCall,

                webSearchCall,

                fileSearchCall,

                imageGenerationCall,

                codeInterpreterCall,

                computerCall,

                openrouterDatetime,

                openrouterWebSearch,

                openrouterCodeInterpreter,

                openrouterFileSearch,

                openrouterImageGeneration,

                openrouterBrowserUse,

                openrouterBash,

                openrouterTextEditor,

                openrouterApplyPatch,

                applyPatchCall,

                shellCall,

                shellCallOutput,

                openrouterShell,

                openrouterWebFetch,

                openrouterToolSearch,

                openrouterMemory,

                openrouterMcp,

                openrouterExperimentalSearchModels,

                openrouterFusion,

                openrouterAdvisor,

                openrouterSubagent,

                openrouterFiles,

                customToolCall,

                toolSearchCall
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

            if (value.IsMessage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputMessageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputMessageItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputMessageItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMessage(), typeInfo);
            }
            else if (value.IsReasoning)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputReasoningItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputReasoningItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputReasoningItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickReasoning(), typeInfo);
            }
            else if (value.IsFunctionCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputFunctionCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputFunctionCallItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputFunctionCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFunctionCall(), typeInfo);
            }
            else if (value.IsWebSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputWebSearchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputWebSearchCallItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputWebSearchCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWebSearchCall(), typeInfo);
            }
            else if (value.IsFileSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputFileSearchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputFileSearchCallItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputFileSearchCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFileSearchCall(), typeInfo);
            }
            else if (value.IsImageGenerationCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputImageGenerationCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputImageGenerationCallItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputImageGenerationCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickImageGenerationCall(), typeInfo);
            }
            else if (value.IsCodeInterpreterCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputCodeInterpreterCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputCodeInterpreterCallItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputCodeInterpreterCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCodeInterpreterCall(), typeInfo);
            }
            else if (value.IsComputerCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputComputerCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputComputerCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputComputerCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickComputerCall(), typeInfo);
            }
            else if (value.IsOpenrouterDatetime)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputDatetimeItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputDatetimeItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputDatetimeItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenrouterDatetime(), typeInfo);
            }
            else if (value.IsOpenrouterWebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputWebSearchServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputWebSearchServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputWebSearchServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenrouterWebSearch(), typeInfo);
            }
            else if (value.IsOpenrouterCodeInterpreter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputCodeInterpreterServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputCodeInterpreterServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputCodeInterpreterServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenrouterCodeInterpreter(), typeInfo);
            }
            else if (value.IsOpenrouterFileSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputFileSearchServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputFileSearchServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputFileSearchServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenrouterFileSearch(), typeInfo);
            }
            else if (value.IsOpenrouterImageGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputImageGenerationServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputImageGenerationServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputImageGenerationServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenrouterImageGeneration(), typeInfo);
            }
            else if (value.IsOpenrouterBrowserUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputBrowserUseServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputBrowserUseServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputBrowserUseServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenrouterBrowserUse(), typeInfo);
            }
            else if (value.IsOpenrouterBash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputBashServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputBashServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputBashServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenrouterBash(), typeInfo);
            }
            else if (value.IsOpenrouterTextEditor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputTextEditorServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputTextEditorServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputTextEditorServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenrouterTextEditor(), typeInfo);
            }
            else if (value.IsOpenrouterApplyPatch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputApplyPatchServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputApplyPatchServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputApplyPatchServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenrouterApplyPatch(), typeInfo);
            }
            else if (value.IsApplyPatchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputApplyPatchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputApplyPatchCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputApplyPatchCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickApplyPatchCall(), typeInfo);
            }
            else if (value.IsShellCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputShellCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputShellCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputShellCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickShellCall(), typeInfo);
            }
            else if (value.IsShellCallOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputShellCallOutputItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputShellCallOutputItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputShellCallOutputItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickShellCallOutput(), typeInfo);
            }
            else if (value.IsOpenrouterShell)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputShellServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputShellServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputShellServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenrouterShell(), typeInfo);
            }
            else if (value.IsOpenrouterWebFetch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputWebFetchServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputWebFetchServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputWebFetchServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenrouterWebFetch(), typeInfo);
            }
            else if (value.IsOpenrouterToolSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputToolSearchServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputToolSearchServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputToolSearchServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenrouterToolSearch(), typeInfo);
            }
            else if (value.IsOpenrouterMemory)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputMemoryServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputMemoryServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputMemoryServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenrouterMemory(), typeInfo);
            }
            else if (value.IsOpenrouterMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputMcpServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputMcpServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputMcpServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenrouterMcp(), typeInfo);
            }
            else if (value.IsOpenrouterExperimentalSearchModels)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputSearchModelsServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputSearchModelsServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputSearchModelsServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenrouterExperimentalSearchModels(), typeInfo);
            }
            else if (value.IsOpenrouterFusion)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputFusionServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputFusionServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputFusionServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenrouterFusion(), typeInfo);
            }
            else if (value.IsOpenrouterAdvisor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputAdvisorServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputAdvisorServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputAdvisorServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenrouterAdvisor(), typeInfo);
            }
            else if (value.IsOpenrouterSubagent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputSubagentServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputSubagentServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputSubagentServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenrouterSubagent(), typeInfo);
            }
            else if (value.IsOpenrouterFiles)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputFilesServerToolItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputFilesServerToolItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputFilesServerToolItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOpenrouterFiles(), typeInfo);
            }
            else if (value.IsCustomToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputCustomToolCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputCustomToolCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputCustomToolCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickCustomToolCall(), typeInfo);
            }
            else if (value.IsToolSearchCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.OutputToolSearchCallItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.OutputToolSearchCallItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.OutputToolSearchCallItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickToolSearchCall(), typeInfo);
            }
        }
    }
}