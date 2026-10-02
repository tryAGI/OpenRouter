
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CustomToolFormatVariant2Syntax : global::System.IEquatable<CustomToolFormatVariant2Syntax>
    {
        /// <summary>
        ///
        /// </summary>
        public CustomToolFormatVariant2Syntax(string value)
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
        public static CustomToolFormatVariant2Syntax Lark { get; } = new("lark");

        /// <summary>
        ///
        /// </summary>
        public static CustomToolFormatVariant2Syntax Regex { get; } = new("regex");
        /// <summary>
        ///
        /// </summary>
        public static CustomToolFormatVariant2Syntax FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "lark" => Lark,
                "regex" => Regex,
                _ => new CustomToolFormatVariant2Syntax(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "lark" => true,
            "regex" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(CustomToolFormatVariant2Syntax other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CustomToolFormatVariant2Syntax other && Equals(other);
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
        public static bool operator ==(CustomToolFormatVariant2Syntax left, CustomToolFormatVariant2Syntax right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CustomToolFormatVariant2Syntax left, CustomToolFormatVariant2Syntax right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomToolFormatVariant2SyntaxExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomToolFormatVariant2Syntax value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomToolFormatVariant2Syntax? ToEnum(string value)
        {
            return CustomToolFormatVariant2Syntax.FromValue(value);
        }
    }
}