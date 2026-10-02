#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Audio to transcribe: inline base64 bytes, or a URL the provider downloads directly.
    /// </summary>
    public readonly partial struct STTInputAudio : global::System.IEquatable<STTInputAudio>
    {
        /// <summary>
        /// Inline base64 audio input for speech-to-text<br/>
        /// Example: {"data":"UklGRiQA...","format":"wav"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.STTInlineInputAudio? Inline { get; init; }
#else
        public global::OpenRouter.STTInlineInputAudio? Inline { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Inline))]
#endif
        public bool IsInline => Inline != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInline(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.STTInlineInputAudio? value)
        {
            value = Inline;
            return IsInline;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTInlineInputAudio PickInline() => Inline is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Inline' but the value was {ToString()}.");

        /// <summary>
        /// Audio input fetched by the provider from a URL<br/>
        /// Example: {"format":"mp3","url":"https://example.com/meeting.mp3"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.STTUrlInputAudio? Url { get; init; }
#else
        public global::OpenRouter.STTUrlInputAudio? Url { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Url))]
#endif
        public bool IsUrl => Url != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUrl(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.STTUrlInputAudio? value)
        {
            value = Url;
            return IsUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.STTUrlInputAudio PickUrl() => Url is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Url' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator STTInputAudio(global::OpenRouter.STTInlineInputAudio value) => new STTInputAudio((global::OpenRouter.STTInlineInputAudio?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.STTInlineInputAudio?(STTInputAudio @this) => @this.Inline;

        /// <summary>
        ///
        /// </summary>
        public STTInputAudio(global::OpenRouter.STTInlineInputAudio? value)
        {
            Inline = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static STTInputAudio FromInline(global::OpenRouter.STTInlineInputAudio? value) => new STTInputAudio(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator STTInputAudio(global::OpenRouter.STTUrlInputAudio value) => new STTInputAudio((global::OpenRouter.STTUrlInputAudio?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.STTUrlInputAudio?(STTInputAudio @this) => @this.Url;

        /// <summary>
        ///
        /// </summary>
        public STTInputAudio(global::OpenRouter.STTUrlInputAudio? value)
        {
            Url = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static STTInputAudio FromUrl(global::OpenRouter.STTUrlInputAudio? value) => new STTInputAudio(value);

        /// <summary>
        ///
        /// </summary>
        public STTInputAudio(
            global::OpenRouter.STTInlineInputAudio? inline,
            global::OpenRouter.STTUrlInputAudio? url
            )
        {
            Inline = inline;
            Url = url;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Url as object ??
            Inline as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Inline?.ToString() ??
            Url?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInline || IsUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.STTInlineInputAudio, TResult>? inline = null,
            global::System.Func<global::OpenRouter.STTUrlInputAudio, TResult>? url = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Inline is { } __value0 && inline != null)
            {
                return inline(__value0);
            }
            else if (Url is { } __value1 && url != null)
            {
                return url(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.STTInlineInputAudio>? inline = null,

            global::System.Action<global::OpenRouter.STTUrlInputAudio>? url = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Inline is { } __value0)
            {
                inline?.Invoke(__value0);
            }
            else if (Url is { } __value1)
            {
                url?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.STTInlineInputAudio>? inline = null,
            global::System.Action<global::OpenRouter.STTUrlInputAudio>? url = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Inline is { } __value0)
            {
                inline?.Invoke(__value0);
            }
            else if (Url is { } __value1)
            {
                url?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Inline,
                typeof(global::OpenRouter.STTInlineInputAudio),
                Url,
                typeof(global::OpenRouter.STTUrlInputAudio),
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
        public bool Equals(STTInputAudio other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.STTInlineInputAudio?>.Default.Equals(Inline, other.Inline) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.STTUrlInputAudio?>.Default.Equals(Url, other.Url)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(STTInputAudio obj1, STTInputAudio obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<STTInputAudio>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(STTInputAudio obj1, STTInputAudio obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is STTInputAudio o && Equals(o);
        }
    }
}
