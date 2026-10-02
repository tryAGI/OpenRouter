
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Sort direction. Only `asc` is supported by OpenRouter storage.<br/>
    /// Example: asc
    /// </summary>
    public readonly partial struct ListFilesOrder : global::System.IEquatable<ListFilesOrder>
    {
        /// <summary>
        ///
        /// </summary>
        public ListFilesOrder(string value)
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
        public static ListFilesOrder Asc { get; } = new("asc");

        /// <summary>
        ///
        /// </summary>
        public static ListFilesOrder Desc { get; } = new("desc");
        /// <summary>
        ///
        /// </summary>
        public static ListFilesOrder FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "asc" => Asc,
                "desc" => Desc,
                _ => new ListFilesOrder(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "asc" => true,
            "desc" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ListFilesOrder other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListFilesOrder other && Equals(other);
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
        public static bool operator ==(ListFilesOrder left, ListFilesOrder right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ListFilesOrder left, ListFilesOrder right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListFilesOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFilesOrder value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFilesOrder? ToEnum(string value)
        {
            return ListFilesOrder.FromValue(value);
        }
    }
}