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
        public global::OpenRouter.AnthropicCodeExecutionContentDiscriminatorType? Type { get; }

        /// <summary>
        /// code_execution_result variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCodeExecutionContentVariant1? CodeExecutionResult { get; init; }
#else
        public global::OpenRouter.AnthropicCodeExecutionContentVariant1? CodeExecutionResult { get; }
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
            out global::OpenRouter.AnthropicCodeExecutionContentVariant1? value)
        {
            value = CodeExecutionResult;
            return IsCodeExecutionResult;
        }

        /// <summary>
        /// code_execution_tool_result_error variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCodeExecutionContentVariant2? CodeExecutionToolResultError { get; init; }
#else
        public global::OpenRouter.AnthropicCodeExecutionContentVariant2? CodeExecutionToolResultError { get; }
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
            out global::OpenRouter.AnthropicCodeExecutionContentVariant2? value)
        {
            value = CodeExecutionToolResultError;
            return IsCodeExecutionToolResultError;
        }

        /// <summary>
        /// encrypted_code_execution_result variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCodeExecutionContentVariant3? EncryptedCodeExecutionResult { get; init; }
#else
        public global::OpenRouter.AnthropicCodeExecutionContentVariant3? EncryptedCodeExecutionResult { get; }
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
            out global::OpenRouter.AnthropicCodeExecutionContentVariant3? value)
        {
            value = EncryptedCodeExecutionResult;
            return IsEncryptedCodeExecutionResult;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicCodeExecutionContent(global::OpenRouter.AnthropicCodeExecutionContentVariant1 value) => new AnthropicCodeExecutionContent((global::OpenRouter.AnthropicCodeExecutionContentVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCodeExecutionContentVariant1?(AnthropicCodeExecutionContent @this) => @this.CodeExecutionResult;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicCodeExecutionContent(global::OpenRouter.AnthropicCodeExecutionContentVariant1? value)
        {
            CodeExecutionResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicCodeExecutionContent(global::OpenRouter.AnthropicCodeExecutionContentVariant2 value) => new AnthropicCodeExecutionContent((global::OpenRouter.AnthropicCodeExecutionContentVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCodeExecutionContentVariant2?(AnthropicCodeExecutionContent @this) => @this.CodeExecutionToolResultError;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicCodeExecutionContent(global::OpenRouter.AnthropicCodeExecutionContentVariant2? value)
        {
            CodeExecutionToolResultError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AnthropicCodeExecutionContent(global::OpenRouter.AnthropicCodeExecutionContentVariant3 value) => new AnthropicCodeExecutionContent((global::OpenRouter.AnthropicCodeExecutionContentVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCodeExecutionContentVariant3?(AnthropicCodeExecutionContent @this) => @this.EncryptedCodeExecutionResult;

        /// <summary>
        /// 
        /// </summary>
        public AnthropicCodeExecutionContent(global::OpenRouter.AnthropicCodeExecutionContentVariant3? value)
        {
            EncryptedCodeExecutionResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicCodeExecutionContent(
            global::OpenRouter.AnthropicCodeExecutionContentDiscriminatorType? type,
            global::OpenRouter.AnthropicCodeExecutionContentVariant1? codeExecutionResult,
            global::OpenRouter.AnthropicCodeExecutionContentVariant2? codeExecutionToolResultError,
            global::OpenRouter.AnthropicCodeExecutionContentVariant3? encryptedCodeExecutionResult
            )
        {
            Type = type;

            CodeExecutionResult = codeExecutionResult;
            CodeExecutionToolResultError = codeExecutionToolResultError;
            EncryptedCodeExecutionResult = encryptedCodeExecutionResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EncryptedCodeExecutionResult as object ??
            CodeExecutionToolResultError as object ??
            CodeExecutionResult as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CodeExecutionResult?.ToString() ??
            CodeExecutionToolResultError?.ToString() ??
            EncryptedCodeExecutionResult?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCodeExecutionResult && !IsCodeExecutionToolResultError && !IsEncryptedCodeExecutionResult || !IsCodeExecutionResult && IsCodeExecutionToolResultError && !IsEncryptedCodeExecutionResult || !IsCodeExecutionResult && !IsCodeExecutionToolResultError && IsEncryptedCodeExecutionResult;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicCodeExecutionContentVariant1, TResult>? codeExecutionResult = null,
            global::System.Func<global::OpenRouter.AnthropicCodeExecutionContentVariant2, TResult>? codeExecutionToolResultError = null,
            global::System.Func<global::OpenRouter.AnthropicCodeExecutionContentVariant3, TResult>? encryptedCodeExecutionResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCodeExecutionResult && codeExecutionResult != null)
            {
                return codeExecutionResult(CodeExecutionResult!);
            }
            else if (IsCodeExecutionToolResultError && codeExecutionToolResultError != null)
            {
                return codeExecutionToolResultError(CodeExecutionToolResultError!);
            }
            else if (IsEncryptedCodeExecutionResult && encryptedCodeExecutionResult != null)
            {
                return encryptedCodeExecutionResult(EncryptedCodeExecutionResult!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicCodeExecutionContentVariant1>? codeExecutionResult = null,

            global::System.Action<global::OpenRouter.AnthropicCodeExecutionContentVariant2>? codeExecutionToolResultError = null,

            global::System.Action<global::OpenRouter.AnthropicCodeExecutionContentVariant3>? encryptedCodeExecutionResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCodeExecutionResult)
            {
                codeExecutionResult?.Invoke(CodeExecutionResult!);
            }
            else if (IsCodeExecutionToolResultError)
            {
                codeExecutionToolResultError?.Invoke(CodeExecutionToolResultError!);
            }
            else if (IsEncryptedCodeExecutionResult)
            {
                encryptedCodeExecutionResult?.Invoke(EncryptedCodeExecutionResult!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AnthropicCodeExecutionContentVariant1>? codeExecutionResult = null,
            global::System.Action<global::OpenRouter.AnthropicCodeExecutionContentVariant2>? codeExecutionToolResultError = null,
            global::System.Action<global::OpenRouter.AnthropicCodeExecutionContentVariant3>? encryptedCodeExecutionResult = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCodeExecutionResult)
            {
                codeExecutionResult?.Invoke(CodeExecutionResult!);
            }
            else if (IsCodeExecutionToolResultError)
            {
                codeExecutionToolResultError?.Invoke(CodeExecutionToolResultError!);
            }
            else if (IsEncryptedCodeExecutionResult)
            {
                encryptedCodeExecutionResult?.Invoke(EncryptedCodeExecutionResult!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CodeExecutionResult,
                typeof(global::OpenRouter.AnthropicCodeExecutionContentVariant1),
                CodeExecutionToolResultError,
                typeof(global::OpenRouter.AnthropicCodeExecutionContentVariant2),
                EncryptedCodeExecutionResult,
                typeof(global::OpenRouter.AnthropicCodeExecutionContentVariant3),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCodeExecutionContentVariant1?>.Default.Equals(CodeExecutionResult, other.CodeExecutionResult) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCodeExecutionContentVariant2?>.Default.Equals(CodeExecutionToolResultError, other.CodeExecutionToolResultError) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCodeExecutionContentVariant3?>.Default.Equals(EncryptedCodeExecutionResult, other.EncryptedCodeExecutionResult) 
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
