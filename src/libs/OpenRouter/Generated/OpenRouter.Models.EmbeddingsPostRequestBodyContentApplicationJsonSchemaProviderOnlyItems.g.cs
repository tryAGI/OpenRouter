#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems : global::System.IEquatable<EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems>
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
#if NET6_0_OR_GREATER
        public string? EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2 { get; init; }
#else
        public string? EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2))]
#endif
        public bool IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2 => EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems(global::OpenRouter.ProviderName value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems((global::OpenRouter.ProviderName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ProviderName?(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems @this) => @this.ProviderName;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems(global::OpenRouter.ProviderName? value)
        {
            ProviderName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems(string value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems @this) => @this.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems(string? value)
        {
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems(
            global::OpenRouter.ProviderName? providerName,
            string? embeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2
            )
        {
            ProviderName = providerName;
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2 = embeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2 as object ??
            ProviderName as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ProviderName?.ToValueString() ??
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProviderName && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2 || !IsProviderName && IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ProviderName?, TResult>? providerName = null,
            global::System.Func<string?, TResult>? embeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2 = null,
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
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2 && embeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2 != null)
            {
                return embeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ProviderName?>? providerName = null,
            global::System.Action<string?>? embeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2 = null,
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
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2)
            {
                embeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2?.Invoke(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2!);
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
                EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2,
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
        public bool Equals(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ProviderName?>.Default.Equals(ProviderName, other.ProviderName) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2, other.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItemsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems obj1, EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems obj1, EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOnlyItems o && Equals(o);
        }
    }
}
