#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Code interpreter is executing the code<br/>
    /// Example: {"item_id":"ci-abc123","output_index":0,"sequence_number":9,"type":"response.code_interpreter_call.interpreting"}
    /// </summary>
    public readonly partial struct CodeInterpreterCallInterpretingEvent : global::System.IEquatable<CodeInterpreterCallInterpretingEvent>
    {
        /// <summary>
        /// Example: {"item_id":"ci_abc123","output_index":0,"sequence_number":2,"type":"response.code_interpreter_call.interpreting"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallInterpreting? OpenAIResponses { get; init; }
#else
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallInterpreting? OpenAIResponses { get; }
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
            out global::OpenRouter.OpenAIResponsesCodeInterpreterCallInterpreting? value)
        {
            value = OpenAIResponses;
            return IsOpenAIResponses;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallInterpreting PickOpenAIResponses() => OpenAIResponses is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAIResponses' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? CodeInterpreterCallInterpretingEventVariant2 { get; init; }
#else
        public object? CodeInterpreterCallInterpretingEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterCallInterpretingEventVariant2))]
#endif
        public bool IsCodeInterpreterCallInterpretingEventVariant2 => CodeInterpreterCallInterpretingEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCodeInterpreterCallInterpretingEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = CodeInterpreterCallInterpretingEventVariant2;
            return IsCodeInterpreterCallInterpretingEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickCodeInterpreterCallInterpretingEventVariant2() => CodeInterpreterCallInterpretingEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeInterpreterCallInterpretingEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CodeInterpreterCallInterpretingEvent(global::OpenRouter.OpenAIResponsesCodeInterpreterCallInterpreting value) => new CodeInterpreterCallInterpretingEvent((global::OpenRouter.OpenAIResponsesCodeInterpreterCallInterpreting?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAIResponsesCodeInterpreterCallInterpreting?(CodeInterpreterCallInterpretingEvent @this) => @this.OpenAIResponses;

        /// <summary>
        ///
        /// </summary>
        public CodeInterpreterCallInterpretingEvent(global::OpenRouter.OpenAIResponsesCodeInterpreterCallInterpreting? value)
        {
            OpenAIResponses = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CodeInterpreterCallInterpretingEvent FromOpenAIResponses(global::OpenRouter.OpenAIResponsesCodeInterpreterCallInterpreting? value) => new CodeInterpreterCallInterpretingEvent(value);

        /// <summary>
        ///
        /// </summary>
        public CodeInterpreterCallInterpretingEvent(
            global::OpenRouter.OpenAIResponsesCodeInterpreterCallInterpreting? openAIResponses,
            object? codeInterpreterCallInterpretingEventVariant2
            )
        {
            OpenAIResponses = openAIResponses;
            CodeInterpreterCallInterpretingEventVariant2 = codeInterpreterCallInterpretingEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CodeInterpreterCallInterpretingEventVariant2 as object ??
            OpenAIResponses as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OpenAIResponses?.ToString() ??
            CodeInterpreterCallInterpretingEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOpenAIResponses && IsCodeInterpreterCallInterpretingEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OpenAIResponsesCodeInterpreterCallInterpreting, TResult>? openAIResponses = null,
            global::System.Func<object, TResult>? codeInterpreterCallInterpretingEventVariant2 = null,
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
            else if (CodeInterpreterCallInterpretingEventVariant2 is { } __value1 && codeInterpreterCallInterpretingEventVariant2 != null)
            {
                return codeInterpreterCallInterpretingEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OpenAIResponsesCodeInterpreterCallInterpreting>? openAIResponses = null,

            global::System.Action<object>? codeInterpreterCallInterpretingEventVariant2 = null,
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
            else if (CodeInterpreterCallInterpretingEventVariant2 is { } __value1)
            {
                codeInterpreterCallInterpretingEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OpenAIResponsesCodeInterpreterCallInterpreting>? openAIResponses = null,
            global::System.Action<object>? codeInterpreterCallInterpretingEventVariant2 = null,
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
            else if (CodeInterpreterCallInterpretingEventVariant2 is { } __value1)
            {
                codeInterpreterCallInterpretingEventVariant2?.Invoke(__value1);
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
                typeof(global::OpenRouter.OpenAIResponsesCodeInterpreterCallInterpreting),
                CodeInterpreterCallInterpretingEventVariant2,
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
        public bool Equals(CodeInterpreterCallInterpretingEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAIResponsesCodeInterpreterCallInterpreting?>.Default.Equals(OpenAIResponses, other.OpenAIResponses) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(CodeInterpreterCallInterpretingEventVariant2, other.CodeInterpreterCallInterpretingEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CodeInterpreterCallInterpretingEvent obj1, CodeInterpreterCallInterpretingEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CodeInterpreterCallInterpretingEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CodeInterpreterCallInterpretingEvent obj1, CodeInterpreterCallInterpretingEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CodeInterpreterCallInterpretingEvent o && Equals(o);
        }
    }
}
