#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when a response has completed successfully<br/>
    /// Example: {"response":{"completed_at":null,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[],"parallel_tool_calls":true,"presence_penalty":null,"status":"completed","temperature":null,"tool_choice":"auto","tools":[],"top_p":null},"sequence_number":10,"type":"response.completed"}
    /// </summary>
    public readonly partial struct StreamEventsResponseCompleted : global::System.IEquatable<StreamEventsResponseCompleted>
    {
        /// <summary>
        /// Event emitted when a response has completed successfully<br/>
        /// Example: {"response":{"completed_at":null,"created_at":1704067200,"error":null,"frequency_penalty":null,"id":"resp-abc123","incomplete_details":null,"instructions":null,"max_output_tokens":null,"metadata":null,"model":"gpt-4","object":"response","output":[{"content":[{"annotations":[],"text":"Hello! How can I help you?","type":"output_text"}],"id":"item-1","role":"assistant","status":"completed","type":"message"}],"parallel_tool_calls":true,"presence_penalty":null,"status":"completed","temperature":null,"tool_choice":"auto","tools":[],"top_p":null},"sequence_number":10,"type":"response.completed"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.CompletedEvent? Event { get; init; }
#else
        public global::OpenRouter.CompletedEvent? Event { get; }
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
            out global::OpenRouter.CompletedEvent? value)
        {
            value = Event;
            return IsEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.CompletedEvent PickEvent() => Event is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Event' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.StreamEventsResponseCompletedVariant2? StreamEventsResponseCompletedVariant2 { get; init; }
#else
        public global::OpenRouter.StreamEventsResponseCompletedVariant2? StreamEventsResponseCompletedVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamEventsResponseCompletedVariant2))]
#endif
        public bool IsStreamEventsResponseCompletedVariant2 => StreamEventsResponseCompletedVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStreamEventsResponseCompletedVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.StreamEventsResponseCompletedVariant2? value)
        {
            value = StreamEventsResponseCompletedVariant2;
            return IsStreamEventsResponseCompletedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseCompletedVariant2 PickStreamEventsResponseCompletedVariant2() => StreamEventsResponseCompletedVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StreamEventsResponseCompletedVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEventsResponseCompleted(global::OpenRouter.CompletedEvent value) => new StreamEventsResponseCompleted((global::OpenRouter.CompletedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.CompletedEvent?(StreamEventsResponseCompleted @this) => @this.Event;

        /// <summary>
        ///
        /// </summary>
        public StreamEventsResponseCompleted(global::OpenRouter.CompletedEvent? value)
        {
            Event = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEventsResponseCompleted FromEvent(global::OpenRouter.CompletedEvent? value) => new StreamEventsResponseCompleted(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEventsResponseCompleted(global::OpenRouter.StreamEventsResponseCompletedVariant2 value) => new StreamEventsResponseCompleted((global::OpenRouter.StreamEventsResponseCompletedVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.StreamEventsResponseCompletedVariant2?(StreamEventsResponseCompleted @this) => @this.StreamEventsResponseCompletedVariant2;

        /// <summary>
        ///
        /// </summary>
        public StreamEventsResponseCompleted(global::OpenRouter.StreamEventsResponseCompletedVariant2? value)
        {
            StreamEventsResponseCompletedVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEventsResponseCompleted FromStreamEventsResponseCompletedVariant2(global::OpenRouter.StreamEventsResponseCompletedVariant2? value) => new StreamEventsResponseCompleted(value);

        /// <summary>
        ///
        /// </summary>
        public StreamEventsResponseCompleted(
            global::OpenRouter.CompletedEvent? @event,
            global::OpenRouter.StreamEventsResponseCompletedVariant2? streamEventsResponseCompletedVariant2
            )
        {
            Event = @event;
            StreamEventsResponseCompletedVariant2 = streamEventsResponseCompletedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            StreamEventsResponseCompletedVariant2 as object ??
            Event as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Event?.ToString() ??
            StreamEventsResponseCompletedVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEvent && IsStreamEventsResponseCompletedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.CompletedEvent, TResult>? @event = null,
            global::System.Func<global::OpenRouter.StreamEventsResponseCompletedVariant2, TResult>? streamEventsResponseCompletedVariant2 = null,
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
            else if (StreamEventsResponseCompletedVariant2 is { } __value1 && streamEventsResponseCompletedVariant2 != null)
            {
                return streamEventsResponseCompletedVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.CompletedEvent>? @event = null,

            global::System.Action<global::OpenRouter.StreamEventsResponseCompletedVariant2>? streamEventsResponseCompletedVariant2 = null,
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
            else if (StreamEventsResponseCompletedVariant2 is { } __value1)
            {
                streamEventsResponseCompletedVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.CompletedEvent>? @event = null,
            global::System.Action<global::OpenRouter.StreamEventsResponseCompletedVariant2>? streamEventsResponseCompletedVariant2 = null,
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
            else if (StreamEventsResponseCompletedVariant2 is { } __value1)
            {
                streamEventsResponseCompletedVariant2?.Invoke(__value1);
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
                typeof(global::OpenRouter.CompletedEvent),
                StreamEventsResponseCompletedVariant2,
                typeof(global::OpenRouter.StreamEventsResponseCompletedVariant2),
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
        public bool Equals(StreamEventsResponseCompleted other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.CompletedEvent?>.Default.Equals(Event, other.Event) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.StreamEventsResponseCompletedVariant2?>.Default.Equals(StreamEventsResponseCompletedVariant2, other.StreamEventsResponseCompletedVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StreamEventsResponseCompleted obj1, StreamEventsResponseCompleted obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StreamEventsResponseCompleted>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StreamEventsResponseCompleted obj1, StreamEventsResponseCompleted obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StreamEventsResponseCompleted o && Equals(o);
        }
    }
}
