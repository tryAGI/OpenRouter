#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OpenResponsesResultToolsItems : global::System.IEquatable<OpenResponsesResultToolsItems>
    {
        /// <summary>
        /// Function tool definition
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenResponsesResultToolsItems0? OpenResponsesResultToolsItems0 { get; init; }
#else
        public global::OpenRouter.OpenResponsesResultToolsItems0? OpenResponsesResultToolsItems0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenResponsesResultToolsItems0))]
#endif
        public bool IsOpenResponsesResultToolsItems0 => OpenResponsesResultToolsItems0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOpenResponsesResultToolsItems0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenResponsesResultToolsItems0? value)
        {
            value = OpenResponsesResultToolsItems0;
            return IsOpenResponsesResultToolsItems0;
        }

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
        public static implicit operator OpenResponsesResultToolsItems(global::OpenRouter.OpenResponsesResultToolsItems0 value) => new OpenResponsesResultToolsItems((global::OpenRouter.OpenResponsesResultToolsItems0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OpenResponsesResultToolsItems0?(OpenResponsesResultToolsItems @this) => @this.OpenResponsesResultToolsItems0;

        /// <summary>
        /// 
        /// </summary>
        public OpenResponsesResultToolsItems(global::OpenRouter.OpenResponsesResultToolsItems0? value)
        {
            OpenResponsesResultToolsItems0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenResponsesResultToolsItems(global::OpenRouter.PreviewWebSearchServerTool value) => new OpenResponsesResultToolsItems((global::OpenRouter.PreviewWebSearchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.PreviewWebSearchServerTool?(OpenResponsesResultToolsItems @this) => @this.PreviewWebSearchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public OpenResponsesResultToolsItems(global::OpenRouter.PreviewWebSearchServerTool? value)
        {
            PreviewWebSearchServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenResponsesResultToolsItems(global::OpenRouter.Preview20250311WebSearchServerTool value) => new OpenResponsesResultToolsItems((global::OpenRouter.Preview20250311WebSearchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.Preview20250311WebSearchServerTool?(OpenResponsesResultToolsItems @this) => @this.Preview20250311WebSearchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public OpenResponsesResultToolsItems(global::OpenRouter.Preview20250311WebSearchServerTool? value)
        {
            Preview20250311WebSearchServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenResponsesResultToolsItems(global::OpenRouter.LegacyWebSearchServerTool value) => new OpenResponsesResultToolsItems((global::OpenRouter.LegacyWebSearchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.LegacyWebSearchServerTool?(OpenResponsesResultToolsItems @this) => @this.LegacyWebSearchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public OpenResponsesResultToolsItems(global::OpenRouter.LegacyWebSearchServerTool? value)
        {
            LegacyWebSearchServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenResponsesResultToolsItems(global::OpenRouter.WebSearchServerTool value) => new OpenResponsesResultToolsItems((global::OpenRouter.WebSearchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.WebSearchServerTool?(OpenResponsesResultToolsItems @this) => @this.WebSearchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public OpenResponsesResultToolsItems(global::OpenRouter.WebSearchServerTool? value)
        {
            WebSearchServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenResponsesResultToolsItems(global::OpenRouter.FileSearchServerTool value) => new OpenResponsesResultToolsItems((global::OpenRouter.FileSearchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.FileSearchServerTool?(OpenResponsesResultToolsItems @this) => @this.FileSearchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public OpenResponsesResultToolsItems(global::OpenRouter.FileSearchServerTool? value)
        {
            FileSearchServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenResponsesResultToolsItems(global::OpenRouter.ComputerUseServerTool value) => new OpenResponsesResultToolsItems((global::OpenRouter.ComputerUseServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ComputerUseServerTool?(OpenResponsesResultToolsItems @this) => @this.ComputerUseServerTool;

        /// <summary>
        /// 
        /// </summary>
        public OpenResponsesResultToolsItems(global::OpenRouter.ComputerUseServerTool? value)
        {
            ComputerUseServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenResponsesResultToolsItems(global::OpenRouter.CodeInterpreterServerTool value) => new OpenResponsesResultToolsItems((global::OpenRouter.CodeInterpreterServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CodeInterpreterServerTool?(OpenResponsesResultToolsItems @this) => @this.CodeInterpreterServerTool;

        /// <summary>
        /// 
        /// </summary>
        public OpenResponsesResultToolsItems(global::OpenRouter.CodeInterpreterServerTool? value)
        {
            CodeInterpreterServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenResponsesResultToolsItems(global::OpenRouter.McpServerTool value) => new OpenResponsesResultToolsItems((global::OpenRouter.McpServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.McpServerTool?(OpenResponsesResultToolsItems @this) => @this.McpServerTool;

        /// <summary>
        /// 
        /// </summary>
        public OpenResponsesResultToolsItems(global::OpenRouter.McpServerTool? value)
        {
            McpServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenResponsesResultToolsItems(global::OpenRouter.ImageGenerationServerTool value) => new OpenResponsesResultToolsItems((global::OpenRouter.ImageGenerationServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ImageGenerationServerTool?(OpenResponsesResultToolsItems @this) => @this.ImageGenerationServerTool;

        /// <summary>
        /// 
        /// </summary>
        public OpenResponsesResultToolsItems(global::OpenRouter.ImageGenerationServerTool? value)
        {
            ImageGenerationServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenResponsesResultToolsItems(global::OpenRouter.CodexLocalShellTool value) => new OpenResponsesResultToolsItems((global::OpenRouter.CodexLocalShellTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CodexLocalShellTool?(OpenResponsesResultToolsItems @this) => @this.CodexLocalShellTool;

        /// <summary>
        /// 
        /// </summary>
        public OpenResponsesResultToolsItems(global::OpenRouter.CodexLocalShellTool? value)
        {
            CodexLocalShellTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenResponsesResultToolsItems(global::OpenRouter.ShellServerTool value) => new OpenResponsesResultToolsItems((global::OpenRouter.ShellServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ShellServerTool?(OpenResponsesResultToolsItems @this) => @this.ShellServerTool;

        /// <summary>
        /// 
        /// </summary>
        public OpenResponsesResultToolsItems(global::OpenRouter.ShellServerTool? value)
        {
            ShellServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenResponsesResultToolsItems(global::OpenRouter.ApplyPatchServerTool value) => new OpenResponsesResultToolsItems((global::OpenRouter.ApplyPatchServerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ApplyPatchServerTool?(OpenResponsesResultToolsItems @this) => @this.ApplyPatchServerTool;

        /// <summary>
        /// 
        /// </summary>
        public OpenResponsesResultToolsItems(global::OpenRouter.ApplyPatchServerTool? value)
        {
            ApplyPatchServerTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenResponsesResultToolsItems(global::OpenRouter.CustomTool value) => new OpenResponsesResultToolsItems((global::OpenRouter.CustomTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.CustomTool?(OpenResponsesResultToolsItems @this) => @this.CustomTool;

        /// <summary>
        /// 
        /// </summary>
        public OpenResponsesResultToolsItems(global::OpenRouter.CustomTool? value)
        {
            CustomTool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OpenResponsesResultToolsItems(
            global::OpenRouter.OpenResponsesResultToolsItems0? openResponsesResultToolsItems0,
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
            global::OpenRouter.CustomTool? customTool
            )
        {
            OpenResponsesResultToolsItems0 = openResponsesResultToolsItems0;
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
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            OpenResponsesResultToolsItems0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OpenResponsesResultToolsItems0?.ToString() ??
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
            CustomTool?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOpenResponsesResultToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool || !IsOpenResponsesResultToolsItems0 && IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool || !IsOpenResponsesResultToolsItems0 && !IsPreviewWebSearchServerTool && IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool || !IsOpenResponsesResultToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool || !IsOpenResponsesResultToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool || !IsOpenResponsesResultToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool || !IsOpenResponsesResultToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool || !IsOpenResponsesResultToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool || !IsOpenResponsesResultToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool || !IsOpenResponsesResultToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool || !IsOpenResponsesResultToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool || !IsOpenResponsesResultToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && IsShellServerTool && !IsApplyPatchServerTool && !IsCustomTool || !IsOpenResponsesResultToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && IsApplyPatchServerTool && !IsCustomTool || !IsOpenResponsesResultToolsItems0 && !IsPreviewWebSearchServerTool && !IsPreview20250311WebSearchServerTool && !IsLegacyWebSearchServerTool && !IsWebSearchServerTool && !IsFileSearchServerTool && !IsComputerUseServerTool && !IsCodeInterpreterServerTool && !IsMcpServerTool && !IsImageGenerationServerTool && !IsCodexLocalShellTool && !IsShellServerTool && !IsApplyPatchServerTool && IsCustomTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OpenResponsesResultToolsItems0, TResult>? openResponsesResultToolsItems0 = null,
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
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenResponsesResultToolsItems0 && openResponsesResultToolsItems0 != null)
            {
                return openResponsesResultToolsItems0(OpenResponsesResultToolsItems0!);
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OpenResponsesResultToolsItems0>? openResponsesResultToolsItems0 = null,

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
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenResponsesResultToolsItems0)
            {
                openResponsesResultToolsItems0?.Invoke(OpenResponsesResultToolsItems0!);
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
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OpenResponsesResultToolsItems0>? openResponsesResultToolsItems0 = null,
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
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOpenResponsesResultToolsItems0)
            {
                openResponsesResultToolsItems0?.Invoke(OpenResponsesResultToolsItems0!);
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OpenResponsesResultToolsItems0,
                typeof(global::OpenRouter.OpenResponsesResultToolsItems0),
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
        public bool Equals(OpenResponsesResultToolsItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenResponsesResultToolsItems0?>.Default.Equals(OpenResponsesResultToolsItems0, other.OpenResponsesResultToolsItems0) &&
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CustomTool?>.Default.Equals(CustomTool, other.CustomTool) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OpenResponsesResultToolsItems obj1, OpenResponsesResultToolsItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OpenResponsesResultToolsItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OpenResponsesResultToolsItems obj1, OpenResponsesResultToolsItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OpenResponsesResultToolsItems o && Equals(o);
        }
    }
}
