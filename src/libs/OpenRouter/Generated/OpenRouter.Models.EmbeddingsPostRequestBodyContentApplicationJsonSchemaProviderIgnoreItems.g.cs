#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems : global::System.IEquatable<EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems>
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
        public string? EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2 { get; init; }
#else
        public string? EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2))]
#endif
        public bool IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2 => EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2;
            return IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2() => IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2
            ? EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems(global::OpenRouter.ProviderName value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems((global::OpenRouter.ProviderName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ProviderName?(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems @this) => @this.ProviderName;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems(global::OpenRouter.ProviderName? value)
        {
            ProviderName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems FromProviderName(global::OpenRouter.ProviderName? value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems(string value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems @this) => @this.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems(string? value)
        {
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems FromEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2(string? value) => new EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems(value);

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems(
            global::OpenRouter.ProviderName? providerName,
            string? embeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2
            )
        {
            ProviderName = providerName;
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2 = embeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2 as object ??
            ProviderName as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ProviderName?.ToValueString() ??
            EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProviderName && !IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2 || !IsProviderName && IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ProviderName?, TResult>? providerName = null,
            global::System.Func<string, TResult>? embeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2 = null,
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
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2 && embeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2 != null)
            {
                return embeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ProviderName?>? providerName = null,

            global::System.Action<string>? embeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2 = null,
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
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2)
            {
                embeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2?.Invoke(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ProviderName?>? providerName = null,
            global::System.Action<string>? embeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2 = null,
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
            else if (IsEmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2)
            {
                embeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2?.Invoke(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2!);
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
                EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2,
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
        public bool Equals(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ProviderName?>.Default.Equals(ProviderName, other.ProviderName) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2, other.EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItemsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems obj1, EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems obj1, EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EmbeddingsPostRequestBodyContentApplicationJsonSchemaProviderIgnoreItems o && Equals(o);
        }
    }
}
