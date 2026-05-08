#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The sorting strategy to use for this request, if "order" is not specified. When set, no load balancing is performed.
    /// </summary>
    public readonly partial struct RerankPostRequestBodyContentApplicationJsonSchemaProviderSort : global::System.IEquatable<RerankPostRequestBodyContentApplicationJsonSchemaProviderSort>
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
        /// 
        /// </summary>
        public bool TryPickProviderSort(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ProviderSort? value)
        {
            value = ProviderSort;
            return IsProviderSort;
        }

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
        /// 
        /// </summary>
        public bool TryPickProviderSortConfig(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ProviderSortConfig? value)
        {
            value = ProviderSortConfig;
            return IsProviderSortConfig;
        }

        /// <summary>
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? RerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3 { get; init; }
#else
        public object? RerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3))]
#endif
        public bool IsRerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3 => RerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = RerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3;
            return IsRerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RerankPostRequestBodyContentApplicationJsonSchemaProviderSort(global::OpenRouter.ProviderSort value) => new RerankPostRequestBodyContentApplicationJsonSchemaProviderSort((global::OpenRouter.ProviderSort?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ProviderSort?(RerankPostRequestBodyContentApplicationJsonSchemaProviderSort @this) => @this.ProviderSort;

        /// <summary>
        /// 
        /// </summary>
        public RerankPostRequestBodyContentApplicationJsonSchemaProviderSort(global::OpenRouter.ProviderSort? value)
        {
            ProviderSort = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RerankPostRequestBodyContentApplicationJsonSchemaProviderSort(global::OpenRouter.ProviderSortConfig value) => new RerankPostRequestBodyContentApplicationJsonSchemaProviderSort((global::OpenRouter.ProviderSortConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ProviderSortConfig?(RerankPostRequestBodyContentApplicationJsonSchemaProviderSort @this) => @this.ProviderSortConfig;

        /// <summary>
        /// 
        /// </summary>
        public RerankPostRequestBodyContentApplicationJsonSchemaProviderSort(global::OpenRouter.ProviderSortConfig? value)
        {
            ProviderSortConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RerankPostRequestBodyContentApplicationJsonSchemaProviderSort(
            global::OpenRouter.ProviderSort? providerSort,
            global::OpenRouter.ProviderSortConfig? providerSortConfig,
            object? rerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3
            )
        {
            ProviderSort = providerSort;
            ProviderSortConfig = providerSortConfig;
            RerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3 = rerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3 as object ??
            ProviderSortConfig as object ??
            ProviderSort as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ProviderSort?.ToValueString() ??
            ProviderSortConfig?.ToString() ??
            RerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProviderSort && !IsProviderSortConfig && !IsRerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3 || !IsProviderSort && IsProviderSortConfig && !IsRerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3 || !IsProviderSort && !IsProviderSortConfig && IsRerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ProviderSort?, TResult>? providerSort = null,
            global::System.Func<global::OpenRouter.ProviderSortConfig, TResult>? providerSortConfig = null,
            global::System.Func<object, TResult>? rerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3 = null,
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
            else if (IsRerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3 && rerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3 != null)
            {
                return rerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3(RerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ProviderSort?>? providerSort = null,

            global::System.Action<global::OpenRouter.ProviderSortConfig>? providerSortConfig = null,

            global::System.Action<object>? rerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3 = null,
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
            else if (IsRerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3)
            {
                rerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3?.Invoke(RerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ProviderSort?>? providerSort = null,
            global::System.Action<global::OpenRouter.ProviderSortConfig>? providerSortConfig = null,
            global::System.Action<object>? rerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3 = null,
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
            else if (IsRerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3)
            {
                rerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3?.Invoke(RerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3!);
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
                RerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3,
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
        public bool Equals(RerankPostRequestBodyContentApplicationJsonSchemaProviderSort other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ProviderSort?>.Default.Equals(ProviderSort, other.ProviderSort) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ProviderSortConfig?>.Default.Equals(ProviderSortConfig, other.ProviderSortConfig) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(RerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3, other.RerankPostRequestBodyContentApplicationJsonSchemaProviderSortVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RerankPostRequestBodyContentApplicationJsonSchemaProviderSort obj1, RerankPostRequestBodyContentApplicationJsonSchemaProviderSort obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RerankPostRequestBodyContentApplicationJsonSchemaProviderSort>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RerankPostRequestBodyContentApplicationJsonSchemaProviderSort obj1, RerankPostRequestBodyContentApplicationJsonSchemaProviderSort obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RerankPostRequestBodyContentApplicationJsonSchemaProviderSort o && Equals(o);
        }
    }
}
