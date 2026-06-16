#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OutputShellCallOutputItemOutputItemsOutcome : global::System.IEquatable<OutputShellCallOutputItemOutputItemsOutcome>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome0? OutputShellCallOutputItemOutputItemsOutcome0 { get; init; }
#else
        public global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome0? OutputShellCallOutputItemOutputItemsOutcome0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputShellCallOutputItemOutputItemsOutcome0))]
#endif
        public bool IsOutputShellCallOutputItemOutputItemsOutcome0 => OutputShellCallOutputItemOutputItemsOutcome0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOutputShellCallOutputItemOutputItemsOutcome0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome0? value)
        {
            value = OutputShellCallOutputItemOutputItemsOutcome0;
            return IsOutputShellCallOutputItemOutputItemsOutcome0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome0 PickOutputShellCallOutputItemOutputItemsOutcome0() => IsOutputShellCallOutputItemOutputItemsOutcome0
            ? OutputShellCallOutputItemOutputItemsOutcome0!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputShellCallOutputItemOutputItemsOutcome0' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome1? OutputShellCallOutputItemOutputItemsOutcome1 { get; init; }
#else
        public global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome1? OutputShellCallOutputItemOutputItemsOutcome1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputShellCallOutputItemOutputItemsOutcome1))]
#endif
        public bool IsOutputShellCallOutputItemOutputItemsOutcome1 => OutputShellCallOutputItemOutputItemsOutcome1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOutputShellCallOutputItemOutputItemsOutcome1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome1? value)
        {
            value = OutputShellCallOutputItemOutputItemsOutcome1;
            return IsOutputShellCallOutputItemOutputItemsOutcome1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome1 PickOutputShellCallOutputItemOutputItemsOutcome1() => IsOutputShellCallOutputItemOutputItemsOutcome1
            ? OutputShellCallOutputItemOutputItemsOutcome1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputShellCallOutputItemOutputItemsOutcome1' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputShellCallOutputItemOutputItemsOutcome(global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome0 value) => new OutputShellCallOutputItemOutputItemsOutcome((global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome0?(OutputShellCallOutputItemOutputItemsOutcome @this) => @this.OutputShellCallOutputItemOutputItemsOutcome0;

        /// <summary>
        /// 
        /// </summary>
        public OutputShellCallOutputItemOutputItemsOutcome(global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome0? value)
        {
            OutputShellCallOutputItemOutputItemsOutcome0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputShellCallOutputItemOutputItemsOutcome FromOutputShellCallOutputItemOutputItemsOutcome0(global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome0? value) => new OutputShellCallOutputItemOutputItemsOutcome(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputShellCallOutputItemOutputItemsOutcome(global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome1 value) => new OutputShellCallOutputItemOutputItemsOutcome((global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome1?(OutputShellCallOutputItemOutputItemsOutcome @this) => @this.OutputShellCallOutputItemOutputItemsOutcome1;

        /// <summary>
        /// 
        /// </summary>
        public OutputShellCallOutputItemOutputItemsOutcome(global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome1? value)
        {
            OutputShellCallOutputItemOutputItemsOutcome1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OutputShellCallOutputItemOutputItemsOutcome FromOutputShellCallOutputItemOutputItemsOutcome1(global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome1? value) => new OutputShellCallOutputItemOutputItemsOutcome(value);

        /// <summary>
        /// 
        /// </summary>
        public OutputShellCallOutputItemOutputItemsOutcome(
            global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome0? outputShellCallOutputItemOutputItemsOutcome0,
            global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome1? outputShellCallOutputItemOutputItemsOutcome1
            )
        {
            OutputShellCallOutputItemOutputItemsOutcome0 = outputShellCallOutputItemOutputItemsOutcome0;
            OutputShellCallOutputItemOutputItemsOutcome1 = outputShellCallOutputItemOutputItemsOutcome1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutputShellCallOutputItemOutputItemsOutcome1 as object ??
            OutputShellCallOutputItemOutputItemsOutcome0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OutputShellCallOutputItemOutputItemsOutcome0?.ToString() ??
            OutputShellCallOutputItemOutputItemsOutcome1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOutputShellCallOutputItemOutputItemsOutcome0 && !IsOutputShellCallOutputItemOutputItemsOutcome1 || !IsOutputShellCallOutputItemOutputItemsOutcome0 && IsOutputShellCallOutputItemOutputItemsOutcome1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome0, TResult>? outputShellCallOutputItemOutputItemsOutcome0 = null,
            global::System.Func<global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome1, TResult>? outputShellCallOutputItemOutputItemsOutcome1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputShellCallOutputItemOutputItemsOutcome0 && outputShellCallOutputItemOutputItemsOutcome0 != null)
            {
                return outputShellCallOutputItemOutputItemsOutcome0(OutputShellCallOutputItemOutputItemsOutcome0!);
            }
            else if (IsOutputShellCallOutputItemOutputItemsOutcome1 && outputShellCallOutputItemOutputItemsOutcome1 != null)
            {
                return outputShellCallOutputItemOutputItemsOutcome1(OutputShellCallOutputItemOutputItemsOutcome1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome0>? outputShellCallOutputItemOutputItemsOutcome0 = null,

            global::System.Action<global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome1>? outputShellCallOutputItemOutputItemsOutcome1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputShellCallOutputItemOutputItemsOutcome0)
            {
                outputShellCallOutputItemOutputItemsOutcome0?.Invoke(OutputShellCallOutputItemOutputItemsOutcome0!);
            }
            else if (IsOutputShellCallOutputItemOutputItemsOutcome1)
            {
                outputShellCallOutputItemOutputItemsOutcome1?.Invoke(OutputShellCallOutputItemOutputItemsOutcome1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome0>? outputShellCallOutputItemOutputItemsOutcome0 = null,
            global::System.Action<global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome1>? outputShellCallOutputItemOutputItemsOutcome1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOutputShellCallOutputItemOutputItemsOutcome0)
            {
                outputShellCallOutputItemOutputItemsOutcome0?.Invoke(OutputShellCallOutputItemOutputItemsOutcome0!);
            }
            else if (IsOutputShellCallOutputItemOutputItemsOutcome1)
            {
                outputShellCallOutputItemOutputItemsOutcome1?.Invoke(OutputShellCallOutputItemOutputItemsOutcome1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OutputShellCallOutputItemOutputItemsOutcome0,
                typeof(global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome0),
                OutputShellCallOutputItemOutputItemsOutcome1,
                typeof(global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome1),
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
        public bool Equals(OutputShellCallOutputItemOutputItemsOutcome other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome0?>.Default.Equals(OutputShellCallOutputItemOutputItemsOutcome0, other.OutputShellCallOutputItemOutputItemsOutcome0) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputShellCallOutputItemOutputItemsOutcome1?>.Default.Equals(OutputShellCallOutputItemOutputItemsOutcome1, other.OutputShellCallOutputItemOutputItemsOutcome1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputShellCallOutputItemOutputItemsOutcome obj1, OutputShellCallOutputItemOutputItemsOutcome obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputShellCallOutputItemOutputItemsOutcome>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputShellCallOutputItemOutputItemsOutcome obj1, OutputShellCallOutputItemOutputItemsOutcome obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputShellCallOutputItemOutputItemsOutcome o && Equals(o);
        }
    }
}
