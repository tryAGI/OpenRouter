
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AnthropicWebSearchToolResultErrorErrorCode : global::System.IEquatable<AnthropicWebSearchToolResultErrorErrorCode>
    {
        /// <summary>
        ///
        /// </summary>
        public AnthropicWebSearchToolResultErrorErrorCode(string value)
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
        public static AnthropicWebSearchToolResultErrorErrorCode InvalidToolInput { get; } = new("invalid_tool_input");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicWebSearchToolResultErrorErrorCode MaxUsesExceeded { get; } = new("max_uses_exceeded");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicWebSearchToolResultErrorErrorCode QueryTooLong { get; } = new("query_too_long");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicWebSearchToolResultErrorErrorCode RequestTooLarge { get; } = new("request_too_large");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicWebSearchToolResultErrorErrorCode TooManyRequests { get; } = new("too_many_requests");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicWebSearchToolResultErrorErrorCode Unavailable { get; } = new("unavailable");
        /// <summary>
        ///
        /// </summary>
        public static AnthropicWebSearchToolResultErrorErrorCode FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "invalid_tool_input" => InvalidToolInput,
                "max_uses_exceeded" => MaxUsesExceeded,
                "query_too_long" => QueryTooLong,
                "request_too_large" => RequestTooLarge,
                "too_many_requests" => TooManyRequests,
                "unavailable" => Unavailable,
                _ => new AnthropicWebSearchToolResultErrorErrorCode(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "invalid_tool_input" => true,
            "max_uses_exceeded" => true,
            "query_too_long" => true,
            "request_too_large" => true,
            "too_many_requests" => true,
            "unavailable" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AnthropicWebSearchToolResultErrorErrorCode other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicWebSearchToolResultErrorErrorCode other && Equals(other);
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
        public static bool operator ==(AnthropicWebSearchToolResultErrorErrorCode left, AnthropicWebSearchToolResultErrorErrorCode right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicWebSearchToolResultErrorErrorCode left, AnthropicWebSearchToolResultErrorErrorCode right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicWebSearchToolResultErrorErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicWebSearchToolResultErrorErrorCode value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicWebSearchToolResultErrorErrorCode? ToEnum(string value)
        {
            return AnthropicWebSearchToolResultErrorErrorCode.FromValue(value);
        }
    }
}