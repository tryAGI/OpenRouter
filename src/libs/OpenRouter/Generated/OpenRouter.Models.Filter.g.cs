#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Filter : global::System.IEquatable<Filter>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ScalarFilter? Scalar { get; init; }
#else
        public global::OpenRouter.ScalarFilter? Scalar { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Scalar))]
#endif
        public bool IsScalar => Scalar != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScalar(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ScalarFilter? value)
        {
            value = Scalar;
            return IsScalar;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ScalarFilter PickScalar() => Scalar is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Scalar' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.SetFilter? Set { get; init; }
#else
        public global::OpenRouter.SetFilter? Set { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Set))]
#endif
        public bool IsSet => Set != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSet(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.SetFilter? value)
        {
            value = Set;
            return IsSet;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.SetFilter PickSet() => Set is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Set' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Filter(global::OpenRouter.ScalarFilter value) => new Filter((global::OpenRouter.ScalarFilter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ScalarFilter?(Filter @this) => @this.Scalar;

        /// <summary>
        ///
        /// </summary>
        public Filter(global::OpenRouter.ScalarFilter? value)
        {
            Scalar = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Filter FromScalar(global::OpenRouter.ScalarFilter? value) => new Filter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Filter(global::OpenRouter.SetFilter value) => new Filter((global::OpenRouter.SetFilter?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.SetFilter?(Filter @this) => @this.Set;

        /// <summary>
        ///
        /// </summary>
        public Filter(global::OpenRouter.SetFilter? value)
        {
            Set = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Filter FromSet(global::OpenRouter.SetFilter? value) => new Filter(value);

        /// <summary>
        ///
        /// </summary>
        public Filter(
            global::OpenRouter.ScalarFilter? scalar,
            global::OpenRouter.SetFilter? set
            )
        {
            Scalar = scalar;
            Set = set;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Set as object ??
            Scalar as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Scalar?.ToString() ??
            Set?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsScalar || IsSet;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ScalarFilter, TResult>? scalar = null,
            global::System.Func<global::OpenRouter.SetFilter, TResult>? set = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Scalar is { } __value0 && scalar != null)
            {
                return scalar(__value0);
            }
            else if (Set is { } __value1 && set != null)
            {
                return set(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ScalarFilter>? scalar = null,

            global::System.Action<global::OpenRouter.SetFilter>? set = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Scalar is { } __value0)
            {
                scalar?.Invoke(__value0);
            }
            else if (Set is { } __value1)
            {
                set?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ScalarFilter>? scalar = null,
            global::System.Action<global::OpenRouter.SetFilter>? set = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Scalar is { } __value0)
            {
                scalar?.Invoke(__value0);
            }
            else if (Set is { } __value1)
            {
                set?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Scalar,
                typeof(global::OpenRouter.ScalarFilter),
                Set,
                typeof(global::OpenRouter.SetFilter),
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
        public bool Equals(Filter other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ScalarFilter?>.Default.Equals(Scalar, other.Scalar) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.SetFilter?>.Default.Equals(Set, other.Set)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Filter obj1, Filter obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Filter>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Filter obj1, Filter obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Filter o && Equals(o);
        }
    }
}
