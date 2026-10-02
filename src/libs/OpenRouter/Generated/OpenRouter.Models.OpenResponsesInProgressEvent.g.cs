#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when a response is in progress<br/>
    /// Example: {"response":{"completed_at":null,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[],"parallel_tool_calls":true,"presence_penalty":null,"status":"in_progress","temperature":null,"tool_choice":"auto","tools":[],"top_p":null},"sequence_number":1,"type":"response.in_progress"}
    /// </summary>
    public readonly partial struct OpenResponsesInProgressEvent : global::System.IEquatable<OpenResponsesInProgressEvent>
    {
        /// <summary>
        /// Event emitted when a response is in progress<br/>
        /// Example: {"response":{"completed_at":null,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[],"parallel_tool_calls":true,"presence_penalty":null,"status":"in_progress","temperature":null,"tool_choice":"auto","tools":[],"top_p":null},"sequence_number":1,"type":"response.in_progress"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.InProgressEvent? InProgressEvent { get; init; }
#else
        public global::OpenRouter.InProgressEvent? InProgressEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InProgressEvent))]
#endif
        public bool IsInProgressEvent => InProgressEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInProgressEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.InProgressEvent? value)
        {
            value = InProgressEvent;
            return IsInProgressEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InProgressEvent PickInProgressEvent() => InProgressEvent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InProgressEvent' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenResponsesInProgressEventVariant2? OpenResponsesInProgressEventVariant2 { get; init; }
#else
        public global::OpenRouter.OpenResponsesInProgressEventVariant2? OpenResponsesInProgressEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenResponsesInProgressEventVariant2))]
#endif
        public bool IsOpenResponsesInProgressEventVariant2 => OpenResponsesInProgressEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenResponsesInProgressEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenResponsesInProgressEventVariant2? value)
        {
            value = OpenResponsesInProgressEventVariant2;
            return IsOpenResponsesInProgressEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesInProgressEventVariant2 PickOpenResponsesInProgressEventVariant2() => OpenResponsesInProgressEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenResponsesInProgressEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator OpenResponsesInProgressEvent(global::OpenRouter.InProgressEvent value) => new OpenResponsesInProgressEvent((global::OpenRouter.InProgressEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.InProgressEvent?(OpenResponsesInProgressEvent @this) => @this.InProgressEvent;

        /// <summary>
        ///
        /// </summary>
        public OpenResponsesInProgressEvent(global::OpenRouter.InProgressEvent? value)
        {
            InProgressEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesInProgressEvent FromInProgressEvent(global::OpenRouter.InProgressEvent? value) => new OpenResponsesInProgressEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OpenResponsesInProgressEvent(global::OpenRouter.OpenResponsesInProgressEventVariant2 value) => new OpenResponsesInProgressEvent((global::OpenRouter.OpenResponsesInProgressEventVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenResponsesInProgressEventVariant2?(OpenResponsesInProgressEvent @this) => @this.OpenResponsesInProgressEventVariant2;

        /// <summary>
        ///
        /// </summary>
        public OpenResponsesInProgressEvent(global::OpenRouter.OpenResponsesInProgressEventVariant2? value)
        {
            OpenResponsesInProgressEventVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesInProgressEvent FromOpenResponsesInProgressEventVariant2(global::OpenRouter.OpenResponsesInProgressEventVariant2? value) => new OpenResponsesInProgressEvent(value);

        /// <summary>
        ///
        /// </summary>
        public OpenResponsesInProgressEvent(
            global::OpenRouter.InProgressEvent? inProgressEvent,
            global::OpenRouter.OpenResponsesInProgressEventVariant2? openResponsesInProgressEventVariant2
            )
        {
            InProgressEvent = inProgressEvent;
            OpenResponsesInProgressEventVariant2 = openResponsesInProgressEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            OpenResponsesInProgressEventVariant2 as object ??
            InProgressEvent as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            InProgressEvent?.ToString() ??
            OpenResponsesInProgressEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInProgressEvent && IsOpenResponsesInProgressEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.InProgressEvent, TResult>? inProgressEvent = null,
            global::System.Func<global::OpenRouter.OpenResponsesInProgressEventVariant2, TResult>? openResponsesInProgressEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InProgressEvent is { } __value0 && inProgressEvent != null)
            {
                return inProgressEvent(__value0);
            }
            else if (OpenResponsesInProgressEventVariant2 is { } __value1 && openResponsesInProgressEventVariant2 != null)
            {
                return openResponsesInProgressEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.InProgressEvent>? inProgressEvent = null,

            global::System.Action<global::OpenRouter.OpenResponsesInProgressEventVariant2>? openResponsesInProgressEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InProgressEvent is { } __value0)
            {
                inProgressEvent?.Invoke(__value0);
            }
            else if (OpenResponsesInProgressEventVariant2 is { } __value1)
            {
                openResponsesInProgressEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.InProgressEvent>? inProgressEvent = null,
            global::System.Action<global::OpenRouter.OpenResponsesInProgressEventVariant2>? openResponsesInProgressEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InProgressEvent is { } __value0)
            {
                inProgressEvent?.Invoke(__value0);
            }
            else if (OpenResponsesInProgressEventVariant2 is { } __value1)
            {
                openResponsesInProgressEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InProgressEvent,
                typeof(global::OpenRouter.InProgressEvent),
                OpenResponsesInProgressEventVariant2,
                typeof(global::OpenRouter.OpenResponsesInProgressEventVariant2),
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
        public bool Equals(OpenResponsesInProgressEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InProgressEvent?>.Default.Equals(InProgressEvent, other.InProgressEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenResponsesInProgressEventVariant2?>.Default.Equals(OpenResponsesInProgressEventVariant2, other.OpenResponsesInProgressEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(OpenResponsesInProgressEvent obj1, OpenResponsesInProgressEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OpenResponsesInProgressEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OpenResponsesInProgressEvent obj1, OpenResponsesInProgressEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OpenResponsesInProgressEvent o && Equals(o);
        }
    }
}
