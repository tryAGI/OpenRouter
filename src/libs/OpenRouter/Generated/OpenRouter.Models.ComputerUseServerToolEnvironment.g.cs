
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ComputerUseServerToolEnvironment : global::System.IEquatable<ComputerUseServerToolEnvironment>
    {
        /// <summary>
        ///
        /// </summary>
        public ComputerUseServerToolEnvironment(string value)
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
        public static ComputerUseServerToolEnvironment Browser { get; } = new("browser");

        /// <summary>
        ///
        /// </summary>
        public static ComputerUseServerToolEnvironment Linux { get; } = new("linux");

        /// <summary>
        ///
        /// </summary>
        public static ComputerUseServerToolEnvironment Mac { get; } = new("mac");

        /// <summary>
        ///
        /// </summary>
        public static ComputerUseServerToolEnvironment Ubuntu { get; } = new("ubuntu");

        /// <summary>
        ///
        /// </summary>
        public static ComputerUseServerToolEnvironment Windows { get; } = new("windows");
        /// <summary>
        ///
        /// </summary>
        public static ComputerUseServerToolEnvironment FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "browser" => Browser,
                "linux" => Linux,
                "mac" => Mac,
                "ubuntu" => Ubuntu,
                "windows" => Windows,
                _ => new ComputerUseServerToolEnvironment(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "browser" => true,
            "linux" => true,
            "mac" => true,
            "ubuntu" => true,
            "windows" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ComputerUseServerToolEnvironment other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ComputerUseServerToolEnvironment other && Equals(other);
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
        public static bool operator ==(ComputerUseServerToolEnvironment left, ComputerUseServerToolEnvironment right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ComputerUseServerToolEnvironment left, ComputerUseServerToolEnvironment right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComputerUseServerToolEnvironmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComputerUseServerToolEnvironment value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComputerUseServerToolEnvironment? ToEnum(string value)
        {
            return ComputerUseServerToolEnvironment.FromValue(value);
        }
    }
}