#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Filter value. Use a scalar (string or number) for eq/neq, or an array for in/not_in.
    /// </summary>
    public readonly partial struct AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue : global::System.IEquatable<AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1 { get; init; }
#else
        public string? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1))]
#endif
        public bool IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1 => AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1;
            return IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1() => IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1
            ? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2 { get; init; }
#else
        public double? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2))]
#endif
        public bool IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2 => AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2;
            return IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public double PickAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2() => IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2
            ? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items>? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items>? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2))]
#endif
        public bool IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2 => AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items>? value)
        {
            value = AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2;
            return IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items> PickAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2() => IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2
            ? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue(string value) => new AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue @this) => @this.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1;

        /// <summary>
        /// 
        /// </summary>
        public AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue(string? value)
        {
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue FromAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1(string? value) => new AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue(double value) => new AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue @this) => @this.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2;

        /// <summary>
        /// 
        /// </summary>
        public AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue(double? value)
        {
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue FromAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2(double? value) => new AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue(value);

        /// <summary>
        /// 
        /// </summary>
        public AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue(
            string? analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1,
            double? analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2,
            global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2
            )
        {
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1 = analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1;
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2 = analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2;
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2 = analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2 as object ??
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2 as object ??
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1?.ToString() ??
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2?.ToString() ??
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1 && !IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2 && !IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2 || !IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1 && IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2 && !IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2 || !IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1 && !IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2 && IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1 = null,
            global::System.Func<double?, TResult>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items>, TResult>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1 && analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1 != null)
            {
                return analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1!);
            }
            else if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2 && analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2 != null)
            {
                return analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2!);
            }
            else if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2 && analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2 != null)
            {
                return analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1 = null,

            global::System.Action<double?>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items>>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1)
            {
                analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1?.Invoke(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1!);
            }
            else if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2)
            {
                analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2?.Invoke(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2!);
            }
            else if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2)
            {
                analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2?.Invoke(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1 = null,
            global::System.Action<double?>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items>>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1)
            {
                analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1?.Invoke(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1!);
            }
            else if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2)
            {
                analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2?.Invoke(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2!);
            }
            else if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2)
            {
                analyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2?.Invoke(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1,
                typeof(string),
                AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2,
                typeof(double),
                AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2,
                typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items>),
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
        public bool Equals(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1, other.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2, other.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValueOneOf2Items>?>.Default.Equals(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2, other.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue obj1, AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue obj1, AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaClassifierFiltersFiltersItemsValue o && Equals(o);
        }
    }
}
