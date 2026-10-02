#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when a reasoning summary part is complete<br/>
    /// Example: {"item_id":"item-1","output_index":0,"part":{"text":"Analyzing the problem step by step to find the optimal solution.","type":"summary_text"},"sequence_number":7,"summary_index":0,"type":"response.reasoning_summary_part.done"}
    /// </summary>
    public readonly partial struct ReasoningSummaryPartDoneEvent : global::System.IEquatable<ReasoningSummaryPartDoneEvent>
    {
        /// <summary>
        /// Event emitted when a reasoning summary part is complete<br/>
        /// Example: {"item_id":"item-1","output_index":0,"part":{"text":"Analyzing the problem step by step to find the optimal solution.","type":"summary_text"},"sequence_number":7,"summary_index":0,"type":"response.reasoning_summary_part.done"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseReasoningSummaryPartDoneEvent? Base { get; init; }
#else
        public global::OpenRouter.BaseReasoningSummaryPartDoneEvent? Base { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.BaseReasoningSummaryPartDoneEvent? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningSummaryPartDoneEvent PickBase() => Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ReasoningSummaryPartDoneEventVariant2 { get; init; }
#else
        public object? ReasoningSummaryPartDoneEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningSummaryPartDoneEventVariant2))]
#endif
        public bool IsReasoningSummaryPartDoneEventVariant2 => ReasoningSummaryPartDoneEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickReasoningSummaryPartDoneEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = ReasoningSummaryPartDoneEventVariant2;
            return IsReasoningSummaryPartDoneEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickReasoningSummaryPartDoneEventVariant2() => ReasoningSummaryPartDoneEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReasoningSummaryPartDoneEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ReasoningSummaryPartDoneEvent(global::OpenRouter.BaseReasoningSummaryPartDoneEvent value) => new ReasoningSummaryPartDoneEvent((global::OpenRouter.BaseReasoningSummaryPartDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.BaseReasoningSummaryPartDoneEvent?(ReasoningSummaryPartDoneEvent @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public ReasoningSummaryPartDoneEvent(global::OpenRouter.BaseReasoningSummaryPartDoneEvent? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ReasoningSummaryPartDoneEvent FromBase(global::OpenRouter.BaseReasoningSummaryPartDoneEvent? value) => new ReasoningSummaryPartDoneEvent(value);

        /// <summary>
        ///
        /// </summary>
        public ReasoningSummaryPartDoneEvent(
            global::OpenRouter.BaseReasoningSummaryPartDoneEvent? @base,
            object? reasoningSummaryPartDoneEventVariant2
            )
        {
            Base = @base;
            ReasoningSummaryPartDoneEventVariant2 = reasoningSummaryPartDoneEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ReasoningSummaryPartDoneEventVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ReasoningSummaryPartDoneEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsReasoningSummaryPartDoneEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.BaseReasoningSummaryPartDoneEvent, TResult>? @base = null,
            global::System.Func<object, TResult>? reasoningSummaryPartDoneEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0 && @base != null)
            {
                return @base(__value0);
            }
            else if (ReasoningSummaryPartDoneEventVariant2 is { } __value1 && reasoningSummaryPartDoneEventVariant2 != null)
            {
                return reasoningSummaryPartDoneEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.BaseReasoningSummaryPartDoneEvent>? @base = null,

            global::System.Action<object>? reasoningSummaryPartDoneEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0)
            {
                @base?.Invoke(__value0);
            }
            else if (ReasoningSummaryPartDoneEventVariant2 is { } __value1)
            {
                reasoningSummaryPartDoneEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.BaseReasoningSummaryPartDoneEvent>? @base = null,
            global::System.Action<object>? reasoningSummaryPartDoneEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base is { } __value0)
            {
                @base?.Invoke(__value0);
            }
            else if (ReasoningSummaryPartDoneEventVariant2 is { } __value1)
            {
                reasoningSummaryPartDoneEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::OpenRouter.BaseReasoningSummaryPartDoneEvent),
                ReasoningSummaryPartDoneEventVariant2,
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
        public bool Equals(ReasoningSummaryPartDoneEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseReasoningSummaryPartDoneEvent?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ReasoningSummaryPartDoneEventVariant2, other.ReasoningSummaryPartDoneEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ReasoningSummaryPartDoneEvent obj1, ReasoningSummaryPartDoneEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ReasoningSummaryPartDoneEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ReasoningSummaryPartDoneEvent obj1, ReasoningSummaryPartDoneEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReasoningSummaryPartDoneEvent o && Equals(o);
        }
    }
}
