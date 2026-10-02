
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesRequestContextManagementEditVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Compact20260112,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestContextManagementEditVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestContextManagementEditVariant3Type value)
        {
            return value switch
            {
                MessagesRequestContextManagementEditVariant3Type.Compact20260112 => "compact_20260112",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestContextManagementEditVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "compact_20260112" => MessagesRequestContextManagementEditVariant3Type.Compact20260112,
                _ => null,
            };
        }
    }
}