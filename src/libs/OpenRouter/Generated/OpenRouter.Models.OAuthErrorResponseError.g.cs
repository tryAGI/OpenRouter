
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct OAuthErrorResponseError : global::System.IEquatable<OAuthErrorResponseError>
    {
        /// <summary>
        ///
        /// </summary>
        public OAuthErrorResponseError(string value)
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
        public static OAuthErrorResponseError InvalidGrant { get; } = new("invalid_grant");

        /// <summary>
        ///
        /// </summary>
        public static OAuthErrorResponseError InvalidRequest { get; } = new("invalid_request");

        /// <summary>
        ///
        /// </summary>
        public static OAuthErrorResponseError InvalidScope { get; } = new("invalid_scope");

        /// <summary>
        ///
        /// </summary>
        public static OAuthErrorResponseError ServerError { get; } = new("server_error");

        /// <summary>
        ///
        /// </summary>
        public static OAuthErrorResponseError TemporarilyUnavailable { get; } = new("temporarily_unavailable");

        /// <summary>
        ///
        /// </summary>
        public static OAuthErrorResponseError UnsupportedGrantType { get; } = new("unsupported_grant_type");
        /// <summary>
        ///
        /// </summary>
        public static OAuthErrorResponseError FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "invalid_grant" => InvalidGrant,
                "invalid_request" => InvalidRequest,
                "invalid_scope" => InvalidScope,
                "server_error" => ServerError,
                "temporarily_unavailable" => TemporarilyUnavailable,
                "unsupported_grant_type" => UnsupportedGrantType,
                _ => new OAuthErrorResponseError(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "invalid_grant" => true,
            "invalid_request" => true,
            "invalid_scope" => true,
            "server_error" => true,
            "temporarily_unavailable" => true,
            "unsupported_grant_type" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(OAuthErrorResponseError other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OAuthErrorResponseError other && Equals(other);
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
        public static bool operator ==(OAuthErrorResponseError left, OAuthErrorResponseError right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OAuthErrorResponseError left, OAuthErrorResponseError right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OAuthErrorResponseErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OAuthErrorResponseError value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OAuthErrorResponseError? ToEnum(string value)
        {
            return OAuthErrorResponseError.FromValue(value);
        }
    }
}