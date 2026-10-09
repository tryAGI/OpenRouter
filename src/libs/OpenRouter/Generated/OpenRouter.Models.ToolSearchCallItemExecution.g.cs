
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ToolSearchCallItemExecution : global::System.IEquatable<ToolSearchCallItemExecution>
    {
        /// <summary>
        ///
        /// </summary>
        public ToolSearchCallItemExecution(string value)
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
        public static ToolSearchCallItemExecution Client { get; } = new("client");

        /// <summary>
        ///
        /// </summary>
        public static ToolSearchCallItemExecution Server { get; } = new("server");
        /// <summary>
        ///
        /// </summary>
        public static ToolSearchCallItemExecution FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "client" => Client,
                "server" => Server,
                _ => new ToolSearchCallItemExecution(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "client" => true,
            "server" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ToolSearchCallItemExecution other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolSearchCallItemExecution other && Equals(other);
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
        public static bool operator ==(ToolSearchCallItemExecution left, ToolSearchCallItemExecution right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ToolSearchCallItemExecution left, ToolSearchCallItemExecution right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolSearchCallItemExecutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolSearchCallItemExecution value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolSearchCallItemExecution? ToEnum(string value)
        {
            return ToolSearchCallItemExecution.FromValue(value);
        }
    }
}