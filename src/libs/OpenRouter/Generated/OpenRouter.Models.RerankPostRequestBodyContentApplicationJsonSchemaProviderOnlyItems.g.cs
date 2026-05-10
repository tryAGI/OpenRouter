#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems : global::System.IEquatable<RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems>
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
        public string? RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2 { get; init; }
#else
        public string? RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2))]
#endif
        public bool IsRerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2 => RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2;
            return IsRerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickRerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2() => IsRerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2
            ? RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems(global::OpenRouter.ProviderName value) => new RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems((global::OpenRouter.ProviderName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ProviderName?(RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems @this) => @this.ProviderName;

        /// <summary>
        /// 
        /// </summary>
        public RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems(global::OpenRouter.ProviderName? value)
        {
            ProviderName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems FromProviderName(global::OpenRouter.ProviderName? value) => new RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems(string value) => new RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems @this) => @this.RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems(string? value)
        {
            RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems FromRerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2(string? value) => new RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems(value);

        /// <summary>
        /// 
        /// </summary>
        public RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems(
            global::OpenRouter.ProviderName? providerName,
            string? rerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2
            )
        {
            ProviderName = providerName;
            RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2 = rerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2 as object ??
            ProviderName as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ProviderName?.ToValueString() ??
            RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProviderName && !IsRerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2 || !IsProviderName && IsRerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ProviderName?, TResult>? providerName = null,
            global::System.Func<string, TResult>? rerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2 = null,
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
            else if (IsRerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2 && rerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2 != null)
            {
                return rerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2(RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ProviderName?>? providerName = null,

            global::System.Action<string>? rerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2 = null,
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
            else if (IsRerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2)
            {
                rerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2?.Invoke(RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ProviderName?>? providerName = null,
            global::System.Action<string>? rerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2 = null,
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
            else if (IsRerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2)
            {
                rerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2?.Invoke(RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2!);
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
                RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2,
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
        public bool Equals(RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ProviderName?>.Default.Equals(ProviderName, other.ProviderName) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2, other.RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems obj1, RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems obj1, RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RerankPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems o && Equals(o);
        }
    }
}
