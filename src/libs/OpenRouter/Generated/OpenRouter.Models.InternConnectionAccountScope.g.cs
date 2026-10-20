
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// `workspace` for a shared connection, `yours` for the key user's personal account, `shared` for a teammate's.
    /// </summary>
    public readonly partial struct InternConnectionAccountScope : global::System.IEquatable<InternConnectionAccountScope>
    {
        /// <summary>
        ///
        /// </summary>
        public InternConnectionAccountScope(string value)
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
        public static InternConnectionAccountScope Shared { get; } = new("shared");

        /// <summary>
        ///
        /// </summary>
        public static InternConnectionAccountScope Workspace { get; } = new("workspace");

        /// <summary>
        ///
        /// </summary>
        public static InternConnectionAccountScope Yours { get; } = new("yours");
        /// <summary>
        ///
        /// </summary>
        public static InternConnectionAccountScope FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "shared" => Shared,
                "workspace" => Workspace,
                "yours" => Yours,
                _ => new InternConnectionAccountScope(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "shared" => true,
            "workspace" => true,
            "yours" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(InternConnectionAccountScope other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InternConnectionAccountScope other && Equals(other);
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
        public static bool operator ==(InternConnectionAccountScope left, InternConnectionAccountScope right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InternConnectionAccountScope left, InternConnectionAccountScope right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InternConnectionAccountScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InternConnectionAccountScope value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InternConnectionAccountScope? ToEnum(string value)
        {
            return InternConnectionAccountScope.FromValue(value);
        }
    }
}