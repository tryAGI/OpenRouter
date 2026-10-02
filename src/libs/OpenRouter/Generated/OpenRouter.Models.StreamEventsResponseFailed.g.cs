#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when a response has failed<br/>
    /// Example: {"response":{"completed_at":null,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[],"parallel_tool_calls":true,"presence_penalty":null,"status":"failed","temperature":null,"tool_choice":"auto","tools":[],"top_p":null},"sequence_number":3,"type":"response.failed"}
    /// </summary>
    public readonly partial struct StreamEventsResponseFailed : global::System.IEquatable<StreamEventsResponseFailed>
    {
        /// <summary>
        /// Event emitted when a response has failed<br/>
        /// Example: {"response":{"completed_at":null,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[],"parallel_tool_calls":true,"presence_penalty":null,"status":"failed","temperature":null,"tool_choice":"auto","tools":[],"top_p":null},"sequence_number":3,"type":"response.failed"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.FailedEvent? Event { get; init; }
#else
        public global::OpenRouter.FailedEvent? Event { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Event))]
#endif
        public bool IsEvent => Event != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.FailedEvent? value)
        {
            value = Event;
            return IsEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.FailedEvent PickEvent() => Event is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Event' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.StreamEventsResponseFailedVariant2? StreamEventsResponseFailedVariant2 { get; init; }
#else
        public global::OpenRouter.StreamEventsResponseFailedVariant2? StreamEventsResponseFailedVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamEventsResponseFailedVariant2))]
#endif
        public bool IsStreamEventsResponseFailedVariant2 => StreamEventsResponseFailedVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStreamEventsResponseFailedVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.StreamEventsResponseFailedVariant2? value)
        {
            value = StreamEventsResponseFailedVariant2;
            return IsStreamEventsResponseFailedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseFailedVariant2 PickStreamEventsResponseFailedVariant2() => StreamEventsResponseFailedVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StreamEventsResponseFailedVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEventsResponseFailed(global::OpenRouter.FailedEvent value) => new StreamEventsResponseFailed((global::OpenRouter.FailedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.FailedEvent?(StreamEventsResponseFailed @this) => @this.Event;

        /// <summary>
        ///
        /// </summary>
        public StreamEventsResponseFailed(global::OpenRouter.FailedEvent? value)
        {
            Event = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEventsResponseFailed FromEvent(global::OpenRouter.FailedEvent? value) => new StreamEventsResponseFailed(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEventsResponseFailed(global::OpenRouter.StreamEventsResponseFailedVariant2 value) => new StreamEventsResponseFailed((global::OpenRouter.StreamEventsResponseFailedVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.StreamEventsResponseFailedVariant2?(StreamEventsResponseFailed @this) => @this.StreamEventsResponseFailedVariant2;

        /// <summary>
        ///
        /// </summary>
        public StreamEventsResponseFailed(global::OpenRouter.StreamEventsResponseFailedVariant2? value)
        {
            StreamEventsResponseFailedVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEventsResponseFailed FromStreamEventsResponseFailedVariant2(global::OpenRouter.StreamEventsResponseFailedVariant2? value) => new StreamEventsResponseFailed(value);

        /// <summary>
        ///
        /// </summary>
        public StreamEventsResponseFailed(
            global::OpenRouter.FailedEvent? @event,
            global::OpenRouter.StreamEventsResponseFailedVariant2? streamEventsResponseFailedVariant2
            )
        {
            Event = @event;
            StreamEventsResponseFailedVariant2 = streamEventsResponseFailedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            StreamEventsResponseFailedVariant2 as object ??
            Event as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Event?.ToString() ??
            StreamEventsResponseFailedVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEvent && IsStreamEventsResponseFailedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.FailedEvent, TResult>? @event = null,
            global::System.Func<global::OpenRouter.StreamEventsResponseFailedVariant2, TResult>? streamEventsResponseFailedVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Event is { } __value0 && @event != null)
            {
                return @event(__value0);
            }
            else if (StreamEventsResponseFailedVariant2 is { } __value1 && streamEventsResponseFailedVariant2 != null)
            {
                return streamEventsResponseFailedVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.FailedEvent>? @event = null,

            global::System.Action<global::OpenRouter.StreamEventsResponseFailedVariant2>? streamEventsResponseFailedVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Event is { } __value0)
            {
                @event?.Invoke(__value0);
            }
            else if (StreamEventsResponseFailedVariant2 is { } __value1)
            {
                streamEventsResponseFailedVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.FailedEvent>? @event = null,
            global::System.Action<global::OpenRouter.StreamEventsResponseFailedVariant2>? streamEventsResponseFailedVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Event is { } __value0)
            {
                @event?.Invoke(__value0);
            }
            else if (StreamEventsResponseFailedVariant2 is { } __value1)
            {
                streamEventsResponseFailedVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Event,
                typeof(global::OpenRouter.FailedEvent),
                StreamEventsResponseFailedVariant2,
                typeof(global::OpenRouter.StreamEventsResponseFailedVariant2),
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
        public bool Equals(StreamEventsResponseFailed other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.FailedEvent?>.Default.Equals(Event, other.Event) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.StreamEventsResponseFailedVariant2?>.Default.Equals(StreamEventsResponseFailedVariant2, other.StreamEventsResponseFailedVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StreamEventsResponseFailed obj1, StreamEventsResponseFailed obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StreamEventsResponseFailed>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StreamEventsResponseFailed obj1, StreamEventsResponseFailed obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StreamEventsResponseFailed o && Equals(o);
        }
    }
}
