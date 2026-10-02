#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Code interpreter call in progress<br/>
    /// Example: {"item_id":"ci-abc123","output_index":0,"sequence_number":2,"type":"response.code_interpreter_call.in_progress"}
    /// </summary>
    public readonly partial struct CodeInterpreterCallInProgressEvent : global::System.IEquatable<CodeInterpreterCallInProgressEvent>
    {
        /// <summary>
        /// Example: {"item_id":"ci_abc123","output_index":0,"sequence_number":1,"type":"response.code_interpreter_call.in_progress"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallInProgress? OpenAIResponses { get; init; }
#else
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallInProgress? OpenAIResponses { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIResponses))]
#endif
        public bool IsOpenAIResponses => OpenAIResponses != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenAIResponses(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenAIResponsesCodeInterpreterCallInProgress? value)
        {
            value = OpenAIResponses;
            return IsOpenAIResponses;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallInProgress PickOpenAIResponses() => OpenAIResponses is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAIResponses' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? CodeInterpreterCallInProgressEventVariant2 { get; init; }
#else
        public object? CodeInterpreterCallInProgressEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterCallInProgressEventVariant2))]
#endif
        public bool IsCodeInterpreterCallInProgressEventVariant2 => CodeInterpreterCallInProgressEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCodeInterpreterCallInProgressEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = CodeInterpreterCallInProgressEventVariant2;
            return IsCodeInterpreterCallInProgressEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickCodeInterpreterCallInProgressEventVariant2() => CodeInterpreterCallInProgressEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeInterpreterCallInProgressEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CodeInterpreterCallInProgressEvent(global::OpenRouter.OpenAIResponsesCodeInterpreterCallInProgress value) => new CodeInterpreterCallInProgressEvent((global::OpenRouter.OpenAIResponsesCodeInterpreterCallInProgress?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAIResponsesCodeInterpreterCallInProgress?(CodeInterpreterCallInProgressEvent @this) => @this.OpenAIResponses;

        /// <summary>
        ///
        /// </summary>
        public CodeInterpreterCallInProgressEvent(global::OpenRouter.OpenAIResponsesCodeInterpreterCallInProgress? value)
        {
            OpenAIResponses = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CodeInterpreterCallInProgressEvent FromOpenAIResponses(global::OpenRouter.OpenAIResponsesCodeInterpreterCallInProgress? value) => new CodeInterpreterCallInProgressEvent(value);

        /// <summary>
        ///
        /// </summary>
        public CodeInterpreterCallInProgressEvent(
            global::OpenRouter.OpenAIResponsesCodeInterpreterCallInProgress? openAIResponses,
            object? codeInterpreterCallInProgressEventVariant2
            )
        {
            OpenAIResponses = openAIResponses;
            CodeInterpreterCallInProgressEventVariant2 = codeInterpreterCallInProgressEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CodeInterpreterCallInProgressEventVariant2 as object ??
            OpenAIResponses as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OpenAIResponses?.ToString() ??
            CodeInterpreterCallInProgressEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOpenAIResponses && IsCodeInterpreterCallInProgressEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OpenAIResponsesCodeInterpreterCallInProgress, TResult>? openAIResponses = null,
            global::System.Func<object, TResult>? codeInterpreterCallInProgressEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OpenAIResponses is { } __value0 && openAIResponses != null)
            {
                return openAIResponses(__value0);
            }
            else if (CodeInterpreterCallInProgressEventVariant2 is { } __value1 && codeInterpreterCallInProgressEventVariant2 != null)
            {
                return codeInterpreterCallInProgressEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OpenAIResponsesCodeInterpreterCallInProgress>? openAIResponses = null,

            global::System.Action<object>? codeInterpreterCallInProgressEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OpenAIResponses is { } __value0)
            {
                openAIResponses?.Invoke(__value0);
            }
            else if (CodeInterpreterCallInProgressEventVariant2 is { } __value1)
            {
                codeInterpreterCallInProgressEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OpenAIResponsesCodeInterpreterCallInProgress>? openAIResponses = null,
            global::System.Action<object>? codeInterpreterCallInProgressEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OpenAIResponses is { } __value0)
            {
                openAIResponses?.Invoke(__value0);
            }
            else if (CodeInterpreterCallInProgressEventVariant2 is { } __value1)
            {
                codeInterpreterCallInProgressEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OpenAIResponses,
                typeof(global::OpenRouter.OpenAIResponsesCodeInterpreterCallInProgress),
                CodeInterpreterCallInProgressEventVariant2,
                typeof(object),
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
        public bool Equals(CodeInterpreterCallInProgressEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAIResponsesCodeInterpreterCallInProgress?>.Default.Equals(OpenAIResponses, other.OpenAIResponses) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(CodeInterpreterCallInProgressEventVariant2, other.CodeInterpreterCallInProgressEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CodeInterpreterCallInProgressEvent obj1, CodeInterpreterCallInProgressEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CodeInterpreterCallInProgressEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CodeInterpreterCallInProgressEvent obj1, CodeInterpreterCallInProgressEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CodeInterpreterCallInProgressEvent o && Equals(o);
        }
    }
}
