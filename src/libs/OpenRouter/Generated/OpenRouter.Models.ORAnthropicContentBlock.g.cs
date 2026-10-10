#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"citations":null,"text":"Hello, world!","type":"text"}
    /// </summary>
    public readonly partial struct ORAnthropicContentBlock : global::System.IEquatable<ORAnthropicContentBlock>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicContentBlockDiscriminatorType? Type { get; }

        /// <summary>
        /// Example: {"citations":null,"text":"Hello, world!","type":"text"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextBlock? Text { get; init; }
#else
        public global::OpenRouter.AnthropicTextBlock? Text { get; }
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
            out global::OpenRouter.AnthropicTextBlock? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextBlock PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"caller":{"type":"direct"},"id":"toolu_01abc","input":{"location":"San Francisco"},"name":"get_weather","type":"tool_use"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicToolUseBlock? ToolUse { get; init; }
#else
        public global::OpenRouter.AnthropicToolUseBlock? ToolUse { get; }
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
            out global::OpenRouter.AnthropicToolUseBlock? value)
        {
            value = ToolUse;
            return IsToolUse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUseBlock PickToolUse() => ToolUse is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolUse' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"signature":"sig_abc123","thinking":"Let me think about this...","type":"thinking"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicThinkingBlock? Thinking { get; init; }
#else
        public global::OpenRouter.AnthropicThinkingBlock? Thinking { get; }
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
            out global::OpenRouter.AnthropicThinkingBlock? value)
        {
            value = Thinking;
            return IsThinking;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicThinkingBlock PickThinking() => Thinking is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Thinking' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"data":"cmVkYWN0ZWQ=","type":"redacted_thinking"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicRedactedThinkingBlock? RedactedThinking { get; init; }
#else
        public global::OpenRouter.AnthropicRedactedThinkingBlock? RedactedThinking { get; }
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
            out global::OpenRouter.AnthropicRedactedThinkingBlock? value)
        {
            value = RedactedThinking;
            return IsRedactedThinking;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicRedactedThinkingBlock PickRedactedThinking() => RedactedThinking is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RedactedThinking' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"caller":{"type":"direct"},"id":"srvtoolu_01abc","input":{},"name":"advisor","type":"server_tool_use"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicServerToolUseBlock? ServerToolUse { get; init; }
#else
        public global::OpenRouter.ORAnthropicServerToolUseBlock? ServerToolUse { get; }
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
            out global::OpenRouter.ORAnthropicServerToolUseBlock? value)
        {
            value = ServerToolUse;
            return IsServerToolUse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicServerToolUseBlock PickServerToolUse() => ServerToolUse is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ServerToolUse' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"caller":{"type":"direct"},"content":[],"tool_use_id":"srvtoolu_01abc","type":"web_search_tool_result"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicWebSearchToolResult? WebSearchToolResult { get; init; }
#else
        public global::OpenRouter.AnthropicWebSearchToolResult? WebSearchToolResult { get; }
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
            out global::OpenRouter.AnthropicWebSearchToolResult? value)
        {
            value = WebSearchToolResult;
            return IsWebSearchToolResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchToolResult PickWebSearchToolResult() => WebSearchToolResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearchToolResult' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"caller":{"type":"direct"},"content":{"content":{"citations":null,"source":{"data":"","media_type":"text/plain","type":"text"},"title":null,"type":"document"},"retrieved_at":null,"type":"web_fetch_result","url":"https://example.com"},"tool_use_id":"srvtoolu_01abc","type":"web_fetch_tool_result"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicWebFetchToolResult? WebFetchToolResult { get; init; }
#else
        public global::OpenRouter.AnthropicWebFetchToolResult? WebFetchToolResult { get; }
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
            out global::OpenRouter.AnthropicWebFetchToolResult? value)
        {
            value = WebFetchToolResult;
            return IsWebFetchToolResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicWebFetchToolResult PickWebFetchToolResult() => WebFetchToolResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebFetchToolResult' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"content":{"content":[],"return_code":0,"stderr":"","stdout":"Hello","type":"code_execution_result"},"tool_use_id":"srvtoolu_01abc","type":"code_execution_tool_result"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCodeExecutionToolResult? CodeExecutionToolResult { get; init; }
#else
        public global::OpenRouter.AnthropicCodeExecutionToolResult? CodeExecutionToolResult { get; }
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
            out global::OpenRouter.AnthropicCodeExecutionToolResult? value)
        {
            value = CodeExecutionToolResult;
            return IsCodeExecutionToolResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionToolResult PickCodeExecutionToolResult() => CodeExecutionToolResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeExecutionToolResult' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"content":{"content":[],"return_code":0,"stderr":"","stdout":"Hello","type":"bash_code_execution_result"},"tool_use_id":"srvtoolu_01abc","type":"bash_code_execution_tool_result"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicBashCodeExecutionToolResult? BashCodeExecutionToolResult { get; init; }
#else
        public global::OpenRouter.AnthropicBashCodeExecutionToolResult? BashCodeExecutionToolResult { get; }
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
            out global::OpenRouter.AnthropicBashCodeExecutionToolResult? value)
        {
            value = BashCodeExecutionToolResult;
            return IsBashCodeExecutionToolResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionToolResult PickBashCodeExecutionToolResult() => BashCodeExecutionToolResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BashCodeExecutionToolResult' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"content":{"content":"file content","file_type":"text","num_lines":10,"start_line":1,"total_lines":10,"type":"text_editor_code_execution_view_result"},"tool_use_id":"srvtoolu_01abc","type":"text_editor_code_execution_tool_result"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult? TextEditorCodeExecutionToolResult { get; init; }
#else
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult? TextEditorCodeExecutionToolResult { get; }
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
            out global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult? value)
        {
            value = TextEditorCodeExecutionToolResult;
            return IsTextEditorCodeExecutionToolResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult PickTextEditorCodeExecutionToolResult() => TextEditorCodeExecutionToolResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextEditorCodeExecutionToolResult' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"content":{"tool_references":[{"tool_name":"my_tool","type":"tool_reference"}],"type":"tool_search_tool_search_result"},"tool_use_id":"srvtoolu_01abc","type":"tool_search_tool_result"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicToolSearchToolResult? ToolSearchToolResult { get; init; }
#else
        public global::OpenRouter.AnthropicToolSearchToolResult? ToolSearchToolResult { get; }
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
            out global::OpenRouter.AnthropicToolSearchToolResult? value)
        {
            value = ToolSearchToolResult;
            return IsToolSearchToolResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolSearchToolResult PickToolSearchToolResult() => ToolSearchToolResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolSearchToolResult' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"file_id":"file_01abc","type":"container_upload"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicContainerUpload? ContainerUpload { get; init; }
#else
        public global::OpenRouter.AnthropicContainerUpload? ContainerUpload { get; }
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
            out global::OpenRouter.AnthropicContainerUpload? value)
        {
            value = ContainerUpload;
            return IsContainerUpload;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicContainerUpload PickContainerUpload() => ContainerUpload is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContainerUpload' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"content":"Compacted summary of conversation.","type":"compaction"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCompactionBlock? Compaction { get; init; }
#else
        public global::OpenRouter.AnthropicCompactionBlock? Compaction { get; }
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
            out global::OpenRouter.AnthropicCompactionBlock? value)
        {
            value = Compaction;
            return IsCompaction;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCompactionBlock PickCompaction() => Compaction is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Compaction' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"content":{"text":"Advisor response text","type":"advisor_result"},"tool_use_id":"srvtoolu_01abc","type":"advisor_tool_result"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicAdvisorToolResult? AdvisorToolResult { get; init; }
#else
        public global::OpenRouter.AnthropicAdvisorToolResult? AdvisorToolResult { get; }
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
            out global::OpenRouter.AnthropicAdvisorToolResult? value)
        {
            value = AdvisorToolResult;
            return IsAdvisorToolResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicAdvisorToolResult PickAdvisorToolResult() => AdvisorToolResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AdvisorToolResult' but the value was {ToString()}.");

        /// <summary>
        /// Output of an `openrouter:shell` call executed in the OpenRouter sandbox<br/>
        /// Example: {"content":{"output":[{"outcome":{"exit_code":0,"type":"exit"},"stderr":"","stdout":"README.md\n"}]},"tool_use_id":"srvtoolu_01abc","type":"openrouter_shell_tool_result"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicShellToolResult? OpenrouterShellToolResult { get; init; }
#else
        public global::OpenRouter.ORAnthropicShellToolResult? OpenrouterShellToolResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterShellToolResult))]
#endif
        public bool IsOpenrouterShellToolResult => OpenrouterShellToolResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenrouterShellToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ORAnthropicShellToolResult? value)
        {
            value = OpenrouterShellToolResult;
            return IsOpenrouterShellToolResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicShellToolResult PickOpenrouterShellToolResult() => OpenrouterShellToolResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterShellToolResult' but the value was {ToString()}.");

        /// <summary>
        /// Output of an `openrouter:bash` call executed in the OpenRouter sandbox (`engine: 'openrouter'`)<br/>
        /// Example: {"content":{"command":"ls","exitCode":0,"stderr":"","stdout":"README.md\n"},"tool_use_id":"srvtoolu_01abc","type":"openrouter_bash_tool_result"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicBashToolResult? OpenrouterBashToolResult { get; init; }
#else
        public global::OpenRouter.ORAnthropicBashToolResult? OpenrouterBashToolResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterBashToolResult))]
#endif
        public bool IsOpenrouterBashToolResult => OpenrouterBashToolResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenrouterBashToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ORAnthropicBashToolResult? value)
        {
            value = OpenrouterBashToolResult;
            return IsOpenrouterBashToolResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicBashToolResult PickOpenrouterBashToolResult() => OpenrouterBashToolResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterBashToolResult' but the value was {ToString()}.");

        /// <summary>
        /// Router-owned deferred discovery result containing original selected tool definitions.<br/>
        /// Example: {"content":{"matches":[]},"tool_use_id":"search","type":"openrouter_tool_search_result"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ORAnthropicToolSearchResult? OpenrouterToolSearchResult { get; init; }
#else
        public global::OpenRouter.ORAnthropicToolSearchResult? OpenrouterToolSearchResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterToolSearchResult))]
#endif
        public bool IsOpenrouterToolSearchResult => OpenrouterToolSearchResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenrouterToolSearchResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ORAnthropicToolSearchResult? value)
        {
            value = OpenrouterToolSearchResult;
            return IsOpenrouterToolSearchResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ORAnthropicToolSearchResult PickOpenrouterToolSearchResult() => OpenrouterToolSearchResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterToolSearchResult' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.AnthropicTextBlock value) => new ORAnthropicContentBlock((global::OpenRouter.AnthropicTextBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextBlock?(ORAnthropicContentBlock @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.AnthropicTextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicContentBlock FromText(global::OpenRouter.AnthropicTextBlock? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.AnthropicToolUseBlock value) => new ORAnthropicContentBlock((global::OpenRouter.AnthropicToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicToolUseBlock?(ORAnthropicContentBlock @this) => @this.ToolUse;

        /// <summary>
        ///
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.AnthropicToolUseBlock? value)
        {
            ToolUse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicContentBlock FromToolUse(global::OpenRouter.AnthropicToolUseBlock? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.AnthropicThinkingBlock value) => new ORAnthropicContentBlock((global::OpenRouter.AnthropicThinkingBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicThinkingBlock?(ORAnthropicContentBlock @this) => @this.Thinking;

        /// <summary>
        ///
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.AnthropicThinkingBlock? value)
        {
            Thinking = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicContentBlock FromThinking(global::OpenRouter.AnthropicThinkingBlock? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.AnthropicRedactedThinkingBlock value) => new ORAnthropicContentBlock((global::OpenRouter.AnthropicRedactedThinkingBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicRedactedThinkingBlock?(ORAnthropicContentBlock @this) => @this.RedactedThinking;

        /// <summary>
        ///
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.AnthropicRedactedThinkingBlock? value)
        {
            RedactedThinking = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicContentBlock FromRedactedThinking(global::OpenRouter.AnthropicRedactedThinkingBlock? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicServerToolUseBlock value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicServerToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicServerToolUseBlock?(ORAnthropicContentBlock @this) => @this.ServerToolUse;

        /// <summary>
        ///
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicServerToolUseBlock? value)
        {
            ServerToolUse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicContentBlock FromServerToolUse(global::OpenRouter.ORAnthropicServerToolUseBlock? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.AnthropicWebSearchToolResult value) => new ORAnthropicContentBlock((global::OpenRouter.AnthropicWebSearchToolResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicWebSearchToolResult?(ORAnthropicContentBlock @this) => @this.WebSearchToolResult;

        /// <summary>
        ///
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.AnthropicWebSearchToolResult? value)
        {
            WebSearchToolResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicContentBlock FromWebSearchToolResult(global::OpenRouter.AnthropicWebSearchToolResult? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.AnthropicWebFetchToolResult value) => new ORAnthropicContentBlock((global::OpenRouter.AnthropicWebFetchToolResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicWebFetchToolResult?(ORAnthropicContentBlock @this) => @this.WebFetchToolResult;

        /// <summary>
        ///
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.AnthropicWebFetchToolResult? value)
        {
            WebFetchToolResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicContentBlock FromWebFetchToolResult(global::OpenRouter.AnthropicWebFetchToolResult? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.AnthropicCodeExecutionToolResult value) => new ORAnthropicContentBlock((global::OpenRouter.AnthropicCodeExecutionToolResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCodeExecutionToolResult?(ORAnthropicContentBlock @this) => @this.CodeExecutionToolResult;

        /// <summary>
        ///
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.AnthropicCodeExecutionToolResult? value)
        {
            CodeExecutionToolResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicContentBlock FromCodeExecutionToolResult(global::OpenRouter.AnthropicCodeExecutionToolResult? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.AnthropicBashCodeExecutionToolResult value) => new ORAnthropicContentBlock((global::OpenRouter.AnthropicBashCodeExecutionToolResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicBashCodeExecutionToolResult?(ORAnthropicContentBlock @this) => @this.BashCodeExecutionToolResult;

        /// <summary>
        ///
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.AnthropicBashCodeExecutionToolResult? value)
        {
            BashCodeExecutionToolResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicContentBlock FromBashCodeExecutionToolResult(global::OpenRouter.AnthropicBashCodeExecutionToolResult? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult value) => new ORAnthropicContentBlock((global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult?(ORAnthropicContentBlock @this) => @this.TextEditorCodeExecutionToolResult;

        /// <summary>
        ///
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult? value)
        {
            TextEditorCodeExecutionToolResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicContentBlock FromTextEditorCodeExecutionToolResult(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.AnthropicToolSearchToolResult value) => new ORAnthropicContentBlock((global::OpenRouter.AnthropicToolSearchToolResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicToolSearchToolResult?(ORAnthropicContentBlock @this) => @this.ToolSearchToolResult;

        /// <summary>
        ///
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.AnthropicToolSearchToolResult? value)
        {
            ToolSearchToolResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicContentBlock FromToolSearchToolResult(global::OpenRouter.AnthropicToolSearchToolResult? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.AnthropicContainerUpload value) => new ORAnthropicContentBlock((global::OpenRouter.AnthropicContainerUpload?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicContainerUpload?(ORAnthropicContentBlock @this) => @this.ContainerUpload;

        /// <summary>
        ///
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.AnthropicContainerUpload? value)
        {
            ContainerUpload = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicContentBlock FromContainerUpload(global::OpenRouter.AnthropicContainerUpload? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.AnthropicCompactionBlock value) => new ORAnthropicContentBlock((global::OpenRouter.AnthropicCompactionBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCompactionBlock?(ORAnthropicContentBlock @this) => @this.Compaction;

        /// <summary>
        ///
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.AnthropicCompactionBlock? value)
        {
            Compaction = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicContentBlock FromCompaction(global::OpenRouter.AnthropicCompactionBlock? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.AnthropicAdvisorToolResult value) => new ORAnthropicContentBlock((global::OpenRouter.AnthropicAdvisorToolResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicAdvisorToolResult?(ORAnthropicContentBlock @this) => @this.AdvisorToolResult;

        /// <summary>
        ///
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.AnthropicAdvisorToolResult? value)
        {
            AdvisorToolResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicContentBlock FromAdvisorToolResult(global::OpenRouter.AnthropicAdvisorToolResult? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicShellToolResult value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicShellToolResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicShellToolResult?(ORAnthropicContentBlock @this) => @this.OpenrouterShellToolResult;

        /// <summary>
        ///
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicShellToolResult? value)
        {
            OpenrouterShellToolResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicContentBlock FromOpenrouterShellToolResult(global::OpenRouter.ORAnthropicShellToolResult? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicBashToolResult value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicBashToolResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicBashToolResult?(ORAnthropicContentBlock @this) => @this.OpenrouterBashToolResult;

        /// <summary>
        ///
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicBashToolResult? value)
        {
            OpenrouterBashToolResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicContentBlock FromOpenrouterBashToolResult(global::OpenRouter.ORAnthropicBashToolResult? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ORAnthropicContentBlock(global::OpenRouter.ORAnthropicToolSearchResult value) => new ORAnthropicContentBlock((global::OpenRouter.ORAnthropicToolSearchResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ORAnthropicToolSearchResult?(ORAnthropicContentBlock @this) => @this.OpenrouterToolSearchResult;

        /// <summary>
        ///
        /// </summary>
        public ORAnthropicContentBlock(global::OpenRouter.ORAnthropicToolSearchResult? value)
        {
            OpenrouterToolSearchResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicContentBlock FromOpenrouterToolSearchResult(global::OpenRouter.ORAnthropicToolSearchResult? value) => new ORAnthropicContentBlock(value);

        /// <summary>
        ///
        /// </summary>
        public ORAnthropicContentBlock(
            global::OpenRouter.ORAnthropicContentBlockDiscriminatorType? type,
            global::OpenRouter.AnthropicTextBlock? text,
            global::OpenRouter.AnthropicToolUseBlock? toolUse,
            global::OpenRouter.AnthropicThinkingBlock? thinking,
            global::OpenRouter.AnthropicRedactedThinkingBlock? redactedThinking,
            global::OpenRouter.ORAnthropicServerToolUseBlock? serverToolUse,
            global::OpenRouter.AnthropicWebSearchToolResult? webSearchToolResult,
            global::OpenRouter.AnthropicWebFetchToolResult? webFetchToolResult,
            global::OpenRouter.AnthropicCodeExecutionToolResult? codeExecutionToolResult,
            global::OpenRouter.AnthropicBashCodeExecutionToolResult? bashCodeExecutionToolResult,
            global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult? textEditorCodeExecutionToolResult,
            global::OpenRouter.AnthropicToolSearchToolResult? toolSearchToolResult,
            global::OpenRouter.AnthropicContainerUpload? containerUpload,
            global::OpenRouter.AnthropicCompactionBlock? compaction,
            global::OpenRouter.AnthropicAdvisorToolResult? advisorToolResult,
            global::OpenRouter.ORAnthropicShellToolResult? openrouterShellToolResult,
            global::OpenRouter.ORAnthropicBashToolResult? openrouterBashToolResult,
            global::OpenRouter.ORAnthropicToolSearchResult? openrouterToolSearchResult
            )
        {
            Type = type;

            Text = text;
            ToolUse = toolUse;
            Thinking = thinking;
            RedactedThinking = redactedThinking;
            ServerToolUse = serverToolUse;
            WebSearchToolResult = webSearchToolResult;
            WebFetchToolResult = webFetchToolResult;
            CodeExecutionToolResult = codeExecutionToolResult;
            BashCodeExecutionToolResult = bashCodeExecutionToolResult;
            TextEditorCodeExecutionToolResult = textEditorCodeExecutionToolResult;
            ToolSearchToolResult = toolSearchToolResult;
            ContainerUpload = containerUpload;
            Compaction = compaction;
            AdvisorToolResult = advisorToolResult;
            OpenrouterShellToolResult = openrouterShellToolResult;
            OpenrouterBashToolResult = openrouterBashToolResult;
            OpenrouterToolSearchResult = openrouterToolSearchResult;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            OpenrouterToolSearchResult as object ??
            OpenrouterBashToolResult as object ??
            OpenrouterShellToolResult as object ??
            AdvisorToolResult as object ??
            Compaction as object ??
            ContainerUpload as object ??
            ToolSearchToolResult as object ??
            TextEditorCodeExecutionToolResult as object ??
            BashCodeExecutionToolResult as object ??
            CodeExecutionToolResult as object ??
            WebFetchToolResult as object ??
            WebSearchToolResult as object ??
            ServerToolUse as object ??
            RedactedThinking as object ??
            Thinking as object ??
            ToolUse as object ??
            Text as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            ToolUse?.ToString() ??
            Thinking?.ToString() ??
            RedactedThinking?.ToString() ??
            ServerToolUse?.ToString() ??
            WebSearchToolResult?.ToString() ??
            WebFetchToolResult?.ToString() ??
            CodeExecutionToolResult?.ToString() ??
            BashCodeExecutionToolResult?.ToString() ??
            TextEditorCodeExecutionToolResult?.ToString() ??
            ToolSearchToolResult?.ToString() ??
            ContainerUpload?.ToString() ??
            Compaction?.ToString() ??
            AdvisorToolResult?.ToString() ??
            OpenrouterShellToolResult?.ToString() ??
            OpenrouterBashToolResult?.ToString() ??
            OpenrouterToolSearchResult?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsToolUse && !IsThinking && !IsRedactedThinking && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload && !IsCompaction && !IsAdvisorToolResult && !IsOpenrouterShellToolResult && !IsOpenrouterBashToolResult && !IsOpenrouterToolSearchResult || !IsText && IsToolUse && !IsThinking && !IsRedactedThinking && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload && !IsCompaction && !IsAdvisorToolResult && !IsOpenrouterShellToolResult && !IsOpenrouterBashToolResult && !IsOpenrouterToolSearchResult || !IsText && !IsToolUse && IsThinking && !IsRedactedThinking && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload && !IsCompaction && !IsAdvisorToolResult && !IsOpenrouterShellToolResult && !IsOpenrouterBashToolResult && !IsOpenrouterToolSearchResult || !IsText && !IsToolUse && !IsThinking && IsRedactedThinking && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload && !IsCompaction && !IsAdvisorToolResult && !IsOpenrouterShellToolResult && !IsOpenrouterBashToolResult && !IsOpenrouterToolSearchResult || !IsText && !IsToolUse && !IsThinking && !IsRedactedThinking && IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload && !IsCompaction && !IsAdvisorToolResult && !IsOpenrouterShellToolResult && !IsOpenrouterBashToolResult && !IsOpenrouterToolSearchResult || !IsText && !IsToolUse && !IsThinking && !IsRedactedThinking && !IsServerToolUse && IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload && !IsCompaction && !IsAdvisorToolResult && !IsOpenrouterShellToolResult && !IsOpenrouterBashToolResult && !IsOpenrouterToolSearchResult || !IsText && !IsToolUse && !IsThinking && !IsRedactedThinking && !IsServerToolUse && !IsWebSearchToolResult && IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload && !IsCompaction && !IsAdvisorToolResult && !IsOpenrouterShellToolResult && !IsOpenrouterBashToolResult && !IsOpenrouterToolSearchResult || !IsText && !IsToolUse && !IsThinking && !IsRedactedThinking && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload && !IsCompaction && !IsAdvisorToolResult && !IsOpenrouterShellToolResult && !IsOpenrouterBashToolResult && !IsOpenrouterToolSearchResult || !IsText && !IsToolUse && !IsThinking && !IsRedactedThinking && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload && !IsCompaction && !IsAdvisorToolResult && !IsOpenrouterShellToolResult && !IsOpenrouterBashToolResult && !IsOpenrouterToolSearchResult || !IsText && !IsToolUse && !IsThinking && !IsRedactedThinking && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload && !IsCompaction && !IsAdvisorToolResult && !IsOpenrouterShellToolResult && !IsOpenrouterBashToolResult && !IsOpenrouterToolSearchResult || !IsText && !IsToolUse && !IsThinking && !IsRedactedThinking && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && IsToolSearchToolResult && !IsContainerUpload && !IsCompaction && !IsAdvisorToolResult && !IsOpenrouterShellToolResult && !IsOpenrouterBashToolResult && !IsOpenrouterToolSearchResult || !IsText && !IsToolUse && !IsThinking && !IsRedactedThinking && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && IsContainerUpload && !IsCompaction && !IsAdvisorToolResult && !IsOpenrouterShellToolResult && !IsOpenrouterBashToolResult && !IsOpenrouterToolSearchResult || !IsText && !IsToolUse && !IsThinking && !IsRedactedThinking && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload && IsCompaction && !IsAdvisorToolResult && !IsOpenrouterShellToolResult && !IsOpenrouterBashToolResult && !IsOpenrouterToolSearchResult || !IsText && !IsToolUse && !IsThinking && !IsRedactedThinking && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload && !IsCompaction && IsAdvisorToolResult && !IsOpenrouterShellToolResult && !IsOpenrouterBashToolResult && !IsOpenrouterToolSearchResult || !IsText && !IsToolUse && !IsThinking && !IsRedactedThinking && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload && !IsCompaction && !IsAdvisorToolResult && IsOpenrouterShellToolResult && !IsOpenrouterBashToolResult && !IsOpenrouterToolSearchResult || !IsText && !IsToolUse && !IsThinking && !IsRedactedThinking && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload && !IsCompaction && !IsAdvisorToolResult && !IsOpenrouterShellToolResult && IsOpenrouterBashToolResult && !IsOpenrouterToolSearchResult || !IsText && !IsToolUse && !IsThinking && !IsRedactedThinking && !IsServerToolUse && !IsWebSearchToolResult && !IsWebFetchToolResult && !IsCodeExecutionToolResult && !IsBashCodeExecutionToolResult && !IsTextEditorCodeExecutionToolResult && !IsToolSearchToolResult && !IsContainerUpload && !IsCompaction && !IsAdvisorToolResult && !IsOpenrouterShellToolResult && !IsOpenrouterBashToolResult && IsOpenrouterToolSearchResult;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicTextBlock, TResult>? text = null,
            global::System.Func<global::OpenRouter.AnthropicToolUseBlock, TResult>? toolUse = null,
            global::System.Func<global::OpenRouter.AnthropicThinkingBlock, TResult>? thinking = null,
            global::System.Func<global::OpenRouter.AnthropicRedactedThinkingBlock, TResult>? redactedThinking = null,
            global::System.Func<global::OpenRouter.ORAnthropicServerToolUseBlock, TResult>? serverToolUse = null,
            global::System.Func<global::OpenRouter.AnthropicWebSearchToolResult, TResult>? webSearchToolResult = null,
            global::System.Func<global::OpenRouter.AnthropicWebFetchToolResult, TResult>? webFetchToolResult = null,
            global::System.Func<global::OpenRouter.AnthropicCodeExecutionToolResult, TResult>? codeExecutionToolResult = null,
            global::System.Func<global::OpenRouter.AnthropicBashCodeExecutionToolResult, TResult>? bashCodeExecutionToolResult = null,
            global::System.Func<global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult, TResult>? textEditorCodeExecutionToolResult = null,
            global::System.Func<global::OpenRouter.AnthropicToolSearchToolResult, TResult>? toolSearchToolResult = null,
            global::System.Func<global::OpenRouter.AnthropicContainerUpload, TResult>? containerUpload = null,
            global::System.Func<global::OpenRouter.AnthropicCompactionBlock, TResult>? compaction = null,
            global::System.Func<global::OpenRouter.AnthropicAdvisorToolResult, TResult>? advisorToolResult = null,
            global::System.Func<global::OpenRouter.ORAnthropicShellToolResult, TResult>? openrouterShellToolResult = null,
            global::System.Func<global::OpenRouter.ORAnthropicBashToolResult, TResult>? openrouterBashToolResult = null,
            global::System.Func<global::OpenRouter.ORAnthropicToolSearchResult, TResult>? openrouterToolSearchResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0 && text != null)
            {
                return text(__value0);
            }
            else if (ToolUse is { } __value1 && toolUse != null)
            {
                return toolUse(__value1);
            }
            else if (Thinking is { } __value2 && thinking != null)
            {
                return thinking(__value2);
            }
            else if (RedactedThinking is { } __value3 && redactedThinking != null)
            {
                return redactedThinking(__value3);
            }
            else if (ServerToolUse is { } __value4 && serverToolUse != null)
            {
                return serverToolUse(__value4);
            }
            else if (WebSearchToolResult is { } __value5 && webSearchToolResult != null)
            {
                return webSearchToolResult(__value5);
            }
            else if (WebFetchToolResult is { } __value6 && webFetchToolResult != null)
            {
                return webFetchToolResult(__value6);
            }
            else if (CodeExecutionToolResult is { } __value7 && codeExecutionToolResult != null)
            {
                return codeExecutionToolResult(__value7);
            }
            else if (BashCodeExecutionToolResult is { } __value8 && bashCodeExecutionToolResult != null)
            {
                return bashCodeExecutionToolResult(__value8);
            }
            else if (TextEditorCodeExecutionToolResult is { } __value9 && textEditorCodeExecutionToolResult != null)
            {
                return textEditorCodeExecutionToolResult(__value9);
            }
            else if (ToolSearchToolResult is { } __value10 && toolSearchToolResult != null)
            {
                return toolSearchToolResult(__value10);
            }
            else if (ContainerUpload is { } __value11 && containerUpload != null)
            {
                return containerUpload(__value11);
            }
            else if (Compaction is { } __value12 && compaction != null)
            {
                return compaction(__value12);
            }
            else if (AdvisorToolResult is { } __value13 && advisorToolResult != null)
            {
                return advisorToolResult(__value13);
            }
            else if (OpenrouterShellToolResult is { } __value14 && openrouterShellToolResult != null)
            {
                return openrouterShellToolResult(__value14);
            }
            else if (OpenrouterBashToolResult is { } __value15 && openrouterBashToolResult != null)
            {
                return openrouterBashToolResult(__value15);
            }
            else if (OpenrouterToolSearchResult is { } __value16 && openrouterToolSearchResult != null)
            {
                return openrouterToolSearchResult(__value16);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicTextBlock>? text = null,

            global::System.Action<global::OpenRouter.AnthropicToolUseBlock>? toolUse = null,

            global::System.Action<global::OpenRouter.AnthropicThinkingBlock>? thinking = null,

            global::System.Action<global::OpenRouter.AnthropicRedactedThinkingBlock>? redactedThinking = null,

            global::System.Action<global::OpenRouter.ORAnthropicServerToolUseBlock>? serverToolUse = null,

            global::System.Action<global::OpenRouter.AnthropicWebSearchToolResult>? webSearchToolResult = null,

            global::System.Action<global::OpenRouter.AnthropicWebFetchToolResult>? webFetchToolResult = null,

            global::System.Action<global::OpenRouter.AnthropicCodeExecutionToolResult>? codeExecutionToolResult = null,

            global::System.Action<global::OpenRouter.AnthropicBashCodeExecutionToolResult>? bashCodeExecutionToolResult = null,

            global::System.Action<global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult>? textEditorCodeExecutionToolResult = null,

            global::System.Action<global::OpenRouter.AnthropicToolSearchToolResult>? toolSearchToolResult = null,

            global::System.Action<global::OpenRouter.AnthropicContainerUpload>? containerUpload = null,

            global::System.Action<global::OpenRouter.AnthropicCompactionBlock>? compaction = null,

            global::System.Action<global::OpenRouter.AnthropicAdvisorToolResult>? advisorToolResult = null,

            global::System.Action<global::OpenRouter.ORAnthropicShellToolResult>? openrouterShellToolResult = null,

            global::System.Action<global::OpenRouter.ORAnthropicBashToolResult>? openrouterBashToolResult = null,

            global::System.Action<global::OpenRouter.ORAnthropicToolSearchResult>? openrouterToolSearchResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (ToolUse is { } __value1)
            {
                toolUse?.Invoke(__value1);
            }
            else if (Thinking is { } __value2)
            {
                thinking?.Invoke(__value2);
            }
            else if (RedactedThinking is { } __value3)
            {
                redactedThinking?.Invoke(__value3);
            }
            else if (ServerToolUse is { } __value4)
            {
                serverToolUse?.Invoke(__value4);
            }
            else if (WebSearchToolResult is { } __value5)
            {
                webSearchToolResult?.Invoke(__value5);
            }
            else if (WebFetchToolResult is { } __value6)
            {
                webFetchToolResult?.Invoke(__value6);
            }
            else if (CodeExecutionToolResult is { } __value7)
            {
                codeExecutionToolResult?.Invoke(__value7);
            }
            else if (BashCodeExecutionToolResult is { } __value8)
            {
                bashCodeExecutionToolResult?.Invoke(__value8);
            }
            else if (TextEditorCodeExecutionToolResult is { } __value9)
            {
                textEditorCodeExecutionToolResult?.Invoke(__value9);
            }
            else if (ToolSearchToolResult is { } __value10)
            {
                toolSearchToolResult?.Invoke(__value10);
            }
            else if (ContainerUpload is { } __value11)
            {
                containerUpload?.Invoke(__value11);
            }
            else if (Compaction is { } __value12)
            {
                compaction?.Invoke(__value12);
            }
            else if (AdvisorToolResult is { } __value13)
            {
                advisorToolResult?.Invoke(__value13);
            }
            else if (OpenrouterShellToolResult is { } __value14)
            {
                openrouterShellToolResult?.Invoke(__value14);
            }
            else if (OpenrouterBashToolResult is { } __value15)
            {
                openrouterBashToolResult?.Invoke(__value15);
            }
            else if (OpenrouterToolSearchResult is { } __value16)
            {
                openrouterToolSearchResult?.Invoke(__value16);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AnthropicTextBlock>? text = null,
            global::System.Action<global::OpenRouter.AnthropicToolUseBlock>? toolUse = null,
            global::System.Action<global::OpenRouter.AnthropicThinkingBlock>? thinking = null,
            global::System.Action<global::OpenRouter.AnthropicRedactedThinkingBlock>? redactedThinking = null,
            global::System.Action<global::OpenRouter.ORAnthropicServerToolUseBlock>? serverToolUse = null,
            global::System.Action<global::OpenRouter.AnthropicWebSearchToolResult>? webSearchToolResult = null,
            global::System.Action<global::OpenRouter.AnthropicWebFetchToolResult>? webFetchToolResult = null,
            global::System.Action<global::OpenRouter.AnthropicCodeExecutionToolResult>? codeExecutionToolResult = null,
            global::System.Action<global::OpenRouter.AnthropicBashCodeExecutionToolResult>? bashCodeExecutionToolResult = null,
            global::System.Action<global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult>? textEditorCodeExecutionToolResult = null,
            global::System.Action<global::OpenRouter.AnthropicToolSearchToolResult>? toolSearchToolResult = null,
            global::System.Action<global::OpenRouter.AnthropicContainerUpload>? containerUpload = null,
            global::System.Action<global::OpenRouter.AnthropicCompactionBlock>? compaction = null,
            global::System.Action<global::OpenRouter.AnthropicAdvisorToolResult>? advisorToolResult = null,
            global::System.Action<global::OpenRouter.ORAnthropicShellToolResult>? openrouterShellToolResult = null,
            global::System.Action<global::OpenRouter.ORAnthropicBashToolResult>? openrouterBashToolResult = null,
            global::System.Action<global::OpenRouter.ORAnthropicToolSearchResult>? openrouterToolSearchResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (ToolUse is { } __value1)
            {
                toolUse?.Invoke(__value1);
            }
            else if (Thinking is { } __value2)
            {
                thinking?.Invoke(__value2);
            }
            else if (RedactedThinking is { } __value3)
            {
                redactedThinking?.Invoke(__value3);
            }
            else if (ServerToolUse is { } __value4)
            {
                serverToolUse?.Invoke(__value4);
            }
            else if (WebSearchToolResult is { } __value5)
            {
                webSearchToolResult?.Invoke(__value5);
            }
            else if (WebFetchToolResult is { } __value6)
            {
                webFetchToolResult?.Invoke(__value6);
            }
            else if (CodeExecutionToolResult is { } __value7)
            {
                codeExecutionToolResult?.Invoke(__value7);
            }
            else if (BashCodeExecutionToolResult is { } __value8)
            {
                bashCodeExecutionToolResult?.Invoke(__value8);
            }
            else if (TextEditorCodeExecutionToolResult is { } __value9)
            {
                textEditorCodeExecutionToolResult?.Invoke(__value9);
            }
            else if (ToolSearchToolResult is { } __value10)
            {
                toolSearchToolResult?.Invoke(__value10);
            }
            else if (ContainerUpload is { } __value11)
            {
                containerUpload?.Invoke(__value11);
            }
            else if (Compaction is { } __value12)
            {
                compaction?.Invoke(__value12);
            }
            else if (AdvisorToolResult is { } __value13)
            {
                advisorToolResult?.Invoke(__value13);
            }
            else if (OpenrouterShellToolResult is { } __value14)
            {
                openrouterShellToolResult?.Invoke(__value14);
            }
            else if (OpenrouterBashToolResult is { } __value15)
            {
                openrouterBashToolResult?.Invoke(__value15);
            }
            else if (OpenrouterToolSearchResult is { } __value16)
            {
                openrouterToolSearchResult?.Invoke(__value16);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::OpenRouter.AnthropicTextBlock),
                ToolUse,
                typeof(global::OpenRouter.AnthropicToolUseBlock),
                Thinking,
                typeof(global::OpenRouter.AnthropicThinkingBlock),
                RedactedThinking,
                typeof(global::OpenRouter.AnthropicRedactedThinkingBlock),
                ServerToolUse,
                typeof(global::OpenRouter.ORAnthropicServerToolUseBlock),
                WebSearchToolResult,
                typeof(global::OpenRouter.AnthropicWebSearchToolResult),
                WebFetchToolResult,
                typeof(global::OpenRouter.AnthropicWebFetchToolResult),
                CodeExecutionToolResult,
                typeof(global::OpenRouter.AnthropicCodeExecutionToolResult),
                BashCodeExecutionToolResult,
                typeof(global::OpenRouter.AnthropicBashCodeExecutionToolResult),
                TextEditorCodeExecutionToolResult,
                typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult),
                ToolSearchToolResult,
                typeof(global::OpenRouter.AnthropicToolSearchToolResult),
                ContainerUpload,
                typeof(global::OpenRouter.AnthropicContainerUpload),
                Compaction,
                typeof(global::OpenRouter.AnthropicCompactionBlock),
                AdvisorToolResult,
                typeof(global::OpenRouter.AnthropicAdvisorToolResult),
                OpenrouterShellToolResult,
                typeof(global::OpenRouter.ORAnthropicShellToolResult),
                OpenrouterBashToolResult,
                typeof(global::OpenRouter.ORAnthropicBashToolResult),
                OpenrouterToolSearchResult,
                typeof(global::OpenRouter.ORAnthropicToolSearchResult),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicToolUseBlock?>.Default.Equals(ToolUse, other.ToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicThinkingBlock?>.Default.Equals(Thinking, other.Thinking) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicRedactedThinkingBlock?>.Default.Equals(RedactedThinking, other.RedactedThinking) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicServerToolUseBlock?>.Default.Equals(ServerToolUse, other.ServerToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicWebSearchToolResult?>.Default.Equals(WebSearchToolResult, other.WebSearchToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicWebFetchToolResult?>.Default.Equals(WebFetchToolResult, other.WebFetchToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCodeExecutionToolResult?>.Default.Equals(CodeExecutionToolResult, other.CodeExecutionToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicBashCodeExecutionToolResult?>.Default.Equals(BashCodeExecutionToolResult, other.BashCodeExecutionToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextEditorCodeExecutionToolResult?>.Default.Equals(TextEditorCodeExecutionToolResult, other.TextEditorCodeExecutionToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicToolSearchToolResult?>.Default.Equals(ToolSearchToolResult, other.ToolSearchToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicContainerUpload?>.Default.Equals(ContainerUpload, other.ContainerUpload) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCompactionBlock?>.Default.Equals(Compaction, other.Compaction) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicAdvisorToolResult?>.Default.Equals(AdvisorToolResult, other.AdvisorToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicShellToolResult?>.Default.Equals(OpenrouterShellToolResult, other.OpenrouterShellToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicBashToolResult?>.Default.Equals(OpenrouterBashToolResult, other.OpenrouterBashToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ORAnthropicToolSearchResult?>.Default.Equals(OpenrouterToolSearchResult, other.OpenrouterToolSearchResult)
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
