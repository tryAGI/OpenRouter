#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An output message item<br/>
    /// Example: {"content":[{"annotations":[],"text":"Hello! How can I help you?","type":"output_text"}],"id":"msg-123","role":"assistant","status":"completed","type":"message"}
    /// </summary>
    public readonly partial struct OutputMessageItem : global::System.IEquatable<OutputMessageItem>
    {
        /// <summary>
        /// Example: {"content":[{"text":"Hello! How can I help you today?","type":"output_text"}],"id":"msg-abc123","role":"assistant","status":"completed","type":"message"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputMessage? OutputMessage { get; init; }
#else
        public global::OpenRouter.OutputMessage? OutputMessage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputMessage))]
#endif
        public bool IsOutputMessage => OutputMessage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OutputMessage? value)
        {
            value = OutputMessage;
            return IsOutputMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OutputMessage PickOutputMessage() => OutputMessage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputMessage' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? OutputMessageItemVariant2 { get; init; }
#else
        public object? OutputMessageItemVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputMessageItemVariant2))]
#endif
        public bool IsOutputMessageItemVariant2 => OutputMessageItemVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOutputMessageItemVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = OutputMessageItemVariant2;
            return IsOutputMessageItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickOutputMessageItemVariant2() => OutputMessageItemVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OutputMessageItemVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator OutputMessageItem(global::OpenRouter.OutputMessage value) => new OutputMessageItem((global::OpenRouter.OutputMessage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OutputMessage?(OutputMessageItem @this) => @this.OutputMessage;

        /// <summary>
        ///
        /// </summary>
        public OutputMessageItem(global::OpenRouter.OutputMessage? value)
        {
            OutputMessage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OutputMessageItem FromOutputMessage(global::OpenRouter.OutputMessage? value) => new OutputMessageItem(value);

        /// <summary>
        ///
        /// </summary>
        public OutputMessageItem(
            global::OpenRouter.OutputMessage? outputMessage,
            object? outputMessageItemVariant2
            )
        {
            OutputMessage = outputMessage;
            OutputMessageItemVariant2 = outputMessageItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            OutputMessageItemVariant2 as object ??
            OutputMessage as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OutputMessage?.ToString() ??
            OutputMessageItemVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOutputMessage && IsOutputMessageItemVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OutputMessage, TResult>? outputMessage = null,
            global::System.Func<object, TResult>? outputMessageItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OutputMessage is { } __value0 && outputMessage != null)
            {
                return outputMessage(__value0);
            }
            else if (OutputMessageItemVariant2 is { } __value1 && outputMessageItemVariant2 != null)
            {
                return outputMessageItemVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OutputMessage>? outputMessage = null,

            global::System.Action<object>? outputMessageItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OutputMessage is { } __value0)
            {
                outputMessage?.Invoke(__value0);
            }
            else if (OutputMessageItemVariant2 is { } __value1)
            {
                outputMessageItemVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OutputMessage>? outputMessage = null,
            global::System.Action<object>? outputMessageItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OutputMessage is { } __value0)
            {
                outputMessage?.Invoke(__value0);
            }
            else if (OutputMessageItemVariant2 is { } __value1)
            {
                outputMessageItemVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OutputMessage,
                typeof(global::OpenRouter.OutputMessage),
                OutputMessageItemVariant2,
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
        public bool Equals(OutputMessageItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputMessage?>.Default.Equals(OutputMessage, other.OutputMessage) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(OutputMessageItemVariant2, other.OutputMessageItemVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(OutputMessageItem obj1, OutputMessageItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputMessageItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OutputMessageItem obj1, OutputMessageItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputMessageItem o && Equals(o);
        }
    }
}
