#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Code interpreter call completed<br/>
    /// Example: {"item_id":"ci-abc123","output_index":0,"sequence_number":10,"type":"response.code_interpreter_call.completed"}
    /// </summary>
    public readonly partial struct CodeInterpreterCallCompletedEvent : global::System.IEquatable<CodeInterpreterCallCompletedEvent>
    {
        /// <summary>
        /// Example: {"item_id":"ci_abc123","output_index":0,"sequence_number":3,"type":"response.code_interpreter_call.completed"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallCompleted? OpenAIResponses { get; init; }
#else
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallCompleted? OpenAIResponses { get; }
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
            out global::OpenRouter.OpenAIResponsesCodeInterpreterCallCompleted? value)
        {
            value = OpenAIResponses;
            return IsOpenAIResponses;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesCodeInterpreterCallCompleted PickOpenAIResponses() => OpenAIResponses is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAIResponses' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? CodeInterpreterCallCompletedEventVariant2 { get; init; }
#else
        public object? CodeInterpreterCallCompletedEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeInterpreterCallCompletedEventVariant2))]
#endif
        public bool IsCodeInterpreterCallCompletedEventVariant2 => CodeInterpreterCallCompletedEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCodeInterpreterCallCompletedEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = CodeInterpreterCallCompletedEventVariant2;
            return IsCodeInterpreterCallCompletedEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickCodeInterpreterCallCompletedEventVariant2() => CodeInterpreterCallCompletedEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeInterpreterCallCompletedEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CodeInterpreterCallCompletedEvent(global::OpenRouter.OpenAIResponsesCodeInterpreterCallCompleted value) => new CodeInterpreterCallCompletedEvent((global::OpenRouter.OpenAIResponsesCodeInterpreterCallCompleted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAIResponsesCodeInterpreterCallCompleted?(CodeInterpreterCallCompletedEvent @this) => @this.OpenAIResponses;

        /// <summary>
        ///
        /// </summary>
        public CodeInterpreterCallCompletedEvent(global::OpenRouter.OpenAIResponsesCodeInterpreterCallCompleted? value)
        {
            OpenAIResponses = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CodeInterpreterCallCompletedEvent FromOpenAIResponses(global::OpenRouter.OpenAIResponsesCodeInterpreterCallCompleted? value) => new CodeInterpreterCallCompletedEvent(value);

        /// <summary>
        ///
        /// </summary>
        public CodeInterpreterCallCompletedEvent(
            global::OpenRouter.OpenAIResponsesCodeInterpreterCallCompleted? openAIResponses,
            object? codeInterpreterCallCompletedEventVariant2
            )
        {
            OpenAIResponses = openAIResponses;
            CodeInterpreterCallCompletedEventVariant2 = codeInterpreterCallCompletedEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CodeInterpreterCallCompletedEventVariant2 as object ??
            OpenAIResponses as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OpenAIResponses?.ToString() ??
            CodeInterpreterCallCompletedEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOpenAIResponses && IsCodeInterpreterCallCompletedEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OpenAIResponsesCodeInterpreterCallCompleted, TResult>? openAIResponses = null,
            global::System.Func<object, TResult>? codeInterpreterCallCompletedEventVariant2 = null,
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
            else if (CodeInterpreterCallCompletedEventVariant2 is { } __value1 && codeInterpreterCallCompletedEventVariant2 != null)
            {
                return codeInterpreterCallCompletedEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OpenAIResponsesCodeInterpreterCallCompleted>? openAIResponses = null,

            global::System.Action<object>? codeInterpreterCallCompletedEventVariant2 = null,
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
            else if (CodeInterpreterCallCompletedEventVariant2 is { } __value1)
            {
                codeInterpreterCallCompletedEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OpenAIResponsesCodeInterpreterCallCompleted>? openAIResponses = null,
            global::System.Action<object>? codeInterpreterCallCompletedEventVariant2 = null,
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
            else if (CodeInterpreterCallCompletedEventVariant2 is { } __value1)
            {
                codeInterpreterCallCompletedEventVariant2?.Invoke(__value1);
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
                typeof(global::OpenRouter.OpenAIResponsesCodeInterpreterCallCompleted),
                CodeInterpreterCallCompletedEventVariant2,
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
        public bool Equals(CodeInterpreterCallCompletedEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAIResponsesCodeInterpreterCallCompleted?>.Default.Equals(OpenAIResponses, other.OpenAIResponses) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(CodeInterpreterCallCompletedEventVariant2, other.CodeInterpreterCallCompletedEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CodeInterpreterCallCompletedEvent obj1, CodeInterpreterCallCompletedEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CodeInterpreterCallCompletedEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CodeInterpreterCallCompletedEvent obj1, CodeInterpreterCallCompletedEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CodeInterpreterCallCompletedEvent o && Equals(o);
        }
    }
}
