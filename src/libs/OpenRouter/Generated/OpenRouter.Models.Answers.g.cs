#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A Decisions answer using a boolean, choice, or score evaluation.
    /// </summary>
    public readonly partial struct Answers : global::System.IEquatable<Answers>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsResponseAnswersDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.DecisionsNoulAnswer? Noul { get; init; }
#else
        public global::OpenRouter.DecisionsNoulAnswer? Noul { get; }
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
            out global::OpenRouter.DecisionsNoulAnswer? value)
        {
            value = Noul;
            return IsNoul;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsNoulAnswer PickNoul() => Noul is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Noul' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.DecisionsChoiceAnswer? Choice { get; init; }
#else
        public global::OpenRouter.DecisionsChoiceAnswer? Choice { get; }
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
            out global::OpenRouter.DecisionsChoiceAnswer? value)
        {
            value = Choice;
            return IsChoice;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsChoiceAnswer PickChoice() => Choice is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Choice' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.DecisionsScoreAnswer? Score { get; init; }
#else
        public global::OpenRouter.DecisionsScoreAnswer? Score { get; }
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
            out global::OpenRouter.DecisionsScoreAnswer? value)
        {
            value = Score;
            return IsScore;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.DecisionsScoreAnswer PickScore() => Score is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Score' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Answers(global::OpenRouter.DecisionsNoulAnswer value) => new Answers((global::OpenRouter.DecisionsNoulAnswer?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.DecisionsNoulAnswer?(Answers @this) => @this.Noul;

        /// <summary>
        ///
        /// </summary>
        public Answers(global::OpenRouter.DecisionsNoulAnswer? value)
        {
            Noul = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Answers FromNoul(global::OpenRouter.DecisionsNoulAnswer? value) => new Answers(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Answers(global::OpenRouter.DecisionsChoiceAnswer value) => new Answers((global::OpenRouter.DecisionsChoiceAnswer?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.DecisionsChoiceAnswer?(Answers @this) => @this.Choice;

        /// <summary>
        ///
        /// </summary>
        public Answers(global::OpenRouter.DecisionsChoiceAnswer? value)
        {
            Choice = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Answers FromChoice(global::OpenRouter.DecisionsChoiceAnswer? value) => new Answers(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Answers(global::OpenRouter.DecisionsScoreAnswer value) => new Answers((global::OpenRouter.DecisionsScoreAnswer?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.DecisionsScoreAnswer?(Answers @this) => @this.Score;

        /// <summary>
        ///
        /// </summary>
        public Answers(global::OpenRouter.DecisionsScoreAnswer? value)
        {
            Score = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Answers FromScore(global::OpenRouter.DecisionsScoreAnswer? value) => new Answers(value);

        /// <summary>
        ///
        /// </summary>
        public Answers(
            global::OpenRouter.DecisionsResponseAnswersDiscriminatorType? type,
            global::OpenRouter.DecisionsNoulAnswer? noul,
            global::OpenRouter.DecisionsChoiceAnswer? choice,
            global::OpenRouter.DecisionsScoreAnswer? score
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
            global::System.Func<global::OpenRouter.DecisionsNoulAnswer, TResult>? noul = null,
            global::System.Func<global::OpenRouter.DecisionsChoiceAnswer, TResult>? choice = null,
            global::System.Func<global::OpenRouter.DecisionsScoreAnswer, TResult>? score = null,
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
            global::System.Action<global::OpenRouter.DecisionsNoulAnswer>? noul = null,

            global::System.Action<global::OpenRouter.DecisionsChoiceAnswer>? choice = null,

            global::System.Action<global::OpenRouter.DecisionsScoreAnswer>? score = null,
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
            global::System.Action<global::OpenRouter.DecisionsNoulAnswer>? noul = null,
            global::System.Action<global::OpenRouter.DecisionsChoiceAnswer>? choice = null,
            global::System.Action<global::OpenRouter.DecisionsScoreAnswer>? score = null,
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
                typeof(global::OpenRouter.DecisionsNoulAnswer),
                Choice,
                typeof(global::OpenRouter.DecisionsChoiceAnswer),
                Score,
                typeof(global::OpenRouter.DecisionsScoreAnswer),
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
        public bool Equals(Answers other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.DecisionsNoulAnswer?>.Default.Equals(Noul, other.Noul) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.DecisionsChoiceAnswer?>.Default.Equals(Choice, other.Choice) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.DecisionsScoreAnswer?>.Default.Equals(Score, other.Score)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Answers obj1, Answers obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Answers>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Answers obj1, Answers obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Answers o && Equals(o);
        }
    }
}
