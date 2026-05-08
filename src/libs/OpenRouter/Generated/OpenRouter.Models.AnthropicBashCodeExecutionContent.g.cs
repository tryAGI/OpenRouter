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
        /// bash_code_execution_result variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicBashCodeExecutionContentVariant1? BashCodeExecutionResult { get; init; }
#else
        public global::OpenRouter.AnthropicBashCodeExecutionContentVariant1? BashCodeExecutionResult { get; }
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
            out global::OpenRouter.AnthropicBashCodeExecutionContentVariant1? value)
        {
            value = BashCodeExecutionResult;
            return IsBashCodeExecutionResult;
        }

        /// <summary>
        /// bash_code_execution_tool_result_error variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicBashCodeExecutionContentVariant2? BashCodeExecutionToolResultError { get; init; }
#else
        public global::OpenRouter.AnthropicBashCodeExecutionContentVariant2? BashCodeExecutionToolResultError { get; }
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
            out global::OpenRouter.AnthropicBashCodeExecutionContentVariant2? value)
        {
            value = BashCodeExecutionToolResultError;
            return IsBashCodeExecutionToolResultError;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicBashCodeExecutionContent(global::OpenRouter.AnthropicBashCodeExecutionContentVariant1 value) => new AnthropicBashCodeExecutionContent((global::OpenRouter.AnthropicBashCodeExecutionContentVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicBashCodeExecutionContentVariant1?(AnthropicBashCodeExecutionContent @this) => @this.BashCodeExecutionResult;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicBashCodeExecutionContent(global::OpenRouter.AnthropicBashCodeExecutionContentVariant1? value)
        {
            BashCodeExecutionResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicBashCodeExecutionContent(global::OpenRouter.AnthropicBashCodeExecutionContentVariant2 value) => new AnthropicBashCodeExecutionContent((global::OpenRouter.AnthropicBashCodeExecutionContentVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicBashCodeExecutionContentVariant2?(AnthropicBashCodeExecutionContent @this) => @this.BashCodeExecutionToolResultError;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicBashCodeExecutionContent(global::OpenRouter.AnthropicBashCodeExecutionContentVariant2? value)
        {
            BashCodeExecutionToolResultError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicBashCodeExecutionContent(
            global::OpenRouter.AnthropicBashCodeExecutionContentVariant1? bashCodeExecutionResult,
            global::OpenRouter.AnthropicBashCodeExecutionContentVariant2? bashCodeExecutionToolResultError
            )
        {
            BashCodeExecutionResult = bashCodeExecutionResult;
            BashCodeExecutionToolResultError = bashCodeExecutionToolResultError;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BashCodeExecutionToolResultError as object ??
            BashCodeExecutionResult as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BashCodeExecutionResult?.ToString() ??
            BashCodeExecutionToolResultError?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBashCodeExecutionResult && !IsBashCodeExecutionToolResultError || !IsBashCodeExecutionResult && IsBashCodeExecutionToolResultError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicBashCodeExecutionContentVariant1, TResult>? bashCodeExecutionResult = null,
            global::System.Func<global::OpenRouter.AnthropicBashCodeExecutionContentVariant2, TResult>? bashCodeExecutionToolResultError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBashCodeExecutionResult && bashCodeExecutionResult != null)
            {
                return bashCodeExecutionResult(BashCodeExecutionResult!);
            }
            else if (IsBashCodeExecutionToolResultError && bashCodeExecutionToolResultError != null)
            {
                return bashCodeExecutionToolResultError(BashCodeExecutionToolResultError!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicBashCodeExecutionContentVariant1>? bashCodeExecutionResult = null,

            global::System.Action<global::OpenRouter.AnthropicBashCodeExecutionContentVariant2>? bashCodeExecutionToolResultError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBashCodeExecutionResult)
            {
                bashCodeExecutionResult?.Invoke(BashCodeExecutionResult!);
            }
            else if (IsBashCodeExecutionToolResultError)
            {
                bashCodeExecutionToolResultError?.Invoke(BashCodeExecutionToolResultError!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AnthropicBashCodeExecutionContentVariant1>? bashCodeExecutionResult = null,
            global::System.Action<global::OpenRouter.AnthropicBashCodeExecutionContentVariant2>? bashCodeExecutionToolResultError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBashCodeExecutionResult)
            {
                bashCodeExecutionResult?.Invoke(BashCodeExecutionResult!);
            }
            else if (IsBashCodeExecutionToolResultError)
            {
                bashCodeExecutionToolResultError?.Invoke(BashCodeExecutionToolResultError!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BashCodeExecutionResult,
                typeof(global::OpenRouter.AnthropicBashCodeExecutionContentVariant1),
                BashCodeExecutionToolResultError,
                typeof(global::OpenRouter.AnthropicBashCodeExecutionContentVariant2),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicBashCodeExecutionContentVariant1?>.Default.Equals(BashCodeExecutionResult, other.BashCodeExecutionResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicBashCodeExecutionContentVariant2?>.Default.Equals(BashCodeExecutionToolResultError, other.BashCodeExecutionToolResultError) 
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
