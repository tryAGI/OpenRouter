
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ToolSearchOutputItemExecution : global::System.IEquatable<ToolSearchOutputItemExecution>
    {
        /// <summary>
        ///
        /// </summary>
        public ToolSearchOutputItemExecution(string value)
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
        public static ToolSearchOutputItemExecution Client { get; } = new("client");

        /// <summary>
        ///
        /// </summary>
        public static ToolSearchOutputItemExecution Server { get; } = new("server");
        /// <summary>
        ///
        /// </summary>
        public static ToolSearchOutputItemExecution FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "client" => Client,
                "server" => Server,
                _ => new ToolSearchOutputItemExecution(value),
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
        public bool Equals(ToolSearchOutputItemExecution other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolSearchOutputItemExecution other && Equals(other);
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
        public static bool operator ==(ToolSearchOutputItemExecution left, ToolSearchOutputItemExecution right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ToolSearchOutputItemExecution left, ToolSearchOutputItemExecution right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolSearchOutputItemExecutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolSearchOutputItemExecution value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolSearchOutputItemExecution? ToEnum(string value)
        {
            return ToolSearchOutputItemExecution.FromValue(value);
        }
    }
}