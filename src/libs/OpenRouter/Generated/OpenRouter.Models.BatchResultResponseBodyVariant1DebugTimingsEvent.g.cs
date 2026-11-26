
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BatchResultResponseBodyVariant1DebugTimingsEvent : global::System.IEquatable<BatchResultResponseBodyVariant1DebugTimingsEvent>
    {
        /// <summary>
        ///
        /// </summary>
        public BatchResultResponseBodyVariant1DebugTimingsEvent(string value)
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
        public static BatchResultResponseBodyVariant1DebugTimingsEvent AdapterRequest { get; } = new("adapter_request");

        /// <summary>
        ///
        /// </summary>
        public static BatchResultResponseBodyVariant1DebugTimingsEvent FirstTokenReceived { get; } = new("first_token_received");

        /// <summary>
        ///
        /// </summary>
        public static BatchResultResponseBodyVariant1DebugTimingsEvent UpstreamBodyEnded { get; } = new("upstream_body_ended");

        /// <summary>
        ///
        /// </summary>
        public static BatchResultResponseBodyVariant1DebugTimingsEvent UpstreamHeadersReceived { get; } = new("upstream_headers_received");
        /// <summary>
        ///
        /// </summary>
        public static BatchResultResponseBodyVariant1DebugTimingsEvent FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "adapter_request" => AdapterRequest,
                "first_token_received" => FirstTokenReceived,
                "upstream_body_ended" => UpstreamBodyEnded,
                "upstream_headers_received" => UpstreamHeadersReceived,
                _ => new BatchResultResponseBodyVariant1DebugTimingsEvent(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "adapter_request" => true,
            "first_token_received" => true,
            "upstream_body_ended" => true,
            "upstream_headers_received" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(BatchResultResponseBodyVariant1DebugTimingsEvent other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BatchResultResponseBodyVariant1DebugTimingsEvent other && Equals(other);
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
        public static bool operator ==(BatchResultResponseBodyVariant1DebugTimingsEvent left, BatchResultResponseBodyVariant1DebugTimingsEvent right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BatchResultResponseBodyVariant1DebugTimingsEvent left, BatchResultResponseBodyVariant1DebugTimingsEvent right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchResultResponseBodyVariant1DebugTimingsEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchResultResponseBodyVariant1DebugTimingsEvent value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchResultResponseBodyVariant1DebugTimingsEvent? ToEnum(string value)
        {
            return BatchResultResponseBodyVariant1DebugTimingsEvent.FromValue(value);
        }
    }
}