
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestToolsItemsOneOf5Type
    {
        /// <summary>
        /// 
        /// </summary>
        Advisor20260301,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestToolsItemsOneOf5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestToolsItemsOneOf5Type value)
        {
            return value switch
            {
                MessagesRequestToolsItemsOneOf5Type.Advisor20260301 => "advisor_20260301",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestToolsItemsOneOf5Type? ToEnum(string value)
        {
            return value switch
            {
                "advisor_20260301" => MessagesRequestToolsItemsOneOf5Type.Advisor20260301,
                _ => null,
            };
        }
    }
}