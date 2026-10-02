
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncompleteDetailsReason : global::System.IEquatable<IncompleteDetailsReason>
    {
        /// <summary>
        ///
        /// </summary>
        public IncompleteDetailsReason(string value)
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
        public static IncompleteDetailsReason ContentFilter { get; } = new("content_filter");

        /// <summary>
        ///
        /// </summary>
        public static IncompleteDetailsReason MaxOutputTokens { get; } = new("max_output_tokens");
        /// <summary>
        ///
        /// </summary>
        public static IncompleteDetailsReason FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "content_filter" => ContentFilter,
                "max_output_tokens" => MaxOutputTokens,
                _ => new IncompleteDetailsReason(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "content_filter" => true,
            "max_output_tokens" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(IncompleteDetailsReason other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncompleteDetailsReason other && Equals(other);
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
        public static bool operator ==(IncompleteDetailsReason left, IncompleteDetailsReason right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncompleteDetailsReason left, IncompleteDetailsReason right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IncompleteDetailsReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IncompleteDetailsReason value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IncompleteDetailsReason? ToEnum(string value)
        {
            return IncompleteDetailsReason.FromValue(value);
        }
    }
}