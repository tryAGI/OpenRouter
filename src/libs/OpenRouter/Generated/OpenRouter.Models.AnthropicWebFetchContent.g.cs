#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnthropicWebFetchContent : global::System.IEquatable<AnthropicWebFetchContent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicWebFetchToolResultError? AnthropicWebFetchToolResultError { get; init; }
#else
        public global::OpenRouter.AnthropicWebFetchToolResultError? AnthropicWebFetchToolResultError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicWebFetchToolResultError))]
#endif
        public bool IsAnthropicWebFetchToolResultError => AnthropicWebFetchToolResultError != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicWebFetchBlock? AnthropicWebFetchBlock { get; init; }
#else
        public global::OpenRouter.AnthropicWebFetchBlock? AnthropicWebFetchBlock { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicWebFetchBlock))]
#endif
        public bool IsAnthropicWebFetchBlock => AnthropicWebFetchBlock != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicWebFetchContent(global::OpenRouter.AnthropicWebFetchToolResultError value) => new AnthropicWebFetchContent((global::OpenRouter.AnthropicWebFetchToolResultError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicWebFetchToolResultError?(AnthropicWebFetchContent @this) => @this.AnthropicWebFetchToolResultError;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicWebFetchContent(global::OpenRouter.AnthropicWebFetchToolResultError? value)
        {
            AnthropicWebFetchToolResultError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicWebFetchContent(global::OpenRouter.AnthropicWebFetchBlock value) => new AnthropicWebFetchContent((global::OpenRouter.AnthropicWebFetchBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicWebFetchBlock?(AnthropicWebFetchContent @this) => @this.AnthropicWebFetchBlock;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicWebFetchContent(global::OpenRouter.AnthropicWebFetchBlock? value)
        {
            AnthropicWebFetchBlock = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicWebFetchContent(
            global::OpenRouter.AnthropicWebFetchToolResultError? anthropicWebFetchToolResultError,
            global::OpenRouter.AnthropicWebFetchBlock? anthropicWebFetchBlock
            )
        {
            AnthropicWebFetchToolResultError = anthropicWebFetchToolResultError;
            AnthropicWebFetchBlock = anthropicWebFetchBlock;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnthropicWebFetchBlock as object ??
            AnthropicWebFetchToolResultError as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnthropicWebFetchToolResultError?.ToString() ??
            AnthropicWebFetchBlock?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicWebFetchToolResultError && !IsAnthropicWebFetchBlock || !IsAnthropicWebFetchToolResultError && IsAnthropicWebFetchBlock;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicWebFetchToolResultError?, TResult>? anthropicWebFetchToolResultError = null,
            global::System.Func<global::OpenRouter.AnthropicWebFetchBlock?, TResult>? anthropicWebFetchBlock = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicWebFetchToolResultError && anthropicWebFetchToolResultError != null)
            {
                return anthropicWebFetchToolResultError(AnthropicWebFetchToolResultError!);
            }
            else if (IsAnthropicWebFetchBlock && anthropicWebFetchBlock != null)
            {
                return anthropicWebFetchBlock(AnthropicWebFetchBlock!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicWebFetchToolResultError?>? anthropicWebFetchToolResultError = null,
            global::System.Action<global::OpenRouter.AnthropicWebFetchBlock?>? anthropicWebFetchBlock = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicWebFetchToolResultError)
            {
                anthropicWebFetchToolResultError?.Invoke(AnthropicWebFetchToolResultError!);
            }
            else if (IsAnthropicWebFetchBlock)
            {
                anthropicWebFetchBlock?.Invoke(AnthropicWebFetchBlock!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnthropicWebFetchToolResultError,
                typeof(global::OpenRouter.AnthropicWebFetchToolResultError),
                AnthropicWebFetchBlock,
                typeof(global::OpenRouter.AnthropicWebFetchBlock),
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
        public bool Equals(AnthropicWebFetchContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicWebFetchToolResultError?>.Default.Equals(AnthropicWebFetchToolResultError, other.AnthropicWebFetchToolResultError) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicWebFetchBlock?>.Default.Equals(AnthropicWebFetchBlock, other.AnthropicWebFetchBlock) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnthropicWebFetchContent obj1, AnthropicWebFetchContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicWebFetchContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnthropicWebFetchContent obj1, AnthropicWebFetchContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicWebFetchContent o && Equals(o);
        }
    }
}
