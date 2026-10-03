
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ParameterDescriptorV2Type : global::System.IEquatable<ParameterDescriptorV2Type>
    {
        /// <summary>
        ///
        /// </summary>
        public ParameterDescriptorV2Type(string value)
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
        public static ParameterDescriptorV2Type Array { get; } = new("array");

        /// <summary>
        ///
        /// </summary>
        public static ParameterDescriptorV2Type Boolean { get; } = new("boolean");

        /// <summary>
        ///
        /// </summary>
        public static ParameterDescriptorV2Type Enum { get; } = new("enum");

        /// <summary>
        ///
        /// </summary>
        public static ParameterDescriptorV2Type Integer { get; } = new("integer");

        /// <summary>
        ///
        /// </summary>
        public static ParameterDescriptorV2Type Object { get; } = new("object");

        /// <summary>
        ///
        /// </summary>
        public static ParameterDescriptorV2Type Range { get; } = new("range");

        /// <summary>
        ///
        /// </summary>
        public static ParameterDescriptorV2Type Unknown { get; } = new("unknown");
        /// <summary>
        ///
        /// </summary>
        public static ParameterDescriptorV2Type FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "array" => Array,
                "boolean" => Boolean,
                "enum" => Enum,
                "integer" => Integer,
                "object" => Object,
                "range" => Range,
                "unknown" => Unknown,
                _ => new ParameterDescriptorV2Type(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "array" => true,
            "boolean" => true,
            "enum" => true,
            "integer" => true,
            "object" => true,
            "range" => true,
            "unknown" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ParameterDescriptorV2Type other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ParameterDescriptorV2Type other && Equals(other);
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
        public static bool operator ==(ParameterDescriptorV2Type left, ParameterDescriptorV2Type right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ParameterDescriptorV2Type left, ParameterDescriptorV2Type right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParameterDescriptorV2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParameterDescriptorV2Type value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParameterDescriptorV2Type? ToEnum(string value)
        {
            return ParameterDescriptorV2Type.FromValue(value);
        }
    }
}