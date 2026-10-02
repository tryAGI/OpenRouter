
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// The status of a preset.<br/>
    /// Example: active
    /// </summary>
    public readonly partial struct PresetStatus : global::System.IEquatable<PresetStatus>
    {
        /// <summary>
        ///
        /// </summary>
        public PresetStatus(string value)
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
        public static PresetStatus Active { get; } = new("active");

        /// <summary>
        ///
        /// </summary>
        public static PresetStatus Archived { get; } = new("archived");

        /// <summary>
        ///
        /// </summary>
        public static PresetStatus Disabled { get; } = new("disabled");
        /// <summary>
        ///
        /// </summary>
        public static PresetStatus FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "active" => Active,
                "archived" => Archived,
                "disabled" => Disabled,
                _ => new PresetStatus(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "active" => true,
            "archived" => true,
            "disabled" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(PresetStatus other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PresetStatus other && Equals(other);
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
        public static bool operator ==(PresetStatus left, PresetStatus right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PresetStatus left, PresetStatus right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PresetStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PresetStatus value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PresetStatus? ToEnum(string value)
        {
            return PresetStatus.FromValue(value);
        }
    }
}