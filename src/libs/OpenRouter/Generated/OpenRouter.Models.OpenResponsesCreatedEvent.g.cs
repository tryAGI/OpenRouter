#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when a response is created<br/>
    /// Example: {"response":{"completed_at":null,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[],"parallel_tool_calls":true,"presence_penalty":null,"status":"in_progress","temperature":null,"tool_choice":"auto","tools":[],"top_p":null},"sequence_number":0,"type":"response.created"}
    /// </summary>
    public readonly partial struct OpenResponsesCreatedEvent : global::System.IEquatable<OpenResponsesCreatedEvent>
    {
        /// <summary>
        /// Event emitted when a response is created<br/>
        /// Example: {"response":{"completed_at":null,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[],"parallel_tool_calls":true,"presence_penalty":null,"status":"in_progress","temperature":null,"tool_choice":"auto","tools":[],"top_p":null},"sequence_number":0,"type":"response.created"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CreatedEvent? CreatedEvent { get; init; }
#else
        public global::OpenRouter.CreatedEvent? CreatedEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreatedEvent))]
#endif
        public bool IsCreatedEvent => CreatedEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreatedEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.CreatedEvent? value)
        {
            value = CreatedEvent;
            return IsCreatedEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CreatedEvent PickCreatedEvent() => CreatedEvent is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreatedEvent' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenResponsesCreatedEventVariant2? OpenResponsesCreatedEventVariant2 { get; init; }
#else
        public global::OpenRouter.OpenResponsesCreatedEventVariant2? OpenResponsesCreatedEventVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenResponsesCreatedEventVariant2))]
#endif
        public bool IsOpenResponsesCreatedEventVariant2 => OpenResponsesCreatedEventVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenResponsesCreatedEventVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenResponsesCreatedEventVariant2? value)
        {
            value = OpenResponsesCreatedEventVariant2;
            return IsOpenResponsesCreatedEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenResponsesCreatedEventVariant2 PickOpenResponsesCreatedEventVariant2() => OpenResponsesCreatedEventVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenResponsesCreatedEventVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator OpenResponsesCreatedEvent(global::OpenRouter.CreatedEvent value) => new OpenResponsesCreatedEvent((global::OpenRouter.CreatedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.CreatedEvent?(OpenResponsesCreatedEvent @this) => @this.CreatedEvent;

        /// <summary>
        ///
        /// </summary>
        public OpenResponsesCreatedEvent(global::OpenRouter.CreatedEvent? value)
        {
            CreatedEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesCreatedEvent FromCreatedEvent(global::OpenRouter.CreatedEvent? value) => new OpenResponsesCreatedEvent(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OpenResponsesCreatedEvent(global::OpenRouter.OpenResponsesCreatedEventVariant2 value) => new OpenResponsesCreatedEvent((global::OpenRouter.OpenResponsesCreatedEventVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenResponsesCreatedEventVariant2?(OpenResponsesCreatedEvent @this) => @this.OpenResponsesCreatedEventVariant2;

        /// <summary>
        ///
        /// </summary>
        public OpenResponsesCreatedEvent(global::OpenRouter.OpenResponsesCreatedEventVariant2? value)
        {
            OpenResponsesCreatedEventVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OpenResponsesCreatedEvent FromOpenResponsesCreatedEventVariant2(global::OpenRouter.OpenResponsesCreatedEventVariant2? value) => new OpenResponsesCreatedEvent(value);

        /// <summary>
        ///
        /// </summary>
        public OpenResponsesCreatedEvent(
            global::OpenRouter.CreatedEvent? createdEvent,
            global::OpenRouter.OpenResponsesCreatedEventVariant2? openResponsesCreatedEventVariant2
            )
        {
            CreatedEvent = createdEvent;
            OpenResponsesCreatedEventVariant2 = openResponsesCreatedEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            OpenResponsesCreatedEventVariant2 as object ??
            CreatedEvent as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            CreatedEvent?.ToString() ??
            OpenResponsesCreatedEventVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCreatedEvent && IsOpenResponsesCreatedEventVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.CreatedEvent, TResult>? createdEvent = null,
            global::System.Func<global::OpenRouter.OpenResponsesCreatedEventVariant2, TResult>? openResponsesCreatedEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CreatedEvent is { } __value0 && createdEvent != null)
            {
                return createdEvent(__value0);
            }
            else if (OpenResponsesCreatedEventVariant2 is { } __value1 && openResponsesCreatedEventVariant2 != null)
            {
                return openResponsesCreatedEventVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.CreatedEvent>? createdEvent = null,

            global::System.Action<global::OpenRouter.OpenResponsesCreatedEventVariant2>? openResponsesCreatedEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CreatedEvent is { } __value0)
            {
                createdEvent?.Invoke(__value0);
            }
            else if (OpenResponsesCreatedEventVariant2 is { } __value1)
            {
                openResponsesCreatedEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.CreatedEvent>? createdEvent = null,
            global::System.Action<global::OpenRouter.OpenResponsesCreatedEventVariant2>? openResponsesCreatedEventVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CreatedEvent is { } __value0)
            {
                createdEvent?.Invoke(__value0);
            }
            else if (OpenResponsesCreatedEventVariant2 is { } __value1)
            {
                openResponsesCreatedEventVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreatedEvent,
                typeof(global::OpenRouter.CreatedEvent),
                OpenResponsesCreatedEventVariant2,
                typeof(global::OpenRouter.OpenResponsesCreatedEventVariant2),
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
        public bool Equals(OpenResponsesCreatedEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CreatedEvent?>.Default.Equals(CreatedEvent, other.CreatedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenResponsesCreatedEventVariant2?>.Default.Equals(OpenResponsesCreatedEventVariant2, other.OpenResponsesCreatedEventVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(OpenResponsesCreatedEvent obj1, OpenResponsesCreatedEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OpenResponsesCreatedEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OpenResponsesCreatedEvent obj1, OpenResponsesCreatedEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OpenResponsesCreatedEvent o && Equals(o);
        }
    }
}
