
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Store or read this file on the named provider using your own API key for it. Omit to use OpenRouter storage.<br/>
    /// Example: openai
    /// </summary>
    public readonly partial struct FileProvider : global::System.IEquatable<FileProvider>
    {
        /// <summary>
        ///
        /// </summary>
        public FileProvider(string value)
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
        public static FileProvider Anthropic { get; } = new("anthropic");

        /// <summary>
        ///
        /// </summary>
        public static FileProvider Openai { get; } = new("openai");
        /// <summary>
        ///
        /// </summary>
        public static FileProvider FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "anthropic" => Anthropic,
                "openai" => Openai,
                _ => new FileProvider(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "anthropic" => true,
            "openai" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(FileProvider other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FileProvider other && Equals(other);
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
        public static bool operator ==(FileProvider left, FileProvider right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(FileProvider left, FileProvider right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileProvider value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileProvider? ToEnum(string value)
        {
            return FileProvider.FromValue(value);
        }
    }
}