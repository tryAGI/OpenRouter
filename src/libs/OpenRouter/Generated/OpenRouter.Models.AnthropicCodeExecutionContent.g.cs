#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnthropicCodeExecutionContent : global::System.IEquatable<AnthropicCodeExecutionContent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCodeExecutionToolResultError? AnthropicCodeExecutionToolResultError { get; init; }
#else
        public global::OpenRouter.AnthropicCodeExecutionToolResultError? AnthropicCodeExecutionToolResultError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicCodeExecutionToolResultError))]
#endif
        public bool IsAnthropicCodeExecutionToolResultError => AnthropicCodeExecutionToolResultError != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCodeExecutionResult? AnthropicCodeExecutionResult { get; init; }
#else
        public global::OpenRouter.AnthropicCodeExecutionResult? AnthropicCodeExecutionResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicCodeExecutionResult))]
#endif
        public bool IsAnthropicCodeExecutionResult => AnthropicCodeExecutionResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicEncryptedCodeExecutionResult? AnthropicEncryptedCodeExecutionResult { get; init; }
#else
        public global::OpenRouter.AnthropicEncryptedCodeExecutionResult? AnthropicEncryptedCodeExecutionResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicEncryptedCodeExecutionResult))]
#endif
        public bool IsAnthropicEncryptedCodeExecutionResult => AnthropicEncryptedCodeExecutionResult != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicCodeExecutionContent(global::OpenRouter.AnthropicCodeExecutionToolResultError value) => new AnthropicCodeExecutionContent((global::OpenRouter.AnthropicCodeExecutionToolResultError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCodeExecutionToolResultError?(AnthropicCodeExecutionContent @this) => @this.AnthropicCodeExecutionToolResultError;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicCodeExecutionContent(global::OpenRouter.AnthropicCodeExecutionToolResultError? value)
        {
            AnthropicCodeExecutionToolResultError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicCodeExecutionContent(global::OpenRouter.AnthropicCodeExecutionResult value) => new AnthropicCodeExecutionContent((global::OpenRouter.AnthropicCodeExecutionResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCodeExecutionResult?(AnthropicCodeExecutionContent @this) => @this.AnthropicCodeExecutionResult;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicCodeExecutionContent(global::OpenRouter.AnthropicCodeExecutionResult? value)
        {
            AnthropicCodeExecutionResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicCodeExecutionContent(global::OpenRouter.AnthropicEncryptedCodeExecutionResult value) => new AnthropicCodeExecutionContent((global::OpenRouter.AnthropicEncryptedCodeExecutionResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicEncryptedCodeExecutionResult?(AnthropicCodeExecutionContent @this) => @this.AnthropicEncryptedCodeExecutionResult;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicCodeExecutionContent(global::OpenRouter.AnthropicEncryptedCodeExecutionResult? value)
        {
            AnthropicEncryptedCodeExecutionResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicCodeExecutionContent(
            global::OpenRouter.AnthropicCodeExecutionToolResultError? anthropicCodeExecutionToolResultError,
            global::OpenRouter.AnthropicCodeExecutionResult? anthropicCodeExecutionResult,
            global::OpenRouter.AnthropicEncryptedCodeExecutionResult? anthropicEncryptedCodeExecutionResult
            )
        {
            AnthropicCodeExecutionToolResultError = anthropicCodeExecutionToolResultError;
            AnthropicCodeExecutionResult = anthropicCodeExecutionResult;
            AnthropicEncryptedCodeExecutionResult = anthropicEncryptedCodeExecutionResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnthropicEncryptedCodeExecutionResult as object ??
            AnthropicCodeExecutionResult as object ??
            AnthropicCodeExecutionToolResultError as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnthropicCodeExecutionToolResultError?.ToString() ??
            AnthropicCodeExecutionResult?.ToString() ??
            AnthropicEncryptedCodeExecutionResult?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicCodeExecutionToolResultError && !IsAnthropicCodeExecutionResult && !IsAnthropicEncryptedCodeExecutionResult || !IsAnthropicCodeExecutionToolResultError && IsAnthropicCodeExecutionResult && !IsAnthropicEncryptedCodeExecutionResult || !IsAnthropicCodeExecutionToolResultError && !IsAnthropicCodeExecutionResult && IsAnthropicEncryptedCodeExecutionResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicCodeExecutionToolResultError?, TResult>? anthropicCodeExecutionToolResultError = null,
            global::System.Func<global::OpenRouter.AnthropicCodeExecutionResult?, TResult>? anthropicCodeExecutionResult = null,
            global::System.Func<global::OpenRouter.AnthropicEncryptedCodeExecutionResult?, TResult>? anthropicEncryptedCodeExecutionResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicCodeExecutionToolResultError && anthropicCodeExecutionToolResultError != null)
            {
                return anthropicCodeExecutionToolResultError(AnthropicCodeExecutionToolResultError!);
            }
            else if (IsAnthropicCodeExecutionResult && anthropicCodeExecutionResult != null)
            {
                return anthropicCodeExecutionResult(AnthropicCodeExecutionResult!);
            }
            else if (IsAnthropicEncryptedCodeExecutionResult && anthropicEncryptedCodeExecutionResult != null)
            {
                return anthropicEncryptedCodeExecutionResult(AnthropicEncryptedCodeExecutionResult!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicCodeExecutionToolResultError?>? anthropicCodeExecutionToolResultError = null,
            global::System.Action<global::OpenRouter.AnthropicCodeExecutionResult?>? anthropicCodeExecutionResult = null,
            global::System.Action<global::OpenRouter.AnthropicEncryptedCodeExecutionResult?>? anthropicEncryptedCodeExecutionResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicCodeExecutionToolResultError)
            {
                anthropicCodeExecutionToolResultError?.Invoke(AnthropicCodeExecutionToolResultError!);
            }
            else if (IsAnthropicCodeExecutionResult)
            {
                anthropicCodeExecutionResult?.Invoke(AnthropicCodeExecutionResult!);
            }
            else if (IsAnthropicEncryptedCodeExecutionResult)
            {
                anthropicEncryptedCodeExecutionResult?.Invoke(AnthropicEncryptedCodeExecutionResult!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnthropicCodeExecutionToolResultError,
                typeof(global::OpenRouter.AnthropicCodeExecutionToolResultError),
                AnthropicCodeExecutionResult,
                typeof(global::OpenRouter.AnthropicCodeExecutionResult),
                AnthropicEncryptedCodeExecutionResult,
                typeof(global::OpenRouter.AnthropicEncryptedCodeExecutionResult),
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
        public bool Equals(AnthropicCodeExecutionContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCodeExecutionToolResultError?>.Default.Equals(AnthropicCodeExecutionToolResultError, other.AnthropicCodeExecutionToolResultError) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCodeExecutionResult?>.Default.Equals(AnthropicCodeExecutionResult, other.AnthropicCodeExecutionResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicEncryptedCodeExecutionResult?>.Default.Equals(AnthropicEncryptedCodeExecutionResult, other.AnthropicEncryptedCodeExecutionResult) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnthropicCodeExecutionContent obj1, AnthropicCodeExecutionContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicCodeExecutionContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnthropicCodeExecutionContent obj1, AnthropicCodeExecutionContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicCodeExecutionContent o && Equals(o);
        }
    }
}
