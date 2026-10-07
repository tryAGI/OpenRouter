#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Text to synthesize, or a list of turns for multi-speaker input. Each turn has its own text, voice, and instructions. Multi-speaker input is currently supported by Gemini TTS models only.<br/>
    /// Example: Hello world
    /// </summary>
    public readonly partial struct SpeechInput : global::System.IEquatable<SpeechInput>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? SpeechInputVariant1 { get; init; }
#else
        public string? SpeechInputVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeechInputVariant1))]
#endif
        public bool IsSpeechInputVariant1 => SpeechInputVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSpeechInputVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = SpeechInputVariant1;
            return IsSpeechInputVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickSpeechInputVariant1() => SpeechInputVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeechInputVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::OpenRouter.SpeechTurn>? SpeechInputVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::OpenRouter.SpeechTurn>? SpeechInputVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeechInputVariant2))]
#endif
        public bool IsSpeechInputVariant2 => SpeechInputVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSpeechInputVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::OpenRouter.SpeechTurn>? value)
        {
            value = SpeechInputVariant2;
            return IsSpeechInputVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.SpeechTurn> PickSpeechInputVariant2() => SpeechInputVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeechInputVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SpeechInput(string value) => new SpeechInput((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(SpeechInput @this) => @this.SpeechInputVariant1;

        /// <summary>
        ///
        /// </summary>
        public SpeechInput(string? value)
        {
            SpeechInputVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SpeechInput FromSpeechInputVariant1(string? value) => new SpeechInput(value);

        /// <summary>
        ///
        /// </summary>
        public SpeechInput(
            string? speechInputVariant1,
            global::System.Collections.Generic.IList<global::OpenRouter.SpeechTurn>? speechInputVariant2
            )
        {
            SpeechInputVariant1 = speechInputVariant1;
            SpeechInputVariant2 = speechInputVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SpeechInputVariant2 as object ??
            SpeechInputVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SpeechInputVariant1?.ToString() ??
            SpeechInputVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSpeechInputVariant1 || IsSpeechInputVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? speechInputVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::OpenRouter.SpeechTurn>, TResult>? speechInputVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SpeechInputVariant1 is { } __value0 && speechInputVariant1 != null)
            {
                return speechInputVariant1(__value0);
            }
            else if (SpeechInputVariant2 is { } __value1 && speechInputVariant2 != null)
            {
                return speechInputVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? speechInputVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.SpeechTurn>>? speechInputVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SpeechInputVariant1 is { } __value0)
            {
                speechInputVariant1?.Invoke(__value0);
            }
            else if (SpeechInputVariant2 is { } __value1)
            {
                speechInputVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? speechInputVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.SpeechTurn>>? speechInputVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SpeechInputVariant1 is { } __value0)
            {
                speechInputVariant1?.Invoke(__value0);
            }
            else if (SpeechInputVariant2 is { } __value1)
            {
                speechInputVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SpeechInputVariant1,
                typeof(string),
                SpeechInputVariant2,
                typeof(global::System.Collections.Generic.IList<global::OpenRouter.SpeechTurn>),
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
        public bool Equals(SpeechInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(SpeechInputVariant1, other.SpeechInputVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::OpenRouter.SpeechTurn>?>.Default.Equals(SpeechInputVariant2, other.SpeechInputVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SpeechInput obj1, SpeechInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SpeechInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SpeechInput obj1, SpeechInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SpeechInput o && Equals(o);
        }
    }
}
