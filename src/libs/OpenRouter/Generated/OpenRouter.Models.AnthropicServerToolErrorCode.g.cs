
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: unavailable
    /// </summary>
    public readonly partial struct AnthropicServerToolErrorCode : global::System.IEquatable<AnthropicServerToolErrorCode>
    {
        /// <summary>
        ///
        /// </summary>
        public AnthropicServerToolErrorCode(string value)
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
        public static AnthropicServerToolErrorCode ExecutionTimeExceeded { get; } = new("execution_time_exceeded");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicServerToolErrorCode InvalidToolInput { get; } = new("invalid_tool_input");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicServerToolErrorCode TooManyRequests { get; } = new("too_many_requests");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicServerToolErrorCode Unavailable { get; } = new("unavailable");
        /// <summary>
        ///
        /// </summary>
        public static AnthropicServerToolErrorCode FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "execution_time_exceeded" => ExecutionTimeExceeded,
                "invalid_tool_input" => InvalidToolInput,
                "too_many_requests" => TooManyRequests,
                "unavailable" => Unavailable,
                _ => new AnthropicServerToolErrorCode(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "execution_time_exceeded" => true,
            "invalid_tool_input" => true,
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
        public bool Equals(AnthropicServerToolErrorCode other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicServerToolErrorCode other && Equals(other);
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
        public static bool operator ==(AnthropicServerToolErrorCode left, AnthropicServerToolErrorCode right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicServerToolErrorCode left, AnthropicServerToolErrorCode right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicServerToolErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicServerToolErrorCode value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicServerToolErrorCode? ToEnum(string value)
        {
            return AnthropicServerToolErrorCode.FromValue(value);
        }
    }
}