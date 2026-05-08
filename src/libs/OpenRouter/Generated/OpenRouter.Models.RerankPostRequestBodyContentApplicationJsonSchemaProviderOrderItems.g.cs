#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems : global::System.IEquatable<RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ProviderName? ProviderName { get; init; }
#else
        public global::OpenRouter.ProviderName? ProviderName { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ProviderName))]
#endif
        public bool IsProviderName => ProviderName != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickProviderName(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ProviderName? value)
        {
            value = ProviderName;
            return IsProviderName;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2 { get; init; }
#else
        public string? RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2))]
#endif
        public bool IsRerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2 => RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2;
            return IsRerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems(global::OpenRouter.ProviderName value) => new RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems((global::OpenRouter.ProviderName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ProviderName?(RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems @this) => @this.ProviderName;

        /// <summary>
        /// 
        /// </summary>
        public RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems(global::OpenRouter.ProviderName? value)
        {
            ProviderName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems(string value) => new RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems @this) => @this.RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems(string? value)
        {
            RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems(
            global::OpenRouter.ProviderName? providerName,
            string? rerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2
            )
        {
            ProviderName = providerName;
            RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2 = rerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2 as object ??
            ProviderName as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ProviderName?.ToValueString() ??
            RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProviderName && !IsRerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2 || !IsProviderName && IsRerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ProviderName?, TResult>? providerName = null,
            global::System.Func<string, TResult>? rerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsProviderName && providerName != null)
            {
                return providerName(ProviderName!);
            }
            else if (IsRerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2 && rerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2 != null)
            {
                return rerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2(RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ProviderName?>? providerName = null,

            global::System.Action<string>? rerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsProviderName)
            {
                providerName?.Invoke(ProviderName!);
            }
            else if (IsRerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2)
            {
                rerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2?.Invoke(RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ProviderName?>? providerName = null,
            global::System.Action<string>? rerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsProviderName)
            {
                providerName?.Invoke(ProviderName!);
            }
            else if (IsRerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2)
            {
                rerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2?.Invoke(RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ProviderName,
                typeof(global::OpenRouter.ProviderName),
                RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2,
                typeof(string),
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
        public bool Equals(RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ProviderName?>.Default.Equals(ProviderName, other.ProviderName) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2, other.RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems obj1, RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems obj1, RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RerankPostRequestBodyContentApplicationJsonSchemaProviderOrderItems o && Equals(o);
        }
    }
}
