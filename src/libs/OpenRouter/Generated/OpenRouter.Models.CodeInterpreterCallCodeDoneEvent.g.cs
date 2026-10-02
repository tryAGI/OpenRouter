#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Emitted when code streaming completes for a `code_interpreter_call`.<br/>
    /// Example: {"code":"print(\u0022hello\u0022)","item_id":"ci-abc123","output_index":0,"sequence_number":8,"type":"response.code_interpreter_call_code.done"}
    /// </summary>
    public readonly partial struct CodeInterpreterCallCodeDoneEvent : global::System.IEquatable<CodeInterpreterCallCodeDoneEvent>
    {
        /// <summary>
        /// Example: {"code":"print(\u0022hello\u0022)","item_id":"ci_abc123","output_index":0,"sequence_number":3,"type":"response.code_interpreter_call_code.done"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDone? OpenAIResponses { get; init; }
#else
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDone? OpenAIResponses { get; }
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
            out global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDone? value)
        {
            value = OpenAIResponses;
            return IsOpenAIResponses;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDone PickOpenAIResponses() => OpenAIResponses is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAIResponses' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? CodeInterpreterCallCodeDoneEventVariant2 { get; init; }
#else
        public object? CodeInterpreterCallCodeDoneEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterCallCodeDoneEventVariant2))]
#endif
        public bool IsCodeInterpreterCallCodeDoneEventVariant2 => CodeInterpreterCallCodeDoneEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCodeInterpreterCallCodeDoneEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = CodeInterpreterCallCodeDoneEventVariant2;
            return IsCodeInterpreterCallCodeDoneEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickCodeInterpreterCallCodeDoneEventVariant2() => CodeInterpreterCallCodeDoneEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeInterpreterCallCodeDoneEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CodeInterpreterCallCodeDoneEvent(global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDone value) => new CodeInterpreterCallCodeDoneEvent((global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDone?(CodeInterpreterCallCodeDoneEvent @this) => @this.OpenAIResponses;

        /// <summary>
        ///
        /// </summary>
        public CodeInterpreterCallCodeDoneEvent(global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDone? value)
        {
            OpenAIResponses = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CodeInterpreterCallCodeDoneEvent FromOpenAIResponses(global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDone? value) => new CodeInterpreterCallCodeDoneEvent(value);

        /// <summary>
        ///
        /// </summary>
        public CodeInterpreterCallCodeDoneEvent(
            global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDone? openAIResponses,
            object? codeInterpreterCallCodeDoneEventVariant2
            )
        {
            OpenAIResponses = openAIResponses;
            CodeInterpreterCallCodeDoneEventVariant2 = codeInterpreterCallCodeDoneEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CodeInterpreterCallCodeDoneEventVariant2 as object ??
            OpenAIResponses as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OpenAIResponses?.ToString() ??
            CodeInterpreterCallCodeDoneEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOpenAIResponses && IsCodeInterpreterCallCodeDoneEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDone, TResult>? openAIResponses = null,
            global::System.Func<object, TResult>? codeInterpreterCallCodeDoneEventVariant2 = null,
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
            else if (CodeInterpreterCallCodeDoneEventVariant2 is { } __value1 && codeInterpreterCallCodeDoneEventVariant2 != null)
            {
                return codeInterpreterCallCodeDoneEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDone>? openAIResponses = null,

            global::System.Action<object>? codeInterpreterCallCodeDoneEventVariant2 = null,
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
            else if (CodeInterpreterCallCodeDoneEventVariant2 is { } __value1)
            {
                codeInterpreterCallCodeDoneEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDone>? openAIResponses = null,
            global::System.Action<object>? codeInterpreterCallCodeDoneEventVariant2 = null,
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
            else if (CodeInterpreterCallCodeDoneEventVariant2 is { } __value1)
            {
                codeInterpreterCallCodeDoneEventVariant2?.Invoke(__value1);
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
                typeof(global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDone),
                CodeInterpreterCallCodeDoneEventVariant2,
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
        public bool Equals(CodeInterpreterCallCodeDoneEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDone?>.Default.Equals(OpenAIResponses, other.OpenAIResponses) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(CodeInterpreterCallCodeDoneEventVariant2, other.CodeInterpreterCallCodeDoneEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CodeInterpreterCallCodeDoneEvent obj1, CodeInterpreterCallCodeDoneEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CodeInterpreterCallCodeDoneEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CodeInterpreterCallCodeDoneEvent obj1, CodeInterpreterCallCodeDoneEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CodeInterpreterCallCodeDoneEvent o && Equals(o);
        }
    }
}
