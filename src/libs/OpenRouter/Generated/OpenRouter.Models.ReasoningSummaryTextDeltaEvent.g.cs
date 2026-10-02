#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when reasoning summary text delta is streamed<br/>
    /// Example: {"delta":"Analyzing","item_id":"item-1","output_index":0,"sequence_number":4,"summary_index":0,"type":"response.reasoning_summary_text.delta"}
    /// </summary>
    public readonly partial struct ReasoningSummaryTextDeltaEvent : global::System.IEquatable<ReasoningSummaryTextDeltaEvent>
    {
        /// <summary>
        /// Event emitted when reasoning summary text delta is streamed<br/>
        /// Example: {"delta":"Analyzing","item_id":"item-1","output_index":0,"sequence_number":4,"summary_index":0,"type":"response.reasoning_summary_text.delta"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseReasoningSummaryTextDeltaEvent? Base { get; init; }
#else
        public global::OpenRouter.BaseReasoningSummaryTextDeltaEvent? Base { get; }
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
            out global::OpenRouter.BaseReasoningSummaryTextDeltaEvent? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningSummaryTextDeltaEvent PickBase() => Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ReasoningSummaryTextDeltaEventVariant2 { get; init; }
#else
        public object? ReasoningSummaryTextDeltaEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningSummaryTextDeltaEventVariant2))]
#endif
        public bool IsReasoningSummaryTextDeltaEventVariant2 => ReasoningSummaryTextDeltaEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickReasoningSummaryTextDeltaEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = ReasoningSummaryTextDeltaEventVariant2;
            return IsReasoningSummaryTextDeltaEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickReasoningSummaryTextDeltaEventVariant2() => ReasoningSummaryTextDeltaEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReasoningSummaryTextDeltaEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ReasoningSummaryTextDeltaEvent(global::OpenRouter.BaseReasoningSummaryTextDeltaEvent value) => new ReasoningSummaryTextDeltaEvent((global::OpenRouter.BaseReasoningSummaryTextDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.BaseReasoningSummaryTextDeltaEvent?(ReasoningSummaryTextDeltaEvent @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public ReasoningSummaryTextDeltaEvent(global::OpenRouter.BaseReasoningSummaryTextDeltaEvent? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ReasoningSummaryTextDeltaEvent FromBase(global::OpenRouter.BaseReasoningSummaryTextDeltaEvent? value) => new ReasoningSummaryTextDeltaEvent(value);

        /// <summary>
        ///
        /// </summary>
        public ReasoningSummaryTextDeltaEvent(
            global::OpenRouter.BaseReasoningSummaryTextDeltaEvent? @base,
            object? reasoningSummaryTextDeltaEventVariant2
            )
        {
            Base = @base;
            ReasoningSummaryTextDeltaEventVariant2 = reasoningSummaryTextDeltaEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ReasoningSummaryTextDeltaEventVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ReasoningSummaryTextDeltaEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsReasoningSummaryTextDeltaEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.BaseReasoningSummaryTextDeltaEvent, TResult>? @base = null,
            global::System.Func<object, TResult>? reasoningSummaryTextDeltaEventVariant2 = null,
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
            else if (ReasoningSummaryTextDeltaEventVariant2 is { } __value1 && reasoningSummaryTextDeltaEventVariant2 != null)
            {
                return reasoningSummaryTextDeltaEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.BaseReasoningSummaryTextDeltaEvent>? @base = null,

            global::System.Action<object>? reasoningSummaryTextDeltaEventVariant2 = null,
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
            else if (ReasoningSummaryTextDeltaEventVariant2 is { } __value1)
            {
                reasoningSummaryTextDeltaEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.BaseReasoningSummaryTextDeltaEvent>? @base = null,
            global::System.Action<object>? reasoningSummaryTextDeltaEventVariant2 = null,
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
            else if (ReasoningSummaryTextDeltaEventVariant2 is { } __value1)
            {
                reasoningSummaryTextDeltaEventVariant2?.Invoke(__value1);
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
                typeof(global::OpenRouter.BaseReasoningSummaryTextDeltaEvent),
                ReasoningSummaryTextDeltaEventVariant2,
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
        public bool Equals(ReasoningSummaryTextDeltaEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseReasoningSummaryTextDeltaEvent?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ReasoningSummaryTextDeltaEventVariant2, other.ReasoningSummaryTextDeltaEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ReasoningSummaryTextDeltaEvent obj1, ReasoningSummaryTextDeltaEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ReasoningSummaryTextDeltaEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ReasoningSummaryTextDeltaEvent obj1, ReasoningSummaryTextDeltaEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReasoningSummaryTextDeltaEvent o && Equals(o);
        }
    }
}
