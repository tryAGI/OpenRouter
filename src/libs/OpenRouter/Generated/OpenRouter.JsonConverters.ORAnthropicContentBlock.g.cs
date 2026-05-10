#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace OpenRouter.JsonConverters
{
    /// <inheritdoc />
    public class ORAnthropicContentBlockJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::OpenRouter.ORAnthropicContentBlock>
    {
        /// <inheritdoc />
        public override global::OpenRouter.ORAnthropicContentBlock Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicContentBlockDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicContentBlockDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ORAnthropicContentBlockDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::OpenRouter.ORAnthropicContentBlockVariant1? bashCodeExecutionToolResult = default;
            if (discriminator?.Type == global::OpenRouter.ORAnthropicContentBlockDiscriminatorType.BashCodeExecutionToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicContentBlockVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicContentBlockVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ORAnthropicContentBlockVariant1)}");
                bashCodeExecutionToolResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ORAnthropicContentBlockVariant2? codeExecutionToolResult = default;
            if (discriminator?.Type == global::OpenRouter.ORAnthropicContentBlockDiscriminatorType.CodeExecutionToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicContentBlockVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicContentBlockVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ORAnthropicContentBlockVariant2)}");
                codeExecutionToolResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ORAnthropicContentBlockVariant3? compaction = default;
            if (discriminator?.Type == global::OpenRouter.ORAnthropicContentBlockDiscriminatorType.Compaction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicContentBlockVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicContentBlockVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ORAnthropicContentBlockVariant3)}");
                compaction = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ORAnthropicContentBlockVariant4? containerUpload = default;
            if (discriminator?.Type == global::OpenRouter.ORAnthropicContentBlockDiscriminatorType.ContainerUpload)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicContentBlockVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicContentBlockVariant4> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ORAnthropicContentBlockVariant4)}");
                containerUpload = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ORAnthropicContentBlockVariant5? redactedThinking = default;
            if (discriminator?.Type == global::OpenRouter.ORAnthropicContentBlockDiscriminatorType.RedactedThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicContentBlockVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicContentBlockVariant5> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ORAnthropicContentBlockVariant5)}");
                redactedThinking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ORAnthropicContentBlockVariant6? serverToolUse = default;
            if (discriminator?.Type == global::OpenRouter.ORAnthropicContentBlockDiscriminatorType.ServerToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicContentBlockVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicContentBlockVariant6> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ORAnthropicContentBlockVariant6)}");
                serverToolUse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ORAnthropicContentBlockVariant7? text = default;
            if (discriminator?.Type == global::OpenRouter.ORAnthropicContentBlockDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicContentBlockVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicContentBlockVariant7> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ORAnthropicContentBlockVariant7)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ORAnthropicContentBlockVariant8? textEditorCodeExecutionToolResult = default;
            if (discriminator?.Type == global::OpenRouter.ORAnthropicContentBlockDiscriminatorType.TextEditorCodeExecutionToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicContentBlockVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicContentBlockVariant8> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ORAnthropicContentBlockVariant8)}");
                textEditorCodeExecutionToolResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ORAnthropicContentBlockVariant9? thinking = default;
            if (discriminator?.Type == global::OpenRouter.ORAnthropicContentBlockDiscriminatorType.Thinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicContentBlockVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicContentBlockVariant9> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ORAnthropicContentBlockVariant9)}");
                thinking = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ORAnthropicContentBlockVariant10? toolSearchToolResult = default;
            if (discriminator?.Type == global::OpenRouter.ORAnthropicContentBlockDiscriminatorType.ToolSearchToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicContentBlockVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicContentBlockVariant10> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ORAnthropicContentBlockVariant10)}");
                toolSearchToolResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ORAnthropicContentBlockVariant11? toolUse = default;
            if (discriminator?.Type == global::OpenRouter.ORAnthropicContentBlockDiscriminatorType.ToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicContentBlockVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicContentBlockVariant11> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ORAnthropicContentBlockVariant11)}");
                toolUse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ORAnthropicContentBlockVariant12? webFetchToolResult = default;
            if (discriminator?.Type == global::OpenRouter.ORAnthropicContentBlockDiscriminatorType.WebFetchToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicContentBlockVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicContentBlockVariant12> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ORAnthropicContentBlockVariant12)}");
                webFetchToolResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::OpenRouter.ORAnthropicContentBlockVariant13? webSearchToolResult = default;
            if (discriminator?.Type == global::OpenRouter.ORAnthropicContentBlockDiscriminatorType.WebSearchToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicContentBlockVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicContentBlockVariant13> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::OpenRouter.ORAnthropicContentBlockVariant13)}");
                webSearchToolResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::OpenRouter.ORAnthropicContentBlock(
                discriminator?.Type,
                bashCodeExecutionToolResult,

                codeExecutionToolResult,

                compaction,

                containerUpload,

                redactedThinking,

                serverToolUse,

                text,

                textEditorCodeExecutionToolResult,

                thinking,

                toolSearchToolResult,

                toolUse,

                webFetchToolResult,

                webSearchToolResult
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::OpenRouter.ORAnthropicContentBlock value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBashCodeExecutionToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicContentBlockVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicContentBlockVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ORAnthropicContentBlockVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BashCodeExecutionToolResult!, typeInfo);
            }
            else if (value.IsCodeExecutionToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicContentBlockVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicContentBlockVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ORAnthropicContentBlockVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeExecutionToolResult!, typeInfo);
            }
            else if (value.IsCompaction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicContentBlockVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicContentBlockVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ORAnthropicContentBlockVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Compaction!, typeInfo);
            }
            else if (value.IsContainerUpload)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicContentBlockVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicContentBlockVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ORAnthropicContentBlockVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ContainerUpload!, typeInfo);
            }
            else if (value.IsRedactedThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicContentBlockVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicContentBlockVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ORAnthropicContentBlockVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RedactedThinking!, typeInfo);
            }
            else if (value.IsServerToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicContentBlockVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicContentBlockVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ORAnthropicContentBlockVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ServerToolUse!, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicContentBlockVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicContentBlockVariant7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ORAnthropicContentBlockVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsTextEditorCodeExecutionToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicContentBlockVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicContentBlockVariant8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ORAnthropicContentBlockVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditorCodeExecutionToolResult!, typeInfo);
            }
            else if (value.IsThinking)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicContentBlockVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicContentBlockVariant9?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ORAnthropicContentBlockVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Thinking!, typeInfo);
            }
            else if (value.IsToolSearchToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicContentBlockVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicContentBlockVariant10?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ORAnthropicContentBlockVariant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolSearchToolResult!, typeInfo);
            }
            else if (value.IsToolUse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicContentBlockVariant11), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicContentBlockVariant11?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ORAnthropicContentBlockVariant11).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolUse!, typeInfo);
            }
            else if (value.IsWebFetchToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicContentBlockVariant12), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicContentBlockVariant12?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ORAnthropicContentBlockVariant12).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebFetchToolResult!, typeInfo);
            }
            else if (value.IsWebSearchToolResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::OpenRouter.ORAnthropicContentBlockVariant13), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::OpenRouter.ORAnthropicContentBlockVariant13?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::OpenRouter.ORAnthropicContentBlockVariant13).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearchToolResult!, typeInfo);
            }
        }
    }
}