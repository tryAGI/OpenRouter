
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct InputImageDetail : global::System.IEquatable<InputImageDetail>
    {
        /// <summary>
        ///
        /// </summary>
        public InputImageDetail(string value)
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
        public static InputImageDetail Auto { get; } = new("auto");

        /// <summary>
        ///
        /// </summary>
        public static InputImageDetail High { get; } = new("high");

        /// <summary>
        ///
        /// </summary>
        public static InputImageDetail Low { get; } = new("low");

        /// <summary>
        ///
        /// </summary>
        public static InputImageDetail Original { get; } = new("original");
        /// <summary>
        ///
        /// </summary>
        public static InputImageDetail FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "auto" => Auto,
                "high" => High,
                "low" => Low,
                "original" => Original,
                _ => new InputImageDetail(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "auto" => true,
            "high" => true,
            "low" => true,
            "original" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(InputImageDetail other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputImageDetail other && Equals(other);
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
        public static bool operator ==(InputImageDetail left, InputImageDetail right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InputImageDetail left, InputImageDetail right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputImageDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputImageDetail value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputImageDetail? ToEnum(string value)
        {
            return InputImageDetail.FromValue(value);
        }
    }
}