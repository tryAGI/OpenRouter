#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when a new content part is added to an output item<br/>
    /// Example: {"content_index":0,"item_id":"item-1","output_index":0,"part":{"annotations":[],"text":"","type":"output_text"},"sequence_number":3,"type":"response.content_part.added"}
    /// </summary>
    public readonly partial struct ContentPartAddedEvent : global::System.IEquatable<ContentPartAddedEvent>
    {
        /// <summary>
        /// Event emitted when a new content part is added to an output item<br/>
        /// Example: {"content_index":0,"item_id":"item-1","output_index":0,"part":{"annotations":[],"text":"","type":"output_text"},"sequence_number":3,"type":"response.content_part.added"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseContentPartAddedEvent? Base { get; init; }
#else
        public global::OpenRouter.BaseContentPartAddedEvent? Base { get; }
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
            out global::OpenRouter.BaseContentPartAddedEvent? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseContentPartAddedEvent PickBase() => Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ContentPartAddedEventVariant2? ContentPartAddedEventVariant2 { get; init; }
#else
        public global::OpenRouter.ContentPartAddedEventVariant2? ContentPartAddedEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentPartAddedEventVariant2))]
#endif
        public bool IsContentPartAddedEventVariant2 => ContentPartAddedEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickContentPartAddedEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ContentPartAddedEventVariant2? value)
        {
            value = ContentPartAddedEventVariant2;
            return IsContentPartAddedEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartAddedEventVariant2 PickContentPartAddedEventVariant2() => ContentPartAddedEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContentPartAddedEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentPartAddedEvent(global::OpenRouter.BaseContentPartAddedEvent value) => new ContentPartAddedEvent((global::OpenRouter.BaseContentPartAddedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.BaseContentPartAddedEvent?(ContentPartAddedEvent @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public ContentPartAddedEvent(global::OpenRouter.BaseContentPartAddedEvent? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentPartAddedEvent FromBase(global::OpenRouter.BaseContentPartAddedEvent? value) => new ContentPartAddedEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentPartAddedEvent(global::OpenRouter.ContentPartAddedEventVariant2 value) => new ContentPartAddedEvent((global::OpenRouter.ContentPartAddedEventVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ContentPartAddedEventVariant2?(ContentPartAddedEvent @this) => @this.ContentPartAddedEventVariant2;

        /// <summary>
        ///
        /// </summary>
        public ContentPartAddedEvent(global::OpenRouter.ContentPartAddedEventVariant2? value)
        {
            ContentPartAddedEventVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentPartAddedEvent FromContentPartAddedEventVariant2(global::OpenRouter.ContentPartAddedEventVariant2? value) => new ContentPartAddedEvent(value);

        /// <summary>
        ///
        /// </summary>
        public ContentPartAddedEvent(
            global::OpenRouter.BaseContentPartAddedEvent? @base,
            global::OpenRouter.ContentPartAddedEventVariant2? contentPartAddedEventVariant2
            )
        {
            Base = @base;
            ContentPartAddedEventVariant2 = contentPartAddedEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ContentPartAddedEventVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ContentPartAddedEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsContentPartAddedEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.BaseContentPartAddedEvent, TResult>? @base = null,
            global::System.Func<global::OpenRouter.ContentPartAddedEventVariant2, TResult>? contentPartAddedEventVariant2 = null,
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
            else if (ContentPartAddedEventVariant2 is { } __value1 && contentPartAddedEventVariant2 != null)
            {
                return contentPartAddedEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.BaseContentPartAddedEvent>? @base = null,

            global::System.Action<global::OpenRouter.ContentPartAddedEventVariant2>? contentPartAddedEventVariant2 = null,
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
            else if (ContentPartAddedEventVariant2 is { } __value1)
            {
                contentPartAddedEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.BaseContentPartAddedEvent>? @base = null,
            global::System.Action<global::OpenRouter.ContentPartAddedEventVariant2>? contentPartAddedEventVariant2 = null,
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
            else if (ContentPartAddedEventVariant2 is { } __value1)
            {
                contentPartAddedEventVariant2?.Invoke(__value1);
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
                typeof(global::OpenRouter.BaseContentPartAddedEvent),
                ContentPartAddedEventVariant2,
                typeof(global::OpenRouter.ContentPartAddedEventVariant2),
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
        public bool Equals(ContentPartAddedEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseContentPartAddedEvent?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ContentPartAddedEventVariant2?>.Default.Equals(ContentPartAddedEventVariant2, other.ContentPartAddedEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ContentPartAddedEvent obj1, ContentPartAddedEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentPartAddedEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ContentPartAddedEvent obj1, ContentPartAddedEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentPartAddedEvent o && Equals(o);
        }
    }
}
