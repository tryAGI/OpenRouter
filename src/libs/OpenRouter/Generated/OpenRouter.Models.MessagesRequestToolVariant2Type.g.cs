
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesRequestToolVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Bash20250124,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestToolVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestToolVariant2Type value)
        {
            return value switch
            {
                MessagesRequestToolVariant2Type.Bash20250124 => "bash_20250124",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestToolVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "bash_20250124" => MessagesRequestToolVariant2Type.Bash20250124,
                _ => null,
            };
        }
    }
}