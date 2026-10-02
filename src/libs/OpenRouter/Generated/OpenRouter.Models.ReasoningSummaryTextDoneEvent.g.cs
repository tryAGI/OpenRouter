#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when reasoning summary text streaming is complete<br/>
    /// Example: {"item_id":"item-1","output_index":0,"sequence_number":6,"summary_index":0,"text":"Analyzing the problem step by step to find the optimal solution.","type":"response.reasoning_summary_text.done"}
    /// </summary>
    public readonly partial struct ReasoningSummaryTextDoneEvent : global::System.IEquatable<ReasoningSummaryTextDoneEvent>
    {
        /// <summary>
        /// Event emitted when reasoning summary text streaming is complete<br/>
        /// Example: {"item_id":"item-1","output_index":0,"sequence_number":6,"summary_index":0,"text":"Analyzing the problem step by step to find the optimal solution.","type":"response.reasoning_summary_text.done"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseReasoningSummaryTextDoneEvent? Base { get; init; }
#else
        public global::OpenRouter.BaseReasoningSummaryTextDoneEvent? Base { get; }
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
            out global::OpenRouter.BaseReasoningSummaryTextDoneEvent? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningSummaryTextDoneEvent PickBase() => Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ReasoningSummaryTextDoneEventVariant2 { get; init; }
#else
        public object? ReasoningSummaryTextDoneEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningSummaryTextDoneEventVariant2))]
#endif
        public bool IsReasoningSummaryTextDoneEventVariant2 => ReasoningSummaryTextDoneEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickReasoningSummaryTextDoneEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = ReasoningSummaryTextDoneEventVariant2;
            return IsReasoningSummaryTextDoneEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickReasoningSummaryTextDoneEventVariant2() => ReasoningSummaryTextDoneEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReasoningSummaryTextDoneEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ReasoningSummaryTextDoneEvent(global::OpenRouter.BaseReasoningSummaryTextDoneEvent value) => new ReasoningSummaryTextDoneEvent((global::OpenRouter.BaseReasoningSummaryTextDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.BaseReasoningSummaryTextDoneEvent?(ReasoningSummaryTextDoneEvent @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public ReasoningSummaryTextDoneEvent(global::OpenRouter.BaseReasoningSummaryTextDoneEvent? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ReasoningSummaryTextDoneEvent FromBase(global::OpenRouter.BaseReasoningSummaryTextDoneEvent? value) => new ReasoningSummaryTextDoneEvent(value);

        /// <summary>
        ///
        /// </summary>
        public ReasoningSummaryTextDoneEvent(
            global::OpenRouter.BaseReasoningSummaryTextDoneEvent? @base,
            object? reasoningSummaryTextDoneEventVariant2
            )
        {
            Base = @base;
            ReasoningSummaryTextDoneEventVariant2 = reasoningSummaryTextDoneEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ReasoningSummaryTextDoneEventVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ReasoningSummaryTextDoneEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsReasoningSummaryTextDoneEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.BaseReasoningSummaryTextDoneEvent, TResult>? @base = null,
            global::System.Func<object, TResult>? reasoningSummaryTextDoneEventVariant2 = null,
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
            else if (ReasoningSummaryTextDoneEventVariant2 is { } __value1 && reasoningSummaryTextDoneEventVariant2 != null)
            {
                return reasoningSummaryTextDoneEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.BaseReasoningSummaryTextDoneEvent>? @base = null,

            global::System.Action<object>? reasoningSummaryTextDoneEventVariant2 = null,
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
            else if (ReasoningSummaryTextDoneEventVariant2 is { } __value1)
            {
                reasoningSummaryTextDoneEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.BaseReasoningSummaryTextDoneEvent>? @base = null,
            global::System.Action<object>? reasoningSummaryTextDoneEventVariant2 = null,
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
            else if (ReasoningSummaryTextDoneEventVariant2 is { } __value1)
            {
                reasoningSummaryTextDoneEventVariant2?.Invoke(__value1);
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
                typeof(global::OpenRouter.BaseReasoningSummaryTextDoneEvent),
                ReasoningSummaryTextDoneEventVariant2,
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
        public bool Equals(ReasoningSummaryTextDoneEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseReasoningSummaryTextDoneEvent?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ReasoningSummaryTextDoneEventVariant2, other.ReasoningSummaryTextDoneEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ReasoningSummaryTextDoneEvent obj1, ReasoningSummaryTextDoneEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ReasoningSummaryTextDoneEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ReasoningSummaryTextDoneEvent obj1, ReasoningSummaryTextDoneEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReasoningSummaryTextDoneEvent o && Equals(o);
        }
    }
}
