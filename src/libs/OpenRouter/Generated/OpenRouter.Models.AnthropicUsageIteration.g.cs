#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"cache_creation":null,"cache_creation_input_tokens":0,"cache_read_input_tokens":0,"input_tokens":100,"output_tokens":50,"type":"message"}
    /// </summary>
    public readonly partial struct AnthropicUsageIteration : global::System.IEquatable<AnthropicUsageIteration>
    {
        /// <summary>
        /// Example: {"cache_creation":null,"cache_creation_input_tokens":0,"cache_read_input_tokens":0,"input_tokens":50,"output_tokens":25,"type":"compaction"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicCompactionUsageIteration? Compaction { get; init; }
#else
        public global::OpenRouter.AnthropicCompactionUsageIteration? Compaction { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Compaction))]
#endif
        public bool IsCompaction => Compaction != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCompaction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicCompactionUsageIteration? value)
        {
            value = Compaction;
            return IsCompaction;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicCompactionUsageIteration PickCompaction() => Compaction is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Compaction' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"cache_creation":null,"cache_creation_input_tokens":0,"cache_read_input_tokens":0,"input_tokens":100,"output_tokens":50,"type":"message"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicMessageUsageIteration? Message { get; init; }
#else
        public global::OpenRouter.AnthropicMessageUsageIteration? Message { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message))]
#endif
        public bool IsMessage => Message != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicMessageUsageIteration? value)
        {
            value = Message;
            return IsMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicMessageUsageIteration PickMessage() => Message is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Message' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"cache_creation":null,"cache_creation_input_tokens":0,"cache_read_input_tokens":0,"input_tokens":823,"model":"claude-opus-4-6","output_tokens":1612,"type":"advisor_message"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicAdvisorMessageUsageIteration? AdvisorMessage { get; init; }
#else
        public global::OpenRouter.AnthropicAdvisorMessageUsageIteration? AdvisorMessage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AdvisorMessage))]
#endif
        public bool IsAdvisorMessage => AdvisorMessage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAdvisorMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicAdvisorMessageUsageIteration? value)
        {
            value = AdvisorMessage;
            return IsAdvisorMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicAdvisorMessageUsageIteration PickAdvisorMessage() => AdvisorMessage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AdvisorMessage' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"cache_creation":null,"cache_creation_input_tokens":0,"cache_read_input_tokens":0,"input_tokens":100,"output_tokens":50,"type":"unknown"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicUnknownUsageIteration? Unknown { get; init; }
#else
        public global::OpenRouter.AnthropicUnknownUsageIteration? Unknown { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Unknown))]
#endif
        public bool IsUnknown => Unknown != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnknown(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicUnknownUsageIteration? value)
        {
            value = Unknown;
            return IsUnknown;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicUnknownUsageIteration PickUnknown() => Unknown is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Unknown' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicUsageIteration(global::OpenRouter.AnthropicCompactionUsageIteration value) => new AnthropicUsageIteration((global::OpenRouter.AnthropicCompactionUsageIteration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicCompactionUsageIteration?(AnthropicUsageIteration @this) => @this.Compaction;

        /// <summary>
        ///
        /// </summary>
        public AnthropicUsageIteration(global::OpenRouter.AnthropicCompactionUsageIteration? value)
        {
            Compaction = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicUsageIteration FromCompaction(global::OpenRouter.AnthropicCompactionUsageIteration? value) => new AnthropicUsageIteration(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicUsageIteration(global::OpenRouter.AnthropicMessageUsageIteration value) => new AnthropicUsageIteration((global::OpenRouter.AnthropicMessageUsageIteration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicMessageUsageIteration?(AnthropicUsageIteration @this) => @this.Message;

        /// <summary>
        ///
        /// </summary>
        public AnthropicUsageIteration(global::OpenRouter.AnthropicMessageUsageIteration? value)
        {
            Message = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicUsageIteration FromMessage(global::OpenRouter.AnthropicMessageUsageIteration? value) => new AnthropicUsageIteration(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicUsageIteration(global::OpenRouter.AnthropicAdvisorMessageUsageIteration value) => new AnthropicUsageIteration((global::OpenRouter.AnthropicAdvisorMessageUsageIteration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicAdvisorMessageUsageIteration?(AnthropicUsageIteration @this) => @this.AdvisorMessage;

        /// <summary>
        ///
        /// </summary>
        public AnthropicUsageIteration(global::OpenRouter.AnthropicAdvisorMessageUsageIteration? value)
        {
            AdvisorMessage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicUsageIteration FromAdvisorMessage(global::OpenRouter.AnthropicAdvisorMessageUsageIteration? value) => new AnthropicUsageIteration(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicUsageIteration(global::OpenRouter.AnthropicUnknownUsageIteration value) => new AnthropicUsageIteration((global::OpenRouter.AnthropicUnknownUsageIteration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicUnknownUsageIteration?(AnthropicUsageIteration @this) => @this.Unknown;

        /// <summary>
        ///
        /// </summary>
        public AnthropicUsageIteration(global::OpenRouter.AnthropicUnknownUsageIteration? value)
        {
            Unknown = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicUsageIteration FromUnknown(global::OpenRouter.AnthropicUnknownUsageIteration? value) => new AnthropicUsageIteration(value);

        /// <summary>
        ///
        /// </summary>
        public AnthropicUsageIteration(
            global::OpenRouter.AnthropicCompactionUsageIteration? compaction,
            global::OpenRouter.AnthropicMessageUsageIteration? message,
            global::OpenRouter.AnthropicAdvisorMessageUsageIteration? advisorMessage,
            global::OpenRouter.AnthropicUnknownUsageIteration? unknown
            )
        {
            Compaction = compaction;
            Message = message;
            AdvisorMessage = advisorMessage;
            Unknown = unknown;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Unknown as object ??
            AdvisorMessage as object ??
            Message as object ??
            Compaction as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Compaction?.ToString() ??
            Message?.ToString() ??
            AdvisorMessage?.ToString() ??
            Unknown?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCompaction || IsMessage || IsAdvisorMessage || IsUnknown;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicCompactionUsageIteration?, TResult>? compaction = null,
            global::System.Func<global::OpenRouter.AnthropicMessageUsageIteration?, TResult>? message = null,
            global::System.Func<global::OpenRouter.AnthropicAdvisorMessageUsageIteration?, TResult>? advisorMessage = null,
            global::System.Func<global::OpenRouter.AnthropicUnknownUsageIteration?, TResult>? unknown = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Compaction is { } __value0 && compaction != null)
            {
                return compaction(__value0);
            }
            else if (Message is { } __value1 && message != null)
            {
                return message(__value1);
            }
            else if (AdvisorMessage is { } __value2 && advisorMessage != null)
            {
                return advisorMessage(__value2);
            }
            else if (Unknown is { } __value3 && unknown != null)
            {
                return unknown(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicCompactionUsageIteration?>? compaction = null,

            global::System.Action<global::OpenRouter.AnthropicMessageUsageIteration?>? message = null,

            global::System.Action<global::OpenRouter.AnthropicAdvisorMessageUsageIteration?>? advisorMessage = null,

            global::System.Action<global::OpenRouter.AnthropicUnknownUsageIteration?>? unknown = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Compaction is { } __value0)
            {
                compaction?.Invoke(__value0);
            }
            else if (Message is { } __value1)
            {
                message?.Invoke(__value1);
            }
            else if (AdvisorMessage is { } __value2)
            {
                advisorMessage?.Invoke(__value2);
            }
            else if (Unknown is { } __value3)
            {
                unknown?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AnthropicCompactionUsageIteration?>? compaction = null,
            global::System.Action<global::OpenRouter.AnthropicMessageUsageIteration?>? message = null,
            global::System.Action<global::OpenRouter.AnthropicAdvisorMessageUsageIteration?>? advisorMessage = null,
            global::System.Action<global::OpenRouter.AnthropicUnknownUsageIteration?>? unknown = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Compaction is { } __value0)
            {
                compaction?.Invoke(__value0);
            }
            else if (Message is { } __value1)
            {
                message?.Invoke(__value1);
            }
            else if (AdvisorMessage is { } __value2)
            {
                advisorMessage?.Invoke(__value2);
            }
            else if (Unknown is { } __value3)
            {
                unknown?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Compaction,
                typeof(global::OpenRouter.AnthropicCompactionUsageIteration),
                Message,
                typeof(global::OpenRouter.AnthropicMessageUsageIteration),
                AdvisorMessage,
                typeof(global::OpenRouter.AnthropicAdvisorMessageUsageIteration),
                Unknown,
                typeof(global::OpenRouter.AnthropicUnknownUsageIteration),
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
        public bool Equals(AnthropicUsageIteration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicCompactionUsageIteration?>.Default.Equals(Compaction, other.Compaction) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicMessageUsageIteration?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicAdvisorMessageUsageIteration?>.Default.Equals(AdvisorMessage, other.AdvisorMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicUnknownUsageIteration?>.Default.Equals(Unknown, other.Unknown)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AnthropicUsageIteration obj1, AnthropicUsageIteration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicUsageIteration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicUsageIteration obj1, AnthropicUsageIteration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicUsageIteration o && Equals(o);
        }
    }
}
