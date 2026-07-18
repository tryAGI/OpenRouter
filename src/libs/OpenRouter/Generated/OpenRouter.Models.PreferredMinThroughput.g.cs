#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Preferred minimum throughput (in tokens per second). Can be a number (applies to p50) or an object with percentile-specific cutoffs. Endpoints below the threshold(s) may still be used, but are deprioritized in routing. When using fallback models, this may cause a fallback model to be used instead of the primary model if it meets the threshold.
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
        public double PickPreferredMinThroughputVariant1() => IsPreferredMinThroughputVariant1
            ? PreferredMinThroughputVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PreferredMinThroughputVariant1' but the value was {ToString()}.");

        /// <summary>
        /// Percentile-based throughput cutoffs. All specified cutoffs must be met for an endpoint to be preferred.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.PercentileThroughputCutoffs? PercentileThroughputCutoffs { get; init; }
#else
        public global::OpenRouter.PercentileThroughputCutoffs? PercentileThroughputCutoffs { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PercentileThroughputCutoffs))]
#endif
        public bool IsPercentileThroughputCutoffs => PercentileThroughputCutoffs != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPercentileThroughputCutoffs(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.PercentileThroughputCutoffs? value)
        {
            value = PercentileThroughputCutoffs;
            return IsPercentileThroughputCutoffs;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.PercentileThroughputCutoffs PickPercentileThroughputCutoffs() => IsPercentileThroughputCutoffs
            ? PercentileThroughputCutoffs!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PercentileThroughputCutoffs' but the value was {ToString()}.");
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
        public static implicit operator global::OpenRouter.PercentileThroughputCutoffs?(PreferredMinThroughput @this) => @this.PercentileThroughputCutoffs;

        /// <summary>
        /// 
        /// </summary>
        public PreferredMinThroughput(global::OpenRouter.PercentileThroughputCutoffs? value)
        {
            PercentileThroughputCutoffs = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PreferredMinThroughput FromPercentileThroughputCutoffs(global::OpenRouter.PercentileThroughputCutoffs? value) => new PreferredMinThroughput(value);

        /// <summary>
        /// 
        /// </summary>
        public PreferredMinThroughput(
            double? preferredMinThroughputVariant1,
            global::OpenRouter.PercentileThroughputCutoffs? percentileThroughputCutoffs
            )
        {
            PreferredMinThroughputVariant1 = preferredMinThroughputVariant1;
            PercentileThroughputCutoffs = percentileThroughputCutoffs;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PercentileThroughputCutoffs as object ??
            PreferredMinThroughputVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PreferredMinThroughputVariant1?.ToString() ??
            PercentileThroughputCutoffs?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPreferredMinThroughputVariant1 && !IsPercentileThroughputCutoffs || !IsPreferredMinThroughputVariant1 && IsPercentileThroughputCutoffs;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<double?, TResult>? preferredMinThroughputVariant1 = null,
            global::System.Func<global::OpenRouter.PercentileThroughputCutoffs, TResult>? percentileThroughputCutoffs = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPreferredMinThroughputVariant1 && preferredMinThroughputVariant1 != null)
            {
                return preferredMinThroughputVariant1(PreferredMinThroughputVariant1!);
            }
            else if (IsPercentileThroughputCutoffs && percentileThroughputCutoffs != null)
            {
                return percentileThroughputCutoffs(PercentileThroughputCutoffs!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<double?>? preferredMinThroughputVariant1 = null,

            global::System.Action<global::OpenRouter.PercentileThroughputCutoffs>? percentileThroughputCutoffs = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPreferredMinThroughputVariant1)
            {
                preferredMinThroughputVariant1?.Invoke(PreferredMinThroughputVariant1!);
            }
            else if (IsPercentileThroughputCutoffs)
            {
                percentileThroughputCutoffs?.Invoke(PercentileThroughputCutoffs!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<double?>? preferredMinThroughputVariant1 = null,
            global::System.Action<global::OpenRouter.PercentileThroughputCutoffs>? percentileThroughputCutoffs = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPreferredMinThroughputVariant1)
            {
                preferredMinThroughputVariant1?.Invoke(PreferredMinThroughputVariant1!);
            }
            else if (IsPercentileThroughputCutoffs)
            {
                percentileThroughputCutoffs?.Invoke(PercentileThroughputCutoffs!);
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
                PercentileThroughputCutoffs,
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.PercentileThroughputCutoffs?>.Default.Equals(PercentileThroughputCutoffs, other.PercentileThroughputCutoffs) 
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
