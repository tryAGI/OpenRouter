#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct RequestCapacityEntryV2 : global::System.IEquatable<RequestCapacityEntryV2>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.RequestCapacityEntryV2Variant1? RequestCapacityEntryV2Variant1 { get; init; }
#else
        public global::OpenRouter.RequestCapacityEntryV2Variant1? RequestCapacityEntryV2Variant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequestCapacityEntryV2Variant1))]
#endif
        public bool IsRequestCapacityEntryV2Variant1 => RequestCapacityEntryV2Variant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRequestCapacityEntryV2Variant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.RequestCapacityEntryV2Variant1? value)
        {
            value = RequestCapacityEntryV2Variant1;
            return IsRequestCapacityEntryV2Variant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RequestCapacityEntryV2Variant1 PickRequestCapacityEntryV2Variant1() => RequestCapacityEntryV2Variant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RequestCapacityEntryV2Variant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.RequestCapacityEntryV2Variant2? RequestCapacityEntryV2Variant2 { get; init; }
#else
        public global::OpenRouter.RequestCapacityEntryV2Variant2? RequestCapacityEntryV2Variant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequestCapacityEntryV2Variant2))]
#endif
        public bool IsRequestCapacityEntryV2Variant2 => RequestCapacityEntryV2Variant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRequestCapacityEntryV2Variant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.RequestCapacityEntryV2Variant2? value)
        {
            value = RequestCapacityEntryV2Variant2;
            return IsRequestCapacityEntryV2Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RequestCapacityEntryV2Variant2 PickRequestCapacityEntryV2Variant2() => RequestCapacityEntryV2Variant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RequestCapacityEntryV2Variant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.RequestCapacityEntryV2Variant3? RequestCapacityEntryV2Variant3 { get; init; }
#else
        public global::OpenRouter.RequestCapacityEntryV2Variant3? RequestCapacityEntryV2Variant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RequestCapacityEntryV2Variant3))]
#endif
        public bool IsRequestCapacityEntryV2Variant3 => RequestCapacityEntryV2Variant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRequestCapacityEntryV2Variant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.RequestCapacityEntryV2Variant3? value)
        {
            value = RequestCapacityEntryV2Variant3;
            return IsRequestCapacityEntryV2Variant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.RequestCapacityEntryV2Variant3 PickRequestCapacityEntryV2Variant3() => RequestCapacityEntryV2Variant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RequestCapacityEntryV2Variant3' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator RequestCapacityEntryV2(global::OpenRouter.RequestCapacityEntryV2Variant1 value) => new RequestCapacityEntryV2((global::OpenRouter.RequestCapacityEntryV2Variant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.RequestCapacityEntryV2Variant1?(RequestCapacityEntryV2 @this) => @this.RequestCapacityEntryV2Variant1;

        /// <summary>
        ///
        /// </summary>
        public RequestCapacityEntryV2(global::OpenRouter.RequestCapacityEntryV2Variant1? value)
        {
            RequestCapacityEntryV2Variant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RequestCapacityEntryV2 FromRequestCapacityEntryV2Variant1(global::OpenRouter.RequestCapacityEntryV2Variant1? value) => new RequestCapacityEntryV2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RequestCapacityEntryV2(global::OpenRouter.RequestCapacityEntryV2Variant2 value) => new RequestCapacityEntryV2((global::OpenRouter.RequestCapacityEntryV2Variant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.RequestCapacityEntryV2Variant2?(RequestCapacityEntryV2 @this) => @this.RequestCapacityEntryV2Variant2;

        /// <summary>
        ///
        /// </summary>
        public RequestCapacityEntryV2(global::OpenRouter.RequestCapacityEntryV2Variant2? value)
        {
            RequestCapacityEntryV2Variant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RequestCapacityEntryV2 FromRequestCapacityEntryV2Variant2(global::OpenRouter.RequestCapacityEntryV2Variant2? value) => new RequestCapacityEntryV2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RequestCapacityEntryV2(global::OpenRouter.RequestCapacityEntryV2Variant3 value) => new RequestCapacityEntryV2((global::OpenRouter.RequestCapacityEntryV2Variant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.RequestCapacityEntryV2Variant3?(RequestCapacityEntryV2 @this) => @this.RequestCapacityEntryV2Variant3;

        /// <summary>
        ///
        /// </summary>
        public RequestCapacityEntryV2(global::OpenRouter.RequestCapacityEntryV2Variant3? value)
        {
            RequestCapacityEntryV2Variant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RequestCapacityEntryV2 FromRequestCapacityEntryV2Variant3(global::OpenRouter.RequestCapacityEntryV2Variant3? value) => new RequestCapacityEntryV2(value);

        /// <summary>
        ///
        /// </summary>
        public RequestCapacityEntryV2(
            global::OpenRouter.RequestCapacityEntryV2Variant1? requestCapacityEntryV2Variant1,
            global::OpenRouter.RequestCapacityEntryV2Variant2? requestCapacityEntryV2Variant2,
            global::OpenRouter.RequestCapacityEntryV2Variant3? requestCapacityEntryV2Variant3
            )
        {
            RequestCapacityEntryV2Variant1 = requestCapacityEntryV2Variant1;
            RequestCapacityEntryV2Variant2 = requestCapacityEntryV2Variant2;
            RequestCapacityEntryV2Variant3 = requestCapacityEntryV2Variant3;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RequestCapacityEntryV2Variant3 as object ??
            RequestCapacityEntryV2Variant2 as object ??
            RequestCapacityEntryV2Variant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            RequestCapacityEntryV2Variant1?.ToString() ??
            RequestCapacityEntryV2Variant2?.ToString() ??
            RequestCapacityEntryV2Variant3?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRequestCapacityEntryV2Variant1 || IsRequestCapacityEntryV2Variant2 || IsRequestCapacityEntryV2Variant3;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.RequestCapacityEntryV2Variant1, TResult>? requestCapacityEntryV2Variant1 = null,
            global::System.Func<global::OpenRouter.RequestCapacityEntryV2Variant2, TResult>? requestCapacityEntryV2Variant2 = null,
            global::System.Func<global::OpenRouter.RequestCapacityEntryV2Variant3, TResult>? requestCapacityEntryV2Variant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RequestCapacityEntryV2Variant1 is { } __value0 && requestCapacityEntryV2Variant1 != null)
            {
                return requestCapacityEntryV2Variant1(__value0);
            }
            else if (RequestCapacityEntryV2Variant2 is { } __value1 && requestCapacityEntryV2Variant2 != null)
            {
                return requestCapacityEntryV2Variant2(__value1);
            }
            else if (RequestCapacityEntryV2Variant3 is { } __value2 && requestCapacityEntryV2Variant3 != null)
            {
                return requestCapacityEntryV2Variant3(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.RequestCapacityEntryV2Variant1>? requestCapacityEntryV2Variant1 = null,

            global::System.Action<global::OpenRouter.RequestCapacityEntryV2Variant2>? requestCapacityEntryV2Variant2 = null,

            global::System.Action<global::OpenRouter.RequestCapacityEntryV2Variant3>? requestCapacityEntryV2Variant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RequestCapacityEntryV2Variant1 is { } __value0)
            {
                requestCapacityEntryV2Variant1?.Invoke(__value0);
            }
            else if (RequestCapacityEntryV2Variant2 is { } __value1)
            {
                requestCapacityEntryV2Variant2?.Invoke(__value1);
            }
            else if (RequestCapacityEntryV2Variant3 is { } __value2)
            {
                requestCapacityEntryV2Variant3?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.RequestCapacityEntryV2Variant1>? requestCapacityEntryV2Variant1 = null,
            global::System.Action<global::OpenRouter.RequestCapacityEntryV2Variant2>? requestCapacityEntryV2Variant2 = null,
            global::System.Action<global::OpenRouter.RequestCapacityEntryV2Variant3>? requestCapacityEntryV2Variant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RequestCapacityEntryV2Variant1 is { } __value0)
            {
                requestCapacityEntryV2Variant1?.Invoke(__value0);
            }
            else if (RequestCapacityEntryV2Variant2 is { } __value1)
            {
                requestCapacityEntryV2Variant2?.Invoke(__value1);
            }
            else if (RequestCapacityEntryV2Variant3 is { } __value2)
            {
                requestCapacityEntryV2Variant3?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RequestCapacityEntryV2Variant1,
                typeof(global::OpenRouter.RequestCapacityEntryV2Variant1),
                RequestCapacityEntryV2Variant2,
                typeof(global::OpenRouter.RequestCapacityEntryV2Variant2),
                RequestCapacityEntryV2Variant3,
                typeof(global::OpenRouter.RequestCapacityEntryV2Variant3),
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
        public bool Equals(RequestCapacityEntryV2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.RequestCapacityEntryV2Variant1?>.Default.Equals(RequestCapacityEntryV2Variant1, other.RequestCapacityEntryV2Variant1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.RequestCapacityEntryV2Variant2?>.Default.Equals(RequestCapacityEntryV2Variant2, other.RequestCapacityEntryV2Variant2) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.RequestCapacityEntryV2Variant3?>.Default.Equals(RequestCapacityEntryV2Variant3, other.RequestCapacityEntryV2Variant3)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(RequestCapacityEntryV2 obj1, RequestCapacityEntryV2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RequestCapacityEntryV2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(RequestCapacityEntryV2 obj1, RequestCapacityEntryV2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RequestCapacityEntryV2 o && Equals(o);
        }
    }
}
