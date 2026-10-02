
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AnthropicTextEditorCodeExecutionViewResultFileType : global::System.IEquatable<AnthropicTextEditorCodeExecutionViewResultFileType>
    {
        /// <summary>
        ///
        /// </summary>
        public AnthropicTextEditorCodeExecutionViewResultFileType(string value)
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
        public static AnthropicTextEditorCodeExecutionViewResultFileType Image { get; } = new("image");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicTextEditorCodeExecutionViewResultFileType Pdf { get; } = new("pdf");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicTextEditorCodeExecutionViewResultFileType Text { get; } = new("text");
        /// <summary>
        ///
        /// </summary>
        public static AnthropicTextEditorCodeExecutionViewResultFileType FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "image" => Image,
                "pdf" => Pdf,
                "text" => Text,
                _ => new AnthropicTextEditorCodeExecutionViewResultFileType(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "image" => true,
            "pdf" => true,
            "text" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AnthropicTextEditorCodeExecutionViewResultFileType other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicTextEditorCodeExecutionViewResultFileType other && Equals(other);
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
        public static bool operator ==(AnthropicTextEditorCodeExecutionViewResultFileType left, AnthropicTextEditorCodeExecutionViewResultFileType right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicTextEditorCodeExecutionViewResultFileType left, AnthropicTextEditorCodeExecutionViewResultFileType right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicTextEditorCodeExecutionViewResultFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicTextEditorCodeExecutionViewResultFileType value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicTextEditorCodeExecutionViewResultFileType? ToEnum(string value)
        {
            return AnthropicTextEditorCodeExecutionViewResultFileType.FromValue(value);
        }
    }
}