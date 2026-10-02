
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// A stable reason a client can branch on.
    /// </summary>
    public readonly partial struct InternChatErrorMetadataReason : global::System.IEquatable<InternChatErrorMetadataReason>
    {
        /// <summary>
        ///
        /// </summary>
        public InternChatErrorMetadataReason(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        ///
        /// </summary>
        public static InternChatErrorMetadataReason AttachmentFailed { get; } = new("attachment_failed");

        /// <summary>
        ///
        /// </summary>
        public static InternChatErrorMetadataReason BadRequest { get; } = new("bad_request");

        /// <summary>
        ///
        /// </summary>
        public static InternChatErrorMetadataReason Busy { get; } = new("busy");

        /// <summary>
        ///
        /// </summary>
        public static InternChatErrorMetadataReason ClientClosedRequest { get; } = new("client_closed_request");

        /// <summary>
        ///
        /// </summary>
        public static InternChatErrorMetadataReason InteractionNotPending { get; } = new("interaction_not_pending");

        /// <summary>
        ///
        /// </summary>
        public static InternChatErrorMetadataReason InteractionUnknown { get; } = new("interaction_unknown");

        /// <summary>
        ///
        /// </summary>
        public static InternChatErrorMetadataReason InternNotReady { get; } = new("intern_not_ready");

        /// <summary>
        ///
        /// </summary>
        public static InternChatErrorMetadataReason InternRejected { get; } = new("intern_rejected");

        /// <summary>
        ///
        /// </summary>
        public static InternChatErrorMetadataReason InternUnreachable { get; } = new("intern_unreachable");

        /// <summary>
        ///
        /// </summary>
        public static InternChatErrorMetadataReason NotFound { get; } = new("not_found");

        /// <summary>
        ///
        /// </summary>
        public static InternChatErrorMetadataReason PayloadTooLarge { get; } = new("payload_too_large");

        /// <summary>
        ///
        /// </summary>
        public static InternChatErrorMetadataReason RateLimited { get; } = new("rate_limited");

        /// <summary>
        ///
        /// </summary>
        public static InternChatErrorMetadataReason RunEnded { get; } = new("run_ended");

        /// <summary>
        ///
        /// </summary>
        public static InternChatErrorMetadataReason StreamSevered { get; } = new("stream_severed");

        /// <summary>
        ///
        /// </summary>
        public static InternChatErrorMetadataReason Timeout { get; } = new("timeout");

        /// <summary>
        ///
        /// </summary>
        public static InternChatErrorMetadataReason TurnFailed { get; } = new("turn_failed");
        /// <summary>
        ///
        /// </summary>
        public static InternChatErrorMetadataReason FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "attachment_failed" => AttachmentFailed,
                "bad_request" => BadRequest,
                "busy" => Busy,
                "client_closed_request" => ClientClosedRequest,
                "interaction_not_pending" => InteractionNotPending,
                "interaction_unknown" => InteractionUnknown,
                "intern_not_ready" => InternNotReady,
                "intern_rejected" => InternRejected,
                "intern_unreachable" => InternUnreachable,
                "not_found" => NotFound,
                "payload_too_large" => PayloadTooLarge,
                "rate_limited" => RateLimited,
                "run_ended" => RunEnded,
                "stream_severed" => StreamSevered,
                "timeout" => Timeout,
                "turn_failed" => TurnFailed,
                _ => new InternChatErrorMetadataReason(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "attachment_failed" => true,
            "bad_request" => true,
            "busy" => true,
            "client_closed_request" => true,
            "interaction_not_pending" => true,
            "interaction_unknown" => true,
            "intern_not_ready" => true,
            "intern_rejected" => true,
            "intern_unreachable" => true,
            "not_found" => true,
            "payload_too_large" => true,
            "rate_limited" => true,
            "run_ended" => true,
            "stream_severed" => true,
            "timeout" => true,
            "turn_failed" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(InternChatErrorMetadataReason other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InternChatErrorMetadataReason other && Equals(other);
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            return global::System.StringComparer.Ordinal.GetHashCode(Value ?? string.Empty);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(InternChatErrorMetadataReason left, InternChatErrorMetadataReason right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InternChatErrorMetadataReason left, InternChatErrorMetadataReason right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InternChatErrorMetadataReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InternChatErrorMetadataReason value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InternChatErrorMetadataReason? ToEnum(string value)
        {
            return InternChatErrorMetadataReason.FromValue(value);
        }
    }
}