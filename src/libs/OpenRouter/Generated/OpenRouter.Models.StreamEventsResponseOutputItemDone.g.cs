#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when an output item is complete<br/>
    /// Example: {"item":{"content":[{"annotations":[],"text":"Hello! How can I help you?","type":"output_text"}],"id":"item-1","role":"assistant","status":"completed","type":"message"},"output_index":0,"sequence_number":8,"type":"response.output_item.done"}
    /// </summary>
    public readonly partial struct StreamEventsResponseOutputItemDone : global::System.IEquatable<StreamEventsResponseOutputItemDone>
    {
        /// <summary>
        /// Event emitted when an output item is complete<br/>
        /// Example: {"item":{"content":[{"annotations":[],"text":"Hello! How can I help you?","type":"output_text"}],"id":"item-1","role":"assistant","status":"completed","type":"message"},"output_index":0,"sequence_number":8,"type":"response.output_item.done"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemDoneEvent? Event { get; init; }
#else
        public global::OpenRouter.OutputItemDoneEvent? Event { get; }
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
            out global::OpenRouter.OutputItemDoneEvent? value)
        {
            value = Event;
            return IsEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputItemDoneEvent PickEvent() => Event is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Event' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.StreamEventsResponseOutputItemDoneVariant2? StreamEventsResponseOutputItemDoneVariant2 { get; init; }
#else
        public global::OpenRouter.StreamEventsResponseOutputItemDoneVariant2? StreamEventsResponseOutputItemDoneVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamEventsResponseOutputItemDoneVariant2))]
#endif
        public bool IsStreamEventsResponseOutputItemDoneVariant2 => StreamEventsResponseOutputItemDoneVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStreamEventsResponseOutputItemDoneVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.StreamEventsResponseOutputItemDoneVariant2? value)
        {
            value = StreamEventsResponseOutputItemDoneVariant2;
            return IsStreamEventsResponseOutputItemDoneVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.StreamEventsResponseOutputItemDoneVariant2 PickStreamEventsResponseOutputItemDoneVariant2() => StreamEventsResponseOutputItemDoneVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StreamEventsResponseOutputItemDoneVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEventsResponseOutputItemDone(global::OpenRouter.OutputItemDoneEvent value) => new StreamEventsResponseOutputItemDone((global::OpenRouter.OutputItemDoneEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemDoneEvent?(StreamEventsResponseOutputItemDone @this) => @this.Event;

        /// <summary>
        ///
        /// </summary>
        public StreamEventsResponseOutputItemDone(global::OpenRouter.OutputItemDoneEvent? value)
        {
            Event = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEventsResponseOutputItemDone FromEvent(global::OpenRouter.OutputItemDoneEvent? value) => new StreamEventsResponseOutputItemDone(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StreamEventsResponseOutputItemDone(global::OpenRouter.StreamEventsResponseOutputItemDoneVariant2 value) => new StreamEventsResponseOutputItemDone((global::OpenRouter.StreamEventsResponseOutputItemDoneVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.StreamEventsResponseOutputItemDoneVariant2?(StreamEventsResponseOutputItemDone @this) => @this.StreamEventsResponseOutputItemDoneVariant2;

        /// <summary>
        ///
        /// </summary>
        public StreamEventsResponseOutputItemDone(global::OpenRouter.StreamEventsResponseOutputItemDoneVariant2? value)
        {
            StreamEventsResponseOutputItemDoneVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StreamEventsResponseOutputItemDone FromStreamEventsResponseOutputItemDoneVariant2(global::OpenRouter.StreamEventsResponseOutputItemDoneVariant2? value) => new StreamEventsResponseOutputItemDone(value);

        /// <summary>
        ///
        /// </summary>
        public StreamEventsResponseOutputItemDone(
            global::OpenRouter.OutputItemDoneEvent? @event,
            global::OpenRouter.StreamEventsResponseOutputItemDoneVariant2? streamEventsResponseOutputItemDoneVariant2
            )
        {
            Event = @event;
            StreamEventsResponseOutputItemDoneVariant2 = streamEventsResponseOutputItemDoneVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            StreamEventsResponseOutputItemDoneVariant2 as object ??
            Event as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Event?.ToString() ??
            StreamEventsResponseOutputItemDoneVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEvent && IsStreamEventsResponseOutputItemDoneVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OutputItemDoneEvent, TResult>? @event = null,
            global::System.Func<global::OpenRouter.StreamEventsResponseOutputItemDoneVariant2, TResult>? streamEventsResponseOutputItemDoneVariant2 = null,
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
            else if (StreamEventsResponseOutputItemDoneVariant2 is { } __value1 && streamEventsResponseOutputItemDoneVariant2 != null)
            {
                return streamEventsResponseOutputItemDoneVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OutputItemDoneEvent>? @event = null,

            global::System.Action<global::OpenRouter.StreamEventsResponseOutputItemDoneVariant2>? streamEventsResponseOutputItemDoneVariant2 = null,
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
            else if (StreamEventsResponseOutputItemDoneVariant2 is { } __value1)
            {
                streamEventsResponseOutputItemDoneVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OutputItemDoneEvent>? @event = null,
            global::System.Action<global::OpenRouter.StreamEventsResponseOutputItemDoneVariant2>? streamEventsResponseOutputItemDoneVariant2 = null,
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
            else if (StreamEventsResponseOutputItemDoneVariant2 is { } __value1)
            {
                streamEventsResponseOutputItemDoneVariant2?.Invoke(__value1);
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
                typeof(global::OpenRouter.OutputItemDoneEvent),
                StreamEventsResponseOutputItemDoneVariant2,
                typeof(global::OpenRouter.StreamEventsResponseOutputItemDoneVariant2),
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
        public bool Equals(StreamEventsResponseOutputItemDone other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemDoneEvent?>.Default.Equals(Event, other.Event) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.StreamEventsResponseOutputItemDoneVariant2?>.Default.Equals(StreamEventsResponseOutputItemDoneVariant2, other.StreamEventsResponseOutputItemDoneVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StreamEventsResponseOutputItemDone obj1, StreamEventsResponseOutputItemDone obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StreamEventsResponseOutputItemDone>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StreamEventsResponseOutputItemDone obj1, StreamEventsResponseOutputItemDone obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StreamEventsResponseOutputItemDone o && Equals(o);
        }
    }
}
