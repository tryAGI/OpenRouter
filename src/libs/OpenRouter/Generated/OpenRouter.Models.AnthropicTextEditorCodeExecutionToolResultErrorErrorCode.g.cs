
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AnthropicTextEditorCodeExecutionToolResultErrorErrorCode : global::System.IEquatable<AnthropicTextEditorCodeExecutionToolResultErrorErrorCode>
    {
        /// <summary>
        ///
        /// </summary>
        public AnthropicTextEditorCodeExecutionToolResultErrorErrorCode(string value)
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
        public static AnthropicTextEditorCodeExecutionToolResultErrorErrorCode ExecutionTimeExceeded { get; } = new("execution_time_exceeded");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicTextEditorCodeExecutionToolResultErrorErrorCode FileNotFound { get; } = new("file_not_found");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicTextEditorCodeExecutionToolResultErrorErrorCode InvalidToolInput { get; } = new("invalid_tool_input");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicTextEditorCodeExecutionToolResultErrorErrorCode TooManyRequests { get; } = new("too_many_requests");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicTextEditorCodeExecutionToolResultErrorErrorCode Unavailable { get; } = new("unavailable");
        /// <summary>
        ///
        /// </summary>
        public static AnthropicTextEditorCodeExecutionToolResultErrorErrorCode FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "execution_time_exceeded" => ExecutionTimeExceeded,
                "file_not_found" => FileNotFound,
                "invalid_tool_input" => InvalidToolInput,
                "too_many_requests" => TooManyRequests,
                "unavailable" => Unavailable,
                _ => new AnthropicTextEditorCodeExecutionToolResultErrorErrorCode(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "execution_time_exceeded" => true,
            "file_not_found" => true,
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
        public bool Equals(AnthropicTextEditorCodeExecutionToolResultErrorErrorCode other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicTextEditorCodeExecutionToolResultErrorErrorCode other && Equals(other);
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
        public static bool operator ==(AnthropicTextEditorCodeExecutionToolResultErrorErrorCode left, AnthropicTextEditorCodeExecutionToolResultErrorErrorCode right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicTextEditorCodeExecutionToolResultErrorErrorCode left, AnthropicTextEditorCodeExecutionToolResultErrorErrorCode right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicTextEditorCodeExecutionToolResultErrorErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicTextEditorCodeExecutionToolResultErrorErrorCode value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicTextEditorCodeExecutionToolResultErrorErrorCode? ToEnum(string value)
        {
            return AnthropicTextEditorCodeExecutionToolResultErrorErrorCode.FromValue(value);
        }
    }
}