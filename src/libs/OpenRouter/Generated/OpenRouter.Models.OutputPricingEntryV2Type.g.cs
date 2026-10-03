
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct OutputPricingEntryV2Type : global::System.IEquatable<OutputPricingEntryV2Type>
    {
        /// <summary>
        ///
        /// </summary>
        public OutputPricingEntryV2Type(string value)
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
        public static OutputPricingEntryV2Type Completion { get; } = new("completion");

        /// <summary>
        ///
        /// </summary>
        public static OutputPricingEntryV2Type InternalReasoning { get; } = new("internal_reasoning");
        /// <summary>
        ///
        /// </summary>
        public static OutputPricingEntryV2Type FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "completion" => Completion,
                "internal_reasoning" => InternalReasoning,
                _ => new OutputPricingEntryV2Type(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "completion" => true,
            "internal_reasoning" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(OutputPricingEntryV2Type other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputPricingEntryV2Type other && Equals(other);
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
        public static bool operator ==(OutputPricingEntryV2Type left, OutputPricingEntryV2Type right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OutputPricingEntryV2Type left, OutputPricingEntryV2Type right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputPricingEntryV2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputPricingEntryV2Type value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputPricingEntryV2Type? ToEnum(string value)
        {
            return OutputPricingEntryV2Type.FromValue(value);
        }
    }
}