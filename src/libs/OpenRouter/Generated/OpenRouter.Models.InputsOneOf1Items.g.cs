#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct InputsOneOf1Items : global::System.IEquatable<InputsOneOf1Items>
    {
        /// <summary>
        /// Reasoning output item with signature and format extensions
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ReasoningItem? ReasoningItem { get; init; }
#else
        public global::OpenRouter.ReasoningItem? ReasoningItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningItem))]
#endif
        public bool IsReasoningItem => ReasoningItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickReasoningItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ReasoningItem? value)
        {
            value = ReasoningItem;
            return IsReasoningItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ReasoningItem PickReasoningItem() => ReasoningItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReasoningItem' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.EasyInputMessage? EasyInputMessage { get; init; }
#else
        public global::OpenRouter.EasyInputMessage? EasyInputMessage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EasyInputMessage))]
#endif
        public bool IsEasyInputMessage => EasyInputMessage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEasyInputMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.EasyInputMessage? value)
        {
            value = EasyInputMessage;
            return IsEasyInputMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.EasyInputMessage PickEasyInputMessage() => EasyInputMessage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'EasyInputMessage' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.InputMessageItem? InputMessageItem { get; init; }
#else
        public global::OpenRouter.InputMessageItem? InputMessageItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputMessageItem))]
#endif
        public bool IsInputMessageItem => InputMessageItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputMessageItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.InputMessageItem? value)
        {
            value = InputMessageItem;
            return IsInputMessageItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputMessageItem PickInputMessageItem() => InputMessageItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputMessageItem' but the value was {ToString()}.");

        /// <summary>
        /// A function call initiated by the model
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FunctionCallItem? FunctionCallItem { get; init; }
#else
        public global::OpenRouter.FunctionCallItem? FunctionCallItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallItem))]
#endif
        public bool IsFunctionCallItem => FunctionCallItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunctionCallItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.FunctionCallItem? value)
        {
            value = FunctionCallItem;
            return IsFunctionCallItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallItem PickFunctionCallItem() => FunctionCallItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallItem' but the value was {ToString()}.");

        /// <summary>
        /// The output from a function call execution
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FunctionCallOutputItem? FunctionCallOutputItem { get; init; }
#else
        public global::OpenRouter.FunctionCallOutputItem? FunctionCallOutputItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallOutputItem))]
#endif
        public bool IsFunctionCallOutputItem => FunctionCallOutputItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunctionCallOutputItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.FunctionCallOutputItem? value)
        {
            value = FunctionCallOutputItem;
            return IsFunctionCallOutputItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FunctionCallOutputItem PickFunctionCallOutputItem() => FunctionCallOutputItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallOutputItem' but the value was {ToString()}.");

        /// <summary>
        /// A tool call emitted by the model requesting a V4A patch operation. The client applies the patch and echoes an `apply_patch_call_output` on the next turn.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ApplyPatchCallItem? ApplyPatchCallItem { get; init; }
#else
        public global::OpenRouter.ApplyPatchCallItem? ApplyPatchCallItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatchCallItem))]
#endif
        public bool IsApplyPatchCallItem => ApplyPatchCallItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickApplyPatchCallItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ApplyPatchCallItem? value)
        {
            value = ApplyPatchCallItem;
            return IsApplyPatchCallItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallItem PickApplyPatchCallItem() => ApplyPatchCallItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatchCallItem' but the value was {ToString()}.");

        /// <summary>
        /// The client's echo of an `apply_patch_call` after applying the patch. `output` is an optional human-readable log; `status` is `completed` when the patch was applied successfully, `failed` otherwise.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ApplyPatchCallOutputItem? ApplyPatchCallOutputItem { get; init; }
#else
        public global::OpenRouter.ApplyPatchCallOutputItem? ApplyPatchCallOutputItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApplyPatchCallOutputItem))]
#endif
        public bool IsApplyPatchCallOutputItem => ApplyPatchCallOutputItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickApplyPatchCallOutputItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ApplyPatchCallOutputItem? value)
        {
            value = ApplyPatchCallOutputItem;
            return IsApplyPatchCallOutputItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ApplyPatchCallOutputItem PickApplyPatchCallOutputItem() => ApplyPatchCallOutputItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatchCallOutputItem' but the value was {ToString()}.");

        /// <summary>
        /// An output message item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.InputsOneOf1Items7? InputsOneOf1Items7 { get; init; }
#else
        public global::OpenRouter.InputsOneOf1Items7? InputsOneOf1Items7 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputsOneOf1Items7))]
#endif
        public bool IsInputsOneOf1Items7 => InputsOneOf1Items7 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputsOneOf1Items7(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.InputsOneOf1Items7? value)
        {
            value = InputsOneOf1Items7;
            return IsInputsOneOf1Items7;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputsOneOf1Items7 PickInputsOneOf1Items7() => InputsOneOf1Items7 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputsOneOf1Items7' but the value was {ToString()}.");

        /// <summary>
        /// An output item containing reasoning
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.InputsOneOf1Items8? InputsOneOf1Items8 { get; init; }
#else
        public global::OpenRouter.InputsOneOf1Items8? InputsOneOf1Items8 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputsOneOf1Items8))]
#endif
        public bool IsInputsOneOf1Items8 => InputsOneOf1Items8 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputsOneOf1Items8(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.InputsOneOf1Items8? value)
        {
            value = InputsOneOf1Items8;
            return IsInputsOneOf1Items8;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputsOneOf1Items8 PickInputsOneOf1Items8() => InputsOneOf1Items8 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputsOneOf1Items8' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputFunctionCallItem? OutputFunctionCallItem { get; init; }
#else
        public global::OpenRouter.OutputFunctionCallItem? OutputFunctionCallItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputFunctionCallItem))]
#endif
        public bool IsOutputFunctionCallItem => OutputFunctionCallItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputFunctionCallItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputFunctionCallItem? value)
        {
            value = OutputFunctionCallItem;
            return IsOutputFunctionCallItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFunctionCallItem PickOutputFunctionCallItem() => OutputFunctionCallItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputFunctionCallItem' but the value was {ToString()}.");

        /// <summary>
        /// A call to a custom (freeform-grammar) tool created by the model — distinct from `function_call`. Used for tools like Codex CLI's `apply_patch` whose payload is opaque text rather than JSON arguments.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputCustomToolCallItem? OutputCustomToolCallItem { get; init; }
#else
        public global::OpenRouter.OutputCustomToolCallItem? OutputCustomToolCallItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputCustomToolCallItem))]
#endif
        public bool IsOutputCustomToolCallItem => OutputCustomToolCallItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputCustomToolCallItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputCustomToolCallItem? value)
        {
            value = OutputCustomToolCallItem;
            return IsOutputCustomToolCallItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCustomToolCallItem PickOutputCustomToolCallItem() => OutputCustomToolCallItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputCustomToolCallItem' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputWebSearchCallItem? OutputWebSearchCallItem { get; init; }
#else
        public global::OpenRouter.OutputWebSearchCallItem? OutputWebSearchCallItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputWebSearchCallItem))]
#endif
        public bool IsOutputWebSearchCallItem => OutputWebSearchCallItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputWebSearchCallItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputWebSearchCallItem? value)
        {
            value = OutputWebSearchCallItem;
            return IsOutputWebSearchCallItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchCallItem PickOutputWebSearchCallItem() => OutputWebSearchCallItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputWebSearchCallItem' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputFileSearchCallItem? OutputFileSearchCallItem { get; init; }
#else
        public global::OpenRouter.OutputFileSearchCallItem? OutputFileSearchCallItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputFileSearchCallItem))]
#endif
        public bool IsOutputFileSearchCallItem => OutputFileSearchCallItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputFileSearchCallItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputFileSearchCallItem? value)
        {
            value = OutputFileSearchCallItem;
            return IsOutputFileSearchCallItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFileSearchCallItem PickOutputFileSearchCallItem() => OutputFileSearchCallItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputFileSearchCallItem' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputImageGenerationCallItem? OutputImageGenerationCallItem { get; init; }
#else
        public global::OpenRouter.OutputImageGenerationCallItem? OutputImageGenerationCallItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputImageGenerationCallItem))]
#endif
        public bool IsOutputImageGenerationCallItem => OutputImageGenerationCallItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputImageGenerationCallItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputImageGenerationCallItem? value)
        {
            value = OutputImageGenerationCallItem;
            return IsOutputImageGenerationCallItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputImageGenerationCallItem PickOutputImageGenerationCallItem() => OutputImageGenerationCallItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputImageGenerationCallItem' but the value was {ToString()}.");

        /// <summary>
        /// A code interpreter execution call with outputs
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputCodeInterpreterCallItem? OutputCodeInterpreterCallItem { get; init; }
#else
        public global::OpenRouter.OutputCodeInterpreterCallItem? OutputCodeInterpreterCallItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputCodeInterpreterCallItem))]
#endif
        public bool IsOutputCodeInterpreterCallItem => OutputCodeInterpreterCallItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputCodeInterpreterCallItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputCodeInterpreterCallItem? value)
        {
            value = OutputCodeInterpreterCallItem;
            return IsOutputCodeInterpreterCallItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCodeInterpreterCallItem PickOutputCodeInterpreterCallItem() => OutputCodeInterpreterCallItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputCodeInterpreterCallItem' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputComputerCallItem? OutputComputerCallItem { get; init; }
#else
        public global::OpenRouter.OutputComputerCallItem? OutputComputerCallItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputComputerCallItem))]
#endif
        public bool IsOutputComputerCallItem => OutputComputerCallItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputComputerCallItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputComputerCallItem? value)
        {
            value = OutputComputerCallItem;
            return IsOutputComputerCallItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputComputerCallItem PickOutputComputerCallItem() => OutputComputerCallItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputComputerCallItem' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:datetime server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputDatetimeItem? OutputDatetimeItem { get; init; }
#else
        public global::OpenRouter.OutputDatetimeItem? OutputDatetimeItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputDatetimeItem))]
#endif
        public bool IsOutputDatetimeItem => OutputDatetimeItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputDatetimeItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputDatetimeItem? value)
        {
            value = OutputDatetimeItem;
            return IsOutputDatetimeItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputDatetimeItem PickOutputDatetimeItem() => OutputDatetimeItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputDatetimeItem' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:web_search server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputWebSearchServerToolItem? OutputWebSearchServerToolItem { get; init; }
#else
        public global::OpenRouter.OutputWebSearchServerToolItem? OutputWebSearchServerToolItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputWebSearchServerToolItem))]
#endif
        public bool IsOutputWebSearchServerToolItem => OutputWebSearchServerToolItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputWebSearchServerToolItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputWebSearchServerToolItem? value)
        {
            value = OutputWebSearchServerToolItem;
            return IsOutputWebSearchServerToolItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebSearchServerToolItem PickOutputWebSearchServerToolItem() => OutputWebSearchServerToolItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputWebSearchServerToolItem' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:code_interpreter server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputCodeInterpreterServerToolItem? OutputCodeInterpreterServerToolItem { get; init; }
#else
        public global::OpenRouter.OutputCodeInterpreterServerToolItem? OutputCodeInterpreterServerToolItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputCodeInterpreterServerToolItem))]
#endif
        public bool IsOutputCodeInterpreterServerToolItem => OutputCodeInterpreterServerToolItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputCodeInterpreterServerToolItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputCodeInterpreterServerToolItem? value)
        {
            value = OutputCodeInterpreterServerToolItem;
            return IsOutputCodeInterpreterServerToolItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputCodeInterpreterServerToolItem PickOutputCodeInterpreterServerToolItem() => OutputCodeInterpreterServerToolItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputCodeInterpreterServerToolItem' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:file_search server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputFileSearchServerToolItem? OutputFileSearchServerToolItem { get; init; }
#else
        public global::OpenRouter.OutputFileSearchServerToolItem? OutputFileSearchServerToolItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputFileSearchServerToolItem))]
#endif
        public bool IsOutputFileSearchServerToolItem => OutputFileSearchServerToolItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputFileSearchServerToolItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputFileSearchServerToolItem? value)
        {
            value = OutputFileSearchServerToolItem;
            return IsOutputFileSearchServerToolItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFileSearchServerToolItem PickOutputFileSearchServerToolItem() => OutputFileSearchServerToolItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputFileSearchServerToolItem' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:image_generation server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputImageGenerationServerToolItem? OutputImageGenerationServerToolItem { get; init; }
#else
        public global::OpenRouter.OutputImageGenerationServerToolItem? OutputImageGenerationServerToolItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputImageGenerationServerToolItem))]
#endif
        public bool IsOutputImageGenerationServerToolItem => OutputImageGenerationServerToolItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputImageGenerationServerToolItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputImageGenerationServerToolItem? value)
        {
            value = OutputImageGenerationServerToolItem;
            return IsOutputImageGenerationServerToolItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputImageGenerationServerToolItem PickOutputImageGenerationServerToolItem() => OutputImageGenerationServerToolItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputImageGenerationServerToolItem' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:browser_use server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputBrowserUseServerToolItem? OutputBrowserUseServerToolItem { get; init; }
#else
        public global::OpenRouter.OutputBrowserUseServerToolItem? OutputBrowserUseServerToolItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputBrowserUseServerToolItem))]
#endif
        public bool IsOutputBrowserUseServerToolItem => OutputBrowserUseServerToolItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputBrowserUseServerToolItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputBrowserUseServerToolItem? value)
        {
            value = OutputBrowserUseServerToolItem;
            return IsOutputBrowserUseServerToolItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputBrowserUseServerToolItem PickOutputBrowserUseServerToolItem() => OutputBrowserUseServerToolItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputBrowserUseServerToolItem' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:bash server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputBashServerToolItem? OutputBashServerToolItem { get; init; }
#else
        public global::OpenRouter.OutputBashServerToolItem? OutputBashServerToolItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputBashServerToolItem))]
#endif
        public bool IsOutputBashServerToolItem => OutputBashServerToolItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputBashServerToolItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputBashServerToolItem? value)
        {
            value = OutputBashServerToolItem;
            return IsOutputBashServerToolItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputBashServerToolItem PickOutputBashServerToolItem() => OutputBashServerToolItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputBashServerToolItem' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:text_editor server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputTextEditorServerToolItem? OutputTextEditorServerToolItem { get; init; }
#else
        public global::OpenRouter.OutputTextEditorServerToolItem? OutputTextEditorServerToolItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputTextEditorServerToolItem))]
#endif
        public bool IsOutputTextEditorServerToolItem => OutputTextEditorServerToolItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputTextEditorServerToolItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputTextEditorServerToolItem? value)
        {
            value = OutputTextEditorServerToolItem;
            return IsOutputTextEditorServerToolItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputTextEditorServerToolItem PickOutputTextEditorServerToolItem() => OutputTextEditorServerToolItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputTextEditorServerToolItem' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:apply_patch server tool output item. The turn halts when validation succeeds so the client can apply the patch and echo an `apply_patch_call_output` on the next turn.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputApplyPatchServerToolItem? OutputApplyPatchServerToolItem { get; init; }
#else
        public global::OpenRouter.OutputApplyPatchServerToolItem? OutputApplyPatchServerToolItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputApplyPatchServerToolItem))]
#endif
        public bool IsOutputApplyPatchServerToolItem => OutputApplyPatchServerToolItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputApplyPatchServerToolItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputApplyPatchServerToolItem? value)
        {
            value = OutputApplyPatchServerToolItem;
            return IsOutputApplyPatchServerToolItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputApplyPatchServerToolItem PickOutputApplyPatchServerToolItem() => OutputApplyPatchServerToolItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputApplyPatchServerToolItem' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:web_fetch server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputWebFetchServerToolItem? OutputWebFetchServerToolItem { get; init; }
#else
        public global::OpenRouter.OutputWebFetchServerToolItem? OutputWebFetchServerToolItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputWebFetchServerToolItem))]
#endif
        public bool IsOutputWebFetchServerToolItem => OutputWebFetchServerToolItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputWebFetchServerToolItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputWebFetchServerToolItem? value)
        {
            value = OutputWebFetchServerToolItem;
            return IsOutputWebFetchServerToolItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputWebFetchServerToolItem PickOutputWebFetchServerToolItem() => OutputWebFetchServerToolItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputWebFetchServerToolItem' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:tool_search server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputToolSearchServerToolItem? OutputToolSearchServerToolItem { get; init; }
#else
        public global::OpenRouter.OutputToolSearchServerToolItem? OutputToolSearchServerToolItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputToolSearchServerToolItem))]
#endif
        public bool IsOutputToolSearchServerToolItem => OutputToolSearchServerToolItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputToolSearchServerToolItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputToolSearchServerToolItem? value)
        {
            value = OutputToolSearchServerToolItem;
            return IsOutputToolSearchServerToolItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputToolSearchServerToolItem PickOutputToolSearchServerToolItem() => OutputToolSearchServerToolItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputToolSearchServerToolItem' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:memory server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputMemoryServerToolItem? OutputMemoryServerToolItem { get; init; }
#else
        public global::OpenRouter.OutputMemoryServerToolItem? OutputMemoryServerToolItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputMemoryServerToolItem))]
#endif
        public bool IsOutputMemoryServerToolItem => OutputMemoryServerToolItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputMemoryServerToolItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputMemoryServerToolItem? value)
        {
            value = OutputMemoryServerToolItem;
            return IsOutputMemoryServerToolItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMemoryServerToolItem PickOutputMemoryServerToolItem() => OutputMemoryServerToolItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputMemoryServerToolItem' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:mcp server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputMcpServerToolItem? OutputMcpServerToolItem { get; init; }
#else
        public global::OpenRouter.OutputMcpServerToolItem? OutputMcpServerToolItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputMcpServerToolItem))]
#endif
        public bool IsOutputMcpServerToolItem => OutputMcpServerToolItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputMcpServerToolItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputMcpServerToolItem? value)
        {
            value = OutputMcpServerToolItem;
            return IsOutputMcpServerToolItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMcpServerToolItem PickOutputMcpServerToolItem() => OutputMcpServerToolItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputMcpServerToolItem' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:experimental__search_models server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputSearchModelsServerToolItem? OutputSearchModelsServerToolItem { get; init; }
#else
        public global::OpenRouter.OutputSearchModelsServerToolItem? OutputSearchModelsServerToolItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputSearchModelsServerToolItem))]
#endif
        public bool IsOutputSearchModelsServerToolItem => OutputSearchModelsServerToolItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputSearchModelsServerToolItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputSearchModelsServerToolItem? value)
        {
            value = OutputSearchModelsServerToolItem;
            return IsOutputSearchModelsServerToolItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputSearchModelsServerToolItem PickOutputSearchModelsServerToolItem() => OutputSearchModelsServerToolItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputSearchModelsServerToolItem' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:fusion server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputFusionServerToolItem? OutputFusionServerToolItem { get; init; }
#else
        public global::OpenRouter.OutputFusionServerToolItem? OutputFusionServerToolItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputFusionServerToolItem))]
#endif
        public bool IsOutputFusionServerToolItem => OutputFusionServerToolItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputFusionServerToolItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputFusionServerToolItem? value)
        {
            value = OutputFusionServerToolItem;
            return IsOutputFusionServerToolItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFusionServerToolItem PickOutputFusionServerToolItem() => OutputFusionServerToolItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputFusionServerToolItem' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:advisor server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputAdvisorServerToolItem? OutputAdvisorServerToolItem { get; init; }
#else
        public global::OpenRouter.OutputAdvisorServerToolItem? OutputAdvisorServerToolItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputAdvisorServerToolItem))]
#endif
        public bool IsOutputAdvisorServerToolItem => OutputAdvisorServerToolItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputAdvisorServerToolItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputAdvisorServerToolItem? value)
        {
            value = OutputAdvisorServerToolItem;
            return IsOutputAdvisorServerToolItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputAdvisorServerToolItem PickOutputAdvisorServerToolItem() => OutputAdvisorServerToolItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputAdvisorServerToolItem' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:subagent server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputSubagentServerToolItem? OutputSubagentServerToolItem { get; init; }
#else
        public global::OpenRouter.OutputSubagentServerToolItem? OutputSubagentServerToolItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputSubagentServerToolItem))]
#endif
        public bool IsOutputSubagentServerToolItem => OutputSubagentServerToolItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputSubagentServerToolItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputSubagentServerToolItem? value)
        {
            value = OutputSubagentServerToolItem;
            return IsOutputSubagentServerToolItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputSubagentServerToolItem PickOutputSubagentServerToolItem() => OutputSubagentServerToolItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputSubagentServerToolItem' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:files server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputFilesServerToolItem? OutputFilesServerToolItem { get; init; }
#else
        public global::OpenRouter.OutputFilesServerToolItem? OutputFilesServerToolItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputFilesServerToolItem))]
#endif
        public bool IsOutputFilesServerToolItem => OutputFilesServerToolItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputFilesServerToolItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputFilesServerToolItem? value)
        {
            value = OutputFilesServerToolItem;
            return IsOutputFilesServerToolItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputFilesServerToolItem PickOutputFilesServerToolItem() => OutputFilesServerToolItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputFilesServerToolItem' but the value was {ToString()}.");

        /// <summary>
        /// A local shell command execution call
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.LocalShellCallItem? LocalShellCallItem { get; init; }
#else
        public global::OpenRouter.LocalShellCallItem? LocalShellCallItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LocalShellCallItem))]
#endif
        public bool IsLocalShellCallItem => LocalShellCallItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickLocalShellCallItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.LocalShellCallItem? value)
        {
            value = LocalShellCallItem;
            return IsLocalShellCallItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LocalShellCallItem PickLocalShellCallItem() => LocalShellCallItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LocalShellCallItem' but the value was {ToString()}.");

        /// <summary>
        /// Output from a local shell command execution
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.LocalShellCallOutputItem? LocalShellCallOutputItem { get; init; }
#else
        public global::OpenRouter.LocalShellCallOutputItem? LocalShellCallOutputItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LocalShellCallOutputItem))]
#endif
        public bool IsLocalShellCallOutputItem => LocalShellCallOutputItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickLocalShellCallOutputItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.LocalShellCallOutputItem? value)
        {
            value = LocalShellCallOutputItem;
            return IsLocalShellCallOutputItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.LocalShellCallOutputItem PickLocalShellCallOutputItem() => LocalShellCallOutputItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'LocalShellCallOutputItem' but the value was {ToString()}.");

        /// <summary>
        /// A shell command execution call (newer variant)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ShellCallItem? ShellCallItem { get; init; }
#else
        public global::OpenRouter.ShellCallItem? ShellCallItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ShellCallItem))]
#endif
        public bool IsShellCallItem => ShellCallItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShellCallItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ShellCallItem? value)
        {
            value = ShellCallItem;
            return IsShellCallItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallItem PickShellCallItem() => ShellCallItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ShellCallItem' but the value was {ToString()}.");

        /// <summary>
        /// Output from a shell command execution (newer variant)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ShellCallOutputItem? ShellCallOutputItem { get; init; }
#else
        public global::OpenRouter.ShellCallOutputItem? ShellCallOutputItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ShellCallOutputItem))]
#endif
        public bool IsShellCallOutputItem => ShellCallOutputItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickShellCallOutputItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ShellCallOutputItem? value)
        {
            value = ShellCallOutputItem;
            return IsShellCallOutputItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ShellCallOutputItem PickShellCallOutputItem() => ShellCallOutputItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ShellCallOutputItem' but the value was {ToString()}.");

        /// <summary>
        /// List of available MCP tools from a server
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.McpListToolsItem? McpListToolsItem { get; init; }
#else
        public global::OpenRouter.McpListToolsItem? McpListToolsItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpListToolsItem))]
#endif
        public bool IsMcpListToolsItem => McpListToolsItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMcpListToolsItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.McpListToolsItem? value)
        {
            value = McpListToolsItem;
            return IsMcpListToolsItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpListToolsItem PickMcpListToolsItem() => McpListToolsItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpListToolsItem' but the value was {ToString()}.");

        /// <summary>
        /// Request for approval to execute an MCP tool
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.McpApprovalRequestItem? McpApprovalRequestItem { get; init; }
#else
        public global::OpenRouter.McpApprovalRequestItem? McpApprovalRequestItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpApprovalRequestItem))]
#endif
        public bool IsMcpApprovalRequestItem => McpApprovalRequestItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMcpApprovalRequestItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.McpApprovalRequestItem? value)
        {
            value = McpApprovalRequestItem;
            return IsMcpApprovalRequestItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpApprovalRequestItem PickMcpApprovalRequestItem() => McpApprovalRequestItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpApprovalRequestItem' but the value was {ToString()}.");

        /// <summary>
        /// User response to an MCP tool approval request
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.McpApprovalResponseItem? McpApprovalResponseItem { get; init; }
#else
        public global::OpenRouter.McpApprovalResponseItem? McpApprovalResponseItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpApprovalResponseItem))]
#endif
        public bool IsMcpApprovalResponseItem => McpApprovalResponseItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMcpApprovalResponseItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.McpApprovalResponseItem? value)
        {
            value = McpApprovalResponseItem;
            return IsMcpApprovalResponseItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpApprovalResponseItem PickMcpApprovalResponseItem() => McpApprovalResponseItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpApprovalResponseItem' but the value was {ToString()}.");

        /// <summary>
        /// An MCP tool call with its output or error
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.McpCallItem? McpCallItem { get; init; }
#else
        public global::OpenRouter.McpCallItem? McpCallItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpCallItem))]
#endif
        public bool IsMcpCallItem => McpCallItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMcpCallItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.McpCallItem? value)
        {
            value = McpCallItem;
            return IsMcpCallItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.McpCallItem PickMcpCallItem() => McpCallItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpCallItem' but the value was {ToString()}.");

        /// <summary>
        /// A call to a custom (freeform-grammar) tool created by the model — distinct from `function_call`. Used for tools like Codex CLI's `apply_patch` whose payload is opaque text rather than JSON arguments.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CustomToolCallItem? CustomToolCallItem { get; init; }
#else
        public global::OpenRouter.CustomToolCallItem? CustomToolCallItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomToolCallItem))]
#endif
        public bool IsCustomToolCallItem => CustomToolCallItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCustomToolCallItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.CustomToolCallItem? value)
        {
            value = CustomToolCallItem;
            return IsCustomToolCallItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallItem PickCustomToolCallItem() => CustomToolCallItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomToolCallItem' but the value was {ToString()}.");

        /// <summary>
        /// The output from a custom (freeform-grammar) tool call execution. Mirrors `function_call_output` but is matched to a `custom_tool_call` rather than a `function_call`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CustomToolCallOutputItem? CustomToolCallOutputItem { get; init; }
#else
        public global::OpenRouter.CustomToolCallOutputItem? CustomToolCallOutputItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomToolCallOutputItem))]
#endif
        public bool IsCustomToolCallOutputItem => CustomToolCallOutputItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCustomToolCallOutputItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.CustomToolCallOutputItem? value)
        {
            value = CustomToolCallOutputItem;
            return IsCustomToolCallOutputItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CustomToolCallOutputItem PickCustomToolCallOutputItem() => CustomToolCallOutputItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomToolCallOutputItem' but the value was {ToString()}.");

        /// <summary>
        /// A context compaction marker with encrypted summary
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CompactionItem? CompactionItem { get; init; }
#else
        public global::OpenRouter.CompactionItem? CompactionItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompactionItem))]
#endif
        public bool IsCompactionItem => CompactionItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCompactionItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.CompactionItem? value)
        {
            value = CompactionItem;
            return IsCompactionItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CompactionItem PickCompactionItem() => CompactionItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CompactionItem' but the value was {ToString()}.");

        /// <summary>
        /// A context compaction marker with an optional encrypted summary
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ContextCompactionItem? ContextCompactionItem { get; init; }
#else
        public global::OpenRouter.ContextCompactionItem? ContextCompactionItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContextCompactionItem))]
#endif
        public bool IsContextCompactionItem => ContextCompactionItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickContextCompactionItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ContextCompactionItem? value)
        {
            value = ContextCompactionItem;
            return IsContextCompactionItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContextCompactionItem PickContextCompactionItem() => ContextCompactionItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContextCompactionItem' but the value was {ToString()}.");

        /// <summary>
        /// A reference to a previous response item by ID
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ItemReferenceItem? ItemReferenceItem { get; init; }
#else
        public global::OpenRouter.ItemReferenceItem? ItemReferenceItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ItemReferenceItem))]
#endif
        public bool IsItemReferenceItem => ItemReferenceItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickItemReferenceItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ItemReferenceItem? value)
        {
            value = ItemReferenceItem;
            return IsItemReferenceItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ItemReferenceItem PickItemReferenceItem() => ItemReferenceItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ItemReferenceItem' but the value was {ToString()}.");

        /// <summary>
        /// Additional tools made available to the model at this point in the input
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AdditionalToolsItem? AdditionalToolsItem { get; init; }
#else
        public global::OpenRouter.AdditionalToolsItem? AdditionalToolsItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AdditionalToolsItem))]
#endif
        public bool IsAdditionalToolsItem => AdditionalToolsItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAdditionalToolsItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AdditionalToolsItem? value)
        {
            value = AdditionalToolsItem;
            return IsAdditionalToolsItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AdditionalToolsItem PickAdditionalToolsItem() => AdditionalToolsItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AdditionalToolsItem' but the value was {ToString()}.");

        /// <summary>
        /// A message routed between agents in a multi-agent session
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AgentMessageItem? AgentMessageItem { get; init; }
#else
        public global::OpenRouter.AgentMessageItem? AgentMessageItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AgentMessageItem))]
#endif
        public bool IsAgentMessageItem => AgentMessageItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAgentMessageItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AgentMessageItem? value)
        {
            value = AgentMessageItem;
            return IsAgentMessageItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AgentMessageItem PickAgentMessageItem() => AgentMessageItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AgentMessageItem' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.ReasoningItem value) => new InputsOneOf1Items((global::OpenRouter.ReasoningItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ReasoningItem?(InputsOneOf1Items @this) => @this.ReasoningItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.ReasoningItem? value)
        {
            ReasoningItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromReasoningItem(global::OpenRouter.ReasoningItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.EasyInputMessage value) => new InputsOneOf1Items((global::OpenRouter.EasyInputMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.EasyInputMessage?(InputsOneOf1Items @this) => @this.EasyInputMessage;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.EasyInputMessage? value)
        {
            EasyInputMessage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromEasyInputMessage(global::OpenRouter.EasyInputMessage? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.InputMessageItem value) => new InputsOneOf1Items((global::OpenRouter.InputMessageItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.InputMessageItem?(InputsOneOf1Items @this) => @this.InputMessageItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.InputMessageItem? value)
        {
            InputMessageItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromInputMessageItem(global::OpenRouter.InputMessageItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.FunctionCallItem value) => new InputsOneOf1Items((global::OpenRouter.FunctionCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.FunctionCallItem?(InputsOneOf1Items @this) => @this.FunctionCallItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.FunctionCallItem? value)
        {
            FunctionCallItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromFunctionCallItem(global::OpenRouter.FunctionCallItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.FunctionCallOutputItem value) => new InputsOneOf1Items((global::OpenRouter.FunctionCallOutputItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.FunctionCallOutputItem?(InputsOneOf1Items @this) => @this.FunctionCallOutputItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.FunctionCallOutputItem? value)
        {
            FunctionCallOutputItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromFunctionCallOutputItem(global::OpenRouter.FunctionCallOutputItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.ApplyPatchCallItem value) => new InputsOneOf1Items((global::OpenRouter.ApplyPatchCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ApplyPatchCallItem?(InputsOneOf1Items @this) => @this.ApplyPatchCallItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.ApplyPatchCallItem? value)
        {
            ApplyPatchCallItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromApplyPatchCallItem(global::OpenRouter.ApplyPatchCallItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.ApplyPatchCallOutputItem value) => new InputsOneOf1Items((global::OpenRouter.ApplyPatchCallOutputItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ApplyPatchCallOutputItem?(InputsOneOf1Items @this) => @this.ApplyPatchCallOutputItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.ApplyPatchCallOutputItem? value)
        {
            ApplyPatchCallOutputItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromApplyPatchCallOutputItem(global::OpenRouter.ApplyPatchCallOutputItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.InputsOneOf1Items7 value) => new InputsOneOf1Items((global::OpenRouter.InputsOneOf1Items7?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.InputsOneOf1Items7?(InputsOneOf1Items @this) => @this.InputsOneOf1Items7;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.InputsOneOf1Items7? value)
        {
            InputsOneOf1Items7 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromInputsOneOf1Items7(global::OpenRouter.InputsOneOf1Items7? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.InputsOneOf1Items8 value) => new InputsOneOf1Items((global::OpenRouter.InputsOneOf1Items8?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.InputsOneOf1Items8?(InputsOneOf1Items @this) => @this.InputsOneOf1Items8;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.InputsOneOf1Items8? value)
        {
            InputsOneOf1Items8 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromInputsOneOf1Items8(global::OpenRouter.InputsOneOf1Items8? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.OutputFunctionCallItem value) => new InputsOneOf1Items((global::OpenRouter.OutputFunctionCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputFunctionCallItem?(InputsOneOf1Items @this) => @this.OutputFunctionCallItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.OutputFunctionCallItem? value)
        {
            OutputFunctionCallItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromOutputFunctionCallItem(global::OpenRouter.OutputFunctionCallItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.OutputCustomToolCallItem value) => new InputsOneOf1Items((global::OpenRouter.OutputCustomToolCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputCustomToolCallItem?(InputsOneOf1Items @this) => @this.OutputCustomToolCallItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.OutputCustomToolCallItem? value)
        {
            OutputCustomToolCallItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromOutputCustomToolCallItem(global::OpenRouter.OutputCustomToolCallItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.OutputWebSearchCallItem value) => new InputsOneOf1Items((global::OpenRouter.OutputWebSearchCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputWebSearchCallItem?(InputsOneOf1Items @this) => @this.OutputWebSearchCallItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.OutputWebSearchCallItem? value)
        {
            OutputWebSearchCallItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromOutputWebSearchCallItem(global::OpenRouter.OutputWebSearchCallItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.OutputFileSearchCallItem value) => new InputsOneOf1Items((global::OpenRouter.OutputFileSearchCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputFileSearchCallItem?(InputsOneOf1Items @this) => @this.OutputFileSearchCallItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.OutputFileSearchCallItem? value)
        {
            OutputFileSearchCallItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromOutputFileSearchCallItem(global::OpenRouter.OutputFileSearchCallItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.OutputImageGenerationCallItem value) => new InputsOneOf1Items((global::OpenRouter.OutputImageGenerationCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputImageGenerationCallItem?(InputsOneOf1Items @this) => @this.OutputImageGenerationCallItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.OutputImageGenerationCallItem? value)
        {
            OutputImageGenerationCallItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromOutputImageGenerationCallItem(global::OpenRouter.OutputImageGenerationCallItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.OutputCodeInterpreterCallItem value) => new InputsOneOf1Items((global::OpenRouter.OutputCodeInterpreterCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputCodeInterpreterCallItem?(InputsOneOf1Items @this) => @this.OutputCodeInterpreterCallItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.OutputCodeInterpreterCallItem? value)
        {
            OutputCodeInterpreterCallItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromOutputCodeInterpreterCallItem(global::OpenRouter.OutputCodeInterpreterCallItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.OutputComputerCallItem value) => new InputsOneOf1Items((global::OpenRouter.OutputComputerCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputComputerCallItem?(InputsOneOf1Items @this) => @this.OutputComputerCallItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.OutputComputerCallItem? value)
        {
            OutputComputerCallItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromOutputComputerCallItem(global::OpenRouter.OutputComputerCallItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.OutputDatetimeItem value) => new InputsOneOf1Items((global::OpenRouter.OutputDatetimeItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputDatetimeItem?(InputsOneOf1Items @this) => @this.OutputDatetimeItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.OutputDatetimeItem? value)
        {
            OutputDatetimeItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromOutputDatetimeItem(global::OpenRouter.OutputDatetimeItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.OutputWebSearchServerToolItem value) => new InputsOneOf1Items((global::OpenRouter.OutputWebSearchServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputWebSearchServerToolItem?(InputsOneOf1Items @this) => @this.OutputWebSearchServerToolItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.OutputWebSearchServerToolItem? value)
        {
            OutputWebSearchServerToolItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromOutputWebSearchServerToolItem(global::OpenRouter.OutputWebSearchServerToolItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.OutputCodeInterpreterServerToolItem value) => new InputsOneOf1Items((global::OpenRouter.OutputCodeInterpreterServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputCodeInterpreterServerToolItem?(InputsOneOf1Items @this) => @this.OutputCodeInterpreterServerToolItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.OutputCodeInterpreterServerToolItem? value)
        {
            OutputCodeInterpreterServerToolItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromOutputCodeInterpreterServerToolItem(global::OpenRouter.OutputCodeInterpreterServerToolItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.OutputFileSearchServerToolItem value) => new InputsOneOf1Items((global::OpenRouter.OutputFileSearchServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputFileSearchServerToolItem?(InputsOneOf1Items @this) => @this.OutputFileSearchServerToolItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.OutputFileSearchServerToolItem? value)
        {
            OutputFileSearchServerToolItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromOutputFileSearchServerToolItem(global::OpenRouter.OutputFileSearchServerToolItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.OutputImageGenerationServerToolItem value) => new InputsOneOf1Items((global::OpenRouter.OutputImageGenerationServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputImageGenerationServerToolItem?(InputsOneOf1Items @this) => @this.OutputImageGenerationServerToolItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.OutputImageGenerationServerToolItem? value)
        {
            OutputImageGenerationServerToolItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromOutputImageGenerationServerToolItem(global::OpenRouter.OutputImageGenerationServerToolItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.OutputBrowserUseServerToolItem value) => new InputsOneOf1Items((global::OpenRouter.OutputBrowserUseServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputBrowserUseServerToolItem?(InputsOneOf1Items @this) => @this.OutputBrowserUseServerToolItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.OutputBrowserUseServerToolItem? value)
        {
            OutputBrowserUseServerToolItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromOutputBrowserUseServerToolItem(global::OpenRouter.OutputBrowserUseServerToolItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.OutputBashServerToolItem value) => new InputsOneOf1Items((global::OpenRouter.OutputBashServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputBashServerToolItem?(InputsOneOf1Items @this) => @this.OutputBashServerToolItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.OutputBashServerToolItem? value)
        {
            OutputBashServerToolItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromOutputBashServerToolItem(global::OpenRouter.OutputBashServerToolItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.OutputTextEditorServerToolItem value) => new InputsOneOf1Items((global::OpenRouter.OutputTextEditorServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputTextEditorServerToolItem?(InputsOneOf1Items @this) => @this.OutputTextEditorServerToolItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.OutputTextEditorServerToolItem? value)
        {
            OutputTextEditorServerToolItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromOutputTextEditorServerToolItem(global::OpenRouter.OutputTextEditorServerToolItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.OutputApplyPatchServerToolItem value) => new InputsOneOf1Items((global::OpenRouter.OutputApplyPatchServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputApplyPatchServerToolItem?(InputsOneOf1Items @this) => @this.OutputApplyPatchServerToolItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.OutputApplyPatchServerToolItem? value)
        {
            OutputApplyPatchServerToolItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromOutputApplyPatchServerToolItem(global::OpenRouter.OutputApplyPatchServerToolItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.OutputWebFetchServerToolItem value) => new InputsOneOf1Items((global::OpenRouter.OutputWebFetchServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputWebFetchServerToolItem?(InputsOneOf1Items @this) => @this.OutputWebFetchServerToolItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.OutputWebFetchServerToolItem? value)
        {
            OutputWebFetchServerToolItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromOutputWebFetchServerToolItem(global::OpenRouter.OutputWebFetchServerToolItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.OutputToolSearchServerToolItem value) => new InputsOneOf1Items((global::OpenRouter.OutputToolSearchServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputToolSearchServerToolItem?(InputsOneOf1Items @this) => @this.OutputToolSearchServerToolItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.OutputToolSearchServerToolItem? value)
        {
            OutputToolSearchServerToolItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromOutputToolSearchServerToolItem(global::OpenRouter.OutputToolSearchServerToolItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.OutputMemoryServerToolItem value) => new InputsOneOf1Items((global::OpenRouter.OutputMemoryServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputMemoryServerToolItem?(InputsOneOf1Items @this) => @this.OutputMemoryServerToolItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.OutputMemoryServerToolItem? value)
        {
            OutputMemoryServerToolItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromOutputMemoryServerToolItem(global::OpenRouter.OutputMemoryServerToolItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.OutputMcpServerToolItem value) => new InputsOneOf1Items((global::OpenRouter.OutputMcpServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputMcpServerToolItem?(InputsOneOf1Items @this) => @this.OutputMcpServerToolItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.OutputMcpServerToolItem? value)
        {
            OutputMcpServerToolItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromOutputMcpServerToolItem(global::OpenRouter.OutputMcpServerToolItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.OutputSearchModelsServerToolItem value) => new InputsOneOf1Items((global::OpenRouter.OutputSearchModelsServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputSearchModelsServerToolItem?(InputsOneOf1Items @this) => @this.OutputSearchModelsServerToolItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.OutputSearchModelsServerToolItem? value)
        {
            OutputSearchModelsServerToolItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromOutputSearchModelsServerToolItem(global::OpenRouter.OutputSearchModelsServerToolItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.OutputFusionServerToolItem value) => new InputsOneOf1Items((global::OpenRouter.OutputFusionServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputFusionServerToolItem?(InputsOneOf1Items @this) => @this.OutputFusionServerToolItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.OutputFusionServerToolItem? value)
        {
            OutputFusionServerToolItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromOutputFusionServerToolItem(global::OpenRouter.OutputFusionServerToolItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.OutputAdvisorServerToolItem value) => new InputsOneOf1Items((global::OpenRouter.OutputAdvisorServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputAdvisorServerToolItem?(InputsOneOf1Items @this) => @this.OutputAdvisorServerToolItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.OutputAdvisorServerToolItem? value)
        {
            OutputAdvisorServerToolItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromOutputAdvisorServerToolItem(global::OpenRouter.OutputAdvisorServerToolItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.OutputSubagentServerToolItem value) => new InputsOneOf1Items((global::OpenRouter.OutputSubagentServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputSubagentServerToolItem?(InputsOneOf1Items @this) => @this.OutputSubagentServerToolItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.OutputSubagentServerToolItem? value)
        {
            OutputSubagentServerToolItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromOutputSubagentServerToolItem(global::OpenRouter.OutputSubagentServerToolItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.OutputFilesServerToolItem value) => new InputsOneOf1Items((global::OpenRouter.OutputFilesServerToolItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputFilesServerToolItem?(InputsOneOf1Items @this) => @this.OutputFilesServerToolItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.OutputFilesServerToolItem? value)
        {
            OutputFilesServerToolItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromOutputFilesServerToolItem(global::OpenRouter.OutputFilesServerToolItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.LocalShellCallItem value) => new InputsOneOf1Items((global::OpenRouter.LocalShellCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.LocalShellCallItem?(InputsOneOf1Items @this) => @this.LocalShellCallItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.LocalShellCallItem? value)
        {
            LocalShellCallItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromLocalShellCallItem(global::OpenRouter.LocalShellCallItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.LocalShellCallOutputItem value) => new InputsOneOf1Items((global::OpenRouter.LocalShellCallOutputItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.LocalShellCallOutputItem?(InputsOneOf1Items @this) => @this.LocalShellCallOutputItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.LocalShellCallOutputItem? value)
        {
            LocalShellCallOutputItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromLocalShellCallOutputItem(global::OpenRouter.LocalShellCallOutputItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.ShellCallItem value) => new InputsOneOf1Items((global::OpenRouter.ShellCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ShellCallItem?(InputsOneOf1Items @this) => @this.ShellCallItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.ShellCallItem? value)
        {
            ShellCallItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromShellCallItem(global::OpenRouter.ShellCallItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.ShellCallOutputItem value) => new InputsOneOf1Items((global::OpenRouter.ShellCallOutputItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ShellCallOutputItem?(InputsOneOf1Items @this) => @this.ShellCallOutputItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.ShellCallOutputItem? value)
        {
            ShellCallOutputItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromShellCallOutputItem(global::OpenRouter.ShellCallOutputItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.McpListToolsItem value) => new InputsOneOf1Items((global::OpenRouter.McpListToolsItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.McpListToolsItem?(InputsOneOf1Items @this) => @this.McpListToolsItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.McpListToolsItem? value)
        {
            McpListToolsItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromMcpListToolsItem(global::OpenRouter.McpListToolsItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.McpApprovalRequestItem value) => new InputsOneOf1Items((global::OpenRouter.McpApprovalRequestItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.McpApprovalRequestItem?(InputsOneOf1Items @this) => @this.McpApprovalRequestItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.McpApprovalRequestItem? value)
        {
            McpApprovalRequestItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromMcpApprovalRequestItem(global::OpenRouter.McpApprovalRequestItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.McpApprovalResponseItem value) => new InputsOneOf1Items((global::OpenRouter.McpApprovalResponseItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.McpApprovalResponseItem?(InputsOneOf1Items @this) => @this.McpApprovalResponseItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.McpApprovalResponseItem? value)
        {
            McpApprovalResponseItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromMcpApprovalResponseItem(global::OpenRouter.McpApprovalResponseItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.McpCallItem value) => new InputsOneOf1Items((global::OpenRouter.McpCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.McpCallItem?(InputsOneOf1Items @this) => @this.McpCallItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.McpCallItem? value)
        {
            McpCallItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromMcpCallItem(global::OpenRouter.McpCallItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.CustomToolCallItem value) => new InputsOneOf1Items((global::OpenRouter.CustomToolCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.CustomToolCallItem?(InputsOneOf1Items @this) => @this.CustomToolCallItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.CustomToolCallItem? value)
        {
            CustomToolCallItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromCustomToolCallItem(global::OpenRouter.CustomToolCallItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.CustomToolCallOutputItem value) => new InputsOneOf1Items((global::OpenRouter.CustomToolCallOutputItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.CustomToolCallOutputItem?(InputsOneOf1Items @this) => @this.CustomToolCallOutputItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.CustomToolCallOutputItem? value)
        {
            CustomToolCallOutputItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromCustomToolCallOutputItem(global::OpenRouter.CustomToolCallOutputItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.CompactionItem value) => new InputsOneOf1Items((global::OpenRouter.CompactionItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.CompactionItem?(InputsOneOf1Items @this) => @this.CompactionItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.CompactionItem? value)
        {
            CompactionItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromCompactionItem(global::OpenRouter.CompactionItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.ContextCompactionItem value) => new InputsOneOf1Items((global::OpenRouter.ContextCompactionItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ContextCompactionItem?(InputsOneOf1Items @this) => @this.ContextCompactionItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.ContextCompactionItem? value)
        {
            ContextCompactionItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromContextCompactionItem(global::OpenRouter.ContextCompactionItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.ItemReferenceItem value) => new InputsOneOf1Items((global::OpenRouter.ItemReferenceItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ItemReferenceItem?(InputsOneOf1Items @this) => @this.ItemReferenceItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.ItemReferenceItem? value)
        {
            ItemReferenceItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromItemReferenceItem(global::OpenRouter.ItemReferenceItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.AdditionalToolsItem value) => new InputsOneOf1Items((global::OpenRouter.AdditionalToolsItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AdditionalToolsItem?(InputsOneOf1Items @this) => @this.AdditionalToolsItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.AdditionalToolsItem? value)
        {
            AdditionalToolsItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromAdditionalToolsItem(global::OpenRouter.AdditionalToolsItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.AgentMessageItem value) => new InputsOneOf1Items((global::OpenRouter.AgentMessageItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AgentMessageItem?(InputsOneOf1Items @this) => @this.AgentMessageItem;

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.AgentMessageItem? value)
        {
            AgentMessageItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputsOneOf1Items FromAgentMessageItem(global::OpenRouter.AgentMessageItem? value) => new InputsOneOf1Items(value);

        /// <summary>
        ///
        /// </summary>
        public InputsOneOf1Items(
            global::OpenRouter.ReasoningItem? reasoningItem,
            global::OpenRouter.EasyInputMessage? easyInputMessage,
            global::OpenRouter.InputMessageItem? inputMessageItem,
            global::OpenRouter.FunctionCallItem? functionCallItem,
            global::OpenRouter.FunctionCallOutputItem? functionCallOutputItem,
            global::OpenRouter.ApplyPatchCallItem? applyPatchCallItem,
            global::OpenRouter.ApplyPatchCallOutputItem? applyPatchCallOutputItem,
            global::OpenRouter.InputsOneOf1Items7? inputsOneOf1Items7,
            global::OpenRouter.InputsOneOf1Items8? inputsOneOf1Items8,
            global::OpenRouter.OutputFunctionCallItem? outputFunctionCallItem,
            global::OpenRouter.OutputCustomToolCallItem? outputCustomToolCallItem,
            global::OpenRouter.OutputWebSearchCallItem? outputWebSearchCallItem,
            global::OpenRouter.OutputFileSearchCallItem? outputFileSearchCallItem,
            global::OpenRouter.OutputImageGenerationCallItem? outputImageGenerationCallItem,
            global::OpenRouter.OutputCodeInterpreterCallItem? outputCodeInterpreterCallItem,
            global::OpenRouter.OutputComputerCallItem? outputComputerCallItem,
            global::OpenRouter.OutputDatetimeItem? outputDatetimeItem,
            global::OpenRouter.OutputWebSearchServerToolItem? outputWebSearchServerToolItem,
            global::OpenRouter.OutputCodeInterpreterServerToolItem? outputCodeInterpreterServerToolItem,
            global::OpenRouter.OutputFileSearchServerToolItem? outputFileSearchServerToolItem,
            global::OpenRouter.OutputImageGenerationServerToolItem? outputImageGenerationServerToolItem,
            global::OpenRouter.OutputBrowserUseServerToolItem? outputBrowserUseServerToolItem,
            global::OpenRouter.OutputBashServerToolItem? outputBashServerToolItem,
            global::OpenRouter.OutputTextEditorServerToolItem? outputTextEditorServerToolItem,
            global::OpenRouter.OutputApplyPatchServerToolItem? outputApplyPatchServerToolItem,
            global::OpenRouter.OutputWebFetchServerToolItem? outputWebFetchServerToolItem,
            global::OpenRouter.OutputToolSearchServerToolItem? outputToolSearchServerToolItem,
            global::OpenRouter.OutputMemoryServerToolItem? outputMemoryServerToolItem,
            global::OpenRouter.OutputMcpServerToolItem? outputMcpServerToolItem,
            global::OpenRouter.OutputSearchModelsServerToolItem? outputSearchModelsServerToolItem,
            global::OpenRouter.OutputFusionServerToolItem? outputFusionServerToolItem,
            global::OpenRouter.OutputAdvisorServerToolItem? outputAdvisorServerToolItem,
            global::OpenRouter.OutputSubagentServerToolItem? outputSubagentServerToolItem,
            global::OpenRouter.OutputFilesServerToolItem? outputFilesServerToolItem,
            global::OpenRouter.LocalShellCallItem? localShellCallItem,
            global::OpenRouter.LocalShellCallOutputItem? localShellCallOutputItem,
            global::OpenRouter.ShellCallItem? shellCallItem,
            global::OpenRouter.ShellCallOutputItem? shellCallOutputItem,
            global::OpenRouter.McpListToolsItem? mcpListToolsItem,
            global::OpenRouter.McpApprovalRequestItem? mcpApprovalRequestItem,
            global::OpenRouter.McpApprovalResponseItem? mcpApprovalResponseItem,
            global::OpenRouter.McpCallItem? mcpCallItem,
            global::OpenRouter.CustomToolCallItem? customToolCallItem,
            global::OpenRouter.CustomToolCallOutputItem? customToolCallOutputItem,
            global::OpenRouter.CompactionItem? compactionItem,
            global::OpenRouter.ContextCompactionItem? contextCompactionItem,
            global::OpenRouter.ItemReferenceItem? itemReferenceItem,
            global::OpenRouter.AdditionalToolsItem? additionalToolsItem,
            global::OpenRouter.AgentMessageItem? agentMessageItem
            )
        {
            ReasoningItem = reasoningItem;
            EasyInputMessage = easyInputMessage;
            InputMessageItem = inputMessageItem;
            FunctionCallItem = functionCallItem;
            FunctionCallOutputItem = functionCallOutputItem;
            ApplyPatchCallItem = applyPatchCallItem;
            ApplyPatchCallOutputItem = applyPatchCallOutputItem;
            InputsOneOf1Items7 = inputsOneOf1Items7;
            InputsOneOf1Items8 = inputsOneOf1Items8;
            OutputFunctionCallItem = outputFunctionCallItem;
            OutputCustomToolCallItem = outputCustomToolCallItem;
            OutputWebSearchCallItem = outputWebSearchCallItem;
            OutputFileSearchCallItem = outputFileSearchCallItem;
            OutputImageGenerationCallItem = outputImageGenerationCallItem;
            OutputCodeInterpreterCallItem = outputCodeInterpreterCallItem;
            OutputComputerCallItem = outputComputerCallItem;
            OutputDatetimeItem = outputDatetimeItem;
            OutputWebSearchServerToolItem = outputWebSearchServerToolItem;
            OutputCodeInterpreterServerToolItem = outputCodeInterpreterServerToolItem;
            OutputFileSearchServerToolItem = outputFileSearchServerToolItem;
            OutputImageGenerationServerToolItem = outputImageGenerationServerToolItem;
            OutputBrowserUseServerToolItem = outputBrowserUseServerToolItem;
            OutputBashServerToolItem = outputBashServerToolItem;
            OutputTextEditorServerToolItem = outputTextEditorServerToolItem;
            OutputApplyPatchServerToolItem = outputApplyPatchServerToolItem;
            OutputWebFetchServerToolItem = outputWebFetchServerToolItem;
            OutputToolSearchServerToolItem = outputToolSearchServerToolItem;
            OutputMemoryServerToolItem = outputMemoryServerToolItem;
            OutputMcpServerToolItem = outputMcpServerToolItem;
            OutputSearchModelsServerToolItem = outputSearchModelsServerToolItem;
            OutputFusionServerToolItem = outputFusionServerToolItem;
            OutputAdvisorServerToolItem = outputAdvisorServerToolItem;
            OutputSubagentServerToolItem = outputSubagentServerToolItem;
            OutputFilesServerToolItem = outputFilesServerToolItem;
            LocalShellCallItem = localShellCallItem;
            LocalShellCallOutputItem = localShellCallOutputItem;
            ShellCallItem = shellCallItem;
            ShellCallOutputItem = shellCallOutputItem;
            McpListToolsItem = mcpListToolsItem;
            McpApprovalRequestItem = mcpApprovalRequestItem;
            McpApprovalResponseItem = mcpApprovalResponseItem;
            McpCallItem = mcpCallItem;
            CustomToolCallItem = customToolCallItem;
            CustomToolCallOutputItem = customToolCallOutputItem;
            CompactionItem = compactionItem;
            ContextCompactionItem = contextCompactionItem;
            ItemReferenceItem = itemReferenceItem;
            AdditionalToolsItem = additionalToolsItem;
            AgentMessageItem = agentMessageItem;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AgentMessageItem as object ??
            AdditionalToolsItem as object ??
            ItemReferenceItem as object ??
            ContextCompactionItem as object ??
            CompactionItem as object ??
            CustomToolCallOutputItem as object ??
            CustomToolCallItem as object ??
            McpCallItem as object ??
            McpApprovalResponseItem as object ??
            McpApprovalRequestItem as object ??
            McpListToolsItem as object ??
            ShellCallOutputItem as object ??
            ShellCallItem as object ??
            LocalShellCallOutputItem as object ??
            LocalShellCallItem as object ??
            OutputFilesServerToolItem as object ??
            OutputSubagentServerToolItem as object ??
            OutputAdvisorServerToolItem as object ??
            OutputFusionServerToolItem as object ??
            OutputSearchModelsServerToolItem as object ??
            OutputMcpServerToolItem as object ??
            OutputMemoryServerToolItem as object ??
            OutputToolSearchServerToolItem as object ??
            OutputWebFetchServerToolItem as object ??
            OutputApplyPatchServerToolItem as object ??
            OutputTextEditorServerToolItem as object ??
            OutputBashServerToolItem as object ??
            OutputBrowserUseServerToolItem as object ??
            OutputImageGenerationServerToolItem as object ??
            OutputFileSearchServerToolItem as object ??
            OutputCodeInterpreterServerToolItem as object ??
            OutputWebSearchServerToolItem as object ??
            OutputDatetimeItem as object ??
            OutputComputerCallItem as object ??
            OutputCodeInterpreterCallItem as object ??
            OutputImageGenerationCallItem as object ??
            OutputFileSearchCallItem as object ??
            OutputWebSearchCallItem as object ??
            OutputCustomToolCallItem as object ??
            OutputFunctionCallItem as object ??
            InputsOneOf1Items8 as object ??
            InputsOneOf1Items7 as object ??
            ApplyPatchCallOutputItem as object ??
            ApplyPatchCallItem as object ??
            FunctionCallOutputItem as object ??
            FunctionCallItem as object ??
            InputMessageItem as object ??
            EasyInputMessage as object ??
            ReasoningItem as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ReasoningItem?.ToString() ??
            EasyInputMessage?.ToString() ??
            InputMessageItem?.ToString() ??
            FunctionCallItem?.ToString() ??
            FunctionCallOutputItem?.ToString() ??
            ApplyPatchCallItem?.ToString() ??
            ApplyPatchCallOutputItem?.ToString() ??
            InputsOneOf1Items7?.ToString() ??
            InputsOneOf1Items8?.ToString() ??
            OutputFunctionCallItem?.ToString() ??
            OutputCustomToolCallItem?.ToString() ??
            OutputWebSearchCallItem?.ToString() ??
            OutputFileSearchCallItem?.ToString() ??
            OutputImageGenerationCallItem?.ToString() ??
            OutputCodeInterpreterCallItem?.ToString() ??
            OutputComputerCallItem?.ToString() ??
            OutputDatetimeItem?.ToString() ??
            OutputWebSearchServerToolItem?.ToString() ??
            OutputCodeInterpreterServerToolItem?.ToString() ??
            OutputFileSearchServerToolItem?.ToString() ??
            OutputImageGenerationServerToolItem?.ToString() ??
            OutputBrowserUseServerToolItem?.ToString() ??
            OutputBashServerToolItem?.ToString() ??
            OutputTextEditorServerToolItem?.ToString() ??
            OutputApplyPatchServerToolItem?.ToString() ??
            OutputWebFetchServerToolItem?.ToString() ??
            OutputToolSearchServerToolItem?.ToString() ??
            OutputMemoryServerToolItem?.ToString() ??
            OutputMcpServerToolItem?.ToString() ??
            OutputSearchModelsServerToolItem?.ToString() ??
            OutputFusionServerToolItem?.ToString() ??
            OutputAdvisorServerToolItem?.ToString() ??
            OutputSubagentServerToolItem?.ToString() ??
            OutputFilesServerToolItem?.ToString() ??
            LocalShellCallItem?.ToString() ??
            LocalShellCallOutputItem?.ToString() ??
            ShellCallItem?.ToString() ??
            ShellCallOutputItem?.ToString() ??
            McpListToolsItem?.ToString() ??
            McpApprovalRequestItem?.ToString() ??
            McpApprovalResponseItem?.ToString() ??
            McpCallItem?.ToString() ??
            CustomToolCallItem?.ToString() ??
            CustomToolCallOutputItem?.ToString() ??
            CompactionItem?.ToString() ??
            ContextCompactionItem?.ToString() ??
            ItemReferenceItem?.ToString() ??
            AdditionalToolsItem?.ToString() ??
            AgentMessageItem?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && IsItemReferenceItem && !IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && IsAdditionalToolsItem && !IsAgentMessageItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsInputsOneOf1Items7 && !IsInputsOneOf1Items8 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsOutputFusionServerToolItem && !IsOutputAdvisorServerToolItem && !IsOutputSubagentServerToolItem && !IsOutputFilesServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsContextCompactionItem && !IsItemReferenceItem && !IsAdditionalToolsItem && IsAgentMessageItem;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ReasoningItem, TResult>? reasoningItem = null,
            global::System.Func<global::OpenRouter.EasyInputMessage, TResult>? easyInputMessage = null,
            global::System.Func<global::OpenRouter.InputMessageItem, TResult>? inputMessageItem = null,
            global::System.Func<global::OpenRouter.FunctionCallItem, TResult>? functionCallItem = null,
            global::System.Func<global::OpenRouter.FunctionCallOutputItem, TResult>? functionCallOutputItem = null,
            global::System.Func<global::OpenRouter.ApplyPatchCallItem, TResult>? applyPatchCallItem = null,
            global::System.Func<global::OpenRouter.ApplyPatchCallOutputItem, TResult>? applyPatchCallOutputItem = null,
            global::System.Func<global::OpenRouter.InputsOneOf1Items7, TResult>? inputsOneOf1Items7 = null,
            global::System.Func<global::OpenRouter.InputsOneOf1Items8, TResult>? inputsOneOf1Items8 = null,
            global::System.Func<global::OpenRouter.OutputFunctionCallItem, TResult>? outputFunctionCallItem = null,
            global::System.Func<global::OpenRouter.OutputCustomToolCallItem, TResult>? outputCustomToolCallItem = null,
            global::System.Func<global::OpenRouter.OutputWebSearchCallItem, TResult>? outputWebSearchCallItem = null,
            global::System.Func<global::OpenRouter.OutputFileSearchCallItem, TResult>? outputFileSearchCallItem = null,
            global::System.Func<global::OpenRouter.OutputImageGenerationCallItem, TResult>? outputImageGenerationCallItem = null,
            global::System.Func<global::OpenRouter.OutputCodeInterpreterCallItem, TResult>? outputCodeInterpreterCallItem = null,
            global::System.Func<global::OpenRouter.OutputComputerCallItem, TResult>? outputComputerCallItem = null,
            global::System.Func<global::OpenRouter.OutputDatetimeItem, TResult>? outputDatetimeItem = null,
            global::System.Func<global::OpenRouter.OutputWebSearchServerToolItem, TResult>? outputWebSearchServerToolItem = null,
            global::System.Func<global::OpenRouter.OutputCodeInterpreterServerToolItem, TResult>? outputCodeInterpreterServerToolItem = null,
            global::System.Func<global::OpenRouter.OutputFileSearchServerToolItem, TResult>? outputFileSearchServerToolItem = null,
            global::System.Func<global::OpenRouter.OutputImageGenerationServerToolItem, TResult>? outputImageGenerationServerToolItem = null,
            global::System.Func<global::OpenRouter.OutputBrowserUseServerToolItem, TResult>? outputBrowserUseServerToolItem = null,
            global::System.Func<global::OpenRouter.OutputBashServerToolItem, TResult>? outputBashServerToolItem = null,
            global::System.Func<global::OpenRouter.OutputTextEditorServerToolItem, TResult>? outputTextEditorServerToolItem = null,
            global::System.Func<global::OpenRouter.OutputApplyPatchServerToolItem, TResult>? outputApplyPatchServerToolItem = null,
            global::System.Func<global::OpenRouter.OutputWebFetchServerToolItem, TResult>? outputWebFetchServerToolItem = null,
            global::System.Func<global::OpenRouter.OutputToolSearchServerToolItem, TResult>? outputToolSearchServerToolItem = null,
            global::System.Func<global::OpenRouter.OutputMemoryServerToolItem, TResult>? outputMemoryServerToolItem = null,
            global::System.Func<global::OpenRouter.OutputMcpServerToolItem, TResult>? outputMcpServerToolItem = null,
            global::System.Func<global::OpenRouter.OutputSearchModelsServerToolItem, TResult>? outputSearchModelsServerToolItem = null,
            global::System.Func<global::OpenRouter.OutputFusionServerToolItem, TResult>? outputFusionServerToolItem = null,
            global::System.Func<global::OpenRouter.OutputAdvisorServerToolItem, TResult>? outputAdvisorServerToolItem = null,
            global::System.Func<global::OpenRouter.OutputSubagentServerToolItem, TResult>? outputSubagentServerToolItem = null,
            global::System.Func<global::OpenRouter.OutputFilesServerToolItem, TResult>? outputFilesServerToolItem = null,
            global::System.Func<global::OpenRouter.LocalShellCallItem, TResult>? localShellCallItem = null,
            global::System.Func<global::OpenRouter.LocalShellCallOutputItem, TResult>? localShellCallOutputItem = null,
            global::System.Func<global::OpenRouter.ShellCallItem, TResult>? shellCallItem = null,
            global::System.Func<global::OpenRouter.ShellCallOutputItem, TResult>? shellCallOutputItem = null,
            global::System.Func<global::OpenRouter.McpListToolsItem, TResult>? mcpListToolsItem = null,
            global::System.Func<global::OpenRouter.McpApprovalRequestItem, TResult>? mcpApprovalRequestItem = null,
            global::System.Func<global::OpenRouter.McpApprovalResponseItem, TResult>? mcpApprovalResponseItem = null,
            global::System.Func<global::OpenRouter.McpCallItem, TResult>? mcpCallItem = null,
            global::System.Func<global::OpenRouter.CustomToolCallItem, TResult>? customToolCallItem = null,
            global::System.Func<global::OpenRouter.CustomToolCallOutputItem, TResult>? customToolCallOutputItem = null,
            global::System.Func<global::OpenRouter.CompactionItem, TResult>? compactionItem = null,
            global::System.Func<global::OpenRouter.ContextCompactionItem, TResult>? contextCompactionItem = null,
            global::System.Func<global::OpenRouter.ItemReferenceItem, TResult>? itemReferenceItem = null,
            global::System.Func<global::OpenRouter.AdditionalToolsItem, TResult>? additionalToolsItem = null,
            global::System.Func<global::OpenRouter.AgentMessageItem, TResult>? agentMessageItem = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ReasoningItem is { } __value0 && reasoningItem != null)
            {
                return reasoningItem(__value0);
            }
            else if (EasyInputMessage is { } __value1 && easyInputMessage != null)
            {
                return easyInputMessage(__value1);
            }
            else if (InputMessageItem is { } __value2 && inputMessageItem != null)
            {
                return inputMessageItem(__value2);
            }
            else if (FunctionCallItem is { } __value3 && functionCallItem != null)
            {
                return functionCallItem(__value3);
            }
            else if (FunctionCallOutputItem is { } __value4 && functionCallOutputItem != null)
            {
                return functionCallOutputItem(__value4);
            }
            else if (ApplyPatchCallItem is { } __value5 && applyPatchCallItem != null)
            {
                return applyPatchCallItem(__value5);
            }
            else if (ApplyPatchCallOutputItem is { } __value6 && applyPatchCallOutputItem != null)
            {
                return applyPatchCallOutputItem(__value6);
            }
            else if (InputsOneOf1Items7 is { } __value7 && inputsOneOf1Items7 != null)
            {
                return inputsOneOf1Items7(__value7);
            }
            else if (InputsOneOf1Items8 is { } __value8 && inputsOneOf1Items8 != null)
            {
                return inputsOneOf1Items8(__value8);
            }
            else if (OutputFunctionCallItem is { } __value9 && outputFunctionCallItem != null)
            {
                return outputFunctionCallItem(__value9);
            }
            else if (OutputCustomToolCallItem is { } __value10 && outputCustomToolCallItem != null)
            {
                return outputCustomToolCallItem(__value10);
            }
            else if (OutputWebSearchCallItem is { } __value11 && outputWebSearchCallItem != null)
            {
                return outputWebSearchCallItem(__value11);
            }
            else if (OutputFileSearchCallItem is { } __value12 && outputFileSearchCallItem != null)
            {
                return outputFileSearchCallItem(__value12);
            }
            else if (OutputImageGenerationCallItem is { } __value13 && outputImageGenerationCallItem != null)
            {
                return outputImageGenerationCallItem(__value13);
            }
            else if (OutputCodeInterpreterCallItem is { } __value14 && outputCodeInterpreterCallItem != null)
            {
                return outputCodeInterpreterCallItem(__value14);
            }
            else if (OutputComputerCallItem is { } __value15 && outputComputerCallItem != null)
            {
                return outputComputerCallItem(__value15);
            }
            else if (OutputDatetimeItem is { } __value16 && outputDatetimeItem != null)
            {
                return outputDatetimeItem(__value16);
            }
            else if (OutputWebSearchServerToolItem is { } __value17 && outputWebSearchServerToolItem != null)
            {
                return outputWebSearchServerToolItem(__value17);
            }
            else if (OutputCodeInterpreterServerToolItem is { } __value18 && outputCodeInterpreterServerToolItem != null)
            {
                return outputCodeInterpreterServerToolItem(__value18);
            }
            else if (OutputFileSearchServerToolItem is { } __value19 && outputFileSearchServerToolItem != null)
            {
                return outputFileSearchServerToolItem(__value19);
            }
            else if (OutputImageGenerationServerToolItem is { } __value20 && outputImageGenerationServerToolItem != null)
            {
                return outputImageGenerationServerToolItem(__value20);
            }
            else if (OutputBrowserUseServerToolItem is { } __value21 && outputBrowserUseServerToolItem != null)
            {
                return outputBrowserUseServerToolItem(__value21);
            }
            else if (OutputBashServerToolItem is { } __value22 && outputBashServerToolItem != null)
            {
                return outputBashServerToolItem(__value22);
            }
            else if (OutputTextEditorServerToolItem is { } __value23 && outputTextEditorServerToolItem != null)
            {
                return outputTextEditorServerToolItem(__value23);
            }
            else if (OutputApplyPatchServerToolItem is { } __value24 && outputApplyPatchServerToolItem != null)
            {
                return outputApplyPatchServerToolItem(__value24);
            }
            else if (OutputWebFetchServerToolItem is { } __value25 && outputWebFetchServerToolItem != null)
            {
                return outputWebFetchServerToolItem(__value25);
            }
            else if (OutputToolSearchServerToolItem is { } __value26 && outputToolSearchServerToolItem != null)
            {
                return outputToolSearchServerToolItem(__value26);
            }
            else if (OutputMemoryServerToolItem is { } __value27 && outputMemoryServerToolItem != null)
            {
                return outputMemoryServerToolItem(__value27);
            }
            else if (OutputMcpServerToolItem is { } __value28 && outputMcpServerToolItem != null)
            {
                return outputMcpServerToolItem(__value28);
            }
            else if (OutputSearchModelsServerToolItem is { } __value29 && outputSearchModelsServerToolItem != null)
            {
                return outputSearchModelsServerToolItem(__value29);
            }
            else if (OutputFusionServerToolItem is { } __value30 && outputFusionServerToolItem != null)
            {
                return outputFusionServerToolItem(__value30);
            }
            else if (OutputAdvisorServerToolItem is { } __value31 && outputAdvisorServerToolItem != null)
            {
                return outputAdvisorServerToolItem(__value31);
            }
            else if (OutputSubagentServerToolItem is { } __value32 && outputSubagentServerToolItem != null)
            {
                return outputSubagentServerToolItem(__value32);
            }
            else if (OutputFilesServerToolItem is { } __value33 && outputFilesServerToolItem != null)
            {
                return outputFilesServerToolItem(__value33);
            }
            else if (LocalShellCallItem is { } __value34 && localShellCallItem != null)
            {
                return localShellCallItem(__value34);
            }
            else if (LocalShellCallOutputItem is { } __value35 && localShellCallOutputItem != null)
            {
                return localShellCallOutputItem(__value35);
            }
            else if (ShellCallItem is { } __value36 && shellCallItem != null)
            {
                return shellCallItem(__value36);
            }
            else if (ShellCallOutputItem is { } __value37 && shellCallOutputItem != null)
            {
                return shellCallOutputItem(__value37);
            }
            else if (McpListToolsItem is { } __value38 && mcpListToolsItem != null)
            {
                return mcpListToolsItem(__value38);
            }
            else if (McpApprovalRequestItem is { } __value39 && mcpApprovalRequestItem != null)
            {
                return mcpApprovalRequestItem(__value39);
            }
            else if (McpApprovalResponseItem is { } __value40 && mcpApprovalResponseItem != null)
            {
                return mcpApprovalResponseItem(__value40);
            }
            else if (McpCallItem is { } __value41 && mcpCallItem != null)
            {
                return mcpCallItem(__value41);
            }
            else if (CustomToolCallItem is { } __value42 && customToolCallItem != null)
            {
                return customToolCallItem(__value42);
            }
            else if (CustomToolCallOutputItem is { } __value43 && customToolCallOutputItem != null)
            {
                return customToolCallOutputItem(__value43);
            }
            else if (CompactionItem is { } __value44 && compactionItem != null)
            {
                return compactionItem(__value44);
            }
            else if (ContextCompactionItem is { } __value45 && contextCompactionItem != null)
            {
                return contextCompactionItem(__value45);
            }
            else if (ItemReferenceItem is { } __value46 && itemReferenceItem != null)
            {
                return itemReferenceItem(__value46);
            }
            else if (AdditionalToolsItem is { } __value47 && additionalToolsItem != null)
            {
                return additionalToolsItem(__value47);
            }
            else if (AgentMessageItem is { } __value48 && agentMessageItem != null)
            {
                return agentMessageItem(__value48);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ReasoningItem>? reasoningItem = null,

            global::System.Action<global::OpenRouter.EasyInputMessage>? easyInputMessage = null,

            global::System.Action<global::OpenRouter.InputMessageItem>? inputMessageItem = null,

            global::System.Action<global::OpenRouter.FunctionCallItem>? functionCallItem = null,

            global::System.Action<global::OpenRouter.FunctionCallOutputItem>? functionCallOutputItem = null,

            global::System.Action<global::OpenRouter.ApplyPatchCallItem>? applyPatchCallItem = null,

            global::System.Action<global::OpenRouter.ApplyPatchCallOutputItem>? applyPatchCallOutputItem = null,

            global::System.Action<global::OpenRouter.InputsOneOf1Items7>? inputsOneOf1Items7 = null,

            global::System.Action<global::OpenRouter.InputsOneOf1Items8>? inputsOneOf1Items8 = null,

            global::System.Action<global::OpenRouter.OutputFunctionCallItem>? outputFunctionCallItem = null,

            global::System.Action<global::OpenRouter.OutputCustomToolCallItem>? outputCustomToolCallItem = null,

            global::System.Action<global::OpenRouter.OutputWebSearchCallItem>? outputWebSearchCallItem = null,

            global::System.Action<global::OpenRouter.OutputFileSearchCallItem>? outputFileSearchCallItem = null,

            global::System.Action<global::OpenRouter.OutputImageGenerationCallItem>? outputImageGenerationCallItem = null,

            global::System.Action<global::OpenRouter.OutputCodeInterpreterCallItem>? outputCodeInterpreterCallItem = null,

            global::System.Action<global::OpenRouter.OutputComputerCallItem>? outputComputerCallItem = null,

            global::System.Action<global::OpenRouter.OutputDatetimeItem>? outputDatetimeItem = null,

            global::System.Action<global::OpenRouter.OutputWebSearchServerToolItem>? outputWebSearchServerToolItem = null,

            global::System.Action<global::OpenRouter.OutputCodeInterpreterServerToolItem>? outputCodeInterpreterServerToolItem = null,

            global::System.Action<global::OpenRouter.OutputFileSearchServerToolItem>? outputFileSearchServerToolItem = null,

            global::System.Action<global::OpenRouter.OutputImageGenerationServerToolItem>? outputImageGenerationServerToolItem = null,

            global::System.Action<global::OpenRouter.OutputBrowserUseServerToolItem>? outputBrowserUseServerToolItem = null,

            global::System.Action<global::OpenRouter.OutputBashServerToolItem>? outputBashServerToolItem = null,

            global::System.Action<global::OpenRouter.OutputTextEditorServerToolItem>? outputTextEditorServerToolItem = null,

            global::System.Action<global::OpenRouter.OutputApplyPatchServerToolItem>? outputApplyPatchServerToolItem = null,

            global::System.Action<global::OpenRouter.OutputWebFetchServerToolItem>? outputWebFetchServerToolItem = null,

            global::System.Action<global::OpenRouter.OutputToolSearchServerToolItem>? outputToolSearchServerToolItem = null,

            global::System.Action<global::OpenRouter.OutputMemoryServerToolItem>? outputMemoryServerToolItem = null,

            global::System.Action<global::OpenRouter.OutputMcpServerToolItem>? outputMcpServerToolItem = null,

            global::System.Action<global::OpenRouter.OutputSearchModelsServerToolItem>? outputSearchModelsServerToolItem = null,

            global::System.Action<global::OpenRouter.OutputFusionServerToolItem>? outputFusionServerToolItem = null,

            global::System.Action<global::OpenRouter.OutputAdvisorServerToolItem>? outputAdvisorServerToolItem = null,

            global::System.Action<global::OpenRouter.OutputSubagentServerToolItem>? outputSubagentServerToolItem = null,

            global::System.Action<global::OpenRouter.OutputFilesServerToolItem>? outputFilesServerToolItem = null,

            global::System.Action<global::OpenRouter.LocalShellCallItem>? localShellCallItem = null,

            global::System.Action<global::OpenRouter.LocalShellCallOutputItem>? localShellCallOutputItem = null,

            global::System.Action<global::OpenRouter.ShellCallItem>? shellCallItem = null,

            global::System.Action<global::OpenRouter.ShellCallOutputItem>? shellCallOutputItem = null,

            global::System.Action<global::OpenRouter.McpListToolsItem>? mcpListToolsItem = null,

            global::System.Action<global::OpenRouter.McpApprovalRequestItem>? mcpApprovalRequestItem = null,

            global::System.Action<global::OpenRouter.McpApprovalResponseItem>? mcpApprovalResponseItem = null,

            global::System.Action<global::OpenRouter.McpCallItem>? mcpCallItem = null,

            global::System.Action<global::OpenRouter.CustomToolCallItem>? customToolCallItem = null,

            global::System.Action<global::OpenRouter.CustomToolCallOutputItem>? customToolCallOutputItem = null,

            global::System.Action<global::OpenRouter.CompactionItem>? compactionItem = null,

            global::System.Action<global::OpenRouter.ContextCompactionItem>? contextCompactionItem = null,

            global::System.Action<global::OpenRouter.ItemReferenceItem>? itemReferenceItem = null,

            global::System.Action<global::OpenRouter.AdditionalToolsItem>? additionalToolsItem = null,

            global::System.Action<global::OpenRouter.AgentMessageItem>? agentMessageItem = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ReasoningItem is { } __value0)
            {
                reasoningItem?.Invoke(__value0);
            }
            else if (EasyInputMessage is { } __value1)
            {
                easyInputMessage?.Invoke(__value1);
            }
            else if (InputMessageItem is { } __value2)
            {
                inputMessageItem?.Invoke(__value2);
            }
            else if (FunctionCallItem is { } __value3)
            {
                functionCallItem?.Invoke(__value3);
            }
            else if (FunctionCallOutputItem is { } __value4)
            {
                functionCallOutputItem?.Invoke(__value4);
            }
            else if (ApplyPatchCallItem is { } __value5)
            {
                applyPatchCallItem?.Invoke(__value5);
            }
            else if (ApplyPatchCallOutputItem is { } __value6)
            {
                applyPatchCallOutputItem?.Invoke(__value6);
            }
            else if (InputsOneOf1Items7 is { } __value7)
            {
                inputsOneOf1Items7?.Invoke(__value7);
            }
            else if (InputsOneOf1Items8 is { } __value8)
            {
                inputsOneOf1Items8?.Invoke(__value8);
            }
            else if (OutputFunctionCallItem is { } __value9)
            {
                outputFunctionCallItem?.Invoke(__value9);
            }
            else if (OutputCustomToolCallItem is { } __value10)
            {
                outputCustomToolCallItem?.Invoke(__value10);
            }
            else if (OutputWebSearchCallItem is { } __value11)
            {
                outputWebSearchCallItem?.Invoke(__value11);
            }
            else if (OutputFileSearchCallItem is { } __value12)
            {
                outputFileSearchCallItem?.Invoke(__value12);
            }
            else if (OutputImageGenerationCallItem is { } __value13)
            {
                outputImageGenerationCallItem?.Invoke(__value13);
            }
            else if (OutputCodeInterpreterCallItem is { } __value14)
            {
                outputCodeInterpreterCallItem?.Invoke(__value14);
            }
            else if (OutputComputerCallItem is { } __value15)
            {
                outputComputerCallItem?.Invoke(__value15);
            }
            else if (OutputDatetimeItem is { } __value16)
            {
                outputDatetimeItem?.Invoke(__value16);
            }
            else if (OutputWebSearchServerToolItem is { } __value17)
            {
                outputWebSearchServerToolItem?.Invoke(__value17);
            }
            else if (OutputCodeInterpreterServerToolItem is { } __value18)
            {
                outputCodeInterpreterServerToolItem?.Invoke(__value18);
            }
            else if (OutputFileSearchServerToolItem is { } __value19)
            {
                outputFileSearchServerToolItem?.Invoke(__value19);
            }
            else if (OutputImageGenerationServerToolItem is { } __value20)
            {
                outputImageGenerationServerToolItem?.Invoke(__value20);
            }
            else if (OutputBrowserUseServerToolItem is { } __value21)
            {
                outputBrowserUseServerToolItem?.Invoke(__value21);
            }
            else if (OutputBashServerToolItem is { } __value22)
            {
                outputBashServerToolItem?.Invoke(__value22);
            }
            else if (OutputTextEditorServerToolItem is { } __value23)
            {
                outputTextEditorServerToolItem?.Invoke(__value23);
            }
            else if (OutputApplyPatchServerToolItem is { } __value24)
            {
                outputApplyPatchServerToolItem?.Invoke(__value24);
            }
            else if (OutputWebFetchServerToolItem is { } __value25)
            {
                outputWebFetchServerToolItem?.Invoke(__value25);
            }
            else if (OutputToolSearchServerToolItem is { } __value26)
            {
                outputToolSearchServerToolItem?.Invoke(__value26);
            }
            else if (OutputMemoryServerToolItem is { } __value27)
            {
                outputMemoryServerToolItem?.Invoke(__value27);
            }
            else if (OutputMcpServerToolItem is { } __value28)
            {
                outputMcpServerToolItem?.Invoke(__value28);
            }
            else if (OutputSearchModelsServerToolItem is { } __value29)
            {
                outputSearchModelsServerToolItem?.Invoke(__value29);
            }
            else if (OutputFusionServerToolItem is { } __value30)
            {
                outputFusionServerToolItem?.Invoke(__value30);
            }
            else if (OutputAdvisorServerToolItem is { } __value31)
            {
                outputAdvisorServerToolItem?.Invoke(__value31);
            }
            else if (OutputSubagentServerToolItem is { } __value32)
            {
                outputSubagentServerToolItem?.Invoke(__value32);
            }
            else if (OutputFilesServerToolItem is { } __value33)
            {
                outputFilesServerToolItem?.Invoke(__value33);
            }
            else if (LocalShellCallItem is { } __value34)
            {
                localShellCallItem?.Invoke(__value34);
            }
            else if (LocalShellCallOutputItem is { } __value35)
            {
                localShellCallOutputItem?.Invoke(__value35);
            }
            else if (ShellCallItem is { } __value36)
            {
                shellCallItem?.Invoke(__value36);
            }
            else if (ShellCallOutputItem is { } __value37)
            {
                shellCallOutputItem?.Invoke(__value37);
            }
            else if (McpListToolsItem is { } __value38)
            {
                mcpListToolsItem?.Invoke(__value38);
            }
            else if (McpApprovalRequestItem is { } __value39)
            {
                mcpApprovalRequestItem?.Invoke(__value39);
            }
            else if (McpApprovalResponseItem is { } __value40)
            {
                mcpApprovalResponseItem?.Invoke(__value40);
            }
            else if (McpCallItem is { } __value41)
            {
                mcpCallItem?.Invoke(__value41);
            }
            else if (CustomToolCallItem is { } __value42)
            {
                customToolCallItem?.Invoke(__value42);
            }
            else if (CustomToolCallOutputItem is { } __value43)
            {
                customToolCallOutputItem?.Invoke(__value43);
            }
            else if (CompactionItem is { } __value44)
            {
                compactionItem?.Invoke(__value44);
            }
            else if (ContextCompactionItem is { } __value45)
            {
                contextCompactionItem?.Invoke(__value45);
            }
            else if (ItemReferenceItem is { } __value46)
            {
                itemReferenceItem?.Invoke(__value46);
            }
            else if (AdditionalToolsItem is { } __value47)
            {
                additionalToolsItem?.Invoke(__value47);
            }
            else if (AgentMessageItem is { } __value48)
            {
                agentMessageItem?.Invoke(__value48);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ReasoningItem>? reasoningItem = null,
            global::System.Action<global::OpenRouter.EasyInputMessage>? easyInputMessage = null,
            global::System.Action<global::OpenRouter.InputMessageItem>? inputMessageItem = null,
            global::System.Action<global::OpenRouter.FunctionCallItem>? functionCallItem = null,
            global::System.Action<global::OpenRouter.FunctionCallOutputItem>? functionCallOutputItem = null,
            global::System.Action<global::OpenRouter.ApplyPatchCallItem>? applyPatchCallItem = null,
            global::System.Action<global::OpenRouter.ApplyPatchCallOutputItem>? applyPatchCallOutputItem = null,
            global::System.Action<global::OpenRouter.InputsOneOf1Items7>? inputsOneOf1Items7 = null,
            global::System.Action<global::OpenRouter.InputsOneOf1Items8>? inputsOneOf1Items8 = null,
            global::System.Action<global::OpenRouter.OutputFunctionCallItem>? outputFunctionCallItem = null,
            global::System.Action<global::OpenRouter.OutputCustomToolCallItem>? outputCustomToolCallItem = null,
            global::System.Action<global::OpenRouter.OutputWebSearchCallItem>? outputWebSearchCallItem = null,
            global::System.Action<global::OpenRouter.OutputFileSearchCallItem>? outputFileSearchCallItem = null,
            global::System.Action<global::OpenRouter.OutputImageGenerationCallItem>? outputImageGenerationCallItem = null,
            global::System.Action<global::OpenRouter.OutputCodeInterpreterCallItem>? outputCodeInterpreterCallItem = null,
            global::System.Action<global::OpenRouter.OutputComputerCallItem>? outputComputerCallItem = null,
            global::System.Action<global::OpenRouter.OutputDatetimeItem>? outputDatetimeItem = null,
            global::System.Action<global::OpenRouter.OutputWebSearchServerToolItem>? outputWebSearchServerToolItem = null,
            global::System.Action<global::OpenRouter.OutputCodeInterpreterServerToolItem>? outputCodeInterpreterServerToolItem = null,
            global::System.Action<global::OpenRouter.OutputFileSearchServerToolItem>? outputFileSearchServerToolItem = null,
            global::System.Action<global::OpenRouter.OutputImageGenerationServerToolItem>? outputImageGenerationServerToolItem = null,
            global::System.Action<global::OpenRouter.OutputBrowserUseServerToolItem>? outputBrowserUseServerToolItem = null,
            global::System.Action<global::OpenRouter.OutputBashServerToolItem>? outputBashServerToolItem = null,
            global::System.Action<global::OpenRouter.OutputTextEditorServerToolItem>? outputTextEditorServerToolItem = null,
            global::System.Action<global::OpenRouter.OutputApplyPatchServerToolItem>? outputApplyPatchServerToolItem = null,
            global::System.Action<global::OpenRouter.OutputWebFetchServerToolItem>? outputWebFetchServerToolItem = null,
            global::System.Action<global::OpenRouter.OutputToolSearchServerToolItem>? outputToolSearchServerToolItem = null,
            global::System.Action<global::OpenRouter.OutputMemoryServerToolItem>? outputMemoryServerToolItem = null,
            global::System.Action<global::OpenRouter.OutputMcpServerToolItem>? outputMcpServerToolItem = null,
            global::System.Action<global::OpenRouter.OutputSearchModelsServerToolItem>? outputSearchModelsServerToolItem = null,
            global::System.Action<global::OpenRouter.OutputFusionServerToolItem>? outputFusionServerToolItem = null,
            global::System.Action<global::OpenRouter.OutputAdvisorServerToolItem>? outputAdvisorServerToolItem = null,
            global::System.Action<global::OpenRouter.OutputSubagentServerToolItem>? outputSubagentServerToolItem = null,
            global::System.Action<global::OpenRouter.OutputFilesServerToolItem>? outputFilesServerToolItem = null,
            global::System.Action<global::OpenRouter.LocalShellCallItem>? localShellCallItem = null,
            global::System.Action<global::OpenRouter.LocalShellCallOutputItem>? localShellCallOutputItem = null,
            global::System.Action<global::OpenRouter.ShellCallItem>? shellCallItem = null,
            global::System.Action<global::OpenRouter.ShellCallOutputItem>? shellCallOutputItem = null,
            global::System.Action<global::OpenRouter.McpListToolsItem>? mcpListToolsItem = null,
            global::System.Action<global::OpenRouter.McpApprovalRequestItem>? mcpApprovalRequestItem = null,
            global::System.Action<global::OpenRouter.McpApprovalResponseItem>? mcpApprovalResponseItem = null,
            global::System.Action<global::OpenRouter.McpCallItem>? mcpCallItem = null,
            global::System.Action<global::OpenRouter.CustomToolCallItem>? customToolCallItem = null,
            global::System.Action<global::OpenRouter.CustomToolCallOutputItem>? customToolCallOutputItem = null,
            global::System.Action<global::OpenRouter.CompactionItem>? compactionItem = null,
            global::System.Action<global::OpenRouter.ContextCompactionItem>? contextCompactionItem = null,
            global::System.Action<global::OpenRouter.ItemReferenceItem>? itemReferenceItem = null,
            global::System.Action<global::OpenRouter.AdditionalToolsItem>? additionalToolsItem = null,
            global::System.Action<global::OpenRouter.AgentMessageItem>? agentMessageItem = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ReasoningItem is { } __value0)
            {
                reasoningItem?.Invoke(__value0);
            }
            else if (EasyInputMessage is { } __value1)
            {
                easyInputMessage?.Invoke(__value1);
            }
            else if (InputMessageItem is { } __value2)
            {
                inputMessageItem?.Invoke(__value2);
            }
            else if (FunctionCallItem is { } __value3)
            {
                functionCallItem?.Invoke(__value3);
            }
            else if (FunctionCallOutputItem is { } __value4)
            {
                functionCallOutputItem?.Invoke(__value4);
            }
            else if (ApplyPatchCallItem is { } __value5)
            {
                applyPatchCallItem?.Invoke(__value5);
            }
            else if (ApplyPatchCallOutputItem is { } __value6)
            {
                applyPatchCallOutputItem?.Invoke(__value6);
            }
            else if (InputsOneOf1Items7 is { } __value7)
            {
                inputsOneOf1Items7?.Invoke(__value7);
            }
            else if (InputsOneOf1Items8 is { } __value8)
            {
                inputsOneOf1Items8?.Invoke(__value8);
            }
            else if (OutputFunctionCallItem is { } __value9)
            {
                outputFunctionCallItem?.Invoke(__value9);
            }
            else if (OutputCustomToolCallItem is { } __value10)
            {
                outputCustomToolCallItem?.Invoke(__value10);
            }
            else if (OutputWebSearchCallItem is { } __value11)
            {
                outputWebSearchCallItem?.Invoke(__value11);
            }
            else if (OutputFileSearchCallItem is { } __value12)
            {
                outputFileSearchCallItem?.Invoke(__value12);
            }
            else if (OutputImageGenerationCallItem is { } __value13)
            {
                outputImageGenerationCallItem?.Invoke(__value13);
            }
            else if (OutputCodeInterpreterCallItem is { } __value14)
            {
                outputCodeInterpreterCallItem?.Invoke(__value14);
            }
            else if (OutputComputerCallItem is { } __value15)
            {
                outputComputerCallItem?.Invoke(__value15);
            }
            else if (OutputDatetimeItem is { } __value16)
            {
                outputDatetimeItem?.Invoke(__value16);
            }
            else if (OutputWebSearchServerToolItem is { } __value17)
            {
                outputWebSearchServerToolItem?.Invoke(__value17);
            }
            else if (OutputCodeInterpreterServerToolItem is { } __value18)
            {
                outputCodeInterpreterServerToolItem?.Invoke(__value18);
            }
            else if (OutputFileSearchServerToolItem is { } __value19)
            {
                outputFileSearchServerToolItem?.Invoke(__value19);
            }
            else if (OutputImageGenerationServerToolItem is { } __value20)
            {
                outputImageGenerationServerToolItem?.Invoke(__value20);
            }
            else if (OutputBrowserUseServerToolItem is { } __value21)
            {
                outputBrowserUseServerToolItem?.Invoke(__value21);
            }
            else if (OutputBashServerToolItem is { } __value22)
            {
                outputBashServerToolItem?.Invoke(__value22);
            }
            else if (OutputTextEditorServerToolItem is { } __value23)
            {
                outputTextEditorServerToolItem?.Invoke(__value23);
            }
            else if (OutputApplyPatchServerToolItem is { } __value24)
            {
                outputApplyPatchServerToolItem?.Invoke(__value24);
            }
            else if (OutputWebFetchServerToolItem is { } __value25)
            {
                outputWebFetchServerToolItem?.Invoke(__value25);
            }
            else if (OutputToolSearchServerToolItem is { } __value26)
            {
                outputToolSearchServerToolItem?.Invoke(__value26);
            }
            else if (OutputMemoryServerToolItem is { } __value27)
            {
                outputMemoryServerToolItem?.Invoke(__value27);
            }
            else if (OutputMcpServerToolItem is { } __value28)
            {
                outputMcpServerToolItem?.Invoke(__value28);
            }
            else if (OutputSearchModelsServerToolItem is { } __value29)
            {
                outputSearchModelsServerToolItem?.Invoke(__value29);
            }
            else if (OutputFusionServerToolItem is { } __value30)
            {
                outputFusionServerToolItem?.Invoke(__value30);
            }
            else if (OutputAdvisorServerToolItem is { } __value31)
            {
                outputAdvisorServerToolItem?.Invoke(__value31);
            }
            else if (OutputSubagentServerToolItem is { } __value32)
            {
                outputSubagentServerToolItem?.Invoke(__value32);
            }
            else if (OutputFilesServerToolItem is { } __value33)
            {
                outputFilesServerToolItem?.Invoke(__value33);
            }
            else if (LocalShellCallItem is { } __value34)
            {
                localShellCallItem?.Invoke(__value34);
            }
            else if (LocalShellCallOutputItem is { } __value35)
            {
                localShellCallOutputItem?.Invoke(__value35);
            }
            else if (ShellCallItem is { } __value36)
            {
                shellCallItem?.Invoke(__value36);
            }
            else if (ShellCallOutputItem is { } __value37)
            {
                shellCallOutputItem?.Invoke(__value37);
            }
            else if (McpListToolsItem is { } __value38)
            {
                mcpListToolsItem?.Invoke(__value38);
            }
            else if (McpApprovalRequestItem is { } __value39)
            {
                mcpApprovalRequestItem?.Invoke(__value39);
            }
            else if (McpApprovalResponseItem is { } __value40)
            {
                mcpApprovalResponseItem?.Invoke(__value40);
            }
            else if (McpCallItem is { } __value41)
            {
                mcpCallItem?.Invoke(__value41);
            }
            else if (CustomToolCallItem is { } __value42)
            {
                customToolCallItem?.Invoke(__value42);
            }
            else if (CustomToolCallOutputItem is { } __value43)
            {
                customToolCallOutputItem?.Invoke(__value43);
            }
            else if (CompactionItem is { } __value44)
            {
                compactionItem?.Invoke(__value44);
            }
            else if (ContextCompactionItem is { } __value45)
            {
                contextCompactionItem?.Invoke(__value45);
            }
            else if (ItemReferenceItem is { } __value46)
            {
                itemReferenceItem?.Invoke(__value46);
            }
            else if (AdditionalToolsItem is { } __value47)
            {
                additionalToolsItem?.Invoke(__value47);
            }
            else if (AgentMessageItem is { } __value48)
            {
                agentMessageItem?.Invoke(__value48);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ReasoningItem,
                typeof(global::OpenRouter.ReasoningItem),
                EasyInputMessage,
                typeof(global::OpenRouter.EasyInputMessage),
                InputMessageItem,
                typeof(global::OpenRouter.InputMessageItem),
                FunctionCallItem,
                typeof(global::OpenRouter.FunctionCallItem),
                FunctionCallOutputItem,
                typeof(global::OpenRouter.FunctionCallOutputItem),
                ApplyPatchCallItem,
                typeof(global::OpenRouter.ApplyPatchCallItem),
                ApplyPatchCallOutputItem,
                typeof(global::OpenRouter.ApplyPatchCallOutputItem),
                InputsOneOf1Items7,
                typeof(global::OpenRouter.InputsOneOf1Items7),
                InputsOneOf1Items8,
                typeof(global::OpenRouter.InputsOneOf1Items8),
                OutputFunctionCallItem,
                typeof(global::OpenRouter.OutputFunctionCallItem),
                OutputCustomToolCallItem,
                typeof(global::OpenRouter.OutputCustomToolCallItem),
                OutputWebSearchCallItem,
                typeof(global::OpenRouter.OutputWebSearchCallItem),
                OutputFileSearchCallItem,
                typeof(global::OpenRouter.OutputFileSearchCallItem),
                OutputImageGenerationCallItem,
                typeof(global::OpenRouter.OutputImageGenerationCallItem),
                OutputCodeInterpreterCallItem,
                typeof(global::OpenRouter.OutputCodeInterpreterCallItem),
                OutputComputerCallItem,
                typeof(global::OpenRouter.OutputComputerCallItem),
                OutputDatetimeItem,
                typeof(global::OpenRouter.OutputDatetimeItem),
                OutputWebSearchServerToolItem,
                typeof(global::OpenRouter.OutputWebSearchServerToolItem),
                OutputCodeInterpreterServerToolItem,
                typeof(global::OpenRouter.OutputCodeInterpreterServerToolItem),
                OutputFileSearchServerToolItem,
                typeof(global::OpenRouter.OutputFileSearchServerToolItem),
                OutputImageGenerationServerToolItem,
                typeof(global::OpenRouter.OutputImageGenerationServerToolItem),
                OutputBrowserUseServerToolItem,
                typeof(global::OpenRouter.OutputBrowserUseServerToolItem),
                OutputBashServerToolItem,
                typeof(global::OpenRouter.OutputBashServerToolItem),
                OutputTextEditorServerToolItem,
                typeof(global::OpenRouter.OutputTextEditorServerToolItem),
                OutputApplyPatchServerToolItem,
                typeof(global::OpenRouter.OutputApplyPatchServerToolItem),
                OutputWebFetchServerToolItem,
                typeof(global::OpenRouter.OutputWebFetchServerToolItem),
                OutputToolSearchServerToolItem,
                typeof(global::OpenRouter.OutputToolSearchServerToolItem),
                OutputMemoryServerToolItem,
                typeof(global::OpenRouter.OutputMemoryServerToolItem),
                OutputMcpServerToolItem,
                typeof(global::OpenRouter.OutputMcpServerToolItem),
                OutputSearchModelsServerToolItem,
                typeof(global::OpenRouter.OutputSearchModelsServerToolItem),
                OutputFusionServerToolItem,
                typeof(global::OpenRouter.OutputFusionServerToolItem),
                OutputAdvisorServerToolItem,
                typeof(global::OpenRouter.OutputAdvisorServerToolItem),
                OutputSubagentServerToolItem,
                typeof(global::OpenRouter.OutputSubagentServerToolItem),
                OutputFilesServerToolItem,
                typeof(global::OpenRouter.OutputFilesServerToolItem),
                LocalShellCallItem,
                typeof(global::OpenRouter.LocalShellCallItem),
                LocalShellCallOutputItem,
                typeof(global::OpenRouter.LocalShellCallOutputItem),
                ShellCallItem,
                typeof(global::OpenRouter.ShellCallItem),
                ShellCallOutputItem,
                typeof(global::OpenRouter.ShellCallOutputItem),
                McpListToolsItem,
                typeof(global::OpenRouter.McpListToolsItem),
                McpApprovalRequestItem,
                typeof(global::OpenRouter.McpApprovalRequestItem),
                McpApprovalResponseItem,
                typeof(global::OpenRouter.McpApprovalResponseItem),
                McpCallItem,
                typeof(global::OpenRouter.McpCallItem),
                CustomToolCallItem,
                typeof(global::OpenRouter.CustomToolCallItem),
                CustomToolCallOutputItem,
                typeof(global::OpenRouter.CustomToolCallOutputItem),
                CompactionItem,
                typeof(global::OpenRouter.CompactionItem),
                ContextCompactionItem,
                typeof(global::OpenRouter.ContextCompactionItem),
                ItemReferenceItem,
                typeof(global::OpenRouter.ItemReferenceItem),
                AdditionalToolsItem,
                typeof(global::OpenRouter.AdditionalToolsItem),
                AgentMessageItem,
                typeof(global::OpenRouter.AgentMessageItem),
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
        public bool Equals(InputsOneOf1Items other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ReasoningItem?>.Default.Equals(ReasoningItem, other.ReasoningItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.EasyInputMessage?>.Default.Equals(EasyInputMessage, other.EasyInputMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InputMessageItem?>.Default.Equals(InputMessageItem, other.InputMessageItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FunctionCallItem?>.Default.Equals(FunctionCallItem, other.FunctionCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FunctionCallOutputItem?>.Default.Equals(FunctionCallOutputItem, other.FunctionCallOutputItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ApplyPatchCallItem?>.Default.Equals(ApplyPatchCallItem, other.ApplyPatchCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ApplyPatchCallOutputItem?>.Default.Equals(ApplyPatchCallOutputItem, other.ApplyPatchCallOutputItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InputsOneOf1Items7?>.Default.Equals(InputsOneOf1Items7, other.InputsOneOf1Items7) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InputsOneOf1Items8?>.Default.Equals(InputsOneOf1Items8, other.InputsOneOf1Items8) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputFunctionCallItem?>.Default.Equals(OutputFunctionCallItem, other.OutputFunctionCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputCustomToolCallItem?>.Default.Equals(OutputCustomToolCallItem, other.OutputCustomToolCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputWebSearchCallItem?>.Default.Equals(OutputWebSearchCallItem, other.OutputWebSearchCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputFileSearchCallItem?>.Default.Equals(OutputFileSearchCallItem, other.OutputFileSearchCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputImageGenerationCallItem?>.Default.Equals(OutputImageGenerationCallItem, other.OutputImageGenerationCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputCodeInterpreterCallItem?>.Default.Equals(OutputCodeInterpreterCallItem, other.OutputCodeInterpreterCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputComputerCallItem?>.Default.Equals(OutputComputerCallItem, other.OutputComputerCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputDatetimeItem?>.Default.Equals(OutputDatetimeItem, other.OutputDatetimeItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputWebSearchServerToolItem?>.Default.Equals(OutputWebSearchServerToolItem, other.OutputWebSearchServerToolItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputCodeInterpreterServerToolItem?>.Default.Equals(OutputCodeInterpreterServerToolItem, other.OutputCodeInterpreterServerToolItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputFileSearchServerToolItem?>.Default.Equals(OutputFileSearchServerToolItem, other.OutputFileSearchServerToolItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputImageGenerationServerToolItem?>.Default.Equals(OutputImageGenerationServerToolItem, other.OutputImageGenerationServerToolItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputBrowserUseServerToolItem?>.Default.Equals(OutputBrowserUseServerToolItem, other.OutputBrowserUseServerToolItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputBashServerToolItem?>.Default.Equals(OutputBashServerToolItem, other.OutputBashServerToolItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputTextEditorServerToolItem?>.Default.Equals(OutputTextEditorServerToolItem, other.OutputTextEditorServerToolItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputApplyPatchServerToolItem?>.Default.Equals(OutputApplyPatchServerToolItem, other.OutputApplyPatchServerToolItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputWebFetchServerToolItem?>.Default.Equals(OutputWebFetchServerToolItem, other.OutputWebFetchServerToolItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputToolSearchServerToolItem?>.Default.Equals(OutputToolSearchServerToolItem, other.OutputToolSearchServerToolItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputMemoryServerToolItem?>.Default.Equals(OutputMemoryServerToolItem, other.OutputMemoryServerToolItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputMcpServerToolItem?>.Default.Equals(OutputMcpServerToolItem, other.OutputMcpServerToolItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputSearchModelsServerToolItem?>.Default.Equals(OutputSearchModelsServerToolItem, other.OutputSearchModelsServerToolItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputFusionServerToolItem?>.Default.Equals(OutputFusionServerToolItem, other.OutputFusionServerToolItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputAdvisorServerToolItem?>.Default.Equals(OutputAdvisorServerToolItem, other.OutputAdvisorServerToolItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputSubagentServerToolItem?>.Default.Equals(OutputSubagentServerToolItem, other.OutputSubagentServerToolItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputFilesServerToolItem?>.Default.Equals(OutputFilesServerToolItem, other.OutputFilesServerToolItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.LocalShellCallItem?>.Default.Equals(LocalShellCallItem, other.LocalShellCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.LocalShellCallOutputItem?>.Default.Equals(LocalShellCallOutputItem, other.LocalShellCallOutputItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ShellCallItem?>.Default.Equals(ShellCallItem, other.ShellCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ShellCallOutputItem?>.Default.Equals(ShellCallOutputItem, other.ShellCallOutputItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.McpListToolsItem?>.Default.Equals(McpListToolsItem, other.McpListToolsItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.McpApprovalRequestItem?>.Default.Equals(McpApprovalRequestItem, other.McpApprovalRequestItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.McpApprovalResponseItem?>.Default.Equals(McpApprovalResponseItem, other.McpApprovalResponseItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.McpCallItem?>.Default.Equals(McpCallItem, other.McpCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CustomToolCallItem?>.Default.Equals(CustomToolCallItem, other.CustomToolCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CustomToolCallOutputItem?>.Default.Equals(CustomToolCallOutputItem, other.CustomToolCallOutputItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CompactionItem?>.Default.Equals(CompactionItem, other.CompactionItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ContextCompactionItem?>.Default.Equals(ContextCompactionItem, other.ContextCompactionItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ItemReferenceItem?>.Default.Equals(ItemReferenceItem, other.ItemReferenceItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AdditionalToolsItem?>.Default.Equals(AdditionalToolsItem, other.AdditionalToolsItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AgentMessageItem?>.Default.Equals(AgentMessageItem, other.AgentMessageItem)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(InputsOneOf1Items obj1, InputsOneOf1Items obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputsOneOf1Items>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InputsOneOf1Items obj1, InputsOneOf1Items obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputsOneOf1Items o && Equals(o);
        }
    }
}
