#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ObservabilityFilterRuleGroupRulesItemsValue : global::System.IEquatable<ObservabilityFilterRuleGroupRulesItemsValue>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ObservabilityFilterRuleGroupRulesItemsValueVariant1 { get; init; }
#else
        public string? ObservabilityFilterRuleGroupRulesItemsValueVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ObservabilityFilterRuleGroupRulesItemsValueVariant1))]
#endif
        public bool IsObservabilityFilterRuleGroupRulesItemsValueVariant1 => ObservabilityFilterRuleGroupRulesItemsValueVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickObservabilityFilterRuleGroupRulesItemsValueVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = ObservabilityFilterRuleGroupRulesItemsValueVariant1;
            return IsObservabilityFilterRuleGroupRulesItemsValueVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickObservabilityFilterRuleGroupRulesItemsValueVariant1() => IsObservabilityFilterRuleGroupRulesItemsValueVariant1
            ? ObservabilityFilterRuleGroupRulesItemsValueVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ObservabilityFilterRuleGroupRulesItemsValueVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? ObservabilityFilterRuleGroupRulesItemsValueVariant2 { get; init; }
#else
        public double? ObservabilityFilterRuleGroupRulesItemsValueVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ObservabilityFilterRuleGroupRulesItemsValueVariant2))]
#endif
        public bool IsObservabilityFilterRuleGroupRulesItemsValueVariant2 => ObservabilityFilterRuleGroupRulesItemsValueVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickObservabilityFilterRuleGroupRulesItemsValueVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = ObservabilityFilterRuleGroupRulesItemsValueVariant2;
            return IsObservabilityFilterRuleGroupRulesItemsValueVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public double PickObservabilityFilterRuleGroupRulesItemsValueVariant2() => IsObservabilityFilterRuleGroupRulesItemsValueVariant2
            ? ObservabilityFilterRuleGroupRulesItemsValueVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ObservabilityFilterRuleGroupRulesItemsValueVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ObservabilityFilterRuleGroupRulesItemsValue(string value) => new ObservabilityFilterRuleGroupRulesItemsValue((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ObservabilityFilterRuleGroupRulesItemsValue @this) => @this.ObservabilityFilterRuleGroupRulesItemsValueVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ObservabilityFilterRuleGroupRulesItemsValue(string? value)
        {
            ObservabilityFilterRuleGroupRulesItemsValueVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ObservabilityFilterRuleGroupRulesItemsValue FromObservabilityFilterRuleGroupRulesItemsValueVariant1(string? value) => new ObservabilityFilterRuleGroupRulesItemsValue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ObservabilityFilterRuleGroupRulesItemsValue(double value) => new ObservabilityFilterRuleGroupRulesItemsValue((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(ObservabilityFilterRuleGroupRulesItemsValue @this) => @this.ObservabilityFilterRuleGroupRulesItemsValueVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ObservabilityFilterRuleGroupRulesItemsValue(double? value)
        {
            ObservabilityFilterRuleGroupRulesItemsValueVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ObservabilityFilterRuleGroupRulesItemsValue FromObservabilityFilterRuleGroupRulesItemsValueVariant2(double? value) => new ObservabilityFilterRuleGroupRulesItemsValue(value);

        /// <summary>
        /// 
        /// </summary>
        public ObservabilityFilterRuleGroupRulesItemsValue(
            string? observabilityFilterRuleGroupRulesItemsValueVariant1,
            double? observabilityFilterRuleGroupRulesItemsValueVariant2
            )
        {
            ObservabilityFilterRuleGroupRulesItemsValueVariant1 = observabilityFilterRuleGroupRulesItemsValueVariant1;
            ObservabilityFilterRuleGroupRulesItemsValueVariant2 = observabilityFilterRuleGroupRulesItemsValueVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ObservabilityFilterRuleGroupRulesItemsValueVariant2 as object ??
            ObservabilityFilterRuleGroupRulesItemsValueVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ObservabilityFilterRuleGroupRulesItemsValueVariant1?.ToString() ??
            ObservabilityFilterRuleGroupRulesItemsValueVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsObservabilityFilterRuleGroupRulesItemsValueVariant1 && !IsObservabilityFilterRuleGroupRulesItemsValueVariant2 || !IsObservabilityFilterRuleGroupRulesItemsValueVariant1 && IsObservabilityFilterRuleGroupRulesItemsValueVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? observabilityFilterRuleGroupRulesItemsValueVariant1 = null,
            global::System.Func<double?, TResult>? observabilityFilterRuleGroupRulesItemsValueVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsObservabilityFilterRuleGroupRulesItemsValueVariant1 && observabilityFilterRuleGroupRulesItemsValueVariant1 != null)
            {
                return observabilityFilterRuleGroupRulesItemsValueVariant1(ObservabilityFilterRuleGroupRulesItemsValueVariant1!);
            }
            else if (IsObservabilityFilterRuleGroupRulesItemsValueVariant2 && observabilityFilterRuleGroupRulesItemsValueVariant2 != null)
            {
                return observabilityFilterRuleGroupRulesItemsValueVariant2(ObservabilityFilterRuleGroupRulesItemsValueVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? observabilityFilterRuleGroupRulesItemsValueVariant1 = null,

            global::System.Action<double?>? observabilityFilterRuleGroupRulesItemsValueVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsObservabilityFilterRuleGroupRulesItemsValueVariant1)
            {
                observabilityFilterRuleGroupRulesItemsValueVariant1?.Invoke(ObservabilityFilterRuleGroupRulesItemsValueVariant1!);
            }
            else if (IsObservabilityFilterRuleGroupRulesItemsValueVariant2)
            {
                observabilityFilterRuleGroupRulesItemsValueVariant2?.Invoke(ObservabilityFilterRuleGroupRulesItemsValueVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? observabilityFilterRuleGroupRulesItemsValueVariant1 = null,
            global::System.Action<double?>? observabilityFilterRuleGroupRulesItemsValueVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsObservabilityFilterRuleGroupRulesItemsValueVariant1)
            {
                observabilityFilterRuleGroupRulesItemsValueVariant1?.Invoke(ObservabilityFilterRuleGroupRulesItemsValueVariant1!);
            }
            else if (IsObservabilityFilterRuleGroupRulesItemsValueVariant2)
            {
                observabilityFilterRuleGroupRulesItemsValueVariant2?.Invoke(ObservabilityFilterRuleGroupRulesItemsValueVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ObservabilityFilterRuleGroupRulesItemsValueVariant1,
                typeof(string),
                ObservabilityFilterRuleGroupRulesItemsValueVariant2,
                typeof(double),
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
        public bool Equals(ObservabilityFilterRuleGroupRulesItemsValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ObservabilityFilterRuleGroupRulesItemsValueVariant1, other.ObservabilityFilterRuleGroupRulesItemsValueVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(ObservabilityFilterRuleGroupRulesItemsValueVariant2, other.ObservabilityFilterRuleGroupRulesItemsValueVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ObservabilityFilterRuleGroupRulesItemsValue obj1, ObservabilityFilterRuleGroupRulesItemsValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ObservabilityFilterRuleGroupRulesItemsValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ObservabilityFilterRuleGroupRulesItemsValue obj1, ObservabilityFilterRuleGroupRulesItemsValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ObservabilityFilterRuleGroupRulesItemsValue o && Equals(o);
        }
    }
}
