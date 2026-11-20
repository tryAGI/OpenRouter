#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An input the model accepts. `audio` and `image` are `input_references` for voice cloning and voice design.<br/>
    /// Example: {"type":"text"}
    /// </summary>
    public readonly partial struct SpeechInputModality : global::System.IEquatable<SpeechInputModality>
    {
        /// <summary>
        /// The `input` text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.SpeechInputModalityVariant1? SpeechInputModalityVariant1 { get; init; }
#else
        public global::OpenRouter.SpeechInputModalityVariant1? SpeechInputModalityVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeechInputModalityVariant1))]
#endif
        public bool IsSpeechInputModalityVariant1 => SpeechInputModalityVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSpeechInputModalityVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.SpeechInputModalityVariant1? value)
        {
            value = SpeechInputModalityVariant1;
            return IsSpeechInputModalityVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputModalityVariant1 PickSpeechInputModalityVariant1() => SpeechInputModalityVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeechInputModalityVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.SpeechInputModalityVariant2? SpeechInputModalityVariant2 { get; init; }
#else
        public global::OpenRouter.SpeechInputModalityVariant2? SpeechInputModalityVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeechInputModalityVariant2))]
#endif
        public bool IsSpeechInputModalityVariant2 => SpeechInputModalityVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSpeechInputModalityVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.SpeechInputModalityVariant2? value)
        {
            value = SpeechInputModalityVariant2;
            return IsSpeechInputModalityVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputModalityVariant2 PickSpeechInputModalityVariant2() => SpeechInputModalityVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeechInputModalityVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.SpeechInputModalityVariant3? SpeechInputModalityVariant3 { get; init; }
#else
        public global::OpenRouter.SpeechInputModalityVariant3? SpeechInputModalityVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeechInputModalityVariant3))]
#endif
        public bool IsSpeechInputModalityVariant3 => SpeechInputModalityVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSpeechInputModalityVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.SpeechInputModalityVariant3? value)
        {
            value = SpeechInputModalityVariant3;
            return IsSpeechInputModalityVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SpeechInputModalityVariant3 PickSpeechInputModalityVariant3() => SpeechInputModalityVariant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeechInputModalityVariant3' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SpeechInputModality(global::OpenRouter.SpeechInputModalityVariant1 value) => new SpeechInputModality((global::OpenRouter.SpeechInputModalityVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.SpeechInputModalityVariant1?(SpeechInputModality @this) => @this.SpeechInputModalityVariant1;

        /// <summary>
        ///
        /// </summary>
        public SpeechInputModality(global::OpenRouter.SpeechInputModalityVariant1? value)
        {
            SpeechInputModalityVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SpeechInputModality FromSpeechInputModalityVariant1(global::OpenRouter.SpeechInputModalityVariant1? value) => new SpeechInputModality(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SpeechInputModality(global::OpenRouter.SpeechInputModalityVariant2 value) => new SpeechInputModality((global::OpenRouter.SpeechInputModalityVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.SpeechInputModalityVariant2?(SpeechInputModality @this) => @this.SpeechInputModalityVariant2;

        /// <summary>
        ///
        /// </summary>
        public SpeechInputModality(global::OpenRouter.SpeechInputModalityVariant2? value)
        {
            SpeechInputModalityVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SpeechInputModality FromSpeechInputModalityVariant2(global::OpenRouter.SpeechInputModalityVariant2? value) => new SpeechInputModality(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SpeechInputModality(global::OpenRouter.SpeechInputModalityVariant3 value) => new SpeechInputModality((global::OpenRouter.SpeechInputModalityVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.SpeechInputModalityVariant3?(SpeechInputModality @this) => @this.SpeechInputModalityVariant3;

        /// <summary>
        ///
        /// </summary>
        public SpeechInputModality(global::OpenRouter.SpeechInputModalityVariant3? value)
        {
            SpeechInputModalityVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SpeechInputModality FromSpeechInputModalityVariant3(global::OpenRouter.SpeechInputModalityVariant3? value) => new SpeechInputModality(value);

        /// <summary>
        ///
        /// </summary>
        public SpeechInputModality(
            global::OpenRouter.SpeechInputModalityVariant1? speechInputModalityVariant1,
            global::OpenRouter.SpeechInputModalityVariant2? speechInputModalityVariant2,
            global::OpenRouter.SpeechInputModalityVariant3? speechInputModalityVariant3
            )
        {
            SpeechInputModalityVariant1 = speechInputModalityVariant1;
            SpeechInputModalityVariant2 = speechInputModalityVariant2;
            SpeechInputModalityVariant3 = speechInputModalityVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SpeechInputModalityVariant3 as object ??
            SpeechInputModalityVariant2 as object ??
            SpeechInputModalityVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SpeechInputModalityVariant1?.ToString() ??
            SpeechInputModalityVariant2?.ToString() ??
            SpeechInputModalityVariant3?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSpeechInputModalityVariant1 && !IsSpeechInputModalityVariant2 && !IsSpeechInputModalityVariant3 || !IsSpeechInputModalityVariant1 && IsSpeechInputModalityVariant2 && !IsSpeechInputModalityVariant3 || !IsSpeechInputModalityVariant1 && !IsSpeechInputModalityVariant2 && IsSpeechInputModalityVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.SpeechInputModalityVariant1, TResult>? speechInputModalityVariant1 = null,
            global::System.Func<global::OpenRouter.SpeechInputModalityVariant2, TResult>? speechInputModalityVariant2 = null,
            global::System.Func<global::OpenRouter.SpeechInputModalityVariant3, TResult>? speechInputModalityVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SpeechInputModalityVariant1 is { } __value0 && speechInputModalityVariant1 != null)
            {
                return speechInputModalityVariant1(__value0);
            }
            else if (SpeechInputModalityVariant2 is { } __value1 && speechInputModalityVariant2 != null)
            {
                return speechInputModalityVariant2(__value1);
            }
            else if (SpeechInputModalityVariant3 is { } __value2 && speechInputModalityVariant3 != null)
            {
                return speechInputModalityVariant3(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.SpeechInputModalityVariant1>? speechInputModalityVariant1 = null,

            global::System.Action<global::OpenRouter.SpeechInputModalityVariant2>? speechInputModalityVariant2 = null,

            global::System.Action<global::OpenRouter.SpeechInputModalityVariant3>? speechInputModalityVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SpeechInputModalityVariant1 is { } __value0)
            {
                speechInputModalityVariant1?.Invoke(__value0);
            }
            else if (SpeechInputModalityVariant2 is { } __value1)
            {
                speechInputModalityVariant2?.Invoke(__value1);
            }
            else if (SpeechInputModalityVariant3 is { } __value2)
            {
                speechInputModalityVariant3?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.SpeechInputModalityVariant1>? speechInputModalityVariant1 = null,
            global::System.Action<global::OpenRouter.SpeechInputModalityVariant2>? speechInputModalityVariant2 = null,
            global::System.Action<global::OpenRouter.SpeechInputModalityVariant3>? speechInputModalityVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SpeechInputModalityVariant1 is { } __value0)
            {
                speechInputModalityVariant1?.Invoke(__value0);
            }
            else if (SpeechInputModalityVariant2 is { } __value1)
            {
                speechInputModalityVariant2?.Invoke(__value1);
            }
            else if (SpeechInputModalityVariant3 is { } __value2)
            {
                speechInputModalityVariant3?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SpeechInputModalityVariant1,
                typeof(global::OpenRouter.SpeechInputModalityVariant1),
                SpeechInputModalityVariant2,
                typeof(global::OpenRouter.SpeechInputModalityVariant2),
                SpeechInputModalityVariant3,
                typeof(global::OpenRouter.SpeechInputModalityVariant3),
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
        public bool Equals(SpeechInputModality other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.SpeechInputModalityVariant1?>.Default.Equals(SpeechInputModalityVariant1, other.SpeechInputModalityVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.SpeechInputModalityVariant2?>.Default.Equals(SpeechInputModalityVariant2, other.SpeechInputModalityVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.SpeechInputModalityVariant3?>.Default.Equals(SpeechInputModalityVariant3, other.SpeechInputModalityVariant3)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SpeechInputModality obj1, SpeechInputModality obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SpeechInputModality>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SpeechInputModality obj1, SpeechInputModality obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SpeechInputModality o && Equals(o);
        }
    }
}
