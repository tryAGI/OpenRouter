
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: stop
    /// </summary>
    public readonly partial struct FinishReason : global::System.IEquatable<FinishReason>
    {
        /// <summary>
        ///
        /// </summary>
        public FinishReason(string value)
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
        public static FinishReason ContentFilter { get; } = new("content_filter");

        /// <summary>
        ///
        /// </summary>
        public static FinishReason FunctionCall { get; } = new("function_call");

        /// <summary>
        ///
        /// </summary>
        public static FinishReason Length { get; } = new("length");

        /// <summary>
        ///
        /// </summary>
        public static FinishReason Stop { get; } = new("stop");

        /// <summary>
        ///
        /// </summary>
        public static FinishReason ToolCalls { get; } = new("tool_calls");
        /// <summary>
        ///
        /// </summary>
        public static FinishReason FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "content_filter" => ContentFilter,
                "function_call" => FunctionCall,
                "length" => Length,
                "stop" => Stop,
                "tool_calls" => ToolCalls,
                _ => new FinishReason(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "content_filter" => true,
            "function_call" => true,
            "length" => true,
            "stop" => true,
            "tool_calls" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(FinishReason other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FinishReason other && Equals(other);
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
        public static bool operator ==(FinishReason left, FinishReason right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(FinishReason left, FinishReason right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FinishReason value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FinishReason? ToEnum(string value)
        {
            return FinishReason.FromValue(value);
        }
    }
}