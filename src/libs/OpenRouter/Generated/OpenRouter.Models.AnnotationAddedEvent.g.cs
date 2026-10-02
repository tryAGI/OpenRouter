#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when a text annotation is added to output<br/>
    /// Example: {"annotation":{"end_index":7,"start_index":0,"title":"Example","type":"url_citation","url":"https://example.com"},"annotation_index":0,"content_index":0,"item_id":"item-1","output_index":0,"sequence_number":5,"type":"response.output_text.annotation.added"}
    /// </summary>
    public readonly partial struct AnnotationAddedEvent : global::System.IEquatable<AnnotationAddedEvent>
    {
        /// <summary>
        /// Event emitted when a text annotation is added to output<br/>
        /// Example: {"annotation":{"end_index":7,"start_index":0,"title":"Example","type":"url_citation","url":"https://example.com"},"annotation_index":0,"content_index":0,"item_id":"item-1","output_index":0,"sequence_number":5,"type":"response.output_text.annotation.added"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseAnnotationAddedEvent? Base { get; init; }
#else
        public global::OpenRouter.BaseAnnotationAddedEvent? Base { get; }
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
            out global::OpenRouter.BaseAnnotationAddedEvent? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseAnnotationAddedEvent PickBase() => Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? AnnotationAddedEventVariant2 { get; init; }
#else
        public object? AnnotationAddedEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnnotationAddedEventVariant2))]
#endif
        public bool IsAnnotationAddedEventVariant2 => AnnotationAddedEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAnnotationAddedEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = AnnotationAddedEventVariant2;
            return IsAnnotationAddedEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickAnnotationAddedEventVariant2() => AnnotationAddedEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnnotationAddedEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnnotationAddedEvent(global::OpenRouter.BaseAnnotationAddedEvent value) => new AnnotationAddedEvent((global::OpenRouter.BaseAnnotationAddedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.BaseAnnotationAddedEvent?(AnnotationAddedEvent @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public AnnotationAddedEvent(global::OpenRouter.BaseAnnotationAddedEvent? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnnotationAddedEvent FromBase(global::OpenRouter.BaseAnnotationAddedEvent? value) => new AnnotationAddedEvent(value);

        /// <summary>
        ///
        /// </summary>
        public AnnotationAddedEvent(
            global::OpenRouter.BaseAnnotationAddedEvent? @base,
            object? annotationAddedEventVariant2
            )
        {
            Base = @base;
            AnnotationAddedEventVariant2 = annotationAddedEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AnnotationAddedEventVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            AnnotationAddedEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsAnnotationAddedEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.BaseAnnotationAddedEvent, TResult>? @base = null,
            global::System.Func<object, TResult>? annotationAddedEventVariant2 = null,
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
            else if (AnnotationAddedEventVariant2 is { } __value1 && annotationAddedEventVariant2 != null)
            {
                return annotationAddedEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.BaseAnnotationAddedEvent>? @base = null,

            global::System.Action<object>? annotationAddedEventVariant2 = null,
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
            else if (AnnotationAddedEventVariant2 is { } __value1)
            {
                annotationAddedEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.BaseAnnotationAddedEvent>? @base = null,
            global::System.Action<object>? annotationAddedEventVariant2 = null,
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
            else if (AnnotationAddedEventVariant2 is { } __value1)
            {
                annotationAddedEventVariant2?.Invoke(__value1);
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
                typeof(global::OpenRouter.BaseAnnotationAddedEvent),
                AnnotationAddedEventVariant2,
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
        public bool Equals(AnnotationAddedEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseAnnotationAddedEvent?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(AnnotationAddedEventVariant2, other.AnnotationAddedEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AnnotationAddedEvent obj1, AnnotationAddedEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnnotationAddedEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnnotationAddedEvent obj1, AnnotationAddedEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnnotationAddedEvent o && Equals(o);
        }
    }
}
