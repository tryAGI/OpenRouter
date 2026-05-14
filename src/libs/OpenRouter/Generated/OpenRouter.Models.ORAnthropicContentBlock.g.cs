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
        /// advisor_tool_result variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicContentBlockVariant1? AdvisorToolResult { get; init; }
#else
        public global::OpenRouter.ORAnthropicContentBlockVariant1? AdvisorToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AdvisorToolResult))]
#endif
        public bool IsAdvisorToolResult => AdvisorToolResult != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAdvisorToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ORAnthropicContentBlockVariant1? value)
        {
            value = AdvisorToolResult;
            return IsAdvisorToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant1 PickAdvisorToolResult() => IsAdvisorToolResult
            ? AdvisorToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AdvisorToolResult' but the value was {ToString()}.");

        /// <summary>
        /// bash_code_execution_tool_result variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicContentBlockVariant2? BashCodeExecutionToolResult { get; init; }
#else
        public global::OpenRouter.ORAnthropicContentBlockVariant2? BashCodeExecutionToolResult { get; }
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
            out global::OpenRouter.ORAnthropicContentBlockVariant2? value)
        {
            value = BashCodeExecutionToolResult;
            return IsBashCodeExecutionToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant2 PickBashCodeExecutionToolResult() => IsBashCodeExecutionToolResult
            ? BashCodeExecutionToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BashCodeExecutionToolResult' but the value was {ToString()}.");

        /// <summary>
        /// code_execution_tool_result variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicContentBlockVariant3? CodeExecutionToolResult { get; init; }
#else
        public global::OpenRouter.ORAnthropicContentBlockVariant3? CodeExecutionToolResult { get; }
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
            out global::OpenRouter.ORAnthropicContentBlockVariant3? value)
        {
            value = CodeExecutionToolResult;
            return IsCodeExecutionToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant3 PickCodeExecutionToolResult() => IsCodeExecutionToolResult
            ? CodeExecutionToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeExecutionToolResult' but the value was {ToString()}.");

        /// <summary>
        /// compaction variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicContentBlockVariant4? Compaction { get; init; }
#else
        public global::OpenRouter.ORAnthropicContentBlockVariant4? Compaction { get; }
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
            out global::OpenRouter.ORAnthropicContentBlockVariant4? value)
        {
            value = Compaction;
            return IsCompaction;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant4 PickCompaction() => IsCompaction
            ? Compaction!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Compaction' but the value was {ToString()}.");

        /// <summary>
        /// container_upload variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicContentBlockVariant5? ContainerUpload { get; init; }
#else
        public global::OpenRouter.ORAnthropicContentBlockVariant5? ContainerUpload { get; }
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
            out global::OpenRouter.ORAnthropicContentBlockVariant5? value)
        {
            value = ContainerUpload;
            return IsContainerUpload;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant5 PickContainerUpload() => IsContainerUpload
            ? ContainerUpload!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContainerUpload' but the value was {ToString()}.");

        /// <summary>
        /// redacted_thinking variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicContentBlockVariant6? RedactedThinking { get; init; }
#else
        public global::OpenRouter.ORAnthropicContentBlockVariant6? RedactedThinking { get; }
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
            out global::OpenRouter.ORAnthropicContentBlockVariant6? value)
        {
            value = RedactedThinking;
            return IsRedactedThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant6 PickRedactedThinking() => IsRedactedThinking
            ? RedactedThinking!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RedactedThinking' but the value was {ToString()}.");

        /// <summary>
        /// server_tool_use variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicContentBlockVariant7? ServerToolUse { get; init; }
#else
        public global::OpenRouter.ORAnthropicContentBlockVariant7? ServerToolUse { get; }
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
            out global::OpenRouter.ORAnthropicContentBlockVariant7? value)
        {
            value = ServerToolUse;
            return IsServerToolUse;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant7 PickServerToolUse() => IsServerToolUse
            ? ServerToolUse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ServerToolUse' but the value was {ToString()}.");

        /// <summary>
        /// text variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicContentBlockVariant8? Text { get; init; }
#else
        public global::OpenRouter.ORAnthropicContentBlockVariant8? Text { get; }
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
            out global::OpenRouter.ORAnthropicContentBlockVariant8? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant8 PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// text_editor_code_execution_tool_result variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicContentBlockVariant9? TextEditorCodeExecutionToolResult { get; init; }
#else
        public global::OpenRouter.ORAnthropicContentBlockVariant9? TextEditorCodeExecutionToolResult { get; }
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
            out global::OpenRouter.ORAnthropicContentBlockVariant9? value)
        {
            value = TextEditorCodeExecutionToolResult;
            return IsTextEditorCodeExecutionToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant9 PickTextEditorCodeExecutionToolResult() => IsTextEditorCodeExecutionToolResult
            ? TextEditorCodeExecutionToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextEditorCodeExecutionToolResult' but the value was {ToString()}.");

        /// <summary>
        /// thinking variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicContentBlockVariant10? Thinking { get; init; }
#else
        public global::OpenRouter.ORAnthropicContentBlockVariant10? Thinking { get; }
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
            out global::OpenRouter.ORAnthropicContentBlockVariant10? value)
        {
            value = Thinking;
            return IsThinking;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant10 PickThinking() => IsThinking
            ? Thinking!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Thinking' but the value was {ToString()}.");

        /// <summary>
        /// tool_search_tool_result variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicContentBlockVariant11? ToolSearchToolResult { get; init; }
#else
        public global::OpenRouter.ORAnthropicContentBlockVariant11? ToolSearchToolResult { get; }
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
            out global::OpenRouter.ORAnthropicContentBlockVariant11? value)
        {
            value = ToolSearchToolResult;
            return IsToolSearchToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant11 PickToolSearchToolResult() => IsToolSearchToolResult
            ? ToolSearchToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolSearchToolResult' but the value was {ToString()}.");

        /// <summary>
        /// tool_use variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicContentBlockVariant12? ToolUse { get; init; }
#else
        public global::OpenRouter.ORAnthropicContentBlockVariant12? ToolUse { get; }
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
            out global::OpenRouter.ORAnthropicContentBlockVariant12? value)
        {
            value = ToolUse;
            return IsToolUse;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant12 PickToolUse() => IsToolUse
            ? ToolUse!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolUse' but the value was {ToString()}.");

        /// <summary>
        /// web_fetch_tool_result variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicContentBlockVariant13? WebFetchToolResult { get; init; }
#else
        public global::OpenRouter.ORAnthropicContentBlockVariant13? WebFetchToolResult { get; }
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
            out global::OpenRouter.ORAnthropicContentBlockVariant13? value)
        {
            value = WebFetchToolResult;
            return IsWebFetchToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant13 PickWebFetchToolResult() => IsWebFetchToolResult
            ? WebFetchToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebFetchToolResult' but the value was {ToString()}.");

        /// <summary>
        /// web_search_tool_result variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicContentBlockVariant14? WebSearchToolResult { get; init; }
#else
        public global::OpenRouter.ORAnthropicContentBlockVariant14? WebSearchToolResult { get; }
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
            out global::OpenRouter.ORAnthropicContentBlockVariant14? value)
        {
            value = WebSearchToolResult;
            return IsWebSearchToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockVariant14 PickWebSearchToolResult() => IsWebSearchToolResult
            ? WebSearchToolResult!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearchToolResult' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant1 value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicContentBlockVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicContentBlockVariant1?(ORAnthropicContentBlock @this) => @this.AdvisorToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant1? value)
        {
            AdvisorToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ORAnthropicContentBlock FromAdvisorToolResult(global::OpenRouter.ORAnthropicContentBlockVariant1? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant2 value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicContentBlockVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicContentBlockVariant2?(ORAnthropicContentBlock @this) => @this.BashCodeExecutionToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant2? value)
        {
            BashCodeExecutionToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ORAnthropicContentBlock FromBashCodeExecutionToolResult(global::OpenRouter.ORAnthropicContentBlockVariant2? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant3 value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicContentBlockVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicContentBlockVariant3?(ORAnthropicContentBlock @this) => @this.CodeExecutionToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant3? value)
        {
            CodeExecutionToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ORAnthropicContentBlock FromCodeExecutionToolResult(global::OpenRouter.ORAnthropicContentBlockVariant3? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant4 value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicContentBlockVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicContentBlockVariant4?(ORAnthropicContentBlock @this) => @this.Compaction;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant4? value)
        {
            Compaction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ORAnthropicContentBlock FromCompaction(global::OpenRouter.ORAnthropicContentBlockVariant4? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant5 value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicContentBlockVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicContentBlockVariant5?(ORAnthropicContentBlock @this) => @this.ContainerUpload;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant5? value)
        {
            ContainerUpload = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ORAnthropicContentBlock FromContainerUpload(global::OpenRouter.ORAnthropicContentBlockVariant5? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant6 value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicContentBlockVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicContentBlockVariant6?(ORAnthropicContentBlock @this) => @this.RedactedThinking;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant6? value)
        {
            RedactedThinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ORAnthropicContentBlock FromRedactedThinking(global::OpenRouter.ORAnthropicContentBlockVariant6? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant7 value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicContentBlockVariant7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicContentBlockVariant7?(ORAnthropicContentBlock @this) => @this.ServerToolUse;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant7? value)
        {
            ServerToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ORAnthropicContentBlock FromServerToolUse(global::OpenRouter.ORAnthropicContentBlockVariant7? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant8 value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicContentBlockVariant8?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicContentBlockVariant8?(ORAnthropicContentBlock @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant8? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ORAnthropicContentBlock FromText(global::OpenRouter.ORAnthropicContentBlockVariant8? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant9 value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicContentBlockVariant9?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicContentBlockVariant9?(ORAnthropicContentBlock @this) => @this.TextEditorCodeExecutionToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant9? value)
        {
            TextEditorCodeExecutionToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ORAnthropicContentBlock FromTextEditorCodeExecutionToolResult(global::OpenRouter.ORAnthropicContentBlockVariant9? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant10 value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicContentBlockVariant10?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicContentBlockVariant10?(ORAnthropicContentBlock @this) => @this.Thinking;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant10? value)
        {
            Thinking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ORAnthropicContentBlock FromThinking(global::OpenRouter.ORAnthropicContentBlockVariant10? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant11 value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicContentBlockVariant11?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicContentBlockVariant11?(ORAnthropicContentBlock @this) => @this.ToolSearchToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant11? value)
        {
            ToolSearchToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ORAnthropicContentBlock FromToolSearchToolResult(global::OpenRouter.ORAnthropicContentBlockVariant11? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant12 value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicContentBlockVariant12?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicContentBlockVariant12?(ORAnthropicContentBlock @this) => @this.ToolUse;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant12? value)
        {
            ToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ORAnthropicContentBlock FromToolUse(global::OpenRouter.ORAnthropicContentBlockVariant12? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant13 value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicContentBlockVariant13?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicContentBlockVariant13?(ORAnthropicContentBlock @this) => @this.WebFetchToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant13? value)
        {
            WebFetchToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ORAnthropicContentBlock FromWebFetchToolResult(global::OpenRouter.ORAnthropicContentBlockVariant13? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant14 value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicContentBlockVariant14?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicContentBlockVariant14?(ORAnthropicContentBlock @this) => @this.WebSearchToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicContentBlockVariant14? value)
        {
            WebSearchToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ORAnthropicContentBlock FromWebSearchToolResult(global::OpenRouter.ORAnthropicContentBlockVariant14? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(
            global::OpenRouter.ORAnthropicContentBlockDiscriminatorType? type,
            global::OpenRouter.ORAnthropicContentBlockVariant1? advisorToolResult,
            global::OpenRouter.ORAnthropicContentBlockVariant2? bashCodeExecutionToolResult,
            global::OpenRouter.ORAnthropicContentBlockVariant3? codeExecutionToolResult,
            global::OpenRouter.ORAnthropicContentBlockVariant4? compaction,
            global::OpenRouter.ORAnthropicContentBlockVariant5? containerUpload,
            global::OpenRouter.ORAnthropicContentBlockVariant6? redactedThinking,
            global::OpenRouter.ORAnthropicContentBlockVariant7? serverToolUse,
            global::OpenRouter.ORAnthropicContentBlockVariant8? text,
            global::OpenRouter.ORAnthropicContentBlockVariant9? textEditorCodeExecutionToolResult,
            global::OpenRouter.ORAnthropicContentBlockVariant10? thinking,
            global::OpenRouter.ORAnthropicContentBlockVariant11? toolSearchToolResult,
            global::OpenRouter.ORAnthropicContentBlockVariant12? toolUse,
            global::OpenRouter.ORAnthropicContentBlockVariant13? webFetchToolResult,
            global::OpenRouter.ORAnthropicContentBlockVariant14? webSearchToolResult
            )
        {
            Type = type;

            AdvisorToolResult = advisorToolResult;
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
            BashCodeExecutionToolResult as object ??
            AdvisorToolResult as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AdvisorToolResult?.ToString() ??
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
            return IsAdvisorToolResult && !IsBashCodeExecutionToolResult && !IsCodeExecutionToolResult && !IsCompaction && !IsContainerUpload && !IsRedactedThinking && !IsServerToolUse && !IsText && !IsTextEditorCodeExecutionToolResult && !IsThinking && !IsToolSearchToolResult && !IsToolUse && !IsWebFetchToolResult && !IsWebSearchToolResult || !IsAdvisorToolResult && IsBashCodeExecutionToolResult && !IsCodeExecutionToolResult && !IsCompaction && !IsContainerUpload && !IsRedactedThinking && !IsServerToolUse && !IsText && !IsTextEditorCodeExecutionToolResult && !IsThinking && !IsToolSearchToolResult && !IsToolUse && !IsWebFetchToolResult && !IsWebSearchToolResult || !IsAdvisorToolResult && !IsBashCodeExecutionToolResult && IsCodeExecutionToolResult && !IsCompaction && !IsContainerUpload && !IsRedactedThinking && !IsServerToolUse && !IsText && !IsTextEditorCodeExecutionToolResult && !IsThinking && !IsToolSearchToolResult && !IsToolUse && !IsWebFetchToolResult && !IsWebSearchToolResult || !IsAdvisorToolResult && !IsBashCodeExecutionToolResult && !IsCodeExecutionToolResult && IsCompaction && !IsContainerUpload && !IsRedactedThinking && !IsServerToolUse && !IsText && !IsTextEditorCodeExecutionToolResult && !IsThinking && !IsToolSearchToolResult && !IsToolUse && !IsWebFetchToolResult && !IsWebSearchToolResult || !IsAdvisorToolResult && !IsBashCodeExecutionToolResult && !IsCodeExecutionToolResult && !IsCompaction && IsContainerUpload && !IsRedactedThinking && !IsServerToolUse && !IsText && !IsTextEditorCodeExecutionToolResult && !IsThinking && !IsToolSearchToolResult && !IsToolUse && !IsWebFetchToolResult && !IsWebSearchToolResult || !IsAdvisorToolResult && !IsBashCodeExecutionToolResult && !IsCodeExecutionToolResult && !IsCompaction && !IsContainerUpload && IsRedactedThinking && !IsServerToolUse && !IsText && !IsTextEditorCodeExecutionToolResult && !IsThinking && !IsToolSearchToolResult && !IsToolUse && !IsWebFetchToolResult && !IsWebSearchToolResult || !IsAdvisorToolResult && !IsBashCodeExecutionToolResult && !IsCodeExecutionToolResult && !IsCompaction && !IsContainerUpload && !IsRedactedThinking && IsServerToolUse && !IsText && !IsTextEditorCodeExecutionToolResult && !IsThinking && !IsToolSearchToolResult && !IsToolUse && !IsWebFetchToolResult && !IsWebSearchToolResult || !IsAdvisorToolResult && !IsBashCodeExecutionToolResult && !IsCodeExecutionToolResult && !IsCompaction && !IsContainerUpload && !IsRedactedThinking && !IsServerToolUse && IsText && !IsTextEditorCodeExecutionToolResult && !IsThinking && !IsToolSearchToolResult && !IsToolUse && !IsWebFetchToolResult && !IsWebSearchToolResult || !IsAdvisorToolResult && !IsBashCodeExecutionToolResult && !IsCodeExecutionToolResult && !IsCompaction && !IsContainerUpload && !IsRedactedThinking && !IsServerToolUse && !IsText && IsTextEditorCodeExecutionToolResult && !IsThinking && !IsToolSearchToolResult && !IsToolUse && !IsWebFetchToolResult && !IsWebSearchToolResult || !IsAdvisorToolResult && !IsBashCodeExecutionToolResult && !IsCodeExecutionToolResult && !IsCompaction && !IsContainerUpload && !IsRedactedThinking && !IsServerToolUse && !IsText && !IsTextEditorCodeExecutionToolResult && IsThinking && !IsToolSearchToolResult && !IsToolUse && !IsWebFetchToolResult && !IsWebSearchToolResult || !IsAdvisorToolResult && !IsBashCodeExecutionToolResult && !IsCodeExecutionToolResult && !IsCompaction && !IsContainerUpload && !IsRedactedThinking && !IsServerToolUse && !IsText && !IsTextEditorCodeExecutionToolResult && !IsThinking && IsToolSearchToolResult && !IsToolUse && !IsWebFetchToolResult && !IsWebSearchToolResult || !IsAdvisorToolResult && !IsBashCodeExecutionToolResult && !IsCodeExecutionToolResult && !IsCompaction && !IsContainerUpload && !IsRedactedThinking && !IsServerToolUse && !IsText && !IsTextEditorCodeExecutionToolResult && !IsThinking && !IsToolSearchToolResult && IsToolUse && !IsWebFetchToolResult && !IsWebSearchToolResult || !IsAdvisorToolResult && !IsBashCodeExecutionToolResult && !IsCodeExecutionToolResult && !IsCompaction && !IsContainerUpload && !IsRedactedThinking && !IsServerToolUse && !IsText && !IsTextEditorCodeExecutionToolResult && !IsThinking && !IsToolSearchToolResult && !IsToolUse && IsWebFetchToolResult && !IsWebSearchToolResult || !IsAdvisorToolResult && !IsBashCodeExecutionToolResult && !IsCodeExecutionToolResult && !IsCompaction && !IsContainerUpload && !IsRedactedThinking && !IsServerToolUse && !IsText && !IsTextEditorCodeExecutionToolResult && !IsThinking && !IsToolSearchToolResult && !IsToolUse && !IsWebFetchToolResult && IsWebSearchToolResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ORAnthropicContentBlockVariant1, TResult>? advisorToolResult = null,
            global::System.Func<global::OpenRouter.ORAnthropicContentBlockVariant2, TResult>? bashCodeExecutionToolResult = null,
            global::System.Func<global::OpenRouter.ORAnthropicContentBlockVariant3, TResult>? codeExecutionToolResult = null,
            global::System.Func<global::OpenRouter.ORAnthropicContentBlockVariant4, TResult>? compaction = null,
            global::System.Func<global::OpenRouter.ORAnthropicContentBlockVariant5, TResult>? containerUpload = null,
            global::System.Func<global::OpenRouter.ORAnthropicContentBlockVariant6, TResult>? redactedThinking = null,
            global::System.Func<global::OpenRouter.ORAnthropicContentBlockVariant7, TResult>? serverToolUse = null,
            global::System.Func<global::OpenRouter.ORAnthropicContentBlockVariant8, TResult>? text = null,
            global::System.Func<global::OpenRouter.ORAnthropicContentBlockVariant9, TResult>? textEditorCodeExecutionToolResult = null,
            global::System.Func<global::OpenRouter.ORAnthropicContentBlockVariant10, TResult>? thinking = null,
            global::System.Func<global::OpenRouter.ORAnthropicContentBlockVariant11, TResult>? toolSearchToolResult = null,
            global::System.Func<global::OpenRouter.ORAnthropicContentBlockVariant12, TResult>? toolUse = null,
            global::System.Func<global::OpenRouter.ORAnthropicContentBlockVariant13, TResult>? webFetchToolResult = null,
            global::System.Func<global::OpenRouter.ORAnthropicContentBlockVariant14, TResult>? webSearchToolResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAdvisorToolResult && advisorToolResult != null)
            {
                return advisorToolResult(AdvisorToolResult!);
            }
            else if (IsBashCodeExecutionToolResult && bashCodeExecutionToolResult != null)
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
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant1>? advisorToolResult = null,

            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant2>? bashCodeExecutionToolResult = null,

            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant3>? codeExecutionToolResult = null,

            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant4>? compaction = null,

            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant5>? containerUpload = null,

            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant6>? redactedThinking = null,

            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant7>? serverToolUse = null,

            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant8>? text = null,

            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant9>? textEditorCodeExecutionToolResult = null,

            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant10>? thinking = null,

            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant11>? toolSearchToolResult = null,

            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant12>? toolUse = null,

            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant13>? webFetchToolResult = null,

            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant14>? webSearchToolResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAdvisorToolResult)
            {
                advisorToolResult?.Invoke(AdvisorToolResult!);
            }
            else if (IsBashCodeExecutionToolResult)
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
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant1>? advisorToolResult = null,
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant2>? bashCodeExecutionToolResult = null,
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant3>? codeExecutionToolResult = null,
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant4>? compaction = null,
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant5>? containerUpload = null,
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant6>? redactedThinking = null,
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant7>? serverToolUse = null,
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant8>? text = null,
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant9>? textEditorCodeExecutionToolResult = null,
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant10>? thinking = null,
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant11>? toolSearchToolResult = null,
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant12>? toolUse = null,
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant13>? webFetchToolResult = null,
            global::System.Action<global::OpenRouter.ORAnthropicContentBlockVariant14>? webSearchToolResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAdvisorToolResult)
            {
                advisorToolResult?.Invoke(AdvisorToolResult!);
            }
            else if (IsBashCodeExecutionToolResult)
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
                AdvisorToolResult,
                typeof(global::OpenRouter.ORAnthropicContentBlockVariant1),
                BashCodeExecutionToolResult,
                typeof(global::OpenRouter.ORAnthropicContentBlockVariant2),
                CodeExecutionToolResult,
                typeof(global::OpenRouter.ORAnthropicContentBlockVariant3),
                Compaction,
                typeof(global::OpenRouter.ORAnthropicContentBlockVariant4),
                ContainerUpload,
                typeof(global::OpenRouter.ORAnthropicContentBlockVariant5),
                RedactedThinking,
                typeof(global::OpenRouter.ORAnthropicContentBlockVariant6),
                ServerToolUse,
                typeof(global::OpenRouter.ORAnthropicContentBlockVariant7),
                Text,
                typeof(global::OpenRouter.ORAnthropicContentBlockVariant8),
                TextEditorCodeExecutionToolResult,
                typeof(global::OpenRouter.ORAnthropicContentBlockVariant9),
                Thinking,
                typeof(global::OpenRouter.ORAnthropicContentBlockVariant10),
                ToolSearchToolResult,
                typeof(global::OpenRouter.ORAnthropicContentBlockVariant11),
                ToolUse,
                typeof(global::OpenRouter.ORAnthropicContentBlockVariant12),
                WebFetchToolResult,
                typeof(global::OpenRouter.ORAnthropicContentBlockVariant13),
                WebSearchToolResult,
                typeof(global::OpenRouter.ORAnthropicContentBlockVariant14),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicContentBlockVariant1?>.Default.Equals(AdvisorToolResult, other.AdvisorToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicContentBlockVariant2?>.Default.Equals(BashCodeExecutionToolResult, other.BashCodeExecutionToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicContentBlockVariant3?>.Default.Equals(CodeExecutionToolResult, other.CodeExecutionToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicContentBlockVariant4?>.Default.Equals(Compaction, other.Compaction) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicContentBlockVariant5?>.Default.Equals(ContainerUpload, other.ContainerUpload) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicContentBlockVariant6?>.Default.Equals(RedactedThinking, other.RedactedThinking) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicContentBlockVariant7?>.Default.Equals(ServerToolUse, other.ServerToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicContentBlockVariant8?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicContentBlockVariant9?>.Default.Equals(TextEditorCodeExecutionToolResult, other.TextEditorCodeExecutionToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicContentBlockVariant10?>.Default.Equals(Thinking, other.Thinking) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicContentBlockVariant11?>.Default.Equals(ToolSearchToolResult, other.ToolSearchToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicContentBlockVariant12?>.Default.Equals(ToolUse, other.ToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicContentBlockVariant13?>.Default.Equals(WebFetchToolResult, other.WebFetchToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicContentBlockVariant14?>.Default.Equals(WebSearchToolResult, other.WebSearchToolResult) 
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
