#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Preferred minimum throughput (in tokens per second). Can be a number (applies to p50) or an object with percentile-specific cutoffs. Endpoints below the threshold(s) may still be used, but are deprioritized in routing. When using fallback models, this may cause a fallback model to be used instead of the primary model if it meets the threshold.<br/>
    /// Example: 100
    /// </summary>
    public readonly partial struct PreferredMinThroughput : global::System.IEquatable<PreferredMinThroughput>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public double? PreferredMinThroughputVariant1 { get; init; }
#else
        public double? PreferredMinThroughputVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PreferredMinThroughputVariant1))]
#endif
        public bool IsPreferredMinThroughputVariant1 => PreferredMinThroughputVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPreferredMinThroughputVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = PreferredMinThroughputVariant1;
            return IsPreferredMinThroughputVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public double PickPreferredMinThroughputVariant1() => PreferredMinThroughputVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PreferredMinThroughputVariant1' but the value was {ToString()}.");

        /// <summary>
        /// Percentile-based throughput cutoffs. All specified cutoffs must be met for an endpoint to be preferred.<br/>
        /// Example: {"p50":100,"p90":50}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.PercentileThroughputCutoffs? PercentileCutoffs { get; init; }
#else
        public global::OpenRouter.PercentileThroughputCutoffs? PercentileCutoffs { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PercentileCutoffs))]
#endif
        public bool IsPercentileCutoffs => PercentileCutoffs != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPercentileCutoffs(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.PercentileThroughputCutoffs? value)
        {
            value = PercentileCutoffs;
            return IsPercentileCutoffs;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PercentileThroughputCutoffs PickPercentileCutoffs() => PercentileCutoffs is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PercentileCutoffs' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PreferredMinThroughput(double value) => new PreferredMinThroughput((double?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator double?(PreferredMinThroughput @this) => @this.PreferredMinThroughputVariant1;

        /// <summary>
        ///
        /// </summary>
        public PreferredMinThroughput(double? value)
        {
            PreferredMinThroughputVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PreferredMinThroughput FromPreferredMinThroughputVariant1(double? value) => new PreferredMinThroughput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PreferredMinThroughput(global::OpenRouter.PercentileThroughputCutoffs value) => new PreferredMinThroughput((global::OpenRouter.PercentileThroughputCutoffs?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.PercentileThroughputCutoffs?(PreferredMinThroughput @this) => @this.PercentileCutoffs;

        /// <summary>
        ///
        /// </summary>
        public PreferredMinThroughput(global::OpenRouter.PercentileThroughputCutoffs? value)
        {
            PercentileCutoffs = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PreferredMinThroughput FromPercentileCutoffs(global::OpenRouter.PercentileThroughputCutoffs? value) => new PreferredMinThroughput(value);

        /// <summary>
        ///
        /// </summary>
        public PreferredMinThroughput(
            double? preferredMinThroughputVariant1,
            global::OpenRouter.PercentileThroughputCutoffs? percentileCutoffs
            )
        {
            PreferredMinThroughputVariant1 = preferredMinThroughputVariant1;
            PercentileCutoffs = percentileCutoffs;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PercentileCutoffs as object ??
            PreferredMinThroughputVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PreferredMinThroughputVariant1?.ToString() ??
            PercentileCutoffs?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPreferredMinThroughputVariant1 || IsPercentileCutoffs;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<double?, TResult>? preferredMinThroughputVariant1 = null,
            global::System.Func<global::OpenRouter.PercentileThroughputCutoffs, TResult>? percentileCutoffs = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PreferredMinThroughputVariant1 is { } __value0 && preferredMinThroughputVariant1 != null)
            {
                return preferredMinThroughputVariant1(__value0);
            }
            else if (PercentileCutoffs is { } __value1 && percentileCutoffs != null)
            {
                return percentileCutoffs(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<double?>? preferredMinThroughputVariant1 = null,

            global::System.Action<global::OpenRouter.PercentileThroughputCutoffs>? percentileCutoffs = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PreferredMinThroughputVariant1 is { } __value0)
            {
                preferredMinThroughputVariant1?.Invoke(__value0);
            }
            else if (PercentileCutoffs is { } __value1)
            {
                percentileCutoffs?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<double?>? preferredMinThroughputVariant1 = null,
            global::System.Action<global::OpenRouter.PercentileThroughputCutoffs>? percentileCutoffs = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PreferredMinThroughputVariant1 is { } __value0)
            {
                preferredMinThroughputVariant1?.Invoke(__value0);
            }
            else if (PercentileCutoffs is { } __value1)
            {
                percentileCutoffs?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PreferredMinThroughputVariant1,
                typeof(double),
                PercentileCutoffs,
                typeof(global::OpenRouter.PercentileThroughputCutoffs),
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
        public bool Equals(PreferredMinThroughput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(PreferredMinThroughputVariant1, other.PreferredMinThroughputVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.PercentileThroughputCutoffs?>.Default.Equals(PercentileCutoffs, other.PercentileCutoffs)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PreferredMinThroughput obj1, PreferredMinThroughput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PreferredMinThroughput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PreferredMinThroughput obj1, PreferredMinThroughput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PreferredMinThroughput o && Equals(o);
        }
    }
}
