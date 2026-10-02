#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A single condition that, when met, halts the server-tool agent loop.<br/>
    /// Example: {"step_count":5,"type":"step_count_is"}
    /// </summary>
    public readonly partial struct StopServerToolsWhenCondition : global::System.IEquatable<StopServerToolsWhenCondition>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenConditionDiscriminatorType? Type { get; }

        /// <summary>
        /// Stop after the agent loop has executed this many steps.<br/>
        /// Example: {"step_count":5,"type":"step_count_is"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.StopServerToolsWhenStepCountIs? StepCountIs { get; init; }
#else
        public global::OpenRouter.StopServerToolsWhenStepCountIs? StepCountIs { get; }
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
            out global::OpenRouter.StopServerToolsWhenStepCountIs? value)
        {
            value = StepCountIs;
            return IsStepCountIs;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenStepCountIs PickStepCountIs() => StepCountIs is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StepCountIs' but the value was {ToString()}.");

        /// <summary>
        /// Stop after a tool with this name has been called.<br/>
        /// Example: {"tool_name":"finalize","type":"has_tool_call"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.StopServerToolsWhenHasToolCall? HasToolCall { get; init; }
#else
        public global::OpenRouter.StopServerToolsWhenHasToolCall? HasToolCall { get; }
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
            out global::OpenRouter.StopServerToolsWhenHasToolCall? value)
        {
            value = HasToolCall;
            return IsHasToolCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenHasToolCall PickHasToolCall() => HasToolCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'HasToolCall' but the value was {ToString()}.");

        /// <summary>
        /// Stop once cumulative token usage across the loop exceeds this threshold.<br/>
        /// Example: {"max_tokens":10000,"type":"max_tokens_used"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.StopServerToolsWhenMaxTokensUsed? MaxTokensUsed { get; init; }
#else
        public global::OpenRouter.StopServerToolsWhenMaxTokensUsed? MaxTokensUsed { get; }
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
            out global::OpenRouter.StopServerToolsWhenMaxTokensUsed? value)
        {
            value = MaxTokensUsed;
            return IsMaxTokensUsed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenMaxTokensUsed PickMaxTokensUsed() => MaxTokensUsed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MaxTokensUsed' but the value was {ToString()}.");

        /// <summary>
        /// Stop once cumulative cost across the loop exceeds this dollar threshold.<br/>
        /// Example: {"max_cost_in_dollars":0.5,"type":"max_cost"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.StopServerToolsWhenMaxCost? MaxCost { get; init; }
#else
        public global::OpenRouter.StopServerToolsWhenMaxCost? MaxCost { get; }
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
            out global::OpenRouter.StopServerToolsWhenMaxCost? value)
        {
            value = MaxCost;
            return IsMaxCost;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenMaxCost PickMaxCost() => MaxCost is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MaxCost' but the value was {ToString()}.");

        /// <summary>
        /// Stop when the upstream model emits this finish reason (e.g. `length`).<br/>
        /// Example: {"reason":"length","type":"finish_reason_is"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.StopServerToolsWhenFinishReasonIs? FinishReasonIs { get; init; }
#else
        public global::OpenRouter.StopServerToolsWhenFinishReasonIs? FinishReasonIs { get; }
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
            out global::OpenRouter.StopServerToolsWhenFinishReasonIs? value)
        {
            value = FinishReasonIs;
            return IsFinishReasonIs;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StopServerToolsWhenFinishReasonIs PickFinishReasonIs() => FinishReasonIs is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FinishReasonIs' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StopServerToolsWhenCondition(global::OpenRouter.StopServerToolsWhenStepCountIs value) => new StopServerToolsWhenCondition((global::OpenRouter.StopServerToolsWhenStepCountIs?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.StopServerToolsWhenStepCountIs?(StopServerToolsWhenCondition @this) => @this.StepCountIs;

        /// <summary>
        ///
        /// </summary>
        public StopServerToolsWhenCondition(global::OpenRouter.StopServerToolsWhenStepCountIs? value)
        {
            StepCountIs = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StopServerToolsWhenCondition FromStepCountIs(global::OpenRouter.StopServerToolsWhenStepCountIs? value) => new StopServerToolsWhenCondition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StopServerToolsWhenCondition(global::OpenRouter.StopServerToolsWhenHasToolCall value) => new StopServerToolsWhenCondition((global::OpenRouter.StopServerToolsWhenHasToolCall?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.StopServerToolsWhenHasToolCall?(StopServerToolsWhenCondition @this) => @this.HasToolCall;

        /// <summary>
        ///
        /// </summary>
        public StopServerToolsWhenCondition(global::OpenRouter.StopServerToolsWhenHasToolCall? value)
        {
            HasToolCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StopServerToolsWhenCondition FromHasToolCall(global::OpenRouter.StopServerToolsWhenHasToolCall? value) => new StopServerToolsWhenCondition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StopServerToolsWhenCondition(global::OpenRouter.StopServerToolsWhenMaxTokensUsed value) => new StopServerToolsWhenCondition((global::OpenRouter.StopServerToolsWhenMaxTokensUsed?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.StopServerToolsWhenMaxTokensUsed?(StopServerToolsWhenCondition @this) => @this.MaxTokensUsed;

        /// <summary>
        ///
        /// </summary>
        public StopServerToolsWhenCondition(global::OpenRouter.StopServerToolsWhenMaxTokensUsed? value)
        {
            MaxTokensUsed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StopServerToolsWhenCondition FromMaxTokensUsed(global::OpenRouter.StopServerToolsWhenMaxTokensUsed? value) => new StopServerToolsWhenCondition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StopServerToolsWhenCondition(global::OpenRouter.StopServerToolsWhenMaxCost value) => new StopServerToolsWhenCondition((global::OpenRouter.StopServerToolsWhenMaxCost?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.StopServerToolsWhenMaxCost?(StopServerToolsWhenCondition @this) => @this.MaxCost;

        /// <summary>
        ///
        /// </summary>
        public StopServerToolsWhenCondition(global::OpenRouter.StopServerToolsWhenMaxCost? value)
        {
            MaxCost = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StopServerToolsWhenCondition FromMaxCost(global::OpenRouter.StopServerToolsWhenMaxCost? value) => new StopServerToolsWhenCondition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StopServerToolsWhenCondition(global::OpenRouter.StopServerToolsWhenFinishReasonIs value) => new StopServerToolsWhenCondition((global::OpenRouter.StopServerToolsWhenFinishReasonIs?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.StopServerToolsWhenFinishReasonIs?(StopServerToolsWhenCondition @this) => @this.FinishReasonIs;

        /// <summary>
        ///
        /// </summary>
        public StopServerToolsWhenCondition(global::OpenRouter.StopServerToolsWhenFinishReasonIs? value)
        {
            FinishReasonIs = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StopServerToolsWhenCondition FromFinishReasonIs(global::OpenRouter.StopServerToolsWhenFinishReasonIs? value) => new StopServerToolsWhenCondition(value);

        /// <summary>
        ///
        /// </summary>
        public StopServerToolsWhenCondition(
            global::OpenRouter.StopServerToolsWhenConditionDiscriminatorType? type,
            global::OpenRouter.StopServerToolsWhenStepCountIs? stepCountIs,
            global::OpenRouter.StopServerToolsWhenHasToolCall? hasToolCall,
            global::OpenRouter.StopServerToolsWhenMaxTokensUsed? maxTokensUsed,
            global::OpenRouter.StopServerToolsWhenMaxCost? maxCost,
            global::OpenRouter.StopServerToolsWhenFinishReasonIs? finishReasonIs
            )
        {
            Type = type;

            StepCountIs = stepCountIs;
            HasToolCall = hasToolCall;
            MaxTokensUsed = maxTokensUsed;
            MaxCost = maxCost;
            FinishReasonIs = finishReasonIs;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            FinishReasonIs as object ??
            MaxCost as object ??
            MaxTokensUsed as object ??
            HasToolCall as object ??
            StepCountIs as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            StepCountIs?.ToString() ??
            HasToolCall?.ToString() ??
            MaxTokensUsed?.ToString() ??
            MaxCost?.ToString() ??
            FinishReasonIs?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsStepCountIs && !IsHasToolCall && !IsMaxTokensUsed && !IsMaxCost && !IsFinishReasonIs || !IsStepCountIs && IsHasToolCall && !IsMaxTokensUsed && !IsMaxCost && !IsFinishReasonIs || !IsStepCountIs && !IsHasToolCall && IsMaxTokensUsed && !IsMaxCost && !IsFinishReasonIs || !IsStepCountIs && !IsHasToolCall && !IsMaxTokensUsed && IsMaxCost && !IsFinishReasonIs || !IsStepCountIs && !IsHasToolCall && !IsMaxTokensUsed && !IsMaxCost && IsFinishReasonIs;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.StopServerToolsWhenStepCountIs, TResult>? stepCountIs = null,
            global::System.Func<global::OpenRouter.StopServerToolsWhenHasToolCall, TResult>? hasToolCall = null,
            global::System.Func<global::OpenRouter.StopServerToolsWhenMaxTokensUsed, TResult>? maxTokensUsed = null,
            global::System.Func<global::OpenRouter.StopServerToolsWhenMaxCost, TResult>? maxCost = null,
            global::System.Func<global::OpenRouter.StopServerToolsWhenFinishReasonIs, TResult>? finishReasonIs = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (StepCountIs is { } __value0 && stepCountIs != null)
            {
                return stepCountIs(__value0);
            }
            else if (HasToolCall is { } __value1 && hasToolCall != null)
            {
                return hasToolCall(__value1);
            }
            else if (MaxTokensUsed is { } __value2 && maxTokensUsed != null)
            {
                return maxTokensUsed(__value2);
            }
            else if (MaxCost is { } __value3 && maxCost != null)
            {
                return maxCost(__value3);
            }
            else if (FinishReasonIs is { } __value4 && finishReasonIs != null)
            {
                return finishReasonIs(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.StopServerToolsWhenStepCountIs>? stepCountIs = null,

            global::System.Action<global::OpenRouter.StopServerToolsWhenHasToolCall>? hasToolCall = null,

            global::System.Action<global::OpenRouter.StopServerToolsWhenMaxTokensUsed>? maxTokensUsed = null,

            global::System.Action<global::OpenRouter.StopServerToolsWhenMaxCost>? maxCost = null,

            global::System.Action<global::OpenRouter.StopServerToolsWhenFinishReasonIs>? finishReasonIs = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (StepCountIs is { } __value0)
            {
                stepCountIs?.Invoke(__value0);
            }
            else if (HasToolCall is { } __value1)
            {
                hasToolCall?.Invoke(__value1);
            }
            else if (MaxTokensUsed is { } __value2)
            {
                maxTokensUsed?.Invoke(__value2);
            }
            else if (MaxCost is { } __value3)
            {
                maxCost?.Invoke(__value3);
            }
            else if (FinishReasonIs is { } __value4)
            {
                finishReasonIs?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.StopServerToolsWhenStepCountIs>? stepCountIs = null,
            global::System.Action<global::OpenRouter.StopServerToolsWhenHasToolCall>? hasToolCall = null,
            global::System.Action<global::OpenRouter.StopServerToolsWhenMaxTokensUsed>? maxTokensUsed = null,
            global::System.Action<global::OpenRouter.StopServerToolsWhenMaxCost>? maxCost = null,
            global::System.Action<global::OpenRouter.StopServerToolsWhenFinishReasonIs>? finishReasonIs = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (StepCountIs is { } __value0)
            {
                stepCountIs?.Invoke(__value0);
            }
            else if (HasToolCall is { } __value1)
            {
                hasToolCall?.Invoke(__value1);
            }
            else if (MaxTokensUsed is { } __value2)
            {
                maxTokensUsed?.Invoke(__value2);
            }
            else if (MaxCost is { } __value3)
            {
                maxCost?.Invoke(__value3);
            }
            else if (FinishReasonIs is { } __value4)
            {
                finishReasonIs?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StepCountIs,
                typeof(global::OpenRouter.StopServerToolsWhenStepCountIs),
                HasToolCall,
                typeof(global::OpenRouter.StopServerToolsWhenHasToolCall),
                MaxTokensUsed,
                typeof(global::OpenRouter.StopServerToolsWhenMaxTokensUsed),
                MaxCost,
                typeof(global::OpenRouter.StopServerToolsWhenMaxCost),
                FinishReasonIs,
                typeof(global::OpenRouter.StopServerToolsWhenFinishReasonIs),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.StopServerToolsWhenStepCountIs?>.Default.Equals(StepCountIs, other.StepCountIs) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.StopServerToolsWhenHasToolCall?>.Default.Equals(HasToolCall, other.HasToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.StopServerToolsWhenMaxTokensUsed?>.Default.Equals(MaxTokensUsed, other.MaxTokensUsed) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.StopServerToolsWhenMaxCost?>.Default.Equals(MaxCost, other.MaxCost) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.StopServerToolsWhenFinishReasonIs?>.Default.Equals(FinishReasonIs, other.FinishReasonIs)
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
