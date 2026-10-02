#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A code interpreter execution call with outputs<br/>
    /// Example: {"code":"print(\u0022hello\u0022)","container_id":"ctr-xyz789","id":"ci-abc123","outputs":[{"logs":"hello\n","type":"logs"}],"status":"completed","type":"code_interpreter_call"}
    /// </summary>
    public readonly partial struct OutputCodeInterpreterCallItem : global::System.IEquatable<OutputCodeInterpreterCallItem>
    {
        /// <summary>
        /// A code interpreter execution call with outputs<br/>
        /// Example: {"code":"print(\u0022Hello, World!\u0022)","container_id":"container-xyz789","id":"code-abc123","outputs":[{"logs":"Hello, World!","type":"logs"}],"status":"completed","type":"code_interpreter_call"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CodeInterpreterCallItem? CodeInterpreterCallItem { get; init; }
#else
        public global::OpenRouter.CodeInterpreterCallItem? CodeInterpreterCallItem { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterCallItem))]
#endif
        public bool IsCodeInterpreterCallItem => CodeInterpreterCallItem != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCodeInterpreterCallItem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.CodeInterpreterCallItem? value)
        {
            value = CodeInterpreterCallItem;
            return IsCodeInterpreterCallItem;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CodeInterpreterCallItem PickCodeInterpreterCallItem() => CodeInterpreterCallItem is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeInterpreterCallItem' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? OutputCodeInterpreterCallItemVariant2 { get; init; }
#else
        public object? OutputCodeInterpreterCallItemVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputCodeInterpreterCallItemVariant2))]
#endif
        public bool IsOutputCodeInterpreterCallItemVariant2 => OutputCodeInterpreterCallItemVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputCodeInterpreterCallItemVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = OutputCodeInterpreterCallItemVariant2;
            return IsOutputCodeInterpreterCallItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickOutputCodeInterpreterCallItemVariant2() => OutputCodeInterpreterCallItemVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputCodeInterpreterCallItemVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputCodeInterpreterCallItem(global::OpenRouter.CodeInterpreterCallItem value) => new OutputCodeInterpreterCallItem((global::OpenRouter.CodeInterpreterCallItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.CodeInterpreterCallItem?(OutputCodeInterpreterCallItem @this) => @this.CodeInterpreterCallItem;

        /// <summary>
        ///
        /// </summary>
        public OutputCodeInterpreterCallItem(global::OpenRouter.CodeInterpreterCallItem? value)
        {
            CodeInterpreterCallItem = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputCodeInterpreterCallItem FromCodeInterpreterCallItem(global::OpenRouter.CodeInterpreterCallItem? value) => new OutputCodeInterpreterCallItem(value);

        /// <summary>
        ///
        /// </summary>
        public OutputCodeInterpreterCallItem(
            global::OpenRouter.CodeInterpreterCallItem? codeInterpreterCallItem,
            object? outputCodeInterpreterCallItemVariant2
            )
        {
            CodeInterpreterCallItem = codeInterpreterCallItem;
            OutputCodeInterpreterCallItemVariant2 = outputCodeInterpreterCallItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            OutputCodeInterpreterCallItemVariant2 as object ??
            CodeInterpreterCallItem as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            CodeInterpreterCallItem?.ToString() ??
            OutputCodeInterpreterCallItemVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCodeInterpreterCallItem && IsOutputCodeInterpreterCallItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.CodeInterpreterCallItem?, TResult>? codeInterpreterCallItem = null,
            global::System.Func<object, TResult>? outputCodeInterpreterCallItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CodeInterpreterCallItem is { } __value0 && codeInterpreterCallItem != null)
            {
                return codeInterpreterCallItem(__value0);
            }
            else if (OutputCodeInterpreterCallItemVariant2 is { } __value1 && outputCodeInterpreterCallItemVariant2 != null)
            {
                return outputCodeInterpreterCallItemVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.CodeInterpreterCallItem?>? codeInterpreterCallItem = null,

            global::System.Action<object>? outputCodeInterpreterCallItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CodeInterpreterCallItem is { } __value0)
            {
                codeInterpreterCallItem?.Invoke(__value0);
            }
            else if (OutputCodeInterpreterCallItemVariant2 is { } __value1)
            {
                outputCodeInterpreterCallItemVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.CodeInterpreterCallItem?>? codeInterpreterCallItem = null,
            global::System.Action<object>? outputCodeInterpreterCallItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CodeInterpreterCallItem is { } __value0)
            {
                codeInterpreterCallItem?.Invoke(__value0);
            }
            else if (OutputCodeInterpreterCallItemVariant2 is { } __value1)
            {
                outputCodeInterpreterCallItemVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CodeInterpreterCallItem,
                typeof(global::OpenRouter.CodeInterpreterCallItem),
                OutputCodeInterpreterCallItemVariant2,
                typeof(object),
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
        public bool Equals(OutputCodeInterpreterCallItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CodeInterpreterCallItem?>.Default.Equals(CodeInterpreterCallItem, other.CodeInterpreterCallItem) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(OutputCodeInterpreterCallItemVariant2, other.OutputCodeInterpreterCallItemVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(OutputCodeInterpreterCallItem obj1, OutputCodeInterpreterCallItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputCodeInterpreterCallItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OutputCodeInterpreterCallItem obj1, OutputCodeInterpreterCallItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputCodeInterpreterCallItem o && Equals(o);
        }
    }
}
