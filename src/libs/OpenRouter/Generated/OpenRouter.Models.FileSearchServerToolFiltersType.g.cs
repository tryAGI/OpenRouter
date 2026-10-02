
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct FileSearchServerToolFiltersType : global::System.IEquatable<FileSearchServerToolFiltersType>
    {
        /// <summary>
        ///
        /// </summary>
        public FileSearchServerToolFiltersType(string value)
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
        public static FileSearchServerToolFiltersType Eq { get; } = new("eq");

        /// <summary>
        ///
        /// </summary>
        public static FileSearchServerToolFiltersType Gt { get; } = new("gt");

        /// <summary>
        ///
        /// </summary>
        public static FileSearchServerToolFiltersType Gte { get; } = new("gte");

        /// <summary>
        ///
        /// </summary>
        public static FileSearchServerToolFiltersType Lt { get; } = new("lt");

        /// <summary>
        ///
        /// </summary>
        public static FileSearchServerToolFiltersType Lte { get; } = new("lte");

        /// <summary>
        ///
        /// </summary>
        public static FileSearchServerToolFiltersType Ne { get; } = new("ne");
        /// <summary>
        ///
        /// </summary>
        public static FileSearchServerToolFiltersType FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "eq" => Eq,
                "gt" => Gt,
                "gte" => Gte,
                "lt" => Lt,
                "lte" => Lte,
                "ne" => Ne,
                _ => new FileSearchServerToolFiltersType(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "eq" => true,
            "gt" => true,
            "gte" => true,
            "lt" => true,
            "lte" => true,
            "ne" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(FileSearchServerToolFiltersType other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FileSearchServerToolFiltersType other && Equals(other);
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
        public static bool operator ==(FileSearchServerToolFiltersType left, FileSearchServerToolFiltersType right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(FileSearchServerToolFiltersType left, FileSearchServerToolFiltersType right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileSearchServerToolFiltersTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileSearchServerToolFiltersType value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileSearchServerToolFiltersType? ToEnum(string value)
        {
            return FileSearchServerToolFiltersType.FromValue(value);
        }
    }
}