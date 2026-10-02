#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when a new output item is added to the response<br/>
    /// Example: {"item":{"content":[],"id":"item-1","role":"assistant","status":"in_progress","type":"message"},"output_index":0,"sequence_number":2,"type":"response.output_item.added"}
    /// </summary>
    public readonly partial struct StreamEventsResponseOutputItemAdded : global::System.IEquatable<StreamEventsResponseOutputItemAdded>
    {
        /// <summary>
        /// Event emitted when a new output item is added to the response<br/>
        /// Example: {"item":{"content":[],"id":"item-1","role":"assistant","status":"in_progress","type":"message"},"output_index":0,"sequence_number":2,"type":"response.output_item.added"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemAddedEvent? Event { get; init; }
#else
        public global::OpenRouter.OutputItemAddedEvent? Event { get; }
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
            out global::OpenRouter.OutputItemAddedEvent? value)
        {
            value = Event;
            return IsEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemAddedEvent PickEvent() => Event is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Event' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.StreamEventsResponseOutputItemAddedVariant2? StreamEventsResponseOutputItemAddedVariant2 { get; init; }
#else
        public global::OpenRouter.StreamEventsResponseOutputItemAddedVariant2? StreamEventsResponseOutputItemAddedVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamEventsResponseOutputItemAddedVariant2))]
#endif
        public bool IsStreamEventsResponseOutputItemAddedVariant2 => StreamEventsResponseOutputItemAddedVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStreamEventsResponseOutputItemAddedVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.StreamEventsResponseOutputItemAddedVariant2? value)
        {
            value = StreamEventsResponseOutputItemAddedVariant2;
            return IsStreamEventsResponseOutputItemAddedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseOutputItemAddedVariant2 PickStreamEventsResponseOutputItemAddedVariant2() => StreamEventsResponseOutputItemAddedVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StreamEventsResponseOutputItemAddedVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEventsResponseOutputItemAdded(global::OpenRouter.OutputItemAddedEvent value) => new StreamEventsResponseOutputItemAdded((global::OpenRouter.OutputItemAddedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemAddedEvent?(StreamEventsResponseOutputItemAdded @this) => @this.Event;

        /// <summary>
        ///
        /// </summary>
        public StreamEventsResponseOutputItemAdded(global::OpenRouter.OutputItemAddedEvent? value)
        {
            Event = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEventsResponseOutputItemAdded FromEvent(global::OpenRouter.OutputItemAddedEvent? value) => new StreamEventsResponseOutputItemAdded(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEventsResponseOutputItemAdded(global::OpenRouter.StreamEventsResponseOutputItemAddedVariant2 value) => new StreamEventsResponseOutputItemAdded((global::OpenRouter.StreamEventsResponseOutputItemAddedVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.StreamEventsResponseOutputItemAddedVariant2?(StreamEventsResponseOutputItemAdded @this) => @this.StreamEventsResponseOutputItemAddedVariant2;

        /// <summary>
        ///
        /// </summary>
        public StreamEventsResponseOutputItemAdded(global::OpenRouter.StreamEventsResponseOutputItemAddedVariant2? value)
        {
            StreamEventsResponseOutputItemAddedVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEventsResponseOutputItemAdded FromStreamEventsResponseOutputItemAddedVariant2(global::OpenRouter.StreamEventsResponseOutputItemAddedVariant2? value) => new StreamEventsResponseOutputItemAdded(value);

        /// <summary>
        ///
        /// </summary>
        public StreamEventsResponseOutputItemAdded(
            global::OpenRouter.OutputItemAddedEvent? @event,
            global::OpenRouter.StreamEventsResponseOutputItemAddedVariant2? streamEventsResponseOutputItemAddedVariant2
            )
        {
            Event = @event;
            StreamEventsResponseOutputItemAddedVariant2 = streamEventsResponseOutputItemAddedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            StreamEventsResponseOutputItemAddedVariant2 as object ??
            Event as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Event?.ToString() ??
            StreamEventsResponseOutputItemAddedVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEvent && IsStreamEventsResponseOutputItemAddedVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OutputItemAddedEvent, TResult>? @event = null,
            global::System.Func<global::OpenRouter.StreamEventsResponseOutputItemAddedVariant2, TResult>? streamEventsResponseOutputItemAddedVariant2 = null,
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
            else if (StreamEventsResponseOutputItemAddedVariant2 is { } __value1 && streamEventsResponseOutputItemAddedVariant2 != null)
            {
                return streamEventsResponseOutputItemAddedVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OutputItemAddedEvent>? @event = null,

            global::System.Action<global::OpenRouter.StreamEventsResponseOutputItemAddedVariant2>? streamEventsResponseOutputItemAddedVariant2 = null,
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
            else if (StreamEventsResponseOutputItemAddedVariant2 is { } __value1)
            {
                streamEventsResponseOutputItemAddedVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OutputItemAddedEvent>? @event = null,
            global::System.Action<global::OpenRouter.StreamEventsResponseOutputItemAddedVariant2>? streamEventsResponseOutputItemAddedVariant2 = null,
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
            else if (StreamEventsResponseOutputItemAddedVariant2 is { } __value1)
            {
                streamEventsResponseOutputItemAddedVariant2?.Invoke(__value1);
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
                typeof(global::OpenRouter.OutputItemAddedEvent),
                StreamEventsResponseOutputItemAddedVariant2,
                typeof(global::OpenRouter.StreamEventsResponseOutputItemAddedVariant2),
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
        public bool Equals(StreamEventsResponseOutputItemAdded other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemAddedEvent?>.Default.Equals(Event, other.Event) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.StreamEventsResponseOutputItemAddedVariant2?>.Default.Equals(StreamEventsResponseOutputItemAddedVariant2, other.StreamEventsResponseOutputItemAddedVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StreamEventsResponseOutputItemAdded obj1, StreamEventsResponseOutputItemAdded obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StreamEventsResponseOutputItemAdded>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StreamEventsResponseOutputItemAdded obj1, StreamEventsResponseOutputItemAdded obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StreamEventsResponseOutputItemAdded o && Equals(o);
        }
    }
}
