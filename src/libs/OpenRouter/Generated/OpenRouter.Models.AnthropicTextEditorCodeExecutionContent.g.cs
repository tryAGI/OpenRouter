#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AnthropicTextEditorCodeExecutionContent : global::System.IEquatable<AnthropicTextEditorCodeExecutionContent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError? AnthropicTextEditorCodeExecutionToolResultError { get; init; }
#else
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError? AnthropicTextEditorCodeExecutionToolResultError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicTextEditorCodeExecutionToolResultError))]
#endif
        public bool IsAnthropicTextEditorCodeExecutionToolResultError => AnthropicTextEditorCodeExecutionToolResultError != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult? AnthropicTextEditorCodeExecutionViewResult { get; init; }
#else
        public global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult? AnthropicTextEditorCodeExecutionViewResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicTextEditorCodeExecutionViewResult))]
#endif
        public bool IsAnthropicTextEditorCodeExecutionViewResult => AnthropicTextEditorCodeExecutionViewResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult? AnthropicTextEditorCodeExecutionCreateResult { get; init; }
#else
        public global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult? AnthropicTextEditorCodeExecutionCreateResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicTextEditorCodeExecutionCreateResult))]
#endif
        public bool IsAnthropicTextEditorCodeExecutionCreateResult => AnthropicTextEditorCodeExecutionCreateResult != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult? AnthropicTextEditorCodeExecutionStrReplaceResult { get; init; }
#else
        public global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult? AnthropicTextEditorCodeExecutionStrReplaceResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicTextEditorCodeExecutionStrReplaceResult))]
#endif
        public bool IsAnthropicTextEditorCodeExecutionStrReplaceResult => AnthropicTextEditorCodeExecutionStrReplaceResult != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicTextEditorCodeExecutionContent(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError value) => new AnthropicTextEditorCodeExecutionContent((global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError?(AnthropicTextEditorCodeExecutionContent @this) => @this.AnthropicTextEditorCodeExecutionToolResultError;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextEditorCodeExecutionContent(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError? value)
        {
            AnthropicTextEditorCodeExecutionToolResultError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicTextEditorCodeExecutionContent(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult value) => new AnthropicTextEditorCodeExecutionContent((global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult?(AnthropicTextEditorCodeExecutionContent @this) => @this.AnthropicTextEditorCodeExecutionViewResult;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextEditorCodeExecutionContent(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult? value)
        {
            AnthropicTextEditorCodeExecutionViewResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicTextEditorCodeExecutionContent(global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult value) => new AnthropicTextEditorCodeExecutionContent((global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult?(AnthropicTextEditorCodeExecutionContent @this) => @this.AnthropicTextEditorCodeExecutionCreateResult;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextEditorCodeExecutionContent(global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult? value)
        {
            AnthropicTextEditorCodeExecutionCreateResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicTextEditorCodeExecutionContent(global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult value) => new AnthropicTextEditorCodeExecutionContent((global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult?(AnthropicTextEditorCodeExecutionContent @this) => @this.AnthropicTextEditorCodeExecutionStrReplaceResult;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextEditorCodeExecutionContent(global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult? value)
        {
            AnthropicTextEditorCodeExecutionStrReplaceResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextEditorCodeExecutionContent(
            global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError? anthropicTextEditorCodeExecutionToolResultError,
            global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult? anthropicTextEditorCodeExecutionViewResult,
            global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult? anthropicTextEditorCodeExecutionCreateResult,
            global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult? anthropicTextEditorCodeExecutionStrReplaceResult
            )
        {
            AnthropicTextEditorCodeExecutionToolResultError = anthropicTextEditorCodeExecutionToolResultError;
            AnthropicTextEditorCodeExecutionViewResult = anthropicTextEditorCodeExecutionViewResult;
            AnthropicTextEditorCodeExecutionCreateResult = anthropicTextEditorCodeExecutionCreateResult;
            AnthropicTextEditorCodeExecutionStrReplaceResult = anthropicTextEditorCodeExecutionStrReplaceResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnthropicTextEditorCodeExecutionStrReplaceResult as object ??
            AnthropicTextEditorCodeExecutionCreateResult as object ??
            AnthropicTextEditorCodeExecutionViewResult as object ??
            AnthropicTextEditorCodeExecutionToolResultError as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnthropicTextEditorCodeExecutionToolResultError?.ToString() ??
            AnthropicTextEditorCodeExecutionViewResult?.ToString() ??
            AnthropicTextEditorCodeExecutionCreateResult?.ToString() ??
            AnthropicTextEditorCodeExecutionStrReplaceResult?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicTextEditorCodeExecutionToolResultError && !IsAnthropicTextEditorCodeExecutionViewResult && !IsAnthropicTextEditorCodeExecutionCreateResult && !IsAnthropicTextEditorCodeExecutionStrReplaceResult || !IsAnthropicTextEditorCodeExecutionToolResultError && IsAnthropicTextEditorCodeExecutionViewResult && !IsAnthropicTextEditorCodeExecutionCreateResult && !IsAnthropicTextEditorCodeExecutionStrReplaceResult || !IsAnthropicTextEditorCodeExecutionToolResultError && !IsAnthropicTextEditorCodeExecutionViewResult && IsAnthropicTextEditorCodeExecutionCreateResult && !IsAnthropicTextEditorCodeExecutionStrReplaceResult || !IsAnthropicTextEditorCodeExecutionToolResultError && !IsAnthropicTextEditorCodeExecutionViewResult && !IsAnthropicTextEditorCodeExecutionCreateResult && IsAnthropicTextEditorCodeExecutionStrReplaceResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError?, TResult>? anthropicTextEditorCodeExecutionToolResultError = null,
            global::System.Func<global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult?, TResult>? anthropicTextEditorCodeExecutionViewResult = null,
            global::System.Func<global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult?, TResult>? anthropicTextEditorCodeExecutionCreateResult = null,
            global::System.Func<global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult?, TResult>? anthropicTextEditorCodeExecutionStrReplaceResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicTextEditorCodeExecutionToolResultError && anthropicTextEditorCodeExecutionToolResultError != null)
            {
                return anthropicTextEditorCodeExecutionToolResultError(AnthropicTextEditorCodeExecutionToolResultError!);
            }
            else if (IsAnthropicTextEditorCodeExecutionViewResult && anthropicTextEditorCodeExecutionViewResult != null)
            {
                return anthropicTextEditorCodeExecutionViewResult(AnthropicTextEditorCodeExecutionViewResult!);
            }
            else if (IsAnthropicTextEditorCodeExecutionCreateResult && anthropicTextEditorCodeExecutionCreateResult != null)
            {
                return anthropicTextEditorCodeExecutionCreateResult(AnthropicTextEditorCodeExecutionCreateResult!);
            }
            else if (IsAnthropicTextEditorCodeExecutionStrReplaceResult && anthropicTextEditorCodeExecutionStrReplaceResult != null)
            {
                return anthropicTextEditorCodeExecutionStrReplaceResult(AnthropicTextEditorCodeExecutionStrReplaceResult!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError?>? anthropicTextEditorCodeExecutionToolResultError = null,
            global::System.Action<global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult?>? anthropicTextEditorCodeExecutionViewResult = null,
            global::System.Action<global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult?>? anthropicTextEditorCodeExecutionCreateResult = null,
            global::System.Action<global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult?>? anthropicTextEditorCodeExecutionStrReplaceResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicTextEditorCodeExecutionToolResultError)
            {
                anthropicTextEditorCodeExecutionToolResultError?.Invoke(AnthropicTextEditorCodeExecutionToolResultError!);
            }
            else if (IsAnthropicTextEditorCodeExecutionViewResult)
            {
                anthropicTextEditorCodeExecutionViewResult?.Invoke(AnthropicTextEditorCodeExecutionViewResult!);
            }
            else if (IsAnthropicTextEditorCodeExecutionCreateResult)
            {
                anthropicTextEditorCodeExecutionCreateResult?.Invoke(AnthropicTextEditorCodeExecutionCreateResult!);
            }
            else if (IsAnthropicTextEditorCodeExecutionStrReplaceResult)
            {
                anthropicTextEditorCodeExecutionStrReplaceResult?.Invoke(AnthropicTextEditorCodeExecutionStrReplaceResult!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnthropicTextEditorCodeExecutionToolResultError,
                typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError),
                AnthropicTextEditorCodeExecutionViewResult,
                typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult),
                AnthropicTextEditorCodeExecutionCreateResult,
                typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult),
                AnthropicTextEditorCodeExecutionStrReplaceResult,
                typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult),
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
        public bool Equals(AnthropicTextEditorCodeExecutionContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError?>.Default.Equals(AnthropicTextEditorCodeExecutionToolResultError, other.AnthropicTextEditorCodeExecutionToolResultError) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult?>.Default.Equals(AnthropicTextEditorCodeExecutionViewResult, other.AnthropicTextEditorCodeExecutionViewResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult?>.Default.Equals(AnthropicTextEditorCodeExecutionCreateResult, other.AnthropicTextEditorCodeExecutionCreateResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult?>.Default.Equals(AnthropicTextEditorCodeExecutionStrReplaceResult, other.AnthropicTextEditorCodeExecutionStrReplaceResult) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AnthropicTextEditorCodeExecutionContent obj1, AnthropicTextEditorCodeExecutionContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicTextEditorCodeExecutionContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AnthropicTextEditorCodeExecutionContent obj1, AnthropicTextEditorCodeExecutionContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicTextEditorCodeExecutionContent o && Equals(o);
        }
    }
}
