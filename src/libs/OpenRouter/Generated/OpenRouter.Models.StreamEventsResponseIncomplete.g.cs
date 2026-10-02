#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when a response is incomplete<br/>
    /// Example: {"response":{"completed_at":null,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[],"parallel_tool_calls":true,"presence_penalty":null,"status":"incomplete","temperature":null,"tool_choice":"auto","tools":[],"top_p":null},"sequence_number":5,"type":"response.incomplete"}
    /// </summary>
    public readonly partial struct StreamEventsResponseIncomplete : global::System.IEquatable<StreamEventsResponseIncomplete>
    {
        /// <summary>
        /// Event emitted when a response is incomplete<br/>
        /// Example: {"response":{"completed_at":null,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[],"parallel_tool_calls":true,"presence_penalty":null,"status":"incomplete","temperature":null,"tool_choice":"auto","tools":[],"top_p":null},"sequence_number":5,"type":"response.incomplete"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.IncompleteEvent? Event { get; init; }
#else
        public global::OpenRouter.IncompleteEvent? Event { get; }
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
            out global::OpenRouter.IncompleteEvent? value)
        {
            value = Event;
            return IsEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.IncompleteEvent PickEvent() => Event is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Event' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.StreamEventsResponseIncompleteVariant2? StreamEventsResponseIncompleteVariant2 { get; init; }
#else
        public global::OpenRouter.StreamEventsResponseIncompleteVariant2? StreamEventsResponseIncompleteVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamEventsResponseIncompleteVariant2))]
#endif
        public bool IsStreamEventsResponseIncompleteVariant2 => StreamEventsResponseIncompleteVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStreamEventsResponseIncompleteVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.StreamEventsResponseIncompleteVariant2? value)
        {
            value = StreamEventsResponseIncompleteVariant2;
            return IsStreamEventsResponseIncompleteVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseIncompleteVariant2 PickStreamEventsResponseIncompleteVariant2() => StreamEventsResponseIncompleteVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StreamEventsResponseIncompleteVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEventsResponseIncomplete(global::OpenRouter.IncompleteEvent value) => new StreamEventsResponseIncomplete((global::OpenRouter.IncompleteEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.IncompleteEvent?(StreamEventsResponseIncomplete @this) => @this.Event;

        /// <summary>
        ///
        /// </summary>
        public StreamEventsResponseIncomplete(global::OpenRouter.IncompleteEvent? value)
        {
            Event = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEventsResponseIncomplete FromEvent(global::OpenRouter.IncompleteEvent? value) => new StreamEventsResponseIncomplete(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEventsResponseIncomplete(global::OpenRouter.StreamEventsResponseIncompleteVariant2 value) => new StreamEventsResponseIncomplete((global::OpenRouter.StreamEventsResponseIncompleteVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.StreamEventsResponseIncompleteVariant2?(StreamEventsResponseIncomplete @this) => @this.StreamEventsResponseIncompleteVariant2;

        /// <summary>
        ///
        /// </summary>
        public StreamEventsResponseIncomplete(global::OpenRouter.StreamEventsResponseIncompleteVariant2? value)
        {
            StreamEventsResponseIncompleteVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEventsResponseIncomplete FromStreamEventsResponseIncompleteVariant2(global::OpenRouter.StreamEventsResponseIncompleteVariant2? value) => new StreamEventsResponseIncomplete(value);

        /// <summary>
        ///
        /// </summary>
        public StreamEventsResponseIncomplete(
            global::OpenRouter.IncompleteEvent? @event,
            global::OpenRouter.StreamEventsResponseIncompleteVariant2? streamEventsResponseIncompleteVariant2
            )
        {
            Event = @event;
            StreamEventsResponseIncompleteVariant2 = streamEventsResponseIncompleteVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            StreamEventsResponseIncompleteVariant2 as object ??
            Event as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Event?.ToString() ??
            StreamEventsResponseIncompleteVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEvent && IsStreamEventsResponseIncompleteVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.IncompleteEvent, TResult>? @event = null,
            global::System.Func<global::OpenRouter.StreamEventsResponseIncompleteVariant2, TResult>? streamEventsResponseIncompleteVariant2 = null,
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
            else if (StreamEventsResponseIncompleteVariant2 is { } __value1 && streamEventsResponseIncompleteVariant2 != null)
            {
                return streamEventsResponseIncompleteVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.IncompleteEvent>? @event = null,

            global::System.Action<global::OpenRouter.StreamEventsResponseIncompleteVariant2>? streamEventsResponseIncompleteVariant2 = null,
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
            else if (StreamEventsResponseIncompleteVariant2 is { } __value1)
            {
                streamEventsResponseIncompleteVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.IncompleteEvent>? @event = null,
            global::System.Action<global::OpenRouter.StreamEventsResponseIncompleteVariant2>? streamEventsResponseIncompleteVariant2 = null,
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
            else if (StreamEventsResponseIncompleteVariant2 is { } __value1)
            {
                streamEventsResponseIncompleteVariant2?.Invoke(__value1);
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
                typeof(global::OpenRouter.IncompleteEvent),
                StreamEventsResponseIncompleteVariant2,
                typeof(global::OpenRouter.StreamEventsResponseIncompleteVariant2),
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
        public bool Equals(StreamEventsResponseIncomplete other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.IncompleteEvent?>.Default.Equals(Event, other.Event) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.StreamEventsResponseIncompleteVariant2?>.Default.Equals(StreamEventsResponseIncompleteVariant2, other.StreamEventsResponseIncompleteVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StreamEventsResponseIncomplete obj1, StreamEventsResponseIncomplete obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StreamEventsResponseIncomplete>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StreamEventsResponseIncomplete obj1, StreamEventsResponseIncomplete obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StreamEventsResponseIncomplete o && Equals(o);
        }
    }
}
