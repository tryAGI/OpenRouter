
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct InternConnectionStatusState : global::System.IEquatable<InternConnectionStatusState>
    {
        /// <summary>
        ///
        /// </summary>
        public InternConnectionStatusState(string value)
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
        public static InternConnectionStatusState Connected { get; } = new("connected");

        /// <summary>
        ///
        /// </summary>
        public static InternConnectionStatusState Error { get; } = new("error");

        /// <summary>
        ///
        /// </summary>
        public static InternConnectionStatusState NeedsReconnect { get; } = new("needs_reconnect");

        /// <summary>
        ///
        /// </summary>
        public static InternConnectionStatusState NotTested { get; } = new("not_tested");
        /// <summary>
        ///
        /// </summary>
        public static InternConnectionStatusState FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "connected" => Connected,
                "error" => Error,
                "needs_reconnect" => NeedsReconnect,
                "not_tested" => NotTested,
                _ => new InternConnectionStatusState(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "connected" => true,
            "error" => true,
            "needs_reconnect" => true,
            "not_tested" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(InternConnectionStatusState other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InternConnectionStatusState other && Equals(other);
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
        public static bool operator ==(InternConnectionStatusState left, InternConnectionStatusState right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InternConnectionStatusState left, InternConnectionStatusState right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InternConnectionStatusStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InternConnectionStatusState value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InternConnectionStatusState? ToEnum(string value)
        {
            return InternConnectionStatusState.FromValue(value);
        }
    }
}