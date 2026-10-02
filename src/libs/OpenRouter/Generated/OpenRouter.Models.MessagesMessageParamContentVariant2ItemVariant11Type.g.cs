
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesMessageParamContentVariant2ItemVariant11Type
    {
        /// <summary>
        ///
        /// </summary>
        Compaction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentVariant2ItemVariant11TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentVariant2ItemVariant11Type value)
        {
            return value switch
            {
                MessagesMessageParamContentVariant2ItemVariant11Type.Compaction => "compaction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentVariant2ItemVariant11Type? ToEnum(string value)
        {
            return value switch
            {
                "compaction" => MessagesMessageParamContentVariant2ItemVariant11Type.Compaction,
                _ => null,
            };
        }
    }
}