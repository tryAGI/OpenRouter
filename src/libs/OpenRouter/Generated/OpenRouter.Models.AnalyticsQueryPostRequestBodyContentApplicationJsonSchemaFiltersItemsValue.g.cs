#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Filter value (scalar or array depending on operator). Several dimensions are enriched in responses (returned as human-readable labels), but filters must use the underlying ID: `api_key_id` — numeric ID (from generation metadata) or key hash (64-char hex from GET /api/v1/keys, resolved server-side); `user` — Clerk user ID (e.g. "user_abc123"), not the display name; `workspace` — workspace UUID, not the workspace name; `app` — numeric app ID, not the app title; `model` — permaslug (e.g. "openai/gpt-4o"), not the display name. Other dimensions (provider, origin, country, etc.) are not enriched and accept the value as returned.
    /// </summary>
    public readonly partial struct AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue : global::System.IEquatable<AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1 { get; init; }
#else
        public string? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1))]
#endif
        public bool IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1 => AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1;
            return IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1() => IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1
            ? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2 { get; init; }
#else
        public double? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2))]
#endif
        public bool IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2 => AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2;
            return IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public double PickAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2() => IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2
            ? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items>? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items>? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2))]
#endif
        public bool IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2 => AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items>? value)
        {
            value = AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2;
            return IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items> PickAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2() => IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2
            ? AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue(string value) => new AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue @this) => @this.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1;

        /// <summary>
        /// 
        /// </summary>
        public AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue(string? value)
        {
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue FromAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1(string? value) => new AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue(double value) => new AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue @this) => @this.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2;

        /// <summary>
        /// 
        /// </summary>
        public AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue(double? value)
        {
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue FromAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2(double? value) => new AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue(value);

        /// <summary>
        /// 
        /// </summary>
        public AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue(
            string? analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1,
            double? analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2,
            global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2
            )
        {
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1 = analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1;
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2 = analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2;
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2 = analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2 as object ??
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2 as object ??
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1?.ToString() ??
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2?.ToString() ??
            AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1 && !IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2 && !IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2 || !IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1 && IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2 && !IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2 || !IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1 && !IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2 && IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1 = null,
            global::System.Func<double?, TResult>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items>, TResult>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1 && analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1 != null)
            {
                return analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1!);
            }
            else if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2 && analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2 != null)
            {
                return analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2!);
            }
            else if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2 && analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2 != null)
            {
                return analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1 = null,

            global::System.Action<double?>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items>>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1)
            {
                analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1?.Invoke(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1!);
            }
            else if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2)
            {
                analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2?.Invoke(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2!);
            }
            else if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2)
            {
                analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2?.Invoke(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1 = null,
            global::System.Action<double?>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items>>? analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1)
            {
                analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1?.Invoke(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1!);
            }
            else if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2)
            {
                analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2?.Invoke(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2!);
            }
            else if (IsAnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2)
            {
                analyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2?.Invoke(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1,
                typeof(string),
                AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2,
                typeof(double),
                AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2,
                typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items>),
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
        public bool Equals(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1, other.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2, other.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValueOneOf2Items>?>.Default.Equals(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2, other.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue obj1, AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue obj1, AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItemsValue o && Equals(o);
        }
    }
}
