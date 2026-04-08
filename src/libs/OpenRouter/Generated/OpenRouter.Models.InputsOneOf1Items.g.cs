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
        public InputsOneOf1Items(
            global::OpenRouter.ReasoningItem? reasoningItem,
            global::OpenRouter.EasyInputMessage? easyInputMessage,
            global::OpenRouter.InputMessageItem? inputMessageItem,
            global::OpenRouter.FunctionCallItem? functionCallItem,
            global::OpenRouter.FunctionCallOutputItem? functionCallOutputItem,
            global::OpenRouter.InputsOneOf1Items5? inputsOneOf1Items5,
            global::OpenRouter.InputsOneOf1Items6? inputsOneOf1Items6,
            global::OpenRouter.OutputFunctionCallItem? outputFunctionCallItem,
            global::OpenRouter.OutputWebSearchCallItem? outputWebSearchCallItem,
            global::OpenRouter.OutputFileSearchCallItem? outputFileSearchCallItem,
            global::OpenRouter.OutputImageGenerationCallItem? outputImageGenerationCallItem,
            global::OpenRouter.OutputDatetimeItem? outputDatetimeItem,
            global::OpenRouter.OutputWebSearchServerToolItem? outputWebSearchServerToolItem
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
            OutputWebSearchCallItem = outputWebSearchCallItem;
            OutputFileSearchCallItem = outputFileSearchCallItem;
            OutputImageGenerationCallItem = outputImageGenerationCallItem;
            OutputDatetimeItem = outputDatetimeItem;
            OutputWebSearchServerToolItem = outputWebSearchServerToolItem;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutputWebSearchServerToolItem as object ??
            OutputDatetimeItem as object ??
            OutputImageGenerationCallItem as object ??
            OutputFileSearchCallItem as object ??
            OutputWebSearchCallItem as object ??
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
            OutputWebSearchCallItem?.ToString() ??
            OutputFileSearchCallItem?.ToString() ??
            OutputImageGenerationCallItem?.ToString() ??
            OutputDatetimeItem?.ToString() ??
            OutputWebSearchServerToolItem?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem || !IsReasoningItem && IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem || !IsReasoningItem && !IsEasyInputMessage && IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && IsOutputImageGenerationCallItem && !IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && IsOutputDatetimeItem && !IsOutputWebSearchServerToolItem || !IsReasoningItem && !IsEasyInputMessage && !IsInputMessageItem && !IsFunctionCallItem && !IsFunctionCallOutputItem && !IsInputsOneOf1Items5 && !IsInputsOneOf1Items6 && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputDatetimeItem && IsOutputWebSearchServerToolItem;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ReasoningItem?, TResult>? reasoningItem = null,
            global::System.Func<global::OpenRouter.EasyInputMessage?, TResult>? easyInputMessage = null,
            global::System.Func<global::OpenRouter.InputMessageItem?, TResult>? inputMessageItem = null,
            global::System.Func<global::OpenRouter.FunctionCallItem?, TResult>? functionCallItem = null,
            global::System.Func<global::OpenRouter.FunctionCallOutputItem?, TResult>? functionCallOutputItem = null,
            global::System.Func<global::OpenRouter.InputsOneOf1Items5?, TResult>? inputsOneOf1Items5 = null,
            global::System.Func<global::OpenRouter.InputsOneOf1Items6?, TResult>? inputsOneOf1Items6 = null,
            global::System.Func<global::OpenRouter.OutputFunctionCallItem?, TResult>? outputFunctionCallItem = null,
            global::System.Func<global::OpenRouter.OutputWebSearchCallItem?, TResult>? outputWebSearchCallItem = null,
            global::System.Func<global::OpenRouter.OutputFileSearchCallItem?, TResult>? outputFileSearchCallItem = null,
            global::System.Func<global::OpenRouter.OutputImageGenerationCallItem?, TResult>? outputImageGenerationCallItem = null,
            global::System.Func<global::OpenRouter.OutputDatetimeItem?, TResult>? outputDatetimeItem = null,
            global::System.Func<global::OpenRouter.OutputWebSearchServerToolItem?, TResult>? outputWebSearchServerToolItem = null,
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
            else if (IsOutputDatetimeItem && outputDatetimeItem != null)
            {
                return outputDatetimeItem(OutputDatetimeItem!);
            }
            else if (IsOutputWebSearchServerToolItem && outputWebSearchServerToolItem != null)
            {
                return outputWebSearchServerToolItem(OutputWebSearchServerToolItem!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ReasoningItem?>? reasoningItem = null,
            global::System.Action<global::OpenRouter.EasyInputMessage?>? easyInputMessage = null,
            global::System.Action<global::OpenRouter.InputMessageItem?>? inputMessageItem = null,
            global::System.Action<global::OpenRouter.FunctionCallItem?>? functionCallItem = null,
            global::System.Action<global::OpenRouter.FunctionCallOutputItem?>? functionCallOutputItem = null,
            global::System.Action<global::OpenRouter.InputsOneOf1Items5?>? inputsOneOf1Items5 = null,
            global::System.Action<global::OpenRouter.InputsOneOf1Items6?>? inputsOneOf1Items6 = null,
            global::System.Action<global::OpenRouter.OutputFunctionCallItem?>? outputFunctionCallItem = null,
            global::System.Action<global::OpenRouter.OutputWebSearchCallItem?>? outputWebSearchCallItem = null,
            global::System.Action<global::OpenRouter.OutputFileSearchCallItem?>? outputFileSearchCallItem = null,
            global::System.Action<global::OpenRouter.OutputImageGenerationCallItem?>? outputImageGenerationCallItem = null,
            global::System.Action<global::OpenRouter.OutputDatetimeItem?>? outputDatetimeItem = null,
            global::System.Action<global::OpenRouter.OutputWebSearchServerToolItem?>? outputWebSearchServerToolItem = null,
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
            else if (IsOutputDatetimeItem)
            {
                outputDatetimeItem?.Invoke(OutputDatetimeItem!);
            }
            else if (IsOutputWebSearchServerToolItem)
            {
                outputWebSearchServerToolItem?.Invoke(OutputWebSearchServerToolItem!);
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
                OutputWebSearchCallItem,
                typeof(global::OpenRouter.OutputWebSearchCallItem),
                OutputFileSearchCallItem,
                typeof(global::OpenRouter.OutputFileSearchCallItem),
                OutputImageGenerationCallItem,
                typeof(global::OpenRouter.OutputImageGenerationCallItem),
                OutputDatetimeItem,
                typeof(global::OpenRouter.OutputDatetimeItem),
                OutputWebSearchServerToolItem,
                typeof(global::OpenRouter.OutputWebSearchServerToolItem),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputWebSearchCallItem?>.Default.Equals(OutputWebSearchCallItem, other.OutputWebSearchCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputFileSearchCallItem?>.Default.Equals(OutputFileSearchCallItem, other.OutputFileSearchCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputImageGenerationCallItem?>.Default.Equals(OutputImageGenerationCallItem, other.OutputImageGenerationCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputDatetimeItem?>.Default.Equals(OutputDatetimeItem, other.OutputDatetimeItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputWebSearchServerToolItem?>.Default.Equals(OutputWebSearchServerToolItem, other.OutputWebSearchServerToolItem) 
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
