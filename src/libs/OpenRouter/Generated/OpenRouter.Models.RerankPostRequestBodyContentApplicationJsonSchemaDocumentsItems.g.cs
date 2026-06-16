#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A document to rerank. Either a plain string, or a structured object with optional `text` and/or `image`.
    /// </summary>
    public readonly partial struct RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems : global::System.IEquatable<RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1 { get; init; }
#else
        public string? RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1))]
#endif
        public bool IsRerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1 => RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1;
            return IsRerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickRerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1() => IsRerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1
            ? RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1' but the value was {ToString()}.");

        /// <summary>
        /// A structured document with optional text and/or image content. At least one of `text` or `image` must be provided.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1? RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1 { get; init; }
#else
        public global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1? RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1))]
#endif
        public bool IsRerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1 => RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickRerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1? value)
        {
            value = RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1;
            return IsRerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1 PickRerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1() => IsRerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1
            ? RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems(string value) => new RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems @this) => @this.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1;

        /// <summary>
        /// 
        /// </summary>
        public RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems(string? value)
        {
            RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems FromRerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1(string? value) => new RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1 value) => new RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems((global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1?(RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems @this) => @this.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1;

        /// <summary>
        /// 
        /// </summary>
        public RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1? value)
        {
            RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems FromRerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1? value) => new RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems(value);

        /// <summary>
        /// 
        /// </summary>
        public RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems(
            string? rerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1,
            global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1? rerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1
            )
        {
            RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1 = rerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1;
            RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1 = rerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1 as object ??
            RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1?.ToString() ??
            RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsRerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1 && !IsRerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1 || !IsRerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1 && IsRerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? rerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1 = null,
            global::System.Func<global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1, TResult>? rerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1 && rerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1 != null)
            {
                return rerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1(RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1!);
            }
            else if (IsRerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1 && rerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1 != null)
            {
                return rerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1(RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? rerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1 = null,

            global::System.Action<global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1>? rerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1)
            {
                rerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1?.Invoke(RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1!);
            }
            else if (IsRerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1)
            {
                rerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1?.Invoke(RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? rerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1 = null,
            global::System.Action<global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1>? rerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsRerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1)
            {
                rerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1?.Invoke(RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1!);
            }
            else if (IsRerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1)
            {
                rerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1?.Invoke(RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1,
                typeof(string),
                RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1,
                typeof(global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1),
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
        public bool Equals(RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1, other.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItemsVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1?>.Default.Equals(RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1, other.RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems obj1, RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems obj1, RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems o && Equals(o);
        }
    }
}
