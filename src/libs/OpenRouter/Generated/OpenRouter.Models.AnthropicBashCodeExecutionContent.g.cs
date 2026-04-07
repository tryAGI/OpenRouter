#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnthropicBashCodeExecutionContent : global::System.IEquatable<AnthropicBashCodeExecutionContent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicBashCodeExecutionToolResultError? AnthropicBashCodeExecutionToolResultError { get; init; }
#else
        public global::OpenRouter.AnthropicBashCodeExecutionToolResultError? AnthropicBashCodeExecutionToolResultError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicBashCodeExecutionToolResultError))]
#endif
        public bool IsAnthropicBashCodeExecutionToolResultError => AnthropicBashCodeExecutionToolResultError != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicBashCodeExecutionResult? AnthropicBashCodeExecutionResult { get; init; }
#else
        public global::OpenRouter.AnthropicBashCodeExecutionResult? AnthropicBashCodeExecutionResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicBashCodeExecutionResult))]
#endif
        public bool IsAnthropicBashCodeExecutionResult => AnthropicBashCodeExecutionResult != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicBashCodeExecutionContent(global::OpenRouter.AnthropicBashCodeExecutionToolResultError value) => new AnthropicBashCodeExecutionContent((global::OpenRouter.AnthropicBashCodeExecutionToolResultError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicBashCodeExecutionToolResultError?(AnthropicBashCodeExecutionContent @this) => @this.AnthropicBashCodeExecutionToolResultError;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicBashCodeExecutionContent(global::OpenRouter.AnthropicBashCodeExecutionToolResultError? value)
        {
            AnthropicBashCodeExecutionToolResultError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicBashCodeExecutionContent(global::OpenRouter.AnthropicBashCodeExecutionResult value) => new AnthropicBashCodeExecutionContent((global::OpenRouter.AnthropicBashCodeExecutionResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicBashCodeExecutionResult?(AnthropicBashCodeExecutionContent @this) => @this.AnthropicBashCodeExecutionResult;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicBashCodeExecutionContent(global::OpenRouter.AnthropicBashCodeExecutionResult? value)
        {
            AnthropicBashCodeExecutionResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicBashCodeExecutionContent(
            global::OpenRouter.AnthropicBashCodeExecutionToolResultError? anthropicBashCodeExecutionToolResultError,
            global::OpenRouter.AnthropicBashCodeExecutionResult? anthropicBashCodeExecutionResult
            )
        {
            AnthropicBashCodeExecutionToolResultError = anthropicBashCodeExecutionToolResultError;
            AnthropicBashCodeExecutionResult = anthropicBashCodeExecutionResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnthropicBashCodeExecutionResult as object ??
            AnthropicBashCodeExecutionToolResultError as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnthropicBashCodeExecutionToolResultError?.ToString() ??
            AnthropicBashCodeExecutionResult?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicBashCodeExecutionToolResultError && !IsAnthropicBashCodeExecutionResult || !IsAnthropicBashCodeExecutionToolResultError && IsAnthropicBashCodeExecutionResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicBashCodeExecutionToolResultError?, TResult>? anthropicBashCodeExecutionToolResultError = null,
            global::System.Func<global::OpenRouter.AnthropicBashCodeExecutionResult?, TResult>? anthropicBashCodeExecutionResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicBashCodeExecutionToolResultError && anthropicBashCodeExecutionToolResultError != null)
            {
                return anthropicBashCodeExecutionToolResultError(AnthropicBashCodeExecutionToolResultError!);
            }
            else if (IsAnthropicBashCodeExecutionResult && anthropicBashCodeExecutionResult != null)
            {
                return anthropicBashCodeExecutionResult(AnthropicBashCodeExecutionResult!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicBashCodeExecutionToolResultError?>? anthropicBashCodeExecutionToolResultError = null,
            global::System.Action<global::OpenRouter.AnthropicBashCodeExecutionResult?>? anthropicBashCodeExecutionResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicBashCodeExecutionToolResultError)
            {
                anthropicBashCodeExecutionToolResultError?.Invoke(AnthropicBashCodeExecutionToolResultError!);
            }
            else if (IsAnthropicBashCodeExecutionResult)
            {
                anthropicBashCodeExecutionResult?.Invoke(AnthropicBashCodeExecutionResult!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnthropicBashCodeExecutionToolResultError,
                typeof(global::OpenRouter.AnthropicBashCodeExecutionToolResultError),
                AnthropicBashCodeExecutionResult,
                typeof(global::OpenRouter.AnthropicBashCodeExecutionResult),
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
        public bool Equals(AnthropicBashCodeExecutionContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicBashCodeExecutionToolResultError?>.Default.Equals(AnthropicBashCodeExecutionToolResultError, other.AnthropicBashCodeExecutionToolResultError) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicBashCodeExecutionResult?>.Default.Equals(AnthropicBashCodeExecutionResult, other.AnthropicBashCodeExecutionResult) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnthropicBashCodeExecutionContent obj1, AnthropicBashCodeExecutionContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicBashCodeExecutionContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnthropicBashCodeExecutionContent obj1, AnthropicBashCodeExecutionContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicBashCodeExecutionContent o && Equals(o);
        }
    }
}
