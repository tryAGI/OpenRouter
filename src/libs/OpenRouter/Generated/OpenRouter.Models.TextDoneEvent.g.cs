#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when text streaming is complete<br/>
    /// Example: {"content_index":0,"item_id":"item-1","logprobs":[],"output_index":0,"sequence_number":6,"text":"Hello! How can I help you?","type":"response.output_text.done"}
    /// </summary>
    public readonly partial struct TextDoneEvent : global::System.IEquatable<TextDoneEvent>
    {
        /// <summary>
        /// Event emitted when text streaming is complete<br/>
        /// Example: {"content_index":0,"item_id":"item-1","logprobs":[],"output_index":0,"sequence_number":6,"text":"Hello! How can I help you?","type":"response.output_text.done"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseTextDoneEvent? Base { get; init; }
#else
        public global::OpenRouter.BaseTextDoneEvent? Base { get; }
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
            out global::OpenRouter.BaseTextDoneEvent? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseTextDoneEvent PickBase() => Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.TextDoneEventVariant2? TextDoneEventVariant2 { get; init; }
#else
        public global::OpenRouter.TextDoneEventVariant2? TextDoneEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextDoneEventVariant2))]
#endif
        public bool IsTextDoneEventVariant2 => TextDoneEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextDoneEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.TextDoneEventVariant2? value)
        {
            value = TextDoneEventVariant2;
            return IsTextDoneEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextDoneEventVariant2 PickTextDoneEventVariant2() => TextDoneEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextDoneEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TextDoneEvent(global::OpenRouter.BaseTextDoneEvent value) => new TextDoneEvent((global::OpenRouter.BaseTextDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.BaseTextDoneEvent?(TextDoneEvent @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public TextDoneEvent(global::OpenRouter.BaseTextDoneEvent? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TextDoneEvent FromBase(global::OpenRouter.BaseTextDoneEvent? value) => new TextDoneEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TextDoneEvent(global::OpenRouter.TextDoneEventVariant2 value) => new TextDoneEvent((global::OpenRouter.TextDoneEventVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.TextDoneEventVariant2?(TextDoneEvent @this) => @this.TextDoneEventVariant2;

        /// <summary>
        ///
        /// </summary>
        public TextDoneEvent(global::OpenRouter.TextDoneEventVariant2? value)
        {
            TextDoneEventVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TextDoneEvent FromTextDoneEventVariant2(global::OpenRouter.TextDoneEventVariant2? value) => new TextDoneEvent(value);

        /// <summary>
        ///
        /// </summary>
        public TextDoneEvent(
            global::OpenRouter.BaseTextDoneEvent? @base,
            global::OpenRouter.TextDoneEventVariant2? textDoneEventVariant2
            )
        {
            Base = @base;
            TextDoneEventVariant2 = textDoneEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            TextDoneEventVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            TextDoneEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsTextDoneEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.BaseTextDoneEvent, TResult>? @base = null,
            global::System.Func<global::OpenRouter.TextDoneEventVariant2, TResult>? textDoneEventVariant2 = null,
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
            else if (TextDoneEventVariant2 is { } __value1 && textDoneEventVariant2 != null)
            {
                return textDoneEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.BaseTextDoneEvent>? @base = null,

            global::System.Action<global::OpenRouter.TextDoneEventVariant2>? textDoneEventVariant2 = null,
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
            else if (TextDoneEventVariant2 is { } __value1)
            {
                textDoneEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.BaseTextDoneEvent>? @base = null,
            global::System.Action<global::OpenRouter.TextDoneEventVariant2>? textDoneEventVariant2 = null,
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
            else if (TextDoneEventVariant2 is { } __value1)
            {
                textDoneEventVariant2?.Invoke(__value1);
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
                typeof(global::OpenRouter.BaseTextDoneEvent),
                TextDoneEventVariant2,
                typeof(global::OpenRouter.TextDoneEventVariant2),
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
        public bool Equals(TextDoneEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseTextDoneEvent?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.TextDoneEventVariant2?>.Default.Equals(TextDoneEventVariant2, other.TextDoneEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TextDoneEvent obj1, TextDoneEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TextDoneEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TextDoneEvent obj1, TextDoneEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TextDoneEvent o && Equals(o);
        }
    }
}
