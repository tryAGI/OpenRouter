#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when a content part is complete<br/>
    /// Example: {"content_index":0,"item_id":"item-1","output_index":0,"part":{"annotations":[],"text":"Hello! How can I help you?","type":"output_text"},"sequence_number":7,"type":"response.content_part.done"}
    /// </summary>
    public readonly partial struct ContentPartDoneEvent : global::System.IEquatable<ContentPartDoneEvent>
    {
        /// <summary>
        /// Event emitted when a content part is complete<br/>
        /// Example: {"content_index":0,"item_id":"item-1","output_index":0,"part":{"annotations":[],"text":"Hello! How can I help you?","type":"output_text"},"sequence_number":7,"type":"response.content_part.done"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseContentPartDoneEvent? Base { get; init; }
#else
        public global::OpenRouter.BaseContentPartDoneEvent? Base { get; }
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
            out global::OpenRouter.BaseContentPartDoneEvent? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseContentPartDoneEvent PickBase() => Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ContentPartDoneEventVariant2? ContentPartDoneEventVariant2 { get; init; }
#else
        public global::OpenRouter.ContentPartDoneEventVariant2? ContentPartDoneEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentPartDoneEventVariant2))]
#endif
        public bool IsContentPartDoneEventVariant2 => ContentPartDoneEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickContentPartDoneEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ContentPartDoneEventVariant2? value)
        {
            value = ContentPartDoneEventVariant2;
            return IsContentPartDoneEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentPartDoneEventVariant2 PickContentPartDoneEventVariant2() => ContentPartDoneEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContentPartDoneEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentPartDoneEvent(global::OpenRouter.BaseContentPartDoneEvent value) => new ContentPartDoneEvent((global::OpenRouter.BaseContentPartDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.BaseContentPartDoneEvent?(ContentPartDoneEvent @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public ContentPartDoneEvent(global::OpenRouter.BaseContentPartDoneEvent? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentPartDoneEvent FromBase(global::OpenRouter.BaseContentPartDoneEvent? value) => new ContentPartDoneEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentPartDoneEvent(global::OpenRouter.ContentPartDoneEventVariant2 value) => new ContentPartDoneEvent((global::OpenRouter.ContentPartDoneEventVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ContentPartDoneEventVariant2?(ContentPartDoneEvent @this) => @this.ContentPartDoneEventVariant2;

        /// <summary>
        ///
        /// </summary>
        public ContentPartDoneEvent(global::OpenRouter.ContentPartDoneEventVariant2? value)
        {
            ContentPartDoneEventVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentPartDoneEvent FromContentPartDoneEventVariant2(global::OpenRouter.ContentPartDoneEventVariant2? value) => new ContentPartDoneEvent(value);

        /// <summary>
        ///
        /// </summary>
        public ContentPartDoneEvent(
            global::OpenRouter.BaseContentPartDoneEvent? @base,
            global::OpenRouter.ContentPartDoneEventVariant2? contentPartDoneEventVariant2
            )
        {
            Base = @base;
            ContentPartDoneEventVariant2 = contentPartDoneEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ContentPartDoneEventVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            ContentPartDoneEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsContentPartDoneEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.BaseContentPartDoneEvent, TResult>? @base = null,
            global::System.Func<global::OpenRouter.ContentPartDoneEventVariant2, TResult>? contentPartDoneEventVariant2 = null,
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
            else if (ContentPartDoneEventVariant2 is { } __value1 && contentPartDoneEventVariant2 != null)
            {
                return contentPartDoneEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.BaseContentPartDoneEvent>? @base = null,

            global::System.Action<global::OpenRouter.ContentPartDoneEventVariant2>? contentPartDoneEventVariant2 = null,
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
            else if (ContentPartDoneEventVariant2 is { } __value1)
            {
                contentPartDoneEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.BaseContentPartDoneEvent>? @base = null,
            global::System.Action<global::OpenRouter.ContentPartDoneEventVariant2>? contentPartDoneEventVariant2 = null,
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
            else if (ContentPartDoneEventVariant2 is { } __value1)
            {
                contentPartDoneEventVariant2?.Invoke(__value1);
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
                typeof(global::OpenRouter.BaseContentPartDoneEvent),
                ContentPartDoneEventVariant2,
                typeof(global::OpenRouter.ContentPartDoneEventVariant2),
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
        public bool Equals(ContentPartDoneEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseContentPartDoneEvent?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ContentPartDoneEventVariant2?>.Default.Equals(ContentPartDoneEventVariant2, other.ContentPartDoneEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ContentPartDoneEvent obj1, ContentPartDoneEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentPartDoneEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ContentPartDoneEvent obj1, ContentPartDoneEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentPartDoneEvent o && Equals(o);
        }
    }
}
