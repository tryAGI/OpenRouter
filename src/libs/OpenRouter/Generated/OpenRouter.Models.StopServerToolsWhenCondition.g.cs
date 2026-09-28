#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A single condition that, when met, halts the server-tool agent loop.
    /// </summary>
    public readonly partial struct StopServerToolsWhenCondition : global::System.IEquatable<StopServerToolsWhenCondition>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenConditionDiscriminatorType? Type { get; }

        /// <summary>
        /// Stop when the upstream model emits this finish reason (e.g. `length`).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.StopServerToolsWhenConditionVariant1? FinishReasonIs { get; init; }
#else
        public global::OpenRouter.StopServerToolsWhenConditionVariant1? FinishReasonIs { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FinishReasonIs))]
#endif
        public bool IsFinishReasonIs => FinishReasonIs != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFinishReasonIs(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.StopServerToolsWhenConditionVariant1? value)
        {
            value = FinishReasonIs;
            return IsFinishReasonIs;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenConditionVariant1 PickFinishReasonIs() => FinishReasonIs is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FinishReasonIs' but the value was {ToString()}.");

        /// <summary>
        /// Stop after a tool with this name has been called.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.StopServerToolsWhenConditionVariant2? HasToolCall { get; init; }
#else
        public global::OpenRouter.StopServerToolsWhenConditionVariant2? HasToolCall { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HasToolCall))]
#endif
        public bool IsHasToolCall => HasToolCall != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickHasToolCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.StopServerToolsWhenConditionVariant2? value)
        {
            value = HasToolCall;
            return IsHasToolCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenConditionVariant2 PickHasToolCall() => HasToolCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HasToolCall' but the value was {ToString()}.");

        /// <summary>
        /// Stop once cumulative cost across the loop exceeds this dollar threshold.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.StopServerToolsWhenConditionVariant3? MaxCost { get; init; }
#else
        public global::OpenRouter.StopServerToolsWhenConditionVariant3? MaxCost { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MaxCost))]
#endif
        public bool IsMaxCost => MaxCost != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMaxCost(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.StopServerToolsWhenConditionVariant3? value)
        {
            value = MaxCost;
            return IsMaxCost;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenConditionVariant3 PickMaxCost() => MaxCost is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MaxCost' but the value was {ToString()}.");

        /// <summary>
        /// Stop once cumulative token usage across the loop exceeds this threshold.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.StopServerToolsWhenConditionVariant4? MaxTokensUsed { get; init; }
#else
        public global::OpenRouter.StopServerToolsWhenConditionVariant4? MaxTokensUsed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MaxTokensUsed))]
#endif
        public bool IsMaxTokensUsed => MaxTokensUsed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMaxTokensUsed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.StopServerToolsWhenConditionVariant4? value)
        {
            value = MaxTokensUsed;
            return IsMaxTokensUsed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenConditionVariant4 PickMaxTokensUsed() => MaxTokensUsed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MaxTokensUsed' but the value was {ToString()}.");

        /// <summary>
        /// Stop after the agent loop has executed this many steps.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.StopServerToolsWhenConditionVariant5? StepCountIs { get; init; }
#else
        public global::OpenRouter.StopServerToolsWhenConditionVariant5? StepCountIs { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StepCountIs))]
#endif
        public bool IsStepCountIs => StepCountIs != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStepCountIs(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.StopServerToolsWhenConditionVariant5? value)
        {
            value = StepCountIs;
            return IsStepCountIs;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenConditionVariant5 PickStepCountIs() => StepCountIs is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StepCountIs' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StopServerToolsWhenCondition(global::OpenRouter.StopServerToolsWhenConditionVariant1 value) => new StopServerToolsWhenCondition((global::OpenRouter.StopServerToolsWhenConditionVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.StopServerToolsWhenConditionVariant1?(StopServerToolsWhenCondition @this) => @this.FinishReasonIs;

        /// <summary>
        ///
        /// </summary>
        public StopServerToolsWhenCondition(global::OpenRouter.StopServerToolsWhenConditionVariant1? value)
        {
            FinishReasonIs = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StopServerToolsWhenCondition FromFinishReasonIs(global::OpenRouter.StopServerToolsWhenConditionVariant1? value) => new StopServerToolsWhenCondition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StopServerToolsWhenCondition(global::OpenRouter.StopServerToolsWhenConditionVariant2 value) => new StopServerToolsWhenCondition((global::OpenRouter.StopServerToolsWhenConditionVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.StopServerToolsWhenConditionVariant2?(StopServerToolsWhenCondition @this) => @this.HasToolCall;

        /// <summary>
        ///
        /// </summary>
        public StopServerToolsWhenCondition(global::OpenRouter.StopServerToolsWhenConditionVariant2? value)
        {
            HasToolCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StopServerToolsWhenCondition FromHasToolCall(global::OpenRouter.StopServerToolsWhenConditionVariant2? value) => new StopServerToolsWhenCondition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StopServerToolsWhenCondition(global::OpenRouter.StopServerToolsWhenConditionVariant3 value) => new StopServerToolsWhenCondition((global::OpenRouter.StopServerToolsWhenConditionVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.StopServerToolsWhenConditionVariant3?(StopServerToolsWhenCondition @this) => @this.MaxCost;

        /// <summary>
        ///
        /// </summary>
        public StopServerToolsWhenCondition(global::OpenRouter.StopServerToolsWhenConditionVariant3? value)
        {
            MaxCost = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StopServerToolsWhenCondition FromMaxCost(global::OpenRouter.StopServerToolsWhenConditionVariant3? value) => new StopServerToolsWhenCondition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StopServerToolsWhenCondition(global::OpenRouter.StopServerToolsWhenConditionVariant4 value) => new StopServerToolsWhenCondition((global::OpenRouter.StopServerToolsWhenConditionVariant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.StopServerToolsWhenConditionVariant4?(StopServerToolsWhenCondition @this) => @this.MaxTokensUsed;

        /// <summary>
        ///
        /// </summary>
        public StopServerToolsWhenCondition(global::OpenRouter.StopServerToolsWhenConditionVariant4? value)
        {
            MaxTokensUsed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StopServerToolsWhenCondition FromMaxTokensUsed(global::OpenRouter.StopServerToolsWhenConditionVariant4? value) => new StopServerToolsWhenCondition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StopServerToolsWhenCondition(global::OpenRouter.StopServerToolsWhenConditionVariant5 value) => new StopServerToolsWhenCondition((global::OpenRouter.StopServerToolsWhenConditionVariant5?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.StopServerToolsWhenConditionVariant5?(StopServerToolsWhenCondition @this) => @this.StepCountIs;

        /// <summary>
        ///
        /// </summary>
        public StopServerToolsWhenCondition(global::OpenRouter.StopServerToolsWhenConditionVariant5? value)
        {
            StepCountIs = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StopServerToolsWhenCondition FromStepCountIs(global::OpenRouter.StopServerToolsWhenConditionVariant5? value) => new StopServerToolsWhenCondition(value);

        /// <summary>
        ///
        /// </summary>
        public StopServerToolsWhenCondition(
            global::OpenRouter.StopServerToolsWhenConditionDiscriminatorType? type,
            global::OpenRouter.StopServerToolsWhenConditionVariant1? finishReasonIs,
            global::OpenRouter.StopServerToolsWhenConditionVariant2? hasToolCall,
            global::OpenRouter.StopServerToolsWhenConditionVariant3? maxCost,
            global::OpenRouter.StopServerToolsWhenConditionVariant4? maxTokensUsed,
            global::OpenRouter.StopServerToolsWhenConditionVariant5? stepCountIs
            )
        {
            Type = type;

            FinishReasonIs = finishReasonIs;
            HasToolCall = hasToolCall;
            MaxCost = maxCost;
            MaxTokensUsed = maxTokensUsed;
            StepCountIs = stepCountIs;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            StepCountIs as object ??
            MaxTokensUsed as object ??
            MaxCost as object ??
            HasToolCall as object ??
            FinishReasonIs as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            FinishReasonIs?.ToString() ??
            HasToolCall?.ToString() ??
            MaxCost?.ToString() ??
            MaxTokensUsed?.ToString() ??
            StepCountIs?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsFinishReasonIs && !IsHasToolCall && !IsMaxCost && !IsMaxTokensUsed && !IsStepCountIs || !IsFinishReasonIs && IsHasToolCall && !IsMaxCost && !IsMaxTokensUsed && !IsStepCountIs || !IsFinishReasonIs && !IsHasToolCall && IsMaxCost && !IsMaxTokensUsed && !IsStepCountIs || !IsFinishReasonIs && !IsHasToolCall && !IsMaxCost && IsMaxTokensUsed && !IsStepCountIs || !IsFinishReasonIs && !IsHasToolCall && !IsMaxCost && !IsMaxTokensUsed && IsStepCountIs;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.StopServerToolsWhenConditionVariant1, TResult>? finishReasonIs = null,
            global::System.Func<global::OpenRouter.StopServerToolsWhenConditionVariant2, TResult>? hasToolCall = null,
            global::System.Func<global::OpenRouter.StopServerToolsWhenConditionVariant3, TResult>? maxCost = null,
            global::System.Func<global::OpenRouter.StopServerToolsWhenConditionVariant4, TResult>? maxTokensUsed = null,
            global::System.Func<global::OpenRouter.StopServerToolsWhenConditionVariant5, TResult>? stepCountIs = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (FinishReasonIs is { } __value0 && finishReasonIs != null)
            {
                return finishReasonIs(__value0);
            }
            else if (HasToolCall is { } __value1 && hasToolCall != null)
            {
                return hasToolCall(__value1);
            }
            else if (MaxCost is { } __value2 && maxCost != null)
            {
                return maxCost(__value2);
            }
            else if (MaxTokensUsed is { } __value3 && maxTokensUsed != null)
            {
                return maxTokensUsed(__value3);
            }
            else if (StepCountIs is { } __value4 && stepCountIs != null)
            {
                return stepCountIs(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.StopServerToolsWhenConditionVariant1>? finishReasonIs = null,

            global::System.Action<global::OpenRouter.StopServerToolsWhenConditionVariant2>? hasToolCall = null,

            global::System.Action<global::OpenRouter.StopServerToolsWhenConditionVariant3>? maxCost = null,

            global::System.Action<global::OpenRouter.StopServerToolsWhenConditionVariant4>? maxTokensUsed = null,

            global::System.Action<global::OpenRouter.StopServerToolsWhenConditionVariant5>? stepCountIs = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (FinishReasonIs is { } __value0)
            {
                finishReasonIs?.Invoke(__value0);
            }
            else if (HasToolCall is { } __value1)
            {
                hasToolCall?.Invoke(__value1);
            }
            else if (MaxCost is { } __value2)
            {
                maxCost?.Invoke(__value2);
            }
            else if (MaxTokensUsed is { } __value3)
            {
                maxTokensUsed?.Invoke(__value3);
            }
            else if (StepCountIs is { } __value4)
            {
                stepCountIs?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.StopServerToolsWhenConditionVariant1>? finishReasonIs = null,
            global::System.Action<global::OpenRouter.StopServerToolsWhenConditionVariant2>? hasToolCall = null,
            global::System.Action<global::OpenRouter.StopServerToolsWhenConditionVariant3>? maxCost = null,
            global::System.Action<global::OpenRouter.StopServerToolsWhenConditionVariant4>? maxTokensUsed = null,
            global::System.Action<global::OpenRouter.StopServerToolsWhenConditionVariant5>? stepCountIs = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (FinishReasonIs is { } __value0)
            {
                finishReasonIs?.Invoke(__value0);
            }
            else if (HasToolCall is { } __value1)
            {
                hasToolCall?.Invoke(__value1);
            }
            else if (MaxCost is { } __value2)
            {
                maxCost?.Invoke(__value2);
            }
            else if (MaxTokensUsed is { } __value3)
            {
                maxTokensUsed?.Invoke(__value3);
            }
            else if (StepCountIs is { } __value4)
            {
                stepCountIs?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FinishReasonIs,
                typeof(global::OpenRouter.StopServerToolsWhenConditionVariant1),
                HasToolCall,
                typeof(global::OpenRouter.StopServerToolsWhenConditionVariant2),
                MaxCost,
                typeof(global::OpenRouter.StopServerToolsWhenConditionVariant3),
                MaxTokensUsed,
                typeof(global::OpenRouter.StopServerToolsWhenConditionVariant4),
                StepCountIs,
                typeof(global::OpenRouter.StopServerToolsWhenConditionVariant5),
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
        public bool Equals(StopServerToolsWhenCondition other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.StopServerToolsWhenConditionVariant1?>.Default.Equals(FinishReasonIs, other.FinishReasonIs) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.StopServerToolsWhenConditionVariant2?>.Default.Equals(HasToolCall, other.HasToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.StopServerToolsWhenConditionVariant3?>.Default.Equals(MaxCost, other.MaxCost) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.StopServerToolsWhenConditionVariant4?>.Default.Equals(MaxTokensUsed, other.MaxTokensUsed) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.StopServerToolsWhenConditionVariant5?>.Default.Equals(StepCountIs, other.StepCountIs)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StopServerToolsWhenCondition obj1, StopServerToolsWhenCondition obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StopServerToolsWhenCondition>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StopServerToolsWhenCondition obj1, StopServerToolsWhenCondition obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StopServerToolsWhenCondition o && Equals(o);
        }
    }
}
