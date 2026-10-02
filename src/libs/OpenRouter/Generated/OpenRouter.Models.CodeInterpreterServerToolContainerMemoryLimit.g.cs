
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CodeInterpreterServerToolContainerMemoryLimit : global::System.IEquatable<CodeInterpreterServerToolContainerMemoryLimit>
    {
        /// <summary>
        ///
        /// </summary>
        public CodeInterpreterServerToolContainerMemoryLimit(string value)
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
        public static CodeInterpreterServerToolContainerMemoryLimit x16g { get; } = new("16g");

        /// <summary>
        ///
        /// </summary>
        public static CodeInterpreterServerToolContainerMemoryLimit x1g { get; } = new("1g");

        /// <summary>
        ///
        /// </summary>
        public static CodeInterpreterServerToolContainerMemoryLimit x4g { get; } = new("4g");

        /// <summary>
        ///
        /// </summary>
        public static CodeInterpreterServerToolContainerMemoryLimit x64g { get; } = new("64g");
        /// <summary>
        ///
        /// </summary>
        public static CodeInterpreterServerToolContainerMemoryLimit FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "16g" => x16g,
                "1g" => x1g,
                "4g" => x4g,
                "64g" => x64g,
                _ => new CodeInterpreterServerToolContainerMemoryLimit(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "16g" => true,
            "1g" => true,
            "4g" => true,
            "64g" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(CodeInterpreterServerToolContainerMemoryLimit other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CodeInterpreterServerToolContainerMemoryLimit other && Equals(other);
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
        public static bool operator ==(CodeInterpreterServerToolContainerMemoryLimit left, CodeInterpreterServerToolContainerMemoryLimit right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CodeInterpreterServerToolContainerMemoryLimit left, CodeInterpreterServerToolContainerMemoryLimit right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeInterpreterServerToolContainerMemoryLimitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeInterpreterServerToolContainerMemoryLimit value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeInterpreterServerToolContainerMemoryLimit? ToEnum(string value)
        {
            return CodeInterpreterServerToolContainerMemoryLimit.FromValue(value);
        }
    }
}