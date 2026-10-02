#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when a refusal delta is streamed<br/>
    /// Example: {"content_index":0,"delta":"I\u0027m sorry","item_id":"item-1","output_index":0,"sequence_number":4,"type":"response.refusal.delta"}
    /// </summary>
    public readonly partial struct RefusalDeltaEvent : global::System.IEquatable<RefusalDeltaEvent>
    {
        /// <summary>
        /// Event emitted when a refusal delta is streamed<br/>
        /// Example: {"content_index":0,"delta":"I\u0027m sorry","item_id":"item-1","output_index":0,"sequence_number":4,"type":"response.refusal.delta"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseRefusalDeltaEvent? Base { get; init; }
#else
        public global::OpenRouter.BaseRefusalDeltaEvent? Base { get; }
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
            out global::OpenRouter.BaseRefusalDeltaEvent? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseRefusalDeltaEvent PickBase() => Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? RefusalDeltaEventVariant2 { get; init; }
#else
        public object? RefusalDeltaEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RefusalDeltaEventVariant2))]
#endif
        public bool IsRefusalDeltaEventVariant2 => RefusalDeltaEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRefusalDeltaEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = RefusalDeltaEventVariant2;
            return IsRefusalDeltaEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickRefusalDeltaEventVariant2() => RefusalDeltaEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RefusalDeltaEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator RefusalDeltaEvent(global::OpenRouter.BaseRefusalDeltaEvent value) => new RefusalDeltaEvent((global::OpenRouter.BaseRefusalDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.BaseRefusalDeltaEvent?(RefusalDeltaEvent @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public RefusalDeltaEvent(global::OpenRouter.BaseRefusalDeltaEvent? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RefusalDeltaEvent FromBase(global::OpenRouter.BaseRefusalDeltaEvent? value) => new RefusalDeltaEvent(value);

        /// <summary>
        ///
        /// </summary>
        public RefusalDeltaEvent(
            global::OpenRouter.BaseRefusalDeltaEvent? @base,
            object? refusalDeltaEventVariant2
            )
        {
            Base = @base;
            RefusalDeltaEventVariant2 = refusalDeltaEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RefusalDeltaEventVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            RefusalDeltaEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsRefusalDeltaEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.BaseRefusalDeltaEvent, TResult>? @base = null,
            global::System.Func<object, TResult>? refusalDeltaEventVariant2 = null,
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
            else if (RefusalDeltaEventVariant2 is { } __value1 && refusalDeltaEventVariant2 != null)
            {
                return refusalDeltaEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.BaseRefusalDeltaEvent>? @base = null,

            global::System.Action<object>? refusalDeltaEventVariant2 = null,
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
            else if (RefusalDeltaEventVariant2 is { } __value1)
            {
                refusalDeltaEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.BaseRefusalDeltaEvent>? @base = null,
            global::System.Action<object>? refusalDeltaEventVariant2 = null,
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
            else if (RefusalDeltaEventVariant2 is { } __value1)
            {
                refusalDeltaEventVariant2?.Invoke(__value1);
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
                typeof(global::OpenRouter.BaseRefusalDeltaEvent),
                RefusalDeltaEventVariant2,
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
        public bool Equals(RefusalDeltaEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseRefusalDeltaEvent?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(RefusalDeltaEventVariant2, other.RefusalDeltaEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(RefusalDeltaEvent obj1, RefusalDeltaEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RefusalDeltaEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(RefusalDeltaEvent obj1, RefusalDeltaEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RefusalDeltaEvent o && Equals(o);
        }
    }
}
