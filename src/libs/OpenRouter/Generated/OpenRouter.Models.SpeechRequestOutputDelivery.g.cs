
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// `stream` (default) streams the audio bytes directly in the response body. `url` stores the generated audio in OpenRouter storage and returns a JSON response with a signed download `url`, `expires_at`, and `media_type`. The URL is a bearer link: anyone holding it can download the audio until it expires, up to 24 hours after the audio was stored (use `expires_at`); the stored copy is deleted by the storage lifecycle within the following day. Falls back to streaming raw audio bytes when a URL cannot be issued because zero-data-retention applies (account settings, guardrails, `provider.zdr`, or a ZDR endpoint) or the request has no workspace.<br/>
    /// Example: stream
    /// </summary>
    public readonly partial struct SpeechRequestOutputDelivery : global::System.IEquatable<SpeechRequestOutputDelivery>
    {
        /// <summary>
        ///
        /// </summary>
        public SpeechRequestOutputDelivery(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// anyone holding it can download the audio until it expires, up to 24 hours after the audio was stored (use `expires_at`); the stored copy is deleted by the storage lifecycle within the following day. Falls back to streaming raw audio bytes when a URL cannot be issued because zero-data-retention applies (account settings, guardrails, `provider.zdr`, or a ZDR endpoint) or the request has no workspace.
        /// </summary>
        public static SpeechRequestOutputDelivery Stream { get; } = new("stream");

        /// <summary>
        /// anyone holding it can download the audio until it expires, up to 24 hours after the audio was stored (use `expires_at`); the stored copy is deleted by the storage lifecycle within the following day. Falls back to streaming raw audio bytes when a URL cannot be issued because zero-data-retention applies (account settings, guardrails, `provider.zdr`, or a ZDR endpoint) or the request has no workspace.
        /// </summary>
        public static SpeechRequestOutputDelivery Url { get; } = new("url");
        /// <summary>
        ///
        /// </summary>
        public static SpeechRequestOutputDelivery FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "stream" => Stream,
                "url" => Url,
                _ => new SpeechRequestOutputDelivery(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "stream" => true,
            "url" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(SpeechRequestOutputDelivery other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SpeechRequestOutputDelivery other && Equals(other);
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
        public static bool operator ==(SpeechRequestOutputDelivery left, SpeechRequestOutputDelivery right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SpeechRequestOutputDelivery left, SpeechRequestOutputDelivery right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechRequestOutputDeliveryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechRequestOutputDelivery value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechRequestOutputDelivery? ToEnum(string value)
        {
            return SpeechRequestOutputDelivery.FromValue(value);
        }
    }
}