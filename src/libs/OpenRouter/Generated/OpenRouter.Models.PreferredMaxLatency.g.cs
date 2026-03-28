#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Preferred maximum latency (in seconds). Can be a number (applies to p50) or an object with percentile-specific cutoffs. Endpoints above the threshold(s) may still be used, but are deprioritized in routing. When using fallback models, this may cause a fallback model to be used instead of the primary model if it meets the threshold.
    /// </summary>
    public readonly partial struct PreferredMaxLatency : global::System.IEquatable<PreferredMaxLatency>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? Value1 { get; init; }
#else
        public double? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// Percentile-based latency cutoffs. All specified cutoffs must be met for an endpoint to be preferred.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.PercentileLatencyCutoffs? PercentileLatencyCutoffs { get; init; }
#else
        public global::OpenRouter.PercentileLatencyCutoffs? PercentileLatencyCutoffs { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PercentileLatencyCutoffs))]
#endif
        public bool IsPercentileLatencyCutoffs => PercentileLatencyCutoffs != null;

        /// <summary>
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? Value3 { get; init; }
#else
        public object? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PreferredMaxLatency(double value) => new PreferredMaxLatency((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(PreferredMaxLatency @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public PreferredMaxLatency(double? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PreferredMaxLatency(global::OpenRouter.PercentileLatencyCutoffs value) => new PreferredMaxLatency((global::OpenRouter.PercentileLatencyCutoffs?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.PercentileLatencyCutoffs?(PreferredMaxLatency @this) => @this.PercentileLatencyCutoffs;

        /// <summary>
        /// 
        /// </summary>
        public PreferredMaxLatency(global::OpenRouter.PercentileLatencyCutoffs? value)
        {
            PercentileLatencyCutoffs = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PreferredMaxLatency(
            double? value1,
            global::OpenRouter.PercentileLatencyCutoffs? percentileLatencyCutoffs,
            object? value3
            )
        {
            Value1 = value1;
            PercentileLatencyCutoffs = percentileLatencyCutoffs;
            Value3 = value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value3 as object ??
            PercentileLatencyCutoffs as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            PercentileLatencyCutoffs?.ToString() ??
            Value3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsPercentileLatencyCutoffs && !IsValue3 || !IsValue1 && IsPercentileLatencyCutoffs && !IsValue3 || !IsValue1 && !IsPercentileLatencyCutoffs && IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<double?, TResult>? value1 = null,
            global::System.Func<global::OpenRouter.PercentileLatencyCutoffs?, TResult>? percentileLatencyCutoffs = null,
            global::System.Func<object?, TResult>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsPercentileLatencyCutoffs && percentileLatencyCutoffs != null)
            {
                return percentileLatencyCutoffs(PercentileLatencyCutoffs!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<double?>? value1 = null,
            global::System.Action<global::OpenRouter.PercentileLatencyCutoffs?>? percentileLatencyCutoffs = null,
            global::System.Action<object?>? value3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsPercentileLatencyCutoffs)
            {
                percentileLatencyCutoffs?.Invoke(PercentileLatencyCutoffs!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(double),
                PercentileLatencyCutoffs,
                typeof(global::OpenRouter.PercentileLatencyCutoffs),
                Value3,
                typeof(object),
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
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.PercentileLatencyCutoffs?>.Default.Equals(PercentileLatencyCutoffs, other.PercentileLatencyCutoffs) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(Value3, other.Value3) 
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
