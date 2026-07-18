#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items : global::System.IEquatable<AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1 { get; init; }
#else
        public string? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1))]
#endif
        public bool IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1 => AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1;
            return IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1() => IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1
            ? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2 { get; init; }
#else
        public double? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2))]
#endif
        public bool IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2 => AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2;
            return IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public double PickAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2() => IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2
            ? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items(string value) => new AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items @this) => @this.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1;

        /// <summary>
        /// 
        /// </summary>
        public AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items(string? value)
        {
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items FromAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1(string? value) => new AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items(double value) => new AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items @this) => @this.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items(double? value)
        {
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items FromAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2(double? value) => new AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items(value);

        /// <summary>
        /// 
        /// </summary>
        public AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items(
            string? analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1,
            double? analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2
            )
        {
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1 = analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1;
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2 = analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2 as object ??
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1?.ToString() ??
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1 && !IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2 || !IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1 && IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1 = null,
            global::System.Func<double?, TResult>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1 && analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1 != null)
            {
                return analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1!);
            }
            else if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2 && analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2 != null)
            {
                return analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1 = null,

            global::System.Action<double?>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1)
            {
                analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1?.Invoke(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1!);
            }
            else if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2)
            {
                analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2?.Invoke(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1 = null,
            global::System.Action<double?>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1)
            {
                analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1?.Invoke(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1!);
            }
            else if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2)
            {
                analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2?.Invoke(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1,
                typeof(string),
                AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2,
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
        public bool Equals(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1, other.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2, other.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2ItemsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items obj1, AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items obj1, AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items o && Equals(o);
        }
    }
}
