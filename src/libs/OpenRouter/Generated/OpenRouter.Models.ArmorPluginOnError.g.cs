
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// When the classifier cannot answer (timeout, upstream error, context too long) the call is reported `unavailable`; `block` rejects it and `log` releases it. Default `block`.
    /// </summary>
    public readonly partial struct ArmorPluginOnError : global::System.IEquatable<ArmorPluginOnError>
    {
        /// <summary>
        ///
        /// </summary>
        public ArmorPluginOnError(string value)
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
        public static ArmorPluginOnError Block { get; } = new("block");

        /// <summary>
        ///
        /// </summary>
        public static ArmorPluginOnError Log { get; } = new("log");
        /// <summary>
        ///
        /// </summary>
        public static ArmorPluginOnError FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "block" => Block,
                "log" => Log,
                _ => new ArmorPluginOnError(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "block" => true,
            "log" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ArmorPluginOnError other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ArmorPluginOnError other && Equals(other);
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
        public static bool operator ==(ArmorPluginOnError left, ArmorPluginOnError right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ArmorPluginOnError left, ArmorPluginOnError right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ArmorPluginOnErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArmorPluginOnError value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArmorPluginOnError? ToEnum(string value)
        {
            return ArmorPluginOnError.FromValue(value);
        }
    }
}