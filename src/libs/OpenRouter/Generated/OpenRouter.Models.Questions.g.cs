#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A Decisions question using a boolean, choice, or ordered score evaluation.
    /// </summary>
    public readonly partial struct Questions : global::System.IEquatable<Questions>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsRequestQuestionsDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.DecisionsNoulQuestion? Noul { get; init; }
#else
        public global::OpenRouter.DecisionsNoulQuestion? Noul { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Noul))]
#endif
        public bool IsNoul => Noul != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNoul(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.DecisionsNoulQuestion? value)
        {
            value = Noul;
            return IsNoul;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsNoulQuestion PickNoul() => Noul is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Noul' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.DecisionsChoiceQuestion? Choice { get; init; }
#else
        public global::OpenRouter.DecisionsChoiceQuestion? Choice { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Choice))]
#endif
        public bool IsChoice => Choice != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChoice(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.DecisionsChoiceQuestion? value)
        {
            value = Choice;
            return IsChoice;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsChoiceQuestion PickChoice() => Choice is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Choice' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.DecisionsScoreQuestion? Score { get; init; }
#else
        public global::OpenRouter.DecisionsScoreQuestion? Score { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Score))]
#endif
        public bool IsScore => Score != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScore(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.DecisionsScoreQuestion? value)
        {
            value = Score;
            return IsScore;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsScoreQuestion PickScore() => Score is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Score' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Questions(global::OpenRouter.DecisionsNoulQuestion value) => new Questions((global::OpenRouter.DecisionsNoulQuestion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.DecisionsNoulQuestion?(Questions @this) => @this.Noul;

        /// <summary>
        ///
        /// </summary>
        public Questions(global::OpenRouter.DecisionsNoulQuestion? value)
        {
            Noul = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Questions FromNoul(global::OpenRouter.DecisionsNoulQuestion? value) => new Questions(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Questions(global::OpenRouter.DecisionsChoiceQuestion value) => new Questions((global::OpenRouter.DecisionsChoiceQuestion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.DecisionsChoiceQuestion?(Questions @this) => @this.Choice;

        /// <summary>
        ///
        /// </summary>
        public Questions(global::OpenRouter.DecisionsChoiceQuestion? value)
        {
            Choice = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Questions FromChoice(global::OpenRouter.DecisionsChoiceQuestion? value) => new Questions(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Questions(global::OpenRouter.DecisionsScoreQuestion value) => new Questions((global::OpenRouter.DecisionsScoreQuestion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.DecisionsScoreQuestion?(Questions @this) => @this.Score;

        /// <summary>
        ///
        /// </summary>
        public Questions(global::OpenRouter.DecisionsScoreQuestion? value)
        {
            Score = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Questions FromScore(global::OpenRouter.DecisionsScoreQuestion? value) => new Questions(value);

        /// <summary>
        ///
        /// </summary>
        public Questions(
            global::OpenRouter.DecisionsRequestQuestionsDiscriminatorType? type,
            global::OpenRouter.DecisionsNoulQuestion? noul,
            global::OpenRouter.DecisionsChoiceQuestion? choice,
            global::OpenRouter.DecisionsScoreQuestion? score
            )
        {
            Type = type;

            Noul = noul;
            Choice = choice;
            Score = score;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Score as object ??
            Choice as object ??
            Noul as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Noul?.ToString() ??
            Choice?.ToString() ??
            Score?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsNoul && !IsChoice && !IsScore || !IsNoul && IsChoice && !IsScore || !IsNoul && !IsChoice && IsScore;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.DecisionsNoulQuestion, TResult>? noul = null,
            global::System.Func<global::OpenRouter.DecisionsChoiceQuestion, TResult>? choice = null,
            global::System.Func<global::OpenRouter.DecisionsScoreQuestion, TResult>? score = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Noul is { } __value0 && noul != null)
            {
                return noul(__value0);
            }
            else if (Choice is { } __value1 && choice != null)
            {
                return choice(__value1);
            }
            else if (Score is { } __value2 && score != null)
            {
                return score(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.DecisionsNoulQuestion>? noul = null,

            global::System.Action<global::OpenRouter.DecisionsChoiceQuestion>? choice = null,

            global::System.Action<global::OpenRouter.DecisionsScoreQuestion>? score = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Noul is { } __value0)
            {
                noul?.Invoke(__value0);
            }
            else if (Choice is { } __value1)
            {
                choice?.Invoke(__value1);
            }
            else if (Score is { } __value2)
            {
                score?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.DecisionsNoulQuestion>? noul = null,
            global::System.Action<global::OpenRouter.DecisionsChoiceQuestion>? choice = null,
            global::System.Action<global::OpenRouter.DecisionsScoreQuestion>? score = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Noul is { } __value0)
            {
                noul?.Invoke(__value0);
            }
            else if (Choice is { } __value1)
            {
                choice?.Invoke(__value1);
            }
            else if (Score is { } __value2)
            {
                score?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Noul,
                typeof(global::OpenRouter.DecisionsNoulQuestion),
                Choice,
                typeof(global::OpenRouter.DecisionsChoiceQuestion),
                Score,
                typeof(global::OpenRouter.DecisionsScoreQuestion),
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
        public bool Equals(Questions other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.DecisionsNoulQuestion?>.Default.Equals(Noul, other.Noul) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.DecisionsChoiceQuestion?>.Default.Equals(Choice, other.Choice) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.DecisionsScoreQuestion?>.Default.Equals(Score, other.Score)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Questions obj1, Questions obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Questions>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Questions obj1, Questions obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Questions o && Equals(o);
        }
    }
}
