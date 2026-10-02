#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Incremental chunk of code being streamed for a `code_interpreter_call`.<br/>
    /// Example: {"delta":"print(\u0022hello\u0022)","item_id":"ci-abc123","output_index":0,"sequence_number":3,"type":"response.code_interpreter_call_code.delta"}
    /// </summary>
    public readonly partial struct CodeInterpreterCallCodeDeltaEvent : global::System.IEquatable<CodeInterpreterCallCodeDeltaEvent>
    {
        /// <summary>
        /// Example: {"delta":"print(\u0022hello\u0022)","item_id":"ci_abc123","output_index":0,"sequence_number":2,"type":"response.code_interpreter_call_code.delta"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDelta? OpenAIResponses { get; init; }
#else
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDelta? OpenAIResponses { get; }
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
            out global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDelta? value)
        {
            value = OpenAIResponses;
            return IsOpenAIResponses;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDelta PickOpenAIResponses() => OpenAIResponses is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAIResponses' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? CodeInterpreterCallCodeDeltaEventVariant2 { get; init; }
#else
        public object? CodeInterpreterCallCodeDeltaEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterCallCodeDeltaEventVariant2))]
#endif
        public bool IsCodeInterpreterCallCodeDeltaEventVariant2 => CodeInterpreterCallCodeDeltaEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCodeInterpreterCallCodeDeltaEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = CodeInterpreterCallCodeDeltaEventVariant2;
            return IsCodeInterpreterCallCodeDeltaEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickCodeInterpreterCallCodeDeltaEventVariant2() => CodeInterpreterCallCodeDeltaEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeInterpreterCallCodeDeltaEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CodeInterpreterCallCodeDeltaEvent(global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDelta value) => new CodeInterpreterCallCodeDeltaEvent((global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDelta?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDelta?(CodeInterpreterCallCodeDeltaEvent @this) => @this.OpenAIResponses;

        /// <summary>
        ///
        /// </summary>
        public CodeInterpreterCallCodeDeltaEvent(global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDelta? value)
        {
            OpenAIResponses = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CodeInterpreterCallCodeDeltaEvent FromOpenAIResponses(global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDelta? value) => new CodeInterpreterCallCodeDeltaEvent(value);

        /// <summary>
        ///
        /// </summary>
        public CodeInterpreterCallCodeDeltaEvent(
            global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDelta? openAIResponses,
            object? codeInterpreterCallCodeDeltaEventVariant2
            )
        {
            OpenAIResponses = openAIResponses;
            CodeInterpreterCallCodeDeltaEventVariant2 = codeInterpreterCallCodeDeltaEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CodeInterpreterCallCodeDeltaEventVariant2 as object ??
            OpenAIResponses as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OpenAIResponses?.ToString() ??
            CodeInterpreterCallCodeDeltaEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOpenAIResponses && IsCodeInterpreterCallCodeDeltaEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDelta, TResult>? openAIResponses = null,
            global::System.Func<object, TResult>? codeInterpreterCallCodeDeltaEventVariant2 = null,
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
            else if (CodeInterpreterCallCodeDeltaEventVariant2 is { } __value1 && codeInterpreterCallCodeDeltaEventVariant2 != null)
            {
                return codeInterpreterCallCodeDeltaEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDelta>? openAIResponses = null,

            global::System.Action<object>? codeInterpreterCallCodeDeltaEventVariant2 = null,
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
            else if (CodeInterpreterCallCodeDeltaEventVariant2 is { } __value1)
            {
                codeInterpreterCallCodeDeltaEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDelta>? openAIResponses = null,
            global::System.Action<object>? codeInterpreterCallCodeDeltaEventVariant2 = null,
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
            else if (CodeInterpreterCallCodeDeltaEventVariant2 is { } __value1)
            {
                codeInterpreterCallCodeDeltaEventVariant2?.Invoke(__value1);
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
                typeof(global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDelta),
                CodeInterpreterCallCodeDeltaEventVariant2,
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
        public bool Equals(CodeInterpreterCallCodeDeltaEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAIResponsesCodeInterpreterCallCodeDelta?>.Default.Equals(OpenAIResponses, other.OpenAIResponses) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(CodeInterpreterCallCodeDeltaEventVariant2, other.CodeInterpreterCallCodeDeltaEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CodeInterpreterCallCodeDeltaEvent obj1, CodeInterpreterCallCodeDeltaEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CodeInterpreterCallCodeDeltaEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CodeInterpreterCallCodeDeltaEvent obj1, CodeInterpreterCallCodeDeltaEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CodeInterpreterCallCodeDeltaEvent o && Equals(o);
        }
    }
}
