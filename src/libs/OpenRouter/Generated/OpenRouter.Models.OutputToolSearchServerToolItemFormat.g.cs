
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// How the model saw the matches. `compact` means each tool by name, description, and input shape, plus a call example. Replaying the item renders the same result.<br/>
    /// Example: compact
    /// </summary>
    public enum OutputToolSearchServerToolItemFormat
    {
        /// <summary>
        ///
        /// </summary>
        Compact,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputToolSearchServerToolItemFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputToolSearchServerToolItemFormat value)
        {
            return value switch
            {
                OutputToolSearchServerToolItemFormat.Compact => "compact",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputToolSearchServerToolItemFormat? ToEnum(string value)
        {
            return value switch
            {
                "compact" => OutputToolSearchServerToolItemFormat.Compact,
                _ => null,
            };
        }
    }
}