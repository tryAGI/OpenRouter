#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Preferred maximum latency (in seconds). Can be a number (applies to p50) or an object with percentile-specific cutoffs. Endpoints above the threshold(s) may still be used, but are deprioritized in routing. When using fallback models, this may cause a fallback model to be used instead of the primary model if it meets the threshold.<br/>
    /// Example: 5
    /// </summary>
    public readonly partial struct PreferredMaxLatency : global::System.IEquatable<PreferredMaxLatency>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public double? PreferredMaxLatencyVariant1 { get; init; }
#else
        public double? PreferredMaxLatencyVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PreferredMaxLatencyVariant1))]
#endif
        public bool IsPreferredMaxLatencyVariant1 => PreferredMaxLatencyVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPreferredMaxLatencyVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = PreferredMaxLatencyVariant1;
            return IsPreferredMaxLatencyVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public double PickPreferredMaxLatencyVariant1() => PreferredMaxLatencyVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PreferredMaxLatencyVariant1' but the value was {ToString()}.");

        /// <summary>
        /// Percentile-based latency cutoffs. All specified cutoffs must be met for an endpoint to be preferred.<br/>
        /// Example: {"p50":5,"p90":10}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.PercentileLatencyCutoffs? PercentileCutoffs { get; init; }
#else
        public global::OpenRouter.PercentileLatencyCutoffs? PercentileCutoffs { get; }
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
            out global::OpenRouter.PercentileLatencyCutoffs? value)
        {
            value = PercentileCutoffs;
            return IsPercentileCutoffs;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.PercentileLatencyCutoffs PickPercentileCutoffs() => PercentileCutoffs is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PercentileCutoffs' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PreferredMaxLatency(double value) => new PreferredMaxLatency((double?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator double?(PreferredMaxLatency @this) => @this.PreferredMaxLatencyVariant1;

        /// <summary>
        ///
        /// </summary>
        public PreferredMaxLatency(double? value)
        {
            PreferredMaxLatencyVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PreferredMaxLatency FromPreferredMaxLatencyVariant1(double? value) => new PreferredMaxLatency(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PreferredMaxLatency(global::OpenRouter.PercentileLatencyCutoffs value) => new PreferredMaxLatency((global::OpenRouter.PercentileLatencyCutoffs?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.PercentileLatencyCutoffs?(PreferredMaxLatency @this) => @this.PercentileCutoffs;

        /// <summary>
        ///
        /// </summary>
        public PreferredMaxLatency(global::OpenRouter.PercentileLatencyCutoffs? value)
        {
            PercentileCutoffs = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PreferredMaxLatency FromPercentileCutoffs(global::OpenRouter.PercentileLatencyCutoffs? value) => new PreferredMaxLatency(value);

        /// <summary>
        ///
        /// </summary>
        public PreferredMaxLatency(
            double? preferredMaxLatencyVariant1,
            global::OpenRouter.PercentileLatencyCutoffs? percentileCutoffs
            )
        {
            PreferredMaxLatencyVariant1 = preferredMaxLatencyVariant1;
            PercentileCutoffs = percentileCutoffs;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PercentileCutoffs as object ??
            PreferredMaxLatencyVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PreferredMaxLatencyVariant1?.ToString() ??
            PercentileCutoffs?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPreferredMaxLatencyVariant1 || IsPercentileCutoffs;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<double?, TResult>? preferredMaxLatencyVariant1 = null,
            global::System.Func<global::OpenRouter.PercentileLatencyCutoffs, TResult>? percentileCutoffs = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PreferredMaxLatencyVariant1 is { } __value0 && preferredMaxLatencyVariant1 != null)
            {
                return preferredMaxLatencyVariant1(__value0);
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
            global::System.Action<double?>? preferredMaxLatencyVariant1 = null,

            global::System.Action<global::OpenRouter.PercentileLatencyCutoffs>? percentileCutoffs = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PreferredMaxLatencyVariant1 is { } __value0)
            {
                preferredMaxLatencyVariant1?.Invoke(__value0);
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
            global::System.Action<double?>? preferredMaxLatencyVariant1 = null,
            global::System.Action<global::OpenRouter.PercentileLatencyCutoffs>? percentileCutoffs = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PreferredMaxLatencyVariant1 is { } __value0)
            {
                preferredMaxLatencyVariant1?.Invoke(__value0);
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
                PreferredMaxLatencyVariant1,
                typeof(double),
                PercentileCutoffs,
                typeof(global::OpenRouter.PercentileLatencyCutoffs),
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
        public bool Equals(PreferredMaxLatency other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(PreferredMaxLatencyVariant1, other.PreferredMaxLatencyVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.PercentileLatencyCutoffs?>.Default.Equals(PercentileCutoffs, other.PercentileCutoffs)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PreferredMaxLatency obj1, PreferredMaxLatency obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PreferredMaxLatency>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PreferredMaxLatency obj1, PreferredMaxLatency obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PreferredMaxLatency o && Equals(o);
        }
    }
}
