#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"content":[],"return_code":0,"stderr":"","stdout":"Hello","type":"code_execution_result"}
    /// </summary>
    public readonly partial struct AnthropicCodeExecutionContent : global::System.IEquatable<AnthropicCodeExecutionContent>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionContentDiscriminatorType? Type { get; }

        /// <summary>
        /// Example: {"error_code":"unavailable","type":"code_execution_tool_result_error"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCodeExecutionToolResultError? CodeExecutionToolResultError { get; init; }
#else
        public global::OpenRouter.AnthropicCodeExecutionToolResultError? CodeExecutionToolResultError { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeExecutionToolResultError))]
#endif
        public bool IsCodeExecutionToolResultError => CodeExecutionToolResultError != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCodeExecutionToolResultError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicCodeExecutionToolResultError? value)
        {
            value = CodeExecutionToolResultError;
            return IsCodeExecutionToolResultError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionToolResultError PickCodeExecutionToolResultError() => CodeExecutionToolResultError is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeExecutionToolResultError' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"content":[],"return_code":0,"stderr":"","stdout":"Hello","type":"code_execution_result"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCodeExecutionResult? CodeExecutionResult { get; init; }
#else
        public global::OpenRouter.AnthropicCodeExecutionResult? CodeExecutionResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeExecutionResult))]
#endif
        public bool IsCodeExecutionResult => CodeExecutionResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCodeExecutionResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicCodeExecutionResult? value)
        {
            value = CodeExecutionResult;
            return IsCodeExecutionResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCodeExecutionResult PickCodeExecutionResult() => CodeExecutionResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeExecutionResult' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"content":[],"encrypted_stdout":"enc_stdout","return_code":0,"stderr":"","type":"encrypted_code_execution_result"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicEncryptedCodeExecutionResult? EncryptedCodeExecutionResult { get; init; }
#else
        public global::OpenRouter.AnthropicEncryptedCodeExecutionResult? EncryptedCodeExecutionResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EncryptedCodeExecutionResult))]
#endif
        public bool IsEncryptedCodeExecutionResult => EncryptedCodeExecutionResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEncryptedCodeExecutionResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicEncryptedCodeExecutionResult? value)
        {
            value = EncryptedCodeExecutionResult;
            return IsEncryptedCodeExecutionResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicEncryptedCodeExecutionResult PickEncryptedCodeExecutionResult() => EncryptedCodeExecutionResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'EncryptedCodeExecutionResult' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicCodeExecutionContent(global::OpenRouter.AnthropicCodeExecutionToolResultError value) => new AnthropicCodeExecutionContent((global::OpenRouter.AnthropicCodeExecutionToolResultError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCodeExecutionToolResultError?(AnthropicCodeExecutionContent @this) => @this.CodeExecutionToolResultError;

        /// <summary>
        ///
        /// </summary>
        public AnthropicCodeExecutionContent(global::OpenRouter.AnthropicCodeExecutionToolResultError? value)
        {
            CodeExecutionToolResultError = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicCodeExecutionContent FromCodeExecutionToolResultError(global::OpenRouter.AnthropicCodeExecutionToolResultError? value) => new AnthropicCodeExecutionContent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicCodeExecutionContent(global::OpenRouter.AnthropicCodeExecutionResult value) => new AnthropicCodeExecutionContent((global::OpenRouter.AnthropicCodeExecutionResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCodeExecutionResult?(AnthropicCodeExecutionContent @this) => @this.CodeExecutionResult;

        /// <summary>
        ///
        /// </summary>
        public AnthropicCodeExecutionContent(global::OpenRouter.AnthropicCodeExecutionResult? value)
        {
            CodeExecutionResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicCodeExecutionContent FromCodeExecutionResult(global::OpenRouter.AnthropicCodeExecutionResult? value) => new AnthropicCodeExecutionContent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicCodeExecutionContent(global::OpenRouter.AnthropicEncryptedCodeExecutionResult value) => new AnthropicCodeExecutionContent((global::OpenRouter.AnthropicEncryptedCodeExecutionResult?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicEncryptedCodeExecutionResult?(AnthropicCodeExecutionContent @this) => @this.EncryptedCodeExecutionResult;

        /// <summary>
        ///
        /// </summary>
        public AnthropicCodeExecutionContent(global::OpenRouter.AnthropicEncryptedCodeExecutionResult? value)
        {
            EncryptedCodeExecutionResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicCodeExecutionContent FromEncryptedCodeExecutionResult(global::OpenRouter.AnthropicEncryptedCodeExecutionResult? value) => new AnthropicCodeExecutionContent(value);

        /// <summary>
        ///
        /// </summary>
        public AnthropicCodeExecutionContent(
            global::OpenRouter.AnthropicCodeExecutionContentDiscriminatorType? type,
            global::OpenRouter.AnthropicCodeExecutionToolResultError? codeExecutionToolResultError,
            global::OpenRouter.AnthropicCodeExecutionResult? codeExecutionResult,
            global::OpenRouter.AnthropicEncryptedCodeExecutionResult? encryptedCodeExecutionResult
            )
        {
            Type = type;

            CodeExecutionToolResultError = codeExecutionToolResultError;
            CodeExecutionResult = codeExecutionResult;
            EncryptedCodeExecutionResult = encryptedCodeExecutionResult;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            EncryptedCodeExecutionResult as object ??
            CodeExecutionResult as object ??
            CodeExecutionToolResultError as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            CodeExecutionToolResultError?.ToString() ??
            CodeExecutionResult?.ToString() ??
            EncryptedCodeExecutionResult?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCodeExecutionToolResultError && !IsCodeExecutionResult && !IsEncryptedCodeExecutionResult || !IsCodeExecutionToolResultError && IsCodeExecutionResult && !IsEncryptedCodeExecutionResult || !IsCodeExecutionToolResultError && !IsCodeExecutionResult && IsEncryptedCodeExecutionResult;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicCodeExecutionToolResultError, TResult>? codeExecutionToolResultError = null,
            global::System.Func<global::OpenRouter.AnthropicCodeExecutionResult, TResult>? codeExecutionResult = null,
            global::System.Func<global::OpenRouter.AnthropicEncryptedCodeExecutionResult, TResult>? encryptedCodeExecutionResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CodeExecutionToolResultError is { } __value0 && codeExecutionToolResultError != null)
            {
                return codeExecutionToolResultError(__value0);
            }
            else if (CodeExecutionResult is { } __value1 && codeExecutionResult != null)
            {
                return codeExecutionResult(__value1);
            }
            else if (EncryptedCodeExecutionResult is { } __value2 && encryptedCodeExecutionResult != null)
            {
                return encryptedCodeExecutionResult(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicCodeExecutionToolResultError>? codeExecutionToolResultError = null,

            global::System.Action<global::OpenRouter.AnthropicCodeExecutionResult>? codeExecutionResult = null,

            global::System.Action<global::OpenRouter.AnthropicEncryptedCodeExecutionResult>? encryptedCodeExecutionResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CodeExecutionToolResultError is { } __value0)
            {
                codeExecutionToolResultError?.Invoke(__value0);
            }
            else if (CodeExecutionResult is { } __value1)
            {
                codeExecutionResult?.Invoke(__value1);
            }
            else if (EncryptedCodeExecutionResult is { } __value2)
            {
                encryptedCodeExecutionResult?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AnthropicCodeExecutionToolResultError>? codeExecutionToolResultError = null,
            global::System.Action<global::OpenRouter.AnthropicCodeExecutionResult>? codeExecutionResult = null,
            global::System.Action<global::OpenRouter.AnthropicEncryptedCodeExecutionResult>? encryptedCodeExecutionResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CodeExecutionToolResultError is { } __value0)
            {
                codeExecutionToolResultError?.Invoke(__value0);
            }
            else if (CodeExecutionResult is { } __value1)
            {
                codeExecutionResult?.Invoke(__value1);
            }
            else if (EncryptedCodeExecutionResult is { } __value2)
            {
                encryptedCodeExecutionResult?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CodeExecutionToolResultError,
                typeof(global::OpenRouter.AnthropicCodeExecutionToolResultError),
                CodeExecutionResult,
                typeof(global::OpenRouter.AnthropicCodeExecutionResult),
                EncryptedCodeExecutionResult,
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCodeExecutionToolResultError?>.Default.Equals(CodeExecutionToolResultError, other.CodeExecutionToolResultError) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCodeExecutionResult?>.Default.Equals(CodeExecutionResult, other.CodeExecutionResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicEncryptedCodeExecutionResult?>.Default.Equals(EncryptedCodeExecutionResult, other.EncryptedCodeExecutionResult)
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
