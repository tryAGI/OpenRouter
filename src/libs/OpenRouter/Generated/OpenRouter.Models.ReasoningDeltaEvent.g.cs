#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when reasoning text delta is streamed<br/>
    /// Example: {"content_index":0,"delta":"First, we need","item_id":"item-1","output_index":0,"sequence_number":4,"type":"response.reasoning_text.delta"}
    /// </summary>
    public readonly partial struct ReasoningDeltaEvent : global::System.IEquatable<ReasoningDeltaEvent>
    {
        /// <summary>
        /// Event emitted when reasoning text delta is streamed<br/>
        /// Example: {"content_index":0,"delta":"First, we need","item_id":"item-1","output_index":0,"sequence_number":4,"type":"response.reasoning_text.delta"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseReasoningDeltaEvent? Base { get; init; }
#else
        public global::OpenRouter.BaseReasoningDeltaEvent? Base { get; }
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
            out global::OpenRouter.BaseReasoningDeltaEvent? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningDeltaEvent PickBase() => Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ReasoningDeltaEventVariant2 { get; init; }
#else
        public object? ReasoningDeltaEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningDeltaEventVariant2))]
#endif
        public bool IsReasoningDeltaEventVariant2 => ReasoningDeltaEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickReasoningDeltaEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = ReasoningDeltaEventVariant2;
            return IsReasoningDeltaEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickReasoningDeltaEventVariant2() => ReasoningDeltaEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReasoningDeltaEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ReasoningDeltaEvent(global::OpenRouter.BaseReasoningDeltaEvent value) => new ReasoningDeltaEvent((global::OpenRouter.BaseReasoningDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.BaseReasoningDeltaEvent?(ReasoningDeltaEvent @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public ReasoningDeltaEvent(global::OpenRouter.BaseReasoningDeltaEvent? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ReasoningDeltaEvent FromBase(global::OpenRouter.BaseReasoningDeltaEvent? value) => new ReasoningDeltaEvent(value);

        /// <summary>
        ///
        /// </summary>
        public ReasoningDeltaEvent(
            global::OpenRouter.BaseReasoningDeltaEvent? @base,
            object? reasoningDeltaEventVariant2
            )
        {
            Base = @base;
            ReasoningDeltaEventVariant2 = reasoningDeltaEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ReasoningDeltaEventVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ReasoningDeltaEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsReasoningDeltaEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.BaseReasoningDeltaEvent, TResult>? @base = null,
            global::System.Func<object, TResult>? reasoningDeltaEventVariant2 = null,
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
            else if (ReasoningDeltaEventVariant2 is { } __value1 && reasoningDeltaEventVariant2 != null)
            {
                return reasoningDeltaEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.BaseReasoningDeltaEvent>? @base = null,

            global::System.Action<object>? reasoningDeltaEventVariant2 = null,
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
            else if (ReasoningDeltaEventVariant2 is { } __value1)
            {
                reasoningDeltaEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.BaseReasoningDeltaEvent>? @base = null,
            global::System.Action<object>? reasoningDeltaEventVariant2 = null,
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
            else if (ReasoningDeltaEventVariant2 is { } __value1)
            {
                reasoningDeltaEventVariant2?.Invoke(__value1);
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
                typeof(global::OpenRouter.BaseReasoningDeltaEvent),
                ReasoningDeltaEventVariant2,
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
        public bool Equals(ReasoningDeltaEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseReasoningDeltaEvent?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ReasoningDeltaEventVariant2, other.ReasoningDeltaEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ReasoningDeltaEvent obj1, ReasoningDeltaEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ReasoningDeltaEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ReasoningDeltaEvent obj1, ReasoningDeltaEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReasoningDeltaEvent o && Equals(o);
        }
    }
}
