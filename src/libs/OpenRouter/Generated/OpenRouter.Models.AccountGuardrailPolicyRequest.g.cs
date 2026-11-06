#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AccountGuardrailPolicyRequest : global::System.IEquatable<AccountGuardrailPolicyRequest>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AccountGuardrailPolicyRequestDiscriminatorPolicyType? PolicyType { get; }

        /// <summary>
        /// Example: {"config":{"include_byok_in_budgets":false,"limit_usd":200,"reset_interval":"monthly"},"name":"Engineering monthly budget","policy_type":"budget","workspace_ids":["0df9e665-d932-5740-b2c7-b52af166bc11"]}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BudgetAccountGuardrailPolicyRequest? Budget { get; init; }
#else
        public global::OpenRouter.BudgetAccountGuardrailPolicyRequest? Budget { get; }
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
            out global::OpenRouter.BudgetAccountGuardrailPolicyRequest? value)
        {
            value = Budget;
            return IsBudget;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.BudgetAccountGuardrailPolicyRequest PickBudget() => Budget is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Budget' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"config":{"content_filter_builtins":[{"action":"block","slug":"secrets"}]},"name":"Block secrets","policy_type":"moderation","workspace_ids":["0df9e665-d932-5740-b2c7-b52af166bc11"]}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ModerationAccountGuardrailPolicyRequest? Moderation { get; init; }
#else
        public global::OpenRouter.ModerationAccountGuardrailPolicyRequest? Moderation { get; }
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
            out global::OpenRouter.ModerationAccountGuardrailPolicyRequest? value)
        {
            value = Moderation;
            return IsModeration;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModerationAccountGuardrailPolicyRequest PickModeration() => Moderation is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Moderation' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"config":{"allowed_models":["openai/gpt-4o","anthropic/claude-sonnet-4"],"allowed_providers":["openai","anthropic"],"enforce_zdr_anthropic":true,"enforce_zdr_openai":true},"name":"Approved models","policy_type":"model_availability","workspace_ids":["0df9e665-d932-5740-b2c7-b52af166bc11"]}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ModelAvailabilityAccountGuardrailPolicyRequest? ModelAvailability { get; init; }
#else
        public global::OpenRouter.ModelAvailabilityAccountGuardrailPolicyRequest? ModelAvailability { get; }
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
            out global::OpenRouter.ModelAvailabilityAccountGuardrailPolicyRequest? value)
        {
            value = ModelAvailability;
            return IsModelAvailability;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelAvailabilityAccountGuardrailPolicyRequest PickModelAvailability() => ModelAvailability is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelAvailability' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AccountGuardrailPolicyRequest(global::OpenRouter.BudgetAccountGuardrailPolicyRequest value) => new AccountGuardrailPolicyRequest((global::OpenRouter.BudgetAccountGuardrailPolicyRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.BudgetAccountGuardrailPolicyRequest?(AccountGuardrailPolicyRequest @this) => @this.Budget;

        /// <summary>
        ///
        /// </summary>
        public AccountGuardrailPolicyRequest(global::OpenRouter.BudgetAccountGuardrailPolicyRequest? value)
        {
            Budget = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AccountGuardrailPolicyRequest FromBudget(global::OpenRouter.BudgetAccountGuardrailPolicyRequest? value) => new AccountGuardrailPolicyRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AccountGuardrailPolicyRequest(global::OpenRouter.ModerationAccountGuardrailPolicyRequest value) => new AccountGuardrailPolicyRequest((global::OpenRouter.ModerationAccountGuardrailPolicyRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ModerationAccountGuardrailPolicyRequest?(AccountGuardrailPolicyRequest @this) => @this.Moderation;

        /// <summary>
        ///
        /// </summary>
        public AccountGuardrailPolicyRequest(global::OpenRouter.ModerationAccountGuardrailPolicyRequest? value)
        {
            Moderation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AccountGuardrailPolicyRequest FromModeration(global::OpenRouter.ModerationAccountGuardrailPolicyRequest? value) => new AccountGuardrailPolicyRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AccountGuardrailPolicyRequest(global::OpenRouter.ModelAvailabilityAccountGuardrailPolicyRequest value) => new AccountGuardrailPolicyRequest((global::OpenRouter.ModelAvailabilityAccountGuardrailPolicyRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ModelAvailabilityAccountGuardrailPolicyRequest?(AccountGuardrailPolicyRequest @this) => @this.ModelAvailability;

        /// <summary>
        ///
        /// </summary>
        public AccountGuardrailPolicyRequest(global::OpenRouter.ModelAvailabilityAccountGuardrailPolicyRequest? value)
        {
            ModelAvailability = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AccountGuardrailPolicyRequest FromModelAvailability(global::OpenRouter.ModelAvailabilityAccountGuardrailPolicyRequest? value) => new AccountGuardrailPolicyRequest(value);

        /// <summary>
        ///
        /// </summary>
        public AccountGuardrailPolicyRequest(
            global::OpenRouter.AccountGuardrailPolicyRequestDiscriminatorPolicyType? policyType,
            global::OpenRouter.BudgetAccountGuardrailPolicyRequest? budget,
            global::OpenRouter.ModerationAccountGuardrailPolicyRequest? moderation,
            global::OpenRouter.ModelAvailabilityAccountGuardrailPolicyRequest? modelAvailability
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
            global::System.Func<global::OpenRouter.BudgetAccountGuardrailPolicyRequest, TResult>? budget = null,
            global::System.Func<global::OpenRouter.ModerationAccountGuardrailPolicyRequest, TResult>? moderation = null,
            global::System.Func<global::OpenRouter.ModelAvailabilityAccountGuardrailPolicyRequest, TResult>? modelAvailability = null,
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
            global::System.Action<global::OpenRouter.BudgetAccountGuardrailPolicyRequest>? budget = null,

            global::System.Action<global::OpenRouter.ModerationAccountGuardrailPolicyRequest>? moderation = null,

            global::System.Action<global::OpenRouter.ModelAvailabilityAccountGuardrailPolicyRequest>? modelAvailability = null,
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
            global::System.Action<global::OpenRouter.BudgetAccountGuardrailPolicyRequest>? budget = null,
            global::System.Action<global::OpenRouter.ModerationAccountGuardrailPolicyRequest>? moderation = null,
            global::System.Action<global::OpenRouter.ModelAvailabilityAccountGuardrailPolicyRequest>? modelAvailability = null,
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
                typeof(global::OpenRouter.BudgetAccountGuardrailPolicyRequest),
                Moderation,
                typeof(global::OpenRouter.ModerationAccountGuardrailPolicyRequest),
                ModelAvailability,
                typeof(global::OpenRouter.ModelAvailabilityAccountGuardrailPolicyRequest),
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
        public bool Equals(AccountGuardrailPolicyRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BudgetAccountGuardrailPolicyRequest?>.Default.Equals(Budget, other.Budget) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ModerationAccountGuardrailPolicyRequest?>.Default.Equals(Moderation, other.Moderation) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ModelAvailabilityAccountGuardrailPolicyRequest?>.Default.Equals(ModelAvailability, other.ModelAvailability)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AccountGuardrailPolicyRequest obj1, AccountGuardrailPolicyRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AccountGuardrailPolicyRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AccountGuardrailPolicyRequest obj1, AccountGuardrailPolicyRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AccountGuardrailPolicyRequest o && Equals(o);
        }
    }
}
