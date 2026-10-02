
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesMessageParamContentVariant2ItemVariant5ContentVariant2ItemType
    {
        /// <summary>
        ///
        /// </summary>
        ToolReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentVariant2ItemVariant5ContentVariant2ItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentVariant2ItemVariant5ContentVariant2ItemType value)
        {
            return value switch
            {
                MessagesMessageParamContentVariant2ItemVariant5ContentVariant2ItemType.ToolReference => "tool_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentVariant2ItemVariant5ContentVariant2ItemType? ToEnum(string value)
        {
            return value switch
            {
                "tool_reference" => MessagesMessageParamContentVariant2ItemVariant5ContentVariant2ItemType.ToolReference,
                _ => null,
            };
        }
    }
}