#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AccountGuardrailPolicy : global::System.IEquatable<AccountGuardrailPolicy>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AccountGuardrailPolicyDiscriminatorPolicyType? PolicyType { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BudgetAccountGuardrailPolicy? Budget { get; init; }
#else
        public global::OpenRouter.BudgetAccountGuardrailPolicy? Budget { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Budget))]
#endif
        public bool IsBudget => Budget != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBudget(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.BudgetAccountGuardrailPolicy? value)
        {
            value = Budget;
            return IsBudget;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BudgetAccountGuardrailPolicy PickBudget() => Budget is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Budget' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ModerationAccountGuardrailPolicy? Moderation { get; init; }
#else
        public global::OpenRouter.ModerationAccountGuardrailPolicy? Moderation { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Moderation))]
#endif
        public bool IsModeration => Moderation != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickModeration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ModerationAccountGuardrailPolicy? value)
        {
            value = Moderation;
            return IsModeration;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModerationAccountGuardrailPolicy PickModeration() => Moderation is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Moderation' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ModelAvailabilityAccountGuardrailPolicy? ModelAvailability { get; init; }
#else
        public global::OpenRouter.ModelAvailabilityAccountGuardrailPolicy? ModelAvailability { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelAvailability))]
#endif
        public bool IsModelAvailability => ModelAvailability != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickModelAvailability(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ModelAvailabilityAccountGuardrailPolicy? value)
        {
            value = ModelAvailability;
            return IsModelAvailability;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelAvailabilityAccountGuardrailPolicy PickModelAvailability() => ModelAvailability is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelAvailability' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AccountGuardrailPolicy(global::OpenRouter.BudgetAccountGuardrailPolicy value) => new AccountGuardrailPolicy((global::OpenRouter.BudgetAccountGuardrailPolicy?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.BudgetAccountGuardrailPolicy?(AccountGuardrailPolicy @this) => @this.Budget;

        /// <summary>
        ///
        /// </summary>
        public AccountGuardrailPolicy(global::OpenRouter.BudgetAccountGuardrailPolicy? value)
        {
            Budget = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AccountGuardrailPolicy FromBudget(global::OpenRouter.BudgetAccountGuardrailPolicy? value) => new AccountGuardrailPolicy(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AccountGuardrailPolicy(global::OpenRouter.ModerationAccountGuardrailPolicy value) => new AccountGuardrailPolicy((global::OpenRouter.ModerationAccountGuardrailPolicy?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ModerationAccountGuardrailPolicy?(AccountGuardrailPolicy @this) => @this.Moderation;

        /// <summary>
        ///
        /// </summary>
        public AccountGuardrailPolicy(global::OpenRouter.ModerationAccountGuardrailPolicy? value)
        {
            Moderation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AccountGuardrailPolicy FromModeration(global::OpenRouter.ModerationAccountGuardrailPolicy? value) => new AccountGuardrailPolicy(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AccountGuardrailPolicy(global::OpenRouter.ModelAvailabilityAccountGuardrailPolicy value) => new AccountGuardrailPolicy((global::OpenRouter.ModelAvailabilityAccountGuardrailPolicy?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ModelAvailabilityAccountGuardrailPolicy?(AccountGuardrailPolicy @this) => @this.ModelAvailability;

        /// <summary>
        ///
        /// </summary>
        public AccountGuardrailPolicy(global::OpenRouter.ModelAvailabilityAccountGuardrailPolicy? value)
        {
            ModelAvailability = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AccountGuardrailPolicy FromModelAvailability(global::OpenRouter.ModelAvailabilityAccountGuardrailPolicy? value) => new AccountGuardrailPolicy(value);

        /// <summary>
        ///
        /// </summary>
        public AccountGuardrailPolicy(
            global::OpenRouter.AccountGuardrailPolicyDiscriminatorPolicyType? policyType,
            global::OpenRouter.BudgetAccountGuardrailPolicy? budget,
            global::OpenRouter.ModerationAccountGuardrailPolicy? moderation,
            global::OpenRouter.ModelAvailabilityAccountGuardrailPolicy? modelAvailability
            )
        {
            PolicyType = policyType;

            Budget = budget;
            Moderation = moderation;
            ModelAvailability = modelAvailability;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ModelAvailability as object ??
            Moderation as object ??
            Budget as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Budget?.ToString() ??
            Moderation?.ToString() ??
            ModelAvailability?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBudget && !IsModeration && !IsModelAvailability || !IsBudget && IsModeration && !IsModelAvailability || !IsBudget && !IsModeration && IsModelAvailability;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.BudgetAccountGuardrailPolicy, TResult>? budget = null,
            global::System.Func<global::OpenRouter.ModerationAccountGuardrailPolicy, TResult>? moderation = null,
            global::System.Func<global::OpenRouter.ModelAvailabilityAccountGuardrailPolicy, TResult>? modelAvailability = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Budget is { } __value0 && budget != null)
            {
                return budget(__value0);
            }
            else if (Moderation is { } __value1 && moderation != null)
            {
                return moderation(__value1);
            }
            else if (ModelAvailability is { } __value2 && modelAvailability != null)
            {
                return modelAvailability(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.BudgetAccountGuardrailPolicy>? budget = null,

            global::System.Action<global::OpenRouter.ModerationAccountGuardrailPolicy>? moderation = null,

            global::System.Action<global::OpenRouter.ModelAvailabilityAccountGuardrailPolicy>? modelAvailability = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Budget is { } __value0)
            {
                budget?.Invoke(__value0);
            }
            else if (Moderation is { } __value1)
            {
                moderation?.Invoke(__value1);
            }
            else if (ModelAvailability is { } __value2)
            {
                modelAvailability?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.BudgetAccountGuardrailPolicy>? budget = null,
            global::System.Action<global::OpenRouter.ModerationAccountGuardrailPolicy>? moderation = null,
            global::System.Action<global::OpenRouter.ModelAvailabilityAccountGuardrailPolicy>? modelAvailability = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Budget is { } __value0)
            {
                budget?.Invoke(__value0);
            }
            else if (Moderation is { } __value1)
            {
                moderation?.Invoke(__value1);
            }
            else if (ModelAvailability is { } __value2)
            {
                modelAvailability?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Budget,
                typeof(global::OpenRouter.BudgetAccountGuardrailPolicy),
                Moderation,
                typeof(global::OpenRouter.ModerationAccountGuardrailPolicy),
                ModelAvailability,
                typeof(global::OpenRouter.ModelAvailabilityAccountGuardrailPolicy),
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
        public bool Equals(AccountGuardrailPolicy other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BudgetAccountGuardrailPolicy?>.Default.Equals(Budget, other.Budget) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ModerationAccountGuardrailPolicy?>.Default.Equals(Moderation, other.Moderation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ModelAvailabilityAccountGuardrailPolicy?>.Default.Equals(ModelAvailability, other.ModelAvailability)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AccountGuardrailPolicy obj1, AccountGuardrailPolicy obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AccountGuardrailPolicy>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AccountGuardrailPolicy obj1, AccountGuardrailPolicy obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AccountGuardrailPolicy o && Equals(o);
        }
    }
}
