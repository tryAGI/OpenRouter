
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesMessageParamContentOneOf1ItemsOneOf10Type
    {
        /// <summary>
        /// 
        /// </summary>
        Compaction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentOneOf1ItemsOneOf10TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentOneOf1ItemsOneOf10Type value)
        {
            return value switch
            {
                MessagesMessageParamContentOneOf1ItemsOneOf10Type.Compaction => "compaction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf10Type? ToEnum(string value)
        {
            return value switch
            {
                "compaction" => MessagesMessageParamContentOneOf1ItemsOneOf10Type.Compaction,
                _ => null,
            };
        }
    }
}