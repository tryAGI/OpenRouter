
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesRequestContextManagementEditVariant2KeepEnum2
    {
        /// <summary>
        ///
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestContextManagementEditVariant2KeepEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestContextManagementEditVariant2KeepEnum2 value)
        {
            return value switch
            {
                MessagesRequestContextManagementEditVariant2KeepEnum2.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestContextManagementEditVariant2KeepEnum2? ToEnum(string value)
        {
            return value switch
            {
                "all" => MessagesRequestContextManagementEditVariant2KeepEnum2.All,
                _ => null,
            };
        }
    }
}