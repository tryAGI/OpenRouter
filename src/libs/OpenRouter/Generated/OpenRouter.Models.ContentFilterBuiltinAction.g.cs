
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Action taken when the builtin filter triggers<br/>
    /// Example: block
    /// </summary>
    public readonly partial struct ContentFilterBuiltinAction : global::System.IEquatable<ContentFilterBuiltinAction>
    {
        /// <summary>
        ///
        /// </summary>
        public ContentFilterBuiltinAction(string value)
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
        public static ContentFilterBuiltinAction Block { get; } = new("block");

        /// <summary>
        ///
        /// </summary>
        public static ContentFilterBuiltinAction Flag { get; } = new("flag");

        /// <summary>
        ///
        /// </summary>
        public static ContentFilterBuiltinAction Redact { get; } = new("redact");
        /// <summary>
        ///
        /// </summary>
        public static ContentFilterBuiltinAction FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "block" => Block,
                "flag" => Flag,
                "redact" => Redact,
                _ => new ContentFilterBuiltinAction(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "block" => true,
            "flag" => true,
            "redact" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ContentFilterBuiltinAction other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentFilterBuiltinAction other && Equals(other);
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
        public static bool operator ==(ContentFilterBuiltinAction left, ContentFilterBuiltinAction right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ContentFilterBuiltinAction left, ContentFilterBuiltinAction right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentFilterBuiltinActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentFilterBuiltinAction value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentFilterBuiltinAction? ToEnum(string value)
        {
            return ContentFilterBuiltinAction.FromValue(value);
        }
    }
}