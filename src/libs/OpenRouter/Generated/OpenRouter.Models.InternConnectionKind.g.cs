
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct InternConnectionKind : global::System.IEquatable<InternConnectionKind>
    {
        /// <summary>
        ///
        /// </summary>
        public InternConnectionKind(string value)
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
        public static InternConnectionKind Github { get; } = new("github");

        /// <summary>
        ///
        /// </summary>
        public static InternConnectionKind Google { get; } = new("google");

        /// <summary>
        ///
        /// </summary>
        public static InternConnectionKind Mcp { get; } = new("mcp");

        /// <summary>
        ///
        /// </summary>
        public static InternConnectionKind Slack { get; } = new("slack");
        /// <summary>
        ///
        /// </summary>
        public static InternConnectionKind FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "github" => Github,
                "google" => Google,
                "mcp" => Mcp,
                "slack" => Slack,
                _ => new InternConnectionKind(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "github" => true,
            "google" => true,
            "mcp" => true,
            "slack" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(InternConnectionKind other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InternConnectionKind other && Equals(other);
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
        public static bool operator ==(InternConnectionKind left, InternConnectionKind right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InternConnectionKind left, InternConnectionKind right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InternConnectionKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InternConnectionKind value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InternConnectionKind? ToEnum(string value)
        {
            return InternConnectionKind.FromValue(value);
        }
    }
}