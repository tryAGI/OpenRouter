
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// The category of feedback being reported<br/>
    /// Example: incorrect_response
    /// </summary>
    public readonly partial struct SubmitGenerationFeedbackRequestCategory : global::System.IEquatable<SubmitGenerationFeedbackRequestCategory>
    {
        /// <summary>
        ///
        /// </summary>
        public SubmitGenerationFeedbackRequestCategory(string value)
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
        public static SubmitGenerationFeedbackRequestCategory ApiError { get; } = new("api_error");

        /// <summary>
        ///
        /// </summary>
        public static SubmitGenerationFeedbackRequestCategory Billing { get; } = new("billing");

        /// <summary>
        ///
        /// </summary>
        public static SubmitGenerationFeedbackRequestCategory Formatting { get; } = new("formatting");

        /// <summary>
        ///
        /// </summary>
        public static SubmitGenerationFeedbackRequestCategory Incoherence { get; } = new("incoherence");

        /// <summary>
        ///
        /// </summary>
        public static SubmitGenerationFeedbackRequestCategory IncorrectResponse { get; } = new("incorrect_response");

        /// <summary>
        ///
        /// </summary>
        public static SubmitGenerationFeedbackRequestCategory Latency { get; } = new("latency");

        /// <summary>
        ///
        /// </summary>
        public static SubmitGenerationFeedbackRequestCategory Other { get; } = new("other");
        /// <summary>
        ///
        /// </summary>
        public static SubmitGenerationFeedbackRequestCategory FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "api_error" => ApiError,
                "billing" => Billing,
                "formatting" => Formatting,
                "incoherence" => Incoherence,
                "incorrect_response" => IncorrectResponse,
                "latency" => Latency,
                "other" => Other,
                _ => new SubmitGenerationFeedbackRequestCategory(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "api_error" => true,
            "billing" => true,
            "formatting" => true,
            "incoherence" => true,
            "incorrect_response" => true,
            "latency" => true,
            "other" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(SubmitGenerationFeedbackRequestCategory other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SubmitGenerationFeedbackRequestCategory other && Equals(other);
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
        public static bool operator ==(SubmitGenerationFeedbackRequestCategory left, SubmitGenerationFeedbackRequestCategory right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SubmitGenerationFeedbackRequestCategory left, SubmitGenerationFeedbackRequestCategory right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubmitGenerationFeedbackRequestCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubmitGenerationFeedbackRequestCategory value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubmitGenerationFeedbackRequestCategory? ToEnum(string value)
        {
            return SubmitGenerationFeedbackRequestCategory.FromValue(value);
        }
    }
}