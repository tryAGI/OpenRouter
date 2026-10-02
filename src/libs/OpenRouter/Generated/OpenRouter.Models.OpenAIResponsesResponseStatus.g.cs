
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: completed
    /// </summary>
    public readonly partial struct OpenAIResponsesResponseStatus : global::System.IEquatable<OpenAIResponsesResponseStatus>
    {
        /// <summary>
        ///
        /// </summary>
        public OpenAIResponsesResponseStatus(string value)
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
        public static OpenAIResponsesResponseStatus Cancelled { get; } = new("cancelled");

        /// <summary>
        ///
        /// </summary>
        public static OpenAIResponsesResponseStatus Completed { get; } = new("completed");

        /// <summary>
        ///
        /// </summary>
        public static OpenAIResponsesResponseStatus Failed { get; } = new("failed");

        /// <summary>
        ///
        /// </summary>
        public static OpenAIResponsesResponseStatus InProgress { get; } = new("in_progress");

        /// <summary>
        ///
        /// </summary>
        public static OpenAIResponsesResponseStatus Incomplete { get; } = new("incomplete");

        /// <summary>
        ///
        /// </summary>
        public static OpenAIResponsesResponseStatus Queued { get; } = new("queued");
        /// <summary>
        ///
        /// </summary>
        public static OpenAIResponsesResponseStatus FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "cancelled" => Cancelled,
                "completed" => Completed,
                "failed" => Failed,
                "in_progress" => InProgress,
                "incomplete" => Incomplete,
                "queued" => Queued,
                _ => new OpenAIResponsesResponseStatus(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "cancelled" => true,
            "completed" => true,
            "failed" => true,
            "in_progress" => true,
            "incomplete" => true,
            "queued" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(OpenAIResponsesResponseStatus other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OpenAIResponsesResponseStatus other && Equals(other);
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
        public static bool operator ==(OpenAIResponsesResponseStatus left, OpenAIResponsesResponseStatus right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OpenAIResponsesResponseStatus left, OpenAIResponsesResponseStatus right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIResponsesResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponsesResponseStatus value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponsesResponseStatus? ToEnum(string value)
        {
            return OpenAIResponsesResponseStatus.FromValue(value);
        }
    }
}