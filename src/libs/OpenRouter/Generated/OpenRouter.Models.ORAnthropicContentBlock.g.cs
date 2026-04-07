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
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextBlock? AnthropicTextBlock { get; init; }
#else
        public global::OpenRouter.AnthropicTextBlock? AnthropicTextBlock { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicTextBlock))]
#endif
        public bool IsAnthropicTextBlock => AnthropicTextBlock != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicToolUseBlock? AnthropicToolUseBlock { get; init; }
#else
        public global::OpenRouter.AnthropicToolUseBlock? AnthropicToolUseBlock { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicToolUseBlock))]
#endif
        public bool IsAnthropicToolUseBlock => AnthropicToolUseBlock != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicThinkingBlock? AnthropicThinkingBlock { get; init; }
#else
        public global::OpenRouter.AnthropicThinkingBlock? AnthropicThinkingBlock { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicThinkingBlock))]
#endif
        public bool IsAnthropicThinkingBlock => AnthropicThinkingBlock != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicRedactedThinkingBlock? AnthropicRedactedThinkingBlock { get; init; }
#else
        public global::OpenRouter.AnthropicRedactedThinkingBlock? AnthropicRedactedThinkingBlock { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicRedactedThinkingBlock))]
#endif
        public bool IsAnthropicRedactedThinkingBlock => AnthropicRedactedThinkingBlock != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicServerToolUseBlock? AnthropicServerToolUseBlock { get; init; }
#else
        public global::OpenRouter.AnthropicServerToolUseBlock? AnthropicServerToolUseBlock { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicServerToolUseBlock))]
#endif
        public bool IsAnthropicServerToolUseBlock => AnthropicServerToolUseBlock != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicWebSearchToolResult? AnthropicWebSearchToolResult { get; init; }
#else
        public global::OpenRouter.AnthropicWebSearchToolResult? AnthropicWebSearchToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicWebSearchToolResult))]
#endif
        public bool IsAnthropicWebSearchToolResult => AnthropicWebSearchToolResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicWebFetchToolResult? AnthropicWebFetchToolResult { get; init; }
#else
        public global::OpenRouter.AnthropicWebFetchToolResult? AnthropicWebFetchToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicWebFetchToolResult))]
#endif
        public bool IsAnthropicWebFetchToolResult => AnthropicWebFetchToolResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCodeExecutionToolResult? AnthropicCodeExecutionToolResult { get; init; }
#else
        public global::OpenRouter.AnthropicCodeExecutionToolResult? AnthropicCodeExecutionToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicCodeExecutionToolResult))]
#endif
        public bool IsAnthropicCodeExecutionToolResult => AnthropicCodeExecutionToolResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicBashCodeExecutionToolResult? AnthropicBashCodeExecutionToolResult { get; init; }
#else
        public global::OpenRouter.AnthropicBashCodeExecutionToolResult? AnthropicBashCodeExecutionToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicBashCodeExecutionToolResult))]
#endif
        public bool IsAnthropicBashCodeExecutionToolResult => AnthropicBashCodeExecutionToolResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult? AnthropicTextEditorCodeExecutionToolResult { get; init; }
#else
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult? AnthropicTextEditorCodeExecutionToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicTextEditorCodeExecutionToolResult))]
#endif
        public bool IsAnthropicTextEditorCodeExecutionToolResult => AnthropicTextEditorCodeExecutionToolResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicToolSearchToolResult? AnthropicToolSearchToolResult { get; init; }
#else
        public global::OpenRouter.AnthropicToolSearchToolResult? AnthropicToolSearchToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicToolSearchToolResult))]
#endif
        public bool IsAnthropicToolSearchToolResult => AnthropicToolSearchToolResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicContainerUpload? AnthropicContainerUpload { get; init; }
#else
        public global::OpenRouter.AnthropicContainerUpload? AnthropicContainerUpload { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicContainerUpload))]
#endif
        public bool IsAnthropicContainerUpload => AnthropicContainerUpload != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCompactionBlock? AnthropicCompactionBlock { get; init; }
#else
        public global::OpenRouter.AnthropicCompactionBlock? AnthropicCompactionBlock { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicCompactionBlock))]
#endif
        public bool IsAnthropicCompactionBlock => AnthropicCompactionBlock != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.AnthropicTextBlock value) => new ORAnthropicContentBlock((global::OpenRouter.AnthropicTextBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextBlock?(ORAnthropicContentBlock @this) => @this.AnthropicTextBlock;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.AnthropicTextBlock? value)
        {
            AnthropicTextBlock = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.AnthropicToolUseBlock value) => new ORAnthropicContentBlock((global::OpenRouter.AnthropicToolUseBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicToolUseBlock?(ORAnthropicContentBlock @this) => @this.AnthropicToolUseBlock;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.AnthropicToolUseBlock? value)
        {
            AnthropicToolUseBlock = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.AnthropicThinkingBlock value) => new ORAnthropicContentBlock((global::OpenRouter.AnthropicThinkingBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicThinkingBlock?(ORAnthropicContentBlock @this) => @this.AnthropicThinkingBlock;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.AnthropicThinkingBlock? value)
        {
            AnthropicThinkingBlock = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.AnthropicRedactedThinkingBlock value) => new ORAnthropicContentBlock((global::OpenRouter.AnthropicRedactedThinkingBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicRedactedThinkingBlock?(ORAnthropicContentBlock @this) => @this.AnthropicRedactedThinkingBlock;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.AnthropicRedactedThinkingBlock? value)
        {
            AnthropicRedactedThinkingBlock = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.AnthropicServerToolUseBlock value) => new ORAnthropicContentBlock((global::OpenRouter.AnthropicServerToolUseBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicServerToolUseBlock?(ORAnthropicContentBlock @this) => @this.AnthropicServerToolUseBlock;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.AnthropicServerToolUseBlock? value)
        {
            AnthropicServerToolUseBlock = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.AnthropicWebSearchToolResult value) => new ORAnthropicContentBlock((global::OpenRouter.AnthropicWebSearchToolResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicWebSearchToolResult?(ORAnthropicContentBlock @this) => @this.AnthropicWebSearchToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.AnthropicWebSearchToolResult? value)
        {
            AnthropicWebSearchToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.AnthropicWebFetchToolResult value) => new ORAnthropicContentBlock((global::OpenRouter.AnthropicWebFetchToolResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicWebFetchToolResult?(ORAnthropicContentBlock @this) => @this.AnthropicWebFetchToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.AnthropicWebFetchToolResult? value)
        {
            AnthropicWebFetchToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.AnthropicCodeExecutionToolResult value) => new ORAnthropicContentBlock((global::OpenRouter.AnthropicCodeExecutionToolResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCodeExecutionToolResult?(ORAnthropicContentBlock @this) => @this.AnthropicCodeExecutionToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.AnthropicCodeExecutionToolResult? value)
        {
            AnthropicCodeExecutionToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.AnthropicBashCodeExecutionToolResult value) => new ORAnthropicContentBlock((global::OpenRouter.AnthropicBashCodeExecutionToolResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicBashCodeExecutionToolResult?(ORAnthropicContentBlock @this) => @this.AnthropicBashCodeExecutionToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.AnthropicBashCodeExecutionToolResult? value)
        {
            AnthropicBashCodeExecutionToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult value) => new ORAnthropicContentBlock((global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult?(ORAnthropicContentBlock @this) => @this.AnthropicTextEditorCodeExecutionToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult? value)
        {
            AnthropicTextEditorCodeExecutionToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.AnthropicToolSearchToolResult value) => new ORAnthropicContentBlock((global::OpenRouter.AnthropicToolSearchToolResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicToolSearchToolResult?(ORAnthropicContentBlock @this) => @this.AnthropicToolSearchToolResult;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.AnthropicToolSearchToolResult? value)
        {
            AnthropicToolSearchToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.AnthropicContainerUpload value) => new ORAnthropicContentBlock((global::OpenRouter.AnthropicContainerUpload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicContainerUpload?(ORAnthropicContentBlock @this) => @this.AnthropicContainerUpload;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.AnthropicContainerUpload? value)
        {
            AnthropicContainerUpload = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.AnthropicCompactionBlock value) => new ORAnthropicContentBlock((global::OpenRouter.AnthropicCompactionBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCompactionBlock?(ORAnthropicContentBlock @this) => @this.AnthropicCompactionBlock;

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.AnthropicCompactionBlock? value)
        {
            AnthropicCompactionBlock = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ORAnthropicContentBlock(
            global::OpenRouter.AnthropicTextBlock? anthropicTextBlock,
            global::OpenRouter.AnthropicToolUseBlock? anthropicToolUseBlock,
            global::OpenRouter.AnthropicThinkingBlock? anthropicThinkingBlock,
            global::OpenRouter.AnthropicRedactedThinkingBlock? anthropicRedactedThinkingBlock,
            global::OpenRouter.AnthropicServerToolUseBlock? anthropicServerToolUseBlock,
            global::OpenRouter.AnthropicWebSearchToolResult? anthropicWebSearchToolResult,
            global::OpenRouter.AnthropicWebFetchToolResult? anthropicWebFetchToolResult,
            global::OpenRouter.AnthropicCodeExecutionToolResult? anthropicCodeExecutionToolResult,
            global::OpenRouter.AnthropicBashCodeExecutionToolResult? anthropicBashCodeExecutionToolResult,
            global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult? anthropicTextEditorCodeExecutionToolResult,
            global::OpenRouter.AnthropicToolSearchToolResult? anthropicToolSearchToolResult,
            global::OpenRouter.AnthropicContainerUpload? anthropicContainerUpload,
            global::OpenRouter.AnthropicCompactionBlock? anthropicCompactionBlock
            )
        {
            AnthropicTextBlock = anthropicTextBlock;
            AnthropicToolUseBlock = anthropicToolUseBlock;
            AnthropicThinkingBlock = anthropicThinkingBlock;
            AnthropicRedactedThinkingBlock = anthropicRedactedThinkingBlock;
            AnthropicServerToolUseBlock = anthropicServerToolUseBlock;
            AnthropicWebSearchToolResult = anthropicWebSearchToolResult;
            AnthropicWebFetchToolResult = anthropicWebFetchToolResult;
            AnthropicCodeExecutionToolResult = anthropicCodeExecutionToolResult;
            AnthropicBashCodeExecutionToolResult = anthropicBashCodeExecutionToolResult;
            AnthropicTextEditorCodeExecutionToolResult = anthropicTextEditorCodeExecutionToolResult;
            AnthropicToolSearchToolResult = anthropicToolSearchToolResult;
            AnthropicContainerUpload = anthropicContainerUpload;
            AnthropicCompactionBlock = anthropicCompactionBlock;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnthropicCompactionBlock as object ??
            AnthropicContainerUpload as object ??
            AnthropicToolSearchToolResult as object ??
            AnthropicTextEditorCodeExecutionToolResult as object ??
            AnthropicBashCodeExecutionToolResult as object ??
            AnthropicCodeExecutionToolResult as object ??
            AnthropicWebFetchToolResult as object ??
            AnthropicWebSearchToolResult as object ??
            AnthropicServerToolUseBlock as object ??
            AnthropicRedactedThinkingBlock as object ??
            AnthropicThinkingBlock as object ??
            AnthropicToolUseBlock as object ??
            AnthropicTextBlock as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnthropicTextBlock?.ToString() ??
            AnthropicToolUseBlock?.ToString() ??
            AnthropicThinkingBlock?.ToString() ??
            AnthropicRedactedThinkingBlock?.ToString() ??
            AnthropicServerToolUseBlock?.ToString() ??
            AnthropicWebSearchToolResult?.ToString() ??
            AnthropicWebFetchToolResult?.ToString() ??
            AnthropicCodeExecutionToolResult?.ToString() ??
            AnthropicBashCodeExecutionToolResult?.ToString() ??
            AnthropicTextEditorCodeExecutionToolResult?.ToString() ??
            AnthropicToolSearchToolResult?.ToString() ??
            AnthropicContainerUpload?.ToString() ??
            AnthropicCompactionBlock?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicTextBlock && !IsAnthropicToolUseBlock && !IsAnthropicThinkingBlock && !IsAnthropicRedactedThinkingBlock && !IsAnthropicServerToolUseBlock && !IsAnthropicWebSearchToolResult && !IsAnthropicWebFetchToolResult && !IsAnthropicCodeExecutionToolResult && !IsAnthropicBashCodeExecutionToolResult && !IsAnthropicTextEditorCodeExecutionToolResult && !IsAnthropicToolSearchToolResult && !IsAnthropicContainerUpload && !IsAnthropicCompactionBlock || !IsAnthropicTextBlock && IsAnthropicToolUseBlock && !IsAnthropicThinkingBlock && !IsAnthropicRedactedThinkingBlock && !IsAnthropicServerToolUseBlock && !IsAnthropicWebSearchToolResult && !IsAnthropicWebFetchToolResult && !IsAnthropicCodeExecutionToolResult && !IsAnthropicBashCodeExecutionToolResult && !IsAnthropicTextEditorCodeExecutionToolResult && !IsAnthropicToolSearchToolResult && !IsAnthropicContainerUpload && !IsAnthropicCompactionBlock || !IsAnthropicTextBlock && !IsAnthropicToolUseBlock && IsAnthropicThinkingBlock && !IsAnthropicRedactedThinkingBlock && !IsAnthropicServerToolUseBlock && !IsAnthropicWebSearchToolResult && !IsAnthropicWebFetchToolResult && !IsAnthropicCodeExecutionToolResult && !IsAnthropicBashCodeExecutionToolResult && !IsAnthropicTextEditorCodeExecutionToolResult && !IsAnthropicToolSearchToolResult && !IsAnthropicContainerUpload && !IsAnthropicCompactionBlock || !IsAnthropicTextBlock && !IsAnthropicToolUseBlock && !IsAnthropicThinkingBlock && IsAnthropicRedactedThinkingBlock && !IsAnthropicServerToolUseBlock && !IsAnthropicWebSearchToolResult && !IsAnthropicWebFetchToolResult && !IsAnthropicCodeExecutionToolResult && !IsAnthropicBashCodeExecutionToolResult && !IsAnthropicTextEditorCodeExecutionToolResult && !IsAnthropicToolSearchToolResult && !IsAnthropicContainerUpload && !IsAnthropicCompactionBlock || !IsAnthropicTextBlock && !IsAnthropicToolUseBlock && !IsAnthropicThinkingBlock && !IsAnthropicRedactedThinkingBlock && IsAnthropicServerToolUseBlock && !IsAnthropicWebSearchToolResult && !IsAnthropicWebFetchToolResult && !IsAnthropicCodeExecutionToolResult && !IsAnthropicBashCodeExecutionToolResult && !IsAnthropicTextEditorCodeExecutionToolResult && !IsAnthropicToolSearchToolResult && !IsAnthropicContainerUpload && !IsAnthropicCompactionBlock || !IsAnthropicTextBlock && !IsAnthropicToolUseBlock && !IsAnthropicThinkingBlock && !IsAnthropicRedactedThinkingBlock && !IsAnthropicServerToolUseBlock && IsAnthropicWebSearchToolResult && !IsAnthropicWebFetchToolResult && !IsAnthropicCodeExecutionToolResult && !IsAnthropicBashCodeExecutionToolResult && !IsAnthropicTextEditorCodeExecutionToolResult && !IsAnthropicToolSearchToolResult && !IsAnthropicContainerUpload && !IsAnthropicCompactionBlock || !IsAnthropicTextBlock && !IsAnthropicToolUseBlock && !IsAnthropicThinkingBlock && !IsAnthropicRedactedThinkingBlock && !IsAnthropicServerToolUseBlock && !IsAnthropicWebSearchToolResult && IsAnthropicWebFetchToolResult && !IsAnthropicCodeExecutionToolResult && !IsAnthropicBashCodeExecutionToolResult && !IsAnthropicTextEditorCodeExecutionToolResult && !IsAnthropicToolSearchToolResult && !IsAnthropicContainerUpload && !IsAnthropicCompactionBlock || !IsAnthropicTextBlock && !IsAnthropicToolUseBlock && !IsAnthropicThinkingBlock && !IsAnthropicRedactedThinkingBlock && !IsAnthropicServerToolUseBlock && !IsAnthropicWebSearchToolResult && !IsAnthropicWebFetchToolResult && IsAnthropicCodeExecutionToolResult && !IsAnthropicBashCodeExecutionToolResult && !IsAnthropicTextEditorCodeExecutionToolResult && !IsAnthropicToolSearchToolResult && !IsAnthropicContainerUpload && !IsAnthropicCompactionBlock || !IsAnthropicTextBlock && !IsAnthropicToolUseBlock && !IsAnthropicThinkingBlock && !IsAnthropicRedactedThinkingBlock && !IsAnthropicServerToolUseBlock && !IsAnthropicWebSearchToolResult && !IsAnthropicWebFetchToolResult && !IsAnthropicCodeExecutionToolResult && IsAnthropicBashCodeExecutionToolResult && !IsAnthropicTextEditorCodeExecutionToolResult && !IsAnthropicToolSearchToolResult && !IsAnthropicContainerUpload && !IsAnthropicCompactionBlock || !IsAnthropicTextBlock && !IsAnthropicToolUseBlock && !IsAnthropicThinkingBlock && !IsAnthropicRedactedThinkingBlock && !IsAnthropicServerToolUseBlock && !IsAnthropicWebSearchToolResult && !IsAnthropicWebFetchToolResult && !IsAnthropicCodeExecutionToolResult && !IsAnthropicBashCodeExecutionToolResult && IsAnthropicTextEditorCodeExecutionToolResult && !IsAnthropicToolSearchToolResult && !IsAnthropicContainerUpload && !IsAnthropicCompactionBlock || !IsAnthropicTextBlock && !IsAnthropicToolUseBlock && !IsAnthropicThinkingBlock && !IsAnthropicRedactedThinkingBlock && !IsAnthropicServerToolUseBlock && !IsAnthropicWebSearchToolResult && !IsAnthropicWebFetchToolResult && !IsAnthropicCodeExecutionToolResult && !IsAnthropicBashCodeExecutionToolResult && !IsAnthropicTextEditorCodeExecutionToolResult && IsAnthropicToolSearchToolResult && !IsAnthropicContainerUpload && !IsAnthropicCompactionBlock || !IsAnthropicTextBlock && !IsAnthropicToolUseBlock && !IsAnthropicThinkingBlock && !IsAnthropicRedactedThinkingBlock && !IsAnthropicServerToolUseBlock && !IsAnthropicWebSearchToolResult && !IsAnthropicWebFetchToolResult && !IsAnthropicCodeExecutionToolResult && !IsAnthropicBashCodeExecutionToolResult && !IsAnthropicTextEditorCodeExecutionToolResult && !IsAnthropicToolSearchToolResult && IsAnthropicContainerUpload && !IsAnthropicCompactionBlock || !IsAnthropicTextBlock && !IsAnthropicToolUseBlock && !IsAnthropicThinkingBlock && !IsAnthropicRedactedThinkingBlock && !IsAnthropicServerToolUseBlock && !IsAnthropicWebSearchToolResult && !IsAnthropicWebFetchToolResult && !IsAnthropicCodeExecutionToolResult && !IsAnthropicBashCodeExecutionToolResult && !IsAnthropicTextEditorCodeExecutionToolResult && !IsAnthropicToolSearchToolResult && !IsAnthropicContainerUpload && IsAnthropicCompactionBlock;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicTextBlock?, TResult>? anthropicTextBlock = null,
            global::System.Func<global::OpenRouter.AnthropicToolUseBlock?, TResult>? anthropicToolUseBlock = null,
            global::System.Func<global::OpenRouter.AnthropicThinkingBlock?, TResult>? anthropicThinkingBlock = null,
            global::System.Func<global::OpenRouter.AnthropicRedactedThinkingBlock?, TResult>? anthropicRedactedThinkingBlock = null,
            global::System.Func<global::OpenRouter.AnthropicServerToolUseBlock?, TResult>? anthropicServerToolUseBlock = null,
            global::System.Func<global::OpenRouter.AnthropicWebSearchToolResult?, TResult>? anthropicWebSearchToolResult = null,
            global::System.Func<global::OpenRouter.AnthropicWebFetchToolResult?, TResult>? anthropicWebFetchToolResult = null,
            global::System.Func<global::OpenRouter.AnthropicCodeExecutionToolResult?, TResult>? anthropicCodeExecutionToolResult = null,
            global::System.Func<global::OpenRouter.AnthropicBashCodeExecutionToolResult?, TResult>? anthropicBashCodeExecutionToolResult = null,
            global::System.Func<global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult?, TResult>? anthropicTextEditorCodeExecutionToolResult = null,
            global::System.Func<global::OpenRouter.AnthropicToolSearchToolResult?, TResult>? anthropicToolSearchToolResult = null,
            global::System.Func<global::OpenRouter.AnthropicContainerUpload?, TResult>? anthropicContainerUpload = null,
            global::System.Func<global::OpenRouter.AnthropicCompactionBlock?, TResult>? anthropicCompactionBlock = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicTextBlock && anthropicTextBlock != null)
            {
                return anthropicTextBlock(AnthropicTextBlock!);
            }
            else if (IsAnthropicToolUseBlock && anthropicToolUseBlock != null)
            {
                return anthropicToolUseBlock(AnthropicToolUseBlock!);
            }
            else if (IsAnthropicThinkingBlock && anthropicThinkingBlock != null)
            {
                return anthropicThinkingBlock(AnthropicThinkingBlock!);
            }
            else if (IsAnthropicRedactedThinkingBlock && anthropicRedactedThinkingBlock != null)
            {
                return anthropicRedactedThinkingBlock(AnthropicRedactedThinkingBlock!);
            }
            else if (IsAnthropicServerToolUseBlock && anthropicServerToolUseBlock != null)
            {
                return anthropicServerToolUseBlock(AnthropicServerToolUseBlock!);
            }
            else if (IsAnthropicWebSearchToolResult && anthropicWebSearchToolResult != null)
            {
                return anthropicWebSearchToolResult(AnthropicWebSearchToolResult!);
            }
            else if (IsAnthropicWebFetchToolResult && anthropicWebFetchToolResult != null)
            {
                return anthropicWebFetchToolResult(AnthropicWebFetchToolResult!);
            }
            else if (IsAnthropicCodeExecutionToolResult && anthropicCodeExecutionToolResult != null)
            {
                return anthropicCodeExecutionToolResult(AnthropicCodeExecutionToolResult!);
            }
            else if (IsAnthropicBashCodeExecutionToolResult && anthropicBashCodeExecutionToolResult != null)
            {
                return anthropicBashCodeExecutionToolResult(AnthropicBashCodeExecutionToolResult!);
            }
            else if (IsAnthropicTextEditorCodeExecutionToolResult && anthropicTextEditorCodeExecutionToolResult != null)
            {
                return anthropicTextEditorCodeExecutionToolResult(AnthropicTextEditorCodeExecutionToolResult!);
            }
            else if (IsAnthropicToolSearchToolResult && anthropicToolSearchToolResult != null)
            {
                return anthropicToolSearchToolResult(AnthropicToolSearchToolResult!);
            }
            else if (IsAnthropicContainerUpload && anthropicContainerUpload != null)
            {
                return anthropicContainerUpload(AnthropicContainerUpload!);
            }
            else if (IsAnthropicCompactionBlock && anthropicCompactionBlock != null)
            {
                return anthropicCompactionBlock(AnthropicCompactionBlock!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicTextBlock?>? anthropicTextBlock = null,
            global::System.Action<global::OpenRouter.AnthropicToolUseBlock?>? anthropicToolUseBlock = null,
            global::System.Action<global::OpenRouter.AnthropicThinkingBlock?>? anthropicThinkingBlock = null,
            global::System.Action<global::OpenRouter.AnthropicRedactedThinkingBlock?>? anthropicRedactedThinkingBlock = null,
            global::System.Action<global::OpenRouter.AnthropicServerToolUseBlock?>? anthropicServerToolUseBlock = null,
            global::System.Action<global::OpenRouter.AnthropicWebSearchToolResult?>? anthropicWebSearchToolResult = null,
            global::System.Action<global::OpenRouter.AnthropicWebFetchToolResult?>? anthropicWebFetchToolResult = null,
            global::System.Action<global::OpenRouter.AnthropicCodeExecutionToolResult?>? anthropicCodeExecutionToolResult = null,
            global::System.Action<global::OpenRouter.AnthropicBashCodeExecutionToolResult?>? anthropicBashCodeExecutionToolResult = null,
            global::System.Action<global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult?>? anthropicTextEditorCodeExecutionToolResult = null,
            global::System.Action<global::OpenRouter.AnthropicToolSearchToolResult?>? anthropicToolSearchToolResult = null,
            global::System.Action<global::OpenRouter.AnthropicContainerUpload?>? anthropicContainerUpload = null,
            global::System.Action<global::OpenRouter.AnthropicCompactionBlock?>? anthropicCompactionBlock = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicTextBlock)
            {
                anthropicTextBlock?.Invoke(AnthropicTextBlock!);
            }
            else if (IsAnthropicToolUseBlock)
            {
                anthropicToolUseBlock?.Invoke(AnthropicToolUseBlock!);
            }
            else if (IsAnthropicThinkingBlock)
            {
                anthropicThinkingBlock?.Invoke(AnthropicThinkingBlock!);
            }
            else if (IsAnthropicRedactedThinkingBlock)
            {
                anthropicRedactedThinkingBlock?.Invoke(AnthropicRedactedThinkingBlock!);
            }
            else if (IsAnthropicServerToolUseBlock)
            {
                anthropicServerToolUseBlock?.Invoke(AnthropicServerToolUseBlock!);
            }
            else if (IsAnthropicWebSearchToolResult)
            {
                anthropicWebSearchToolResult?.Invoke(AnthropicWebSearchToolResult!);
            }
            else if (IsAnthropicWebFetchToolResult)
            {
                anthropicWebFetchToolResult?.Invoke(AnthropicWebFetchToolResult!);
            }
            else if (IsAnthropicCodeExecutionToolResult)
            {
                anthropicCodeExecutionToolResult?.Invoke(AnthropicCodeExecutionToolResult!);
            }
            else if (IsAnthropicBashCodeExecutionToolResult)
            {
                anthropicBashCodeExecutionToolResult?.Invoke(AnthropicBashCodeExecutionToolResult!);
            }
            else if (IsAnthropicTextEditorCodeExecutionToolResult)
            {
                anthropicTextEditorCodeExecutionToolResult?.Invoke(AnthropicTextEditorCodeExecutionToolResult!);
            }
            else if (IsAnthropicToolSearchToolResult)
            {
                anthropicToolSearchToolResult?.Invoke(AnthropicToolSearchToolResult!);
            }
            else if (IsAnthropicContainerUpload)
            {
                anthropicContainerUpload?.Invoke(AnthropicContainerUpload!);
            }
            else if (IsAnthropicCompactionBlock)
            {
                anthropicCompactionBlock?.Invoke(AnthropicCompactionBlock!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnthropicTextBlock,
                typeof(global::OpenRouter.AnthropicTextBlock),
                AnthropicToolUseBlock,
                typeof(global::OpenRouter.AnthropicToolUseBlock),
                AnthropicThinkingBlock,
                typeof(global::OpenRouter.AnthropicThinkingBlock),
                AnthropicRedactedThinkingBlock,
                typeof(global::OpenRouter.AnthropicRedactedThinkingBlock),
                AnthropicServerToolUseBlock,
                typeof(global::OpenRouter.AnthropicServerToolUseBlock),
                AnthropicWebSearchToolResult,
                typeof(global::OpenRouter.AnthropicWebSearchToolResult),
                AnthropicWebFetchToolResult,
                typeof(global::OpenRouter.AnthropicWebFetchToolResult),
                AnthropicCodeExecutionToolResult,
                typeof(global::OpenRouter.AnthropicCodeExecutionToolResult),
                AnthropicBashCodeExecutionToolResult,
                typeof(global::OpenRouter.AnthropicBashCodeExecutionToolResult),
                AnthropicTextEditorCodeExecutionToolResult,
                typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult),
                AnthropicToolSearchToolResult,
                typeof(global::OpenRouter.AnthropicToolSearchToolResult),
                AnthropicContainerUpload,
                typeof(global::OpenRouter.AnthropicContainerUpload),
                AnthropicCompactionBlock,
                typeof(global::OpenRouter.AnthropicCompactionBlock),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextBlock?>.Default.Equals(AnthropicTextBlock, other.AnthropicTextBlock) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicToolUseBlock?>.Default.Equals(AnthropicToolUseBlock, other.AnthropicToolUseBlock) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicThinkingBlock?>.Default.Equals(AnthropicThinkingBlock, other.AnthropicThinkingBlock) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicRedactedThinkingBlock?>.Default.Equals(AnthropicRedactedThinkingBlock, other.AnthropicRedactedThinkingBlock) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicServerToolUseBlock?>.Default.Equals(AnthropicServerToolUseBlock, other.AnthropicServerToolUseBlock) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicWebSearchToolResult?>.Default.Equals(AnthropicWebSearchToolResult, other.AnthropicWebSearchToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicWebFetchToolResult?>.Default.Equals(AnthropicWebFetchToolResult, other.AnthropicWebFetchToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCodeExecutionToolResult?>.Default.Equals(AnthropicCodeExecutionToolResult, other.AnthropicCodeExecutionToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicBashCodeExecutionToolResult?>.Default.Equals(AnthropicBashCodeExecutionToolResult, other.AnthropicBashCodeExecutionToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult?>.Default.Equals(AnthropicTextEditorCodeExecutionToolResult, other.AnthropicTextEditorCodeExecutionToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicToolSearchToolResult?>.Default.Equals(AnthropicToolSearchToolResult, other.AnthropicToolSearchToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicContainerUpload?>.Default.Equals(AnthropicContainerUpload, other.AnthropicContainerUpload) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCompactionBlock?>.Default.Equals(AnthropicCompactionBlock, other.AnthropicCompactionBlock) 
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
