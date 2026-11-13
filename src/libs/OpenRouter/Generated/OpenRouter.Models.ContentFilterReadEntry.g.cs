#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A custom regex content filter, with whether inference enforces it.<br/>
    /// Example: {"action":"redact","is_enforced":true,"label":"[API_KEY]","pattern":"\\b(sk-[a-zA-Z0-9]{48})\\b"}
    /// </summary>
    public readonly partial struct ContentFilterReadEntry : global::System.IEquatable<ContentFilterReadEntry>
    {
        /// <summary>
        /// A custom regex content filter that scans request messages for matching patterns.<br/>
        /// Example: {"action":"redact","label":"[API_KEY]","pattern":"\\b(sk-[a-zA-Z0-9]{48})\\b"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ContentFilterEntry? ContentFilterEntry { get; init; }
#else
        public global::OpenRouter.ContentFilterEntry? ContentFilterEntry { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentFilterEntry))]
#endif
        public bool IsContentFilterEntry => ContentFilterEntry != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickContentFilterEntry(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ContentFilterEntry? value)
        {
            value = ContentFilterEntry;
            return IsContentFilterEntry;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentFilterEntry PickContentFilterEntry() => ContentFilterEntry is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContentFilterEntry' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ContentFilterReadEntryVariant2? ContentFilterReadEntryVariant2 { get; init; }
#else
        public global::OpenRouter.ContentFilterReadEntryVariant2? ContentFilterReadEntryVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentFilterReadEntryVariant2))]
#endif
        public bool IsContentFilterReadEntryVariant2 => ContentFilterReadEntryVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickContentFilterReadEntryVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ContentFilterReadEntryVariant2? value)
        {
            value = ContentFilterReadEntryVariant2;
            return IsContentFilterReadEntryVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ContentFilterReadEntryVariant2 PickContentFilterReadEntryVariant2() => ContentFilterReadEntryVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContentFilterReadEntryVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentFilterReadEntry(global::OpenRouter.ContentFilterEntry value) => new ContentFilterReadEntry((global::OpenRouter.ContentFilterEntry?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ContentFilterEntry?(ContentFilterReadEntry @this) => @this.ContentFilterEntry;

        /// <summary>
        ///
        /// </summary>
        public ContentFilterReadEntry(global::OpenRouter.ContentFilterEntry? value)
        {
            ContentFilterEntry = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentFilterReadEntry FromContentFilterEntry(global::OpenRouter.ContentFilterEntry? value) => new ContentFilterReadEntry(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentFilterReadEntry(global::OpenRouter.ContentFilterReadEntryVariant2 value) => new ContentFilterReadEntry((global::OpenRouter.ContentFilterReadEntryVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ContentFilterReadEntryVariant2?(ContentFilterReadEntry @this) => @this.ContentFilterReadEntryVariant2;

        /// <summary>
        ///
        /// </summary>
        public ContentFilterReadEntry(global::OpenRouter.ContentFilterReadEntryVariant2? value)
        {
            ContentFilterReadEntryVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentFilterReadEntry FromContentFilterReadEntryVariant2(global::OpenRouter.ContentFilterReadEntryVariant2? value) => new ContentFilterReadEntry(value);

        /// <summary>
        ///
        /// </summary>
        public ContentFilterReadEntry(
            global::OpenRouter.ContentFilterEntry? contentFilterEntry,
            global::OpenRouter.ContentFilterReadEntryVariant2? contentFilterReadEntryVariant2
            )
        {
            ContentFilterEntry = contentFilterEntry;
            ContentFilterReadEntryVariant2 = contentFilterReadEntryVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ContentFilterReadEntryVariant2 as object ??
            ContentFilterEntry as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ContentFilterEntry?.ToString() ??
            ContentFilterReadEntryVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsContentFilterEntry && IsContentFilterReadEntryVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ContentFilterEntry, TResult>? contentFilterEntry = null,
            global::System.Func<global::OpenRouter.ContentFilterReadEntryVariant2, TResult>? contentFilterReadEntryVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ContentFilterEntry is { } __value0 && contentFilterEntry != null)
            {
                return contentFilterEntry(__value0);
            }
            else if (ContentFilterReadEntryVariant2 is { } __value1 && contentFilterReadEntryVariant2 != null)
            {
                return contentFilterReadEntryVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ContentFilterEntry>? contentFilterEntry = null,

            global::System.Action<global::OpenRouter.ContentFilterReadEntryVariant2>? contentFilterReadEntryVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ContentFilterEntry is { } __value0)
            {
                contentFilterEntry?.Invoke(__value0);
            }
            else if (ContentFilterReadEntryVariant2 is { } __value1)
            {
                contentFilterReadEntryVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ContentFilterEntry>? contentFilterEntry = null,
            global::System.Action<global::OpenRouter.ContentFilterReadEntryVariant2>? contentFilterReadEntryVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ContentFilterEntry is { } __value0)
            {
                contentFilterEntry?.Invoke(__value0);
            }
            else if (ContentFilterReadEntryVariant2 is { } __value1)
            {
                contentFilterReadEntryVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ContentFilterEntry,
                typeof(global::OpenRouter.ContentFilterEntry),
                ContentFilterReadEntryVariant2,
                typeof(global::OpenRouter.ContentFilterReadEntryVariant2),
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
        public bool Equals(ContentFilterReadEntry other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ContentFilterEntry?>.Default.Equals(ContentFilterEntry, other.ContentFilterEntry) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ContentFilterReadEntryVariant2?>.Default.Equals(ContentFilterReadEntryVariant2, other.ContentFilterReadEntryVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ContentFilterReadEntry obj1, ContentFilterReadEntry obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentFilterReadEntry>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ContentFilterReadEntry obj1, ContentFilterReadEntry obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentFilterReadEntry o && Equals(o);
        }
    }
}
