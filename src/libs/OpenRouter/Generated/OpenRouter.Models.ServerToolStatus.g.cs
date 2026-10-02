
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: active
    /// </summary>
    public readonly partial struct ServerToolStatus : global::System.IEquatable<ServerToolStatus>
    {
        /// <summary>
        ///
        /// </summary>
        public ServerToolStatus(string value)
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
        public static ServerToolStatus Active { get; } = new("active");

        /// <summary>
        ///
        /// </summary>
        public static ServerToolStatus Deprecated { get; } = new("deprecated");
        /// <summary>
        ///
        /// </summary>
        public static ServerToolStatus FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "active" => Active,
                "deprecated" => Deprecated,
                _ => new ServerToolStatus(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "active" => true,
            "deprecated" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ServerToolStatus other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ServerToolStatus other && Equals(other);
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
        public static bool operator ==(ServerToolStatus left, ServerToolStatus right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ServerToolStatus left, ServerToolStatus right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerToolStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerToolStatus value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerToolStatus? ToEnum(string value)
        {
            return ServerToolStatus.FromValue(value);
        }
    }
}