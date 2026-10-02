#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An output item from the response<br/>
    /// Example: {"content":[{"text":"Hello! How can I help you today?","type":"output_text"}],"id":"msg-abc123","role":"assistant","status":"completed","type":"message"}
    /// </summary>
    public readonly partial struct OutputItems : global::System.IEquatable<OutputItems>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemsDiscriminatorType? Type { get; }

        /// <summary>
        /// An output message item<br/>
        /// Example: {"content":[{"annotations":[],"text":"Hello! How can I help you?","type":"output_text"}],"id":"msg-123","role":"assistant","status":"completed","type":"message"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputMessageItem? Message { get; init; }
#else
        public global::OpenRouter.OutputMessageItem? Message { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message))]
#endif
        public bool IsMessage => Message != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputMessageItem? value)
        {
            value = Message;
            return IsMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessageItem PickMessage() => Message is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Message' but the value was {ToString()}.");

        /// <summary>
        /// An output item containing reasoning<br/>
        /// Example: {"content":[{"text":"First, we analyze the problem...","type":"reasoning_text"}],"format":"anthropic-claude-v1","id":"reasoning-123","signature":"EvcBCkgIChABGAIqQKkSDbRuVEQUk9qN1odC098l9SEj...","status":"completed","summary":[{"text":"Analyzed the problem and found the optimal solution.","type":"summary_text"}],"type":"reasoning"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputReasoningItem? Reasoning { get; init; }
#else
        public global::OpenRouter.OutputReasoningItem? Reasoning { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Reasoning))]
#endif
        public bool IsReasoning => Reasoning != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickReasoning(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputReasoningItem? value)
        {
            value = Reasoning;
            return IsReasoning;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputReasoningItem PickReasoning() => Reasoning is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Reasoning' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"arguments":"{\u0022location\u0022:\u0022San Francisco\u0022}","call_id":"call-abc123","id":"fc-abc123","name":"get_weather","status":"completed","type":"function_call"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputFunctionCallItem? FunctionCall { get; init; }
#else
        public global::OpenRouter.OutputFunctionCallItem? FunctionCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCall))]
#endif
        public bool IsFunctionCall => FunctionCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunctionCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputFunctionCallItem? value)
        {
            value = FunctionCall;
            return IsFunctionCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFunctionCallItem PickFunctionCall() => FunctionCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCall' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"id":"ws-abc123","status":"completed","type":"web_search_call"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputWebSearchCallItem? WebSearchCall { get; init; }
#else
        public global::OpenRouter.OutputWebSearchCallItem? WebSearchCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchCall))]
#endif
        public bool IsWebSearchCall => WebSearchCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebSearchCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputWebSearchCallItem? value)
        {
            value = WebSearchCall;
            return IsWebSearchCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchCallItem PickWebSearchCall() => WebSearchCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearchCall' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"id":"fs-abc123","queries":["search term"],"results":[],"status":"completed","type":"file_search_call"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputFileSearchCallItem? FileSearchCall { get; init; }
#else
        public global::OpenRouter.OutputFileSearchCallItem? FileSearchCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchCall))]
#endif
        public bool IsFileSearchCall => FileSearchCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFileSearchCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputFileSearchCallItem? value)
        {
            value = FileSearchCall;
            return IsFileSearchCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFileSearchCallItem PickFileSearchCall() => FileSearchCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileSearchCall' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"id":"img-abc123","result":null,"status":"completed","type":"image_generation_call"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputImageGenerationCallItem? ImageGenerationCall { get; init; }
#else
        public global::OpenRouter.OutputImageGenerationCallItem? ImageGenerationCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenerationCall))]
#endif
        public bool IsImageGenerationCall => ImageGenerationCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImageGenerationCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputImageGenerationCallItem? value)
        {
            value = ImageGenerationCall;
            return IsImageGenerationCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputImageGenerationCallItem PickImageGenerationCall() => ImageGenerationCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageGenerationCall' but the value was {ToString()}.");

        /// <summary>
        /// A code interpreter execution call with outputs<br/>
        /// Example: {"code":"print(\u0022hello\u0022)","container_id":"ctr-xyz789","id":"ci-abc123","outputs":[{"logs":"hello\n","type":"logs"}],"status":"completed","type":"code_interpreter_call"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputCodeInterpreterCallItem? CodeInterpreterCall { get; init; }
#else
        public global::OpenRouter.OutputCodeInterpreterCallItem? CodeInterpreterCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterCall))]
#endif
        public bool IsCodeInterpreterCall => CodeInterpreterCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCodeInterpreterCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputCodeInterpreterCallItem? value)
        {
            value = CodeInterpreterCall;
            return IsCodeInterpreterCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCodeInterpreterCallItem PickCodeInterpreterCall() => CodeInterpreterCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeInterpreterCall' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"action":{"type":"screenshot"},"call_id":"call-abc123","id":"cu-abc123","pending_safety_checks":[],"status":"completed","type":"computer_call"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputComputerCallItem? ComputerCall { get; init; }
#else
        public global::OpenRouter.OutputComputerCallItem? ComputerCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerCall))]
#endif
        public bool IsComputerCall => ComputerCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputerCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputComputerCallItem? value)
        {
            value = ComputerCall;
            return IsComputerCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputComputerCallItem PickComputerCall() => ComputerCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerCall' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:datetime server tool output item<br/>
        /// Example: {"datetime":"2026-03-12T14:30:00.000Z","id":"dt_tmp_abc123","status":"completed","timezone":"UTC","type":"openrouter:datetime"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputDatetimeItem? OpenrouterDatetime { get; init; }
#else
        public global::OpenRouter.OutputDatetimeItem? OpenrouterDatetime { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterDatetime))]
#endif
        public bool IsOpenrouterDatetime => OpenrouterDatetime != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenrouterDatetime(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputDatetimeItem? value)
        {
            value = OpenrouterDatetime;
            return IsOpenrouterDatetime;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputDatetimeItem PickOpenrouterDatetime() => OpenrouterDatetime is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterDatetime' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:web_search server tool output item<br/>
        /// Example: {"action":{"query":"latest AI news","type":"search"},"id":"ws_tmp_abc123","status":"completed","type":"openrouter:web_search"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputWebSearchServerToolItem? OpenrouterWebSearch { get; init; }
#else
        public global::OpenRouter.OutputWebSearchServerToolItem? OpenrouterWebSearch { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterWebSearch))]
#endif
        public bool IsOpenrouterWebSearch => OpenrouterWebSearch != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenrouterWebSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputWebSearchServerToolItem? value)
        {
            value = OpenrouterWebSearch;
            return IsOpenrouterWebSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchServerToolItem PickOpenrouterWebSearch() => OpenrouterWebSearch is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterWebSearch' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:code_interpreter server tool output item<br/>
        /// Example: {"code":"print(\u0022hello\u0022)","id":"ci_tmp_abc123","language":"python","status":"completed","stdout":"hello\n","type":"openrouter:code_interpreter"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputCodeInterpreterServerToolItem? OpenrouterCodeInterpreter { get; init; }
#else
        public global::OpenRouter.OutputCodeInterpreterServerToolItem? OpenrouterCodeInterpreter { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterCodeInterpreter))]
#endif
        public bool IsOpenrouterCodeInterpreter => OpenrouterCodeInterpreter != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenrouterCodeInterpreter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputCodeInterpreterServerToolItem? value)
        {
            value = OpenrouterCodeInterpreter;
            return IsOpenrouterCodeInterpreter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCodeInterpreterServerToolItem PickOpenrouterCodeInterpreter() => OpenrouterCodeInterpreter is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterCodeInterpreter' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:file_search server tool output item<br/>
        /// Example: {"id":"fs_tmp_abc123","queries":["search term"],"status":"completed","type":"openrouter:file_search"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputFileSearchServerToolItem? OpenrouterFileSearch { get; init; }
#else
        public global::OpenRouter.OutputFileSearchServerToolItem? OpenrouterFileSearch { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterFileSearch))]
#endif
        public bool IsOpenrouterFileSearch => OpenrouterFileSearch != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenrouterFileSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputFileSearchServerToolItem? value)
        {
            value = OpenrouterFileSearch;
            return IsOpenrouterFileSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFileSearchServerToolItem PickOpenrouterFileSearch() => OpenrouterFileSearch is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterFileSearch' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:image_generation server tool output item<br/>
        /// Example: {"id":"ig_tmp_abc123","imageUrl":"https://example.com/image.png","result":"https://example.com/image.png","status":"completed","type":"openrouter:image_generation"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputImageGenerationServerToolItem? OpenrouterImageGeneration { get; init; }
#else
        public global::OpenRouter.OutputImageGenerationServerToolItem? OpenrouterImageGeneration { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterImageGeneration))]
#endif
        public bool IsOpenrouterImageGeneration => OpenrouterImageGeneration != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenrouterImageGeneration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputImageGenerationServerToolItem? value)
        {
            value = OpenrouterImageGeneration;
            return IsOpenrouterImageGeneration;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputImageGenerationServerToolItem PickOpenrouterImageGeneration() => OpenrouterImageGeneration is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterImageGeneration' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:browser_use server tool output item<br/>
        /// Example: {"action":"screenshot","id":"bu_tmp_abc123","status":"completed","type":"openrouter:browser_use"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputBrowserUseServerToolItem? OpenrouterBrowserUse { get; init; }
#else
        public global::OpenRouter.OutputBrowserUseServerToolItem? OpenrouterBrowserUse { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterBrowserUse))]
#endif
        public bool IsOpenrouterBrowserUse => OpenrouterBrowserUse != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenrouterBrowserUse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputBrowserUseServerToolItem? value)
        {
            value = OpenrouterBrowserUse;
            return IsOpenrouterBrowserUse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputBrowserUseServerToolItem PickOpenrouterBrowserUse() => OpenrouterBrowserUse is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterBrowserUse' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:bash server tool output item<br/>
        /// Example: {"command":"ls -la","exitCode":0,"id":"bash_tmp_abc123","status":"completed","stdout":"total 0\n","type":"openrouter:bash"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputBashServerToolItem? OpenrouterBash { get; init; }
#else
        public global::OpenRouter.OutputBashServerToolItem? OpenrouterBash { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterBash))]
#endif
        public bool IsOpenrouterBash => OpenrouterBash != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenrouterBash(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputBashServerToolItem? value)
        {
            value = OpenrouterBash;
            return IsOpenrouterBash;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputBashServerToolItem PickOpenrouterBash() => OpenrouterBash is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterBash' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:text_editor server tool output item<br/>
        /// Example: {"command":"view","filePath":"/src/main.ts","id":"te_tmp_abc123","status":"completed","type":"openrouter:text_editor"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputTextEditorServerToolItem? OpenrouterTextEditor { get; init; }
#else
        public global::OpenRouter.OutputTextEditorServerToolItem? OpenrouterTextEditor { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterTextEditor))]
#endif
        public bool IsOpenrouterTextEditor => OpenrouterTextEditor != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenrouterTextEditor(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputTextEditorServerToolItem? value)
        {
            value = OpenrouterTextEditor;
            return IsOpenrouterTextEditor;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputTextEditorServerToolItem PickOpenrouterTextEditor() => OpenrouterTextEditor is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterTextEditor' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:apply_patch server tool output item. The turn halts when validation succeeds so the client can apply the patch and echo an `apply_patch_call_output` on the next turn.<br/>
        /// Example: {"call_id":"call_abc123","id":"apc_abc123","operation":{"diff":"@@ function main() {\n\u002B  console.log(\u0022hi\u0022);\n }","path":"/src/main.ts","type":"update_file"},"status":"completed","type":"openrouter:apply_patch"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputApplyPatchServerToolItem? OpenrouterApplyPatch { get; init; }
#else
        public global::OpenRouter.OutputApplyPatchServerToolItem? OpenrouterApplyPatch { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterApplyPatch))]
#endif
        public bool IsOpenrouterApplyPatch => OpenrouterApplyPatch != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenrouterApplyPatch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputApplyPatchServerToolItem? value)
        {
            value = OpenrouterApplyPatch;
            return IsOpenrouterApplyPatch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputApplyPatchServerToolItem PickOpenrouterApplyPatch() => OpenrouterApplyPatch is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterApplyPatch' but the value was {ToString()}.");

        /// <summary>
        /// A native `apply_patch_call` output item matching OpenAI's Responses API shape. Emitted when the client requested the `apply_patch` shorthand.<br/>
        /// Example: {"call_id":"call_abc123","id":"apc_abc123","operation":{"diff":"@@ function main() {\n\u002B  console.log(\u0022hi\u0022);\n }","path":"/src/main.ts","type":"update_file"},"status":"completed","type":"apply_patch_call"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputApplyPatchCallItem? ApplyPatchCall { get; init; }
#else
        public global::OpenRouter.OutputApplyPatchCallItem? ApplyPatchCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatchCall))]
#endif
        public bool IsApplyPatchCall => ApplyPatchCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickApplyPatchCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputApplyPatchCallItem? value)
        {
            value = ApplyPatchCall;
            return IsApplyPatchCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputApplyPatchCallItem PickApplyPatchCall() => ApplyPatchCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatchCall' but the value was {ToString()}.");

        /// <summary>
        /// A native `shell_call` output item matching OpenAI's Responses API shape. Emitted for the sandbox-backed `shell` tool.<br/>
        /// Example: {"action":{"commands":["echo hello"],"max_output_length":null,"timeout_ms":null},"call_id":"call_abc123","id":"shc_abc123","status":"completed","type":"shell_call"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputShellCallItem? ShellCall { get; init; }
#else
        public global::OpenRouter.OutputShellCallItem? ShellCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ShellCall))]
#endif
        public bool IsShellCall => ShellCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShellCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputShellCallItem? value)
        {
            value = ShellCall;
            return IsShellCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallItem PickShellCall() => ShellCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ShellCall' but the value was {ToString()}.");

        /// <summary>
        /// A native `shell_call_output` item matching OpenAI's Responses API shape. Carries per-command stdout, stderr, and the exit/timeout outcome. A sandbox failure terminates the item as `incomplete` with `error` set.<br/>
        /// Example: {"call_id":"call_abc123","id":"sho_abc123","output":[{"outcome":{"exit_code":0,"type":"exit"},"stderr":"","stdout":"hello\n"}],"status":"completed","type":"shell_call_output"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputShellCallOutputItem? ShellCallOutput { get; init; }
#else
        public global::OpenRouter.OutputShellCallOutputItem? ShellCallOutput { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ShellCallOutput))]
#endif
        public bool IsShellCallOutput => ShellCallOutput != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShellCallOutput(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputShellCallOutputItem? value)
        {
            value = ShellCallOutput;
            return IsShellCallOutput;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellCallOutputItem PickShellCallOutput() => ShellCallOutput is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ShellCallOutput' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:shell server tool output item<br/>
        /// Example: {"action":{"commands":["echo hello"],"max_output_length":null,"timeout_ms":null},"call_id":"call_abc123","id":"st_tmp_abc123","output":[{"outcome":{"exit_code":0,"type":"exit"},"stderr":"","stdout":"hello\n"}],"status":"completed","type":"openrouter:shell"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputShellServerToolItem? OpenrouterShell { get; init; }
#else
        public global::OpenRouter.OutputShellServerToolItem? OpenrouterShell { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterShell))]
#endif
        public bool IsOpenrouterShell => OpenrouterShell != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenrouterShell(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputShellServerToolItem? value)
        {
            value = OpenrouterShell;
            return IsOpenrouterShell;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputShellServerToolItem PickOpenrouterShell() => OpenrouterShell is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterShell' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:web_fetch server tool output item<br/>
        /// Example: {"httpStatus":200,"id":"wf_tmp_abc123","status":"completed","title":"Example Domain","type":"openrouter:web_fetch","url":"https://example.com"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputWebFetchServerToolItem? OpenrouterWebFetch { get; init; }
#else
        public global::OpenRouter.OutputWebFetchServerToolItem? OpenrouterWebFetch { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterWebFetch))]
#endif
        public bool IsOpenrouterWebFetch => OpenrouterWebFetch != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenrouterWebFetch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputWebFetchServerToolItem? value)
        {
            value = OpenrouterWebFetch;
            return IsOpenrouterWebFetch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebFetchServerToolItem PickOpenrouterWebFetch() => OpenrouterWebFetch is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterWebFetch' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:tool_search server tool output item<br/>
        /// Example: {"id":"ts_tmp_abc123","query":"weather tools","status":"completed","type":"openrouter:tool_search"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputToolSearchServerToolItem? OpenrouterToolSearch { get; init; }
#else
        public global::OpenRouter.OutputToolSearchServerToolItem? OpenrouterToolSearch { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterToolSearch))]
#endif
        public bool IsOpenrouterToolSearch => OpenrouterToolSearch != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenrouterToolSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputToolSearchServerToolItem? value)
        {
            value = OpenrouterToolSearch;
            return IsOpenrouterToolSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputToolSearchServerToolItem PickOpenrouterToolSearch() => OpenrouterToolSearch is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterToolSearch' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:memory server tool output item<br/>
        /// Example: {"action":"read","id":"mem_tmp_abc123","key":"user_preference","status":"completed","type":"openrouter:memory"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputMemoryServerToolItem? OpenrouterMemory { get; init; }
#else
        public global::OpenRouter.OutputMemoryServerToolItem? OpenrouterMemory { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterMemory))]
#endif
        public bool IsOpenrouterMemory => OpenrouterMemory != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenrouterMemory(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputMemoryServerToolItem? value)
        {
            value = OpenrouterMemory;
            return IsOpenrouterMemory;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMemoryServerToolItem PickOpenrouterMemory() => OpenrouterMemory is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterMemory' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:mcp server tool output item<br/>
        /// Example: {"id":"mcp_tmp_abc123","serverLabel":"my-server","status":"completed","toolName":"get_data","type":"openrouter:mcp"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputMcpServerToolItem? OpenrouterMcp { get; init; }
#else
        public global::OpenRouter.OutputMcpServerToolItem? OpenrouterMcp { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterMcp))]
#endif
        public bool IsOpenrouterMcp => OpenrouterMcp != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenrouterMcp(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputMcpServerToolItem? value)
        {
            value = OpenrouterMcp;
            return IsOpenrouterMcp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMcpServerToolItem PickOpenrouterMcp() => OpenrouterMcp is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterMcp' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:experimental__search_models server tool output item<br/>
        /// Example: {"arguments":"{\u0022query\u0022:\u0022Claude Opus\u0022}","id":"sm_tmp_abc123","query":"Claude Opus","status":"completed","type":"openrouter:experimental__search_models"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputSearchModelsServerToolItem? OpenrouterExperimentalSearchModels { get; init; }
#else
        public global::OpenRouter.OutputSearchModelsServerToolItem? OpenrouterExperimentalSearchModels { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterExperimentalSearchModels))]
#endif
        public bool IsOpenrouterExperimentalSearchModels => OpenrouterExperimentalSearchModels != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenrouterExperimentalSearchModels(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputSearchModelsServerToolItem? value)
        {
            value = OpenrouterExperimentalSearchModels;
            return IsOpenrouterExperimentalSearchModels;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputSearchModelsServerToolItem PickOpenrouterExperimentalSearchModels() => OpenrouterExperimentalSearchModels is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterExperimentalSearchModels' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:fusion server tool output item<br/>
        /// Example: {"id":"st_tmp_abc123","status":"completed","type":"openrouter:fusion"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputFusionServerToolItem? OpenrouterFusion { get; init; }
#else
        public global::OpenRouter.OutputFusionServerToolItem? OpenrouterFusion { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterFusion))]
#endif
        public bool IsOpenrouterFusion => OpenrouterFusion != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenrouterFusion(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputFusionServerToolItem? value)
        {
            value = OpenrouterFusion;
            return IsOpenrouterFusion;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFusionServerToolItem PickOpenrouterFusion() => OpenrouterFusion is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterFusion' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:advisor server tool output item<br/>
        /// Example: {"id":"st_tmp_abc123","status":"completed","type":"openrouter:advisor"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputAdvisorServerToolItem? OpenrouterAdvisor { get; init; }
#else
        public global::OpenRouter.OutputAdvisorServerToolItem? OpenrouterAdvisor { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterAdvisor))]
#endif
        public bool IsOpenrouterAdvisor => OpenrouterAdvisor != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenrouterAdvisor(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputAdvisorServerToolItem? value)
        {
            value = OpenrouterAdvisor;
            return IsOpenrouterAdvisor;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputAdvisorServerToolItem PickOpenrouterAdvisor() => OpenrouterAdvisor is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterAdvisor' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:subagent server tool output item<br/>
        /// Example: {"id":"st_tmp_abc123","status":"completed","type":"openrouter:subagent"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputSubagentServerToolItem? OpenrouterSubagent { get; init; }
#else
        public global::OpenRouter.OutputSubagentServerToolItem? OpenrouterSubagent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterSubagent))]
#endif
        public bool IsOpenrouterSubagent => OpenrouterSubagent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenrouterSubagent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputSubagentServerToolItem? value)
        {
            value = OpenrouterSubagent;
            return IsOpenrouterSubagent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputSubagentServerToolItem PickOpenrouterSubagent() => OpenrouterSubagent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterSubagent' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:files server tool output item<br/>
        /// Example: {"filename":"notes.txt","id":"fl_tmp_abc123","operation":"read","result":"{\u0022id\u0022:\u0022file_abc\u0022,\u0022filename\u0022:\u0022notes.txt\u0022,\u0022content\u0022:\u0022hello\u0022}","status":"completed","type":"openrouter:files"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputFilesServerToolItem? OpenrouterFiles { get; init; }
#else
        public global::OpenRouter.OutputFilesServerToolItem? OpenrouterFiles { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterFiles))]
#endif
        public bool IsOpenrouterFiles => OpenrouterFiles != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenrouterFiles(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputFilesServerToolItem? value)
        {
            value = OpenrouterFiles;
            return IsOpenrouterFiles;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFilesServerToolItem PickOpenrouterFiles() => OpenrouterFiles is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenrouterFiles' but the value was {ToString()}.");

        /// <summary>
        /// A call to a custom (freeform-grammar) tool created by the model — distinct from `function_call`. Used for tools like Codex CLI's `apply_patch` whose payload is opaque text rather than JSON arguments.<br/>
        /// Example: {"call_id":"call-abc123","id":"ctc-abc123","input":"*** Begin Patch\n*** End Patch","name":"apply_patch","status":"completed","type":"custom_tool_call"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputCustomToolCallItem? CustomToolCall { get; init; }
#else
        public global::OpenRouter.OutputCustomToolCallItem? CustomToolCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomToolCall))]
#endif
        public bool IsCustomToolCall => CustomToolCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCustomToolCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputCustomToolCallItem? value)
        {
            value = CustomToolCall;
            return IsCustomToolCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCustomToolCallItem PickCustomToolCall() => CustomToolCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomToolCall' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputMessageItem value) => new OutputItems((global::OpenRouter.OutputMessageItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputMessageItem?(OutputItems @this) => @this.Message;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputMessageItem? value)
        {
            Message = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromMessage(global::OpenRouter.OutputMessageItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputReasoningItem value) => new OutputItems((global::OpenRouter.OutputReasoningItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputReasoningItem?(OutputItems @this) => @this.Reasoning;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputReasoningItem? value)
        {
            Reasoning = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromReasoning(global::OpenRouter.OutputReasoningItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputFunctionCallItem value) => new OutputItems((global::OpenRouter.OutputFunctionCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputFunctionCallItem?(OutputItems @this) => @this.FunctionCall;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputFunctionCallItem? value)
        {
            FunctionCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromFunctionCall(global::OpenRouter.OutputFunctionCallItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputWebSearchCallItem value) => new OutputItems((global::OpenRouter.OutputWebSearchCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputWebSearchCallItem?(OutputItems @this) => @this.WebSearchCall;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputWebSearchCallItem? value)
        {
            WebSearchCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromWebSearchCall(global::OpenRouter.OutputWebSearchCallItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputFileSearchCallItem value) => new OutputItems((global::OpenRouter.OutputFileSearchCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputFileSearchCallItem?(OutputItems @this) => @this.FileSearchCall;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputFileSearchCallItem? value)
        {
            FileSearchCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromFileSearchCall(global::OpenRouter.OutputFileSearchCallItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputImageGenerationCallItem value) => new OutputItems((global::OpenRouter.OutputImageGenerationCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputImageGenerationCallItem?(OutputItems @this) => @this.ImageGenerationCall;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputImageGenerationCallItem? value)
        {
            ImageGenerationCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromImageGenerationCall(global::OpenRouter.OutputImageGenerationCallItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputCodeInterpreterCallItem value) => new OutputItems((global::OpenRouter.OutputCodeInterpreterCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputCodeInterpreterCallItem?(OutputItems @this) => @this.CodeInterpreterCall;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputCodeInterpreterCallItem? value)
        {
            CodeInterpreterCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromCodeInterpreterCall(global::OpenRouter.OutputCodeInterpreterCallItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputComputerCallItem value) => new OutputItems((global::OpenRouter.OutputComputerCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputComputerCallItem?(OutputItems @this) => @this.ComputerCall;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputComputerCallItem? value)
        {
            ComputerCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromComputerCall(global::OpenRouter.OutputComputerCallItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputDatetimeItem value) => new OutputItems((global::OpenRouter.OutputDatetimeItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputDatetimeItem?(OutputItems @this) => @this.OpenrouterDatetime;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputDatetimeItem? value)
        {
            OpenrouterDatetime = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromOpenrouterDatetime(global::OpenRouter.OutputDatetimeItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputWebSearchServerToolItem value) => new OutputItems((global::OpenRouter.OutputWebSearchServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputWebSearchServerToolItem?(OutputItems @this) => @this.OpenrouterWebSearch;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputWebSearchServerToolItem? value)
        {
            OpenrouterWebSearch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromOpenrouterWebSearch(global::OpenRouter.OutputWebSearchServerToolItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputCodeInterpreterServerToolItem value) => new OutputItems((global::OpenRouter.OutputCodeInterpreterServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputCodeInterpreterServerToolItem?(OutputItems @this) => @this.OpenrouterCodeInterpreter;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputCodeInterpreterServerToolItem? value)
        {
            OpenrouterCodeInterpreter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromOpenrouterCodeInterpreter(global::OpenRouter.OutputCodeInterpreterServerToolItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputFileSearchServerToolItem value) => new OutputItems((global::OpenRouter.OutputFileSearchServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputFileSearchServerToolItem?(OutputItems @this) => @this.OpenrouterFileSearch;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputFileSearchServerToolItem? value)
        {
            OpenrouterFileSearch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromOpenrouterFileSearch(global::OpenRouter.OutputFileSearchServerToolItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputImageGenerationServerToolItem value) => new OutputItems((global::OpenRouter.OutputImageGenerationServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputImageGenerationServerToolItem?(OutputItems @this) => @this.OpenrouterImageGeneration;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputImageGenerationServerToolItem? value)
        {
            OpenrouterImageGeneration = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromOpenrouterImageGeneration(global::OpenRouter.OutputImageGenerationServerToolItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputBrowserUseServerToolItem value) => new OutputItems((global::OpenRouter.OutputBrowserUseServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputBrowserUseServerToolItem?(OutputItems @this) => @this.OpenrouterBrowserUse;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputBrowserUseServerToolItem? value)
        {
            OpenrouterBrowserUse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromOpenrouterBrowserUse(global::OpenRouter.OutputBrowserUseServerToolItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputBashServerToolItem value) => new OutputItems((global::OpenRouter.OutputBashServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputBashServerToolItem?(OutputItems @this) => @this.OpenrouterBash;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputBashServerToolItem? value)
        {
            OpenrouterBash = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromOpenrouterBash(global::OpenRouter.OutputBashServerToolItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputTextEditorServerToolItem value) => new OutputItems((global::OpenRouter.OutputTextEditorServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputTextEditorServerToolItem?(OutputItems @this) => @this.OpenrouterTextEditor;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputTextEditorServerToolItem? value)
        {
            OpenrouterTextEditor = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromOpenrouterTextEditor(global::OpenRouter.OutputTextEditorServerToolItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputApplyPatchServerToolItem value) => new OutputItems((global::OpenRouter.OutputApplyPatchServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputApplyPatchServerToolItem?(OutputItems @this) => @this.OpenrouterApplyPatch;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputApplyPatchServerToolItem? value)
        {
            OpenrouterApplyPatch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromOpenrouterApplyPatch(global::OpenRouter.OutputApplyPatchServerToolItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputApplyPatchCallItem value) => new OutputItems((global::OpenRouter.OutputApplyPatchCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputApplyPatchCallItem?(OutputItems @this) => @this.ApplyPatchCall;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputApplyPatchCallItem? value)
        {
            ApplyPatchCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromApplyPatchCall(global::OpenRouter.OutputApplyPatchCallItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputShellCallItem value) => new OutputItems((global::OpenRouter.OutputShellCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputShellCallItem?(OutputItems @this) => @this.ShellCall;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputShellCallItem? value)
        {
            ShellCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromShellCall(global::OpenRouter.OutputShellCallItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputShellCallOutputItem value) => new OutputItems((global::OpenRouter.OutputShellCallOutputItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputShellCallOutputItem?(OutputItems @this) => @this.ShellCallOutput;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputShellCallOutputItem? value)
        {
            ShellCallOutput = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromShellCallOutput(global::OpenRouter.OutputShellCallOutputItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputShellServerToolItem value) => new OutputItems((global::OpenRouter.OutputShellServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputShellServerToolItem?(OutputItems @this) => @this.OpenrouterShell;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputShellServerToolItem? value)
        {
            OpenrouterShell = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromOpenrouterShell(global::OpenRouter.OutputShellServerToolItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputWebFetchServerToolItem value) => new OutputItems((global::OpenRouter.OutputWebFetchServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputWebFetchServerToolItem?(OutputItems @this) => @this.OpenrouterWebFetch;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputWebFetchServerToolItem? value)
        {
            OpenrouterWebFetch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromOpenrouterWebFetch(global::OpenRouter.OutputWebFetchServerToolItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputToolSearchServerToolItem value) => new OutputItems((global::OpenRouter.OutputToolSearchServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputToolSearchServerToolItem?(OutputItems @this) => @this.OpenrouterToolSearch;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputToolSearchServerToolItem? value)
        {
            OpenrouterToolSearch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromOpenrouterToolSearch(global::OpenRouter.OutputToolSearchServerToolItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputMemoryServerToolItem value) => new OutputItems((global::OpenRouter.OutputMemoryServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputMemoryServerToolItem?(OutputItems @this) => @this.OpenrouterMemory;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputMemoryServerToolItem? value)
        {
            OpenrouterMemory = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromOpenrouterMemory(global::OpenRouter.OutputMemoryServerToolItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputMcpServerToolItem value) => new OutputItems((global::OpenRouter.OutputMcpServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputMcpServerToolItem?(OutputItems @this) => @this.OpenrouterMcp;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputMcpServerToolItem? value)
        {
            OpenrouterMcp = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromOpenrouterMcp(global::OpenRouter.OutputMcpServerToolItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputSearchModelsServerToolItem value) => new OutputItems((global::OpenRouter.OutputSearchModelsServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputSearchModelsServerToolItem?(OutputItems @this) => @this.OpenrouterExperimentalSearchModels;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputSearchModelsServerToolItem? value)
        {
            OpenrouterExperimentalSearchModels = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromOpenrouterExperimentalSearchModels(global::OpenRouter.OutputSearchModelsServerToolItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputFusionServerToolItem value) => new OutputItems((global::OpenRouter.OutputFusionServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputFusionServerToolItem?(OutputItems @this) => @this.OpenrouterFusion;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputFusionServerToolItem? value)
        {
            OpenrouterFusion = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromOpenrouterFusion(global::OpenRouter.OutputFusionServerToolItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputAdvisorServerToolItem value) => new OutputItems((global::OpenRouter.OutputAdvisorServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputAdvisorServerToolItem?(OutputItems @this) => @this.OpenrouterAdvisor;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputAdvisorServerToolItem? value)
        {
            OpenrouterAdvisor = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromOpenrouterAdvisor(global::OpenRouter.OutputAdvisorServerToolItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputSubagentServerToolItem value) => new OutputItems((global::OpenRouter.OutputSubagentServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputSubagentServerToolItem?(OutputItems @this) => @this.OpenrouterSubagent;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputSubagentServerToolItem? value)
        {
            OpenrouterSubagent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromOpenrouterSubagent(global::OpenRouter.OutputSubagentServerToolItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputFilesServerToolItem value) => new OutputItems((global::OpenRouter.OutputFilesServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputFilesServerToolItem?(OutputItems @this) => @this.OpenrouterFiles;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputFilesServerToolItem? value)
        {
            OpenrouterFiles = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromOpenrouterFiles(global::OpenRouter.OutputFilesServerToolItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputCustomToolCallItem value) => new OutputItems((global::OpenRouter.OutputCustomToolCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputCustomToolCallItem?(OutputItems @this) => @this.CustomToolCall;

        /// <summary>
        ///
        /// </summary>
        public OutputItems(global::OpenRouter.OutputCustomToolCallItem? value)
        {
            CustomToolCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputItems FromCustomToolCall(global::OpenRouter.OutputCustomToolCallItem? value) => new OutputItems(value);

        /// <summary>
        ///
        /// </summary>
        public OutputItems(
            global::OpenRouter.OutputItemsDiscriminatorType? type,
            global::OpenRouter.OutputMessageItem? message,
            global::OpenRouter.OutputReasoningItem? reasoning,
            global::OpenRouter.OutputFunctionCallItem? functionCall,
            global::OpenRouter.OutputWebSearchCallItem? webSearchCall,
            global::OpenRouter.OutputFileSearchCallItem? fileSearchCall,
            global::OpenRouter.OutputImageGenerationCallItem? imageGenerationCall,
            global::OpenRouter.OutputCodeInterpreterCallItem? codeInterpreterCall,
            global::OpenRouter.OutputComputerCallItem? computerCall,
            global::OpenRouter.OutputDatetimeItem? openrouterDatetime,
            global::OpenRouter.OutputWebSearchServerToolItem? openrouterWebSearch,
            global::OpenRouter.OutputCodeInterpreterServerToolItem? openrouterCodeInterpreter,
            global::OpenRouter.OutputFileSearchServerToolItem? openrouterFileSearch,
            global::OpenRouter.OutputImageGenerationServerToolItem? openrouterImageGeneration,
            global::OpenRouter.OutputBrowserUseServerToolItem? openrouterBrowserUse,
            global::OpenRouter.OutputBashServerToolItem? openrouterBash,
            global::OpenRouter.OutputTextEditorServerToolItem? openrouterTextEditor,
            global::OpenRouter.OutputApplyPatchServerToolItem? openrouterApplyPatch,
            global::OpenRouter.OutputApplyPatchCallItem? applyPatchCall,
            global::OpenRouter.OutputShellCallItem? shellCall,
            global::OpenRouter.OutputShellCallOutputItem? shellCallOutput,
            global::OpenRouter.OutputShellServerToolItem? openrouterShell,
            global::OpenRouter.OutputWebFetchServerToolItem? openrouterWebFetch,
            global::OpenRouter.OutputToolSearchServerToolItem? openrouterToolSearch,
            global::OpenRouter.OutputMemoryServerToolItem? openrouterMemory,
            global::OpenRouter.OutputMcpServerToolItem? openrouterMcp,
            global::OpenRouter.OutputSearchModelsServerToolItem? openrouterExperimentalSearchModels,
            global::OpenRouter.OutputFusionServerToolItem? openrouterFusion,
            global::OpenRouter.OutputAdvisorServerToolItem? openrouterAdvisor,
            global::OpenRouter.OutputSubagentServerToolItem? openrouterSubagent,
            global::OpenRouter.OutputFilesServerToolItem? openrouterFiles,
            global::OpenRouter.OutputCustomToolCallItem? customToolCall
            )
        {
            Type = type;

            Message = message;
            Reasoning = reasoning;
            FunctionCall = functionCall;
            WebSearchCall = webSearchCall;
            FileSearchCall = fileSearchCall;
            ImageGenerationCall = imageGenerationCall;
            CodeInterpreterCall = codeInterpreterCall;
            ComputerCall = computerCall;
            OpenrouterDatetime = openrouterDatetime;
            OpenrouterWebSearch = openrouterWebSearch;
            OpenrouterCodeInterpreter = openrouterCodeInterpreter;
            OpenrouterFileSearch = openrouterFileSearch;
            OpenrouterImageGeneration = openrouterImageGeneration;
            OpenrouterBrowserUse = openrouterBrowserUse;
            OpenrouterBash = openrouterBash;
            OpenrouterTextEditor = openrouterTextEditor;
            OpenrouterApplyPatch = openrouterApplyPatch;
            ApplyPatchCall = applyPatchCall;
            ShellCall = shellCall;
            ShellCallOutput = shellCallOutput;
            OpenrouterShell = openrouterShell;
            OpenrouterWebFetch = openrouterWebFetch;
            OpenrouterToolSearch = openrouterToolSearch;
            OpenrouterMemory = openrouterMemory;
            OpenrouterMcp = openrouterMcp;
            OpenrouterExperimentalSearchModels = openrouterExperimentalSearchModels;
            OpenrouterFusion = openrouterFusion;
            OpenrouterAdvisor = openrouterAdvisor;
            OpenrouterSubagent = openrouterSubagent;
            OpenrouterFiles = openrouterFiles;
            CustomToolCall = customToolCall;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CustomToolCall as object ??
            OpenrouterFiles as object ??
            OpenrouterSubagent as object ??
            OpenrouterAdvisor as object ??
            OpenrouterFusion as object ??
            OpenrouterExperimentalSearchModels as object ??
            OpenrouterMcp as object ??
            OpenrouterMemory as object ??
            OpenrouterToolSearch as object ??
            OpenrouterWebFetch as object ??
            OpenrouterShell as object ??
            ShellCallOutput as object ??
            ShellCall as object ??
            ApplyPatchCall as object ??
            OpenrouterApplyPatch as object ??
            OpenrouterTextEditor as object ??
            OpenrouterBash as object ??
            OpenrouterBrowserUse as object ??
            OpenrouterImageGeneration as object ??
            OpenrouterFileSearch as object ??
            OpenrouterCodeInterpreter as object ??
            OpenrouterWebSearch as object ??
            OpenrouterDatetime as object ??
            ComputerCall as object ??
            CodeInterpreterCall as object ??
            ImageGenerationCall as object ??
            FileSearchCall as object ??
            WebSearchCall as object ??
            FunctionCall as object ??
            Reasoning as object ??
            Message as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Message?.ToString() ??
            Reasoning?.ToString() ??
            FunctionCall?.ToString() ??
            WebSearchCall?.ToString() ??
            FileSearchCall?.ToString() ??
            ImageGenerationCall?.ToString() ??
            CodeInterpreterCall?.ToString() ??
            ComputerCall?.ToString() ??
            OpenrouterDatetime?.ToString() ??
            OpenrouterWebSearch?.ToString() ??
            OpenrouterCodeInterpreter?.ToString() ??
            OpenrouterFileSearch?.ToString() ??
            OpenrouterImageGeneration?.ToString() ??
            OpenrouterBrowserUse?.ToString() ??
            OpenrouterBash?.ToString() ??
            OpenrouterTextEditor?.ToString() ??
            OpenrouterApplyPatch?.ToString() ??
            ApplyPatchCall?.ToString() ??
            ShellCall?.ToString() ??
            ShellCallOutput?.ToString() ??
            OpenrouterShell?.ToString() ??
            OpenrouterWebFetch?.ToString() ??
            OpenrouterToolSearch?.ToString() ??
            OpenrouterMemory?.ToString() ??
            OpenrouterMcp?.ToString() ??
            OpenrouterExperimentalSearchModels?.ToString() ??
            OpenrouterFusion?.ToString() ??
            OpenrouterAdvisor?.ToString() ??
            OpenrouterSubagent?.ToString() ??
            OpenrouterFiles?.ToString() ??
            CustomToolCall?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsMessage && !IsReasoning && !IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && IsReasoning && !IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && !IsFunctionCall && IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsWebSearchCall && IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && IsOpenrouterSubagent && !IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && IsOpenrouterFiles && !IsCustomToolCall || !IsMessage && !IsReasoning && !IsFunctionCall && !IsWebSearchCall && !IsFileSearchCall && !IsImageGenerationCall && !IsCodeInterpreterCall && !IsComputerCall && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsOpenrouterCodeInterpreter && !IsOpenrouterFileSearch && !IsOpenrouterImageGeneration && !IsOpenrouterBrowserUse && !IsOpenrouterBash && !IsOpenrouterTextEditor && !IsOpenrouterApplyPatch && !IsApplyPatchCall && !IsShellCall && !IsShellCallOutput && !IsOpenrouterShell && !IsOpenrouterWebFetch && !IsOpenrouterToolSearch && !IsOpenrouterMemory && !IsOpenrouterMcp && !IsOpenrouterExperimentalSearchModels && !IsOpenrouterFusion && !IsOpenrouterAdvisor && !IsOpenrouterSubagent && !IsOpenrouterFiles && IsCustomToolCall;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OutputMessageItem?, TResult>? message = null,
            global::System.Func<global::OpenRouter.OutputReasoningItem?, TResult>? reasoning = null,
            global::System.Func<global::OpenRouter.OutputFunctionCallItem?, TResult>? functionCall = null,
            global::System.Func<global::OpenRouter.OutputWebSearchCallItem?, TResult>? webSearchCall = null,
            global::System.Func<global::OpenRouter.OutputFileSearchCallItem?, TResult>? fileSearchCall = null,
            global::System.Func<global::OpenRouter.OutputImageGenerationCallItem?, TResult>? imageGenerationCall = null,
            global::System.Func<global::OpenRouter.OutputCodeInterpreterCallItem?, TResult>? codeInterpreterCall = null,
            global::System.Func<global::OpenRouter.OutputComputerCallItem, TResult>? computerCall = null,
            global::System.Func<global::OpenRouter.OutputDatetimeItem, TResult>? openrouterDatetime = null,
            global::System.Func<global::OpenRouter.OutputWebSearchServerToolItem, TResult>? openrouterWebSearch = null,
            global::System.Func<global::OpenRouter.OutputCodeInterpreterServerToolItem, TResult>? openrouterCodeInterpreter = null,
            global::System.Func<global::OpenRouter.OutputFileSearchServerToolItem, TResult>? openrouterFileSearch = null,
            global::System.Func<global::OpenRouter.OutputImageGenerationServerToolItem, TResult>? openrouterImageGeneration = null,
            global::System.Func<global::OpenRouter.OutputBrowserUseServerToolItem, TResult>? openrouterBrowserUse = null,
            global::System.Func<global::OpenRouter.OutputBashServerToolItem, TResult>? openrouterBash = null,
            global::System.Func<global::OpenRouter.OutputTextEditorServerToolItem, TResult>? openrouterTextEditor = null,
            global::System.Func<global::OpenRouter.OutputApplyPatchServerToolItem, TResult>? openrouterApplyPatch = null,
            global::System.Func<global::OpenRouter.OutputApplyPatchCallItem, TResult>? applyPatchCall = null,
            global::System.Func<global::OpenRouter.OutputShellCallItem, TResult>? shellCall = null,
            global::System.Func<global::OpenRouter.OutputShellCallOutputItem, TResult>? shellCallOutput = null,
            global::System.Func<global::OpenRouter.OutputShellServerToolItem, TResult>? openrouterShell = null,
            global::System.Func<global::OpenRouter.OutputWebFetchServerToolItem, TResult>? openrouterWebFetch = null,
            global::System.Func<global::OpenRouter.OutputToolSearchServerToolItem, TResult>? openrouterToolSearch = null,
            global::System.Func<global::OpenRouter.OutputMemoryServerToolItem, TResult>? openrouterMemory = null,
            global::System.Func<global::OpenRouter.OutputMcpServerToolItem, TResult>? openrouterMcp = null,
            global::System.Func<global::OpenRouter.OutputSearchModelsServerToolItem, TResult>? openrouterExperimentalSearchModels = null,
            global::System.Func<global::OpenRouter.OutputFusionServerToolItem, TResult>? openrouterFusion = null,
            global::System.Func<global::OpenRouter.OutputAdvisorServerToolItem, TResult>? openrouterAdvisor = null,
            global::System.Func<global::OpenRouter.OutputSubagentServerToolItem, TResult>? openrouterSubagent = null,
            global::System.Func<global::OpenRouter.OutputFilesServerToolItem, TResult>? openrouterFiles = null,
            global::System.Func<global::OpenRouter.OutputCustomToolCallItem, TResult>? customToolCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Message is { } __value0 && message != null)
            {
                return message(__value0);
            }
            else if (Reasoning is { } __value1 && reasoning != null)
            {
                return reasoning(__value1);
            }
            else if (FunctionCall is { } __value2 && functionCall != null)
            {
                return functionCall(__value2);
            }
            else if (WebSearchCall is { } __value3 && webSearchCall != null)
            {
                return webSearchCall(__value3);
            }
            else if (FileSearchCall is { } __value4 && fileSearchCall != null)
            {
                return fileSearchCall(__value4);
            }
            else if (ImageGenerationCall is { } __value5 && imageGenerationCall != null)
            {
                return imageGenerationCall(__value5);
            }
            else if (CodeInterpreterCall is { } __value6 && codeInterpreterCall != null)
            {
                return codeInterpreterCall(__value6);
            }
            else if (ComputerCall is { } __value7 && computerCall != null)
            {
                return computerCall(__value7);
            }
            else if (OpenrouterDatetime is { } __value8 && openrouterDatetime != null)
            {
                return openrouterDatetime(__value8);
            }
            else if (OpenrouterWebSearch is { } __value9 && openrouterWebSearch != null)
            {
                return openrouterWebSearch(__value9);
            }
            else if (OpenrouterCodeInterpreter is { } __value10 && openrouterCodeInterpreter != null)
            {
                return openrouterCodeInterpreter(__value10);
            }
            else if (OpenrouterFileSearch is { } __value11 && openrouterFileSearch != null)
            {
                return openrouterFileSearch(__value11);
            }
            else if (OpenrouterImageGeneration is { } __value12 && openrouterImageGeneration != null)
            {
                return openrouterImageGeneration(__value12);
            }
            else if (OpenrouterBrowserUse is { } __value13 && openrouterBrowserUse != null)
            {
                return openrouterBrowserUse(__value13);
            }
            else if (OpenrouterBash is { } __value14 && openrouterBash != null)
            {
                return openrouterBash(__value14);
            }
            else if (OpenrouterTextEditor is { } __value15 && openrouterTextEditor != null)
            {
                return openrouterTextEditor(__value15);
            }
            else if (OpenrouterApplyPatch is { } __value16 && openrouterApplyPatch != null)
            {
                return openrouterApplyPatch(__value16);
            }
            else if (ApplyPatchCall is { } __value17 && applyPatchCall != null)
            {
                return applyPatchCall(__value17);
            }
            else if (ShellCall is { } __value18 && shellCall != null)
            {
                return shellCall(__value18);
            }
            else if (ShellCallOutput is { } __value19 && shellCallOutput != null)
            {
                return shellCallOutput(__value19);
            }
            else if (OpenrouterShell is { } __value20 && openrouterShell != null)
            {
                return openrouterShell(__value20);
            }
            else if (OpenrouterWebFetch is { } __value21 && openrouterWebFetch != null)
            {
                return openrouterWebFetch(__value21);
            }
            else if (OpenrouterToolSearch is { } __value22 && openrouterToolSearch != null)
            {
                return openrouterToolSearch(__value22);
            }
            else if (OpenrouterMemory is { } __value23 && openrouterMemory != null)
            {
                return openrouterMemory(__value23);
            }
            else if (OpenrouterMcp is { } __value24 && openrouterMcp != null)
            {
                return openrouterMcp(__value24);
            }
            else if (OpenrouterExperimentalSearchModels is { } __value25 && openrouterExperimentalSearchModels != null)
            {
                return openrouterExperimentalSearchModels(__value25);
            }
            else if (OpenrouterFusion is { } __value26 && openrouterFusion != null)
            {
                return openrouterFusion(__value26);
            }
            else if (OpenrouterAdvisor is { } __value27 && openrouterAdvisor != null)
            {
                return openrouterAdvisor(__value27);
            }
            else if (OpenrouterSubagent is { } __value28 && openrouterSubagent != null)
            {
                return openrouterSubagent(__value28);
            }
            else if (OpenrouterFiles is { } __value29 && openrouterFiles != null)
            {
                return openrouterFiles(__value29);
            }
            else if (CustomToolCall is { } __value30 && customToolCall != null)
            {
                return customToolCall(__value30);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OutputMessageItem?>? message = null,

            global::System.Action<global::OpenRouter.OutputReasoningItem?>? reasoning = null,

            global::System.Action<global::OpenRouter.OutputFunctionCallItem?>? functionCall = null,

            global::System.Action<global::OpenRouter.OutputWebSearchCallItem?>? webSearchCall = null,

            global::System.Action<global::OpenRouter.OutputFileSearchCallItem?>? fileSearchCall = null,

            global::System.Action<global::OpenRouter.OutputImageGenerationCallItem?>? imageGenerationCall = null,

            global::System.Action<global::OpenRouter.OutputCodeInterpreterCallItem?>? codeInterpreterCall = null,

            global::System.Action<global::OpenRouter.OutputComputerCallItem>? computerCall = null,

            global::System.Action<global::OpenRouter.OutputDatetimeItem>? openrouterDatetime = null,

            global::System.Action<global::OpenRouter.OutputWebSearchServerToolItem>? openrouterWebSearch = null,

            global::System.Action<global::OpenRouter.OutputCodeInterpreterServerToolItem>? openrouterCodeInterpreter = null,

            global::System.Action<global::OpenRouter.OutputFileSearchServerToolItem>? openrouterFileSearch = null,

            global::System.Action<global::OpenRouter.OutputImageGenerationServerToolItem>? openrouterImageGeneration = null,

            global::System.Action<global::OpenRouter.OutputBrowserUseServerToolItem>? openrouterBrowserUse = null,

            global::System.Action<global::OpenRouter.OutputBashServerToolItem>? openrouterBash = null,

            global::System.Action<global::OpenRouter.OutputTextEditorServerToolItem>? openrouterTextEditor = null,

            global::System.Action<global::OpenRouter.OutputApplyPatchServerToolItem>? openrouterApplyPatch = null,

            global::System.Action<global::OpenRouter.OutputApplyPatchCallItem>? applyPatchCall = null,

            global::System.Action<global::OpenRouter.OutputShellCallItem>? shellCall = null,

            global::System.Action<global::OpenRouter.OutputShellCallOutputItem>? shellCallOutput = null,

            global::System.Action<global::OpenRouter.OutputShellServerToolItem>? openrouterShell = null,

            global::System.Action<global::OpenRouter.OutputWebFetchServerToolItem>? openrouterWebFetch = null,

            global::System.Action<global::OpenRouter.OutputToolSearchServerToolItem>? openrouterToolSearch = null,

            global::System.Action<global::OpenRouter.OutputMemoryServerToolItem>? openrouterMemory = null,

            global::System.Action<global::OpenRouter.OutputMcpServerToolItem>? openrouterMcp = null,

            global::System.Action<global::OpenRouter.OutputSearchModelsServerToolItem>? openrouterExperimentalSearchModels = null,

            global::System.Action<global::OpenRouter.OutputFusionServerToolItem>? openrouterFusion = null,

            global::System.Action<global::OpenRouter.OutputAdvisorServerToolItem>? openrouterAdvisor = null,

            global::System.Action<global::OpenRouter.OutputSubagentServerToolItem>? openrouterSubagent = null,

            global::System.Action<global::OpenRouter.OutputFilesServerToolItem>? openrouterFiles = null,

            global::System.Action<global::OpenRouter.OutputCustomToolCallItem>? customToolCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Message is { } __value0)
            {
                message?.Invoke(__value0);
            }
            else if (Reasoning is { } __value1)
            {
                reasoning?.Invoke(__value1);
            }
            else if (FunctionCall is { } __value2)
            {
                functionCall?.Invoke(__value2);
            }
            else if (WebSearchCall is { } __value3)
            {
                webSearchCall?.Invoke(__value3);
            }
            else if (FileSearchCall is { } __value4)
            {
                fileSearchCall?.Invoke(__value4);
            }
            else if (ImageGenerationCall is { } __value5)
            {
                imageGenerationCall?.Invoke(__value5);
            }
            else if (CodeInterpreterCall is { } __value6)
            {
                codeInterpreterCall?.Invoke(__value6);
            }
            else if (ComputerCall is { } __value7)
            {
                computerCall?.Invoke(__value7);
            }
            else if (OpenrouterDatetime is { } __value8)
            {
                openrouterDatetime?.Invoke(__value8);
            }
            else if (OpenrouterWebSearch is { } __value9)
            {
                openrouterWebSearch?.Invoke(__value9);
            }
            else if (OpenrouterCodeInterpreter is { } __value10)
            {
                openrouterCodeInterpreter?.Invoke(__value10);
            }
            else if (OpenrouterFileSearch is { } __value11)
            {
                openrouterFileSearch?.Invoke(__value11);
            }
            else if (OpenrouterImageGeneration is { } __value12)
            {
                openrouterImageGeneration?.Invoke(__value12);
            }
            else if (OpenrouterBrowserUse is { } __value13)
            {
                openrouterBrowserUse?.Invoke(__value13);
            }
            else if (OpenrouterBash is { } __value14)
            {
                openrouterBash?.Invoke(__value14);
            }
            else if (OpenrouterTextEditor is { } __value15)
            {
                openrouterTextEditor?.Invoke(__value15);
            }
            else if (OpenrouterApplyPatch is { } __value16)
            {
                openrouterApplyPatch?.Invoke(__value16);
            }
            else if (ApplyPatchCall is { } __value17)
            {
                applyPatchCall?.Invoke(__value17);
            }
            else if (ShellCall is { } __value18)
            {
                shellCall?.Invoke(__value18);
            }
            else if (ShellCallOutput is { } __value19)
            {
                shellCallOutput?.Invoke(__value19);
            }
            else if (OpenrouterShell is { } __value20)
            {
                openrouterShell?.Invoke(__value20);
            }
            else if (OpenrouterWebFetch is { } __value21)
            {
                openrouterWebFetch?.Invoke(__value21);
            }
            else if (OpenrouterToolSearch is { } __value22)
            {
                openrouterToolSearch?.Invoke(__value22);
            }
            else if (OpenrouterMemory is { } __value23)
            {
                openrouterMemory?.Invoke(__value23);
            }
            else if (OpenrouterMcp is { } __value24)
            {
                openrouterMcp?.Invoke(__value24);
            }
            else if (OpenrouterExperimentalSearchModels is { } __value25)
            {
                openrouterExperimentalSearchModels?.Invoke(__value25);
            }
            else if (OpenrouterFusion is { } __value26)
            {
                openrouterFusion?.Invoke(__value26);
            }
            else if (OpenrouterAdvisor is { } __value27)
            {
                openrouterAdvisor?.Invoke(__value27);
            }
            else if (OpenrouterSubagent is { } __value28)
            {
                openrouterSubagent?.Invoke(__value28);
            }
            else if (OpenrouterFiles is { } __value29)
            {
                openrouterFiles?.Invoke(__value29);
            }
            else if (CustomToolCall is { } __value30)
            {
                customToolCall?.Invoke(__value30);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OutputMessageItem?>? message = null,
            global::System.Action<global::OpenRouter.OutputReasoningItem?>? reasoning = null,
            global::System.Action<global::OpenRouter.OutputFunctionCallItem?>? functionCall = null,
            global::System.Action<global::OpenRouter.OutputWebSearchCallItem?>? webSearchCall = null,
            global::System.Action<global::OpenRouter.OutputFileSearchCallItem?>? fileSearchCall = null,
            global::System.Action<global::OpenRouter.OutputImageGenerationCallItem?>? imageGenerationCall = null,
            global::System.Action<global::OpenRouter.OutputCodeInterpreterCallItem?>? codeInterpreterCall = null,
            global::System.Action<global::OpenRouter.OutputComputerCallItem>? computerCall = null,
            global::System.Action<global::OpenRouter.OutputDatetimeItem>? openrouterDatetime = null,
            global::System.Action<global::OpenRouter.OutputWebSearchServerToolItem>? openrouterWebSearch = null,
            global::System.Action<global::OpenRouter.OutputCodeInterpreterServerToolItem>? openrouterCodeInterpreter = null,
            global::System.Action<global::OpenRouter.OutputFileSearchServerToolItem>? openrouterFileSearch = null,
            global::System.Action<global::OpenRouter.OutputImageGenerationServerToolItem>? openrouterImageGeneration = null,
            global::System.Action<global::OpenRouter.OutputBrowserUseServerToolItem>? openrouterBrowserUse = null,
            global::System.Action<global::OpenRouter.OutputBashServerToolItem>? openrouterBash = null,
            global::System.Action<global::OpenRouter.OutputTextEditorServerToolItem>? openrouterTextEditor = null,
            global::System.Action<global::OpenRouter.OutputApplyPatchServerToolItem>? openrouterApplyPatch = null,
            global::System.Action<global::OpenRouter.OutputApplyPatchCallItem>? applyPatchCall = null,
            global::System.Action<global::OpenRouter.OutputShellCallItem>? shellCall = null,
            global::System.Action<global::OpenRouter.OutputShellCallOutputItem>? shellCallOutput = null,
            global::System.Action<global::OpenRouter.OutputShellServerToolItem>? openrouterShell = null,
            global::System.Action<global::OpenRouter.OutputWebFetchServerToolItem>? openrouterWebFetch = null,
            global::System.Action<global::OpenRouter.OutputToolSearchServerToolItem>? openrouterToolSearch = null,
            global::System.Action<global::OpenRouter.OutputMemoryServerToolItem>? openrouterMemory = null,
            global::System.Action<global::OpenRouter.OutputMcpServerToolItem>? openrouterMcp = null,
            global::System.Action<global::OpenRouter.OutputSearchModelsServerToolItem>? openrouterExperimentalSearchModels = null,
            global::System.Action<global::OpenRouter.OutputFusionServerToolItem>? openrouterFusion = null,
            global::System.Action<global::OpenRouter.OutputAdvisorServerToolItem>? openrouterAdvisor = null,
            global::System.Action<global::OpenRouter.OutputSubagentServerToolItem>? openrouterSubagent = null,
            global::System.Action<global::OpenRouter.OutputFilesServerToolItem>? openrouterFiles = null,
            global::System.Action<global::OpenRouter.OutputCustomToolCallItem>? customToolCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Message is { } __value0)
            {
                message?.Invoke(__value0);
            }
            else if (Reasoning is { } __value1)
            {
                reasoning?.Invoke(__value1);
            }
            else if (FunctionCall is { } __value2)
            {
                functionCall?.Invoke(__value2);
            }
            else if (WebSearchCall is { } __value3)
            {
                webSearchCall?.Invoke(__value3);
            }
            else if (FileSearchCall is { } __value4)
            {
                fileSearchCall?.Invoke(__value4);
            }
            else if (ImageGenerationCall is { } __value5)
            {
                imageGenerationCall?.Invoke(__value5);
            }
            else if (CodeInterpreterCall is { } __value6)
            {
                codeInterpreterCall?.Invoke(__value6);
            }
            else if (ComputerCall is { } __value7)
            {
                computerCall?.Invoke(__value7);
            }
            else if (OpenrouterDatetime is { } __value8)
            {
                openrouterDatetime?.Invoke(__value8);
            }
            else if (OpenrouterWebSearch is { } __value9)
            {
                openrouterWebSearch?.Invoke(__value9);
            }
            else if (OpenrouterCodeInterpreter is { } __value10)
            {
                openrouterCodeInterpreter?.Invoke(__value10);
            }
            else if (OpenrouterFileSearch is { } __value11)
            {
                openrouterFileSearch?.Invoke(__value11);
            }
            else if (OpenrouterImageGeneration is { } __value12)
            {
                openrouterImageGeneration?.Invoke(__value12);
            }
            else if (OpenrouterBrowserUse is { } __value13)
            {
                openrouterBrowserUse?.Invoke(__value13);
            }
            else if (OpenrouterBash is { } __value14)
            {
                openrouterBash?.Invoke(__value14);
            }
            else if (OpenrouterTextEditor is { } __value15)
            {
                openrouterTextEditor?.Invoke(__value15);
            }
            else if (OpenrouterApplyPatch is { } __value16)
            {
                openrouterApplyPatch?.Invoke(__value16);
            }
            else if (ApplyPatchCall is { } __value17)
            {
                applyPatchCall?.Invoke(__value17);
            }
            else if (ShellCall is { } __value18)
            {
                shellCall?.Invoke(__value18);
            }
            else if (ShellCallOutput is { } __value19)
            {
                shellCallOutput?.Invoke(__value19);
            }
            else if (OpenrouterShell is { } __value20)
            {
                openrouterShell?.Invoke(__value20);
            }
            else if (OpenrouterWebFetch is { } __value21)
            {
                openrouterWebFetch?.Invoke(__value21);
            }
            else if (OpenrouterToolSearch is { } __value22)
            {
                openrouterToolSearch?.Invoke(__value22);
            }
            else if (OpenrouterMemory is { } __value23)
            {
                openrouterMemory?.Invoke(__value23);
            }
            else if (OpenrouterMcp is { } __value24)
            {
                openrouterMcp?.Invoke(__value24);
            }
            else if (OpenrouterExperimentalSearchModels is { } __value25)
            {
                openrouterExperimentalSearchModels?.Invoke(__value25);
            }
            else if (OpenrouterFusion is { } __value26)
            {
                openrouterFusion?.Invoke(__value26);
            }
            else if (OpenrouterAdvisor is { } __value27)
            {
                openrouterAdvisor?.Invoke(__value27);
            }
            else if (OpenrouterSubagent is { } __value28)
            {
                openrouterSubagent?.Invoke(__value28);
            }
            else if (OpenrouterFiles is { } __value29)
            {
                openrouterFiles?.Invoke(__value29);
            }
            else if (CustomToolCall is { } __value30)
            {
                customToolCall?.Invoke(__value30);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Message,
                typeof(global::OpenRouter.OutputMessageItem),
                Reasoning,
                typeof(global::OpenRouter.OutputReasoningItem),
                FunctionCall,
                typeof(global::OpenRouter.OutputFunctionCallItem),
                WebSearchCall,
                typeof(global::OpenRouter.OutputWebSearchCallItem),
                FileSearchCall,
                typeof(global::OpenRouter.OutputFileSearchCallItem),
                ImageGenerationCall,
                typeof(global::OpenRouter.OutputImageGenerationCallItem),
                CodeInterpreterCall,
                typeof(global::OpenRouter.OutputCodeInterpreterCallItem),
                ComputerCall,
                typeof(global::OpenRouter.OutputComputerCallItem),
                OpenrouterDatetime,
                typeof(global::OpenRouter.OutputDatetimeItem),
                OpenrouterWebSearch,
                typeof(global::OpenRouter.OutputWebSearchServerToolItem),
                OpenrouterCodeInterpreter,
                typeof(global::OpenRouter.OutputCodeInterpreterServerToolItem),
                OpenrouterFileSearch,
                typeof(global::OpenRouter.OutputFileSearchServerToolItem),
                OpenrouterImageGeneration,
                typeof(global::OpenRouter.OutputImageGenerationServerToolItem),
                OpenrouterBrowserUse,
                typeof(global::OpenRouter.OutputBrowserUseServerToolItem),
                OpenrouterBash,
                typeof(global::OpenRouter.OutputBashServerToolItem),
                OpenrouterTextEditor,
                typeof(global::OpenRouter.OutputTextEditorServerToolItem),
                OpenrouterApplyPatch,
                typeof(global::OpenRouter.OutputApplyPatchServerToolItem),
                ApplyPatchCall,
                typeof(global::OpenRouter.OutputApplyPatchCallItem),
                ShellCall,
                typeof(global::OpenRouter.OutputShellCallItem),
                ShellCallOutput,
                typeof(global::OpenRouter.OutputShellCallOutputItem),
                OpenrouterShell,
                typeof(global::OpenRouter.OutputShellServerToolItem),
                OpenrouterWebFetch,
                typeof(global::OpenRouter.OutputWebFetchServerToolItem),
                OpenrouterToolSearch,
                typeof(global::OpenRouter.OutputToolSearchServerToolItem),
                OpenrouterMemory,
                typeof(global::OpenRouter.OutputMemoryServerToolItem),
                OpenrouterMcp,
                typeof(global::OpenRouter.OutputMcpServerToolItem),
                OpenrouterExperimentalSearchModels,
                typeof(global::OpenRouter.OutputSearchModelsServerToolItem),
                OpenrouterFusion,
                typeof(global::OpenRouter.OutputFusionServerToolItem),
                OpenrouterAdvisor,
                typeof(global::OpenRouter.OutputAdvisorServerToolItem),
                OpenrouterSubagent,
                typeof(global::OpenRouter.OutputSubagentServerToolItem),
                OpenrouterFiles,
                typeof(global::OpenRouter.OutputFilesServerToolItem),
                CustomToolCall,
                typeof(global::OpenRouter.OutputCustomToolCallItem),
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
        public bool Equals(OutputItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputMessageItem?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputReasoningItem?>.Default.Equals(Reasoning, other.Reasoning) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputFunctionCallItem?>.Default.Equals(FunctionCall, other.FunctionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputWebSearchCallItem?>.Default.Equals(WebSearchCall, other.WebSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputFileSearchCallItem?>.Default.Equals(FileSearchCall, other.FileSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputImageGenerationCallItem?>.Default.Equals(ImageGenerationCall, other.ImageGenerationCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputCodeInterpreterCallItem?>.Default.Equals(CodeInterpreterCall, other.CodeInterpreterCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputComputerCallItem?>.Default.Equals(ComputerCall, other.ComputerCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputDatetimeItem?>.Default.Equals(OpenrouterDatetime, other.OpenrouterDatetime) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputWebSearchServerToolItem?>.Default.Equals(OpenrouterWebSearch, other.OpenrouterWebSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputCodeInterpreterServerToolItem?>.Default.Equals(OpenrouterCodeInterpreter, other.OpenrouterCodeInterpreter) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputFileSearchServerToolItem?>.Default.Equals(OpenrouterFileSearch, other.OpenrouterFileSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputImageGenerationServerToolItem?>.Default.Equals(OpenrouterImageGeneration, other.OpenrouterImageGeneration) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputBrowserUseServerToolItem?>.Default.Equals(OpenrouterBrowserUse, other.OpenrouterBrowserUse) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputBashServerToolItem?>.Default.Equals(OpenrouterBash, other.OpenrouterBash) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputTextEditorServerToolItem?>.Default.Equals(OpenrouterTextEditor, other.OpenrouterTextEditor) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputApplyPatchServerToolItem?>.Default.Equals(OpenrouterApplyPatch, other.OpenrouterApplyPatch) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputApplyPatchCallItem?>.Default.Equals(ApplyPatchCall, other.ApplyPatchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputShellCallItem?>.Default.Equals(ShellCall, other.ShellCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputShellCallOutputItem?>.Default.Equals(ShellCallOutput, other.ShellCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputShellServerToolItem?>.Default.Equals(OpenrouterShell, other.OpenrouterShell) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputWebFetchServerToolItem?>.Default.Equals(OpenrouterWebFetch, other.OpenrouterWebFetch) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputToolSearchServerToolItem?>.Default.Equals(OpenrouterToolSearch, other.OpenrouterToolSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputMemoryServerToolItem?>.Default.Equals(OpenrouterMemory, other.OpenrouterMemory) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputMcpServerToolItem?>.Default.Equals(OpenrouterMcp, other.OpenrouterMcp) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputSearchModelsServerToolItem?>.Default.Equals(OpenrouterExperimentalSearchModels, other.OpenrouterExperimentalSearchModels) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputFusionServerToolItem?>.Default.Equals(OpenrouterFusion, other.OpenrouterFusion) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputAdvisorServerToolItem?>.Default.Equals(OpenrouterAdvisor, other.OpenrouterAdvisor) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputSubagentServerToolItem?>.Default.Equals(OpenrouterSubagent, other.OpenrouterSubagent) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputFilesServerToolItem?>.Default.Equals(OpenrouterFiles, other.OpenrouterFiles) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputCustomToolCallItem?>.Default.Equals(CustomToolCall, other.CustomToolCall)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(OutputItems obj1, OutputItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OutputItems obj1, OutputItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputItems o && Equals(o);
        }
    }
}
