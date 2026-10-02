#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"content":[],"return_code":0,"stderr":"","stdout":"Hello","type":"bash_code_execution_result"}
    /// </summary>
    public readonly partial struct AnthropicBashCodeExecutionContent : global::System.IEquatable<AnthropicBashCodeExecutionContent>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionContentDiscriminatorType? Type { get; }

        /// <summary>
        /// Example: {"error_code":"unavailable","type":"bash_code_execution_tool_result_error"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicBashCodeExecutionToolResultError? BashCodeExecutionToolResultError { get; init; }
#else
        public global::OpenRouter.AnthropicBashCodeExecutionToolResultError? BashCodeExecutionToolResultError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BashCodeExecutionToolResultError))]
#endif
        public bool IsBashCodeExecutionToolResultError => BashCodeExecutionToolResultError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBashCodeExecutionToolResultError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicBashCodeExecutionToolResultError? value)
        {
            value = BashCodeExecutionToolResultError;
            return IsBashCodeExecutionToolResultError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionToolResultError PickBashCodeExecutionToolResultError() => BashCodeExecutionToolResultError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BashCodeExecutionToolResultError' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"content":[],"return_code":0,"stderr":"","stdout":"Hello","type":"bash_code_execution_result"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicBashCodeExecutionResult? BashCodeExecutionResult { get; init; }
#else
        public global::OpenRouter.AnthropicBashCodeExecutionResult? BashCodeExecutionResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BashCodeExecutionResult))]
#endif
        public bool IsBashCodeExecutionResult => BashCodeExecutionResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBashCodeExecutionResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicBashCodeExecutionResult? value)
        {
            value = BashCodeExecutionResult;
            return IsBashCodeExecutionResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicBashCodeExecutionResult PickBashCodeExecutionResult() => BashCodeExecutionResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BashCodeExecutionResult' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicBashCodeExecutionContent(global::OpenRouter.AnthropicBashCodeExecutionToolResultError value) => new AnthropicBashCodeExecutionContent((global::OpenRouter.AnthropicBashCodeExecutionToolResultError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicBashCodeExecutionToolResultError?(AnthropicBashCodeExecutionContent @this) => @this.BashCodeExecutionToolResultError;

        /// <summary>
        ///
        /// </summary>
        public AnthropicBashCodeExecutionContent(global::OpenRouter.AnthropicBashCodeExecutionToolResultError? value)
        {
            BashCodeExecutionToolResultError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicBashCodeExecutionContent FromBashCodeExecutionToolResultError(global::OpenRouter.AnthropicBashCodeExecutionToolResultError? value) => new AnthropicBashCodeExecutionContent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicBashCodeExecutionContent(global::OpenRouter.AnthropicBashCodeExecutionResult value) => new AnthropicBashCodeExecutionContent((global::OpenRouter.AnthropicBashCodeExecutionResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicBashCodeExecutionResult?(AnthropicBashCodeExecutionContent @this) => @this.BashCodeExecutionResult;

        /// <summary>
        ///
        /// </summary>
        public AnthropicBashCodeExecutionContent(global::OpenRouter.AnthropicBashCodeExecutionResult? value)
        {
            BashCodeExecutionResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicBashCodeExecutionContent FromBashCodeExecutionResult(global::OpenRouter.AnthropicBashCodeExecutionResult? value) => new AnthropicBashCodeExecutionContent(value);

        /// <summary>
        ///
        /// </summary>
        public AnthropicBashCodeExecutionContent(
            global::OpenRouter.AnthropicBashCodeExecutionContentDiscriminatorType? type,
            global::OpenRouter.AnthropicBashCodeExecutionToolResultError? bashCodeExecutionToolResultError,
            global::OpenRouter.AnthropicBashCodeExecutionResult? bashCodeExecutionResult
            )
        {
            Type = type;

            BashCodeExecutionToolResultError = bashCodeExecutionToolResultError;
            BashCodeExecutionResult = bashCodeExecutionResult;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BashCodeExecutionResult as object ??
            BashCodeExecutionToolResultError as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BashCodeExecutionToolResultError?.ToString() ??
            BashCodeExecutionResult?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBashCodeExecutionToolResultError && !IsBashCodeExecutionResult || !IsBashCodeExecutionToolResultError && IsBashCodeExecutionResult;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicBashCodeExecutionToolResultError, TResult>? bashCodeExecutionToolResultError = null,
            global::System.Func<global::OpenRouter.AnthropicBashCodeExecutionResult, TResult>? bashCodeExecutionResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BashCodeExecutionToolResultError is { } __value0 && bashCodeExecutionToolResultError != null)
            {
                return bashCodeExecutionToolResultError(__value0);
            }
            else if (BashCodeExecutionResult is { } __value1 && bashCodeExecutionResult != null)
            {
                return bashCodeExecutionResult(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicBashCodeExecutionToolResultError>? bashCodeExecutionToolResultError = null,

            global::System.Action<global::OpenRouter.AnthropicBashCodeExecutionResult>? bashCodeExecutionResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BashCodeExecutionToolResultError is { } __value0)
            {
                bashCodeExecutionToolResultError?.Invoke(__value0);
            }
            else if (BashCodeExecutionResult is { } __value1)
            {
                bashCodeExecutionResult?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AnthropicBashCodeExecutionToolResultError>? bashCodeExecutionToolResultError = null,
            global::System.Action<global::OpenRouter.AnthropicBashCodeExecutionResult>? bashCodeExecutionResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BashCodeExecutionToolResultError is { } __value0)
            {
                bashCodeExecutionToolResultError?.Invoke(__value0);
            }
            else if (BashCodeExecutionResult is { } __value1)
            {
                bashCodeExecutionResult?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BashCodeExecutionToolResultError,
                typeof(global::OpenRouter.AnthropicBashCodeExecutionToolResultError),
                BashCodeExecutionResult,
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicBashCodeExecutionToolResultError?>.Default.Equals(BashCodeExecutionToolResultError, other.BashCodeExecutionToolResultError) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicBashCodeExecutionResult?>.Default.Equals(BashCodeExecutionResult, other.BashCodeExecutionResult)
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
