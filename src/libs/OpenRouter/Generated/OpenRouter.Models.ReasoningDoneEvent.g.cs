#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when reasoning text streaming is complete<br/>
    /// Example: {"content_index":0,"item_id":"item-1","output_index":0,"sequence_number":6,"text":"First, we need to identify the key components and then combine them logically.","type":"response.reasoning_text.done"}
    /// </summary>
    public readonly partial struct ReasoningDoneEvent : global::System.IEquatable<ReasoningDoneEvent>
    {
        /// <summary>
        /// Event emitted when reasoning text streaming is complete<br/>
        /// Example: {"content_index":0,"item_id":"item-1","output_index":0,"sequence_number":6,"text":"First, we need to identify the key components and then combine them logically.","type":"response.reasoning_text.done"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseReasoningDoneEvent? Base { get; init; }
#else
        public global::OpenRouter.BaseReasoningDoneEvent? Base { get; }
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
            out global::OpenRouter.BaseReasoningDoneEvent? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseReasoningDoneEvent PickBase() => Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ReasoningDoneEventVariant2 { get; init; }
#else
        public object? ReasoningDoneEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ReasoningDoneEventVariant2))]
#endif
        public bool IsReasoningDoneEventVariant2 => ReasoningDoneEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickReasoningDoneEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = ReasoningDoneEventVariant2;
            return IsReasoningDoneEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickReasoningDoneEventVariant2() => ReasoningDoneEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ReasoningDoneEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ReasoningDoneEvent(global::OpenRouter.BaseReasoningDoneEvent value) => new ReasoningDoneEvent((global::OpenRouter.BaseReasoningDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.BaseReasoningDoneEvent?(ReasoningDoneEvent @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public ReasoningDoneEvent(global::OpenRouter.BaseReasoningDoneEvent? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ReasoningDoneEvent FromBase(global::OpenRouter.BaseReasoningDoneEvent? value) => new ReasoningDoneEvent(value);

        /// <summary>
        ///
        /// </summary>
        public ReasoningDoneEvent(
            global::OpenRouter.BaseReasoningDoneEvent? @base,
            object? reasoningDoneEventVariant2
            )
        {
            Base = @base;
            ReasoningDoneEventVariant2 = reasoningDoneEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ReasoningDoneEventVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ReasoningDoneEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsReasoningDoneEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.BaseReasoningDoneEvent, TResult>? @base = null,
            global::System.Func<object, TResult>? reasoningDoneEventVariant2 = null,
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
            else if (ReasoningDoneEventVariant2 is { } __value1 && reasoningDoneEventVariant2 != null)
            {
                return reasoningDoneEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.BaseReasoningDoneEvent>? @base = null,

            global::System.Action<object>? reasoningDoneEventVariant2 = null,
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
            else if (ReasoningDoneEventVariant2 is { } __value1)
            {
                reasoningDoneEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.BaseReasoningDoneEvent>? @base = null,
            global::System.Action<object>? reasoningDoneEventVariant2 = null,
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
            else if (ReasoningDoneEventVariant2 is { } __value1)
            {
                reasoningDoneEventVariant2?.Invoke(__value1);
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
                typeof(global::OpenRouter.BaseReasoningDoneEvent),
                ReasoningDoneEventVariant2,
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
        public bool Equals(ReasoningDoneEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseReasoningDoneEvent?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ReasoningDoneEventVariant2, other.ReasoningDoneEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ReasoningDoneEvent obj1, ReasoningDoneEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ReasoningDoneEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ReasoningDoneEvent obj1, ReasoningDoneEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReasoningDoneEvent o && Equals(o);
        }
    }
}
