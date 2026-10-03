#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct RequestPricingEntryV2 : global::System.IEquatable<RequestPricingEntryV2>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.RequestPricingEntryV2Variant1? RequestPricingEntryV2Variant1 { get; init; }
#else
        public global::OpenRouter.RequestPricingEntryV2Variant1? RequestPricingEntryV2Variant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequestPricingEntryV2Variant1))]
#endif
        public bool IsRequestPricingEntryV2Variant1 => RequestPricingEntryV2Variant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRequestPricingEntryV2Variant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.RequestPricingEntryV2Variant1? value)
        {
            value = RequestPricingEntryV2Variant1;
            return IsRequestPricingEntryV2Variant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RequestPricingEntryV2Variant1 PickRequestPricingEntryV2Variant1() => RequestPricingEntryV2Variant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RequestPricingEntryV2Variant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.RequestPricingEntryV2Variant2? RequestPricingEntryV2Variant2 { get; init; }
#else
        public global::OpenRouter.RequestPricingEntryV2Variant2? RequestPricingEntryV2Variant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequestPricingEntryV2Variant2))]
#endif
        public bool IsRequestPricingEntryV2Variant2 => RequestPricingEntryV2Variant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRequestPricingEntryV2Variant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.RequestPricingEntryV2Variant2? value)
        {
            value = RequestPricingEntryV2Variant2;
            return IsRequestPricingEntryV2Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RequestPricingEntryV2Variant2 PickRequestPricingEntryV2Variant2() => RequestPricingEntryV2Variant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RequestPricingEntryV2Variant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator RequestPricingEntryV2(global::OpenRouter.RequestPricingEntryV2Variant1 value) => new RequestPricingEntryV2((global::OpenRouter.RequestPricingEntryV2Variant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.RequestPricingEntryV2Variant1?(RequestPricingEntryV2 @this) => @this.RequestPricingEntryV2Variant1;

        /// <summary>
        ///
        /// </summary>
        public RequestPricingEntryV2(global::OpenRouter.RequestPricingEntryV2Variant1? value)
        {
            RequestPricingEntryV2Variant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RequestPricingEntryV2 FromRequestPricingEntryV2Variant1(global::OpenRouter.RequestPricingEntryV2Variant1? value) => new RequestPricingEntryV2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RequestPricingEntryV2(global::OpenRouter.RequestPricingEntryV2Variant2 value) => new RequestPricingEntryV2((global::OpenRouter.RequestPricingEntryV2Variant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.RequestPricingEntryV2Variant2?(RequestPricingEntryV2 @this) => @this.RequestPricingEntryV2Variant2;

        /// <summary>
        ///
        /// </summary>
        public RequestPricingEntryV2(global::OpenRouter.RequestPricingEntryV2Variant2? value)
        {
            RequestPricingEntryV2Variant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RequestPricingEntryV2 FromRequestPricingEntryV2Variant2(global::OpenRouter.RequestPricingEntryV2Variant2? value) => new RequestPricingEntryV2(value);

        /// <summary>
        ///
        /// </summary>
        public RequestPricingEntryV2(
            global::OpenRouter.RequestPricingEntryV2Variant1? requestPricingEntryV2Variant1,
            global::OpenRouter.RequestPricingEntryV2Variant2? requestPricingEntryV2Variant2
            )
        {
            RequestPricingEntryV2Variant1 = requestPricingEntryV2Variant1;
            RequestPricingEntryV2Variant2 = requestPricingEntryV2Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RequestPricingEntryV2Variant2 as object ??
            RequestPricingEntryV2Variant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            RequestPricingEntryV2Variant1?.ToString() ??
            RequestPricingEntryV2Variant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRequestPricingEntryV2Variant1 && !IsRequestPricingEntryV2Variant2 || !IsRequestPricingEntryV2Variant1 && IsRequestPricingEntryV2Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.RequestPricingEntryV2Variant1, TResult>? requestPricingEntryV2Variant1 = null,
            global::System.Func<global::OpenRouter.RequestPricingEntryV2Variant2, TResult>? requestPricingEntryV2Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RequestPricingEntryV2Variant1 is { } __value0 && requestPricingEntryV2Variant1 != null)
            {
                return requestPricingEntryV2Variant1(__value0);
            }
            else if (RequestPricingEntryV2Variant2 is { } __value1 && requestPricingEntryV2Variant2 != null)
            {
                return requestPricingEntryV2Variant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.RequestPricingEntryV2Variant1>? requestPricingEntryV2Variant1 = null,

            global::System.Action<global::OpenRouter.RequestPricingEntryV2Variant2>? requestPricingEntryV2Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RequestPricingEntryV2Variant1 is { } __value0)
            {
                requestPricingEntryV2Variant1?.Invoke(__value0);
            }
            else if (RequestPricingEntryV2Variant2 is { } __value1)
            {
                requestPricingEntryV2Variant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.RequestPricingEntryV2Variant1>? requestPricingEntryV2Variant1 = null,
            global::System.Action<global::OpenRouter.RequestPricingEntryV2Variant2>? requestPricingEntryV2Variant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RequestPricingEntryV2Variant1 is { } __value0)
            {
                requestPricingEntryV2Variant1?.Invoke(__value0);
            }
            else if (RequestPricingEntryV2Variant2 is { } __value1)
            {
                requestPricingEntryV2Variant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RequestPricingEntryV2Variant1,
                typeof(global::OpenRouter.RequestPricingEntryV2Variant1),
                RequestPricingEntryV2Variant2,
                typeof(global::OpenRouter.RequestPricingEntryV2Variant2),
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
        public bool Equals(RequestPricingEntryV2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.RequestPricingEntryV2Variant1?>.Default.Equals(RequestPricingEntryV2Variant1, other.RequestPricingEntryV2Variant1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.RequestPricingEntryV2Variant2?>.Default.Equals(RequestPricingEntryV2Variant2, other.RequestPricingEntryV2Variant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(RequestPricingEntryV2 obj1, RequestPricingEntryV2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RequestPricingEntryV2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(RequestPricingEntryV2 obj1, RequestPricingEntryV2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RequestPricingEntryV2 o && Equals(o);
        }
    }
}
