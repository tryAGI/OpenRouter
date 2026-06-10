#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items : global::System.IEquatable<AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1 { get; init; }
#else
        public string? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1))]
#endif
        public bool IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1 => AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1;
            return IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1() => IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1
            ? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2 { get; init; }
#else
        public double? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2))]
#endif
        public bool IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2 => AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2;
            return IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public double PickAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2() => IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2
            ? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items(string value) => new AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items @this) => @this.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1;

        /// <summary>
        /// 
        /// </summary>
        public AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items(string? value)
        {
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items FromAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1(string? value) => new AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items(double value) => new AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items @this) => @this.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items(double? value)
        {
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items FromAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2(double? value) => new AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items(value);

        /// <summary>
        /// 
        /// </summary>
        public AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items(
            string? analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1,
            double? analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2
            )
        {
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1 = analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1;
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2 = analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2 as object ??
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1?.ToString() ??
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1 && !IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2 || !IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1 && IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1 = null,
            global::System.Func<double?, TResult>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1 && analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1 != null)
            {
                return analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1!);
            }
            else if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2 && analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2 != null)
            {
                return analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1 = null,

            global::System.Action<double?>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1)
            {
                analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1?.Invoke(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1!);
            }
            else if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2)
            {
                analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2?.Invoke(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1 = null,
            global::System.Action<double?>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1)
            {
                analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1?.Invoke(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1!);
            }
            else if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2)
            {
                analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2?.Invoke(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1,
                typeof(string),
                AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2,
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
        public bool Equals(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1, other.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2, other.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2ItemsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items obj1, AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items obj1, AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items o && Equals(o);
        }
    }
}
