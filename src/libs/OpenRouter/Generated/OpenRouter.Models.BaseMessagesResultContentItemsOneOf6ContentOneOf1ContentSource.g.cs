#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource : global::System.IEquatable<BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0? BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 { get; init; }
#else
        public global::OpenRouter.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0? BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0))]
#endif
        public bool IsBaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 => BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicPlainTextSourceResponse? AnthropicPlainTextSourceResponse { get; init; }
#else
        public global::OpenRouter.AnthropicPlainTextSourceResponse? AnthropicPlainTextSourceResponse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicPlainTextSourceResponse))]
#endif
        public bool IsAnthropicPlainTextSourceResponse => AnthropicPlainTextSourceResponse != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource(global::OpenRouter.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 value) => new BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource((global::OpenRouter.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0?(BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource @this) => @this.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource(global::OpenRouter.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0? value)
        {
            BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource(global::OpenRouter.AnthropicPlainTextSourceResponse value) => new BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource((global::OpenRouter.AnthropicPlainTextSourceResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicPlainTextSourceResponse?(BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource @this) => @this.AnthropicPlainTextSourceResponse;

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource(global::OpenRouter.AnthropicPlainTextSourceResponse? value)
        {
            AnthropicPlainTextSourceResponse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource(
            global::OpenRouter.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0? baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0,
            global::OpenRouter.AnthropicPlainTextSourceResponse? anthropicPlainTextSourceResponse
            )
        {
            BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 = baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0;
            AnthropicPlainTextSourceResponse = anthropicPlainTextSourceResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnthropicPlainTextSourceResponse as object ??
            BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0?.ToString() ??
            AnthropicPlainTextSourceResponse?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 && !IsAnthropicPlainTextSourceResponse || !IsBaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 && IsAnthropicPlainTextSourceResponse;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0?, TResult>? baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 = null,
            global::System.Func<global::OpenRouter.AnthropicPlainTextSourceResponse?, TResult>? anthropicPlainTextSourceResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 && baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 != null)
            {
                return baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0(BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0!);
            }
            else if (IsAnthropicPlainTextSourceResponse && anthropicPlainTextSourceResponse != null)
            {
                return anthropicPlainTextSourceResponse(AnthropicPlainTextSourceResponse!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0?>? baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0 = null,
            global::System.Action<global::OpenRouter.AnthropicPlainTextSourceResponse?>? anthropicPlainTextSourceResponse = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0)
            {
                baseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0?.Invoke(BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0!);
            }
            else if (IsAnthropicPlainTextSourceResponse)
            {
                anthropicPlainTextSourceResponse?.Invoke(AnthropicPlainTextSourceResponse!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0,
                typeof(global::OpenRouter.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0),
                AnthropicPlainTextSourceResponse,
                typeof(global::OpenRouter.AnthropicPlainTextSourceResponse),
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
        public bool Equals(BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0?>.Default.Equals(BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0, other.BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource0) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicPlainTextSourceResponse?>.Default.Equals(AnthropicPlainTextSourceResponse, other.AnthropicPlainTextSourceResponse) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource obj1, BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource obj1, BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BaseMessagesResultContentItemsOneOf6ContentOneOf1ContentSource o && Equals(o);
        }
    }
}
