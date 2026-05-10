#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ORAnthropicContentBlock : global::System.IEquatable<ORAnthropicContentBlock>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockDiscriminatorType? Type { get; }

        /// <summary>
        /// bash_code_execution_tool_result variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicContentBlockVariant1? BashCodeExecutionToolResult { get; init; }
#else
        public global::OpenRouter.ORAnthropicContentBlockVariant1? BashCodeExecutionToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BashCodeExecutionToolResult))]
#endif
        public bool IsBashCodeExecutionToolResult => BashCodeExecutionToolResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBashCodeExecutionToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ORAnthropicContentBlockVariant1? value)
        {
            value = BashCodeExecutionToolResult;
            return IsBashCodeExecutionToolResult;
        }

        /// <summary>
        /// code_execution_tool_result variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicContentBlockVariant2? CodeExecutionToolResult { get; init; }
#else
        public global::OpenRouter.ORAnthropicContentBlockVariant2? CodeExecutionToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeExecutionToolResult))]
#endif
        public bool IsCodeExecutionToolResult => CodeExecutionToolResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCodeExecutionToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ORAnthropicContentBlockVariant2? value)
        {
            value = CodeExecutionToolResult;
            return IsCodeExecutionToolResult;
        }

        /// <summary>
        /// compaction variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicContentBlockVariant3? Compaction { get; init; }
#else
        public global::OpenRouter.ORAnthropicContentBlockVariant3? Compaction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Compaction))]
#endif
        public bool IsCompaction => Compaction != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCompaction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ORAnthropicContentBlockVariant3? value)
        {
            value = Compaction;
            return IsCompaction;
        }

        /// <summary>
        /// container_upload variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicContentBlockVariant4? ContainerUpload { get; init; }
#else
        public global::OpenRouter.ORAnthropicContentBlockVariant4? ContainerUpload { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContainerUpload))]
#endif
        public bool IsContainerUpload => ContainerUpload != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickContainerUpload(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ORAnthropicContentBlockVariant4? value)
        {
            value = ContainerUpload;
            return IsContainerUpload;
        }

        /// <summary>
        /// redacted_thinking variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicContentBlockVariant5? RedactedThinking { get; init; }
#else
        public global::OpenRouter.ORAnthropicContentBlockVariant5? RedactedThinking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RedactedThinking))]
#endif
        public bool IsRedactedThinking => RedactedThinking != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRedactedThinking(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ORAnthropicContentBlockVariant5? value)
        {
            value = RedactedThinking;
            return IsRedactedThinking;
        }

        /// <summary>
        /// server_tool_use variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicContentBlockVariant6? ServerToolUse { get; init; }
#else
        public global::OpenRouter.ORAnthropicContentBlockVariant6? ServerToolUse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ServerToolUse))]
#endif
        public bool IsServerToolUse => ServerToolUse != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickServerToolUse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ORAnthropicContentBlockVariant6? value)
        {
            value = ServerToolUse;
            return IsServerToolUse;
        }

        /// <summary>
        /// text variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicContentBlockVariant7? Text { get; init; }
#else
        public global::OpenRouter.ORAnthropicContentBlockVariant7? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ORAnthropicContentBlockVariant7? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        /// text_editor_code_execution_tool_result variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicContentBlockVariant8? TextEditorCodeExecutionToolResult { get; init; }
#else
        public global::OpenRouter.ORAnthropicContentBlockVariant8? TextEditorCodeExecutionToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextEditorCodeExecutionToolResult))]
#endif
        public bool IsTextEditorCodeExecutionToolResult => TextEditorCodeExecutionToolResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTextEditorCodeExecutionToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ORAnthropicContentBlockVariant8? value)
        {
            value = TextEditorCodeExecutionToolResult;
            return IsTextEditorCodeExecutionToolResult;
        }

        /// <summary>
        /// thinking variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicContentBlockVariant9? Thinking { get; init; }
#else
        public global::OpenRouter.ORAnthropicContentBlockVariant9? Thinking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Thinking))]
#endif
        public bool IsThinking => Thinking != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickThinking(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ORAnthropicContentBlockVariant9? value)
        {
            value = Thinking;
            return IsThinking;
        }

        /// <summary>
        /// tool_search_tool_result variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicContentBlockVariant10? ToolSearchToolResult { get; init; }
#else
        public global::OpenRouter.ORAnthropicContentBlockVariant10? ToolSearchToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolSearchToolResult))]
#endif
        public bool IsToolSearchToolResult => ToolSearchToolResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickToolSearchToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ORAnthropicContentBlockVariant10? value)
        {
            value = ToolSearchToolResult;
            return IsToolSearchToolResult;
        }

        /// <summary>
        /// tool_use variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicContentBlockVariant11? ToolUse { get; init; }
#else
        public global::OpenRouter.ORAnthropicContentBlockVariant11? ToolUse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolUse))]
#endif
        public bool IsToolUse => ToolUse != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickToolUse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ORAnthropicContentBlockVariant11? value)
        {
            value = ToolUse;
            return IsToolUse;
        }

        /// <summary>
        /// web_fetch_tool_result variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicContentBlockVariant12? WebFetchToolResult { get; init; }
#else
        public global::OpenRouter.ORAnthropicContentBlockVariant12? WebFetchToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebFetchToolResult))]
#endif
        public bool IsWebFetchToolResult => WebFetchToolResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebFetchToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ORAnthropicContentBlockVariant12? value)
        {
            value = WebFetchToolResult;
            return IsWebFetchToolResult;
        }

        /// <summary>
        /// web_search_tool_result variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicContentBlockVariant13? WebSearchToolResult { get; init; }
#else
        public global::OpenRouter.ORAnthropicContentBlockVariant13? WebSearchToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchToolResult))]
#endif
        public bool IsWebSearchToolResult => WebSearchToolResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWebSearchToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ORAnthropicContentBlockVariant13? value)
        {
            value = WebSearchToolResult;
            return IsWebSearchToolResult;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant1 value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicContentBlockVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicContentBlockVariant1?(ORAnthropicContentBlock @this) => @this.BashCodeExecutionToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant1? value)
        {
            BashCodeExecutionToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant2 value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicContentBlockVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicContentBlockVariant2?(ORAnthropicContentBlock @this) => @this.CodeExecutionToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant2? value)
        {
            CodeExecutionToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant3 value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicContentBlockVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicContentBlockVariant3?(ORAnthropicContentBlock @this) => @this.Compaction;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant3? value)
        {
            Compaction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant4 value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicContentBlockVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicContentBlockVariant4?(ORAnthropicContentBlock @this) => @this.ContainerUpload;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant4? value)
        {
            ContainerUpload = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant5 value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicContentBlockVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicContentBlockVariant5?(ORAnthropicContentBlock @this) => @this.RedactedThinking;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant5? value)
        {
            RedactedThinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant6 value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicContentBlockVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicContentBlockVariant6?(ORAnthropicContentBlock @this) => @this.ServerToolUse;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant6? value)
        {
            ServerToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant7 value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicContentBlockVariant7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicContentBlockVariant7?(ORAnthropicContentBlock @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant7? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant8 value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicContentBlockVariant8?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicContentBlockVariant8?(ORAnthropicContentBlock @this) => @this.TextEditorCodeExecutionToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant8? value)
        {
            TextEditorCodeExecutionToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant9 value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicContentBlockVariant9?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicContentBlockVariant9?(ORAnthropicContentBlock @this) => @this.Thinking;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant9? value)
        {
            Thinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant10 value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicContentBlockVariant10?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicContentBlockVariant10?(ORAnthropicContentBlock @this) => @this.ToolSearchToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant10? value)
        {
            ToolSearchToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant11 value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicContentBlockVariant11?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicContentBlockVariant11?(ORAnthropicContentBlock @this) => @this.ToolUse;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant11? value)
        {
            ToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant12 value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicContentBlockVariant12?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicContentBlockVariant12?(ORAnthropicContentBlock @this) => @this.WebFetchToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant12? value)
        {
            WebFetchToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant13 value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicContentBlockVariant13?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicContentBlockVariant13?(ORAnthropicContentBlock @this) => @this.WebSearchToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant13? value)
        {
            WebSearchToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(
            global::OpenRouter.ORAnthropicContentBlockDiscriminatorType? type,
            global::OpenRouter.ORAnthropicContentBlockVariant1? bashCodeExecutionToolResult,
            global::OpenRouter.ORAnthropicContentBlockVariant2? codeExecutionToolResult,
            global::OpenRouter.ORAnthropicContentBlockVariant3? compaction,
            global::OpenRouter.ORAnthropicContentBlockVariant4? containerUpload,
            global::OpenRouter.ORAnthropicContentBlockVariant5? redactedThinking,
            global::OpenRouter.ORAnthropicContentBlockVariant6? serverToolUse,
            global::OpenRouter.ORAnthropicContentBlockVariant7? text,
            global::OpenRouter.ORAnthropicContentBlockVariant8? textEditorCodeExecutionToolResult,
            global::OpenRouter.ORAnthropicContentBlockVariant9? thinking,
            global::OpenRouter.ORAnthropicContentBlockVariant10? toolSearchToolResult,
            global::OpenRouter.ORAnthropicContentBlockVariant11? toolUse,
            global::OpenRouter.ORAnthropicContentBlockVariant12? webFetchToolResult,
            global::OpenRouter.ORAnthropicContentBlockVariant13? webSearchToolResult
            )
        {
            Type = type;

            BashCodeExecutionToolResult = bashCodeExecutionToolResult;
            CodeExecutionToolResult = codeExecutionToolResult;
            Compaction = compaction;
            ContainerUpload = containerUpload;
            RedactedThinking = redactedThinking;
            ServerToolUse = serverToolUse;
            Text = text;
            TextEditorCodeExecutionToolResult = textEditorCodeExecutionToolResult;
            Thinking = thinking;
            ToolSearchToolResult = toolSearchToolResult;
            ToolUse = toolUse;
            WebFetchToolResult = webFetchToolResult;
            WebSearchToolResult = webSearchToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WebSearchToolResult as object ??
            WebFetchToolResult as object ??
            ToolUse as object ??
            ToolSearchToolResult as object ??
            Thinking as object ??
            TextEditorCodeExecutionToolResult as object ??
            Text as object ??
            ServerToolUse as object ??
            RedactedThinking as object ??
            ContainerUpload as object ??
            Compaction as object ??
            CodeExecutionToolResult as object ??
            BashCodeExecutionToolResult as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BashCodeExecutionToolResult?.ToString() ??
            CodeExecutionToolResult?.ToString() ??
            Compaction?.ToString() ??
            ContainerUpload?.ToString() ??
            RedactedThinking?.ToString() ??
            ServerToolUse?.ToString() ??
            Text?.ToString() ??
            TextEditorCodeExecutionToolResult?.ToString() ??
            Thinking?.ToString() ??
            ToolSearchToolResult?.ToString() ??
            ToolUse?.ToString() ??
            WebFetchToolResult?.ToString() ??
            WebSearchToolResult?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBashCodeExecutionToolResult && !IsCodeExecutionToolResult && !IsCompaction && !IsContainerUpload && !IsRedactedThinking && !IsServerToolUse && !IsText && !IsTextEditorCodeExecutionToolResult && !IsThinking && !IsToolSearchToolResult && !IsToolUse && !IsWebFetchToolResult && !IsWebSearchToolResult || !IsBashCodeExecutionToolResult && IsCodeExecutionToolResult && !IsCompaction && !IsContainerUpload && !IsRedactedThinking && !IsServerToolUse && !IsText && !IsTextEditorCodeExecutionToolResult && !IsThinking && !IsToolSearchToolResult && !IsToolUse && !IsWebFetchToolResult && !IsWebSearchToolResult || !IsBashCodeExecutionToolResult && !IsCodeExecutionToolResult && IsCompaction && !IsContainerUpload && !IsRedactedThinking && !IsServerToolUse && !IsText && !IsTextEditorCodeExecutionToolResult && !IsThinking && !IsToolSearchToolResult && !IsToolUse && !IsWebFetchToolResult && !IsWebSearchToolResult || !IsBashCodeExecutionToolResult && !IsCodeExecutionToolResult && !IsCompaction && IsContainerUpload && !IsRedactedThinking && !IsServerToolUse && !IsText && !IsTextEditorCodeExecutionToolResult && !IsThinking && !IsToolSearchToolResult && !IsToolUse && !IsWebFetchToolResult && !IsWebSearchToolResult || !IsBashCodeExecutionToolResult && !IsCodeExecutionToolResult && !IsCompaction && !IsContainerUpload && IsRedactedThinking && !IsServerToolUse && !IsText && !IsTextEditorCodeExecutionToolResult && !IsThinking && !IsToolSearchToolResult && !IsToolUse && !IsWebFetchToolResult && !IsWebSearchToolResult || !IsBashCodeExecutionToolResult && !IsCodeExecutionToolResult && !IsCompaction && !IsContainerUpload && !IsRedactedThinking && IsServerToolUse && !IsText && !IsTextEditorCodeExecutionToolResult && !IsThinking && !IsToolSearchToolResult && !IsToolUse && !IsWebFetchToolResult && !IsWebSearchToolResult || !IsBashCodeExecutionToolResult && !IsCodeExecutionToolResult && !IsCompaction && !IsContainerUpload && !IsRedactedThinking && !IsServerToolUse && IsText && !IsTextEditorCodeExecutionToolResult && !IsThinking && !IsToolSearchToolResult && !IsToolUse && !IsWebFetchToolResult && !IsWebSearchToolResult || !IsBashCodeExecutionToolResult && !IsCodeExecutionToolResult && !IsCompaction && !IsContainerUpload && !IsRedactedThinking && !IsServerToolUse && !IsText && IsTextEditorCodeExecutionToolResult && !IsThinking && !IsToolSearchToolResult && !IsToolUse && !IsWebFetchToolResult && !IsWebSearchToolResult || !IsBashCodeExecutionToolResult && !IsCodeExecutionToolResult && !IsCompaction && !IsContainerUpload && !IsRedactedThinking && !IsServerToolUse && !IsText && !IsTextEditorCodeExecutionToolResult && IsThinking && !IsToolSearchToolResult && !IsToolUse && !IsWebFetchToolResult && !IsWebSearchToolResult || !IsBashCodeExecutionToolResult && !IsCodeExecutionToolResult && !IsCompaction && !IsContainerUpload && !IsRedactedThinking && !IsServerToolUse && !IsText && !IsTextEditorCodeExecutionToolResult && !IsThinking && IsToolSearchToolResult && !IsToolUse && !IsWebFetchToolResult && !IsWebSearchToolResult || !IsBashCodeExecutionToolResult && !IsCodeExecutionToolResult && !IsCompaction && !IsContainerUpload && !IsRedactedThinking && !IsServerToolUse && !IsText && !IsTextEditorCodeExecutionToolResult && !IsThinking && !IsToolSearchToolResult && IsToolUse && !IsWebFetchToolResult && !IsWebSearchToolResult || !IsBashCodeExecutionToolResult && !IsCodeExecutionToolResult && !IsCompaction && !IsContainerUpload && !IsRedactedThinking && !IsServerToolUse && !IsText && !IsTextEditorCodeExecutionToolResult && !IsThinking && !IsToolSearchToolResult && !IsToolUse && IsWebFetchToolResult && !IsWebSearchToolResult || !IsBashCodeExecutionToolResult && !IsCodeExecutionToolResult && !IsCompaction && !IsContainerUpload && !IsRedactedThinking && !IsServerToolUse && !IsText && !IsTextEditorCodeExecutionToolResult && !IsThinking && !IsToolSearchToolResult && !IsToolUse && !IsWebFetchToolResult && IsWebSearchToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ORAnthropicContentBlockVariant1, TResult>? bashCodeExecutionToolResult = null,
            global::System.Func<global::OpenRouter.ORAnthropicContentBlockVariant2, TResult>? codeExecutionToolResult = null,
            global::System.Func<global::OpenRouter.ORAnthropicContentBlockVariant3, TResult>? compaction = null,
            global::System.Func<global::OpenRouter.ORAnthropicContentBlockVariant4, TResult>? containerUpload = null,
            global::System.Func<global::OpenRouter.ORAnthropicContentBlockVariant5, TResult>? redactedThinking = null,
            global::System.Func<global::OpenRouter.ORAnthropicContentBlockVariant6, TResult>? serverToolUse = null,
            global::System.Func<global::OpenRouter.ORAnthropicContentBlockVariant7, TResult>? text = null,
            global::System.Func<global::OpenRouter.ORAnthropicContentBlockVariant8, TResult>? textEditorCodeExecutionToolResult = null,
            global::System.Func<global::OpenRouter.ORAnthropicContentBlockVariant9, TResult>? thinking = null,
            global::System.Func<global::OpenRouter.ORAnthropicContentBlockVariant10, TResult>? toolSearchToolResult = null,
            global::System.Func<global::OpenRouter.ORAnthropicContentBlockVariant11, TResult>? toolUse = null,
            global::System.Func<global::OpenRouter.ORAnthropicContentBlockVariant12, TResult>? webFetchToolResult = null,
            global::System.Func<global::OpenRouter.ORAnthropicContentBlockVariant13, TResult>? webSearchToolResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBashCodeExecutionToolResult && bashCodeExecutionToolResult != null)
            {
                return bashCodeExecutionToolResult(BashCodeExecutionToolResult!);
            }
            else if (IsCodeExecutionToolResult && codeExecutionToolResult != null)
            {
                return codeExecutionToolResult(CodeExecutionToolResult!);
            }
            else if (IsCompaction && compaction != null)
            {
                return compaction(Compaction!);
            }
            else if (IsContainerUpload && containerUpload != null)
            {
                return containerUpload(ContainerUpload!);
            }
            else if (IsRedactedThinking && redactedThinking != null)
            {
                return redactedThinking(RedactedThinking!);
            }
            else if (IsServerToolUse && serverToolUse != null)
            {
                return serverToolUse(ServerToolUse!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsTextEditorCodeExecutionToolResult && textEditorCodeExecutionToolResult != null)
            {
                return textEditorCodeExecutionToolResult(TextEditorCodeExecutionToolResult!);
            }
            else if (IsThinking && thinking != null)
            {
                return thinking(Thinking!);
            }
            else if (IsToolSearchToolResult && toolSearchToolResult != null)
            {
                return toolSearchToolResult(ToolSearchToolResult!);
            }
            else if (IsToolUse && toolUse != null)
            {
                return toolUse(ToolUse!);
            }
            else if (IsWebFetchToolResult && webFetchToolResult != null)
            {
                return webFetchToolResult(WebFetchToolResult!);
            }
            else if (IsWebSearchToolResult && webSearchToolResult != null)
            {
                return webSearchToolResult(WebSearchToolResult!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant1>? bashCodeExecutionToolResult = null,

            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant2>? codeExecutionToolResult = null,

            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant3>? compaction = null,

            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant4>? containerUpload = null,

            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant5>? redactedThinking = null,

            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant6>? serverToolUse = null,

            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant7>? text = null,

            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant8>? textEditorCodeExecutionToolResult = null,

            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant9>? thinking = null,

            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant10>? toolSearchToolResult = null,

            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant11>? toolUse = null,

            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant12>? webFetchToolResult = null,

            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant13>? webSearchToolResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBashCodeExecutionToolResult)
            {
                bashCodeExecutionToolResult?.Invoke(BashCodeExecutionToolResult!);
            }
            else if (IsCodeExecutionToolResult)
            {
                codeExecutionToolResult?.Invoke(CodeExecutionToolResult!);
            }
            else if (IsCompaction)
            {
                compaction?.Invoke(Compaction!);
            }
            else if (IsContainerUpload)
            {
                containerUpload?.Invoke(ContainerUpload!);
            }
            else if (IsRedactedThinking)
            {
                redactedThinking?.Invoke(RedactedThinking!);
            }
            else if (IsServerToolUse)
            {
                serverToolUse?.Invoke(ServerToolUse!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsTextEditorCodeExecutionToolResult)
            {
                textEditorCodeExecutionToolResult?.Invoke(TextEditorCodeExecutionToolResult!);
            }
            else if (IsThinking)
            {
                thinking?.Invoke(Thinking!);
            }
            else if (IsToolSearchToolResult)
            {
                toolSearchToolResult?.Invoke(ToolSearchToolResult!);
            }
            else if (IsToolUse)
            {
                toolUse?.Invoke(ToolUse!);
            }
            else if (IsWebFetchToolResult)
            {
                webFetchToolResult?.Invoke(WebFetchToolResult!);
            }
            else if (IsWebSearchToolResult)
            {
                webSearchToolResult?.Invoke(WebSearchToolResult!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant1>? bashCodeExecutionToolResult = null,
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant2>? codeExecutionToolResult = null,
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant3>? compaction = null,
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant4>? containerUpload = null,
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant5>? redactedThinking = null,
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant6>? serverToolUse = null,
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant7>? text = null,
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant8>? textEditorCodeExecutionToolResult = null,
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant9>? thinking = null,
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant10>? toolSearchToolResult = null,
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant11>? toolUse = null,
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant12>? webFetchToolResult = null,
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant13>? webSearchToolResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBashCodeExecutionToolResult)
            {
                bashCodeExecutionToolResult?.Invoke(BashCodeExecutionToolResult!);
            }
            else if (IsCodeExecutionToolResult)
            {
                codeExecutionToolResult?.Invoke(CodeExecutionToolResult!);
            }
            else if (IsCompaction)
            {
                compaction?.Invoke(Compaction!);
            }
            else if (IsContainerUpload)
            {
                containerUpload?.Invoke(ContainerUpload!);
            }
            else if (IsRedactedThinking)
            {
                redactedThinking?.Invoke(RedactedThinking!);
            }
            else if (IsServerToolUse)
            {
                serverToolUse?.Invoke(ServerToolUse!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsTextEditorCodeExecutionToolResult)
            {
                textEditorCodeExecutionToolResult?.Invoke(TextEditorCodeExecutionToolResult!);
            }
            else if (IsThinking)
            {
                thinking?.Invoke(Thinking!);
            }
            else if (IsToolSearchToolResult)
            {
                toolSearchToolResult?.Invoke(ToolSearchToolResult!);
            }
            else if (IsToolUse)
            {
                toolUse?.Invoke(ToolUse!);
            }
            else if (IsWebFetchToolResult)
            {
                webFetchToolResult?.Invoke(WebFetchToolResult!);
            }
            else if (IsWebSearchToolResult)
            {
                webSearchToolResult?.Invoke(WebSearchToolResult!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BashCodeExecutionToolResult,
                typeof(global::OpenRouter.ORAnthropicContentBlockVariant1),
                CodeExecutionToolResult,
                typeof(global::OpenRouter.ORAnthropicContentBlockVariant2),
                Compaction,
                typeof(global::OpenRouter.ORAnthropicContentBlockVariant3),
                ContainerUpload,
                typeof(global::OpenRouter.ORAnthropicContentBlockVariant4),
                RedactedThinking,
                typeof(global::OpenRouter.ORAnthropicContentBlockVariant5),
                ServerToolUse,
                typeof(global::OpenRouter.ORAnthropicContentBlockVariant6),
                Text,
                typeof(global::OpenRouter.ORAnthropicContentBlockVariant7),
                TextEditorCodeExecutionToolResult,
                typeof(global::OpenRouter.ORAnthropicContentBlockVariant8),
                Thinking,
                typeof(global::OpenRouter.ORAnthropicContentBlockVariant9),
                ToolSearchToolResult,
                typeof(global::OpenRouter.ORAnthropicContentBlockVariant10),
                ToolUse,
                typeof(global::OpenRouter.ORAnthropicContentBlockVariant11),
                WebFetchToolResult,
                typeof(global::OpenRouter.ORAnthropicContentBlockVariant12),
                WebSearchToolResult,
                typeof(global::OpenRouter.ORAnthropicContentBlockVariant13),
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
        public bool Equals(ORAnthropicContentBlock other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicContentBlockVariant1?>.Default.Equals(BashCodeExecutionToolResult, other.BashCodeExecutionToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicContentBlockVariant2?>.Default.Equals(CodeExecutionToolResult, other.CodeExecutionToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicContentBlockVariant3?>.Default.Equals(Compaction, other.Compaction) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicContentBlockVariant4?>.Default.Equals(ContainerUpload, other.ContainerUpload) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicContentBlockVariant5?>.Default.Equals(RedactedThinking, other.RedactedThinking) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicContentBlockVariant6?>.Default.Equals(ServerToolUse, other.ServerToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicContentBlockVariant7?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicContentBlockVariant8?>.Default.Equals(TextEditorCodeExecutionToolResult, other.TextEditorCodeExecutionToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicContentBlockVariant9?>.Default.Equals(Thinking, other.Thinking) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicContentBlockVariant10?>.Default.Equals(ToolSearchToolResult, other.ToolSearchToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicContentBlockVariant11?>.Default.Equals(ToolUse, other.ToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicContentBlockVariant12?>.Default.Equals(WebFetchToolResult, other.WebFetchToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicContentBlockVariant13?>.Default.Equals(WebSearchToolResult, other.WebSearchToolResult) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ORAnthropicContentBlock obj1, ORAnthropicContentBlock obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ORAnthropicContentBlock>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ORAnthropicContentBlock obj1, ORAnthropicContentBlock obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ORAnthropicContentBlock o && Equals(o);
        }
    }
}
