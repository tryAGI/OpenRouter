#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems : global::System.IEquatable<RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems>
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
        public global::OpenRouter.ProviderName PickProviderName() => IsProviderName
            ? ProviderName!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ProviderName' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2 { get; init; }
#else
        public string? RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2))]
#endif
        public bool IsRerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2 => RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2;
            return IsRerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickRerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2() => IsRerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2
            ? RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems(global::OpenRouter.ProviderName value) => new RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems((global::OpenRouter.ProviderName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ProviderName?(RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems @this) => @this.ProviderName;

        /// <summary>
        /// 
        /// </summary>
        public RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems(global::OpenRouter.ProviderName? value)
        {
            ProviderName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems FromProviderName(global::OpenRouter.ProviderName? value) => new RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems(string value) => new RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems @this) => @this.RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems(string? value)
        {
            RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems FromRerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2(string? value) => new RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems(value);

        /// <summary>
        /// 
        /// </summary>
        public RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems(
            global::OpenRouter.ProviderName? providerName,
            string? rerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2
            )
        {
            ProviderName = providerName;
            RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2 = rerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2 as object ??
            ProviderName as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ProviderName?.ToValueString() ??
            RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProviderName && !IsRerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2 || !IsProviderName && IsRerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ProviderName?, TResult>? providerName = null,
            global::System.Func<string, TResult>? rerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2 = null,
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
            else if (IsRerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2 && rerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2 != null)
            {
                return rerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2(RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ProviderName?>? providerName = null,

            global::System.Action<string>? rerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2 = null,
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
            else if (IsRerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2)
            {
                rerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2?.Invoke(RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ProviderName?>? providerName = null,
            global::System.Action<string>? rerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2 = null,
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
            else if (IsRerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2)
            {
                rerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2?.Invoke(RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2!);
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
                RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2,
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
        public bool Equals(RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ProviderName?>.Default.Equals(ProviderName, other.ProviderName) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2, other.RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems obj1, RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems obj1, RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RerankPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems o && Equals(o);
        }
    }
}
