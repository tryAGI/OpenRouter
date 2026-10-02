
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AnthropicMessagesErrorResponseErrorType : global::System.IEquatable<AnthropicMessagesErrorResponseErrorType>
    {
        /// <summary>
        ///
        /// </summary>
        public AnthropicMessagesErrorResponseErrorType(string value)
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
        public static AnthropicMessagesErrorResponseErrorType ApiError { get; } = new("api_error");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicMessagesErrorResponseErrorType AuthenticationError { get; } = new("authentication_error");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicMessagesErrorResponseErrorType BillingError { get; } = new("billing_error");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicMessagesErrorResponseErrorType InvalidRequestError { get; } = new("invalid_request_error");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicMessagesErrorResponseErrorType NotFoundError { get; } = new("not_found_error");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicMessagesErrorResponseErrorType OverloadedError { get; } = new("overloaded_error");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicMessagesErrorResponseErrorType PermissionError { get; } = new("permission_error");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicMessagesErrorResponseErrorType RateLimitError { get; } = new("rate_limit_error");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicMessagesErrorResponseErrorType TimeoutError { get; } = new("timeout_error");
        /// <summary>
        ///
        /// </summary>
        public static AnthropicMessagesErrorResponseErrorType FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "api_error" => ApiError,
                "authentication_error" => AuthenticationError,
                "billing_error" => BillingError,
                "invalid_request_error" => InvalidRequestError,
                "not_found_error" => NotFoundError,
                "overloaded_error" => OverloadedError,
                "permission_error" => PermissionError,
                "rate_limit_error" => RateLimitError,
                "timeout_error" => TimeoutError,
                _ => new AnthropicMessagesErrorResponseErrorType(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "api_error" => true,
            "authentication_error" => true,
            "billing_error" => true,
            "invalid_request_error" => true,
            "not_found_error" => true,
            "overloaded_error" => true,
            "permission_error" => true,
            "rate_limit_error" => true,
            "timeout_error" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AnthropicMessagesErrorResponseErrorType other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicMessagesErrorResponseErrorType other && Equals(other);
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
        public static bool operator ==(AnthropicMessagesErrorResponseErrorType left, AnthropicMessagesErrorResponseErrorType right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicMessagesErrorResponseErrorType left, AnthropicMessagesErrorResponseErrorType right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicMessagesErrorResponseErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicMessagesErrorResponseErrorType value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicMessagesErrorResponseErrorType? ToEnum(string value)
        {
            return AnthropicMessagesErrorResponseErrorType.FromValue(value);
        }
    }
}