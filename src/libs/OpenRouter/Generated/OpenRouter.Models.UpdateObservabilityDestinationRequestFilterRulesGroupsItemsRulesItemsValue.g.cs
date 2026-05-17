#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValue : global::System.IEquatable<UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValue>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1 { get; init; }
#else
        public string? UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1))]
#endif
        public bool IsUpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1 => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1;
            return IsUpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickUpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1() => IsUpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1
            ? UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2 { get; init; }
#else
        public double? UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2))]
#endif
        public bool IsUpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2 => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickUpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2;
            return IsUpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public double PickUpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2() => IsUpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2
            ? UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValue(string value) => new UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValue((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValue @this) => @this.UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1;

        /// <summary>
        /// 
        /// </summary>
        public UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValue(string? value)
        {
            UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValue FromUpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1(string? value) => new UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValue(double value) => new UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValue((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValue @this) => @this.UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2;

        /// <summary>
        /// 
        /// </summary>
        public UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValue(double? value)
        {
            UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValue FromUpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2(double? value) => new UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValue(value);

        /// <summary>
        /// 
        /// </summary>
        public UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValue(
            string? updateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1,
            double? updateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2
            )
        {
            UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1 = updateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1;
            UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2 = updateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2 as object ??
            UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1?.ToString() ??
            UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1 && !IsUpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2 || !IsUpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1 && IsUpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? updateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1 = null,
            global::System.Func<double?, TResult>? updateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1 && updateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1 != null)
            {
                return updateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1(UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1!);
            }
            else if (IsUpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2 && updateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2 != null)
            {
                return updateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2(UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? updateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1 = null,

            global::System.Action<double?>? updateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1)
            {
                updateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1?.Invoke(UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1!);
            }
            else if (IsUpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2)
            {
                updateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2?.Invoke(UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? updateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1 = null,
            global::System.Action<double?>? updateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1)
            {
                updateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1?.Invoke(UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1!);
            }
            else if (IsUpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2)
            {
                updateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2?.Invoke(UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1,
                typeof(string),
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2,
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
        public bool Equals(UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1, other.UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2, other.UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValue obj1, UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValue obj1, UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValue o && Equals(o);
        }
    }
}
