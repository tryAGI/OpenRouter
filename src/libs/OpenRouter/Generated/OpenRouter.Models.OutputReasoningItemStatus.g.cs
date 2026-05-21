#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OutputReasoningItemStatus : global::System.IEquatable<OutputReasoningItemStatus>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputReasoningItemStatus0? OutputReasoningItemStatus0 { get; init; }
#else
        public global::OpenRouter.OutputReasoningItemStatus0? OutputReasoningItemStatus0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputReasoningItemStatus0))]
#endif
        public bool IsOutputReasoningItemStatus0 => OutputReasoningItemStatus0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOutputReasoningItemStatus0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputReasoningItemStatus0? value)
        {
            value = OutputReasoningItemStatus0;
            return IsOutputReasoningItemStatus0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputReasoningItemStatus0 PickOutputReasoningItemStatus0() => IsOutputReasoningItemStatus0
            ? OutputReasoningItemStatus0!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputReasoningItemStatus0' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputReasoningItemStatus1? OutputReasoningItemStatus1 { get; init; }
#else
        public global::OpenRouter.OutputReasoningItemStatus1? OutputReasoningItemStatus1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputReasoningItemStatus1))]
#endif
        public bool IsOutputReasoningItemStatus1 => OutputReasoningItemStatus1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOutputReasoningItemStatus1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputReasoningItemStatus1? value)
        {
            value = OutputReasoningItemStatus1;
            return IsOutputReasoningItemStatus1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputReasoningItemStatus1 PickOutputReasoningItemStatus1() => IsOutputReasoningItemStatus1
            ? OutputReasoningItemStatus1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputReasoningItemStatus1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputReasoningItemStatus2? OutputReasoningItemStatus2 { get; init; }
#else
        public global::OpenRouter.OutputReasoningItemStatus2? OutputReasoningItemStatus2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputReasoningItemStatus2))]
#endif
        public bool IsOutputReasoningItemStatus2 => OutputReasoningItemStatus2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOutputReasoningItemStatus2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputReasoningItemStatus2? value)
        {
            value = OutputReasoningItemStatus2;
            return IsOutputReasoningItemStatus2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputReasoningItemStatus2 PickOutputReasoningItemStatus2() => IsOutputReasoningItemStatus2
            ? OutputReasoningItemStatus2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputReasoningItemStatus2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputReasoningItemStatus(global::OpenRouter.OutputReasoningItemStatus0 value) => new OutputReasoningItemStatus((global::OpenRouter.OutputReasoningItemStatus0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputReasoningItemStatus0?(OutputReasoningItemStatus @this) => @this.OutputReasoningItemStatus0;

        /// <summary>
        /// 
        /// </summary>
        public OutputReasoningItemStatus(global::OpenRouter.OutputReasoningItemStatus0? value)
        {
            OutputReasoningItemStatus0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputReasoningItemStatus FromOutputReasoningItemStatus0(global::OpenRouter.OutputReasoningItemStatus0? value) => new OutputReasoningItemStatus(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputReasoningItemStatus(global::OpenRouter.OutputReasoningItemStatus1 value) => new OutputReasoningItemStatus((global::OpenRouter.OutputReasoningItemStatus1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputReasoningItemStatus1?(OutputReasoningItemStatus @this) => @this.OutputReasoningItemStatus1;

        /// <summary>
        /// 
        /// </summary>
        public OutputReasoningItemStatus(global::OpenRouter.OutputReasoningItemStatus1? value)
        {
            OutputReasoningItemStatus1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputReasoningItemStatus FromOutputReasoningItemStatus1(global::OpenRouter.OutputReasoningItemStatus1? value) => new OutputReasoningItemStatus(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputReasoningItemStatus(global::OpenRouter.OutputReasoningItemStatus2 value) => new OutputReasoningItemStatus((global::OpenRouter.OutputReasoningItemStatus2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputReasoningItemStatus2?(OutputReasoningItemStatus @this) => @this.OutputReasoningItemStatus2;

        /// <summary>
        /// 
        /// </summary>
        public OutputReasoningItemStatus(global::OpenRouter.OutputReasoningItemStatus2? value)
        {
            OutputReasoningItemStatus2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputReasoningItemStatus FromOutputReasoningItemStatus2(global::OpenRouter.OutputReasoningItemStatus2? value) => new OutputReasoningItemStatus(value);

        /// <summary>
        /// 
        /// </summary>
        public OutputReasoningItemStatus(
            global::OpenRouter.OutputReasoningItemStatus0? outputReasoningItemStatus0,
            global::OpenRouter.OutputReasoningItemStatus1? outputReasoningItemStatus1,
            global::OpenRouter.OutputReasoningItemStatus2? outputReasoningItemStatus2
            )
        {
            OutputReasoningItemStatus0 = outputReasoningItemStatus0;
            OutputReasoningItemStatus1 = outputReasoningItemStatus1;
            OutputReasoningItemStatus2 = outputReasoningItemStatus2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutputReasoningItemStatus2 as object ??
            OutputReasoningItemStatus1 as object ??
            OutputReasoningItemStatus0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OutputReasoningItemStatus0?.ToValueString() ??
            OutputReasoningItemStatus1?.ToValueString() ??
            OutputReasoningItemStatus2?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOutputReasoningItemStatus0 && !IsOutputReasoningItemStatus1 && !IsOutputReasoningItemStatus2 || !IsOutputReasoningItemStatus0 && IsOutputReasoningItemStatus1 && !IsOutputReasoningItemStatus2 || !IsOutputReasoningItemStatus0 && !IsOutputReasoningItemStatus1 && IsOutputReasoningItemStatus2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OutputReasoningItemStatus0?, TResult>? outputReasoningItemStatus0 = null,
            global::System.Func<global::OpenRouter.OutputReasoningItemStatus1?, TResult>? outputReasoningItemStatus1 = null,
            global::System.Func<global::OpenRouter.OutputReasoningItemStatus2?, TResult>? outputReasoningItemStatus2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputReasoningItemStatus0 && outputReasoningItemStatus0 != null)
            {
                return outputReasoningItemStatus0(OutputReasoningItemStatus0!);
            }
            else if (IsOutputReasoningItemStatus1 && outputReasoningItemStatus1 != null)
            {
                return outputReasoningItemStatus1(OutputReasoningItemStatus1!);
            }
            else if (IsOutputReasoningItemStatus2 && outputReasoningItemStatus2 != null)
            {
                return outputReasoningItemStatus2(OutputReasoningItemStatus2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OutputReasoningItemStatus0?>? outputReasoningItemStatus0 = null,

            global::System.Action<global::OpenRouter.OutputReasoningItemStatus1?>? outputReasoningItemStatus1 = null,

            global::System.Action<global::OpenRouter.OutputReasoningItemStatus2?>? outputReasoningItemStatus2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputReasoningItemStatus0)
            {
                outputReasoningItemStatus0?.Invoke(OutputReasoningItemStatus0!);
            }
            else if (IsOutputReasoningItemStatus1)
            {
                outputReasoningItemStatus1?.Invoke(OutputReasoningItemStatus1!);
            }
            else if (IsOutputReasoningItemStatus2)
            {
                outputReasoningItemStatus2?.Invoke(OutputReasoningItemStatus2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OutputReasoningItemStatus0?>? outputReasoningItemStatus0 = null,
            global::System.Action<global::OpenRouter.OutputReasoningItemStatus1?>? outputReasoningItemStatus1 = null,
            global::System.Action<global::OpenRouter.OutputReasoningItemStatus2?>? outputReasoningItemStatus2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputReasoningItemStatus0)
            {
                outputReasoningItemStatus0?.Invoke(OutputReasoningItemStatus0!);
            }
            else if (IsOutputReasoningItemStatus1)
            {
                outputReasoningItemStatus1?.Invoke(OutputReasoningItemStatus1!);
            }
            else if (IsOutputReasoningItemStatus2)
            {
                outputReasoningItemStatus2?.Invoke(OutputReasoningItemStatus2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OutputReasoningItemStatus0,
                typeof(global::OpenRouter.OutputReasoningItemStatus0),
                OutputReasoningItemStatus1,
                typeof(global::OpenRouter.OutputReasoningItemStatus1),
                OutputReasoningItemStatus2,
                typeof(global::OpenRouter.OutputReasoningItemStatus2),
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
        public bool Equals(OutputReasoningItemStatus other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputReasoningItemStatus0?>.Default.Equals(OutputReasoningItemStatus0, other.OutputReasoningItemStatus0) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputReasoningItemStatus1?>.Default.Equals(OutputReasoningItemStatus1, other.OutputReasoningItemStatus1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputReasoningItemStatus2?>.Default.Equals(OutputReasoningItemStatus2, other.OutputReasoningItemStatus2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputReasoningItemStatus obj1, OutputReasoningItemStatus obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputReasoningItemStatus>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputReasoningItemStatus obj1, OutputReasoningItemStatus obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputReasoningItemStatus o && Equals(o);
        }
    }
}
