#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ReasoningItemStatus : global::System.IEquatable<ReasoningItemStatus>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ReasoningItemStatus0? ReasoningItemStatus0 { get; init; }
#else
        public global::OpenRouter.ReasoningItemStatus0? ReasoningItemStatus0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningItemStatus0))]
#endif
        public bool IsReasoningItemStatus0 => ReasoningItemStatus0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReasoningItemStatus0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ReasoningItemStatus0? value)
        {
            value = ReasoningItemStatus0;
            return IsReasoningItemStatus0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ReasoningItemStatus0 PickReasoningItemStatus0() => IsReasoningItemStatus0
            ? ReasoningItemStatus0!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReasoningItemStatus0' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ReasoningItemStatus1? ReasoningItemStatus1 { get; init; }
#else
        public global::OpenRouter.ReasoningItemStatus1? ReasoningItemStatus1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningItemStatus1))]
#endif
        public bool IsReasoningItemStatus1 => ReasoningItemStatus1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReasoningItemStatus1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ReasoningItemStatus1? value)
        {
            value = ReasoningItemStatus1;
            return IsReasoningItemStatus1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ReasoningItemStatus1 PickReasoningItemStatus1() => IsReasoningItemStatus1
            ? ReasoningItemStatus1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReasoningItemStatus1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ReasoningItemStatus2? ReasoningItemStatus2 { get; init; }
#else
        public global::OpenRouter.ReasoningItemStatus2? ReasoningItemStatus2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningItemStatus2))]
#endif
        public bool IsReasoningItemStatus2 => ReasoningItemStatus2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickReasoningItemStatus2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ReasoningItemStatus2? value)
        {
            value = ReasoningItemStatus2;
            return IsReasoningItemStatus2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ReasoningItemStatus2 PickReasoningItemStatus2() => IsReasoningItemStatus2
            ? ReasoningItemStatus2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReasoningItemStatus2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReasoningItemStatus(global::OpenRouter.ReasoningItemStatus0 value) => new ReasoningItemStatus((global::OpenRouter.ReasoningItemStatus0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ReasoningItemStatus0?(ReasoningItemStatus @this) => @this.ReasoningItemStatus0;

        /// <summary>
        /// 
        /// </summary>
        public ReasoningItemStatus(global::OpenRouter.ReasoningItemStatus0? value)
        {
            ReasoningItemStatus0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ReasoningItemStatus FromReasoningItemStatus0(global::OpenRouter.ReasoningItemStatus0? value) => new ReasoningItemStatus(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReasoningItemStatus(global::OpenRouter.ReasoningItemStatus1 value) => new ReasoningItemStatus((global::OpenRouter.ReasoningItemStatus1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ReasoningItemStatus1?(ReasoningItemStatus @this) => @this.ReasoningItemStatus1;

        /// <summary>
        /// 
        /// </summary>
        public ReasoningItemStatus(global::OpenRouter.ReasoningItemStatus1? value)
        {
            ReasoningItemStatus1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ReasoningItemStatus FromReasoningItemStatus1(global::OpenRouter.ReasoningItemStatus1? value) => new ReasoningItemStatus(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReasoningItemStatus(global::OpenRouter.ReasoningItemStatus2 value) => new ReasoningItemStatus((global::OpenRouter.ReasoningItemStatus2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ReasoningItemStatus2?(ReasoningItemStatus @this) => @this.ReasoningItemStatus2;

        /// <summary>
        /// 
        /// </summary>
        public ReasoningItemStatus(global::OpenRouter.ReasoningItemStatus2? value)
        {
            ReasoningItemStatus2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ReasoningItemStatus FromReasoningItemStatus2(global::OpenRouter.ReasoningItemStatus2? value) => new ReasoningItemStatus(value);

        /// <summary>
        /// 
        /// </summary>
        public ReasoningItemStatus(
            global::OpenRouter.ReasoningItemStatus0? reasoningItemStatus0,
            global::OpenRouter.ReasoningItemStatus1? reasoningItemStatus1,
            global::OpenRouter.ReasoningItemStatus2? reasoningItemStatus2
            )
        {
            ReasoningItemStatus0 = reasoningItemStatus0;
            ReasoningItemStatus1 = reasoningItemStatus1;
            ReasoningItemStatus2 = reasoningItemStatus2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ReasoningItemStatus2 as object ??
            ReasoningItemStatus1 as object ??
            ReasoningItemStatus0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ReasoningItemStatus0?.ToValueString() ??
            ReasoningItemStatus1?.ToValueString() ??
            ReasoningItemStatus2?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsReasoningItemStatus0 && !IsReasoningItemStatus1 && !IsReasoningItemStatus2 || !IsReasoningItemStatus0 && IsReasoningItemStatus1 && !IsReasoningItemStatus2 || !IsReasoningItemStatus0 && !IsReasoningItemStatus1 && IsReasoningItemStatus2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ReasoningItemStatus0?, TResult>? reasoningItemStatus0 = null,
            global::System.Func<global::OpenRouter.ReasoningItemStatus1?, TResult>? reasoningItemStatus1 = null,
            global::System.Func<global::OpenRouter.ReasoningItemStatus2?, TResult>? reasoningItemStatus2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReasoningItemStatus0 && reasoningItemStatus0 != null)
            {
                return reasoningItemStatus0(ReasoningItemStatus0!);
            }
            else if (IsReasoningItemStatus1 && reasoningItemStatus1 != null)
            {
                return reasoningItemStatus1(ReasoningItemStatus1!);
            }
            else if (IsReasoningItemStatus2 && reasoningItemStatus2 != null)
            {
                return reasoningItemStatus2(ReasoningItemStatus2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ReasoningItemStatus0?>? reasoningItemStatus0 = null,

            global::System.Action<global::OpenRouter.ReasoningItemStatus1?>? reasoningItemStatus1 = null,

            global::System.Action<global::OpenRouter.ReasoningItemStatus2?>? reasoningItemStatus2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReasoningItemStatus0)
            {
                reasoningItemStatus0?.Invoke(ReasoningItemStatus0!);
            }
            else if (IsReasoningItemStatus1)
            {
                reasoningItemStatus1?.Invoke(ReasoningItemStatus1!);
            }
            else if (IsReasoningItemStatus2)
            {
                reasoningItemStatus2?.Invoke(ReasoningItemStatus2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ReasoningItemStatus0?>? reasoningItemStatus0 = null,
            global::System.Action<global::OpenRouter.ReasoningItemStatus1?>? reasoningItemStatus1 = null,
            global::System.Action<global::OpenRouter.ReasoningItemStatus2?>? reasoningItemStatus2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsReasoningItemStatus0)
            {
                reasoningItemStatus0?.Invoke(ReasoningItemStatus0!);
            }
            else if (IsReasoningItemStatus1)
            {
                reasoningItemStatus1?.Invoke(ReasoningItemStatus1!);
            }
            else if (IsReasoningItemStatus2)
            {
                reasoningItemStatus2?.Invoke(ReasoningItemStatus2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ReasoningItemStatus0,
                typeof(global::OpenRouter.ReasoningItemStatus0),
                ReasoningItemStatus1,
                typeof(global::OpenRouter.ReasoningItemStatus1),
                ReasoningItemStatus2,
                typeof(global::OpenRouter.ReasoningItemStatus2),
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
        public bool Equals(ReasoningItemStatus other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ReasoningItemStatus0?>.Default.Equals(ReasoningItemStatus0, other.ReasoningItemStatus0) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ReasoningItemStatus1?>.Default.Equals(ReasoningItemStatus1, other.ReasoningItemStatus1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ReasoningItemStatus2?>.Default.Equals(ReasoningItemStatus2, other.ReasoningItemStatus2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ReasoningItemStatus obj1, ReasoningItemStatus obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ReasoningItemStatus>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ReasoningItemStatus obj1, ReasoningItemStatus obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReasoningItemStatus o && Equals(o);
        }
    }
}
