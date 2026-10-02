#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"content":"file content","file_type":"text","num_lines":10,"start_line":1,"total_lines":10,"type":"text_editor_code_execution_view_result"}
    /// </summary>
    public readonly partial struct AnthropicTextEditorCodeExecutionContent : global::System.IEquatable<AnthropicTextEditorCodeExecutionContent>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminatorType? Type { get; }

        /// <summary>
        /// Example: {"error_code":"unavailable","error_message":null,"type":"text_editor_code_execution_tool_result_error"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError? TextEditorCodeExecutionToolResultError { get; init; }
#else
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError? TextEditorCodeExecutionToolResultError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextEditorCodeExecutionToolResultError))]
#endif
        public bool IsTextEditorCodeExecutionToolResultError => TextEditorCodeExecutionToolResultError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextEditorCodeExecutionToolResultError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError? value)
        {
            value = TextEditorCodeExecutionToolResultError;
            return IsTextEditorCodeExecutionToolResultError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError PickTextEditorCodeExecutionToolResultError() => TextEditorCodeExecutionToolResultError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextEditorCodeExecutionToolResultError' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"content":"file content","file_type":"text","num_lines":10,"start_line":1,"total_lines":10,"type":"text_editor_code_execution_view_result"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult? TextEditorCodeExecutionViewResult { get; init; }
#else
        public global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult? TextEditorCodeExecutionViewResult { get; }
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
        public bool TryPickTextEditorCodeExecutionViewResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult? value)
        {
            value = TextEditorCodeExecutionViewResult;
            return IsTextEditorCodeExecutionViewResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult PickTextEditorCodeExecutionViewResult() => TextEditorCodeExecutionViewResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextEditorCodeExecutionViewResult' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"is_file_update":false,"type":"text_editor_code_execution_create_result"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult? TextEditorCodeExecutionCreateResult { get; init; }
#else
        public global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult? TextEditorCodeExecutionCreateResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextEditorCodeExecutionCreateResult))]
#endif
        public bool IsTextEditorCodeExecutionCreateResult => TextEditorCodeExecutionCreateResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextEditorCodeExecutionCreateResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult? value)
        {
            value = TextEditorCodeExecutionCreateResult;
            return IsTextEditorCodeExecutionCreateResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult PickTextEditorCodeExecutionCreateResult() => TextEditorCodeExecutionCreateResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextEditorCodeExecutionCreateResult' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"lines":null,"new_lines":null,"new_start":null,"old_lines":null,"old_start":null,"type":"text_editor_code_execution_str_replace_result"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult? TextEditorCodeExecutionStrReplaceResult { get; init; }
#else
        public global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult? TextEditorCodeExecutionStrReplaceResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextEditorCodeExecutionStrReplaceResult))]
#endif
        public bool IsTextEditorCodeExecutionStrReplaceResult => TextEditorCodeExecutionStrReplaceResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextEditorCodeExecutionStrReplaceResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult? value)
        {
            value = TextEditorCodeExecutionStrReplaceResult;
            return IsTextEditorCodeExecutionStrReplaceResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult PickTextEditorCodeExecutionStrReplaceResult() => TextEditorCodeExecutionStrReplaceResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextEditorCodeExecutionStrReplaceResult' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicTextEditorCodeExecutionContent(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError value) => new AnthropicTextEditorCodeExecutionContent((global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError?(AnthropicTextEditorCodeExecutionContent @this) => @this.TextEditorCodeExecutionToolResultError;

        /// <summary>
        ///
        /// </summary>
        public AnthropicTextEditorCodeExecutionContent(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError? value)
        {
            TextEditorCodeExecutionToolResultError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicTextEditorCodeExecutionContent FromTextEditorCodeExecutionToolResultError(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError? value) => new AnthropicTextEditorCodeExecutionContent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicTextEditorCodeExecutionContent(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult value) => new AnthropicTextEditorCodeExecutionContent((global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult?(AnthropicTextEditorCodeExecutionContent @this) => @this.TextEditorCodeExecutionViewResult;

        /// <summary>
        ///
        /// </summary>
        public AnthropicTextEditorCodeExecutionContent(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult? value)
        {
            TextEditorCodeExecutionViewResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicTextEditorCodeExecutionContent FromTextEditorCodeExecutionViewResult(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult? value) => new AnthropicTextEditorCodeExecutionContent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicTextEditorCodeExecutionContent(global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult value) => new AnthropicTextEditorCodeExecutionContent((global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult?(AnthropicTextEditorCodeExecutionContent @this) => @this.TextEditorCodeExecutionCreateResult;

        /// <summary>
        ///
        /// </summary>
        public AnthropicTextEditorCodeExecutionContent(global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult? value)
        {
            TextEditorCodeExecutionCreateResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicTextEditorCodeExecutionContent FromTextEditorCodeExecutionCreateResult(global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult? value) => new AnthropicTextEditorCodeExecutionContent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicTextEditorCodeExecutionContent(global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult value) => new AnthropicTextEditorCodeExecutionContent((global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult?(AnthropicTextEditorCodeExecutionContent @this) => @this.TextEditorCodeExecutionStrReplaceResult;

        /// <summary>
        ///
        /// </summary>
        public AnthropicTextEditorCodeExecutionContent(global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult? value)
        {
            TextEditorCodeExecutionStrReplaceResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicTextEditorCodeExecutionContent FromTextEditorCodeExecutionStrReplaceResult(global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult? value) => new AnthropicTextEditorCodeExecutionContent(value);

        /// <summary>
        ///
        /// </summary>
        public AnthropicTextEditorCodeExecutionContent(
            global::OpenRouter.AnthropicTextEditorCodeExecutionContentDiscriminatorType? type,
            global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError? textEditorCodeExecutionToolResultError,
            global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult? textEditorCodeExecutionViewResult,
            global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult? textEditorCodeExecutionCreateResult,
            global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult? textEditorCodeExecutionStrReplaceResult
            )
        {
            Type = type;

            TextEditorCodeExecutionToolResultError = textEditorCodeExecutionToolResultError;
            TextEditorCodeExecutionViewResult = textEditorCodeExecutionViewResult;
            TextEditorCodeExecutionCreateResult = textEditorCodeExecutionCreateResult;
            TextEditorCodeExecutionStrReplaceResult = textEditorCodeExecutionStrReplaceResult;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            TextEditorCodeExecutionStrReplaceResult as object ??
            TextEditorCodeExecutionCreateResult as object ??
            TextEditorCodeExecutionViewResult as object ??
            TextEditorCodeExecutionToolResultError as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            TextEditorCodeExecutionToolResultError?.ToString() ??
            TextEditorCodeExecutionViewResult?.ToString() ??
            TextEditorCodeExecutionCreateResult?.ToString() ??
            TextEditorCodeExecutionStrReplaceResult?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTextEditorCodeExecutionToolResultError && !IsTextEditorCodeExecutionViewResult && !IsTextEditorCodeExecutionCreateResult && !IsTextEditorCodeExecutionStrReplaceResult || !IsTextEditorCodeExecutionToolResultError && IsTextEditorCodeExecutionViewResult && !IsTextEditorCodeExecutionCreateResult && !IsTextEditorCodeExecutionStrReplaceResult || !IsTextEditorCodeExecutionToolResultError && !IsTextEditorCodeExecutionViewResult && IsTextEditorCodeExecutionCreateResult && !IsTextEditorCodeExecutionStrReplaceResult || !IsTextEditorCodeExecutionToolResultError && !IsTextEditorCodeExecutionViewResult && !IsTextEditorCodeExecutionCreateResult && IsTextEditorCodeExecutionStrReplaceResult;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError, TResult>? textEditorCodeExecutionToolResultError = null,
            global::System.Func<global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult, TResult>? textEditorCodeExecutionViewResult = null,
            global::System.Func<global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult, TResult>? textEditorCodeExecutionCreateResult = null,
            global::System.Func<global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult, TResult>? textEditorCodeExecutionStrReplaceResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TextEditorCodeExecutionToolResultError is { } __value0 && textEditorCodeExecutionToolResultError != null)
            {
                return textEditorCodeExecutionToolResultError(__value0);
            }
            else if (TextEditorCodeExecutionViewResult is { } __value1 && textEditorCodeExecutionViewResult != null)
            {
                return textEditorCodeExecutionViewResult(__value1);
            }
            else if (TextEditorCodeExecutionCreateResult is { } __value2 && textEditorCodeExecutionCreateResult != null)
            {
                return textEditorCodeExecutionCreateResult(__value2);
            }
            else if (TextEditorCodeExecutionStrReplaceResult is { } __value3 && textEditorCodeExecutionStrReplaceResult != null)
            {
                return textEditorCodeExecutionStrReplaceResult(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError>? textEditorCodeExecutionToolResultError = null,

            global::System.Action<global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult>? textEditorCodeExecutionViewResult = null,

            global::System.Action<global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult>? textEditorCodeExecutionCreateResult = null,

            global::System.Action<global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult>? textEditorCodeExecutionStrReplaceResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TextEditorCodeExecutionToolResultError is { } __value0)
            {
                textEditorCodeExecutionToolResultError?.Invoke(__value0);
            }
            else if (TextEditorCodeExecutionViewResult is { } __value1)
            {
                textEditorCodeExecutionViewResult?.Invoke(__value1);
            }
            else if (TextEditorCodeExecutionCreateResult is { } __value2)
            {
                textEditorCodeExecutionCreateResult?.Invoke(__value2);
            }
            else if (TextEditorCodeExecutionStrReplaceResult is { } __value3)
            {
                textEditorCodeExecutionStrReplaceResult?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError>? textEditorCodeExecutionToolResultError = null,
            global::System.Action<global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult>? textEditorCodeExecutionViewResult = null,
            global::System.Action<global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult>? textEditorCodeExecutionCreateResult = null,
            global::System.Action<global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult>? textEditorCodeExecutionStrReplaceResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TextEditorCodeExecutionToolResultError is { } __value0)
            {
                textEditorCodeExecutionToolResultError?.Invoke(__value0);
            }
            else if (TextEditorCodeExecutionViewResult is { } __value1)
            {
                textEditorCodeExecutionViewResult?.Invoke(__value1);
            }
            else if (TextEditorCodeExecutionCreateResult is { } __value2)
            {
                textEditorCodeExecutionCreateResult?.Invoke(__value2);
            }
            else if (TextEditorCodeExecutionStrReplaceResult is { } __value3)
            {
                textEditorCodeExecutionStrReplaceResult?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextEditorCodeExecutionToolResultError,
                typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError),
                TextEditorCodeExecutionViewResult,
                typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult),
                TextEditorCodeExecutionCreateResult,
                typeof(global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult),
                TextEditorCodeExecutionStrReplaceResult,
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextEditorCodeExecutionToolResultError?>.Default.Equals(TextEditorCodeExecutionToolResultError, other.TextEditorCodeExecutionToolResultError) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextEditorCodeExecutionViewResult?>.Default.Equals(TextEditorCodeExecutionViewResult, other.TextEditorCodeExecutionViewResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextEditorCodeExecutionCreateResult?>.Default.Equals(TextEditorCodeExecutionCreateResult, other.TextEditorCodeExecutionCreateResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextEditorCodeExecutionStrReplaceResult?>.Default.Equals(TextEditorCodeExecutionStrReplaceResult, other.TextEditorCodeExecutionStrReplaceResult)
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
