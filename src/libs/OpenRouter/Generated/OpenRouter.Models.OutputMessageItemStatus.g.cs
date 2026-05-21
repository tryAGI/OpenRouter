#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OutputMessageItemStatus : global::System.IEquatable<OutputMessageItemStatus>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputMessageItemStatus0? OutputMessageItemStatus0 { get; init; }
#else
        public global::OpenRouter.OutputMessageItemStatus0? OutputMessageItemStatus0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputMessageItemStatus0))]
#endif
        public bool IsOutputMessageItemStatus0 => OutputMessageItemStatus0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOutputMessageItemStatus0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputMessageItemStatus0? value)
        {
            value = OutputMessageItemStatus0;
            return IsOutputMessageItemStatus0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputMessageItemStatus0 PickOutputMessageItemStatus0() => IsOutputMessageItemStatus0
            ? OutputMessageItemStatus0!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputMessageItemStatus0' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputMessageItemStatus1? OutputMessageItemStatus1 { get; init; }
#else
        public global::OpenRouter.OutputMessageItemStatus1? OutputMessageItemStatus1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputMessageItemStatus1))]
#endif
        public bool IsOutputMessageItemStatus1 => OutputMessageItemStatus1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOutputMessageItemStatus1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputMessageItemStatus1? value)
        {
            value = OutputMessageItemStatus1;
            return IsOutputMessageItemStatus1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputMessageItemStatus1 PickOutputMessageItemStatus1() => IsOutputMessageItemStatus1
            ? OutputMessageItemStatus1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputMessageItemStatus1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputMessageItemStatus2? OutputMessageItemStatus2 { get; init; }
#else
        public global::OpenRouter.OutputMessageItemStatus2? OutputMessageItemStatus2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputMessageItemStatus2))]
#endif
        public bool IsOutputMessageItemStatus2 => OutputMessageItemStatus2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOutputMessageItemStatus2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputMessageItemStatus2? value)
        {
            value = OutputMessageItemStatus2;
            return IsOutputMessageItemStatus2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputMessageItemStatus2 PickOutputMessageItemStatus2() => IsOutputMessageItemStatus2
            ? OutputMessageItemStatus2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputMessageItemStatus2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputMessageItemStatus(global::OpenRouter.OutputMessageItemStatus0 value) => new OutputMessageItemStatus((global::OpenRouter.OutputMessageItemStatus0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputMessageItemStatus0?(OutputMessageItemStatus @this) => @this.OutputMessageItemStatus0;

        /// <summary>
        /// 
        /// </summary>
        public OutputMessageItemStatus(global::OpenRouter.OutputMessageItemStatus0? value)
        {
            OutputMessageItemStatus0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputMessageItemStatus FromOutputMessageItemStatus0(global::OpenRouter.OutputMessageItemStatus0? value) => new OutputMessageItemStatus(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputMessageItemStatus(global::OpenRouter.OutputMessageItemStatus1 value) => new OutputMessageItemStatus((global::OpenRouter.OutputMessageItemStatus1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputMessageItemStatus1?(OutputMessageItemStatus @this) => @this.OutputMessageItemStatus1;

        /// <summary>
        /// 
        /// </summary>
        public OutputMessageItemStatus(global::OpenRouter.OutputMessageItemStatus1? value)
        {
            OutputMessageItemStatus1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputMessageItemStatus FromOutputMessageItemStatus1(global::OpenRouter.OutputMessageItemStatus1? value) => new OutputMessageItemStatus(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputMessageItemStatus(global::OpenRouter.OutputMessageItemStatus2 value) => new OutputMessageItemStatus((global::OpenRouter.OutputMessageItemStatus2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputMessageItemStatus2?(OutputMessageItemStatus @this) => @this.OutputMessageItemStatus2;

        /// <summary>
        /// 
        /// </summary>
        public OutputMessageItemStatus(global::OpenRouter.OutputMessageItemStatus2? value)
        {
            OutputMessageItemStatus2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputMessageItemStatus FromOutputMessageItemStatus2(global::OpenRouter.OutputMessageItemStatus2? value) => new OutputMessageItemStatus(value);

        /// <summary>
        /// 
        /// </summary>
        public OutputMessageItemStatus(
            global::OpenRouter.OutputMessageItemStatus0? outputMessageItemStatus0,
            global::OpenRouter.OutputMessageItemStatus1? outputMessageItemStatus1,
            global::OpenRouter.OutputMessageItemStatus2? outputMessageItemStatus2
            )
        {
            OutputMessageItemStatus0 = outputMessageItemStatus0;
            OutputMessageItemStatus1 = outputMessageItemStatus1;
            OutputMessageItemStatus2 = outputMessageItemStatus2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutputMessageItemStatus2 as object ??
            OutputMessageItemStatus1 as object ??
            OutputMessageItemStatus0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OutputMessageItemStatus0?.ToValueString() ??
            OutputMessageItemStatus1?.ToValueString() ??
            OutputMessageItemStatus2?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOutputMessageItemStatus0 && !IsOutputMessageItemStatus1 && !IsOutputMessageItemStatus2 || !IsOutputMessageItemStatus0 && IsOutputMessageItemStatus1 && !IsOutputMessageItemStatus2 || !IsOutputMessageItemStatus0 && !IsOutputMessageItemStatus1 && IsOutputMessageItemStatus2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OutputMessageItemStatus0?, TResult>? outputMessageItemStatus0 = null,
            global::System.Func<global::OpenRouter.OutputMessageItemStatus1?, TResult>? outputMessageItemStatus1 = null,
            global::System.Func<global::OpenRouter.OutputMessageItemStatus2?, TResult>? outputMessageItemStatus2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputMessageItemStatus0 && outputMessageItemStatus0 != null)
            {
                return outputMessageItemStatus0(OutputMessageItemStatus0!);
            }
            else if (IsOutputMessageItemStatus1 && outputMessageItemStatus1 != null)
            {
                return outputMessageItemStatus1(OutputMessageItemStatus1!);
            }
            else if (IsOutputMessageItemStatus2 && outputMessageItemStatus2 != null)
            {
                return outputMessageItemStatus2(OutputMessageItemStatus2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OutputMessageItemStatus0?>? outputMessageItemStatus0 = null,

            global::System.Action<global::OpenRouter.OutputMessageItemStatus1?>? outputMessageItemStatus1 = null,

            global::System.Action<global::OpenRouter.OutputMessageItemStatus2?>? outputMessageItemStatus2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputMessageItemStatus0)
            {
                outputMessageItemStatus0?.Invoke(OutputMessageItemStatus0!);
            }
            else if (IsOutputMessageItemStatus1)
            {
                outputMessageItemStatus1?.Invoke(OutputMessageItemStatus1!);
            }
            else if (IsOutputMessageItemStatus2)
            {
                outputMessageItemStatus2?.Invoke(OutputMessageItemStatus2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OutputMessageItemStatus0?>? outputMessageItemStatus0 = null,
            global::System.Action<global::OpenRouter.OutputMessageItemStatus1?>? outputMessageItemStatus1 = null,
            global::System.Action<global::OpenRouter.OutputMessageItemStatus2?>? outputMessageItemStatus2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputMessageItemStatus0)
            {
                outputMessageItemStatus0?.Invoke(OutputMessageItemStatus0!);
            }
            else if (IsOutputMessageItemStatus1)
            {
                outputMessageItemStatus1?.Invoke(OutputMessageItemStatus1!);
            }
            else if (IsOutputMessageItemStatus2)
            {
                outputMessageItemStatus2?.Invoke(OutputMessageItemStatus2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OutputMessageItemStatus0,
                typeof(global::OpenRouter.OutputMessageItemStatus0),
                OutputMessageItemStatus1,
                typeof(global::OpenRouter.OutputMessageItemStatus1),
                OutputMessageItemStatus2,
                typeof(global::OpenRouter.OutputMessageItemStatus2),
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
        public bool Equals(OutputMessageItemStatus other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputMessageItemStatus0?>.Default.Equals(OutputMessageItemStatus0, other.OutputMessageItemStatus0) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputMessageItemStatus1?>.Default.Equals(OutputMessageItemStatus1, other.OutputMessageItemStatus1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputMessageItemStatus2?>.Default.Equals(OutputMessageItemStatus2, other.OutputMessageItemStatus2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputMessageItemStatus obj1, OutputMessageItemStatus obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputMessageItemStatus>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputMessageItemStatus obj1, OutputMessageItemStatus obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputMessageItemStatus o && Equals(o);
        }
    }
}
