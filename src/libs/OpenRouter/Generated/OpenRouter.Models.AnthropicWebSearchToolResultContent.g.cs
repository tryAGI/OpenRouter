#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnthropicWebSearchToolResultContent : global::System.IEquatable<AnthropicWebSearchToolResultContent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResult>? AnthropicWebSearchToolResultContent0 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResult>? AnthropicWebSearchToolResultContent0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicWebSearchToolResultContent0))]
#endif
        public bool IsAnthropicWebSearchToolResultContent0 => AnthropicWebSearchToolResultContent0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicWebSearchToolResultError? AnthropicWebSearchToolResultError { get; init; }
#else
        public global::OpenRouter.AnthropicWebSearchToolResultError? AnthropicWebSearchToolResultError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicWebSearchToolResultError))]
#endif
        public bool IsAnthropicWebSearchToolResultError => AnthropicWebSearchToolResultError != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicWebSearchToolResultContent(global::OpenRouter.AnthropicWebSearchToolResultError value) => new AnthropicWebSearchToolResultContent((global::OpenRouter.AnthropicWebSearchToolResultError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicWebSearchToolResultError?(AnthropicWebSearchToolResultContent @this) => @this.AnthropicWebSearchToolResultError;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicWebSearchToolResultContent(global::OpenRouter.AnthropicWebSearchToolResultError? value)
        {
            AnthropicWebSearchToolResultError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicWebSearchToolResultContent(
            global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResult>? anthropicWebSearchToolResultContent0,
            global::OpenRouter.AnthropicWebSearchToolResultError? anthropicWebSearchToolResultError
            )
        {
            AnthropicWebSearchToolResultContent0 = anthropicWebSearchToolResultContent0;
            AnthropicWebSearchToolResultError = anthropicWebSearchToolResultError;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnthropicWebSearchToolResultError as object ??
            AnthropicWebSearchToolResultContent0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnthropicWebSearchToolResultContent0?.ToString() ??
            AnthropicWebSearchToolResultError?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicWebSearchToolResultContent0 && !IsAnthropicWebSearchToolResultError || !IsAnthropicWebSearchToolResultContent0 && IsAnthropicWebSearchToolResultError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResult>?, TResult>? anthropicWebSearchToolResultContent0 = null,
            global::System.Func<global::OpenRouter.AnthropicWebSearchToolResultError?, TResult>? anthropicWebSearchToolResultError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicWebSearchToolResultContent0 && anthropicWebSearchToolResultContent0 != null)
            {
                return anthropicWebSearchToolResultContent0(AnthropicWebSearchToolResultContent0!);
            }
            else if (IsAnthropicWebSearchToolResultError && anthropicWebSearchToolResultError != null)
            {
                return anthropicWebSearchToolResultError(AnthropicWebSearchToolResultError!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResult>?>? anthropicWebSearchToolResultContent0 = null,
            global::System.Action<global::OpenRouter.AnthropicWebSearchToolResultError?>? anthropicWebSearchToolResultError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicWebSearchToolResultContent0)
            {
                anthropicWebSearchToolResultContent0?.Invoke(AnthropicWebSearchToolResultContent0!);
            }
            else if (IsAnthropicWebSearchToolResultError)
            {
                anthropicWebSearchToolResultError?.Invoke(AnthropicWebSearchToolResultError!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnthropicWebSearchToolResultContent0,
                typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResult>),
                AnthropicWebSearchToolResultError,
                typeof(global::OpenRouter.AnthropicWebSearchToolResultError),
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
        public bool Equals(AnthropicWebSearchToolResultContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResult>?>.Default.Equals(AnthropicWebSearchToolResultContent0, other.AnthropicWebSearchToolResultContent0) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicWebSearchToolResultError?>.Default.Equals(AnthropicWebSearchToolResultError, other.AnthropicWebSearchToolResultError) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnthropicWebSearchToolResultContent obj1, AnthropicWebSearchToolResultContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicWebSearchToolResultContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnthropicWebSearchToolResultContent obj1, AnthropicWebSearchToolResultContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicWebSearchToolResultContent o && Equals(o);
        }
    }
}
