
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesRequestToolVariant2Name
    {
        /// <summary>
        ///
        /// </summary>
        Bash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestToolVariant2NameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestToolVariant2Name value)
        {
            return value switch
            {
                MessagesRequestToolVariant2Name.Bash => "bash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestToolVariant2Name? ToEnum(string value)
        {
            return value switch
            {
                "bash" => MessagesRequestToolVariant2Name.Bash,
                _ => null,
            };
        }
    }
}