#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Either a parameter predicate (a map of request parameter name to pricing condition) or a composition predicate (`allOf`, `anyOf`, `not`). Recursive; the full JSON Schema is in the Models API V2 schema asset.
    /// </summary>
    public readonly partial struct PricingPredicateV2 : global::System.IEquatable<PricingPredicateV2>
    {
        /// <summary>
        /// Parameter predicate: request parameter name to pricing condition
        /// </summary>
#if NET6_0_OR_GREATER
        public object? PricingPredicateV2Variant1 { get; init; }
#else
        public object? PricingPredicateV2Variant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PricingPredicateV2Variant1))]
#endif
        public bool IsPricingPredicateV2Variant1 => PricingPredicateV2Variant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPricingPredicateV2Variant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = PricingPredicateV2Variant1;
            return IsPricingPredicateV2Variant1;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickPricingPredicateV2Variant1() => PricingPredicateV2Variant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PricingPredicateV2Variant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.PricingPredicateV2Variant2? PricingPredicateV2Variant2 { get; init; }
#else
        public global::OpenRouter.PricingPredicateV2Variant2? PricingPredicateV2Variant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PricingPredicateV2Variant2))]
#endif
        public bool IsPricingPredicateV2Variant2 => PricingPredicateV2Variant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPricingPredicateV2Variant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.PricingPredicateV2Variant2? value)
        {
            value = PricingPredicateV2Variant2;
            return IsPricingPredicateV2Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PricingPredicateV2Variant2 PickPricingPredicateV2Variant2() => PricingPredicateV2Variant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PricingPredicateV2Variant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.PricingPredicateV2Variant3? PricingPredicateV2Variant3 { get; init; }
#else
        public global::OpenRouter.PricingPredicateV2Variant3? PricingPredicateV2Variant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PricingPredicateV2Variant3))]
#endif
        public bool IsPricingPredicateV2Variant3 => PricingPredicateV2Variant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPricingPredicateV2Variant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.PricingPredicateV2Variant3? value)
        {
            value = PricingPredicateV2Variant3;
            return IsPricingPredicateV2Variant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PricingPredicateV2Variant3 PickPricingPredicateV2Variant3() => PricingPredicateV2Variant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PricingPredicateV2Variant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.PricingPredicateV2Variant4? PricingPredicateV2Variant4 { get; init; }
#else
        public global::OpenRouter.PricingPredicateV2Variant4? PricingPredicateV2Variant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PricingPredicateV2Variant4))]
#endif
        public bool IsPricingPredicateV2Variant4 => PricingPredicateV2Variant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPricingPredicateV2Variant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.PricingPredicateV2Variant4? value)
        {
            value = PricingPredicateV2Variant4;
            return IsPricingPredicateV2Variant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PricingPredicateV2Variant4 PickPricingPredicateV2Variant4() => PricingPredicateV2Variant4 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PricingPredicateV2Variant4' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PricingPredicateV2(global::OpenRouter.PricingPredicateV2Variant2 value) => new PricingPredicateV2((global::OpenRouter.PricingPredicateV2Variant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.PricingPredicateV2Variant2?(PricingPredicateV2 @this) => @this.PricingPredicateV2Variant2;

        /// <summary>
        ///
        /// </summary>
        public PricingPredicateV2(global::OpenRouter.PricingPredicateV2Variant2? value)
        {
            PricingPredicateV2Variant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PricingPredicateV2 FromPricingPredicateV2Variant2(global::OpenRouter.PricingPredicateV2Variant2? value) => new PricingPredicateV2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PricingPredicateV2(global::OpenRouter.PricingPredicateV2Variant3 value) => new PricingPredicateV2((global::OpenRouter.PricingPredicateV2Variant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.PricingPredicateV2Variant3?(PricingPredicateV2 @this) => @this.PricingPredicateV2Variant3;

        /// <summary>
        ///
        /// </summary>
        public PricingPredicateV2(global::OpenRouter.PricingPredicateV2Variant3? value)
        {
            PricingPredicateV2Variant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PricingPredicateV2 FromPricingPredicateV2Variant3(global::OpenRouter.PricingPredicateV2Variant3? value) => new PricingPredicateV2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PricingPredicateV2(global::OpenRouter.PricingPredicateV2Variant4 value) => new PricingPredicateV2((global::OpenRouter.PricingPredicateV2Variant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.PricingPredicateV2Variant4?(PricingPredicateV2 @this) => @this.PricingPredicateV2Variant4;

        /// <summary>
        ///
        /// </summary>
        public PricingPredicateV2(global::OpenRouter.PricingPredicateV2Variant4? value)
        {
            PricingPredicateV2Variant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PricingPredicateV2 FromPricingPredicateV2Variant4(global::OpenRouter.PricingPredicateV2Variant4? value) => new PricingPredicateV2(value);

        /// <summary>
        ///
        /// </summary>
        public PricingPredicateV2(
            object? pricingPredicateV2Variant1,
            global::OpenRouter.PricingPredicateV2Variant2? pricingPredicateV2Variant2,
            global::OpenRouter.PricingPredicateV2Variant3? pricingPredicateV2Variant3,
            global::OpenRouter.PricingPredicateV2Variant4? pricingPredicateV2Variant4
            )
        {
            PricingPredicateV2Variant1 = pricingPredicateV2Variant1;
            PricingPredicateV2Variant2 = pricingPredicateV2Variant2;
            PricingPredicateV2Variant3 = pricingPredicateV2Variant3;
            PricingPredicateV2Variant4 = pricingPredicateV2Variant4;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PricingPredicateV2Variant4 as object ??
            PricingPredicateV2Variant3 as object ??
            PricingPredicateV2Variant2 as object ??
            PricingPredicateV2Variant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PricingPredicateV2Variant1?.ToString() ??
            PricingPredicateV2Variant2?.ToString() ??
            PricingPredicateV2Variant3?.ToString() ??
            PricingPredicateV2Variant4?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPricingPredicateV2Variant1 && !IsPricingPredicateV2Variant2 && !IsPricingPredicateV2Variant3 && !IsPricingPredicateV2Variant4 || !IsPricingPredicateV2Variant1 && IsPricingPredicateV2Variant2 && !IsPricingPredicateV2Variant3 && !IsPricingPredicateV2Variant4 || !IsPricingPredicateV2Variant1 && !IsPricingPredicateV2Variant2 && IsPricingPredicateV2Variant3 && !IsPricingPredicateV2Variant4 || !IsPricingPredicateV2Variant1 && !IsPricingPredicateV2Variant2 && !IsPricingPredicateV2Variant3 && IsPricingPredicateV2Variant4;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<object, TResult>? pricingPredicateV2Variant1 = null,
            global::System.Func<global::OpenRouter.PricingPredicateV2Variant2, TResult>? pricingPredicateV2Variant2 = null,
            global::System.Func<global::OpenRouter.PricingPredicateV2Variant3, TResult>? pricingPredicateV2Variant3 = null,
            global::System.Func<global::OpenRouter.PricingPredicateV2Variant4, TResult>? pricingPredicateV2Variant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PricingPredicateV2Variant1 is { } __value0 && pricingPredicateV2Variant1 != null)
            {
                return pricingPredicateV2Variant1(__value0);
            }
            else if (PricingPredicateV2Variant2 is { } __value1 && pricingPredicateV2Variant2 != null)
            {
                return pricingPredicateV2Variant2(__value1);
            }
            else if (PricingPredicateV2Variant3 is { } __value2 && pricingPredicateV2Variant3 != null)
            {
                return pricingPredicateV2Variant3(__value2);
            }
            else if (PricingPredicateV2Variant4 is { } __value3 && pricingPredicateV2Variant4 != null)
            {
                return pricingPredicateV2Variant4(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<object>? pricingPredicateV2Variant1 = null,

            global::System.Action<global::OpenRouter.PricingPredicateV2Variant2>? pricingPredicateV2Variant2 = null,

            global::System.Action<global::OpenRouter.PricingPredicateV2Variant3>? pricingPredicateV2Variant3 = null,

            global::System.Action<global::OpenRouter.PricingPredicateV2Variant4>? pricingPredicateV2Variant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PricingPredicateV2Variant1 is { } __value0)
            {
                pricingPredicateV2Variant1?.Invoke(__value0);
            }
            else if (PricingPredicateV2Variant2 is { } __value1)
            {
                pricingPredicateV2Variant2?.Invoke(__value1);
            }
            else if (PricingPredicateV2Variant3 is { } __value2)
            {
                pricingPredicateV2Variant3?.Invoke(__value2);
            }
            else if (PricingPredicateV2Variant4 is { } __value3)
            {
                pricingPredicateV2Variant4?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<object>? pricingPredicateV2Variant1 = null,
            global::System.Action<global::OpenRouter.PricingPredicateV2Variant2>? pricingPredicateV2Variant2 = null,
            global::System.Action<global::OpenRouter.PricingPredicateV2Variant3>? pricingPredicateV2Variant3 = null,
            global::System.Action<global::OpenRouter.PricingPredicateV2Variant4>? pricingPredicateV2Variant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PricingPredicateV2Variant1 is { } __value0)
            {
                pricingPredicateV2Variant1?.Invoke(__value0);
            }
            else if (PricingPredicateV2Variant2 is { } __value1)
            {
                pricingPredicateV2Variant2?.Invoke(__value1);
            }
            else if (PricingPredicateV2Variant3 is { } __value2)
            {
                pricingPredicateV2Variant3?.Invoke(__value2);
            }
            else if (PricingPredicateV2Variant4 is { } __value3)
            {
                pricingPredicateV2Variant4?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PricingPredicateV2Variant1,
                typeof(object),
                PricingPredicateV2Variant2,
                typeof(global::OpenRouter.PricingPredicateV2Variant2),
                PricingPredicateV2Variant3,
                typeof(global::OpenRouter.PricingPredicateV2Variant3),
                PricingPredicateV2Variant4,
                typeof(global::OpenRouter.PricingPredicateV2Variant4),
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
        public bool Equals(PricingPredicateV2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(PricingPredicateV2Variant1, other.PricingPredicateV2Variant1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.PricingPredicateV2Variant2?>.Default.Equals(PricingPredicateV2Variant2, other.PricingPredicateV2Variant2) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.PricingPredicateV2Variant3?>.Default.Equals(PricingPredicateV2Variant3, other.PricingPredicateV2Variant3) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.PricingPredicateV2Variant4?>.Default.Equals(PricingPredicateV2Variant4, other.PricingPredicateV2Variant4)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PricingPredicateV2 obj1, PricingPredicateV2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PricingPredicateV2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PricingPredicateV2 obj1, PricingPredicateV2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PricingPredicateV2 o && Equals(o);
        }
    }
}
