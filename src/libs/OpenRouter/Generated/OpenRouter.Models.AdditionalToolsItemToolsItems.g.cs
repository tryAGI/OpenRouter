#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AdditionalToolsItemToolsItems : global::System.IEquatable<AdditionalToolsItemToolsItems>
    {
        /// <summary>
        /// Function tool definition
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AdditionalToolsItemToolsItems0? AdditionalToolsItemToolsItems0 { get; init; }
#else
        public global::OpenRouter.AdditionalToolsItemToolsItems0? AdditionalToolsItemToolsItems0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AdditionalToolsItemToolsItems0))]
#endif
        public bool IsAdditionalToolsItemToolsItems0 => AdditionalToolsItemToolsItems0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAdditionalToolsItemToolsItems0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AdditionalToolsItemToolsItems0? value)
        {
            value = AdditionalToolsItemToolsItems0;
            return IsAdditionalToolsItemToolsItems0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.AdditionalToolsItemToolsItems0 PickAdditionalToolsItemToolsItems0() => IsAdditionalToolsItemToolsItems0
            ? AdditionalToolsItemToolsItems0!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AdditionalToolsItemToolsItems0' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickPreviewWebSearchServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.PreviewWebSearchServerTool? value)
        {
            value = PreviewWebSearchServerTool;
            return IsPreviewWebSearchServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.PreviewWebSearchServerTool PickPreviewWebSearchServerTool() => IsPreviewWebSearchServerTool
            ? PreviewWebSearchServerTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PreviewWebSearchServerTool' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickPreview20250311WebSearchServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.Preview20250311WebSearchServerTool? value)
        {
            value = Preview20250311WebSearchServerTool;
            return IsPreview20250311WebSearchServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.Preview20250311WebSearchServerTool PickPreview20250311WebSearchServerTool() => IsPreview20250311WebSearchServerTool
            ? Preview20250311WebSearchServerTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Preview20250311WebSearchServerTool' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickLegacyWebSearchServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.LegacyWebSearchServerTool? value)
        {
            value = LegacyWebSearchServerTool;
            return IsLegacyWebSearchServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.LegacyWebSearchServerTool PickLegacyWebSearchServerTool() => IsLegacyWebSearchServerTool
            ? LegacyWebSearchServerTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'LegacyWebSearchServerTool' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickWebSearchServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.WebSearchServerTool? value)
        {
            value = WebSearchServerTool;
            return IsWebSearchServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.WebSearchServerTool PickWebSearchServerTool() => IsWebSearchServerTool
            ? WebSearchServerTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearchServerTool' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickFileSearchServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.FileSearchServerTool? value)
        {
            value = FileSearchServerTool;
            return IsFileSearchServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.FileSearchServerTool PickFileSearchServerTool() => IsFileSearchServerTool
            ? FileSearchServerTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileSearchServerTool' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickComputerUseServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ComputerUseServerTool? value)
        {
            value = ComputerUseServerTool;
            return IsComputerUseServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ComputerUseServerTool PickComputerUseServerTool() => IsComputerUseServerTool
            ? ComputerUseServerTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerUseServerTool' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickCodeInterpreterServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.CodeInterpreterServerTool? value)
        {
            value = CodeInterpreterServerTool;
            return IsCodeInterpreterServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.CodeInterpreterServerTool PickCodeInterpreterServerTool() => IsCodeInterpreterServerTool
            ? CodeInterpreterServerTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeInterpreterServerTool' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickMcpServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.McpServerTool? value)
        {
            value = McpServerTool;
            return IsMcpServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.McpServerTool PickMcpServerTool() => IsMcpServerTool
            ? McpServerTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpServerTool' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickImageGenerationServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ImageGenerationServerTool? value)
        {
            value = ImageGenerationServerTool;
            return IsImageGenerationServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ImageGenerationServerTool PickImageGenerationServerTool() => IsImageGenerationServerTool
            ? ImageGenerationServerTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageGenerationServerTool' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickCodexLocalShellTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.CodexLocalShellTool? value)
        {
            value = CodexLocalShellTool;
            return IsCodexLocalShellTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.CodexLocalShellTool PickCodexLocalShellTool() => IsCodexLocalShellTool
            ? CodexLocalShellTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodexLocalShellTool' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickShellServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ShellServerTool? value)
        {
            value = ShellServerTool;
            return IsShellServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ShellServerTool PickShellServerTool() => IsShellServerTool
            ? ShellServerTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ShellServerTool' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickApplyPatchServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ApplyPatchServerTool? value)
        {
            value = ApplyPatchServerTool;
            return IsApplyPatchServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ApplyPatchServerTool PickApplyPatchServerTool() => IsApplyPatchServerTool
            ? ApplyPatchServerTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatchServerTool' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickCustomTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.CustomTool? value)
        {
            value = CustomTool;
            return IsCustomTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.CustomTool PickCustomTool() => IsCustomTool
            ? CustomTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomTool' but the value was {ToString()}.");

        /// <summary>
        /// Groups function/custom tools under a shared namespace
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.NamespaceTool? NamespaceTool { get; init; }
#else
        public global::OpenRouter.NamespaceTool? NamespaceTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NamespaceTool))]
#endif
        public bool IsNamespaceTool => NamespaceTool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickNamespaceTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.NamespaceTool? value)
        {
            value = NamespaceTool;
            return IsNamespaceTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.NamespaceTool PickNamespaceTool() => IsNamespaceTool
            ? NamespaceTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'NamespaceTool' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter built-in server tool: consults a higher-intelligence advisor model (any OpenRouter model) for guidance mid-generation and returns its response. The advisor may run as a sub-agent with its own tools. Include multiple entries to offer several named advisors; at most one entry may omit `name` to act as the default advisor.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AdvisorServerToolOpenRouter? AdvisorServerToolOpenRouter { get; init; }
#else
        public global::OpenRouter.AdvisorServerToolOpenRouter? AdvisorServerToolOpenRouter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AdvisorServerToolOpenRouter))]
#endif
        public bool IsAdvisorServerToolOpenRouter => AdvisorServerToolOpenRouter != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAdvisorServerToolOpenRouter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AdvisorServerToolOpenRouter? value)
        {
            value = AdvisorServerToolOpenRouter;
            return IsAdvisorServerToolOpenRouter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.AdvisorServerToolOpenRouter PickAdvisorServerToolOpenRouter() => IsAdvisorServerToolOpenRouter
            ? AdvisorServerToolOpenRouter!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AdvisorServerToolOpenRouter' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter built-in server tool: delegates self-contained tasks to a smaller, cheaper, faster worker model (any OpenRouter model) mid-generation and returns its outcome. The worker may run as a sub-agent with its own tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.SubagentServerToolOpenRouter? SubagentServerToolOpenRouter { get; init; }
#else
        public global::OpenRouter.SubagentServerToolOpenRouter? SubagentServerToolOpenRouter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubagentServerToolOpenRouter))]
#endif
        public bool IsSubagentServerToolOpenRouter => SubagentServerToolOpenRouter != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSubagentServerToolOpenRouter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.SubagentServerToolOpenRouter? value)
        {
            value = SubagentServerToolOpenRouter;
            return IsSubagentServerToolOpenRouter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.SubagentServerToolOpenRouter PickSubagentServerToolOpenRouter() => IsSubagentServerToolOpenRouter
            ? SubagentServerToolOpenRouter!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubagentServerToolOpenRouter' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickDatetimeServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.DatetimeServerTool? value)
        {
            value = DatetimeServerTool;
            return IsDatetimeServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.DatetimeServerTool PickDatetimeServerTool() => IsDatetimeServerTool
            ? DatetimeServerTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DatetimeServerTool' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter built-in server tool: read, write, edit, and list workspace files via the Files API. Requires the `x-openrouter-file-ids: openrouter` request header.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FilesServerTool? FilesServerTool { get; init; }
#else
        public global::OpenRouter.FilesServerTool? FilesServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FilesServerTool))]
#endif
        public bool IsFilesServerTool => FilesServerTool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFilesServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.FilesServerTool? value)
        {
            value = FilesServerTool;
            return IsFilesServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.FilesServerTool PickFilesServerTool() => IsFilesServerTool
            ? FilesServerTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FilesServerTool' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter built-in server tool: fans out the user prompt to a panel of analysis models, then asks a judge model to summarize their collective output as structured JSON the outer model can synthesize from.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FusionServerToolOpenRouter? FusionServerToolOpenRouter { get; init; }
#else
        public global::OpenRouter.FusionServerToolOpenRouter? FusionServerToolOpenRouter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FusionServerToolOpenRouter))]
#endif
        public bool IsFusionServerToolOpenRouter => FusionServerToolOpenRouter != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFusionServerToolOpenRouter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.FusionServerToolOpenRouter? value)
        {
            value = FusionServerToolOpenRouter;
            return IsFusionServerToolOpenRouter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.FusionServerToolOpenRouter PickFusionServerToolOpenRouter() => IsFusionServerToolOpenRouter
            ? FusionServerToolOpenRouter!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FusionServerToolOpenRouter' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickImageGenerationServerToolOpenRouter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ImageGenerationServerToolOpenRouter? value)
        {
            value = ImageGenerationServerToolOpenRouter;
            return IsImageGenerationServerToolOpenRouter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ImageGenerationServerToolOpenRouter PickImageGenerationServerToolOpenRouter() => IsImageGenerationServerToolOpenRouter
            ? ImageGenerationServerToolOpenRouter!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageGenerationServerToolOpenRouter' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter built-in server tool: searches and filters AI models available on OpenRouter
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.SearchModelsServerToolOpenRouter? SearchModelsServerToolOpenRouter { get; init; }
#else
        public global::OpenRouter.SearchModelsServerToolOpenRouter? SearchModelsServerToolOpenRouter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SearchModelsServerToolOpenRouter))]
#endif
        public bool IsSearchModelsServerToolOpenRouter => SearchModelsServerToolOpenRouter != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSearchModelsServerToolOpenRouter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.SearchModelsServerToolOpenRouter? value)
        {
            value = SearchModelsServerToolOpenRouter;
            return IsSearchModelsServerToolOpenRouter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.SearchModelsServerToolOpenRouter PickSearchModelsServerToolOpenRouter() => IsSearchModelsServerToolOpenRouter
            ? SearchModelsServerToolOpenRouter!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SearchModelsServerToolOpenRouter' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickWebFetchServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.WebFetchServerTool? value)
        {
            value = WebFetchServerTool;
            return IsWebFetchServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.WebFetchServerTool PickWebFetchServerTool() => IsWebFetchServerTool
            ? WebFetchServerTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebFetchServerTool' but the value was {ToString()}.");

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
        public bool TryPickWebSearchServerToolOpenRouter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.WebSearchServerToolOpenRouter? value)
        {
            value = WebSearchServerToolOpenRouter;
            return IsWebSearchServerToolOpenRouter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.WebSearchServerToolOpenRouter PickWebSearchServerToolOpenRouter() => IsWebSearchServerToolOpenRouter
            ? WebSearchServerToolOpenRouter!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearchServerToolOpenRouter' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter built-in server tool: validates V4A diff patches for file operations (create, update, delete). Restricted to the Responses API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ApplyPatchServerToolOpenRouter? ApplyPatchServerToolOpenRouter { get; init; }
#else
        public global::OpenRouter.ApplyPatchServerToolOpenRouter? ApplyPatchServerToolOpenRouter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatchServerToolOpenRouter))]
#endif
        public bool IsApplyPatchServerToolOpenRouter => ApplyPatchServerToolOpenRouter != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickApplyPatchServerToolOpenRouter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ApplyPatchServerToolOpenRouter? value)
        {
            value = ApplyPatchServerToolOpenRouter;
            return IsApplyPatchServerToolOpenRouter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ApplyPatchServerToolOpenRouter PickApplyPatchServerToolOpenRouter() => IsApplyPatchServerToolOpenRouter
            ? ApplyPatchServerToolOpenRouter!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatchServerToolOpenRouter' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter built-in server tool: runs shell commands server-side in a sandboxed container
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BashServerTool? BashServerTool { get; init; }
#else
        public global::OpenRouter.BashServerTool? BashServerTool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BashServerTool))]
#endif
        public bool IsBashServerTool => BashServerTool != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBashServerTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.BashServerTool? value)
        {
            value = BashServerTool;
            return IsBashServerTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.BashServerTool PickBashServerTool() => IsBashServerTool
            ? BashServerTool!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BashServerTool' but the value was {ToString()}.");

        /// <summary>
        /// OpenRouter built-in server tool: runs shell commands server-side in a sandboxed container (a sandbox-backed clone of OpenAI's hosted shell tool)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ShellServerToolOpenRouter? ShellServerToolOpenRouter { get; init; }
#else
        public global::OpenRouter.ShellServerToolOpenRouter? ShellServerToolOpenRouter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ShellServerToolOpenRouter))]
#endif
        public bool IsShellServerToolOpenRouter => ShellServerToolOpenRouter != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickShellServerToolOpenRouter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ShellServerToolOpenRouter? value)
        {
            value = ShellServerToolOpenRouter;
            return IsShellServerToolOpenRouter;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ShellServerToolOpenRouter PickShellServerToolOpenRouter() => IsShellServerToolOpenRouter
            ? ShellServerToolOpenRouter!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ShellServerToolOpenRouter' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AdditionalToolsItemToolsItems27? AdditionalToolsItemToolsItems27 { get; init; }
#else
        public global::OpenRouter.AdditionalToolsItemToolsItems27? AdditionalToolsItemToolsItems27 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AdditionalToolsItemToolsItems27))]
#endif
        public bool IsAdditionalToolsItemToolsItems27 => AdditionalToolsItemToolsItems27 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAdditionalToolsItemToolsItems27(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AdditionalToolsItemToolsItems27? value)
        {
            value = AdditionalToolsItemToolsItems27;
            return IsAdditionalToolsItemToolsItems27;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.AdditionalToolsItemToolsItems27 PickAdditionalToolsItemToolsItems27() => IsAdditionalToolsItemToolsItems27
            ? AdditionalToolsItemToolsItems27!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AdditionalToolsItemToolsItems27' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdditionalToolsItemToolsItems(global::OpenRouter.AdditionalToolsItemToolsItems0 value) => new AdditionalToolsItemToolsItems((global::OpenRouter.AdditionalToolsItemToolsItems0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AdditionalToolsItemToolsItems0?(AdditionalToolsItemToolsItems @this) => @this.AdditionalToolsItemToolsItems0;

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(global::OpenRouter.AdditionalToolsItemToolsItems0? value)
        {
            AdditionalToolsItemToolsItems0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AdditionalToolsItemToolsItems FromAdditionalToolsItemToolsItems0(global::OpenRouter.AdditionalToolsItemToolsItems0? value) => new AdditionalToolsItemToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdditionalToolsItemToolsItems(global::OpenRouter.PreviewWebSearchServerTool value) => new AdditionalToolsItemToolsItems((global::OpenRouter.PreviewWebSearchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.PreviewWebSearchServerTool?(AdditionalToolsItemToolsItems @this) => @this.PreviewWebSearchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(global::OpenRouter.PreviewWebSearchServerTool? value)
        {
            PreviewWebSearchServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AdditionalToolsItemToolsItems FromPreviewWebSearchServerTool(global::OpenRouter.PreviewWebSearchServerTool? value) => new AdditionalToolsItemToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdditionalToolsItemToolsItems(global::OpenRouter.Preview20250311WebSearchServerTool value) => new AdditionalToolsItemToolsItems((global::OpenRouter.Preview20250311WebSearchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.Preview20250311WebSearchServerTool?(AdditionalToolsItemToolsItems @this) => @this.Preview20250311WebSearchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(global::OpenRouter.Preview20250311WebSearchServerTool? value)
        {
            Preview20250311WebSearchServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AdditionalToolsItemToolsItems FromPreview20250311WebSearchServerTool(global::OpenRouter.Preview20250311WebSearchServerTool? value) => new AdditionalToolsItemToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdditionalToolsItemToolsItems(global::OpenRouter.LegacyWebSearchServerTool value) => new AdditionalToolsItemToolsItems((global::OpenRouter.LegacyWebSearchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.LegacyWebSearchServerTool?(AdditionalToolsItemToolsItems @this) => @this.LegacyWebSearchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(global::OpenRouter.LegacyWebSearchServerTool? value)
        {
            LegacyWebSearchServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AdditionalToolsItemToolsItems FromLegacyWebSearchServerTool(global::OpenRouter.LegacyWebSearchServerTool? value) => new AdditionalToolsItemToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdditionalToolsItemToolsItems(global::OpenRouter.WebSearchServerTool value) => new AdditionalToolsItemToolsItems((global::OpenRouter.WebSearchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.WebSearchServerTool?(AdditionalToolsItemToolsItems @this) => @this.WebSearchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(global::OpenRouter.WebSearchServerTool? value)
        {
            WebSearchServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AdditionalToolsItemToolsItems FromWebSearchServerTool(global::OpenRouter.WebSearchServerTool? value) => new AdditionalToolsItemToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdditionalToolsItemToolsItems(global::OpenRouter.FileSearchServerTool value) => new AdditionalToolsItemToolsItems((global::OpenRouter.FileSearchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.FileSearchServerTool?(AdditionalToolsItemToolsItems @this) => @this.FileSearchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(global::OpenRouter.FileSearchServerTool? value)
        {
            FileSearchServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AdditionalToolsItemToolsItems FromFileSearchServerTool(global::OpenRouter.FileSearchServerTool? value) => new AdditionalToolsItemToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdditionalToolsItemToolsItems(global::OpenRouter.ComputerUseServerTool value) => new AdditionalToolsItemToolsItems((global::OpenRouter.ComputerUseServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ComputerUseServerTool?(AdditionalToolsItemToolsItems @this) => @this.ComputerUseServerTool;

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(global::OpenRouter.ComputerUseServerTool? value)
        {
            ComputerUseServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AdditionalToolsItemToolsItems FromComputerUseServerTool(global::OpenRouter.ComputerUseServerTool? value) => new AdditionalToolsItemToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdditionalToolsItemToolsItems(global::OpenRouter.CodeInterpreterServerTool value) => new AdditionalToolsItemToolsItems((global::OpenRouter.CodeInterpreterServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CodeInterpreterServerTool?(AdditionalToolsItemToolsItems @this) => @this.CodeInterpreterServerTool;

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(global::OpenRouter.CodeInterpreterServerTool? value)
        {
            CodeInterpreterServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AdditionalToolsItemToolsItems FromCodeInterpreterServerTool(global::OpenRouter.CodeInterpreterServerTool? value) => new AdditionalToolsItemToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdditionalToolsItemToolsItems(global::OpenRouter.McpServerTool value) => new AdditionalToolsItemToolsItems((global::OpenRouter.McpServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.McpServerTool?(AdditionalToolsItemToolsItems @this) => @this.McpServerTool;

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(global::OpenRouter.McpServerTool? value)
        {
            McpServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AdditionalToolsItemToolsItems FromMcpServerTool(global::OpenRouter.McpServerTool? value) => new AdditionalToolsItemToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdditionalToolsItemToolsItems(global::OpenRouter.ImageGenerationServerTool value) => new AdditionalToolsItemToolsItems((global::OpenRouter.ImageGenerationServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ImageGenerationServerTool?(AdditionalToolsItemToolsItems @this) => @this.ImageGenerationServerTool;

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(global::OpenRouter.ImageGenerationServerTool? value)
        {
            ImageGenerationServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AdditionalToolsItemToolsItems FromImageGenerationServerTool(global::OpenRouter.ImageGenerationServerTool? value) => new AdditionalToolsItemToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdditionalToolsItemToolsItems(global::OpenRouter.CodexLocalShellTool value) => new AdditionalToolsItemToolsItems((global::OpenRouter.CodexLocalShellTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CodexLocalShellTool?(AdditionalToolsItemToolsItems @this) => @this.CodexLocalShellTool;

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(global::OpenRouter.CodexLocalShellTool? value)
        {
            CodexLocalShellTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AdditionalToolsItemToolsItems FromCodexLocalShellTool(global::OpenRouter.CodexLocalShellTool? value) => new AdditionalToolsItemToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdditionalToolsItemToolsItems(global::OpenRouter.ShellServerTool value) => new AdditionalToolsItemToolsItems((global::OpenRouter.ShellServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ShellServerTool?(AdditionalToolsItemToolsItems @this) => @this.ShellServerTool;

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(global::OpenRouter.ShellServerTool? value)
        {
            ShellServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AdditionalToolsItemToolsItems FromShellServerTool(global::OpenRouter.ShellServerTool? value) => new AdditionalToolsItemToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdditionalToolsItemToolsItems(global::OpenRouter.ApplyPatchServerTool value) => new AdditionalToolsItemToolsItems((global::OpenRouter.ApplyPatchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ApplyPatchServerTool?(AdditionalToolsItemToolsItems @this) => @this.ApplyPatchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(global::OpenRouter.ApplyPatchServerTool? value)
        {
            ApplyPatchServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AdditionalToolsItemToolsItems FromApplyPatchServerTool(global::OpenRouter.ApplyPatchServerTool? value) => new AdditionalToolsItemToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdditionalToolsItemToolsItems(global::OpenRouter.CustomTool value) => new AdditionalToolsItemToolsItems((global::OpenRouter.CustomTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CustomTool?(AdditionalToolsItemToolsItems @this) => @this.CustomTool;

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(global::OpenRouter.CustomTool? value)
        {
            CustomTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AdditionalToolsItemToolsItems FromCustomTool(global::OpenRouter.CustomTool? value) => new AdditionalToolsItemToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdditionalToolsItemToolsItems(global::OpenRouter.NamespaceTool value) => new AdditionalToolsItemToolsItems((global::OpenRouter.NamespaceTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.NamespaceTool?(AdditionalToolsItemToolsItems @this) => @this.NamespaceTool;

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(global::OpenRouter.NamespaceTool? value)
        {
            NamespaceTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AdditionalToolsItemToolsItems FromNamespaceTool(global::OpenRouter.NamespaceTool? value) => new AdditionalToolsItemToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdditionalToolsItemToolsItems(global::OpenRouter.AdvisorServerToolOpenRouter value) => new AdditionalToolsItemToolsItems((global::OpenRouter.AdvisorServerToolOpenRouter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AdvisorServerToolOpenRouter?(AdditionalToolsItemToolsItems @this) => @this.AdvisorServerToolOpenRouter;

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(global::OpenRouter.AdvisorServerToolOpenRouter? value)
        {
            AdvisorServerToolOpenRouter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AdditionalToolsItemToolsItems FromAdvisorServerToolOpenRouter(global::OpenRouter.AdvisorServerToolOpenRouter? value) => new AdditionalToolsItemToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdditionalToolsItemToolsItems(global::OpenRouter.SubagentServerToolOpenRouter value) => new AdditionalToolsItemToolsItems((global::OpenRouter.SubagentServerToolOpenRouter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.SubagentServerToolOpenRouter?(AdditionalToolsItemToolsItems @this) => @this.SubagentServerToolOpenRouter;

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(global::OpenRouter.SubagentServerToolOpenRouter? value)
        {
            SubagentServerToolOpenRouter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AdditionalToolsItemToolsItems FromSubagentServerToolOpenRouter(global::OpenRouter.SubagentServerToolOpenRouter? value) => new AdditionalToolsItemToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdditionalToolsItemToolsItems(global::OpenRouter.DatetimeServerTool value) => new AdditionalToolsItemToolsItems((global::OpenRouter.DatetimeServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.DatetimeServerTool?(AdditionalToolsItemToolsItems @this) => @this.DatetimeServerTool;

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(global::OpenRouter.DatetimeServerTool? value)
        {
            DatetimeServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AdditionalToolsItemToolsItems FromDatetimeServerTool(global::OpenRouter.DatetimeServerTool? value) => new AdditionalToolsItemToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdditionalToolsItemToolsItems(global::OpenRouter.FilesServerTool value) => new AdditionalToolsItemToolsItems((global::OpenRouter.FilesServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.FilesServerTool?(AdditionalToolsItemToolsItems @this) => @this.FilesServerTool;

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(global::OpenRouter.FilesServerTool? value)
        {
            FilesServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AdditionalToolsItemToolsItems FromFilesServerTool(global::OpenRouter.FilesServerTool? value) => new AdditionalToolsItemToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdditionalToolsItemToolsItems(global::OpenRouter.FusionServerToolOpenRouter value) => new AdditionalToolsItemToolsItems((global::OpenRouter.FusionServerToolOpenRouter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.FusionServerToolOpenRouter?(AdditionalToolsItemToolsItems @this) => @this.FusionServerToolOpenRouter;

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(global::OpenRouter.FusionServerToolOpenRouter? value)
        {
            FusionServerToolOpenRouter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AdditionalToolsItemToolsItems FromFusionServerToolOpenRouter(global::OpenRouter.FusionServerToolOpenRouter? value) => new AdditionalToolsItemToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdditionalToolsItemToolsItems(global::OpenRouter.ImageGenerationServerToolOpenRouter value) => new AdditionalToolsItemToolsItems((global::OpenRouter.ImageGenerationServerToolOpenRouter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ImageGenerationServerToolOpenRouter?(AdditionalToolsItemToolsItems @this) => @this.ImageGenerationServerToolOpenRouter;

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(global::OpenRouter.ImageGenerationServerToolOpenRouter? value)
        {
            ImageGenerationServerToolOpenRouter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AdditionalToolsItemToolsItems FromImageGenerationServerToolOpenRouter(global::OpenRouter.ImageGenerationServerToolOpenRouter? value) => new AdditionalToolsItemToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdditionalToolsItemToolsItems(global::OpenRouter.SearchModelsServerToolOpenRouter value) => new AdditionalToolsItemToolsItems((global::OpenRouter.SearchModelsServerToolOpenRouter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.SearchModelsServerToolOpenRouter?(AdditionalToolsItemToolsItems @this) => @this.SearchModelsServerToolOpenRouter;

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(global::OpenRouter.SearchModelsServerToolOpenRouter? value)
        {
            SearchModelsServerToolOpenRouter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AdditionalToolsItemToolsItems FromSearchModelsServerToolOpenRouter(global::OpenRouter.SearchModelsServerToolOpenRouter? value) => new AdditionalToolsItemToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdditionalToolsItemToolsItems(global::OpenRouter.WebFetchServerTool value) => new AdditionalToolsItemToolsItems((global::OpenRouter.WebFetchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.WebFetchServerTool?(AdditionalToolsItemToolsItems @this) => @this.WebFetchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(global::OpenRouter.WebFetchServerTool? value)
        {
            WebFetchServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AdditionalToolsItemToolsItems FromWebFetchServerTool(global::OpenRouter.WebFetchServerTool? value) => new AdditionalToolsItemToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdditionalToolsItemToolsItems(global::OpenRouter.WebSearchServerToolOpenRouter value) => new AdditionalToolsItemToolsItems((global::OpenRouter.WebSearchServerToolOpenRouter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.WebSearchServerToolOpenRouter?(AdditionalToolsItemToolsItems @this) => @this.WebSearchServerToolOpenRouter;

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(global::OpenRouter.WebSearchServerToolOpenRouter? value)
        {
            WebSearchServerToolOpenRouter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AdditionalToolsItemToolsItems FromWebSearchServerToolOpenRouter(global::OpenRouter.WebSearchServerToolOpenRouter? value) => new AdditionalToolsItemToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdditionalToolsItemToolsItems(global::OpenRouter.ApplyPatchServerToolOpenRouter value) => new AdditionalToolsItemToolsItems((global::OpenRouter.ApplyPatchServerToolOpenRouter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ApplyPatchServerToolOpenRouter?(AdditionalToolsItemToolsItems @this) => @this.ApplyPatchServerToolOpenRouter;

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(global::OpenRouter.ApplyPatchServerToolOpenRouter? value)
        {
            ApplyPatchServerToolOpenRouter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AdditionalToolsItemToolsItems FromApplyPatchServerToolOpenRouter(global::OpenRouter.ApplyPatchServerToolOpenRouter? value) => new AdditionalToolsItemToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdditionalToolsItemToolsItems(global::OpenRouter.BashServerTool value) => new AdditionalToolsItemToolsItems((global::OpenRouter.BashServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.BashServerTool?(AdditionalToolsItemToolsItems @this) => @this.BashServerTool;

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(global::OpenRouter.BashServerTool? value)
        {
            BashServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AdditionalToolsItemToolsItems FromBashServerTool(global::OpenRouter.BashServerTool? value) => new AdditionalToolsItemToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdditionalToolsItemToolsItems(global::OpenRouter.ShellServerToolOpenRouter value) => new AdditionalToolsItemToolsItems((global::OpenRouter.ShellServerToolOpenRouter?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ShellServerToolOpenRouter?(AdditionalToolsItemToolsItems @this) => @this.ShellServerToolOpenRouter;

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(global::OpenRouter.ShellServerToolOpenRouter? value)
        {
            ShellServerToolOpenRouter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AdditionalToolsItemToolsItems FromShellServerToolOpenRouter(global::OpenRouter.ShellServerToolOpenRouter? value) => new AdditionalToolsItemToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AdditionalToolsItemToolsItems(global::OpenRouter.AdditionalToolsItemToolsItems27 value) => new AdditionalToolsItemToolsItems((global::OpenRouter.AdditionalToolsItemToolsItems27?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AdditionalToolsItemToolsItems27?(AdditionalToolsItemToolsItems @this) => @this.AdditionalToolsItemToolsItems27;

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(global::OpenRouter.AdditionalToolsItemToolsItems27? value)
        {
            AdditionalToolsItemToolsItems27 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AdditionalToolsItemToolsItems FromAdditionalToolsItemToolsItems27(global::OpenRouter.AdditionalToolsItemToolsItems27? value) => new AdditionalToolsItemToolsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public AdditionalToolsItemToolsItems(
            global::OpenRouter.AdditionalToolsItemToolsItems0? additionalToolsItemToolsItems0,
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
            global::OpenRouter.NamespaceTool? namespaceTool,
            global::OpenRouter.AdvisorServerToolOpenRouter? advisorServerToolOpenRouter,
            global::OpenRouter.SubagentServerToolOpenRouter? subagentServerToolOpenRouter,
            global::OpenRouter.DatetimeServerTool? datetimeServerTool,
            global::OpenRouter.FilesServerTool? filesServerTool,
            global::OpenRouter.FusionServerToolOpenRouter? fusionServerToolOpenRouter,
            global::OpenRouter.ImageGenerationServerToolOpenRouter? imageGenerationServerToolOpenRouter,
            global::OpenRouter.SearchModelsServerToolOpenRouter? searchModelsServerToolOpenRouter,
            global::OpenRouter.WebFetchServerTool? webFetchServerTool,
            global::OpenRouter.WebSearchServerToolOpenRouter? webSearchServerToolOpenRouter,
            global::OpenRouter.ApplyPatchServerToolOpenRouter? applyPatchServerToolOpenRouter,
            global::OpenRouter.BashServerTool? bashServerTool,
            global::OpenRouter.ShellServerToolOpenRouter? shellServerToolOpenRouter,
            global::OpenRouter.AdditionalToolsItemToolsItems27? additionalToolsItemToolsItems27
            )
        {
            AdditionalToolsItemToolsItems0 = additionalToolsItemToolsItems0;
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
            NamespaceTool = namespaceTool;
            AdvisorServerToolOpenRouter = advisorServerToolOpenRouter;
            SubagentServerToolOpenRouter = subagentServerToolOpenRouter;
            DatetimeServerTool = datetimeServerTool;
            FilesServerTool = filesServerTool;
            FusionServerToolOpenRouter = fusionServerToolOpenRouter;
            ImageGenerationServerToolOpenRouter = imageGenerationServerToolOpenRouter;
            SearchModelsServerToolOpenRouter = searchModelsServerToolOpenRouter;
            WebFetchServerTool = webFetchServerTool;
            WebSearchServerToolOpenRouter = webSearchServerToolOpenRouter;
            ApplyPatchServerToolOpenRouter = applyPatchServerToolOpenRouter;
            BashServerTool = bashServerTool;
            ShellServerToolOpenRouter = shellServerToolOpenRouter;
            AdditionalToolsItemToolsItems27 = additionalToolsItemToolsItems27;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AdditionalToolsItemToolsItems27 as object ??
            ShellServerToolOpenRouter as object ??
            BashServerTool as object ??
            ApplyPatchServerToolOpenRouter as object ??
            WebSearchServerToolOpenRouter as object ??
            WebFetchServerTool as object ??
            SearchModelsServerToolOpenRouter as object ??
            ImageGenerationServerToolOpenRouter as object ??
            FusionServerToolOpenRouter as object ??
            FilesServerTool as object ??
            DatetimeServerTool as object ??
            SubagentServerToolOpenRouter as object ??
            AdvisorServerToolOpenRouter as object ??
            NamespaceTool as object ??
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
            AdditionalToolsItemToolsItems0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AdditionalToolsItemToolsItems0?.ToString() ??
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
            NamespaceTool?.ToString() ??
            AdvisorServerToolOpenRouter?.ToString() ??
            SubagentServerToolOpenRouter?.ToString() ??
            DatetimeServerTool?.ToString() ??
            FilesServerTool?.ToString() ??
            FusionServerToolOpenRouter?.ToString() ??
            ImageGenerationServerToolOpenRouter?.ToString() ??
            SearchModelsServerToolOpenRouter?.ToString() ??
            WebFetchServerTool?.ToString() ??
            WebSearchServerToolOpenRouter?.ToString() ??
            ApplyPatchServerToolOpenRouter?.ToString() ??
            BashServerTool?.ToString() ??
            ShellServerToolOpenRouter?.ToString() ??
            AdditionalToolsItemToolsItems27?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAdditionalToolsItemToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsNamespaceTool && !IsAdvisorServerToolOpenRouter && !IsSubagentServerToolOpenRouter && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsSearchModelsServerToolOpenRouter && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter && !IsApplyPatchServerToolOpenRouter && !IsBashServerTool && !IsShellServerToolOpenRouter && !IsAdditionalToolsItemToolsItems27 || !IsAdditionalToolsItemToolsItems0 && IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsNamespaceTool && !IsAdvisorServerToolOpenRouter && !IsSubagentServerToolOpenRouter && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsSearchModelsServerToolOpenRouter && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter && !IsApplyPatchServerToolOpenRouter && !IsBashServerTool && !IsShellServerToolOpenRouter && !IsAdditionalToolsItemToolsItems27 || !IsAdditionalToolsItemToolsItems0 && !IsPreviewWebSearchServerTool && IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsNamespaceTool && !IsAdvisorServerToolOpenRouter && !IsSubagentServerToolOpenRouter && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsSearchModelsServerToolOpenRouter && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter && !IsApplyPatchServerToolOpenRouter && !IsBashServerTool && !IsShellServerToolOpenRouter && !IsAdditionalToolsItemToolsItems27 || !IsAdditionalToolsItemToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsNamespaceTool && !IsAdvisorServerToolOpenRouter && !IsSubagentServerToolOpenRouter && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsSearchModelsServerToolOpenRouter && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter && !IsApplyPatchServerToolOpenRouter && !IsBashServerTool && !IsShellServerToolOpenRouter && !IsAdditionalToolsItemToolsItems27 || !IsAdditionalToolsItemToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsNamespaceTool && !IsAdvisorServerToolOpenRouter && !IsSubagentServerToolOpenRouter && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsSearchModelsServerToolOpenRouter && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter && !IsApplyPatchServerToolOpenRouter && !IsBashServerTool && !IsShellServerToolOpenRouter && !IsAdditionalToolsItemToolsItems27 || !IsAdditionalToolsItemToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsNamespaceTool && !IsAdvisorServerToolOpenRouter && !IsSubagentServerToolOpenRouter && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsSearchModelsServerToolOpenRouter && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter && !IsApplyPatchServerToolOpenRouter && !IsBashServerTool && !IsShellServerToolOpenRouter && !IsAdditionalToolsItemToolsItems27 || !IsAdditionalToolsItemToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsNamespaceTool && !IsAdvisorServerToolOpenRouter && !IsSubagentServerToolOpenRouter && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsSearchModelsServerToolOpenRouter && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter && !IsApplyPatchServerToolOpenRouter && !IsBashServerTool && !IsShellServerToolOpenRouter && !IsAdditionalToolsItemToolsItems27 || !IsAdditionalToolsItemToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsNamespaceTool && !IsAdvisorServerToolOpenRouter && !IsSubagentServerToolOpenRouter && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsSearchModelsServerToolOpenRouter && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter && !IsApplyPatchServerToolOpenRouter && !IsBashServerTool && !IsShellServerToolOpenRouter && !IsAdditionalToolsItemToolsItems27 || !IsAdditionalToolsItemToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsNamespaceTool && !IsAdvisorServerToolOpenRouter && !IsSubagentServerToolOpenRouter && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsSearchModelsServerToolOpenRouter && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter && !IsApplyPatchServerToolOpenRouter && !IsBashServerTool && !IsShellServerToolOpenRouter && !IsAdditionalToolsItemToolsItems27 || !IsAdditionalToolsItemToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsNamespaceTool && !IsAdvisorServerToolOpenRouter && !IsSubagentServerToolOpenRouter && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsSearchModelsServerToolOpenRouter && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter && !IsApplyPatchServerToolOpenRouter && !IsBashServerTool && !IsShellServerToolOpenRouter && !IsAdditionalToolsItemToolsItems27 || !IsAdditionalToolsItemToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsNamespaceTool && !IsAdvisorServerToolOpenRouter && !IsSubagentServerToolOpenRouter && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsSearchModelsServerToolOpenRouter && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter && !IsApplyPatchServerToolOpenRouter && !IsBashServerTool && !IsShellServerToolOpenRouter && !IsAdditionalToolsItemToolsItems27 || !IsAdditionalToolsItemToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsNamespaceTool && !IsAdvisorServerToolOpenRouter && !IsSubagentServerToolOpenRouter && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsSearchModelsServerToolOpenRouter && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter && !IsApplyPatchServerToolOpenRouter && !IsBashServerTool && !IsShellServerToolOpenRouter && !IsAdditionalToolsItemToolsItems27 || !IsAdditionalToolsItemToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && IsApplyPatchServerTool && !IsCustomTool && !IsNamespaceTool && !IsAdvisorServerToolOpenRouter && !IsSubagentServerToolOpenRouter && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsSearchModelsServerToolOpenRouter && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter && !IsApplyPatchServerToolOpenRouter && !IsBashServerTool && !IsShellServerToolOpenRouter && !IsAdditionalToolsItemToolsItems27 || !IsAdditionalToolsItemToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && IsCustomTool && !IsNamespaceTool && !IsAdvisorServerToolOpenRouter && !IsSubagentServerToolOpenRouter && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsSearchModelsServerToolOpenRouter && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter && !IsApplyPatchServerToolOpenRouter && !IsBashServerTool && !IsShellServerToolOpenRouter && !IsAdditionalToolsItemToolsItems27 || !IsAdditionalToolsItemToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && IsNamespaceTool && !IsAdvisorServerToolOpenRouter && !IsSubagentServerToolOpenRouter && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsSearchModelsServerToolOpenRouter && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter && !IsApplyPatchServerToolOpenRouter && !IsBashServerTool && !IsShellServerToolOpenRouter && !IsAdditionalToolsItemToolsItems27 || !IsAdditionalToolsItemToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsNamespaceTool && IsAdvisorServerToolOpenRouter && !IsSubagentServerToolOpenRouter && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsSearchModelsServerToolOpenRouter && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter && !IsApplyPatchServerToolOpenRouter && !IsBashServerTool && !IsShellServerToolOpenRouter && !IsAdditionalToolsItemToolsItems27 || !IsAdditionalToolsItemToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsNamespaceTool && !IsAdvisorServerToolOpenRouter && IsSubagentServerToolOpenRouter && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsSearchModelsServerToolOpenRouter && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter && !IsApplyPatchServerToolOpenRouter && !IsBashServerTool && !IsShellServerToolOpenRouter && !IsAdditionalToolsItemToolsItems27 || !IsAdditionalToolsItemToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsNamespaceTool && !IsAdvisorServerToolOpenRouter && !IsSubagentServerToolOpenRouter && IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsSearchModelsServerToolOpenRouter && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter && !IsApplyPatchServerToolOpenRouter && !IsBashServerTool && !IsShellServerToolOpenRouter && !IsAdditionalToolsItemToolsItems27 || !IsAdditionalToolsItemToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsNamespaceTool && !IsAdvisorServerToolOpenRouter && !IsSubagentServerToolOpenRouter && !IsDatetimeServerTool && IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsSearchModelsServerToolOpenRouter && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter && !IsApplyPatchServerToolOpenRouter && !IsBashServerTool && !IsShellServerToolOpenRouter && !IsAdditionalToolsItemToolsItems27 || !IsAdditionalToolsItemToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsNamespaceTool && !IsAdvisorServerToolOpenRouter && !IsSubagentServerToolOpenRouter && !IsDatetimeServerTool && !IsFilesServerTool && IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsSearchModelsServerToolOpenRouter && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter && !IsApplyPatchServerToolOpenRouter && !IsBashServerTool && !IsShellServerToolOpenRouter && !IsAdditionalToolsItemToolsItems27 || !IsAdditionalToolsItemToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsNamespaceTool && !IsAdvisorServerToolOpenRouter && !IsSubagentServerToolOpenRouter && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && IsImageGenerationServerToolOpenRouter && !IsSearchModelsServerToolOpenRouter && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter && !IsApplyPatchServerToolOpenRouter && !IsBashServerTool && !IsShellServerToolOpenRouter && !IsAdditionalToolsItemToolsItems27 || !IsAdditionalToolsItemToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsNamespaceTool && !IsAdvisorServerToolOpenRouter && !IsSubagentServerToolOpenRouter && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && IsSearchModelsServerToolOpenRouter && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter && !IsApplyPatchServerToolOpenRouter && !IsBashServerTool && !IsShellServerToolOpenRouter && !IsAdditionalToolsItemToolsItems27 || !IsAdditionalToolsItemToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsNamespaceTool && !IsAdvisorServerToolOpenRouter && !IsSubagentServerToolOpenRouter && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsSearchModelsServerToolOpenRouter && IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter && !IsApplyPatchServerToolOpenRouter && !IsBashServerTool && !IsShellServerToolOpenRouter && !IsAdditionalToolsItemToolsItems27 || !IsAdditionalToolsItemToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsNamespaceTool && !IsAdvisorServerToolOpenRouter && !IsSubagentServerToolOpenRouter && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsSearchModelsServerToolOpenRouter && !IsWebFetchServerTool && IsWebSearchServerToolOpenRouter && !IsApplyPatchServerToolOpenRouter && !IsBashServerTool && !IsShellServerToolOpenRouter && !IsAdditionalToolsItemToolsItems27 || !IsAdditionalToolsItemToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsNamespaceTool && !IsAdvisorServerToolOpenRouter && !IsSubagentServerToolOpenRouter && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsSearchModelsServerToolOpenRouter && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter && IsApplyPatchServerToolOpenRouter && !IsBashServerTool && !IsShellServerToolOpenRouter && !IsAdditionalToolsItemToolsItems27 || !IsAdditionalToolsItemToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsNamespaceTool && !IsAdvisorServerToolOpenRouter && !IsSubagentServerToolOpenRouter && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsSearchModelsServerToolOpenRouter && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter && !IsApplyPatchServerToolOpenRouter && IsBashServerTool && !IsShellServerToolOpenRouter && !IsAdditionalToolsItemToolsItems27 || !IsAdditionalToolsItemToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsNamespaceTool && !IsAdvisorServerToolOpenRouter && !IsSubagentServerToolOpenRouter && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsSearchModelsServerToolOpenRouter && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter && !IsApplyPatchServerToolOpenRouter && !IsBashServerTool && IsShellServerToolOpenRouter && !IsAdditionalToolsItemToolsItems27 || !IsAdditionalToolsItemToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool && !IsNamespaceTool && !IsAdvisorServerToolOpenRouter && !IsSubagentServerToolOpenRouter && !IsDatetimeServerTool && !IsFilesServerTool && !IsFusionServerToolOpenRouter && !IsImageGenerationServerToolOpenRouter && !IsSearchModelsServerToolOpenRouter && !IsWebFetchServerTool && !IsWebSearchServerToolOpenRouter && !IsApplyPatchServerToolOpenRouter && !IsBashServerTool && !IsShellServerToolOpenRouter && IsAdditionalToolsItemToolsItems27;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AdditionalToolsItemToolsItems0, TResult>? additionalToolsItemToolsItems0 = null,
            global::System.Func<global::OpenRouter.PreviewWebSearchServerTool, TResult>? previewWebSearchServerTool = null,
            global::System.Func<global::OpenRouter.Preview20250311WebSearchServerTool, TResult>? preview20250311WebSearchServerTool = null,
            global::System.Func<global::OpenRouter.LegacyWebSearchServerTool, TResult>? legacyWebSearchServerTool = null,
            global::System.Func<global::OpenRouter.WebSearchServerTool, TResult>? webSearchServerTool = null,
            global::System.Func<global::OpenRouter.FileSearchServerTool, TResult>? fileSearchServerTool = null,
            global::System.Func<global::OpenRouter.ComputerUseServerTool, TResult>? computerUseServerTool = null,
            global::System.Func<global::OpenRouter.CodeInterpreterServerTool, TResult>? codeInterpreterServerTool = null,
            global::System.Func<global::OpenRouter.McpServerTool, TResult>? mcpServerTool = null,
            global::System.Func<global::OpenRouter.ImageGenerationServerTool, TResult>? imageGenerationServerTool = null,
            global::System.Func<global::OpenRouter.CodexLocalShellTool, TResult>? codexLocalShellTool = null,
            global::System.Func<global::OpenRouter.ShellServerTool, TResult>? shellServerTool = null,
            global::System.Func<global::OpenRouter.ApplyPatchServerTool, TResult>? applyPatchServerTool = null,
            global::System.Func<global::OpenRouter.CustomTool, TResult>? customTool = null,
            global::System.Func<global::OpenRouter.NamespaceTool, TResult>? namespaceTool = null,
            global::System.Func<global::OpenRouter.AdvisorServerToolOpenRouter, TResult>? advisorServerToolOpenRouter = null,
            global::System.Func<global::OpenRouter.SubagentServerToolOpenRouter, TResult>? subagentServerToolOpenRouter = null,
            global::System.Func<global::OpenRouter.DatetimeServerTool, TResult>? datetimeServerTool = null,
            global::System.Func<global::OpenRouter.FilesServerTool, TResult>? filesServerTool = null,
            global::System.Func<global::OpenRouter.FusionServerToolOpenRouter, TResult>? fusionServerToolOpenRouter = null,
            global::System.Func<global::OpenRouter.ImageGenerationServerToolOpenRouter, TResult>? imageGenerationServerToolOpenRouter = null,
            global::System.Func<global::OpenRouter.SearchModelsServerToolOpenRouter, TResult>? searchModelsServerToolOpenRouter = null,
            global::System.Func<global::OpenRouter.WebFetchServerTool, TResult>? webFetchServerTool = null,
            global::System.Func<global::OpenRouter.WebSearchServerToolOpenRouter, TResult>? webSearchServerToolOpenRouter = null,
            global::System.Func<global::OpenRouter.ApplyPatchServerToolOpenRouter, TResult>? applyPatchServerToolOpenRouter = null,
            global::System.Func<global::OpenRouter.BashServerTool, TResult>? bashServerTool = null,
            global::System.Func<global::OpenRouter.ShellServerToolOpenRouter, TResult>? shellServerToolOpenRouter = null,
            global::System.Func<global::OpenRouter.AdditionalToolsItemToolsItems27, TResult>? additionalToolsItemToolsItems27 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAdditionalToolsItemToolsItems0 && additionalToolsItemToolsItems0 != null)
            {
                return additionalToolsItemToolsItems0(AdditionalToolsItemToolsItems0!);
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
            else if (IsNamespaceTool && namespaceTool != null)
            {
                return namespaceTool(NamespaceTool!);
            }
            else if (IsAdvisorServerToolOpenRouter && advisorServerToolOpenRouter != null)
            {
                return advisorServerToolOpenRouter(AdvisorServerToolOpenRouter!);
            }
            else if (IsSubagentServerToolOpenRouter && subagentServerToolOpenRouter != null)
            {
                return subagentServerToolOpenRouter(SubagentServerToolOpenRouter!);
            }
            else if (IsDatetimeServerTool && datetimeServerTool != null)
            {
                return datetimeServerTool(DatetimeServerTool!);
            }
            else if (IsFilesServerTool && filesServerTool != null)
            {
                return filesServerTool(FilesServerTool!);
            }
            else if (IsFusionServerToolOpenRouter && fusionServerToolOpenRouter != null)
            {
                return fusionServerToolOpenRouter(FusionServerToolOpenRouter!);
            }
            else if (IsImageGenerationServerToolOpenRouter && imageGenerationServerToolOpenRouter != null)
            {
                return imageGenerationServerToolOpenRouter(ImageGenerationServerToolOpenRouter!);
            }
            else if (IsSearchModelsServerToolOpenRouter && searchModelsServerToolOpenRouter != null)
            {
                return searchModelsServerToolOpenRouter(SearchModelsServerToolOpenRouter!);
            }
            else if (IsWebFetchServerTool && webFetchServerTool != null)
            {
                return webFetchServerTool(WebFetchServerTool!);
            }
            else if (IsWebSearchServerToolOpenRouter && webSearchServerToolOpenRouter != null)
            {
                return webSearchServerToolOpenRouter(WebSearchServerToolOpenRouter!);
            }
            else if (IsApplyPatchServerToolOpenRouter && applyPatchServerToolOpenRouter != null)
            {
                return applyPatchServerToolOpenRouter(ApplyPatchServerToolOpenRouter!);
            }
            else if (IsBashServerTool && bashServerTool != null)
            {
                return bashServerTool(BashServerTool!);
            }
            else if (IsShellServerToolOpenRouter && shellServerToolOpenRouter != null)
            {
                return shellServerToolOpenRouter(ShellServerToolOpenRouter!);
            }
            else if (IsAdditionalToolsItemToolsItems27 && additionalToolsItemToolsItems27 != null)
            {
                return additionalToolsItemToolsItems27(AdditionalToolsItemToolsItems27!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AdditionalToolsItemToolsItems0>? additionalToolsItemToolsItems0 = null,

            global::System.Action<global::OpenRouter.PreviewWebSearchServerTool>? previewWebSearchServerTool = null,

            global::System.Action<global::OpenRouter.Preview20250311WebSearchServerTool>? preview20250311WebSearchServerTool = null,

            global::System.Action<global::OpenRouter.LegacyWebSearchServerTool>? legacyWebSearchServerTool = null,

            global::System.Action<global::OpenRouter.WebSearchServerTool>? webSearchServerTool = null,

            global::System.Action<global::OpenRouter.FileSearchServerTool>? fileSearchServerTool = null,

            global::System.Action<global::OpenRouter.ComputerUseServerTool>? computerUseServerTool = null,

            global::System.Action<global::OpenRouter.CodeInterpreterServerTool>? codeInterpreterServerTool = null,

            global::System.Action<global::OpenRouter.McpServerTool>? mcpServerTool = null,

            global::System.Action<global::OpenRouter.ImageGenerationServerTool>? imageGenerationServerTool = null,

            global::System.Action<global::OpenRouter.CodexLocalShellTool>? codexLocalShellTool = null,

            global::System.Action<global::OpenRouter.ShellServerTool>? shellServerTool = null,

            global::System.Action<global::OpenRouter.ApplyPatchServerTool>? applyPatchServerTool = null,

            global::System.Action<global::OpenRouter.CustomTool>? customTool = null,

            global::System.Action<global::OpenRouter.NamespaceTool>? namespaceTool = null,

            global::System.Action<global::OpenRouter.AdvisorServerToolOpenRouter>? advisorServerToolOpenRouter = null,

            global::System.Action<global::OpenRouter.SubagentServerToolOpenRouter>? subagentServerToolOpenRouter = null,

            global::System.Action<global::OpenRouter.DatetimeServerTool>? datetimeServerTool = null,

            global::System.Action<global::OpenRouter.FilesServerTool>? filesServerTool = null,

            global::System.Action<global::OpenRouter.FusionServerToolOpenRouter>? fusionServerToolOpenRouter = null,

            global::System.Action<global::OpenRouter.ImageGenerationServerToolOpenRouter>? imageGenerationServerToolOpenRouter = null,

            global::System.Action<global::OpenRouter.SearchModelsServerToolOpenRouter>? searchModelsServerToolOpenRouter = null,

            global::System.Action<global::OpenRouter.WebFetchServerTool>? webFetchServerTool = null,

            global::System.Action<global::OpenRouter.WebSearchServerToolOpenRouter>? webSearchServerToolOpenRouter = null,

            global::System.Action<global::OpenRouter.ApplyPatchServerToolOpenRouter>? applyPatchServerToolOpenRouter = null,

            global::System.Action<global::OpenRouter.BashServerTool>? bashServerTool = null,

            global::System.Action<global::OpenRouter.ShellServerToolOpenRouter>? shellServerToolOpenRouter = null,

            global::System.Action<global::OpenRouter.AdditionalToolsItemToolsItems27>? additionalToolsItemToolsItems27 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAdditionalToolsItemToolsItems0)
            {
                additionalToolsItemToolsItems0?.Invoke(AdditionalToolsItemToolsItems0!);
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
            else if (IsNamespaceTool)
            {
                namespaceTool?.Invoke(NamespaceTool!);
            }
            else if (IsAdvisorServerToolOpenRouter)
            {
                advisorServerToolOpenRouter?.Invoke(AdvisorServerToolOpenRouter!);
            }
            else if (IsSubagentServerToolOpenRouter)
            {
                subagentServerToolOpenRouter?.Invoke(SubagentServerToolOpenRouter!);
            }
            else if (IsDatetimeServerTool)
            {
                datetimeServerTool?.Invoke(DatetimeServerTool!);
            }
            else if (IsFilesServerTool)
            {
                filesServerTool?.Invoke(FilesServerTool!);
            }
            else if (IsFusionServerToolOpenRouter)
            {
                fusionServerToolOpenRouter?.Invoke(FusionServerToolOpenRouter!);
            }
            else if (IsImageGenerationServerToolOpenRouter)
            {
                imageGenerationServerToolOpenRouter?.Invoke(ImageGenerationServerToolOpenRouter!);
            }
            else if (IsSearchModelsServerToolOpenRouter)
            {
                searchModelsServerToolOpenRouter?.Invoke(SearchModelsServerToolOpenRouter!);
            }
            else if (IsWebFetchServerTool)
            {
                webFetchServerTool?.Invoke(WebFetchServerTool!);
            }
            else if (IsWebSearchServerToolOpenRouter)
            {
                webSearchServerToolOpenRouter?.Invoke(WebSearchServerToolOpenRouter!);
            }
            else if (IsApplyPatchServerToolOpenRouter)
            {
                applyPatchServerToolOpenRouter?.Invoke(ApplyPatchServerToolOpenRouter!);
            }
            else if (IsBashServerTool)
            {
                bashServerTool?.Invoke(BashServerTool!);
            }
            else if (IsShellServerToolOpenRouter)
            {
                shellServerToolOpenRouter?.Invoke(ShellServerToolOpenRouter!);
            }
            else if (IsAdditionalToolsItemToolsItems27)
            {
                additionalToolsItemToolsItems27?.Invoke(AdditionalToolsItemToolsItems27!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AdditionalToolsItemToolsItems0>? additionalToolsItemToolsItems0 = null,
            global::System.Action<global::OpenRouter.PreviewWebSearchServerTool>? previewWebSearchServerTool = null,
            global::System.Action<global::OpenRouter.Preview20250311WebSearchServerTool>? preview20250311WebSearchServerTool = null,
            global::System.Action<global::OpenRouter.LegacyWebSearchServerTool>? legacyWebSearchServerTool = null,
            global::System.Action<global::OpenRouter.WebSearchServerTool>? webSearchServerTool = null,
            global::System.Action<global::OpenRouter.FileSearchServerTool>? fileSearchServerTool = null,
            global::System.Action<global::OpenRouter.ComputerUseServerTool>? computerUseServerTool = null,
            global::System.Action<global::OpenRouter.CodeInterpreterServerTool>? codeInterpreterServerTool = null,
            global::System.Action<global::OpenRouter.McpServerTool>? mcpServerTool = null,
            global::System.Action<global::OpenRouter.ImageGenerationServerTool>? imageGenerationServerTool = null,
            global::System.Action<global::OpenRouter.CodexLocalShellTool>? codexLocalShellTool = null,
            global::System.Action<global::OpenRouter.ShellServerTool>? shellServerTool = null,
            global::System.Action<global::OpenRouter.ApplyPatchServerTool>? applyPatchServerTool = null,
            global::System.Action<global::OpenRouter.CustomTool>? customTool = null,
            global::System.Action<global::OpenRouter.NamespaceTool>? namespaceTool = null,
            global::System.Action<global::OpenRouter.AdvisorServerToolOpenRouter>? advisorServerToolOpenRouter = null,
            global::System.Action<global::OpenRouter.SubagentServerToolOpenRouter>? subagentServerToolOpenRouter = null,
            global::System.Action<global::OpenRouter.DatetimeServerTool>? datetimeServerTool = null,
            global::System.Action<global::OpenRouter.FilesServerTool>? filesServerTool = null,
            global::System.Action<global::OpenRouter.FusionServerToolOpenRouter>? fusionServerToolOpenRouter = null,
            global::System.Action<global::OpenRouter.ImageGenerationServerToolOpenRouter>? imageGenerationServerToolOpenRouter = null,
            global::System.Action<global::OpenRouter.SearchModelsServerToolOpenRouter>? searchModelsServerToolOpenRouter = null,
            global::System.Action<global::OpenRouter.WebFetchServerTool>? webFetchServerTool = null,
            global::System.Action<global::OpenRouter.WebSearchServerToolOpenRouter>? webSearchServerToolOpenRouter = null,
            global::System.Action<global::OpenRouter.ApplyPatchServerToolOpenRouter>? applyPatchServerToolOpenRouter = null,
            global::System.Action<global::OpenRouter.BashServerTool>? bashServerTool = null,
            global::System.Action<global::OpenRouter.ShellServerToolOpenRouter>? shellServerToolOpenRouter = null,
            global::System.Action<global::OpenRouter.AdditionalToolsItemToolsItems27>? additionalToolsItemToolsItems27 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAdditionalToolsItemToolsItems0)
            {
                additionalToolsItemToolsItems0?.Invoke(AdditionalToolsItemToolsItems0!);
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
            else if (IsNamespaceTool)
            {
                namespaceTool?.Invoke(NamespaceTool!);
            }
            else if (IsAdvisorServerToolOpenRouter)
            {
                advisorServerToolOpenRouter?.Invoke(AdvisorServerToolOpenRouter!);
            }
            else if (IsSubagentServerToolOpenRouter)
            {
                subagentServerToolOpenRouter?.Invoke(SubagentServerToolOpenRouter!);
            }
            else if (IsDatetimeServerTool)
            {
                datetimeServerTool?.Invoke(DatetimeServerTool!);
            }
            else if (IsFilesServerTool)
            {
                filesServerTool?.Invoke(FilesServerTool!);
            }
            else if (IsFusionServerToolOpenRouter)
            {
                fusionServerToolOpenRouter?.Invoke(FusionServerToolOpenRouter!);
            }
            else if (IsImageGenerationServerToolOpenRouter)
            {
                imageGenerationServerToolOpenRouter?.Invoke(ImageGenerationServerToolOpenRouter!);
            }
            else if (IsSearchModelsServerToolOpenRouter)
            {
                searchModelsServerToolOpenRouter?.Invoke(SearchModelsServerToolOpenRouter!);
            }
            else if (IsWebFetchServerTool)
            {
                webFetchServerTool?.Invoke(WebFetchServerTool!);
            }
            else if (IsWebSearchServerToolOpenRouter)
            {
                webSearchServerToolOpenRouter?.Invoke(WebSearchServerToolOpenRouter!);
            }
            else if (IsApplyPatchServerToolOpenRouter)
            {
                applyPatchServerToolOpenRouter?.Invoke(ApplyPatchServerToolOpenRouter!);
            }
            else if (IsBashServerTool)
            {
                bashServerTool?.Invoke(BashServerTool!);
            }
            else if (IsShellServerToolOpenRouter)
            {
                shellServerToolOpenRouter?.Invoke(ShellServerToolOpenRouter!);
            }
            else if (IsAdditionalToolsItemToolsItems27)
            {
                additionalToolsItemToolsItems27?.Invoke(AdditionalToolsItemToolsItems27!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AdditionalToolsItemToolsItems0,
                typeof(global::OpenRouter.AdditionalToolsItemToolsItems0),
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
                NamespaceTool,
                typeof(global::OpenRouter.NamespaceTool),
                AdvisorServerToolOpenRouter,
                typeof(global::OpenRouter.AdvisorServerToolOpenRouter),
                SubagentServerToolOpenRouter,
                typeof(global::OpenRouter.SubagentServerToolOpenRouter),
                DatetimeServerTool,
                typeof(global::OpenRouter.DatetimeServerTool),
                FilesServerTool,
                typeof(global::OpenRouter.FilesServerTool),
                FusionServerToolOpenRouter,
                typeof(global::OpenRouter.FusionServerToolOpenRouter),
                ImageGenerationServerToolOpenRouter,
                typeof(global::OpenRouter.ImageGenerationServerToolOpenRouter),
                SearchModelsServerToolOpenRouter,
                typeof(global::OpenRouter.SearchModelsServerToolOpenRouter),
                WebFetchServerTool,
                typeof(global::OpenRouter.WebFetchServerTool),
                WebSearchServerToolOpenRouter,
                typeof(global::OpenRouter.WebSearchServerToolOpenRouter),
                ApplyPatchServerToolOpenRouter,
                typeof(global::OpenRouter.ApplyPatchServerToolOpenRouter),
                BashServerTool,
                typeof(global::OpenRouter.BashServerTool),
                ShellServerToolOpenRouter,
                typeof(global::OpenRouter.ShellServerToolOpenRouter),
                AdditionalToolsItemToolsItems27,
                typeof(global::OpenRouter.AdditionalToolsItemToolsItems27),
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
        public bool Equals(AdditionalToolsItemToolsItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AdditionalToolsItemToolsItems0?>.Default.Equals(AdditionalToolsItemToolsItems0, other.AdditionalToolsItemToolsItems0) &&
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.NamespaceTool?>.Default.Equals(NamespaceTool, other.NamespaceTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AdvisorServerToolOpenRouter?>.Default.Equals(AdvisorServerToolOpenRouter, other.AdvisorServerToolOpenRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.SubagentServerToolOpenRouter?>.Default.Equals(SubagentServerToolOpenRouter, other.SubagentServerToolOpenRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.DatetimeServerTool?>.Default.Equals(DatetimeServerTool, other.DatetimeServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FilesServerTool?>.Default.Equals(FilesServerTool, other.FilesServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FusionServerToolOpenRouter?>.Default.Equals(FusionServerToolOpenRouter, other.FusionServerToolOpenRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ImageGenerationServerToolOpenRouter?>.Default.Equals(ImageGenerationServerToolOpenRouter, other.ImageGenerationServerToolOpenRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.SearchModelsServerToolOpenRouter?>.Default.Equals(SearchModelsServerToolOpenRouter, other.SearchModelsServerToolOpenRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.WebFetchServerTool?>.Default.Equals(WebFetchServerTool, other.WebFetchServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.WebSearchServerToolOpenRouter?>.Default.Equals(WebSearchServerToolOpenRouter, other.WebSearchServerToolOpenRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ApplyPatchServerToolOpenRouter?>.Default.Equals(ApplyPatchServerToolOpenRouter, other.ApplyPatchServerToolOpenRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BashServerTool?>.Default.Equals(BashServerTool, other.BashServerTool) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ShellServerToolOpenRouter?>.Default.Equals(ShellServerToolOpenRouter, other.ShellServerToolOpenRouter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AdditionalToolsItemToolsItems27?>.Default.Equals(AdditionalToolsItemToolsItems27, other.AdditionalToolsItemToolsItems27) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AdditionalToolsItemToolsItems obj1, AdditionalToolsItemToolsItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AdditionalToolsItemToolsItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AdditionalToolsItemToolsItems obj1, AdditionalToolsItemToolsItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AdditionalToolsItemToolsItems o && Equals(o);
        }
    }
}
