#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems : global::System.IEquatable<EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems>
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
        public string? EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2 { get; init; }
#else
        public string? EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2))]
#endif
        public bool IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2 => EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2;
            return IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2() => IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2
            ? EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems(global::OpenRouter.ProviderName value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems((global::OpenRouter.ProviderName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ProviderName?(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems @this) => @this.ProviderName;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems(global::OpenRouter.ProviderName? value)
        {
            ProviderName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems FromProviderName(global::OpenRouter.ProviderName? value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems(string value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems @this) => @this.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems(string? value)
        {
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems FromEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2(string? value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems(value);

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems(
            global::OpenRouter.ProviderName? providerName,
            string? embeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2
            )
        {
            ProviderName = providerName;
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2 = embeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2 as object ??
            ProviderName as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ProviderName?.ToValueString() ??
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProviderName && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2 || !IsProviderName && IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ProviderName?, TResult>? providerName = null,
            global::System.Func<string, TResult>? embeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2 = null,
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
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2 && embeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2 != null)
            {
                return embeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ProviderName?>? providerName = null,

            global::System.Action<string>? embeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2 = null,
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
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2)
            {
                embeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2?.Invoke(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ProviderName?>? providerName = null,
            global::System.Action<string>? embeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2 = null,
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
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2)
            {
                embeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2?.Invoke(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2!);
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
                EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2,
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
        public bool Equals(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ProviderName?>.Default.Equals(ProviderName, other.ProviderName) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2, other.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItemsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems obj1, EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems obj1, EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderOrderItems o && Equals(o);
        }
    }
}
