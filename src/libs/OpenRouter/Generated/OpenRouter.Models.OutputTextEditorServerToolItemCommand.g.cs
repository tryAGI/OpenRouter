
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct OutputTextEditorServerToolItemCommand : global::System.IEquatable<OutputTextEditorServerToolItemCommand>
    {
        /// <summary>
        ///
        /// </summary>
        public OutputTextEditorServerToolItemCommand(string value)
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
        public static OutputTextEditorServerToolItemCommand Create { get; } = new("create");

        /// <summary>
        ///
        /// </summary>
        public static OutputTextEditorServerToolItemCommand Insert { get; } = new("insert");

        /// <summary>
        ///
        /// </summary>
        public static OutputTextEditorServerToolItemCommand StrReplace { get; } = new("str_replace");

        /// <summary>
        ///
        /// </summary>
        public static OutputTextEditorServerToolItemCommand View { get; } = new("view");
        /// <summary>
        ///
        /// </summary>
        public static OutputTextEditorServerToolItemCommand FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "create" => Create,
                "insert" => Insert,
                "str_replace" => StrReplace,
                "view" => View,
                _ => new OutputTextEditorServerToolItemCommand(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "create" => true,
            "insert" => true,
            "str_replace" => true,
            "view" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(OutputTextEditorServerToolItemCommand other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputTextEditorServerToolItemCommand other && Equals(other);
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
        public static bool operator ==(OutputTextEditorServerToolItemCommand left, OutputTextEditorServerToolItemCommand right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OutputTextEditorServerToolItemCommand left, OutputTextEditorServerToolItemCommand right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputTextEditorServerToolItemCommandExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputTextEditorServerToolItemCommand value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputTextEditorServerToolItemCommand? ToEnum(string value)
        {
            return OutputTextEditorServerToolItemCommand.FromValue(value);
        }
    }
}