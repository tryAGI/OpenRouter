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
        /// text_editor_code_execution_create_result variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant1? TextEditorCodeExecutionCreateResult { get; init; }
#else
        public global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant1? TextEditorCodeExecutionCreateResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextEditorCodeExecutionCreateResult))]
#endif
        public bool IsTextEditorCodeExecutionCreateResult => TextEditorCodeExecutionCreateResult != null;

        /// <summary>
        /// text_editor_code_execution_str_replace_result variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant2? TextEditorCodeExecutionStrReplaceResult { get; init; }
#else
        public global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant2? TextEditorCodeExecutionStrReplaceResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextEditorCodeExecutionStrReplaceResult))]
#endif
        public bool IsTextEditorCodeExecutionStrReplaceResult => TextEditorCodeExecutionStrReplaceResult != null;

        /// <summary>
        /// text_editor_code_execution_tool_result_error variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant3? TextEditorCodeExecutionToolResultError { get; init; }
#else
        public global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant3? TextEditorCodeExecutionToolResultError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextEditorCodeExecutionToolResultError))]
#endif
        public bool IsTextEditorCodeExecutionToolResultError => TextEditorCodeExecutionToolResultError != null;

        /// <summary>
        /// text_editor_code_execution_view_result variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant4? TextEditorCodeExecutionViewResult { get; init; }
#else
        public global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant4? TextEditorCodeExecutionViewResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextEditorCodeExecutionViewResult))]
#endif
        public bool IsTextEditorCodeExecutionViewResult => TextEditorCodeExecutionViewResult != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicTextEditorCodeExecutionContent(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant1 value) => new AnthropicTextEditorCodeExecutionContent((global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant1?(AnthropicTextEditorCodeExecutionContent @this) => @this.TextEditorCodeExecutionCreateResult;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextEditorCodeExecutionContent(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant1? value)
        {
            TextEditorCodeExecutionCreateResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicTextEditorCodeExecutionContent(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant2 value) => new AnthropicTextEditorCodeExecutionContent((global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant2?(AnthropicTextEditorCodeExecutionContent @this) => @this.TextEditorCodeExecutionStrReplaceResult;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextEditorCodeExecutionContent(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant2? value)
        {
            TextEditorCodeExecutionStrReplaceResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicTextEditorCodeExecutionContent(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant3 value) => new AnthropicTextEditorCodeExecutionContent((global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant3?(AnthropicTextEditorCodeExecutionContent @this) => @this.TextEditorCodeExecutionToolResultError;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextEditorCodeExecutionContent(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant3? value)
        {
            TextEditorCodeExecutionToolResultError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicTextEditorCodeExecutionContent(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant4 value) => new AnthropicTextEditorCodeExecutionContent((global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant4?(AnthropicTextEditorCodeExecutionContent @this) => @this.TextEditorCodeExecutionViewResult;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextEditorCodeExecutionContent(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant4? value)
        {
            TextEditorCodeExecutionViewResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicTextEditorCodeExecutionContent(
            global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant1? textEditorCodeExecutionCreateResult,
            global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant2? textEditorCodeExecutionStrReplaceResult,
            global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant3? textEditorCodeExecutionToolResultError,
            global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant4? textEditorCodeExecutionViewResult
            )
        {
            TextEditorCodeExecutionCreateResult = textEditorCodeExecutionCreateResult;
            TextEditorCodeExecutionStrReplaceResult = textEditorCodeExecutionStrReplaceResult;
            TextEditorCodeExecutionToolResultError = textEditorCodeExecutionToolResultError;
            TextEditorCodeExecutionViewResult = textEditorCodeExecutionViewResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TextEditorCodeExecutionViewResult as object ??
            TextEditorCodeExecutionToolResultError as object ??
            TextEditorCodeExecutionStrReplaceResult as object ??
            TextEditorCodeExecutionCreateResult as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextEditorCodeExecutionCreateResult?.ToString() ??
            TextEditorCodeExecutionStrReplaceResult?.ToString() ??
            TextEditorCodeExecutionToolResultError?.ToString() ??
            TextEditorCodeExecutionViewResult?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextEditorCodeExecutionCreateResult && !IsTextEditorCodeExecutionStrReplaceResult && !IsTextEditorCodeExecutionToolResultError && !IsTextEditorCodeExecutionViewResult || !IsTextEditorCodeExecutionCreateResult && IsTextEditorCodeExecutionStrReplaceResult && !IsTextEditorCodeExecutionToolResultError && !IsTextEditorCodeExecutionViewResult || !IsTextEditorCodeExecutionCreateResult && !IsTextEditorCodeExecutionStrReplaceResult && IsTextEditorCodeExecutionToolResultError && !IsTextEditorCodeExecutionViewResult || !IsTextEditorCodeExecutionCreateResult && !IsTextEditorCodeExecutionStrReplaceResult && !IsTextEditorCodeExecutionToolResultError && IsTextEditorCodeExecutionViewResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant1?, TResult>? textEditorCodeExecutionCreateResult = null,
            global::System.Func<global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant2?, TResult>? textEditorCodeExecutionStrReplaceResult = null,
            global::System.Func<global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant3?, TResult>? textEditorCodeExecutionToolResultError = null,
            global::System.Func<global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant4?, TResult>? textEditorCodeExecutionViewResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextEditorCodeExecutionCreateResult && textEditorCodeExecutionCreateResult != null)
            {
                return textEditorCodeExecutionCreateResult(TextEditorCodeExecutionCreateResult!);
            }
            else if (IsTextEditorCodeExecutionStrReplaceResult && textEditorCodeExecutionStrReplaceResult != null)
            {
                return textEditorCodeExecutionStrReplaceResult(TextEditorCodeExecutionStrReplaceResult!);
            }
            else if (IsTextEditorCodeExecutionToolResultError && textEditorCodeExecutionToolResultError != null)
            {
                return textEditorCodeExecutionToolResultError(TextEditorCodeExecutionToolResultError!);
            }
            else if (IsTextEditorCodeExecutionViewResult && textEditorCodeExecutionViewResult != null)
            {
                return textEditorCodeExecutionViewResult(TextEditorCodeExecutionViewResult!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant1?>? textEditorCodeExecutionCreateResult = null,
            global::System.Action<global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant2?>? textEditorCodeExecutionStrReplaceResult = null,
            global::System.Action<global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant3?>? textEditorCodeExecutionToolResultError = null,
            global::System.Action<global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant4?>? textEditorCodeExecutionViewResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextEditorCodeExecutionCreateResult)
            {
                textEditorCodeExecutionCreateResult?.Invoke(TextEditorCodeExecutionCreateResult!);
            }
            else if (IsTextEditorCodeExecutionStrReplaceResult)
            {
                textEditorCodeExecutionStrReplaceResult?.Invoke(TextEditorCodeExecutionStrReplaceResult!);
            }
            else if (IsTextEditorCodeExecutionToolResultError)
            {
                textEditorCodeExecutionToolResultError?.Invoke(TextEditorCodeExecutionToolResultError!);
            }
            else if (IsTextEditorCodeExecutionViewResult)
            {
                textEditorCodeExecutionViewResult?.Invoke(TextEditorCodeExecutionViewResult!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextEditorCodeExecutionCreateResult,
                typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant1),
                TextEditorCodeExecutionStrReplaceResult,
                typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant2),
                TextEditorCodeExecutionToolResultError,
                typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant3),
                TextEditorCodeExecutionViewResult,
                typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant4),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant1?>.Default.Equals(TextEditorCodeExecutionCreateResult, other.TextEditorCodeExecutionCreateResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant2?>.Default.Equals(TextEditorCodeExecutionStrReplaceResult, other.TextEditorCodeExecutionStrReplaceResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant3?>.Default.Equals(TextEditorCodeExecutionToolResultError, other.TextEditorCodeExecutionToolResultError) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextEditorCodeExecutionContentVariant4?>.Default.Equals(TextEditorCodeExecutionViewResult, other.TextEditorCodeExecutionViewResult) 
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
