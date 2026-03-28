#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An output item from the response
    /// </summary>
    public readonly partial struct OutputItems : global::System.IEquatable<OutputItems>
    {
        /// <summary>
        /// An output message item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputMessageItem? OutputMessageItem { get; init; }
#else
        public global::OpenRouter.OutputMessageItem? OutputMessageItem { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputMessageItem))]
#endif
        public bool IsOutputMessageItem => OutputMessageItem != null;

        /// <summary>
        /// An output item containing reasoning
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputReasoningItem? OutputReasoningItem { get; init; }
#else
        public global::OpenRouter.OutputReasoningItem? OutputReasoningItem { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputReasoningItem))]
#endif
        public bool IsOutputReasoningItem => OutputReasoningItem != null;

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
        /// A generic OpenRouter server tool output item
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputServerToolItem? OutputServerToolItem { get; init; }
#else
        public global::OpenRouter.OutputServerToolItem? OutputServerToolItem { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputServerToolItem))]
#endif
        public bool IsOutputServerToolItem => OutputServerToolItem != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputMessageItem value) => new OutputItems((global::OpenRouter.OutputMessageItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputMessageItem?(OutputItems @this) => @this.OutputMessageItem;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputMessageItem? value)
        {
            OutputMessageItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputReasoningItem value) => new OutputItems((global::OpenRouter.OutputReasoningItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputReasoningItem?(OutputItems @this) => @this.OutputReasoningItem;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputReasoningItem? value)
        {
            OutputReasoningItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputFunctionCallItem value) => new OutputItems((global::OpenRouter.OutputFunctionCallItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputFunctionCallItem?(OutputItems @this) => @this.OutputFunctionCallItem;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputFunctionCallItem? value)
        {
            OutputFunctionCallItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputWebSearchCallItem value) => new OutputItems((global::OpenRouter.OutputWebSearchCallItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputWebSearchCallItem?(OutputItems @this) => @this.OutputWebSearchCallItem;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputWebSearchCallItem? value)
        {
            OutputWebSearchCallItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputFileSearchCallItem value) => new OutputItems((global::OpenRouter.OutputFileSearchCallItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputFileSearchCallItem?(OutputItems @this) => @this.OutputFileSearchCallItem;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputFileSearchCallItem? value)
        {
            OutputFileSearchCallItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputImageGenerationCallItem value) => new OutputItems((global::OpenRouter.OutputImageGenerationCallItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputImageGenerationCallItem?(OutputItems @this) => @this.OutputImageGenerationCallItem;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputImageGenerationCallItem? value)
        {
            OutputImageGenerationCallItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputServerToolItem value) => new OutputItems((global::OpenRouter.OutputServerToolItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputServerToolItem?(OutputItems @this) => @this.OutputServerToolItem;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputServerToolItem? value)
        {
            OutputServerToolItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(
            global::OpenRouter.OutputMessageItem? outputMessageItem,
            global::OpenRouter.OutputReasoningItem? outputReasoningItem,
            global::OpenRouter.OutputFunctionCallItem? outputFunctionCallItem,
            global::OpenRouter.OutputWebSearchCallItem? outputWebSearchCallItem,
            global::OpenRouter.OutputFileSearchCallItem? outputFileSearchCallItem,
            global::OpenRouter.OutputImageGenerationCallItem? outputImageGenerationCallItem,
            global::OpenRouter.OutputServerToolItem? outputServerToolItem
            )
        {
            OutputMessageItem = outputMessageItem;
            OutputReasoningItem = outputReasoningItem;
            OutputFunctionCallItem = outputFunctionCallItem;
            OutputWebSearchCallItem = outputWebSearchCallItem;
            OutputFileSearchCallItem = outputFileSearchCallItem;
            OutputImageGenerationCallItem = outputImageGenerationCallItem;
            OutputServerToolItem = outputServerToolItem;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutputServerToolItem as object ??
            OutputImageGenerationCallItem as object ??
            OutputFileSearchCallItem as object ??
            OutputWebSearchCallItem as object ??
            OutputFunctionCallItem as object ??
            OutputReasoningItem as object ??
            OutputMessageItem as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OutputMessageItem?.ToString() ??
            OutputReasoningItem?.ToString() ??
            OutputFunctionCallItem?.ToString() ??
            OutputWebSearchCallItem?.ToString() ??
            OutputFileSearchCallItem?.ToString() ??
            OutputImageGenerationCallItem?.ToString() ??
            OutputServerToolItem?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOutputMessageItem && !IsOutputReasoningItem && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputServerToolItem || !IsOutputMessageItem && IsOutputReasoningItem && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputServerToolItem || !IsOutputMessageItem && !IsOutputReasoningItem && IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputServerToolItem || !IsOutputMessageItem && !IsOutputReasoningItem && !IsOutputFunctionCallItem && IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputServerToolItem || !IsOutputMessageItem && !IsOutputReasoningItem && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && !IsOutputServerToolItem || !IsOutputMessageItem && !IsOutputReasoningItem && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && IsOutputImageGenerationCallItem && !IsOutputServerToolItem || !IsOutputMessageItem && !IsOutputReasoningItem && !IsOutputFunctionCallItem && !IsOutputWebSearchCallItem && !IsOutputFileSearchCallItem && !IsOutputImageGenerationCallItem && IsOutputServerToolItem;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OutputMessageItem?, TResult>? outputMessageItem = null,
            global::System.Func<global::OpenRouter.OutputReasoningItem?, TResult>? outputReasoningItem = null,
            global::System.Func<global::OpenRouter.OutputFunctionCallItem?, TResult>? outputFunctionCallItem = null,
            global::System.Func<global::OpenRouter.OutputWebSearchCallItem?, TResult>? outputWebSearchCallItem = null,
            global::System.Func<global::OpenRouter.OutputFileSearchCallItem?, TResult>? outputFileSearchCallItem = null,
            global::System.Func<global::OpenRouter.OutputImageGenerationCallItem?, TResult>? outputImageGenerationCallItem = null,
            global::System.Func<global::OpenRouter.OutputServerToolItem?, TResult>? outputServerToolItem = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputMessageItem && outputMessageItem != null)
            {
                return outputMessageItem(OutputMessageItem!);
            }
            else if (IsOutputReasoningItem && outputReasoningItem != null)
            {
                return outputReasoningItem(OutputReasoningItem!);
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
            else if (IsOutputServerToolItem && outputServerToolItem != null)
            {
                return outputServerToolItem(OutputServerToolItem!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OutputMessageItem?>? outputMessageItem = null,
            global::System.Action<global::OpenRouter.OutputReasoningItem?>? outputReasoningItem = null,
            global::System.Action<global::OpenRouter.OutputFunctionCallItem?>? outputFunctionCallItem = null,
            global::System.Action<global::OpenRouter.OutputWebSearchCallItem?>? outputWebSearchCallItem = null,
            global::System.Action<global::OpenRouter.OutputFileSearchCallItem?>? outputFileSearchCallItem = null,
            global::System.Action<global::OpenRouter.OutputImageGenerationCallItem?>? outputImageGenerationCallItem = null,
            global::System.Action<global::OpenRouter.OutputServerToolItem?>? outputServerToolItem = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputMessageItem)
            {
                outputMessageItem?.Invoke(OutputMessageItem!);
            }
            else if (IsOutputReasoningItem)
            {
                outputReasoningItem?.Invoke(OutputReasoningItem!);
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
            else if (IsOutputServerToolItem)
            {
                outputServerToolItem?.Invoke(OutputServerToolItem!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OutputMessageItem,
                typeof(global::OpenRouter.OutputMessageItem),
                OutputReasoningItem,
                typeof(global::OpenRouter.OutputReasoningItem),
                OutputFunctionCallItem,
                typeof(global::OpenRouter.OutputFunctionCallItem),
                OutputWebSearchCallItem,
                typeof(global::OpenRouter.OutputWebSearchCallItem),
                OutputFileSearchCallItem,
                typeof(global::OpenRouter.OutputFileSearchCallItem),
                OutputImageGenerationCallItem,
                typeof(global::OpenRouter.OutputImageGenerationCallItem),
                OutputServerToolItem,
                typeof(global::OpenRouter.OutputServerToolItem),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputMessageItem?>.Default.Equals(OutputMessageItem, other.OutputMessageItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputReasoningItem?>.Default.Equals(OutputReasoningItem, other.OutputReasoningItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputFunctionCallItem?>.Default.Equals(OutputFunctionCallItem, other.OutputFunctionCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputWebSearchCallItem?>.Default.Equals(OutputWebSearchCallItem, other.OutputWebSearchCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputFileSearchCallItem?>.Default.Equals(OutputFileSearchCallItem, other.OutputFileSearchCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputImageGenerationCallItem?>.Default.Equals(OutputImageGenerationCallItem, other.OutputImageGenerationCallItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputServerToolItem?>.Default.Equals(OutputServerToolItem, other.OutputServerToolItem) 
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
