
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Action taken when the pattern matches<br/>
    /// Example: block
    /// </summary>
    public readonly partial struct ContentFilterAction : global::System.IEquatable<ContentFilterAction>
    {
        /// <summary>
        ///
        /// </summary>
        public ContentFilterAction(string value)
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
        public static ContentFilterAction Block { get; } = new("block");

        /// <summary>
        ///
        /// </summary>
        public static ContentFilterAction Flag { get; } = new("flag");

        /// <summary>
        ///
        /// </summary>
        public static ContentFilterAction Redact { get; } = new("redact");
        /// <summary>
        ///
        /// </summary>
        public static ContentFilterAction FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "block" => Block,
                "flag" => Flag,
                "redact" => Redact,
                _ => new ContentFilterAction(value),
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
        public bool Equals(ContentFilterAction other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentFilterAction other && Equals(other);
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
        public static bool operator ==(ContentFilterAction left, ContentFilterAction right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ContentFilterAction left, ContentFilterAction right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentFilterActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentFilterAction value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentFilterAction? ToEnum(string value)
        {
            return ContentFilterAction.FromValue(value);
        }
    }
}