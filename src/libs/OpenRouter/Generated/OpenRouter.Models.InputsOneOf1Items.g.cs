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
        public global::OpenRouter.ReasoningItem PickReasoningItem() => IsReasoningItem
            ? ReasoningItem!
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
        public global::OpenRouter.EasyInputMessage PickEasyInputMessage() => IsEasyInputMessage
            ? EasyInputMessage!
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
        public global::OpenRouter.InputMessageItem PickInputMessageItem() => IsInputMessageItem
            ? InputMessageItem!
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
        public global::OpenRouter.FunctionCallItem PickFunctionCallItem() => IsFunctionCallItem
            ? FunctionCallItem!
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
        public global::OpenRouter.FunctionCallOutputItem PickFunctionCallOutputItem() => IsFunctionCallOutputItem
            ? FunctionCallOutputItem!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallOutputItem' but the value was {ToString()}.");

        /// <summary>
        /// An output message item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.InputsOneOf1Items5? InputsOneOf1Items5 { get; init; }
#else
        public global::OpenRouter.InputsOneOf1Items5? InputsOneOf1Items5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputsOneOf1Items5))]
#endif
        public bool IsInputsOneOf1Items5 => InputsOneOf1Items5 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputsOneOf1Items5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.InputsOneOf1Items5? value)
        {
            value = InputsOneOf1Items5;
            return IsInputsOneOf1Items5;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.InputsOneOf1Items5 PickInputsOneOf1Items5() => IsInputsOneOf1Items5
            ? InputsOneOf1Items5!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputsOneOf1Items5' but the value was {ToString()}.");

        /// <summary>
        /// An output item containing reasoning
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.InputsOneOf1Items6? InputsOneOf1Items6 { get; init; }
#else
        public global::OpenRouter.InputsOneOf1Items6? InputsOneOf1Items6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputsOneOf1Items6))]
#endif
        public bool IsInputsOneOf1Items6 => InputsOneOf1Items6 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputsOneOf1Items6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.InputsOneOf1Items6? value)
        {
            value = InputsOneOf1Items6;
            return IsInputsOneOf1Items6;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.InputsOneOf1Items6 PickInputsOneOf1Items6() => IsInputsOneOf1Items6
            ? InputsOneOf1Items6!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputsOneOf1Items6' but the value was {ToString()}.");

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
        public global::OpenRouter.OutputFunctionCallItem PickOutputFunctionCallItem() => IsOutputFunctionCallItem
            ? OutputFunctionCallItem!
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
        public global::OpenRouter.OutputCustomToolCallItem PickOutputCustomToolCallItem() => IsOutputCustomToolCallItem
            ? OutputCustomToolCallItem!
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
        public global::OpenRouter.OutputWebSearchCallItem PickOutputWebSearchCallItem() => IsOutputWebSearchCallItem
            ? OutputWebSearchCallItem!
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
        public global::OpenRouter.OutputFileSearchCallItem PickOutputFileSearchCallItem() => IsOutputFileSearchCallItem
            ? OutputFileSearchCallItem!
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
        public global::OpenRouter.OutputImageGenerationCallItem PickOutputImageGenerationCallItem() => IsOutputImageGenerationCallItem
            ? OutputImageGenerationCallItem!
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
        public global::OpenRouter.OutputCodeInterpreterCallItem PickOutputCodeInterpreterCallItem() => IsOutputCodeInterpreterCallItem
            ? OutputCodeInterpreterCallItem!
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
        public global::OpenRouter.OutputComputerCallItem PickOutputComputerCallItem() => IsOutputComputerCallItem
            ? OutputComputerCallItem!
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
        public global::OpenRouter.OutputDatetimeItem PickOutputDatetimeItem() => IsOutputDatetimeItem
            ? OutputDatetimeItem!
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
        public global::OpenRouter.OutputWebSearchServerToolItem PickOutputWebSearchServerToolItem() => IsOutputWebSearchServerToolItem
            ? OutputWebSearchServerToolItem!
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
        public global::OpenRouter.OutputCodeInterpreterServerToolItem PickOutputCodeInterpreterServerToolItem() => IsOutputCodeInterpreterServerToolItem
            ? OutputCodeInterpreterServerToolItem!
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
        public global::OpenRouter.OutputFileSearchServerToolItem PickOutputFileSearchServerToolItem() => IsOutputFileSearchServerToolItem
            ? OutputFileSearchServerToolItem!
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
        public global::OpenRouter.OutputImageGenerationServerToolItem PickOutputImageGenerationServerToolItem() => IsOutputImageGenerationServerToolItem
            ? OutputImageGenerationServerToolItem!
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
        public global::OpenRouter.OutputBrowserUseServerToolItem PickOutputBrowserUseServerToolItem() => IsOutputBrowserUseServerToolItem
            ? OutputBrowserUseServerToolItem!
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
        public global::OpenRouter.OutputBashServerToolItem PickOutputBashServerToolItem() => IsOutputBashServerToolItem
            ? OutputBashServerToolItem!
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
        public global::OpenRouter.OutputTextEditorServerToolItem PickOutputTextEditorServerToolItem() => IsOutputTextEditorServerToolItem
            ? OutputTextEditorServerToolItem!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputTextEditorServerToolItem' but the value was {ToString()}.");

        /// <summary>
        /// An openrouter:apply_patch server tool output item
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
        public global::OpenRouter.OutputApplyPatchServerToolItem PickOutputApplyPatchServerToolItem() => IsOutputApplyPatchServerToolItem
            ? OutputApplyPatchServerToolItem!
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
        public global::OpenRouter.OutputWebFetchServerToolItem PickOutputWebFetchServerToolItem() => IsOutputWebFetchServerToolItem
            ? OutputWebFetchServerToolItem!
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
        public global::OpenRouter.OutputToolSearchServerToolItem PickOutputToolSearchServerToolItem() => IsOutputToolSearchServerToolItem
            ? OutputToolSearchServerToolItem!
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
        public global::OpenRouter.OutputMemoryServerToolItem PickOutputMemoryServerToolItem() => IsOutputMemoryServerToolItem
            ? OutputMemoryServerToolItem!
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
        public global::OpenRouter.OutputMcpServerToolItem PickOutputMcpServerToolItem() => IsOutputMcpServerToolItem
            ? OutputMcpServerToolItem!
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
        public global::OpenRouter.OutputSearchModelsServerToolItem PickOutputSearchModelsServerToolItem() => IsOutputSearchModelsServerToolItem
            ? OutputSearchModelsServerToolItem!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputSearchModelsServerToolItem' but the value was {ToString()}.");

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
        public global::OpenRouter.LocalShellCallItem PickLocalShellCallItem() => IsLocalShellCallItem
            ? LocalShellCallItem!
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
        public global::OpenRouter.LocalShellCallOutputItem PickLocalShellCallOutputItem() => IsLocalShellCallOutputItem
            ? LocalShellCallOutputItem!
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
        public global::OpenRouter.ShellCallItem PickShellCallItem() => IsShellCallItem
            ? ShellCallItem!
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
        public global::OpenRouter.ShellCallOutputItem PickShellCallOutputItem() => IsShellCallOutputItem
            ? ShellCallOutputItem!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ShellCallOutputItem' but the value was {ToString()}.");

        /// <summary>
        /// A file create/update/delete via diff patch
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
        public global::OpenRouter.ApplyPatchCallItem PickApplyPatchCallItem() => IsApplyPatchCallItem
            ? ApplyPatchCallItem!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatchCallItem' but the value was {ToString()}.");

        /// <summary>
        /// Output from an apply patch operation
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
        public global::OpenRouter.ApplyPatchCallOutputItem PickApplyPatchCallOutputItem() => IsApplyPatchCallOutputItem
            ? ApplyPatchCallOutputItem!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApplyPatchCallOutputItem' but the value was {ToString()}.");

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
        public global::OpenRouter.McpListToolsItem PickMcpListToolsItem() => IsMcpListToolsItem
            ? McpListToolsItem!
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
        public global::OpenRouter.McpApprovalRequestItem PickMcpApprovalRequestItem() => IsMcpApprovalRequestItem
            ? McpApprovalRequestItem!
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
        public global::OpenRouter.McpApprovalResponseItem PickMcpApprovalResponseItem() => IsMcpApprovalResponseItem
            ? McpApprovalResponseItem!
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
        public global::OpenRouter.McpCallItem PickMcpCallItem() => IsMcpCallItem
            ? McpCallItem!
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
        public global::OpenRouter.CustomToolCallItem PickCustomToolCallItem() => IsCustomToolCallItem
            ? CustomToolCallItem!
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
        public global::OpenRouter.CustomToolCallOutputItem PickCustomToolCallOutputItem() => IsCustomToolCallOutputItem
            ? CustomToolCallOutputItem!
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
        public global::OpenRouter.CompactionItem PickCompactionItem() => IsCompactionItem
            ? CompactionItem!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CompactionItem' but the value was {ToString()}.");

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
        public global::OpenRouter.ItemReferenceItem PickItemReferenceItem() => IsItemReferenceItem
            ? ItemReferenceItem!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ItemReferenceItem' but the value was {ToString()}.");
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
        public static implicit operator InputsOneOf1Items(global::OpenRouter.InputsOneOf1Items5 value) => new InputsOneOf1Items((global::OpenRouter.InputsOneOf1Items5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.InputsOneOf1Items5?(InputsOneOf1Items @this) => @this.InputsOneOf1Items5;

        /// <summary>
        /// 
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.InputsOneOf1Items5? value)
        {
            InputsOneOf1Items5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputsOneOf1Items FromInputsOneOf1Items5(global::OpenRouter.InputsOneOf1Items5? value) => new InputsOneOf1Items(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputsOneOf1Items(global::OpenRouter.InputsOneOf1Items6 value) => new InputsOneOf1Items((global::OpenRouter.InputsOneOf1Items6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.InputsOneOf1Items6?(InputsOneOf1Items @this) => @this.InputsOneOf1Items6;

        /// <summary>
        /// 
        /// </summary>
        public InputsOneOf1Items(global::OpenRouter.InputsOneOf1Items6? value)
        {
            InputsOneOf1Items6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputsOneOf1Items FromInputsOneOf1Items6(global::OpenRouter.InputsOneOf1Items6? value) => new InputsOneOf1Items(value);

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
        public InputsOneOf1Items(
            global::OpenRouter.ReasoningItem? reasoningItem,
            global::OpenRouter.EasyInputMessage? easyInputMessage,
            global::OpenRouter.InputMessageItem? inputMessageItem,
            global::OpenRouter.FunctionCallItem? functionCallItem,
            global::OpenRouter.FunctionCallOutputItem? functionCallOutputItem,
            global::OpenRouter.InputsOneOf1Items5? inputsOneOf1Items5,
            global::OpenRouter.InputsOneOf1Items6? inputsOneOf1Items6,
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
            global::OpenRouter.LocalShellCallItem? localShellCallItem,
            global::OpenRouter.LocalShellCallOutputItem? localShellCallOutputItem,
            global::OpenRouter.ShellCallItem? shellCallItem,
            global::OpenRouter.ShellCallOutputItem? shellCallOutputItem,
            global::OpenRouter.ApplyPatchCallItem? applyPatchCallItem,
            global::OpenRouter.ApplyPatchCallOutputItem? applyPatchCallOutputItem,
            global::OpenRouter.McpListToolsItem? mcpListToolsItem,
            global::OpenRouter.McpApprovalRequestItem? mcpApprovalRequestItem,
            global::OpenRouter.McpApprovalResponseItem? mcpApprovalResponseItem,
            global::OpenRouter.McpCallItem? mcpCallItem,
            global::OpenRouter.CustomToolCallItem? customToolCallItem,
            global::OpenRouter.CustomToolCallOutputItem? customToolCallOutputItem,
            global::OpenRouter.CompactionItem? compactionItem,
            global::OpenRouter.ItemReferenceItem? itemReferenceItem
            )
        {
            ReasoningItem = reasoningItem;
            EasyInputMessage = easyInputMessage;
            InputMessageItem = inputMessageItem;
            FunctionCallItem = functionCallItem;
            FunctionCallOutputItem = functionCallOutputItem;
            InputsOneOf1Items5 = inputsOneOf1Items5;
            InputsOneOf1Items6 = inputsOneOf1Items6;
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
            LocalShellCallItem = localShellCallItem;
            LocalShellCallOutputItem = localShellCallOutputItem;
            ShellCallItem = shellCallItem;
            ShellCallOutputItem = shellCallOutputItem;
            ApplyPatchCallItem = applyPatchCallItem;
            ApplyPatchCallOutputItem = applyPatchCallOutputItem;
            McpListToolsItem = mcpListToolsItem;
            McpApprovalRequestItem = mcpApprovalRequestItem;
            McpApprovalResponseItem = mcpApprovalResponseItem;
            McpCallItem = mcpCallItem;
            CustomToolCallItem = customToolCallItem;
            CustomToolCallOutputItem = customToolCallOutputItem;
            CompactionItem = compactionItem;
            ItemReferenceItem = itemReferenceItem;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ItemReferenceItem as object ??
            CompactionItem as object ??
            CustomToolCallOutputItem as object ??
            CustomToolCallItem as object ??
            McpCallItem as object ??
            McpApprovalResponseItem as object ??
            McpApprovalRequestItem as object ??
            McpListToolsItem as object ??
            ApplyPatchCallOutputItem as object ??
            ApplyPatchCallItem as object ??
            ShellCallOutputItem as object ??
            ShellCallItem as object ??
            LocalShellCallOutputItem as object ??
            LocalShellCallItem as object ??
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
            InputsOneOf1Items6 as object ??
            InputsOneOf1Items5 as object ??
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
            InputsOneOf1Items5?.ToString() ??
            InputsOneOf1Items6?.ToString() ??
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
            LocalShellCallItem?.ToString() ??
            LocalShellCallOutputItem?.ToString() ??
            ShellCallItem?.ToString() ??
            ShellCallOutputItem?.ToString() ??
            ApplyPatchCallItem?.ToString() ??
            ApplyPatchCallOutputItem?.ToString() ??
            McpListToolsItem?.ToString() ??
            McpApprovalRequestItem?.ToString() ??
            McpApprovalResponseItem?.ToString() ??
            McpCallItem?.ToString() ??
            CustomToolCallItem?.ToString() ??
            CustomToolCallOutputItem?.ToString() ??
            CompactionItem?.ToString() ??
            ItemReferenceItem?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && IsCustomToolCallOutputItem && !IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && IsCompactionItem && !IsItemReferenceItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputCustomToolCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputCodeInterpreterCallItem && !IsOutputComputerCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem && !IsOutputCodeInterpreterServerToolItem && !IsOutputFileSearchServerToolItem && !IsOutputImageGenerationServerToolItem && !IsOutputBrowserUseServerToolItem && !IsOutputBashServerToolItem && !IsOutputTextEditorServerToolItem && !IsOutputApplyPatchServerToolItem && !IsOutputWebFetchServerToolItem && !IsOutputToolSearchServerToolItem && !IsOutputMemoryServerToolItem && !IsOutputMcpServerToolItem && !IsOutputSearchModelsServerToolItem && !IsLocalShellCallItem && !IsLocalShellCallOutputItem && !IsShellCallItem && !IsShellCallOutputItem && !IsApplyPatchCallItem && !IsApplyPatchCallOutputItem && !IsMcpListToolsItem && !IsMcpApprovalRequestItem && !IsMcpApprovalResponseItem && !IsMcpCallItem && !IsCustomToolCallItem && !IsCustomToolCallOutputItem && !IsCompactionItem && IsItemReferenceItem;
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
            global::System.Func<global::OpenRouter.InputsOneOf1Items5, TResult>? inputsOneOf1Items5 = null,
            global::System.Func<global::OpenRouter.InputsOneOf1Items6, TResult>? inputsOneOf1Items6 = null,
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
            global::System.Func<global::OpenRouter.LocalShellCallItem, TResult>? localShellCallItem = null,
            global::System.Func<global::OpenRouter.LocalShellCallOutputItem, TResult>? localShellCallOutputItem = null,
            global::System.Func<global::OpenRouter.ShellCallItem, TResult>? shellCallItem = null,
            global::System.Func<global::OpenRouter.ShellCallOutputItem, TResult>? shellCallOutputItem = null,
            global::System.Func<global::OpenRouter.ApplyPatchCallItem, TResult>? applyPatchCallItem = null,
            global::System.Func<global::OpenRouter.ApplyPatchCallOutputItem, TResult>? applyPatchCallOutputItem = null,
            global::System.Func<global::OpenRouter.McpListToolsItem, TResult>? mcpListToolsItem = null,
            global::System.Func<global::OpenRouter.McpApprovalRequestItem, TResult>? mcpApprovalRequestItem = null,
            global::System.Func<global::OpenRouter.McpApprovalResponseItem, TResult>? mcpApprovalResponseItem = null,
            global::System.Func<global::OpenRouter.McpCallItem, TResult>? mcpCallItem = null,
            global::System.Func<global::OpenRouter.CustomToolCallItem, TResult>? customToolCallItem = null,
            global::System.Func<global::OpenRouter.CustomToolCallOutputItem, TResult>? customToolCallOutputItem = null,
            global::System.Func<global::OpenRouter.CompactionItem, TResult>? compactionItem = null,
            global::System.Func<global::OpenRouter.ItemReferenceItem, TResult>? itemReferenceItem = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReasoningItem && reasoningItem != null)
            {
                return reasoningItem(ReasoningItem!);
            }
            else if (IsEasyInputMessage && easyInputMessage != null)
            {
                return easyInputMessage(EasyInputMessage!);
            }
            else if (IsInputMessageItem && inputMessageItem != null)
            {
                return inputMessageItem(InputMessageItem!);
            }
            else if (IsFunctionCallItem && functionCallItem != null)
            {
                return functionCallItem(FunctionCallItem!);
            }
            else if (IsFunctionCallOutputItem && functionCallOutputItem != null)
            {
                return functionCallOutputItem(FunctionCallOutputItem!);
            }
            else if (IsInputsOneOf1Items5 && inputsOneOf1Items5 != null)
            {
                return inputsOneOf1Items5(InputsOneOf1Items5!);
            }
            else if (IsInputsOneOf1Items6 && inputsOneOf1Items6 != null)
            {
                return inputsOneOf1Items6(InputsOneOf1Items6!);
            }
            else if (IsOutputFunctionCallItem && outputFunctionCallItem != null)
            {
                return outputFunctionCallItem(OutputFunctionCallItem!);
            }
            else if (IsOutputCustomToolCallItem && outputCustomToolCallItem != null)
            {
                return outputCustomToolCallItem(OutputCustomToolCallItem!);
            }
            else if (IsOutputWebSearchCallItem && outputWebSearchCallItem != null)
            {
                return outputWebSearchCallItem(OutputWebSearchCallItem!);
            }
            else if (IsOutputFileSearchCallItem && outputFileSearchCallItem != null)
            {
                return outputFileSearchCallItem(OutputFileSearchCallItem!);
            }
            else if (IsOutputImageGenerationCallItem && outputImageGenerationCallItem != null)
            {
                return outputImageGenerationCallItem(OutputImageGenerationCallItem!);
            }
            else if (IsOutputCodeInterpreterCallItem && outputCodeInterpreterCallItem != null)
            {
                return outputCodeInterpreterCallItem(OutputCodeInterpreterCallItem!);
            }
            else if (IsOutputComputerCallItem && outputComputerCallItem != null)
            {
                return outputComputerCallItem(OutputComputerCallItem!);
            }
            else if (IsOutputDatetimeItem && outputDatetimeItem != null)
            {
                return outputDatetimeItem(OutputDatetimeItem!);
            }
            else if (IsOutputWebSearchServerToolItem && outputWebSearchServerToolItem != null)
            {
                return outputWebSearchServerToolItem(OutputWebSearchServerToolItem!);
            }
            else if (IsOutputCodeInterpreterServerToolItem && outputCodeInterpreterServerToolItem != null)
            {
                return outputCodeInterpreterServerToolItem(OutputCodeInterpreterServerToolItem!);
            }
            else if (IsOutputFileSearchServerToolItem && outputFileSearchServerToolItem != null)
            {
                return outputFileSearchServerToolItem(OutputFileSearchServerToolItem!);
            }
            else if (IsOutputImageGenerationServerToolItem && outputImageGenerationServerToolItem != null)
            {
                return outputImageGenerationServerToolItem(OutputImageGenerationServerToolItem!);
            }
            else if (IsOutputBrowserUseServerToolItem && outputBrowserUseServerToolItem != null)
            {
                return outputBrowserUseServerToolItem(OutputBrowserUseServerToolItem!);
            }
            else if (IsOutputBashServerToolItem && outputBashServerToolItem != null)
            {
                return outputBashServerToolItem(OutputBashServerToolItem!);
            }
            else if (IsOutputTextEditorServerToolItem && outputTextEditorServerToolItem != null)
            {
                return outputTextEditorServerToolItem(OutputTextEditorServerToolItem!);
            }
            else if (IsOutputApplyPatchServerToolItem && outputApplyPatchServerToolItem != null)
            {
                return outputApplyPatchServerToolItem(OutputApplyPatchServerToolItem!);
            }
            else if (IsOutputWebFetchServerToolItem && outputWebFetchServerToolItem != null)
            {
                return outputWebFetchServerToolItem(OutputWebFetchServerToolItem!);
            }
            else if (IsOutputToolSearchServerToolItem && outputToolSearchServerToolItem != null)
            {
                return outputToolSearchServerToolItem(OutputToolSearchServerToolItem!);
            }
            else if (IsOutputMemoryServerToolItem && outputMemoryServerToolItem != null)
            {
                return outputMemoryServerToolItem(OutputMemoryServerToolItem!);
            }
            else if (IsOutputMcpServerToolItem && outputMcpServerToolItem != null)
            {
                return outputMcpServerToolItem(OutputMcpServerToolItem!);
            }
            else if (IsOutputSearchModelsServerToolItem && outputSearchModelsServerToolItem != null)
            {
                return outputSearchModelsServerToolItem(OutputSearchModelsServerToolItem!);
            }
            else if (IsLocalShellCallItem && localShellCallItem != null)
            {
                return localShellCallItem(LocalShellCallItem!);
            }
            else if (IsLocalShellCallOutputItem && localShellCallOutputItem != null)
            {
                return localShellCallOutputItem(LocalShellCallOutputItem!);
            }
            else if (IsShellCallItem && shellCallItem != null)
            {
                return shellCallItem(ShellCallItem!);
            }
            else if (IsShellCallOutputItem && shellCallOutputItem != null)
            {
                return shellCallOutputItem(ShellCallOutputItem!);
            }
            else if (IsApplyPatchCallItem && applyPatchCallItem != null)
            {
                return applyPatchCallItem(ApplyPatchCallItem!);
            }
            else if (IsApplyPatchCallOutputItem && applyPatchCallOutputItem != null)
            {
                return applyPatchCallOutputItem(ApplyPatchCallOutputItem!);
            }
            else if (IsMcpListToolsItem && mcpListToolsItem != null)
            {
                return mcpListToolsItem(McpListToolsItem!);
            }
            else if (IsMcpApprovalRequestItem && mcpApprovalRequestItem != null)
            {
                return mcpApprovalRequestItem(McpApprovalRequestItem!);
            }
            else if (IsMcpApprovalResponseItem && mcpApprovalResponseItem != null)
            {
                return mcpApprovalResponseItem(McpApprovalResponseItem!);
            }
            else if (IsMcpCallItem && mcpCallItem != null)
            {
                return mcpCallItem(McpCallItem!);
            }
            else if (IsCustomToolCallItem && customToolCallItem != null)
            {
                return customToolCallItem(CustomToolCallItem!);
            }
            else if (IsCustomToolCallOutputItem && customToolCallOutputItem != null)
            {
                return customToolCallOutputItem(CustomToolCallOutputItem!);
            }
            else if (IsCompactionItem && compactionItem != null)
            {
                return compactionItem(CompactionItem!);
            }
            else if (IsItemReferenceItem && itemReferenceItem != null)
            {
                return itemReferenceItem(ItemReferenceItem!);
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

            global::System.Action<global::OpenRouter.InputsOneOf1Items5>? inputsOneOf1Items5 = null,

            global::System.Action<global::OpenRouter.InputsOneOf1Items6>? inputsOneOf1Items6 = null,

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

            global::System.Action<global::OpenRouter.LocalShellCallItem>? localShellCallItem = null,

            global::System.Action<global::OpenRouter.LocalShellCallOutputItem>? localShellCallOutputItem = null,

            global::System.Action<global::OpenRouter.ShellCallItem>? shellCallItem = null,

            global::System.Action<global::OpenRouter.ShellCallOutputItem>? shellCallOutputItem = null,

            global::System.Action<global::OpenRouter.ApplyPatchCallItem>? applyPatchCallItem = null,

            global::System.Action<global::OpenRouter.ApplyPatchCallOutputItem>? applyPatchCallOutputItem = null,

            global::System.Action<global::OpenRouter.McpListToolsItem>? mcpListToolsItem = null,

            global::System.Action<global::OpenRouter.McpApprovalRequestItem>? mcpApprovalRequestItem = null,

            global::System.Action<global::OpenRouter.McpApprovalResponseItem>? mcpApprovalResponseItem = null,

            global::System.Action<global::OpenRouter.McpCallItem>? mcpCallItem = null,

            global::System.Action<global::OpenRouter.CustomToolCallItem>? customToolCallItem = null,

            global::System.Action<global::OpenRouter.CustomToolCallOutputItem>? customToolCallOutputItem = null,

            global::System.Action<global::OpenRouter.CompactionItem>? compactionItem = null,

            global::System.Action<global::OpenRouter.ItemReferenceItem>? itemReferenceItem = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReasoningItem)
            {
                reasoningItem?.Invoke(ReasoningItem!);
            }
            else if (IsEasyInputMessage)
            {
                easyInputMessage?.Invoke(EasyInputMessage!);
            }
            else if (IsInputMessageItem)
            {
                inputMessageItem?.Invoke(InputMessageItem!);
            }
            else if (IsFunctionCallItem)
            {
                functionCallItem?.Invoke(FunctionCallItem!);
            }
            else if (IsFunctionCallOutputItem)
            {
                functionCallOutputItem?.Invoke(FunctionCallOutputItem!);
            }
            else if (IsInputsOneOf1Items5)
            {
                inputsOneOf1Items5?.Invoke(InputsOneOf1Items5!);
            }
            else if (IsInputsOneOf1Items6)
            {
                inputsOneOf1Items6?.Invoke(InputsOneOf1Items6!);
            }
            else if (IsOutputFunctionCallItem)
            {
                outputFunctionCallItem?.Invoke(OutputFunctionCallItem!);
            }
            else if (IsOutputCustomToolCallItem)
            {
                outputCustomToolCallItem?.Invoke(OutputCustomToolCallItem!);
            }
            else if (IsOutputWebSearchCallItem)
            {
                outputWebSearchCallItem?.Invoke(OutputWebSearchCallItem!);
            }
            else if (IsOutputFileSearchCallItem)
            {
                outputFileSearchCallItem?.Invoke(OutputFileSearchCallItem!);
            }
            else if (IsOutputImageGenerationCallItem)
            {
                outputImageGenerationCallItem?.Invoke(OutputImageGenerationCallItem!);
            }
            else if (IsOutputCodeInterpreterCallItem)
            {
                outputCodeInterpreterCallItem?.Invoke(OutputCodeInterpreterCallItem!);
            }
            else if (IsOutputComputerCallItem)
            {
                outputComputerCallItem?.Invoke(OutputComputerCallItem!);
            }
            else if (IsOutputDatetimeItem)
            {
                outputDatetimeItem?.Invoke(OutputDatetimeItem!);
            }
            else if (IsOutputWebSearchServerToolItem)
            {
                outputWebSearchServerToolItem?.Invoke(OutputWebSearchServerToolItem!);
            }
            else if (IsOutputCodeInterpreterServerToolItem)
            {
                outputCodeInterpreterServerToolItem?.Invoke(OutputCodeInterpreterServerToolItem!);
            }
            else if (IsOutputFileSearchServerToolItem)
            {
                outputFileSearchServerToolItem?.Invoke(OutputFileSearchServerToolItem!);
            }
            else if (IsOutputImageGenerationServerToolItem)
            {
                outputImageGenerationServerToolItem?.Invoke(OutputImageGenerationServerToolItem!);
            }
            else if (IsOutputBrowserUseServerToolItem)
            {
                outputBrowserUseServerToolItem?.Invoke(OutputBrowserUseServerToolItem!);
            }
            else if (IsOutputBashServerToolItem)
            {
                outputBashServerToolItem?.Invoke(OutputBashServerToolItem!);
            }
            else if (IsOutputTextEditorServerToolItem)
            {
                outputTextEditorServerToolItem?.Invoke(OutputTextEditorServerToolItem!);
            }
            else if (IsOutputApplyPatchServerToolItem)
            {
                outputApplyPatchServerToolItem?.Invoke(OutputApplyPatchServerToolItem!);
            }
            else if (IsOutputWebFetchServerToolItem)
            {
                outputWebFetchServerToolItem?.Invoke(OutputWebFetchServerToolItem!);
            }
            else if (IsOutputToolSearchServerToolItem)
            {
                outputToolSearchServerToolItem?.Invoke(OutputToolSearchServerToolItem!);
            }
            else if (IsOutputMemoryServerToolItem)
            {
                outputMemoryServerToolItem?.Invoke(OutputMemoryServerToolItem!);
            }
            else if (IsOutputMcpServerToolItem)
            {
                outputMcpServerToolItem?.Invoke(OutputMcpServerToolItem!);
            }
            else if (IsOutputSearchModelsServerToolItem)
            {
                outputSearchModelsServerToolItem?.Invoke(OutputSearchModelsServerToolItem!);
            }
            else if (IsLocalShellCallItem)
            {
                localShellCallItem?.Invoke(LocalShellCallItem!);
            }
            else if (IsLocalShellCallOutputItem)
            {
                localShellCallOutputItem?.Invoke(LocalShellCallOutputItem!);
            }
            else if (IsShellCallItem)
            {
                shellCallItem?.Invoke(ShellCallItem!);
            }
            else if (IsShellCallOutputItem)
            {
                shellCallOutputItem?.Invoke(ShellCallOutputItem!);
            }
            else if (IsApplyPatchCallItem)
            {
                applyPatchCallItem?.Invoke(ApplyPatchCallItem!);
            }
            else if (IsApplyPatchCallOutputItem)
            {
                applyPatchCallOutputItem?.Invoke(ApplyPatchCallOutputItem!);
            }
            else if (IsMcpListToolsItem)
            {
                mcpListToolsItem?.Invoke(McpListToolsItem!);
            }
            else if (IsMcpApprovalRequestItem)
            {
                mcpApprovalRequestItem?.Invoke(McpApprovalRequestItem!);
            }
            else if (IsMcpApprovalResponseItem)
            {
                mcpApprovalResponseItem?.Invoke(McpApprovalResponseItem!);
            }
            else if (IsMcpCallItem)
            {
                mcpCallItem?.Invoke(McpCallItem!);
            }
            else if (IsCustomToolCallItem)
            {
                customToolCallItem?.Invoke(CustomToolCallItem!);
            }
            else if (IsCustomToolCallOutputItem)
            {
                customToolCallOutputItem?.Invoke(CustomToolCallOutputItem!);
            }
            else if (IsCompactionItem)
            {
                compactionItem?.Invoke(CompactionItem!);
            }
            else if (IsItemReferenceItem)
            {
                itemReferenceItem?.Invoke(ItemReferenceItem!);
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
            global::System.Action<global::OpenRouter.InputsOneOf1Items5>? inputsOneOf1Items5 = null,
            global::System.Action<global::OpenRouter.InputsOneOf1Items6>? inputsOneOf1Items6 = null,
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
            global::System.Action<global::OpenRouter.LocalShellCallItem>? localShellCallItem = null,
            global::System.Action<global::OpenRouter.LocalShellCallOutputItem>? localShellCallOutputItem = null,
            global::System.Action<global::OpenRouter.ShellCallItem>? shellCallItem = null,
            global::System.Action<global::OpenRouter.ShellCallOutputItem>? shellCallOutputItem = null,
            global::System.Action<global::OpenRouter.ApplyPatchCallItem>? applyPatchCallItem = null,
            global::System.Action<global::OpenRouter.ApplyPatchCallOutputItem>? applyPatchCallOutputItem = null,
            global::System.Action<global::OpenRouter.McpListToolsItem>? mcpListToolsItem = null,
            global::System.Action<global::OpenRouter.McpApprovalRequestItem>? mcpApprovalRequestItem = null,
            global::System.Action<global::OpenRouter.McpApprovalResponseItem>? mcpApprovalResponseItem = null,
            global::System.Action<global::OpenRouter.McpCallItem>? mcpCallItem = null,
            global::System.Action<global::OpenRouter.CustomToolCallItem>? customToolCallItem = null,
            global::System.Action<global::OpenRouter.CustomToolCallOutputItem>? customToolCallOutputItem = null,
            global::System.Action<global::OpenRouter.CompactionItem>? compactionItem = null,
            global::System.Action<global::OpenRouter.ItemReferenceItem>? itemReferenceItem = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReasoningItem)
            {
                reasoningItem?.Invoke(ReasoningItem!);
            }
            else if (IsEasyInputMessage)
            {
                easyInputMessage?.Invoke(EasyInputMessage!);
            }
            else if (IsInputMessageItem)
            {
                inputMessageItem?.Invoke(InputMessageItem!);
            }
            else if (IsFunctionCallItem)
            {
                functionCallItem?.Invoke(FunctionCallItem!);
            }
            else if (IsFunctionCallOutputItem)
            {
                functionCallOutputItem?.Invoke(FunctionCallOutputItem!);
            }
            else if (IsInputsOneOf1Items5)
            {
                inputsOneOf1Items5?.Invoke(InputsOneOf1Items5!);
            }
            else if (IsInputsOneOf1Items6)
            {
                inputsOneOf1Items6?.Invoke(InputsOneOf1Items6!);
            }
            else if (IsOutputFunctionCallItem)
            {
                outputFunctionCallItem?.Invoke(OutputFunctionCallItem!);
            }
            else if (IsOutputCustomToolCallItem)
            {
                outputCustomToolCallItem?.Invoke(OutputCustomToolCallItem!);
            }
            else if (IsOutputWebSearchCallItem)
            {
                outputWebSearchCallItem?.Invoke(OutputWebSearchCallItem!);
            }
            else if (IsOutputFileSearchCallItem)
            {
                outputFileSearchCallItem?.Invoke(OutputFileSearchCallItem!);
            }
            else if (IsOutputImageGenerationCallItem)
            {
                outputImageGenerationCallItem?.Invoke(OutputImageGenerationCallItem!);
            }
            else if (IsOutputCodeInterpreterCallItem)
            {
                outputCodeInterpreterCallItem?.Invoke(OutputCodeInterpreterCallItem!);
            }
            else if (IsOutputComputerCallItem)
            {
                outputComputerCallItem?.Invoke(OutputComputerCallItem!);
            }
            else if (IsOutputDatetimeItem)
            {
                outputDatetimeItem?.Invoke(OutputDatetimeItem!);
            }
            else if (IsOutputWebSearchServerToolItem)
            {
                outputWebSearchServerToolItem?.Invoke(OutputWebSearchServerToolItem!);
            }
            else if (IsOutputCodeInterpreterServerToolItem)
            {
                outputCodeInterpreterServerToolItem?.Invoke(OutputCodeInterpreterServerToolItem!);
            }
            else if (IsOutputFileSearchServerToolItem)
            {
                outputFileSearchServerToolItem?.Invoke(OutputFileSearchServerToolItem!);
            }
            else if (IsOutputImageGenerationServerToolItem)
            {
                outputImageGenerationServerToolItem?.Invoke(OutputImageGenerationServerToolItem!);
            }
            else if (IsOutputBrowserUseServerToolItem)
            {
                outputBrowserUseServerToolItem?.Invoke(OutputBrowserUseServerToolItem!);
            }
            else if (IsOutputBashServerToolItem)
            {
                outputBashServerToolItem?.Invoke(OutputBashServerToolItem!);
            }
            else if (IsOutputTextEditorServerToolItem)
            {
                outputTextEditorServerToolItem?.Invoke(OutputTextEditorServerToolItem!);
            }
            else if (IsOutputApplyPatchServerToolItem)
            {
                outputApplyPatchServerToolItem?.Invoke(OutputApplyPatchServerToolItem!);
            }
            else if (IsOutputWebFetchServerToolItem)
            {
                outputWebFetchServerToolItem?.Invoke(OutputWebFetchServerToolItem!);
            }
            else if (IsOutputToolSearchServerToolItem)
            {
                outputToolSearchServerToolItem?.Invoke(OutputToolSearchServerToolItem!);
            }
            else if (IsOutputMemoryServerToolItem)
            {
                outputMemoryServerToolItem?.Invoke(OutputMemoryServerToolItem!);
            }
            else if (IsOutputMcpServerToolItem)
            {
                outputMcpServerToolItem?.Invoke(OutputMcpServerToolItem!);
            }
            else if (IsOutputSearchModelsServerToolItem)
            {
                outputSearchModelsServerToolItem?.Invoke(OutputSearchModelsServerToolItem!);
            }
            else if (IsLocalShellCallItem)
            {
                localShellCallItem?.Invoke(LocalShellCallItem!);
            }
            else if (IsLocalShellCallOutputItem)
            {
                localShellCallOutputItem?.Invoke(LocalShellCallOutputItem!);
            }
            else if (IsShellCallItem)
            {
                shellCallItem?.Invoke(ShellCallItem!);
            }
            else if (IsShellCallOutputItem)
            {
                shellCallOutputItem?.Invoke(ShellCallOutputItem!);
            }
            else if (IsApplyPatchCallItem)
            {
                applyPatchCallItem?.Invoke(ApplyPatchCallItem!);
            }
            else if (IsApplyPatchCallOutputItem)
            {
                applyPatchCallOutputItem?.Invoke(ApplyPatchCallOutputItem!);
            }
            else if (IsMcpListToolsItem)
            {
                mcpListToolsItem?.Invoke(McpListToolsItem!);
            }
            else if (IsMcpApprovalRequestItem)
            {
                mcpApprovalRequestItem?.Invoke(McpApprovalRequestItem!);
            }
            else if (IsMcpApprovalResponseItem)
            {
                mcpApprovalResponseItem?.Invoke(McpApprovalResponseItem!);
            }
            else if (IsMcpCallItem)
            {
                mcpCallItem?.Invoke(McpCallItem!);
            }
            else if (IsCustomToolCallItem)
            {
                customToolCallItem?.Invoke(CustomToolCallItem!);
            }
            else if (IsCustomToolCallOutputItem)
            {
                customToolCallOutputItem?.Invoke(CustomToolCallOutputItem!);
            }
            else if (IsCompactionItem)
            {
                compactionItem?.Invoke(CompactionItem!);
            }
            else if (IsItemReferenceItem)
            {
                itemReferenceItem?.Invoke(ItemReferenceItem!);
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
                InputsOneOf1Items5,
                typeof(global::OpenRouter.InputsOneOf1Items5),
                InputsOneOf1Items6,
                typeof(global::OpenRouter.InputsOneOf1Items6),
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
                LocalShellCallItem,
                typeof(global::OpenRouter.LocalShellCallItem),
                LocalShellCallOutputItem,
                typeof(global::OpenRouter.LocalShellCallOutputItem),
                ShellCallItem,
                typeof(global::OpenRouter.ShellCallItem),
                ShellCallOutputItem,
                typeof(global::OpenRouter.ShellCallOutputItem),
                ApplyPatchCallItem,
                typeof(global::OpenRouter.ApplyPatchCallItem),
                ApplyPatchCallOutputItem,
                typeof(global::OpenRouter.ApplyPatchCallOutputItem),
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
                ItemReferenceItem,
                typeof(global::OpenRouter.ItemReferenceItem),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InputsOneOf1Items5?>.Default.Equals(InputsOneOf1Items5, other.InputsOneOf1Items5) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InputsOneOf1Items6?>.Default.Equals(InputsOneOf1Items6, other.InputsOneOf1Items6) &&
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.LocalShellCallItem?>.Default.Equals(LocalShellCallItem, other.LocalShellCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.LocalShellCallOutputItem?>.Default.Equals(LocalShellCallOutputItem, other.LocalShellCallOutputItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ShellCallItem?>.Default.Equals(ShellCallItem, other.ShellCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ShellCallOutputItem?>.Default.Equals(ShellCallOutputItem, other.ShellCallOutputItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ApplyPatchCallItem?>.Default.Equals(ApplyPatchCallItem, other.ApplyPatchCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ApplyPatchCallOutputItem?>.Default.Equals(ApplyPatchCallOutputItem, other.ApplyPatchCallOutputItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.McpListToolsItem?>.Default.Equals(McpListToolsItem, other.McpListToolsItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.McpApprovalRequestItem?>.Default.Equals(McpApprovalRequestItem, other.McpApprovalRequestItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.McpApprovalResponseItem?>.Default.Equals(McpApprovalResponseItem, other.McpApprovalResponseItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.McpCallItem?>.Default.Equals(McpCallItem, other.McpCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CustomToolCallItem?>.Default.Equals(CustomToolCallItem, other.CustomToolCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CustomToolCallOutputItem?>.Default.Equals(CustomToolCallOutputItem, other.CustomToolCallOutputItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CompactionItem?>.Default.Equals(CompactionItem, other.CompactionItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ItemReferenceItem?>.Default.Equals(ItemReferenceItem, other.ItemReferenceItem) 
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
