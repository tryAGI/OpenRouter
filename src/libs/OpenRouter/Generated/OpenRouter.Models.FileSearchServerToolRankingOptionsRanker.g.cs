
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct FileSearchServerToolRankingOptionsRanker : global::System.IEquatable<FileSearchServerToolRankingOptionsRanker>
    {
        /// <summary>
        ///
        /// </summary>
        public FileSearchServerToolRankingOptionsRanker(string value)
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
        public static FileSearchServerToolRankingOptionsRanker Auto { get; } = new("auto");

        /// <summary>
        ///
        /// </summary>
        public static FileSearchServerToolRankingOptionsRanker Default20241115 { get; } = new("default-2024-11-15");
        /// <summary>
        ///
        /// </summary>
        public static FileSearchServerToolRankingOptionsRanker FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "auto" => Auto,
                "default-2024-11-15" => Default20241115,
                _ => new FileSearchServerToolRankingOptionsRanker(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "auto" => true,
            "default-2024-11-15" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(FileSearchServerToolRankingOptionsRanker other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FileSearchServerToolRankingOptionsRanker other && Equals(other);
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
        public static bool operator ==(FileSearchServerToolRankingOptionsRanker left, FileSearchServerToolRankingOptionsRanker right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(FileSearchServerToolRankingOptionsRanker left, FileSearchServerToolRankingOptionsRanker right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileSearchServerToolRankingOptionsRankerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileSearchServerToolRankingOptionsRanker value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileSearchServerToolRankingOptionsRanker? ToEnum(string value)
        {
            return FileSearchServerToolRankingOptionsRanker.FromValue(value);
        }
    }
}