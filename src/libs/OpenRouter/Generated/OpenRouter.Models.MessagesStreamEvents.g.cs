#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Union of all possible streaming events<br/>
    /// Example: {"delta":{"text":"Hello","type":"text_delta"},"index":0,"type":"content_block_delta"}
    /// </summary>
    public readonly partial struct MessagesStreamEvents : global::System.IEquatable<MessagesStreamEvents>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStreamEventsDiscriminatorType? Type { get; }

        /// <summary>
        /// Event sent at the start of a streaming message<br/>
        /// Example: {"message":{"container":null,"content":[],"id":"msg_01XFDUDYJgAACzvnptvVoYEL","model":"claude-sonnet-4-5-20250929","role":"assistant","stop_details":null,"stop_reason":null,"stop_sequence":null,"type":"message","usage":{"cache_creation":null,"cache_creation_input_tokens":null,"cache_read_input_tokens":null,"inference_geo":null,"input_tokens":12,"output_tokens":0,"output_tokens_details":null,"server_tool_use":null,"service_tier":"standard"}},"type":"message_start"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesStartEvent? MessageStart { get; init; }
#else
        public global::OpenRouter.MessagesStartEvent? MessageStart { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageStart))]
#endif
        public bool IsMessageStart => MessageStart != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMessageStart(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.MessagesStartEvent? value)
        {
            value = MessageStart;
            return IsMessageStart;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStartEvent PickMessageStart() => MessageStart is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MessageStart' but the value was {ToString()}.");

        /// <summary>
        /// Event sent when the message metadata changes (e.g., stop_reason)<br/>
        /// Example: {"delta":{"container":null,"stop_details":null,"stop_reason":"end_turn","stop_sequence":null},"type":"message_delta","usage":{"cache_creation_input_tokens":null,"cache_read_input_tokens":null,"input_tokens":null,"output_tokens":15,"output_tokens_details":null,"server_tool_use":null}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesDeltaEvent? MessageDelta { get; init; }
#else
        public global::OpenRouter.MessagesDeltaEvent? MessageDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageDelta))]
#endif
        public bool IsMessageDelta => MessageDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMessageDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.MessagesDeltaEvent? value)
        {
            value = MessageDelta;
            return IsMessageDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesDeltaEvent PickMessageDelta() => MessageDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MessageDelta' but the value was {ToString()}.");

        /// <summary>
        /// Event sent when the message is complete<br/>
        /// Example: {"type":"message_stop"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesStopEvent? MessageStop { get; init; }
#else
        public global::OpenRouter.MessagesStopEvent? MessageStop { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageStop))]
#endif
        public bool IsMessageStop => MessageStop != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMessageStop(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.MessagesStopEvent? value)
        {
            value = MessageStop;
            return IsMessageStop;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesStopEvent PickMessageStop() => MessageStop is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MessageStop' but the value was {ToString()}.");

        /// <summary>
        /// Event sent when a new content block starts<br/>
        /// Example: {"content_block":{"citations":[],"text":"","type":"text"},"index":0,"type":"content_block_start"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesContentBlockStartEvent? ContentBlockStart { get; init; }
#else
        public global::OpenRouter.MessagesContentBlockStartEvent? ContentBlockStart { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentBlockStart))]
#endif
        public bool IsContentBlockStart => ContentBlockStart != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickContentBlockStart(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.MessagesContentBlockStartEvent? value)
        {
            value = ContentBlockStart;
            return IsContentBlockStart;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockStartEvent PickContentBlockStart() => ContentBlockStart is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContentBlockStart' but the value was {ToString()}.");

        /// <summary>
        /// Event sent when content is added to a content block<br/>
        /// Example: {"delta":{"text":"Hello","type":"text_delta"},"index":0,"type":"content_block_delta"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesContentBlockDeltaEvent? ContentBlockDelta { get; init; }
#else
        public global::OpenRouter.MessagesContentBlockDeltaEvent? ContentBlockDelta { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentBlockDelta))]
#endif
        public bool IsContentBlockDelta => ContentBlockDelta != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickContentBlockDelta(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.MessagesContentBlockDeltaEvent? value)
        {
            value = ContentBlockDelta;
            return IsContentBlockDelta;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockDeltaEvent PickContentBlockDelta() => ContentBlockDelta is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContentBlockDelta' but the value was {ToString()}.");

        /// <summary>
        /// Event sent when a content block is complete<br/>
        /// Example: {"index":0,"type":"content_block_stop"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesContentBlockStopEvent? ContentBlockStop { get; init; }
#else
        public global::OpenRouter.MessagesContentBlockStopEvent? ContentBlockStop { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentBlockStop))]
#endif
        public bool IsContentBlockStop => ContentBlockStop != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickContentBlockStop(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.MessagesContentBlockStopEvent? value)
        {
            value = ContentBlockStop;
            return IsContentBlockStop;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesContentBlockStopEvent PickContentBlockStop() => ContentBlockStop is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContentBlockStop' but the value was {ToString()}.");

        /// <summary>
        /// Keep-alive ping event<br/>
        /// Example: {"type":"ping"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesPingEvent? Ping { get; init; }
#else
        public global::OpenRouter.MessagesPingEvent? Ping { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ping))]
#endif
        public bool IsPing => Ping != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPing(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.MessagesPingEvent? value)
        {
            value = Ping;
            return IsPing;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesPingEvent PickPing() => Ping is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Ping' but the value was {ToString()}.");

        /// <summary>
        /// Error event in the stream<br/>
        /// Example: {"error":{"error_type":"provider_overloaded","message":"Overloaded","type":"overloaded_error"},"type":"error"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesErrorEvent? Error { get; init; }
#else
        public global::OpenRouter.MessagesErrorEvent? Error { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.MessagesErrorEvent? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.MessagesErrorEvent PickError() => Error is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator MessagesStreamEvents(global::OpenRouter.MessagesStartEvent value) => new MessagesStreamEvents((global::OpenRouter.MessagesStartEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesStartEvent?(MessagesStreamEvents @this) => @this.MessageStart;

        /// <summary>
        ///
        /// </summary>
        public MessagesStreamEvents(global::OpenRouter.MessagesStartEvent? value)
        {
            MessageStart = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MessagesStreamEvents FromMessageStart(global::OpenRouter.MessagesStartEvent? value) => new MessagesStreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator MessagesStreamEvents(global::OpenRouter.MessagesDeltaEvent value) => new MessagesStreamEvents((global::OpenRouter.MessagesDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesDeltaEvent?(MessagesStreamEvents @this) => @this.MessageDelta;

        /// <summary>
        ///
        /// </summary>
        public MessagesStreamEvents(global::OpenRouter.MessagesDeltaEvent? value)
        {
            MessageDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MessagesStreamEvents FromMessageDelta(global::OpenRouter.MessagesDeltaEvent? value) => new MessagesStreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator MessagesStreamEvents(global::OpenRouter.MessagesStopEvent value) => new MessagesStreamEvents((global::OpenRouter.MessagesStopEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesStopEvent?(MessagesStreamEvents @this) => @this.MessageStop;

        /// <summary>
        ///
        /// </summary>
        public MessagesStreamEvents(global::OpenRouter.MessagesStopEvent? value)
        {
            MessageStop = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MessagesStreamEvents FromMessageStop(global::OpenRouter.MessagesStopEvent? value) => new MessagesStreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator MessagesStreamEvents(global::OpenRouter.MessagesContentBlockStartEvent value) => new MessagesStreamEvents((global::OpenRouter.MessagesContentBlockStartEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesContentBlockStartEvent?(MessagesStreamEvents @this) => @this.ContentBlockStart;

        /// <summary>
        ///
        /// </summary>
        public MessagesStreamEvents(global::OpenRouter.MessagesContentBlockStartEvent? value)
        {
            ContentBlockStart = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MessagesStreamEvents FromContentBlockStart(global::OpenRouter.MessagesContentBlockStartEvent? value) => new MessagesStreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator MessagesStreamEvents(global::OpenRouter.MessagesContentBlockDeltaEvent value) => new MessagesStreamEvents((global::OpenRouter.MessagesContentBlockDeltaEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesContentBlockDeltaEvent?(MessagesStreamEvents @this) => @this.ContentBlockDelta;

        /// <summary>
        ///
        /// </summary>
        public MessagesStreamEvents(global::OpenRouter.MessagesContentBlockDeltaEvent? value)
        {
            ContentBlockDelta = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MessagesStreamEvents FromContentBlockDelta(global::OpenRouter.MessagesContentBlockDeltaEvent? value) => new MessagesStreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator MessagesStreamEvents(global::OpenRouter.MessagesContentBlockStopEvent value) => new MessagesStreamEvents((global::OpenRouter.MessagesContentBlockStopEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesContentBlockStopEvent?(MessagesStreamEvents @this) => @this.ContentBlockStop;

        /// <summary>
        ///
        /// </summary>
        public MessagesStreamEvents(global::OpenRouter.MessagesContentBlockStopEvent? value)
        {
            ContentBlockStop = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MessagesStreamEvents FromContentBlockStop(global::OpenRouter.MessagesContentBlockStopEvent? value) => new MessagesStreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator MessagesStreamEvents(global::OpenRouter.MessagesPingEvent value) => new MessagesStreamEvents((global::OpenRouter.MessagesPingEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesPingEvent?(MessagesStreamEvents @this) => @this.Ping;

        /// <summary>
        ///
        /// </summary>
        public MessagesStreamEvents(global::OpenRouter.MessagesPingEvent? value)
        {
            Ping = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MessagesStreamEvents FromPing(global::OpenRouter.MessagesPingEvent? value) => new MessagesStreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator MessagesStreamEvents(global::OpenRouter.MessagesErrorEvent value) => new MessagesStreamEvents((global::OpenRouter.MessagesErrorEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesErrorEvent?(MessagesStreamEvents @this) => @this.Error;

        /// <summary>
        ///
        /// </summary>
        public MessagesStreamEvents(global::OpenRouter.MessagesErrorEvent? value)
        {
            Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MessagesStreamEvents FromError(global::OpenRouter.MessagesErrorEvent? value) => new MessagesStreamEvents(value);

        /// <summary>
        ///
        /// </summary>
        public MessagesStreamEvents(
            global::OpenRouter.MessagesStreamEventsDiscriminatorType? type,
            global::OpenRouter.MessagesStartEvent? messageStart,
            global::OpenRouter.MessagesDeltaEvent? messageDelta,
            global::OpenRouter.MessagesStopEvent? messageStop,
            global::OpenRouter.MessagesContentBlockStartEvent? contentBlockStart,
            global::OpenRouter.MessagesContentBlockDeltaEvent? contentBlockDelta,
            global::OpenRouter.MessagesContentBlockStopEvent? contentBlockStop,
            global::OpenRouter.MessagesPingEvent? ping,
            global::OpenRouter.MessagesErrorEvent? error
            )
        {
            Type = type;

            MessageStart = messageStart;
            MessageDelta = messageDelta;
            MessageStop = messageStop;
            ContentBlockStart = contentBlockStart;
            ContentBlockDelta = contentBlockDelta;
            ContentBlockStop = contentBlockStop;
            Ping = ping;
            Error = error;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Error as object ??
            Ping as object ??
            ContentBlockStop as object ??
            ContentBlockDelta as object ??
            ContentBlockStart as object ??
            MessageStop as object ??
            MessageDelta as object ??
            MessageStart as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            MessageStart?.ToString() ??
            MessageDelta?.ToString() ??
            MessageStop?.ToString() ??
            ContentBlockStart?.ToString() ??
            ContentBlockDelta?.ToString() ??
            ContentBlockStop?.ToString() ??
            Ping?.ToString() ??
            Error?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsMessageStart && !IsMessageDelta && !IsMessageStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsPing && !IsError || !IsMessageStart && IsMessageDelta && !IsMessageStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsPing && !IsError || !IsMessageStart && !IsMessageDelta && IsMessageStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsPing && !IsError || !IsMessageStart && !IsMessageDelta && !IsMessageStop && IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsPing && !IsError || !IsMessageStart && !IsMessageDelta && !IsMessageStop && !IsContentBlockStart && IsContentBlockDelta && !IsContentBlockStop && !IsPing && !IsError || !IsMessageStart && !IsMessageDelta && !IsMessageStop && !IsContentBlockStart && !IsContentBlockDelta && IsContentBlockStop && !IsPing && !IsError || !IsMessageStart && !IsMessageDelta && !IsMessageStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && IsPing && !IsError || !IsMessageStart && !IsMessageDelta && !IsMessageStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsPing && IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.MessagesStartEvent, TResult>? messageStart = null,
            global::System.Func<global::OpenRouter.MessagesDeltaEvent, TResult>? messageDelta = null,
            global::System.Func<global::OpenRouter.MessagesStopEvent, TResult>? messageStop = null,
            global::System.Func<global::OpenRouter.MessagesContentBlockStartEvent, TResult>? contentBlockStart = null,
            global::System.Func<global::OpenRouter.MessagesContentBlockDeltaEvent, TResult>? contentBlockDelta = null,
            global::System.Func<global::OpenRouter.MessagesContentBlockStopEvent, TResult>? contentBlockStop = null,
            global::System.Func<global::OpenRouter.MessagesPingEvent, TResult>? ping = null,
            global::System.Func<global::OpenRouter.MessagesErrorEvent, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (MessageStart is { } __value0 && messageStart != null)
            {
                return messageStart(__value0);
            }
            else if (MessageDelta is { } __value1 && messageDelta != null)
            {
                return messageDelta(__value1);
            }
            else if (MessageStop is { } __value2 && messageStop != null)
            {
                return messageStop(__value2);
            }
            else if (ContentBlockStart is { } __value3 && contentBlockStart != null)
            {
                return contentBlockStart(__value3);
            }
            else if (ContentBlockDelta is { } __value4 && contentBlockDelta != null)
            {
                return contentBlockDelta(__value4);
            }
            else if (ContentBlockStop is { } __value5 && contentBlockStop != null)
            {
                return contentBlockStop(__value5);
            }
            else if (Ping is { } __value6 && ping != null)
            {
                return ping(__value6);
            }
            else if (Error is { } __value7 && error != null)
            {
                return error(__value7);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.MessagesStartEvent>? messageStart = null,

            global::System.Action<global::OpenRouter.MessagesDeltaEvent>? messageDelta = null,

            global::System.Action<global::OpenRouter.MessagesStopEvent>? messageStop = null,

            global::System.Action<global::OpenRouter.MessagesContentBlockStartEvent>? contentBlockStart = null,

            global::System.Action<global::OpenRouter.MessagesContentBlockDeltaEvent>? contentBlockDelta = null,

            global::System.Action<global::OpenRouter.MessagesContentBlockStopEvent>? contentBlockStop = null,

            global::System.Action<global::OpenRouter.MessagesPingEvent>? ping = null,

            global::System.Action<global::OpenRouter.MessagesErrorEvent>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (MessageStart is { } __value0)
            {
                messageStart?.Invoke(__value0);
            }
            else if (MessageDelta is { } __value1)
            {
                messageDelta?.Invoke(__value1);
            }
            else if (MessageStop is { } __value2)
            {
                messageStop?.Invoke(__value2);
            }
            else if (ContentBlockStart is { } __value3)
            {
                contentBlockStart?.Invoke(__value3);
            }
            else if (ContentBlockDelta is { } __value4)
            {
                contentBlockDelta?.Invoke(__value4);
            }
            else if (ContentBlockStop is { } __value5)
            {
                contentBlockStop?.Invoke(__value5);
            }
            else if (Ping is { } __value6)
            {
                ping?.Invoke(__value6);
            }
            else if (Error is { } __value7)
            {
                error?.Invoke(__value7);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.MessagesStartEvent>? messageStart = null,
            global::System.Action<global::OpenRouter.MessagesDeltaEvent>? messageDelta = null,
            global::System.Action<global::OpenRouter.MessagesStopEvent>? messageStop = null,
            global::System.Action<global::OpenRouter.MessagesContentBlockStartEvent>? contentBlockStart = null,
            global::System.Action<global::OpenRouter.MessagesContentBlockDeltaEvent>? contentBlockDelta = null,
            global::System.Action<global::OpenRouter.MessagesContentBlockStopEvent>? contentBlockStop = null,
            global::System.Action<global::OpenRouter.MessagesPingEvent>? ping = null,
            global::System.Action<global::OpenRouter.MessagesErrorEvent>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (MessageStart is { } __value0)
            {
                messageStart?.Invoke(__value0);
            }
            else if (MessageDelta is { } __value1)
            {
                messageDelta?.Invoke(__value1);
            }
            else if (MessageStop is { } __value2)
            {
                messageStop?.Invoke(__value2);
            }
            else if (ContentBlockStart is { } __value3)
            {
                contentBlockStart?.Invoke(__value3);
            }
            else if (ContentBlockDelta is { } __value4)
            {
                contentBlockDelta?.Invoke(__value4);
            }
            else if (ContentBlockStop is { } __value5)
            {
                contentBlockStop?.Invoke(__value5);
            }
            else if (Ping is { } __value6)
            {
                ping?.Invoke(__value6);
            }
            else if (Error is { } __value7)
            {
                error?.Invoke(__value7);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessageStart,
                typeof(global::OpenRouter.MessagesStartEvent),
                MessageDelta,
                typeof(global::OpenRouter.MessagesDeltaEvent),
                MessageStop,
                typeof(global::OpenRouter.MessagesStopEvent),
                ContentBlockStart,
                typeof(global::OpenRouter.MessagesContentBlockStartEvent),
                ContentBlockDelta,
                typeof(global::OpenRouter.MessagesContentBlockDeltaEvent),
                ContentBlockStop,
                typeof(global::OpenRouter.MessagesContentBlockStopEvent),
                Ping,
                typeof(global::OpenRouter.MessagesPingEvent),
                Error,
                typeof(global::OpenRouter.MessagesErrorEvent),
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
        public bool Equals(MessagesStreamEvents other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesStartEvent?>.Default.Equals(MessageStart, other.MessageStart) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesDeltaEvent?>.Default.Equals(MessageDelta, other.MessageDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesStopEvent?>.Default.Equals(MessageStop, other.MessageStop) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesContentBlockStartEvent?>.Default.Equals(ContentBlockStart, other.ContentBlockStart) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesContentBlockDeltaEvent?>.Default.Equals(ContentBlockDelta, other.ContentBlockDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesContentBlockStopEvent?>.Default.Equals(ContentBlockStop, other.ContentBlockStop) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesPingEvent?>.Default.Equals(Ping, other.Ping) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesErrorEvent?>.Default.Equals(Error, other.Error)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(MessagesStreamEvents obj1, MessagesStreamEvents obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesStreamEvents>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(MessagesStreamEvents obj1, MessagesStreamEvents obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesStreamEvents o && Equals(o);
        }
    }
}
