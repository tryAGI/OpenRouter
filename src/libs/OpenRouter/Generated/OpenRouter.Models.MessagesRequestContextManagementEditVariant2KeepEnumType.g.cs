
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesRequestContextManagementEditVariant2KeepEnumType
    {
        /// <summary>
        ///
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestContextManagementEditVariant2KeepEnumTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestContextManagementEditVariant2KeepEnumType value)
        {
            return value switch
            {
                MessagesRequestContextManagementEditVariant2KeepEnumType.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestContextManagementEditVariant2KeepEnumType? ToEnum(string value)
        {
            return value switch
            {
                "all" => MessagesRequestContextManagementEditVariant2KeepEnumType.All,
                _ => null,
            };
        }
    }
}