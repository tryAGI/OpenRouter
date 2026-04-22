#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResponsesRequestToolsItems : global::System.IEquatable<ResponsesRequestToolsItems>
    {
        /// <summary>
        /// Function tool definition
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ResponsesRequestToolsItems0? ResponsesRequestToolsItems0 { get; init; }
#else
        public global::OpenRouter.ResponsesRequestToolsItems0? ResponsesRequestToolsItems0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponsesRequestToolsItems0))]
#endif
        public bool IsResponsesRequestToolsItems0 => ResponsesRequestToolsItems0 != null;

        /// <summary>
        /// Web search preview tool configuration
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.PreviewWebSearchServerTool? PreviewWebSearchServerTool { get; init; }
#else
        public global::OpenRouter.PreviewWebSearchServerTool? PreviewWebSearchServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PreviewWebSearchServerTool))]
#endif
        public bool IsPreviewWebSearchServerTool => PreviewWebSearchServerTool != null;

        /// <summary>
        /// Web search preview tool configuration (2025-03-11 version)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.Preview20250311WebSearchServerTool? Preview20250311WebSearchServerTool { get; init; }
#else
        public global::OpenRouter.Preview20250311WebSearchServerTool? Preview20250311WebSearchServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Preview20250311WebSearchServerTool))]
#endif
        public bool IsPreview20250311WebSearchServerTool => Preview20250311WebSearchServerTool != null;

        /// <summary>
        /// Web search tool configuration
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.LegacyWebSearchServerTool? LegacyWebSearchServerTool { get; init; }
#else
        public global::OpenRouter.LegacyWebSearchServerTool? LegacyWebSearchServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LegacyWebSearchServerTool))]
#endif
        public bool IsLegacyWebSearchServerTool => LegacyWebSearchServerTool != null;

        /// <summary>
        /// Web search tool configuration (2025-08-26 version)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.WebSearchServerTool? WebSearchServerTool { get; init; }
#else
        public global::OpenRouter.WebSearchServerTool? WebSearchServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchServerTool))]
#endif
        public bool IsWebSearchServerTool => WebSearchServerTool != null;

        /// <summary>
        /// File search tool configuration
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FileSearchServerTool? FileSearchServerTool { get; init; }
#else
        public global::OpenRouter.FileSearchServerTool? FileSearchServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchServerTool))]
#endif
        public bool IsFileSearchServerTool => FileSearchServerTool != null;

        /// <summary>
        /// Computer use preview tool configuration
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ComputerUseServerTool? ComputerUseServerTool { get; init; }
#else
        public global::OpenRouter.ComputerUseServerTool? ComputerUseServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerUseServerTool))]
#endif
        public bool IsComputerUseServerTool => ComputerUseServerTool != null;

        /// <summary>
        /// Code interpreter tool configuration
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CodeInterpreterServerTool? CodeInterpreterServerTool { get; init; }
#else
        public global::OpenRouter.CodeInterpreterServerTool? CodeInterpreterServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterServerTool))]
#endif
        public bool IsCodeInterpreterServerTool => CodeInterpreterServerTool != null;

        /// <summary>
        /// MCP (Model Context Protocol) tool configuration
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.McpServerTool? McpServerTool { get; init; }
#else
        public global::OpenRouter.McpServerTool? McpServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpServerTool))]
#endif
        public bool IsMcpServerTool => McpServerTool != null;

        /// <summary>
        /// Image generation tool configuration
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ImageGenerationServerTool? ImageGenerationServerTool { get; init; }
#else
        public global::OpenRouter.ImageGenerationServerTool? ImageGenerationServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenerationServerTool))]
#endif
        public bool IsImageGenerationServerTool => ImageGenerationServerTool != null;

        /// <summary>
        /// Local shell tool configuration
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CodexLocalShellTool? CodexLocalShellTool { get; init; }
#else
        public global::OpenRouter.CodexLocalShellTool? CodexLocalShellTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodexLocalShellTool))]
#endif
        public bool IsCodexLocalShellTool => CodexLocalShellTool != null;

        /// <summary>
        /// Shell tool configuration
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ShellServerTool? ShellServerTool { get; init; }
#else
        public global::OpenRouter.ShellServerTool? ShellServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ShellServerTool))]
#endif
        public bool IsShellServerTool => ShellServerTool != null;

        /// <summary>
        /// Apply patch tool configuration
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ApplyPatchServerTool? ApplyPatchServerTool { get; init; }
#else
        public global::OpenRouter.ApplyPatchServerTool? ApplyPatchServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatchServerTool))]
#endif
        public bool IsApplyPatchServerTool => ApplyPatchServerTool != null;

        /// <summary>
        /// Custom tool configuration
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CustomTool? CustomTool { get; init; }
#else
        public global::OpenRouter.CustomTool? CustomTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomTool))]
#endif
        public bool IsCustomTool => CustomTool != null;

        /// <summary>
        /// OpenRouter built-in server tool: returns the current date and time
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.DatetimeServerTool? DatetimeServerTool { get; init; }
#else
        public global::OpenRouter.DatetimeServerTool? DatetimeServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DatetimeServerTool))]
#endif
        public bool IsDatetimeServerTool => DatetimeServerTool != null;

        /// <summary>
        /// OpenRouter built-in server tool: generates images from text prompts using an image generation model
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ImageGenerationServerToolOpenRouter? ImageGenerationServerToolOpenRouter { get; init; }
#else
        public global::OpenRouter.ImageGenerationServerToolOpenRouter? ImageGenerationServerToolOpenRouter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenerationServerToolOpenRouter))]
#endif
        public bool IsImageGenerationServerToolOpenRouter => ImageGenerationServerToolOpenRouter != null;

        /// <summary>
        /// OpenRouter built-in server tool: searches and filters AI models available on OpenRouter
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ChatSearchModelsServerTool? ChatSearchModelsServerTool { get; init; }
#else
        public global::OpenRouter.ChatSearchModelsServerTool? ChatSearchModelsServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatSearchModelsServerTool))]
#endif
        public bool IsChatSearchModelsServerTool => ChatSearchModelsServerTool != null;

        /// <summary>
        /// OpenRouter built-in server tool: fetches full content from a URL (web page or PDF)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.WebFetchServerTool? WebFetchServerTool { get; init; }
#else
        public global::OpenRouter.WebFetchServerTool? WebFetchServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebFetchServerTool))]
#endif
        public bool IsWebFetchServerTool => WebFetchServerTool != null;

        /// <summary>
        /// OpenRouter built-in server tool: searches the web for current information
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.WebSearchServerToolOpenRouter? WebSearchServerToolOpenRouter { get; init; }
#else
        public global::OpenRouter.WebSearchServerToolOpenRouter? WebSearchServerToolOpenRouter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchServerToolOpenRouter))]
#endif
        public bool IsWebSearchServerToolOpenRouter => WebSearchServerToolOpenRouter != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestToolsItems(global::OpenRouter.ResponsesRequestToolsItems0 value) => new ResponsesRequestToolsItems((global::OpenRouter.ResponsesRequestToolsItems0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ResponsesRequestToolsItems0?(ResponsesRequestToolsItems @this) => @this.ResponsesRequestToolsItems0;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestToolsItems(global::OpenRouter.ResponsesRequestToolsItems0? value)
        {
            ResponsesRequestToolsItems0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestToolsItems(global::OpenRouter.PreviewWebSearchServerTool value) => new ResponsesRequestToolsItems((global::OpenRouter.PreviewWebSearchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.PreviewWebSearchServerTool?(ResponsesRequestToolsItems @this) => @this.PreviewWebSearchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestToolsItems(global::OpenRouter.PreviewWebSearchServerTool? value)
        {
            PreviewWebSearchServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestToolsItems(global::OpenRouter.Preview20250311WebSearchServerTool value) => new ResponsesRequestToolsItems((global::OpenRouter.Preview20250311WebSearchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.Preview20250311WebSearchServerTool?(ResponsesRequestToolsItems @this) => @this.Preview20250311WebSearchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestToolsItems(global::OpenRouter.Preview20250311WebSearchServerTool? value)
        {
            Preview20250311WebSearchServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestToolsItems(global::OpenRouter.LegacyWebSearchServerTool value) => new ResponsesRequestToolsItems((global::OpenRouter.LegacyWebSearchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.LegacyWebSearchServerTool?(ResponsesRequestToolsItems @this) => @this.LegacyWebSearchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestToolsItems(global::OpenRouter.LegacyWebSearchServerTool? value)
        {
            LegacyWebSearchServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestToolsItems(global::OpenRouter.WebSearchServerTool value) => new ResponsesRequestToolsItems((global::OpenRouter.WebSearchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.WebSearchServerTool?(ResponsesRequestToolsItems @this) => @this.WebSearchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestToolsItems(global::OpenRouter.WebSearchServerTool? value)
        {
            WebSearchServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestToolsItems(global::OpenRouter.FileSearchServerTool value) => new ResponsesRequestToolsItems((global::OpenRouter.FileSearchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.FileSearchServerTool?(ResponsesRequestToolsItems @this) => @this.FileSearchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestToolsItems(global::OpenRouter.FileSearchServerTool? value)
        {
            FileSearchServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestToolsItems(global::OpenRouter.ComputerUseServerTool value) => new ResponsesRequestToolsItems((global::OpenRouter.ComputerUseServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ComputerUseServerTool?(ResponsesRequestToolsItems @this) => @this.ComputerUseServerTool;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestToolsItems(global::OpenRouter.ComputerUseServerTool? value)
        {
            ComputerUseServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestToolsItems(global::OpenRouter.CodeInterpreterServerTool value) => new ResponsesRequestToolsItems((global::OpenRouter.CodeInterpreterServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CodeInterpreterServerTool?(ResponsesRequestToolsItems @this) => @this.CodeInterpreterServerTool;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestToolsItems(global::OpenRouter.CodeInterpreterServerTool? value)
        {
            CodeInterpreterServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestToolsItems(global::OpenRouter.McpServerTool value) => new ResponsesRequestToolsItems((global::OpenRouter.McpServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.McpServerTool?(ResponsesRequestToolsItems @this) => @this.McpServerTool;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestToolsItems(global::OpenRouter.McpServerTool? value)
        {
            McpServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestToolsItems(global::OpenRouter.ImageGenerationServerTool value) => new ResponsesRequestToolsItems((global::OpenRouter.ImageGenerationServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ImageGenerationServerTool?(ResponsesRequestToolsItems @this) => @this.ImageGenerationServerTool;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestToolsItems(global::OpenRouter.ImageGenerationServerTool? value)
        {
            ImageGenerationServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestToolsItems(global::OpenRouter.CodexLocalShellTool value) => new ResponsesRequestToolsItems((global::OpenRouter.CodexLocalShellTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CodexLocalShellTool?(ResponsesRequestToolsItems @this) => @this.CodexLocalShellTool;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestToolsItems(global::OpenRouter.CodexLocalShellTool? value)
        {
            CodexLocalShellTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestToolsItems(global::OpenRouter.ShellServerTool value) => new ResponsesRequestToolsItems((global::OpenRouter.ShellServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ShellServerTool?(ResponsesRequestToolsItems @this) => @this.ShellServerTool;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestToolsItems(global::OpenRouter.ShellServerTool? value)
        {
            ShellServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestToolsItems(global::OpenRouter.ApplyPatchServerTool value) => new ResponsesRequestToolsItems((global::OpenRouter.ApplyPatchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ApplyPatchServerTool?(ResponsesRequestToolsItems @this) => @this.ApplyPatchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestToolsItems(global::OpenRouter.ApplyPatchServerTool? value)
        {
            ApplyPatchServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestToolsItems(global::OpenRouter.CustomTool value) => new ResponsesRequestToolsItems((global::OpenRouter.CustomTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CustomTool?(ResponsesRequestToolsItems @this) => @this.CustomTool;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestToolsItems(global::OpenRouter.CustomTool? value)
        {
            CustomTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestToolsItems(global::OpenRouter.DatetimeServerTool value) => new ResponsesRequestToolsItems((global::OpenRouter.DatetimeServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.DatetimeServerTool?(ResponsesRequestToolsItems @this) => @this.DatetimeServerTool;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestToolsItems(global::OpenRouter.DatetimeServerTool? value)
        {
            DatetimeServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestToolsItems(global::OpenRouter.ImageGenerationServerToolOpenRouter value) => new ResponsesRequestToolsItems((global::OpenRouter.ImageGenerationServerToolOpenRouter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ImageGenerationServerToolOpenRouter?(ResponsesRequestToolsItems @this) => @this.ImageGenerationServerToolOpenRouter;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestToolsItems(global::OpenRouter.ImageGenerationServerToolOpenRouter? value)
        {
            ImageGenerationServerToolOpenRouter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestToolsItems(global::OpenRouter.ChatSearchModelsServerTool value) => new ResponsesRequestToolsItems((global::OpenRouter.ChatSearchModelsServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ChatSearchModelsServerTool?(ResponsesRequestToolsItems @this) => @this.ChatSearchModelsServerTool;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestToolsItems(global::OpenRouter.ChatSearchModelsServerTool? value)
        {
            ChatSearchModelsServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestToolsItems(global::OpenRouter.WebFetchServerTool value) => new ResponsesRequestToolsItems((global::OpenRouter.WebFetchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.WebFetchServerTool?(ResponsesRequestToolsItems @this) => @this.WebFetchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestToolsItems(global::OpenRouter.WebFetchServerTool? value)
        {
            WebFetchServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestToolsItems(global::OpenRouter.WebSearchServerToolOpenRouter value) => new ResponsesRequestToolsItems((global::OpenRouter.WebSearchServerToolOpenRouter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.WebSearchServerToolOpenRouter?(ResponsesRequestToolsItems @this) => @this.WebSearchServerToolOpenRouter;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestToolsItems(global::OpenRouter.WebSearchServerToolOpenRouter? value)
        {
            WebSearchServerToolOpenRouter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestToolsItems(
            global::OpenRouter.ResponsesRequestToolsItems0? responsesRequestToolsItems0,
            global::OpenRouter.PreviewWebSearchServerTool? previewWebSearchServerTool,
            global::OpenRouter.Preview20250311WebSearchServerTool? preview20250311WebSearchServerTool,
            global::OpenRouter.LegacyWebSearchServerTool? legacyWebSearchServerTool,
            global::OpenRouter.WebSearchServerTool? webSearchServerTool,
            global::OpenRouter.FileSearchServerTool? fileSearchServerTool,
            global::OpenRouter.ComputerUseServerTool? computerUseServerTool,
            global::OpenRouter.CodeInterpreterServerTool? codeInterpreterServerTool,
            global::OpenRouter.McpServerTool? mcpServerTool,
            global::OpenRouter.ImageGenerationServerTool? imageGenerationServerTool,
            global::OpenRouter.CodexLocalShellTool? codexLocalShellTool,
            global::OpenRouter.ShellServerTool? shellServerTool,
            global::OpenRouter.ApplyPatchServerTool? applyPatchServerTool,
            global::OpenRouter.CustomTool? customTool,
            global::OpenRouter.DatetimeServerTool? datetimeServerTool,
            global::OpenRouter.ImageGenerationServerToolOpenRouter? imageGenerationServerToolOpenRouter,
            global::OpenRouter.ChatSearchModelsServerTool? chatSearchModelsServerTool,
            global::OpenRouter.WebFetchServerTool? webFetchServerTool,
            global::OpenRouter.WebSearchServerToolOpenRouter? webSearchServerToolOpenRouter
            )
        {
            ResponsesRequestToolsItems0 = responsesRequestToolsItems0;
            PreviewWebSearchServerTool = previewWebSearchServerTool;
            Preview20250311WebSearchServerTool = preview20250311WebSearchServerTool;
            LegacyWebSearchServerTool = legacyWebSearchServerTool;
            WebSearchServerTool = webSearchServerTool;
            FileSearchServerTool = fileSearchServerTool;
            ComputerUseServerTool = computerUseServerTool;
            CodeInterpreterServerTool = codeInterpreterServerTool;
            McpServerTool = mcpServerTool;
            ImageGenerationServerTool = imageGenerationServerTool;
            CodexLocalShellTool = codexLocalShellTool;
            ShellServerTool = shellServerTool;
            ApplyPatchServerTool = applyPatchServerTool;
            CustomTool = customTool;
            DatetimeServerTool = datetimeServerTool;
            ImageGenerationServerToolOpenRouter = imageGenerationServerToolOpenRouter;
            ChatSearchModelsServerTool = chatSearchModelsServerTool;
            WebFetchServerTool = webFetchServerTool;
            WebSearchServerToolOpenRouter = webSearchServerToolOpenRouter;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WebSearchServerToolOpenRouter as object ??
            WebFetchServerTool as object ??
            ChatSearchModelsServerTool as object ??
            ImageGenerationServerToolOpenRouter as object ??
            DatetimeServerTool as object ??
            CustomTool as object ??
            ApplyPatchServerTool as object ??
            ShellServerTool as object ??
            CodexLocalShellTool as object ??
            ImageGenerationServerTool as object ??
            McpServerTool as object ??
            CodeInterpreterServerTool as object ??
            ComputerUseServerTool as object ??
            FileSearchServerTool as object ??
            WebSearchServerTool as object ??
            LegacyWebSearchServerTool as object ??
            Preview20250311WebSearchServerTool as object ??
            PreviewWebSearchServerTool as object ??
            ResponsesRequestToolsItems0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ResponsesRequestToolsItems0?.ToString() ??
            PreviewWebSearchServerTool?.ToString() ??
            Preview20250311WebSearchServerTool?.ToString() ??
            LegacyWebSearchServerTool?.ToString() ??
            WebSearchServerTool?.ToString() ??
            FileSearchServerTool?.ToString() ??
            ComputerUseServerTool?.ToString() ??
            CodeInterpreterServerTool?.ToString() ??
            McpServerTool?.ToString() ??
            ImageGenerationServerTool?.ToString() ??
            CodexLocalShellTool?.ToString() ??
            ShellServerTool?.ToString() ??
            ApplyPatchServerTool?.ToString() ??
            CustomTool?.ToString() ??
            DatetimeServerTool?.ToString() ??
            ImageGenerationServerToolOpenRouter?.ToString() ??
            ChatSearchModelsServerTool?.ToString() ??
            WebFetchServerTool?.ToString() ??
            WebSearchServerToolOpenRouter?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResponsesRequestToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsDatetimeServerTool && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter || !IsResponsesRequestToolsItems0 && IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsDatetimeServerTool && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter || !IsResponsesRequestToolsItems0 && !IsPreviewWebSearchServerTool && IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsDatetimeServerTool && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter || !IsResponsesRequestToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsDatetimeServerTool && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter || !IsResponsesRequestToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsDatetimeServerTool && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter || !IsResponsesRequestToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsDatetimeServerTool && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter || !IsResponsesRequestToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsDatetimeServerTool && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter || !IsResponsesRequestToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsDatetimeServerTool && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter || !IsResponsesRequestToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsDatetimeServerTool && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter || !IsResponsesRequestToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsDatetimeServerTool && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter || !IsResponsesRequestToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsDatetimeServerTool && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter || !IsResponsesRequestToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsDatetimeServerTool && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter || !IsResponsesRequestToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && IsApplyPatchServerTool && !IsCustomTool && !IsDatetimeServerTool && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter || !IsResponsesRequestToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && IsCustomTool && !IsDatetimeServerTool && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter || !IsResponsesRequestToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && IsDatetimeServerTool && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter || !IsResponsesRequestToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsDatetimeServerTool && IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter || !IsResponsesRequestToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsDatetimeServerTool && !IsImageGenerationServerToolOpenRouter && IsChatSearchModelsServerTool && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter || !IsResponsesRequestToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsDatetimeServerTool && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter || !IsResponsesRequestToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsDatetimeServerTool && !IsImageGenerationServerToolOpenRouter && !IsChatSearchModelsServerTool && !IsWebFetchServerTool && IsWebSearchServerToolOpenRouter;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ResponsesRequestToolsItems0?, TResult>? responsesRequestToolsItems0 = null,
            global::System.Func<global::OpenRouter.PreviewWebSearchServerTool?, TResult>? previewWebSearchServerTool = null,
            global::System.Func<global::OpenRouter.Preview20250311WebSearchServerTool?, TResult>? preview20250311WebSearchServerTool = null,
            global::System.Func<global::OpenRouter.LegacyWebSearchServerTool?, TResult>? legacyWebSearchServerTool = null,
            global::System.Func<global::OpenRouter.WebSearchServerTool?, TResult>? webSearchServerTool = null,
            global::System.Func<global::OpenRouter.FileSearchServerTool?, TResult>? fileSearchServerTool = null,
            global::System.Func<global::OpenRouter.ComputerUseServerTool?, TResult>? computerUseServerTool = null,
            global::System.Func<global::OpenRouter.CodeInterpreterServerTool?, TResult>? codeInterpreterServerTool = null,
            global::System.Func<global::OpenRouter.McpServerTool?, TResult>? mcpServerTool = null,
            global::System.Func<global::OpenRouter.ImageGenerationServerTool?, TResult>? imageGenerationServerTool = null,
            global::System.Func<global::OpenRouter.CodexLocalShellTool?, TResult>? codexLocalShellTool = null,
            global::System.Func<global::OpenRouter.ShellServerTool?, TResult>? shellServerTool = null,
            global::System.Func<global::OpenRouter.ApplyPatchServerTool?, TResult>? applyPatchServerTool = null,
            global::System.Func<global::OpenRouter.CustomTool?, TResult>? customTool = null,
            global::System.Func<global::OpenRouter.DatetimeServerTool?, TResult>? datetimeServerTool = null,
            global::System.Func<global::OpenRouter.ImageGenerationServerToolOpenRouter?, TResult>? imageGenerationServerToolOpenRouter = null,
            global::System.Func<global::OpenRouter.ChatSearchModelsServerTool?, TResult>? chatSearchModelsServerTool = null,
            global::System.Func<global::OpenRouter.WebFetchServerTool?, TResult>? webFetchServerTool = null,
            global::System.Func<global::OpenRouter.WebSearchServerToolOpenRouter?, TResult>? webSearchServerToolOpenRouter = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponsesRequestToolsItems0 && responsesRequestToolsItems0 != null)
            {
                return responsesRequestToolsItems0(ResponsesRequestToolsItems0!);
            }
            else if (IsPreviewWebSearchServerTool && previewWebSearchServerTool != null)
            {
                return previewWebSearchServerTool(PreviewWebSearchServerTool!);
            }
            else if (IsPreview20250311WebSearchServerTool && preview20250311WebSearchServerTool != null)
            {
                return preview20250311WebSearchServerTool(Preview20250311WebSearchServerTool!);
            }
            else if (IsLegacyWebSearchServerTool && legacyWebSearchServerTool != null)
            {
                return legacyWebSearchServerTool(LegacyWebSearchServerTool!);
            }
            else if (IsWebSearchServerTool && webSearchServerTool != null)
            {
                return webSearchServerTool(WebSearchServerTool!);
            }
            else if (IsFileSearchServerTool && fileSearchServerTool != null)
            {
                return fileSearchServerTool(FileSearchServerTool!);
            }
            else if (IsComputerUseServerTool && computerUseServerTool != null)
            {
                return computerUseServerTool(ComputerUseServerTool!);
            }
            else if (IsCodeInterpreterServerTool && codeInterpreterServerTool != null)
            {
                return codeInterpreterServerTool(CodeInterpreterServerTool!);
            }
            else if (IsMcpServerTool && mcpServerTool != null)
            {
                return mcpServerTool(McpServerTool!);
            }
            else if (IsImageGenerationServerTool && imageGenerationServerTool != null)
            {
                return imageGenerationServerTool(ImageGenerationServerTool!);
            }
            else if (IsCodexLocalShellTool && codexLocalShellTool != null)
            {
                return codexLocalShellTool(CodexLocalShellTool!);
            }
            else if (IsShellServerTool && shellServerTool != null)
            {
                return shellServerTool(ShellServerTool!);
            }
            else if (IsApplyPatchServerTool && applyPatchServerTool != null)
            {
                return applyPatchServerTool(ApplyPatchServerTool!);
            }
            else if (IsCustomTool && customTool != null)
            {
                return customTool(CustomTool!);
            }
            else if (IsDatetimeServerTool && datetimeServerTool != null)
            {
                return datetimeServerTool(DatetimeServerTool!);
            }
            else if (IsImageGenerationServerToolOpenRouter && imageGenerationServerToolOpenRouter != null)
            {
                return imageGenerationServerToolOpenRouter(ImageGenerationServerToolOpenRouter!);
            }
            else if (IsChatSearchModelsServerTool && chatSearchModelsServerTool != null)
            {
                return chatSearchModelsServerTool(ChatSearchModelsServerTool!);
            }
            else if (IsWebFetchServerTool && webFetchServerTool != null)
            {
                return webFetchServerTool(WebFetchServerTool!);
            }
            else if (IsWebSearchServerToolOpenRouter && webSearchServerToolOpenRouter != null)
            {
                return webSearchServerToolOpenRouter(WebSearchServerToolOpenRouter!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ResponsesRequestToolsItems0?>? responsesRequestToolsItems0 = null,
            global::System.Action<global::OpenRouter.PreviewWebSearchServerTool?>? previewWebSearchServerTool = null,
            global::System.Action<global::OpenRouter.Preview20250311WebSearchServerTool?>? preview20250311WebSearchServerTool = null,
            global::System.Action<global::OpenRouter.LegacyWebSearchServerTool?>? legacyWebSearchServerTool = null,
            global::System.Action<global::OpenRouter.WebSearchServerTool?>? webSearchServerTool = null,
            global::System.Action<global::OpenRouter.FileSearchServerTool?>? fileSearchServerTool = null,
            global::System.Action<global::OpenRouter.ComputerUseServerTool?>? computerUseServerTool = null,
            global::System.Action<global::OpenRouter.CodeInterpreterServerTool?>? codeInterpreterServerTool = null,
            global::System.Action<global::OpenRouter.McpServerTool?>? mcpServerTool = null,
            global::System.Action<global::OpenRouter.ImageGenerationServerTool?>? imageGenerationServerTool = null,
            global::System.Action<global::OpenRouter.CodexLocalShellTool?>? codexLocalShellTool = null,
            global::System.Action<global::OpenRouter.ShellServerTool?>? shellServerTool = null,
            global::System.Action<global::OpenRouter.ApplyPatchServerTool?>? applyPatchServerTool = null,
            global::System.Action<global::OpenRouter.CustomTool?>? customTool = null,
            global::System.Action<global::OpenRouter.DatetimeServerTool?>? datetimeServerTool = null,
            global::System.Action<global::OpenRouter.ImageGenerationServerToolOpenRouter?>? imageGenerationServerToolOpenRouter = null,
            global::System.Action<global::OpenRouter.ChatSearchModelsServerTool?>? chatSearchModelsServerTool = null,
            global::System.Action<global::OpenRouter.WebFetchServerTool?>? webFetchServerTool = null,
            global::System.Action<global::OpenRouter.WebSearchServerToolOpenRouter?>? webSearchServerToolOpenRouter = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponsesRequestToolsItems0)
            {
                responsesRequestToolsItems0?.Invoke(ResponsesRequestToolsItems0!);
            }
            else if (IsPreviewWebSearchServerTool)
            {
                previewWebSearchServerTool?.Invoke(PreviewWebSearchServerTool!);
            }
            else if (IsPreview20250311WebSearchServerTool)
            {
                preview20250311WebSearchServerTool?.Invoke(Preview20250311WebSearchServerTool!);
            }
            else if (IsLegacyWebSearchServerTool)
            {
                legacyWebSearchServerTool?.Invoke(LegacyWebSearchServerTool!);
            }
            else if (IsWebSearchServerTool)
            {
                webSearchServerTool?.Invoke(WebSearchServerTool!);
            }
            else if (IsFileSearchServerTool)
            {
                fileSearchServerTool?.Invoke(FileSearchServerTool!);
            }
            else if (IsComputerUseServerTool)
            {
                computerUseServerTool?.Invoke(ComputerUseServerTool!);
            }
            else if (IsCodeInterpreterServerTool)
            {
                codeInterpreterServerTool?.Invoke(CodeInterpreterServerTool!);
            }
            else if (IsMcpServerTool)
            {
                mcpServerTool?.Invoke(McpServerTool!);
            }
            else if (IsImageGenerationServerTool)
            {
                imageGenerationServerTool?.Invoke(ImageGenerationServerTool!);
            }
            else if (IsCodexLocalShellTool)
            {
                codexLocalShellTool?.Invoke(CodexLocalShellTool!);
            }
            else if (IsShellServerTool)
            {
                shellServerTool?.Invoke(ShellServerTool!);
            }
            else if (IsApplyPatchServerTool)
            {
                applyPatchServerTool?.Invoke(ApplyPatchServerTool!);
            }
            else if (IsCustomTool)
            {
                customTool?.Invoke(CustomTool!);
            }
            else if (IsDatetimeServerTool)
            {
                datetimeServerTool?.Invoke(DatetimeServerTool!);
            }
            else if (IsImageGenerationServerToolOpenRouter)
            {
                imageGenerationServerToolOpenRouter?.Invoke(ImageGenerationServerToolOpenRouter!);
            }
            else if (IsChatSearchModelsServerTool)
            {
                chatSearchModelsServerTool?.Invoke(ChatSearchModelsServerTool!);
            }
            else if (IsWebFetchServerTool)
            {
                webFetchServerTool?.Invoke(WebFetchServerTool!);
            }
            else if (IsWebSearchServerToolOpenRouter)
            {
                webSearchServerToolOpenRouter?.Invoke(WebSearchServerToolOpenRouter!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ResponsesRequestToolsItems0,
                typeof(global::OpenRouter.ResponsesRequestToolsItems0),
                PreviewWebSearchServerTool,
                typeof(global::OpenRouter.PreviewWebSearchServerTool),
                Preview20250311WebSearchServerTool,
                typeof(global::OpenRouter.Preview20250311WebSearchServerTool),
                LegacyWebSearchServerTool,
                typeof(global::OpenRouter.LegacyWebSearchServerTool),
                WebSearchServerTool,
                typeof(global::OpenRouter.WebSearchServerTool),
                FileSearchServerTool,
                typeof(global::OpenRouter.FileSearchServerTool),
                ComputerUseServerTool,
                typeof(global::OpenRouter.ComputerUseServerTool),
                CodeInterpreterServerTool,
                typeof(global::OpenRouter.CodeInterpreterServerTool),
                McpServerTool,
                typeof(global::OpenRouter.McpServerTool),
                ImageGenerationServerTool,
                typeof(global::OpenRouter.ImageGenerationServerTool),
                CodexLocalShellTool,
                typeof(global::OpenRouter.CodexLocalShellTool),
                ShellServerTool,
                typeof(global::OpenRouter.ShellServerTool),
                ApplyPatchServerTool,
                typeof(global::OpenRouter.ApplyPatchServerTool),
                CustomTool,
                typeof(global::OpenRouter.CustomTool),
                DatetimeServerTool,
                typeof(global::OpenRouter.DatetimeServerTool),
                ImageGenerationServerToolOpenRouter,
                typeof(global::OpenRouter.ImageGenerationServerToolOpenRouter),
                ChatSearchModelsServerTool,
                typeof(global::OpenRouter.ChatSearchModelsServerTool),
                WebFetchServerTool,
                typeof(global::OpenRouter.WebFetchServerTool),
                WebSearchServerToolOpenRouter,
                typeof(global::OpenRouter.WebSearchServerToolOpenRouter),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ResponsesRequestToolsItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ResponsesRequestToolsItems0?>.Default.Equals(ResponsesRequestToolsItems0, other.ResponsesRequestToolsItems0) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.PreviewWebSearchServerTool?>.Default.Equals(PreviewWebSearchServerTool, other.PreviewWebSearchServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.Preview20250311WebSearchServerTool?>.Default.Equals(Preview20250311WebSearchServerTool, other.Preview20250311WebSearchServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.LegacyWebSearchServerTool?>.Default.Equals(LegacyWebSearchServerTool, other.LegacyWebSearchServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.WebSearchServerTool?>.Default.Equals(WebSearchServerTool, other.WebSearchServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FileSearchServerTool?>.Default.Equals(FileSearchServerTool, other.FileSearchServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ComputerUseServerTool?>.Default.Equals(ComputerUseServerTool, other.ComputerUseServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CodeInterpreterServerTool?>.Default.Equals(CodeInterpreterServerTool, other.CodeInterpreterServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.McpServerTool?>.Default.Equals(McpServerTool, other.McpServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ImageGenerationServerTool?>.Default.Equals(ImageGenerationServerTool, other.ImageGenerationServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CodexLocalShellTool?>.Default.Equals(CodexLocalShellTool, other.CodexLocalShellTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ShellServerTool?>.Default.Equals(ShellServerTool, other.ShellServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ApplyPatchServerTool?>.Default.Equals(ApplyPatchServerTool, other.ApplyPatchServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CustomTool?>.Default.Equals(CustomTool, other.CustomTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.DatetimeServerTool?>.Default.Equals(DatetimeServerTool, other.DatetimeServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ImageGenerationServerToolOpenRouter?>.Default.Equals(ImageGenerationServerToolOpenRouter, other.ImageGenerationServerToolOpenRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ChatSearchModelsServerTool?>.Default.Equals(ChatSearchModelsServerTool, other.ChatSearchModelsServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.WebFetchServerTool?>.Default.Equals(WebFetchServerTool, other.WebFetchServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.WebSearchServerToolOpenRouter?>.Default.Equals(WebSearchServerToolOpenRouter, other.WebSearchServerToolOpenRouter) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponsesRequestToolsItems obj1, ResponsesRequestToolsItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponsesRequestToolsItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponsesRequestToolsItems obj1, ResponsesRequestToolsItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponsesRequestToolsItems o && Equals(o);
        }
    }
}
