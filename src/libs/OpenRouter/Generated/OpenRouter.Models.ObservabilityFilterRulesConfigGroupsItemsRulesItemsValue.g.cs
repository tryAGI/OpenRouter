#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ObservabilityFilterRulesConfigGroupsItemsRulesItemsValue : global::System.IEquatable<ObservabilityFilterRulesConfigGroupsItemsRulesItemsValue>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1 { get; init; }
#else
        public string? ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1))]
#endif
        public bool IsObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1 => ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1;
            return IsObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1() => IsObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1
            ? ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2 { get; init; }
#else
        public double? ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2))]
#endif
        public bool IsObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2 => ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2;
            return IsObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public double PickObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2() => IsObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2
            ? ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ObservabilityFilterRulesConfigGroupsItemsRulesItemsValue(string value) => new ObservabilityFilterRulesConfigGroupsItemsRulesItemsValue((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ObservabilityFilterRulesConfigGroupsItemsRulesItemsValue @this) => @this.ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ObservabilityFilterRulesConfigGroupsItemsRulesItemsValue(string? value)
        {
            ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ObservabilityFilterRulesConfigGroupsItemsRulesItemsValue FromObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1(string? value) => new ObservabilityFilterRulesConfigGroupsItemsRulesItemsValue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ObservabilityFilterRulesConfigGroupsItemsRulesItemsValue(double value) => new ObservabilityFilterRulesConfigGroupsItemsRulesItemsValue((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(ObservabilityFilterRulesConfigGroupsItemsRulesItemsValue @this) => @this.ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ObservabilityFilterRulesConfigGroupsItemsRulesItemsValue(double? value)
        {
            ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ObservabilityFilterRulesConfigGroupsItemsRulesItemsValue FromObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2(double? value) => new ObservabilityFilterRulesConfigGroupsItemsRulesItemsValue(value);

        /// <summary>
        /// 
        /// </summary>
        public ObservabilityFilterRulesConfigGroupsItemsRulesItemsValue(
            string? observabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1,
            double? observabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2
            )
        {
            ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1 = observabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1;
            ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2 = observabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2 as object ??
            ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1?.ToString() ??
            ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1 && !IsObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2 || !IsObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1 && IsObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? observabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1 = null,
            global::System.Func<double?, TResult>? observabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1 && observabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1 != null)
            {
                return observabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1(ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1!);
            }
            else if (IsObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2 && observabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2 != null)
            {
                return observabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2(ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? observabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1 = null,

            global::System.Action<double?>? observabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1)
            {
                observabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1?.Invoke(ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1!);
            }
            else if (IsObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2)
            {
                observabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2?.Invoke(ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? observabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1 = null,
            global::System.Action<double?>? observabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1)
            {
                observabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1?.Invoke(ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1!);
            }
            else if (IsObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2)
            {
                observabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2?.Invoke(ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1,
                typeof(string),
                ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2,
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
        public bool Equals(ObservabilityFilterRulesConfigGroupsItemsRulesItemsValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1, other.ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2, other.ObservabilityFilterRulesConfigGroupsItemsRulesItemsValueVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ObservabilityFilterRulesConfigGroupsItemsRulesItemsValue obj1, ObservabilityFilterRulesConfigGroupsItemsRulesItemsValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ObservabilityFilterRulesConfigGroupsItemsRulesItemsValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ObservabilityFilterRulesConfigGroupsItemsRulesItemsValue obj1, ObservabilityFilterRulesConfigGroupsItemsRulesItemsValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ObservabilityFilterRulesConfigGroupsItemsRulesItemsValue o && Equals(o);
        }
    }
}
