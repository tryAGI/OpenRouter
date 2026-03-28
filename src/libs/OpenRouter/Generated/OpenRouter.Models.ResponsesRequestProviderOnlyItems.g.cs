#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResponsesRequestProviderOnlyItems : global::System.IEquatable<ResponsesRequestProviderOnlyItems>
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
        public string? Value2 { get; init; }
#else
        public string? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestProviderOnlyItems(global::OpenRouter.ProviderName value) => new ResponsesRequestProviderOnlyItems((global::OpenRouter.ProviderName?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ProviderName?(ResponsesRequestProviderOnlyItems @this) => @this.ProviderName;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestProviderOnlyItems(global::OpenRouter.ProviderName? value)
        {
            ProviderName = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestProviderOnlyItems(string value) => new ResponsesRequestProviderOnlyItems((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ResponsesRequestProviderOnlyItems @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestProviderOnlyItems(string? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestProviderOnlyItems(
            global::OpenRouter.ProviderName? providerName,
            string? value2
            )
        {
            ProviderName = providerName;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            ProviderName as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ProviderName?.ToValueString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProviderName && !IsValue2 || !IsProviderName && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ProviderName?, TResult>? providerName = null,
            global::System.Func<string?, TResult>? value2 = null,
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
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ProviderName?>? providerName = null,
            global::System.Action<string?>? value2 = null,
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
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
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
                Value2,
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
        public bool Equals(ResponsesRequestProviderOnlyItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ProviderName?>.Default.Equals(ProviderName, other.ProviderName) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponsesRequestProviderOnlyItems obj1, ResponsesRequestProviderOnlyItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponsesRequestProviderOnlyItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponsesRequestProviderOnlyItems obj1, ResponsesRequestProviderOnlyItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponsesRequestProviderOnlyItems o && Equals(o);
        }
    }
}
