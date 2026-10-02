#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when a text delta is streamed<br/>
    /// Example: {"content_index":0,"delta":"Hello","item_id":"item-1","logprobs":[],"output_index":0,"sequence_number":4,"type":"response.output_text.delta"}
    /// </summary>
    public readonly partial struct TextDeltaEvent : global::System.IEquatable<TextDeltaEvent>
    {
        /// <summary>
        /// Event emitted when a text delta is streamed<br/>
        /// Example: {"content_index":0,"delta":"Hello","item_id":"item-1","logprobs":[],"output_index":0,"sequence_number":4,"type":"response.output_text.delta"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseTextDeltaEvent? Base { get; init; }
#else
        public global::OpenRouter.BaseTextDeltaEvent? Base { get; }
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
            out global::OpenRouter.BaseTextDeltaEvent? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BaseTextDeltaEvent PickBase() => Base is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.TextDeltaEventVariant2? TextDeltaEventVariant2 { get; init; }
#else
        public global::OpenRouter.TextDeltaEventVariant2? TextDeltaEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextDeltaEventVariant2))]
#endif
        public bool IsTextDeltaEventVariant2 => TextDeltaEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextDeltaEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.TextDeltaEventVariant2? value)
        {
            value = TextDeltaEventVariant2;
            return IsTextDeltaEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.TextDeltaEventVariant2 PickTextDeltaEventVariant2() => TextDeltaEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextDeltaEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TextDeltaEvent(global::OpenRouter.BaseTextDeltaEvent value) => new TextDeltaEvent((global::OpenRouter.BaseTextDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.BaseTextDeltaEvent?(TextDeltaEvent @this) => @this.Base;

        /// <summary>
        ///
        /// </summary>
        public TextDeltaEvent(global::OpenRouter.BaseTextDeltaEvent? value)
        {
            Base = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TextDeltaEvent FromBase(global::OpenRouter.BaseTextDeltaEvent? value) => new TextDeltaEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TextDeltaEvent(global::OpenRouter.TextDeltaEventVariant2 value) => new TextDeltaEvent((global::OpenRouter.TextDeltaEventVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.TextDeltaEventVariant2?(TextDeltaEvent @this) => @this.TextDeltaEventVariant2;

        /// <summary>
        ///
        /// </summary>
        public TextDeltaEvent(global::OpenRouter.TextDeltaEventVariant2? value)
        {
            TextDeltaEventVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TextDeltaEvent FromTextDeltaEventVariant2(global::OpenRouter.TextDeltaEventVariant2? value) => new TextDeltaEvent(value);

        /// <summary>
        ///
        /// </summary>
        public TextDeltaEvent(
            global::OpenRouter.BaseTextDeltaEvent? @base,
            global::OpenRouter.TextDeltaEventVariant2? textDeltaEventVariant2
            )
        {
            Base = @base;
            TextDeltaEventVariant2 = textDeltaEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            TextDeltaEventVariant2 as object ??
            Base as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            TextDeltaEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsTextDeltaEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.BaseTextDeltaEvent, TResult>? @base = null,
            global::System.Func<global::OpenRouter.TextDeltaEventVariant2, TResult>? textDeltaEventVariant2 = null,
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
            else if (TextDeltaEventVariant2 is { } __value1 && textDeltaEventVariant2 != null)
            {
                return textDeltaEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.BaseTextDeltaEvent>? @base = null,

            global::System.Action<global::OpenRouter.TextDeltaEventVariant2>? textDeltaEventVariant2 = null,
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
            else if (TextDeltaEventVariant2 is { } __value1)
            {
                textDeltaEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.BaseTextDeltaEvent>? @base = null,
            global::System.Action<global::OpenRouter.TextDeltaEventVariant2>? textDeltaEventVariant2 = null,
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
            else if (TextDeltaEventVariant2 is { } __value1)
            {
                textDeltaEventVariant2?.Invoke(__value1);
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
                typeof(global::OpenRouter.BaseTextDeltaEvent),
                TextDeltaEventVariant2,
                typeof(global::OpenRouter.TextDeltaEventVariant2),
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
        public bool Equals(TextDeltaEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseTextDeltaEvent?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.TextDeltaEventVariant2?>.Default.Equals(TextDeltaEventVariant2, other.TextDeltaEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TextDeltaEvent obj1, TextDeltaEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TextDeltaEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TextDeltaEvent obj1, TextDeltaEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TextDeltaEvent o && Equals(o);
        }
    }
}
