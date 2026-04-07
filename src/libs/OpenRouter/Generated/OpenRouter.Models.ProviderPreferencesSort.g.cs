#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The sorting strategy to use for this request, if "order" is not specified. When set, no load balancing is performed.
    /// </summary>
    public readonly partial struct ProviderPreferencesSort : global::System.IEquatable<ProviderPreferencesSort>
    {
        /// <summary>
        /// The provider sorting strategy (price, throughput, latency)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ProviderSort? ProviderSort { get; init; }
#else
        public global::OpenRouter.ProviderSort? ProviderSort { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ProviderSort))]
#endif
        public bool IsProviderSort => ProviderSort != null;

        /// <summary>
        /// The provider sorting strategy (price, throughput, latency)
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ProviderSortConfig? ProviderSortConfig { get; init; }
#else
        public global::OpenRouter.ProviderSortConfig? ProviderSortConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ProviderSortConfig))]
#endif
        public bool IsProviderSortConfig => ProviderSortConfig != null;

        /// <summary>
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ProviderPreferencesSortVariant3 { get; init; }
#else
        public object? ProviderPreferencesSortVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ProviderPreferencesSortVariant3))]
#endif
        public bool IsProviderPreferencesSortVariant3 => ProviderPreferencesSortVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ProviderPreferencesSort(global::OpenRouter.ProviderSort value) => new ProviderPreferencesSort((global::OpenRouter.ProviderSort?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ProviderSort?(ProviderPreferencesSort @this) => @this.ProviderSort;

        /// <summary>
        /// 
        /// </summary>
        public ProviderPreferencesSort(global::OpenRouter.ProviderSort? value)
        {
            ProviderSort = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ProviderPreferencesSort(global::OpenRouter.ProviderSortConfig value) => new ProviderPreferencesSort((global::OpenRouter.ProviderSortConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ProviderSortConfig?(ProviderPreferencesSort @this) => @this.ProviderSortConfig;

        /// <summary>
        /// 
        /// </summary>
        public ProviderPreferencesSort(global::OpenRouter.ProviderSortConfig? value)
        {
            ProviderSortConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ProviderPreferencesSort(
            global::OpenRouter.ProviderSort? providerSort,
            global::OpenRouter.ProviderSortConfig? providerSortConfig,
            object? providerPreferencesSortVariant3
            )
        {
            ProviderSort = providerSort;
            ProviderSortConfig = providerSortConfig;
            ProviderPreferencesSortVariant3 = providerPreferencesSortVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ProviderPreferencesSortVariant3 as object ??
            ProviderSortConfig as object ??
            ProviderSort as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ProviderSort?.ToValueString() ??
            ProviderSortConfig?.ToString() ??
            ProviderPreferencesSortVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProviderSort && !IsProviderSortConfig && !IsProviderPreferencesSortVariant3 || !IsProviderSort && IsProviderSortConfig && !IsProviderPreferencesSortVariant3 || !IsProviderSort && !IsProviderSortConfig && IsProviderPreferencesSortVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ProviderSort?, TResult>? providerSort = null,
            global::System.Func<global::OpenRouter.ProviderSortConfig?, TResult>? providerSortConfig = null,
            global::System.Func<object?, TResult>? providerPreferencesSortVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsProviderSort && providerSort != null)
            {
                return providerSort(ProviderSort!);
            }
            else if (IsProviderSortConfig && providerSortConfig != null)
            {
                return providerSortConfig(ProviderSortConfig!);
            }
            else if (IsProviderPreferencesSortVariant3 && providerPreferencesSortVariant3 != null)
            {
                return providerPreferencesSortVariant3(ProviderPreferencesSortVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ProviderSort?>? providerSort = null,
            global::System.Action<global::OpenRouter.ProviderSortConfig?>? providerSortConfig = null,
            global::System.Action<object?>? providerPreferencesSortVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsProviderSort)
            {
                providerSort?.Invoke(ProviderSort!);
            }
            else if (IsProviderSortConfig)
            {
                providerSortConfig?.Invoke(ProviderSortConfig!);
            }
            else if (IsProviderPreferencesSortVariant3)
            {
                providerPreferencesSortVariant3?.Invoke(ProviderPreferencesSortVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ProviderSort,
                typeof(global::OpenRouter.ProviderSort),
                ProviderSortConfig,
                typeof(global::OpenRouter.ProviderSortConfig),
                ProviderPreferencesSortVariant3,
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
        public bool Equals(ProviderPreferencesSort other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ProviderSort?>.Default.Equals(ProviderSort, other.ProviderSort) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ProviderSortConfig?>.Default.Equals(ProviderSortConfig, other.ProviderSortConfig) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ProviderPreferencesSortVariant3, other.ProviderPreferencesSortVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ProviderPreferencesSort obj1, ProviderPreferencesSort obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ProviderPreferencesSort>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ProviderPreferencesSort obj1, ProviderPreferencesSort obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ProviderPreferencesSort o && Equals(o);
        }
    }
}
