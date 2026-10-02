
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AnthropicBashCodeExecutionToolResultErrorErrorCode : global::System.IEquatable<AnthropicBashCodeExecutionToolResultErrorErrorCode>
    {
        /// <summary>
        ///
        /// </summary>
        public AnthropicBashCodeExecutionToolResultErrorErrorCode(string value)
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
        public static AnthropicBashCodeExecutionToolResultErrorErrorCode ExecutionTimeExceeded { get; } = new("execution_time_exceeded");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicBashCodeExecutionToolResultErrorErrorCode InvalidToolInput { get; } = new("invalid_tool_input");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicBashCodeExecutionToolResultErrorErrorCode OutputFileTooLarge { get; } = new("output_file_too_large");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicBashCodeExecutionToolResultErrorErrorCode TooManyRequests { get; } = new("too_many_requests");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicBashCodeExecutionToolResultErrorErrorCode Unavailable { get; } = new("unavailable");
        /// <summary>
        ///
        /// </summary>
        public static AnthropicBashCodeExecutionToolResultErrorErrorCode FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "execution_time_exceeded" => ExecutionTimeExceeded,
                "invalid_tool_input" => InvalidToolInput,
                "output_file_too_large" => OutputFileTooLarge,
                "too_many_requests" => TooManyRequests,
                "unavailable" => Unavailable,
                _ => new AnthropicBashCodeExecutionToolResultErrorErrorCode(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "execution_time_exceeded" => true,
            "invalid_tool_input" => true,
            "output_file_too_large" => true,
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
        public bool Equals(AnthropicBashCodeExecutionToolResultErrorErrorCode other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicBashCodeExecutionToolResultErrorErrorCode other && Equals(other);
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
        public static bool operator ==(AnthropicBashCodeExecutionToolResultErrorErrorCode left, AnthropicBashCodeExecutionToolResultErrorErrorCode right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicBashCodeExecutionToolResultErrorErrorCode left, AnthropicBashCodeExecutionToolResultErrorErrorCode right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicBashCodeExecutionToolResultErrorErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicBashCodeExecutionToolResultErrorErrorCode value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicBashCodeExecutionToolResultErrorErrorCode? ToEnum(string value)
        {
            return AnthropicBashCodeExecutionToolResultErrorErrorCode.FromValue(value);
        }
    }
}