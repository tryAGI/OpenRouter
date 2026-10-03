
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct OutputCapacityEntryV2Variant1Type : global::System.IEquatable<OutputCapacityEntryV2Variant1Type>
    {
        /// <summary>
        ///
        /// </summary>
        public OutputCapacityEntryV2Variant1Type(string value)
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
        public static OutputCapacityEntryV2Variant1Type Completion { get; } = new("completion");

        /// <summary>
        ///
        /// </summary>
        public static OutputCapacityEntryV2Variant1Type InternalReasoning { get; } = new("internal_reasoning");
        /// <summary>
        ///
        /// </summary>
        public static OutputCapacityEntryV2Variant1Type FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "completion" => Completion,
                "internal_reasoning" => InternalReasoning,
                _ => new OutputCapacityEntryV2Variant1Type(value),
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
        public bool Equals(OutputCapacityEntryV2Variant1Type other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputCapacityEntryV2Variant1Type other && Equals(other);
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
        public static bool operator ==(OutputCapacityEntryV2Variant1Type left, OutputCapacityEntryV2Variant1Type right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OutputCapacityEntryV2Variant1Type left, OutputCapacityEntryV2Variant1Type right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputCapacityEntryV2Variant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputCapacityEntryV2Variant1Type value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputCapacityEntryV2Variant1Type? ToEnum(string value)
        {
            return OutputCapacityEntryV2Variant1Type.FromValue(value);
        }
    }
}