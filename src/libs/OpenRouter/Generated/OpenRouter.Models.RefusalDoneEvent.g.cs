#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when refusal streaming is complete<br/>
    /// Example: {"content_index":0,"item_id":"item-1","output_index":0,"refusal":"I\u0027m sorry, but I can\u0027t assist with that request.","sequence_number":6,"type":"response.refusal.done"}
    /// </summary>
    public readonly partial struct RefusalDoneEvent : global::System.IEquatable<RefusalDoneEvent>
    {
        /// <summary>
        /// Event emitted when refusal streaming is complete<br/>
        /// Example: {"content_index":0,"item_id":"item-1","output_index":0,"refusal":"I\u0027m sorry, but I can\u0027t assist with that request.","sequence_number":6,"type":"response.refusal.done"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseRefusalDoneEvent? Base { get; init; }
#else
        public global::OpenRouter.BaseRefusalDoneEvent? Base { get; }
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
            out global::OpenRouter.BaseRefusalDoneEvent? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseRefusalDoneEvent PickBase() => Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? RefusalDoneEventVariant2 { get; init; }
#else
        public object? RefusalDoneEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RefusalDoneEventVariant2))]
#endif
        public bool IsRefusalDoneEventVariant2 => RefusalDoneEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRefusalDoneEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = RefusalDoneEventVariant2;
            return IsRefusalDoneEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickRefusalDoneEventVariant2() => RefusalDoneEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RefusalDoneEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator RefusalDoneEvent(global::OpenRouter.BaseRefusalDoneEvent value) => new RefusalDoneEvent((global::OpenRouter.BaseRefusalDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.BaseRefusalDoneEvent?(RefusalDoneEvent @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public RefusalDoneEvent(global::OpenRouter.BaseRefusalDoneEvent? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RefusalDoneEvent FromBase(global::OpenRouter.BaseRefusalDoneEvent? value) => new RefusalDoneEvent(value);

        /// <summary>
        ///
        /// </summary>
        public RefusalDoneEvent(
            global::OpenRouter.BaseRefusalDoneEvent? @base,
            object? refusalDoneEventVariant2
            )
        {
            Base = @base;
            RefusalDoneEventVariant2 = refusalDoneEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RefusalDoneEventVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            RefusalDoneEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsRefusalDoneEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.BaseRefusalDoneEvent, TResult>? @base = null,
            global::System.Func<object, TResult>? refusalDoneEventVariant2 = null,
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
            else if (RefusalDoneEventVariant2 is { } __value1 && refusalDoneEventVariant2 != null)
            {
                return refusalDoneEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.BaseRefusalDoneEvent>? @base = null,

            global::System.Action<object>? refusalDoneEventVariant2 = null,
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
            else if (RefusalDoneEventVariant2 is { } __value1)
            {
                refusalDoneEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.BaseRefusalDoneEvent>? @base = null,
            global::System.Action<object>? refusalDoneEventVariant2 = null,
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
            else if (RefusalDoneEventVariant2 is { } __value1)
            {
                refusalDoneEventVariant2?.Invoke(__value1);
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
                typeof(global::OpenRouter.BaseRefusalDoneEvent),
                RefusalDoneEventVariant2,
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
        public bool Equals(RefusalDoneEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseRefusalDoneEvent?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(RefusalDoneEventVariant2, other.RefusalDoneEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(RefusalDoneEvent obj1, RefusalDoneEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RefusalDoneEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(RefusalDoneEvent obj1, RefusalDoneEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RefusalDoneEvent o && Equals(o);
        }
    }
}
